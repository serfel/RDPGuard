#!/usr/bin/env python3
import os
import re
from pathlib import Path

workspace = "/workspace"

# Files that need InitializeComponent to be properly called from constructor
all_cs_files = list(Path(workspace).glob("*.cs"))

for cs_file in all_cs_files:
    content = cs_file.read_text()
    
    # Check if file has base.Name
    if 'base.Name = "' not in content:
        continue
    
    original_content = content
    
    # Replace any remaining method_7() calls with InitializeComponent()
    content = re.sub(r'\bmethod_7\s*\(\s*\)', 'InitializeComponent()', content)
    
    # Find class name
    class_name_match = re.search(r'class\s+(\w+)', content)
    if not class_name_match:
        continue
    
    class_name = class_name_match.group(1)
    
    # Check if constructor exists and if it calls InitializeComponent
    # Pattern for constructor with body
    constructor_pattern = rf'(public\s+{re.escape(class_name)}\s*\(\s*\))(\s*\{{)([^}}]*)(\}})'
    constructor_match = re.search(constructor_pattern, content, re.DOTALL)
    
    if constructor_match:
        constructor_body = constructor_match.group(3)
        
        # If InitializeComponent is not in the constructor body, add it
        if 'InitializeComponent()' not in constructor_body:
            # Add InitializeComponent() as first statement in constructor
            new_body = '\n\t\t\tInitializeComponent();' + constructor_body
            new_constructor = constructor_match.group(1) + constructor_match.group(2) + new_body + constructor_match.group(4)
            content = content.replace(constructor_match.group(0), new_constructor)
            print(f"Fixed constructor in {cs_file.name}")
    
    if content != original_content:
        cs_file.write_text(content)

print("Done fixing all constructors")
