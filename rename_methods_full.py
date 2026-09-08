#!/usr/bin/env python3
import os
import re
from pathlib import Path

workspace = "/workspace"

# First, let's analyze all files with base.Name to understand what methods do
# and rename them appropriately

files_with_base_name = []
for cs_file in Path(workspace).glob("*.cs"):
    content = cs_file.read_text()
    if 'base.Name = "' in content:
        files_with_base_name.append(cs_file)

print(f"Files with base.Name: {len(files_with_base_name)}")

# For each file, we need to:
# 1. Rename method_7 -> InitializeComponent (the initialization method)
# 2. Rename other methods based on their functionality

# Let's process each file
for cs_file in files_with_base_name:
    content = cs_file.read_text()
    original_content = content
    
    # Rename method_7 to InitializeComponent (this is typically the initialization method)
    # It's usually called from constructor and contains control initialization
    content = re.sub(r'\bmethod_7\b', 'InitializeComponent', content)
    
    # Now let's analyze the specific methods in this file and rename them
    # We need to look at what each method does
    
    cs_file.write_text(content)
    print(f"Updated {cs_file.name}")

print("\n=== First pass done ===")
