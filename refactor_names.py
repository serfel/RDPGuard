#!/usr/bin/env python3
"""
Comprehensive refactoring script to rename obfuscated method and variable names
to meaningful names throughout the entire codebase.
"""
import os
import re
from pathlib import Path
from collections import defaultdict

workspace = "/workspace"

# First pass: collect all class definitions and their base.Name values
# to understand what each file represents

file_info = {}

for cs_file in Path(workspace).glob("*.cs"):
    content = cs_file.read_text()
    
    # Find class name
    class_match = re.search(r'(?:internal\s+)?(?:sealed\s+)?class\s+(\w+)\s*:', content)
    if not class_match:
        continue
    
    class_name = class_match.group(1)
    
    # Find base.Name value
    base_name_match = re.search(r'base\.Name\s*=\s*"([^"]+)"', content)
    form_name = base_name_match.group(1) if base_name_match else None
    
    # Find field declarations
    fields = {}
    for match in re.finditer(r'private\s+(?:static\s+)?(?:readonly\s+)?(\w+)\s+(\w+)_(\d+);', content):
        field_type = match.group(1)
        field_base = match.group(2)
        field_num = match.group(3)
        fields[f"{field_base}_{field_num}"] = field_type
    
    # Find method declarations  
    methods = {}
    for match in re.finditer(r'(?:private|protected|public|internal)\s+(?:static\s+)?(?:override\s+)?(?:void|[\w<>]+)\s+(method|smethod)_(\d+)', content):
        method_type = match.group(1)
        method_num = match.group(2)
        methods[f"{method_type}_{method_num}"] = True
    
    file_info[cs_file.name] = {
        'path': cs_file,
        'class_name': class_name,
        'form_name': form_name,
        'fields': fields,
        'methods': methods,
        'content': content
    }

print(f"Analyzed {len(file_info)} files")

# Now let's look at specific patterns to understand what each method does
# and create a mapping for renaming

# For forms/dialogs, we need to identify:
# - InitializeComponent (initialization method)
# - event handlers (Click, TextChanged, etc.)
# - validation methods
# - dialog result methods

# Let's print out some examples to understand the patterns
for fname, info in list(file_info.items())[:5]:
    print(f"\n=== {fname} ===")
    print(f"Class: {info['class_name']}, Form: {info['form_name']}")
    print(f"Fields: {list(info['fields'].keys())[:10]}")
    print(f"Methods: {list(info['methods'].keys())[:10]}")

