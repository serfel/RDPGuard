using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using rdpguard_ui;
using rdpguard.lib;

internal sealed class Class46 : ListViewWithScroll
{
	private class Class20 : IComparer
	{
		public Dictionary<int, SortOrder> dictionary_0 = new Dictionary<int, SortOrder>();

		private int int_0;

		public int Int32_0
		{
			get
			{
				return int_0;
			}
			set
			{
				int_0 = value;
				if (!dictionary_0.ContainsKey(int_0))
				{
					dictionary_0.Add(int_0, SortOrder.Descending);
				}
				dictionary_0[int_0] = ((SortOrder.Ascending != SortOrder_0) ? SortOrder.Ascending : SortOrder.Descending);
			}
		}

		private int Int32_1
		{
			get
			{
				if (SortOrder.Ascending != SortOrder_0)
				{
					return -1;
				}
				return 1;
			}
		}

		public SortOrder SortOrder_0
		{
			get
			{
				if (!dictionary_0.ContainsKey(int_0))
				{
					return SortOrder.Ascending;
				}
				return dictionary_0[int_0];
			}
		}

		public Class20()
		{
			dictionary_0.Add(int_0, SortOrder.Ascending);
		}

		public int Compare(object object_0, object object_1)
		{
			if (object_0 == null && object_1 == null)
			{
				return 0;
			}
			if (object_0 == null && object_1 != null)
			{
				return -1;
			}
			if (object_0 != null && object_1 == null)
			{
				return 1;
			}
			if (object_0 is IPListViewItem iPListViewItem && object_1 is IPListViewItem iPListViewItem2)
			{
				switch (Int32_0)
				{
				default:
					return 0;
				case 2:
				{
					string strA = ((Int32_0 < iPListViewItem.SubItems.Count) ? iPListViewItem.SubItems[Int32_0].Text : string.Empty);
					string strB = ((Int32_0 < iPListViewItem2.SubItems.Count) ? iPListViewItem2.SubItems[Int32_0].Text : string.Empty);
					return string.Compare(strA, strB, ignoreCase: true) * Int32_1;
				}
				case 0:
				case 1:
					return Int32_1 * GStruct1.smethod_136(iPListViewItem.IPListEntry.gclass24_0.GStruct1_0, iPListViewItem2.IPListEntry.gclass24_0.GStruct1_0);
				}
			}
			return 0;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<IPListViewItem, IPListEntry> _003C_003E9__1_0;

		public static Func<IPListEntry, IPListViewItem> _003C_003E9__8_0;

		internal IPListEntry method_0(IPListViewItem iplistViewItem_0)
		{
			return iplistViewItem_0.IPListEntry;
		}

		internal IPListViewItem method_1(IPListEntry iplistEntry_0)
		{
			return new IPListViewItem(iplistEntry_0);
		}
	}

	public IPListEntry[] IPListEntry_0
	{
		get
		{
			IEnumerable<IPListViewItem> source = base.Items.Cast<IPListViewItem>();
			Func<IPListViewItem, IPListEntry> selector = _003C_003Ec._003C_003E9.method_0;
			return source.Select(selector).ToArray();
		}
	}

	public IPListViewItem[] IPListViewItem_0 => base.SelectedItems.Cast<IPListViewItem>().ToArray();

	public IPListEntry IPListEntry_1
	{
		get
		{
			if (!base.Boolean_1)
			{
				return null;
			}
			return IPListViewItem_0[0].IPListEntry;
		}
		set
		{
			if (base.Boolean_1)
			{
				IPListViewItem_0[0].IPListEntry = value;
			}
		}
	}

	public void method_11(IPListEntry[] iplistEntry_0)
	{
		BeginUpdate();
		Func<IPListEntry, IPListViewItem> selector = _003C_003Ec._003C_003E9.method_1;
		ListViewItem[] array = iplistEntry_0.Select(selector).ToArray();
		ListViewItem[] listViewItem_ = array;
		method_2(listViewItem_);
		EndUpdate();
	}

	protected override void OnColumnClick(ColumnClickEventArgs columnClickEventArgs_0)
	{
		base.OnColumnClick(columnClickEventArgs_0);
		if (base.ListViewItemSorter == null)
		{
			base.ListViewItemSorter = new Class20();
		}
		Class20 @class = base.ListViewItemSorter as Class20;
		@class.Int32_0 = columnClickEventArgs_0.Column;
		Sort();
		this.smethod_0(@class.Int32_0, @class.SortOrder_0);
	}
}
