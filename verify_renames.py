#!/usr/bin/env python3
import os
import re
from pathlib import Path

workspace = "/workspace"

# Mapping of old class names to new class names
old_to_new_class = {
    'Control11': 'ImapMonitoringViaLogsControl',
    'Form3': 'FtpSettingsDialog',
    'Control12': 'TrafficMonitoringControl',
    'Form31': 'EventLogDialog',
    'Form4': 'HttpSettingsDialog',
    'Control9': 'MailSendTaskAddEditControl',
    'Form28': 'IPListDialog',
    'Control10': 'Pop3MonitoringViaLogsControl',
    'Form25': 'SmtpServersDialog',
    'Form26': 'SmtpServerAddEditDialog',
    'Form33': 'formCrashReport',
    'Form1': 'AdvancedGeoIPSettingsDialog',
    'Form12': 'SipSettingsDialog',
    'Form22': 'AdvancedBlockingSettingsDialog',
    'Control1': 'GeoIPCountriesTable',
    'Form13': 'MsSqlExclusionsDialog',
    'Form16': 'MySqlSettingsDialog',
    'Form24': 'CustomActionsDialog',
    'Form30': 'LicenseActivatationDialog',
    'Control8': 'HttpPostTaskAddEditControl',
    'Form10': 'LicenseActivatationOfflineDialog',
    'Control15': 'DirectoriesTable',
    'Form5': 'ProtocolRulesDialog',
    'Form11': 'Pop3SettingsDialog',
    'Form29': 'AboutDialog',
    'Form15': 'RDWebSettingsDialog',
    'Form34': 'DiagnosticReportDialog',
    'Form2': 'AdvancedHttpSettingsDialog',
    'Form9': 'CustomActionAddEditDialog',
    'Form23': 'IPFilterDialog',
    'Form32': 'DashboardDialog',
    'Form6': 'AdvancedSmtpSettingsDialog',
    'Form18': 'WinPcapDialog',
    'Control3': 'FtpMonitoringViaLogsControl',
    'Form20': 'SmtpSettingsDialog',
    'Control5': 'TelegramSendTaskAddEditControl',
    'Control7': 'ExecuteProgramAddEditControl',
    'Form21': 'RdpSettingsDialog',
    'Form7': 'GeoIPCountryAddDialog',
    'Form27': 'IPListEntryAddEditDialog',
    'Form8': 'WebFormsSettingsDialog',
    'Form35': 'OptionsDialog',
    'Form19': 'RawSocketsDialog',
    'Control6': 'ReportToAbuseIPDBAddEditControl',
    'Control0': 'EditableGeoIPCountriesTable',
    'Form17': 'ImapSettingsDialog',
    'Form14': 'MsSqlSettingsDialog',
    'Control13': 'SmtpMonitoringViaLogsControl',
}

print("=== Verification Report ===\n")

# Check 1: Verify all old class names are gone from file contents
print("1. Checking for remaining old class name references...")
all_cs_files = list(Path(workspace).glob("*.cs"))
issues = []

for cs_file in all_cs_files:
    content = cs_file.read_text()
    for old_class in old_to_new_class.keys():
        # Look for the old class name as a whole word (not part of another word)
        if re.search(r'\b' + re.escape(old_class) + r'\b', content):
            issues.append(f"  {cs_file.name}: Still contains reference to '{old_class}'")

if issues:
    print("ISSUES FOUND:")
    for issue in issues[:20]:  # Show first 20
        print(issue)
    if len(issues) > 20:
        print(f"  ... and {len(issues) - 20} more")
else:
    print("  OK - No old class name references found")

# Check 2: Verify files with base.Name have InitializeComponent
print("\n2. Checking for InitializeComponent in files with base.Name...")
files_with_base_name = []
for cs_file in all_cs_files:
    content = cs_file.read_text()
    if 'base.Name = "' in content:
        files_with_base_name.append(cs_file)
        if 'InitializeComponent' not in content:
            print(f"  ISSUE: {cs_file.name} has base.Name but no InitializeComponent")
        else:
            # Check if InitializeComponent is called from constructor
            if not re.search(r'InitializeComponent\s*\(\s*\)', content):
                print(f"  WARNING: {cs_file.name} has InitializeComponent but might not be called")

print(f"  Checked {len(files_with_base_name)} files with base.Name")

# Check 3: List all renamed files
print("\n3. Renamed files verification...")
for old_class, new_class in old_to_new_class.items():
    old_file = os.path.join(workspace, f"{old_class}.cs")
    new_file = os.path.join(workspace, f"{new_class}.cs")
    
    if os.path.exists(old_file):
        print(f"  ISSUE: {old_class}.cs still exists (should be renamed to {new_class}.cs)")
    elif os.path.exists(new_file):
        print(f"  OK: {old_class}.cs -> {new_class}.cs")
    else:
        print(f"  MISSING: Neither {old_class}.cs nor {new_class}.cs found")

print("\n=== Summary ===")
print(f"Total files in workspace: {len(all_cs_files)}")
print(f"Files with base.Name: {len(files_with_base_name)}")
print(f"Expected renamed classes: {len(old_to_new_class)}")
