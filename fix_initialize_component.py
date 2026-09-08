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
    
    # Check if there's a method_7 or InitializeComponent definition
    has_init_method = 'InitializeComponent' in content or 'method_7' in content
    
    if has_init_method and 'InitializeComponent' in content:
        # Check if it's called from constructor
        # Look for pattern like: public ClassName() { ... InitializeComponent(); ... }
        # or: public ClassName() { method_7(); ... }
        
        # Find constructor
        class_name_match = re.search(r'class\s+(\w+)', content)
        if class_name_match:
            class_name = class_name_match.group(1)
            
            # Check if constructor calls InitializeComponent
            constructor_pattern = rf'public\s+{class_name}\s*\(\s*\)\s*\{{[^}}]*\}}'
            constructor_match = re.search(constructor_pattern, content, re.DOTALL)
            
            if constructor_match:
                constructor_body = constructor_match.group(0)
                if 'InitializeComponent()' not in constructor_body and 'method_7()' not in constructor_body:
                    # Need to add InitializeComponent call to constructor
                    # Replace method_7() with InitializeComponent() if present
                    content = re.sub(r'\bmethod_7\s*\(\s*\)', 'InitializeComponent()', content)
                    
                    # If still not in constructor, we need to modify the constructor
                    new_constructor = f'public {class_name}()\n\t\t{{\n\t\t\tInitializeComponent();\n\t\t}}'
                    
                    # Try to find and replace the constructor
                    old_constructor_pattern = rf'public\s+{re.escape(class_name)}\s*\(\s*\)\s*\{{\s*\}}'
                    if re.search(old_constructor_pattern, content):
                        content = re.sub(old_constructor_pattern, new_constructor, content)
                        print(f"Fixed empty constructor in {cs_file.name}")
    
    if content != original_content:
        cs_file.write_text(content)

print("Done fixing InitializeComponent calls")
