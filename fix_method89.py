#!/usr/bin/env python3
"""Fix method_8 and method_9 calls in derived classes - they should call base methods."""
import os
import re
from pathlib import Path

workspace = "/workspace"

# method_8 -> CloseDialog or SetDialogResult (in Form0 base class)
# method_9 -> ShowOnlineHelp (in Form0 base class)

for cs_file in Path(workspace).glob("*.cs"):
    content = cs_file.read_text()
    original = content
    
    # Check if this is a derived class from Form0
    if ': Form0' not in content and ': UserControl' not in content:
        continue
    
    changes = 0
    
    # Replace method_8(DialogResult.X) with CloseDialog or just keep as base.method_8
    # Actually, these are inherited methods from Form0, so we should rename them there
    # In derived classes, we can leave them as-is since they're calling the base class method
    
    # But let's rename them in Form0.cs itself
    if cs_file.name == "Form0.cs":
        # Rename method_8 to CloseDialog
        content = re.sub(r'\bmethod_8\b', 'CloseDialog', content)
        # Rename method_9 to ShowOnlineHelp  
        content = re.sub(r'\bmethod_9\b', 'ShowOnlineHelp', content)
    
    if content != original:
        cs_file.write_text(content)
        print(f"✓ {cs_file.name}")
        changes += 1

print(f"\nDone!")
