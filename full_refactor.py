#!/usr/bin/env python3
"""
Complete refactoring script to rename ALL obfuscated names to meaningful names.
This handles:
1. Field variables (class66_0 -> btnSave, etc.)
2. Methods (method_8 -> OnButtonOk, etc.)
3. All references throughout the codebase
4. Event handler method names
"""
import os
import re
from pathlib import Path

workspace = "/workspace"

def get_all_cs_files():
    """Get all C# files in workspace."""
    return list(Path(workspace).glob("*.cs"))

def extract_field_mappings(content):
    """Extract complete field name mappings from .Name assignments."""
    field_mapping = {}
    
    # Find all .Name = "..." assignments
    for match in re.finditer(r'(\w+_\d+)\.Name\s*=\s*"([^"]+)"', content):
        var_name = match.group(1)
        meaningful_name = match.group(2)
        
        if meaningful_name:
            # Convert to camelCase
            field_name = meaningful_name[0].lower() + meaningful_name[1:] if len(meaningful_name) > 1 else meaningful_name.lower()
            field_name = re.sub(r'[^a-zA-Z0-9]', '', field_name)
            field_mapping[var_name] = field_name
    
    return field_mapping

def analyze_and_rename_methods(content):
    """Analyze methods and rename them based on functionality."""
    changes = []
    
    # Find all method declarations with their bodies
    pattern = r'(private|protected|public|internal)\s+(static\s+)?(?:override\s+)?([\w<>,\[\]\s]+?)\s+(method|smethod)_(\d+)\s*\(([^)]*)\)'
    
    for match in re.finditer(pattern, content):
        access = match.group(1)
        static_kw = match.group(2) or ''
        return_type = match.group(3).strip()
        method_type = match.group(4)
        method_num = match.group(5)
        params_str = match.group(6)
        
        old_name = f"{method_type}_{method_num}"
        
        # Find method body
        start_pos = match.end()
        brace_start = content.find('{', start_pos)
        if brace_start == -1:
            continue
        
        brace_count = 1
        pos = brace_start + 1
        while pos < len(content) and brace_count > 0:
            if content[pos] == '{':
                brace_count += 1
            elif content[pos] == '}':
                brace_count -= 1
            pos += 1
        
        method_body = content[brace_start:pos]
        
        # Determine new name based on content
        new_name = None
        
        # DialogResult handling
        if 'DialogResult.OK' in method_body:
            new_name = 'OnButtonOk'
        elif 'DialogResult.Cancel' in method_body:
            new_name = 'OnButtonCancel'
        # Help link
        elif 'String_12' in method_body or ('String_0' in method_body and 'lnk' in content[max(0,match.start()-200):match.start()]):
            new_name = 'OnOnlineHelp'
        # InitializeComponent
        elif 'SuspendLayout()' in method_body or 'ResumeLayout(' in method_body:
            new_name = 'InitializeComponent'
        # Event registration
        elif '.Click +=' in method_body.replace(' ', '') or '.TextChanged +=' in method_body.replace(' ', ''):
            if 'Click' in method_body or 'TextChanged' in method_body:
                new_name = 'InitializeHandlers'
        # Validation
        elif 'Enabled = ' in method_body and ('Checked' in method_body or 'Text' in method_body):
            new_name = 'ValidateInput'
        # Load/initialization
        elif 'Checked' in method_body and 'Enabled' in method_body:
            new_name = 'OnLoad'
        
        if new_name and new_name != old_name:
            changes.append((old_name, new_name))
    
    return changes

def process_file(cs_file):
    """Process a single file completely."""
    content = cs_file.read_text()
    original_content = content
    
    # Skip non-form files
    if 'base.Name =' not in content:
        return False, 0
    
    total_changes = 0
    
    # Step 1: Get field mappings
    field_mapping = extract_field_mappings(content)
    
    # Also find fields by looking at initialization patterns
    for match in re.finditer(r'(\w+)_(\d+)\s*=\s*new\s+(\w+)\(\);', content):
        base = match.group(1)
        num = match.group(2)
        var_name = f"{base}_{num}"
        
        if var_name not in field_mapping:
            # Look for its Name assignment nearby
            search_start = match.end()
            search_end = min(search_start + 500, len(content))
            nearby = content[search_start:search_end]
            name_match = re.search(rf'{var_name}\.Name\s*=\s*"([^"]+)"', nearby)
            if name_match:
                meaningful = name_match.group(1)
                field_name = meaningful[0].lower() + meaningful[1:] if len(meaningful) > 1 else meaningful.lower()
                field_name = re.sub(r'[^a-zA-Z0-9]', '', field_name)
                field_mapping[var_name] = field_name
    
    # Step 2: Get method renamings
    method_renames = analyze_and_rename_methods(content)
    
    # Apply field renamings FIRST (before method renames might conflict)
    # Sort by length descending to avoid partial matches
    for old_name, new_name in sorted(field_mapping.items(), key=lambda x: -len(x[0])):
        if old_name != new_name:
            # Replace declaration
            content = re.sub(
                rf'\b(private|protected|public|internal)\s+(\w+)\s+{re.escape(old_name)};',
                rf'\1 \2 {new_name};',
                content
            )
            # Replace all usages
            content = re.sub(rf'\b{re.escape(old_name)}\b', new_name, content)
            total_changes += 1
    
    # Apply method renamings
    for old_name, new_name in sorted(method_renames, key=lambda x: -len(x[0])):
        if old_name != new_name:
            content = re.sub(rf'\b{re.escape(old_name)}\b', new_name, content)
            total_changes += 1
    
    if content != original_content:
        cs_file.write_text(content)
        return True, total_changes
    
    return False, 0

# Main execution
print("=== Complete Refactoring Pass ===\n")

total_files = 0
total_changes = 0

for cs_file in get_all_cs_files():
    changed, changes = process_file(cs_file)
    if changed:
        total_files += 1
        total_changes += changes
        print(f"✓ {cs_file.name}: {changes} renamings")

print(f"\n=== Summary ===")
print(f"Files updated: {total_files}")
print(f"Total renamings: {total_changes}")
