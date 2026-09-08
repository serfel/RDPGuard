#!/usr/bin/env python3
import os
import re
from pathlib import Path

workspace = "/workspace"

# These control files have constructors with parameters and need InitializeComponent called
control_files = [
    "TrafficMonitoringControl.cs",
    "Pop3MonitoringViaLogsControl.cs",
    "FtpMonitoringViaLogsControl.cs",
    "MailSendTaskAddEditControl.cs",
    "ExecuteProgramAddEditControl.cs",
    "SmtpMonitoringViaLogsControl.cs",
    "ImapMonitoringViaLogsControl.cs",
    "HttpPostTaskAddEditControl.cs",
    "ReportToAbuseIPDBAddEditControl.cs",
    "TelegramSendTaskAddEditControl.cs",
]

for filename in control_files:
    filepath = os.path.join(workspace, filename)
    if not os.path.exists(filepath):
        continue
    
    content = open(filepath).read()
    original = content
    
    # Find the method that contains base.Name (this is the initialization method)
    # It's usually a private void method at the end of the class
    # We need to rename it to InitializeComponent if it isn't already
    
    # Check if there's a method containing "base.Name"
    lines = content.split('\n')
    init_method_start = -1
    init_method_name = None
    
    for i, line in enumerate(lines):
        if 'base.Name = "' in line:
            # Find the method this line belongs to
            for j in range(i, -1, -1):
                method_match = re.search(r'(private|protected)\s+void\s+(\w+)\s*\(', lines[j])
                if method_match:
                    init_method_name = method_match.group(2)
                    init_method_start = j
                    break
            break
    
    if init_method_name and init_method_name != 'InitializeComponent':
        print(f"{filename}: Found init method '{init_method_name}', renaming to InitializeComponent")
        content = content.replace(init_method_name, 'InitializeComponent')
    
    # Now find constructor and add InitializeComponent call
    class_match = re.search(r'class\s+(\w+)', content)
    if class_match:
        class_name = class_match.group(1)
        
        # Find constructor with parameters
        constructor_pattern = rf'(public\s+{re.escape(class_name)}\s*\([^)]*\))(\s*\{{)([^}}]*)(\}})'
        constructor_match = re.search(constructor_pattern, content, re.DOTALL)
        
        if constructor_match:
            constructor_body = constructor_match.group(3)
            
            if 'InitializeComponent()' not in constructor_body:
                # Add InitializeComponent() as first statement
                new_body = '\n\t\t\tInitializeComponent();' + constructor_body
                new_constructor = constructor_match.group(1) + constructor_match.group(2) + new_body + constructor_match.group(4)
                content = content.replace(constructor_match.group(0), new_constructor)
                print(f"{filename}: Added InitializeComponent() call to constructor")
    
    if content != original:
        open(filepath, 'w').write(content)

print("Done fixing control files")
