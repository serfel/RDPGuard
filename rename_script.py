#!/usr/bin/env python3
import os
import re
from pathlib import Path

workspace = "/workspace"

# Step 1: Collect all base.Name assignments to build a mapping of file -> intended class name
file_to_name = {}
name_to_file = {}

for cs_file in Path(workspace).glob("*.cs"):
    content = cs_file.read_text()
    match = re.search(r'base\.Name\s*=\s*"([^"]+)"', content)
    if match:
        intended_name = match.group(1)
        file_to_name[cs_file] = intended_name
        name_to_file[intended_name] = cs_file

print(f"Found {len(file_to_name)} files with base.Name assignments")

# Step 2: Build old class name -> new class name mapping
old_to_new_class = {}
for cs_file, new_name in file_to_name.items():
    old_class_name = cs_file.stem  # e.g., "Control1"
    old_to_new_class[old_class_name] = new_name

print(f"Class renames: {old_to_new_class}")

# Step 3: Rename classes inside files and collect method renames
method_renames = {}  # file -> {old_method: new_method}

for cs_file in Path(workspace).glob("*.cs"):
    content = cs_file.read_text()
    lines = content.split('\n')
    
    # Find the class declaration line
    class_match = re.search(r'(internal\s+(?:sealed\s+)?class\s+)\w+', content)
    if class_match:
        old_class = cs_file.stem
        if old_class in old_to_new_class:
            new_class = old_to_new_class[old_class]
            # Replace class declaration
            new_content = re.sub(
                r'(internal\s+(?:sealed\s+)?class\s+)' + re.escape(old_class) + r'\b',
                r'\1' + new_class,
                content
            )
            
            # Also replace constructor
            new_content = re.sub(
                r'(public\s+)' + re.escape(old_class) + r'\(\)',
                r'public ' + new_class + '()',
                new_content
            )
            
            cs_file.write_text(new_content)
            print(f"Renamed class {old_class} -> {new_class} in {cs_file.name}")

# Step 4: Now we need to rename files themselves
# But first let's handle method renames - find methods like method_0, method_1 etc.
# and rename them based on their functionality

# Let's analyze each file with base.Name to understand what methods do
print("\n=== Analyzing methods for renaming ===")

