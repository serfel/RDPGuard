#!/usr/bin/env python3
import os
import re
from pathlib import Path

workspace = "/workspace"

# Let's analyze methods in files with base.Name to understand what they do
files_with_base_name = []
for cs_file in Path(workspace).glob("*.cs"):
    content = cs_file.read_text()
    if 'base.Name = "' in content:
        files_with_base_name.append(cs_file)

print(f"Files with base.Name: {len(files_with_base_name)}\n")

# For each file, let's extract method signatures and their bodies
for cs_file in sorted(files_with_base_name):
    content = cs_file.read_text()
    print(f"\n=== {cs_file.name} ===")
    
    # Find all method_X patterns
    methods = re.findall(r'(private|public|internal)\s+(?:static\s+)?(\w+)\s+method_(\d+)\s*\([^)]*\)', content)
    print(f"Methods found: {[f'method_{m[2]}' for m in methods]}")
    
    # Check if InitializeComponent exists now
    if 'InitializeComponent' in content:
        print("Has InitializeComponent: YES")
    
