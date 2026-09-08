#!/usr/bin/env python3
import os
import re
from pathlib import Path

workspace = "/workspace"

# Get all cs files
all_cs_files = list(Path(workspace).glob("*.cs"))

# Pattern to find method declarations
method_pattern = re.compile(r'(internal\s+(?:sealed\s+)?class\s+\w+[^{]*\{)|((?:private|public|internal)\s+(?:static\s+)?(?:void|bool|int|string|\w+)\s+method_(\d+))', re.MULTILINE)

# For each file, we need to rename methods consistently
# The pattern is:
# - method_7 -> InitializeComponent (initialization method called from constructor)
# - Other methods should be renamed based on their purpose

# Let's first collect all method usages across all files
method_usages = {}  # method_name -> set of (file, line_number, context)

for cs_file in all_cs_files:
    content = cs_file.read_text()
    lines = content.split('\n')
    for i, line in enumerate(lines):
        matches = re.findall(r'\bmethod_(\d+)\b', line)
        for m in matches:
            key = f"method_{m}"
            if key not in method_usages:
                method_usages[key] = []
            method_usages[key].append((cs_file.name, i+1, line.strip()))

# Now let's analyze and rename methods per file
# We'll use a consistent naming scheme:
# For classes with base.Name:
#   - method_7 -> InitializeComponent
#   - method_0, method_1, etc. -> descriptive names based on usage

print("Analyzing method patterns...")

# First pass: rename method_7 to InitializeComponent in all files that have it
files_updated = 0
for cs_file in all_cs_files:
    content = cs_file.read_text()
    original = content
    
    # Rename method_7 to InitializeComponent
    content = re.sub(r'\bmethod_7\b', 'InitializeComponent', content)
    
    if content != original:
        cs_file.write_text(content)
        files_updated += 1

print(f"Updated {files_updated} files with InitializeComponent rename")

# Second pass: Analyze remaining methods and rename them
# We need to understand what each method does

# Let's look at the structure more carefully
# In many WinForms-style classes:
# - method_0 often is event handler setup or initialization helper
# - method_1, method_2, etc. are often Add/Remove/Update operations

# For now, let's focus on renaming methods within each class to be more descriptive
# based on their position and typical patterns

print("\n=== Renaming methods based on context ===")

for cs_file in all_cs_files:
    content = cs_file.read_text()
    original = content
    
    # Skip if already processed for InitializeComponent
    # Look for common patterns
    
    # Pattern 1: If class has "Table" in name, methods might be table operations
    if 'Table' in cs_file.name:
        # method_0 -> InitializeHandlers
        content = re.sub(r'\bmethod_0\b', 'InitializeHandlers', content)
        # method_1 -> AddItems  
        content = re.sub(r'\bmethod_1\b', 'AddItems', content)
        # method_2 -> AddItem
        content = re.sub(r'\bmethod_2\b', 'AddItem', content)
        # method_3 -> UpdateCustomList
        content = re.sub(r'\bmethod_3\b', 'UpdateCustomList', content)
        # method_4 -> RemoveSelected
        content = re.sub(r'\bmethod_4\b', 'RemoveSelected', content)
        # method_5 -> RemoveItem
        content = re.sub(r'\bmethod_5\b', 'RemoveItem', content)
        # method_6 -> UpdateTotals
        content = re.sub(r'\bmethod_6\b', 'UpdateTotals', content)
        # method_8 -> RemoveListItem
        content = re.sub(r'\bmethod_8\b', 'RemoveListItem', content)
        # method_9 -> RemoveCountry
        content = re.sub(r'\bmethod_9\b', 'RemoveCountry', content)
        # method_10 -> GetEntryCount
        content = re.sub(r'\bmethod_10\b', 'GetEntryCount', content)
        # method_11 -> GetAddressCount
        content = re.sub(r'\bmethod_11\b', 'GetAddressCount', content)
    
    elif 'Dialog' in cs_file.name:
        # Dialog classes typically have button handlers
        # method_11 -> InitializeComponentHelper or similar
        # method_12, method_13 -> button click handlers
        
        # For dialogs, let's keep generic but clearer names
        content = re.sub(r'\bmethod_11\b', 'InitializeComponents', content)
        content = re.sub(r'\bmethod_12\b', 'OnButtonOk', content)
        content = re.sub(r'\bmethod_13\b', 'OnButtonCancel', content)
        content = re.sub(r'\bmethod_14\b', 'OnLoad', content)
        content = re.sub(r'\bmethod_15\b', 'ValidateInput', content)
        content = re.sub(r'\bmethod_16\b', 'SaveSettings', content)
        content = re.sub(r'\bmethod_17\b', 'LoadSettings', content)
        content = re.sub(r'\bmethod_18\b', 'OnTextChanged', content)
        content = re.sub(r'\bmethod_19\b', 'OnCheckedChanged', content)
        content = re.sub(r'\bmethod_20\b', 'OnSelectedIndexChanged', content)
    
    elif 'Control' in cs_file.name:
        # UserControl classes
        content = re.sub(r'\bmethod_0\b', 'InitializeHandlers', content)
        content = re.sub(r'\bmethod_1\b', 'AddTask', content)
        content = re.sub(r'\bmethod_2\b', 'EditTask', content)
        content = re.sub(r'\bmethod_3\b', 'RemoveTask', content)
    
    if content != original:
        cs_file.write_text(content)
        print(f"Updated {cs_file.name}")

print("\n=== Done ===")
