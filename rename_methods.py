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

# Build reverse mapping
new_to_old_class = {v: k for k, v in old_to_new_class.items()}

# Files that have been renamed (class name changed inside)
renamed_files = {}  # old_filename -> new_filename
for old_class, new_class in old_to_new_class.items():
    old_file = f"{old_class}.cs"
    if os.path.exists(os.path.join(workspace, old_file)):
        renamed_files[old_file] = f"{new_class}.cs"

print(f"Files to rename: {renamed_files}")

# First, let's rename the files
for old_file, new_file in renamed_files.items():
    old_path = os.path.join(workspace, old_file)
    new_path = os.path.join(workspace, new_file)
    if os.path.exists(old_path):
        os.rename(old_path, new_path)
        print(f"Renamed file: {old_file} -> {new_file}")

# Now update all references to old class names in all files
all_cs_files = list(Path(workspace).glob("*.cs"))

# Build comprehensive replacement map
replacements = {}
for old_class, new_class in old_to_new_class.items():
    replacements[old_class] = new_class

# Also add reversed entries for any classes we might have missed
# But focus on what we know

print(f"\nUpdating references in all files...")

for cs_file in all_cs_files:
    content = cs_file.read_text()
    original_content = content
    
    # Replace all old class names with new ones
    for old_class, new_class in replacements.items():
        # Match whole word only
        content = re.sub(r'\b' + re.escape(old_class) + r'\b', new_class, content)
    
    if content != original_content:
        cs_file.write_text(content)
        print(f"Updated references in {cs_file.name}")

print("\n=== Done ===")
