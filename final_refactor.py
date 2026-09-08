#!/usr/bin/env python3
"""
Final comprehensive refactoring - handles event handler method names too.
"""
import os
import re
from pathlib import Path

workspace = "/workspace"

def process_all_files():
    """Process all files with complete renaming."""
    
    # First pass: collect all field mappings from all files
    all_field_mappings = {}
    
    for cs_file in Path(workspace).glob("*.cs"):
        content = cs_file.read_text()
        
        # Extract field mappings from .Name assignments
        for match in re.finditer(r'(\w+_\d+)\.Name\s*=\s*"([^"]+)"', content):
            var_name = match.group(1)
            meaningful = match.group(2)
            if meaningful:
                new_name = meaningful[0].lower() + meaningful[1:] if len(meaningful) > 1 else meaningful.lower()
                new_name = re.sub(r'[^a-zA-Z0-9]', '', new_name)
                all_field_mappings[var_name] = new_name
    
    print(f"Collected {len(all_field_mappings)} field mappings")
    
    # Second pass: apply all renamings and fix event handlers
    files_modified = 0
    total_changes = 0
    
    for cs_file in Path(workspace).glob("*.cs"):
        content = cs_file.read_text()
        original = content
        
        if 'base.Name =' not in content:
            continue
        
        changes = 0
        
        # Apply field renamings (sorted by length to avoid partial matches)
        for old_name, new_name in sorted(all_field_mappings.items(), key=lambda x: -len(x[0])):
            if old_name != new_name and old_name in content:
                # Replace declaration
                content = re.sub(
                    rf'\b(private|protected|public|internal)\s+(\w+)\s+{re.escape(old_name)};',
                    lambda m: f"{m.group(1)} {m.group(2)} {new_name};",
                    content
                )
                # Replace all usages
                content = re.sub(rf'\b{re.escape(old_name)}\b', new_name, content)
                changes += 1
        
        # Fix event handler method names
        # Pattern: variable.Event += old_handler_name;
        # We need to rename the handler method to match the new variable name
        event_pattern = r'(\w+)\.(\w+)\s*\+=\s*(\w+_Click|\w+_TextChanged|\w+_CheckedChanged|\w+_KeyUp|\w+_MouseDoubleClick|\w+_LinkClicked);'
        
        for match in re.finditer(event_pattern, content):
            control_var = match.group(1)
            event_name = match.group(2)
            handler_name = match.group(3)
            
            # Find the handler method declaration
            handler_decl_pattern = rf'(private|protected)\s+void\s+{re.escape(handler_name)}\s*\('
            handler_decl = re.search(handler_decl_pattern, content)
            
            if handler_decl:
                # Create new handler name based on control variable and event
                new_handler = f"{control_var}_{event_name}"
                
                if handler_name != new_handler:
                    # Rename the handler method
                    content = re.sub(
                        rf'\b{re.escape(handler_name)}\b',
                        new_handler,
                        content
                    )
                    changes += 1
        
        # Also rename InitializeComponents to InitializeComponent
        content = re.sub(r'\bInitializeComponents\b', 'InitializeComponent', content)
        
        if content != original:
            cs_file.write_text(content)
            files_modified += 1
            total_changes += changes
            if changes > 0:
                print(f"✓ {cs_file.name}: {changes} changes")
    
    return files_modified, total_changes

print("=== Final Refactoring Pass ===\n")
files, changes = process_all_files()
print(f"\n=== Summary ===")
print(f"Files modified: {files}")
print(f"Total changes: {changes}")
