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

print("=== FINAL VERIFICATION REPORT ===\n")

all_cs_files = list(Path(workspace).glob("*.cs"))

# Check 1: Verify all old class names are gone from file contents
print("1. Old class name references check:")
issues = []
for cs_file in all_cs_files:
    content = cs_file.read_text()
    for old_class in old_to_new_class.keys():
        if re.search(r'\b' + re.escape(old_class) + r'\b', content):
            issues.append(f"  {cs_file.name}: Still contains '{old_class}'")

if issues:
    print("   FAILED - Issues found:")
    for issue in issues[:10]:
        print(issue)
else:
    print("   PASSED - No old class name references found\n")

# Check 2: Verify files with base.Name have proper initialization
print("2. InitializeComponent check:")
files_with_base_name = []
init_issues = []
for cs_file in all_cs_files:
    content = cs_file.read_text()
    if 'base.Name = "' in content:
        files_with_base_name.append(cs_file)
        
        # Check if InitializeComponent method exists and is called
        has_init_method = bool(re.search(r'void\s+InitializeComponent\s*\(', content))
        has_init_call = bool(re.search(r'InitializeComponent\s*\(', content))
        
        if not has_init_method:
            init_issues.append(f"  {cs_file.name}: Missing InitializeComponent method")
        elif not has_init_call:
            init_issues.append(f"  {cs_file.name}: InitializeComponent not called")

if init_issues:
    print("   ISSUES FOUND:")
    for issue in init_issues[:10]:
        print(issue)
else:
    print("   PASSED - All files with base.Name have proper InitializeComponent\n")

# Check 3: File renames
print("3. File rename check:")
rename_issues = []
for old_class, new_class in old_to_new_class.items():
    old_file = os.path.join(workspace, f"{old_class}.cs")
    new_file = os.path.join(workspace, f"{new_class}.cs")
    
    if os.path.exists(old_file):
        rename_issues.append(f"  {old_class}.cs still exists (should be renamed)")
    elif not os.path.exists(new_file):
        rename_issues.append(f"  {new_class}.cs not found")

if rename_issues:
    print("   ISSUES FOUND:")
    for issue in rename_issues[:10]:
        print(issue)
else:
    print("   PASSED - All 48 classes renamed correctly\n")

# Summary
print("=== SUMMARY ===")
print(f"Total .cs files: {len(all_cs_files)}")
print(f"Files with base.Name: {len(files_with_base_name)}")
print(f"Classes renamed: {len(old_to_new_class)}")
print(f"Old class refs remaining: {len(issues)}")
print(f"Init issues: {len(init_issues)}")
print(f"Rename issues: {len(rename_issues)}")

if not issues and not init_issues and not rename_issues:
    print("\n✓ ALL CHECKS PASSED!")
else:
    print(f"\n✗ Some checks failed - see details above")
