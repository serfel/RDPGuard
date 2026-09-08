#!/usr/bin/env python3
"""Fix remaining vmethod_3, vmethod_4, vmethod_5 - these are in Control4 and derived classes."""
import os
import re
from pathlib import Path

workspace = "/workspace"

# First fix Control4.cs (base class for these methods)
control4_path = Path(workspace) / "Control4.cs"
if control4_path.exists():
    content = control4_path.read_text()
    
    # vmethod_3 -> UpdateTaskType
    content = re.sub(r'\bvmethod_3\b', 'UpdateTaskType', content)
    # vmethod_4 -> ValidateInput  
    content = re.sub(r'\bvmethod_4\b', 'ValidateInput', content)
    # vmethod_5 -> SetEditMode
    content = re.sub(r'\bvmethod_5\b', 'SetEditMode', content)
    
    control4_path.write_text(content)
    print("✓ Control4.cs updated")

# Now update all files that use these methods
for cs_file in Path(workspace).glob("*.cs"):
    if cs_file.name == "Control4.cs":
        continue
        
    content = cs_file.read_text()
    original = content
    
    changes_made = False
    
    if 'vmethod_3(' in content:
        content = re.sub(r'\bvmethod_3\b', 'UpdateTaskType', content)
        changes_made = True
    
    if 'vmethod_4(' in content or ' vmethod_4;' in content or ' vmethod_4)' in content:
        content = re.sub(r'\bvmethod_4\b', 'ValidateInput', content)
        changes_made = True
    
    if 'vmethod_5(' in content:
        content = re.sub(r'\bvmethod_5\b', 'SetEditMode', content)
        changes_made = True
    
    if changes_made and content != original:
        cs_file.write_text(content)
        print(f"✓ {cs_file.name}")

print("\nDone!")
