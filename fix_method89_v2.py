#!/usr/bin/env python3
"""Fix method_8 and method_9 calls everywhere - rename to meaningful names."""
import os
import re
from pathlib import Path

workspace = "/workspace"

# First, let's rename in Form0.cs (the base class)
form0_path = Path(workspace) / "Form0.cs"
if form0_path.exists():
    content = form0_path.read_text()
    
    # Rename method_8 to CloseDialog  
    content = re.sub(r'\bmethod_8\b', 'CloseDialog', content)
    # Rename method_9 to ShowOnlineHelp
    content = re.sub(r'\bmethod_9\b', 'ShowOnlineHelp', content)
    
    form0_path.write_text(content)
    print("✓ Form0.cs updated")

# Now update all derived classes to use the new method names
for cs_file in Path(workspace).glob("*.cs"):
    if cs_file.name == "Form0.cs":
        continue
        
    content = cs_file.read_text()
    original = content
    
    # Only update files that inherit from Form0 or call these methods
    if 'method_8(' in content or 'method_9(' in content:
        # Replace method_8(DialogResult.X) with CloseDialog(DialogResult.X)
        content = re.sub(r'\bmethod_8\b', 'CloseDialog', content)
        # Replace method_9(string) with ShowOnlineHelp(string)
        content = re.sub(r'\bmethod_9\b', 'ShowOnlineHelp', content)
        
        if content != original:
            cs_file.write_text(content)
            print(f"✓ {cs_file.name}")

print("\nDone!")
