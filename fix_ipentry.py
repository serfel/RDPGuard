#!/usr/bin/env python3
import re
from pathlib import Path

# Fix the last vmethod_0 in IPListEntry.cs
ip_path = Path("/workspace/rdpguard.lib/IPListEntry.cs")
content = ip_path.read_text()
content = re.sub(r'\bvmethod_0\b', 'MatchesIP', content)
ip_path.write_text(content)
print("✓ IPListEntry.cs updated")
