using System;
using System.Windows.Forms;
using rdpguard.lib;

namespace rdpguard_ui;

[Serializable]
internal sealed class IPListViewItem : ListViewItem
{
	private IPListEntry iplistEntry_0;

	public IPListEntry IPListEntry
	{
		get
		{
			return iplistEntry_0;
		}
		set
		{
			iplistEntry_0 = value;
			base.SubItems[0].Text = value.gclass24_0.method_5();
			base.SubItems[1].Text = ((value.gclass24_0.Boolean_1 ? true : false) ? value.gclass24_0.method_6() : null);
			base.SubItems[2].Text = value.Comment;
		}
	}

	public IPListViewItem(IPListEntry iplistEntry_1)
	{
		base.SubItems.Add(string.Empty);
		base.SubItems.Add(string.Empty);
		IPListEntry = iplistEntry_1;
	}
}
