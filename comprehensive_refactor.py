#!/usr/bin/env python3
"""
Comprehensive refactoring script to rename obfuscated names to meaningful names.
This script processes all .cs files and renames:
1. Field variables based on their .Name property assignment
2. Methods based on their functionality
3. Updates all references throughout the codebase
"""
import os
import re
from pathlib import Path
from collections import defaultdict

workspace = "/workspace"

def extract_field_name_mapping(content):
    """Extract mapping from obfuscated field names to meaningful names based on .Name assignments."""
    field_mapping = {}
    
    # Pattern: variable.Name = "MeaningfulName";
    # We need to find which variable gets which name
    for match in re.finditer(r'(\w+_\d+)\.Name\s*=\s*"([^"]+)"', content):
        var_name = match.group(1)
        meaningful_name = match.group(2)
        
        # Convert meaningful name to C# field naming convention (lowercase first letter)
        if meaningful_name:
            # Convert to camelCase for field names
            field_name = meaningful_name[0].lower() + meaningful_name[1:] if len(meaningful_name) > 1 else meaningful_name.lower()
            # Remove any special characters
            field_name = re.sub(r'[^a-zA-Z0-9]', '', field_name)
            field_mapping[var_name] = field_name
    
    return field_mapping

def extract_method_mapping(content, class_name):
    """Extract method mappings based on their usage patterns."""
    method_mapping = {}
    
    # Find method declarations and analyze their content
    # Pattern for instance methods: void method_N(...) or Type method_N(...)
    method_declarations = list(re.finditer(
        r'(private|protected|public|internal)\s+(static\s+)?(?:override\s+)?([\w<>,\[\]]+)\s+(method|smethod)_(\d+)\s*\(',
        content
    ))
    
    for decl in method_declarations:
        method_type = decl.group(4)  # method or smethod
        method_num = decl.group(5)
        old_name = f"{method_type}_{method_num}"
        
        # Get context around the method to understand what it does
        start_pos = decl.end()
        # Find the method body
        brace_count = 0
        method_body_start = content.find('{', start_pos)
        if method_body_start == -1:
            continue
        
        brace_count = 1
        pos = method_body_start + 1
        while pos < len(content) and brace_count > 0:
            if content[pos] == '{':
                brace_count += 1
            elif content[pos] == '}':
                brace_count -= 1
            pos += 1
        
        method_body = content[method_body_start:pos]
        
        # Analyze method body to determine new name
        new_name = None
        
        # Check for DialogResult handling (method_8 typically)
        if 'DialogResult.OK' in method_body or 'DialogResult.Cancel' in method_body:
            if 'OK' in method_body:
                new_name = 'OnButtonOk'
            elif 'Cancel' in method_body:
                new_name = 'OnButtonCancel'
        
        # Check for help link handling (method_9 typically)
        if 'method_9' in old_name and ('String_12' in method_body or 'String_0' in method_body):
            new_name = 'OnOnlineHelp'
        
        # Check for InitializeComponent pattern
        if 'SuspendLayout()' in method_body or 'ResumeLayout(' in method_body:
            new_name = 'InitializeComponent'
        
        # Check for event handler registration
        if '.Click += ' in method_body or '.TextChanged += ' in method_body:
            new_name = 'InitializeHandlers'
        
        # Check for validation
        if 'Enabled = ' in method_body and ('Checked' in method_body or 'Text' in method_body):
            new_name = 'ValidateInput'
        
        # Check for load/initialization
        if 'Checked' in method_body and 'Enabled' in method_body and not new_name:
            new_name = 'OnLoad'
        
        if new_name:
            method_mapping[old_name] = new_name
    
    return method_mapping

def get_control_type_prefix(field_type):
    """Get appropriate prefix for control type."""
    type_mapping = {
        'Class66': 'btn',      # Button
        'Class62': 'lbl',      # Label  
        'Class63': 'hint',     # Hint label
        'Class61': 'chb',      # CheckBox
        'Class54': 'ed',       # Edit/TextBox
        'GClass3': 'lnk',      # Link
        'GControl0': 'separator',  # Separator line
        'PictureBox': 'img',   # Image
        'GClass0': 'lst',      # ListView
        'Class0': 'cb',        # ComboBox
        'Class65': 'gb',       # GroupBox
        'Class58': 'pnl',      # Panel
        'TextBox': 'txt',      # TextBox
        'Class67': 'toolStrip',
        'ToolStripButton': 'tsbtn',
    }
    return type_mapping.get(field_type, 'ctrl')

def process_file(cs_file):
    """Process a single file and perform renaming."""
    content = cs_file.read_text()
    original_content = content
    
    # Skip non-form/control files
    if 'base.Name =' not in content:
        return False, 0
    
    changes_made = 0
    
    # Step 1: Extract field name mappings
    field_mapping = extract_field_name_mapping(content)
    
    # Also map based on common patterns in form initialization
    # Look for patterns like: class66_0 = new Class66(); followed by .Name = "..."
    for match in re.finditer(r'(\w+)_\d+\s*=\s*new\s+(\w+)\(\);', content):
        var_base = match.group(1)
        var_type = match.group(2)
        
        # Find all variables of same base pattern
        for field_var in re.findall(rf'{var_base}_\d+', content):
            if field_var not in field_mapping:
                # Try to find its Name assignment
                name_match = re.search(rf'{field_var}\.Name\s*=\s*"([^"]+)"', content)
                if name_match:
                    meaningful = name_match.group(1)
                    field_name = meaningful[0].lower() + meaningful[1:] if len(meaningful) > 1 else meaningful.lower()
                    field_name = re.sub(r'[^a-zA-Z0-9]', '', field_name)
                    field_mapping[field_var] = field_name
    
    # Step 2: Extract method mappings
    class_match = re.search(r'class\s+(\w+)\s*:', content)
    class_name = class_match.group(1) if class_match else "Unknown"
    method_mapping = extract_method_mapping(content, class_name)
    
    # Apply field renamings (sorted by length descending to avoid partial replacements)
    for old_name, new_name in sorted(field_mapping.items(), key=lambda x: -len(x[0])):
        if old_name != new_name:
            # Replace field declarations
            content = re.sub(
                rf'\b(private|protected|public|internal)\s+(\w+)\s+{re.escape(old_name)};',
                rf'\1 \2 {new_name};',
                content
            )
            # Replace field usages (but not in string literals)
            # This is tricky - we need to be careful not to replace in strings
            content = re.sub(rf'\b{re.escape(old_name)}\b', new_name, content)
            changes_made += 1
    
    # Apply method renamings
    for old_name, new_name in sorted(method_mapping.items(), key=lambda x: -len(x[0])):
        if old_name != new_name:
            # Replace method declarations
            content = re.sub(
                rf'\b{re.escape(old_name)}\b',
                new_name,
                content
            )
            changes_made += 1
    
    if changes_made > 0:
        cs_file.write_text(content)
    
    return changes_made > 0, changes_made

# Main execution
print("=== Starting Comprehensive Refactoring ===\n")

total_files = 0
total_changes = 0

for cs_file in Path(workspace).glob("*.cs"):
    changed, changes = process_file(cs_file)
    if changed:
        total_files += 1
        total_changes += changes
        print(f"Updated {cs_file.name}: {changes} changes")

print(f"\n=== Summary ===")
print(f"Files modified: {total_files}")
print(f"Total renamings: {total_changes}")
