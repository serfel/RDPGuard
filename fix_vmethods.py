#!/usr/bin/env python3
"""Fix vmethod_0, vmethod_1, vmethod_2 - these are virtual methods in Form0."""
import os
import re
from pathlib import Path

workspace = "/workspace"

# First fix Form0.cs
form0_path = Path(workspace) / "Form0.cs"
if form0_path.exists():
    content = form0_path.read_text()
    
    # vmethod_0 -> OnFormClosing (virtual method called on form closing)
    content = re.sub(r'\bvmethod_0\b', 'OnFormClosing', content)
    # vmethod_1 -> InitializeFormPosition (sets up form position)
    content = re.sub(r'\bvmethod_1\b', 'InitializeFormPosition', content)
    # vmethod_2 -> AdjustFormSize (adjusts form size based on controls)
    content = re.sub(r'\bvmethod_2\b', 'AdjustFormSize', content)
    
    form0_path.write_text(content)
    print("✓ Form0.cs updated")

# Now update all derived classes
for cs_file in Path(workspace).glob("*.cs"):
    if cs_file.name == "Form0.cs":
        continue
        
    content = cs_file.read_text()
    original = content
    
    changes_made = False
    
    # Replace vmethod calls
    if 'vmethod_0(' in content or 'vmethod_0)' in content or ' vmethod_0;' in content:
        content = re.sub(r'\bvmethod_0\b', 'OnFormClosing', content)
        changes_made = True
    
    if 'vmethod_1(' in content:
        content = re.sub(r'\bvmethod_1\b', 'InitializeFormPosition', content)
        changes_made = True
    
    if 'vmethod_2(' in content:
        content = re.sub(r'\bvmethod_2\b', 'AdjustFormSize', content)
        changes_made = True
    
    if changes_made and content != original:
        cs_file.write_text(content)
        print(f"✓ {cs_file.name}")

print("\nDone!")
