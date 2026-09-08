using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using rdpguard.lib;

internal sealed class Control1 : UserControl
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<ListViewItem, bool> _003C_003E9__15_0;

		public static Func<ListViewItem, GClass5> _003C_003E9__15_1;

		public static Func<ListViewItem, bool> _003C_003E9__17_0;

		public static Func<ListViewItem, GClass5> _003C_003E9__17_1;

		public static Func<ListViewItem, bool> _003C_003E9__20_0;

		public static Func<ListViewItem, bool> _003C_003E9__29_0;

		public static Func<ListViewItem, bool> _003C_003E9__31_0;

		public static Func<IPListEntry, GStruct1> _003C_003E9__36_0;

		public static Action<ListViewItem> _003C_003E9__38_1;

		public static Func<GClass5, long> _003C_003E9__39_0;

		public static Func<GClass5, long> _003C_003E9__39_1;

		public static Func<IPListEntry, GStruct1> _003C_003E9__39_2;

		internal bool method_0(ListViewItem listViewItem_0)
		{
			return listViewItem_0.Tag is GClass5;
		}

		internal GClass5 method_1(ListViewItem listViewItem_0)
		{
			return listViewItem_0.Tag as GClass5;
		}

		internal bool method_2(ListViewItem listViewItem_0)
		{
			return listViewItem_0.Tag is GClass5;
		}

		internal GClass5 method_3(ListViewItem listViewItem_0)
		{
			return listViewItem_0.Tag as GClass5;
		}

		internal bool method_4(ListViewItem listViewItem_0)
		{
			return listViewItem_0.Tag is List<IPListEntry>;
		}

		internal bool method_5(ListViewItem listViewItem_0)
		{
			return listViewItem_0 is Class7;
		}

		internal bool method_6(ListViewItem listViewItem_0)
		{
			return listViewItem_0 is Class8;
		}

		internal GStruct1 method_7(IPListEntry iplistEntry_0)
		{
			return iplistEntry_0.gclass24_0.GStruct1_2;
		}

		internal void method_8(ListViewItem listViewItem_0)
		{
			listViewItem_0.Remove();
		}

		internal long method_9(GClass5 gclass5_0)
		{
			return gclass5_0.long_0;
		}

		internal long method_10(GClass5 gclass5_0)
		{
			return gclass5_0.long_1;
		}

		internal GStruct1 method_11(IPListEntry iplistEntry_0)
		{
			return iplistEntry_0.gclass24_0.GStruct1_2;
		}
	}

	private sealed class Class6
	{
		public GClass5 gclass5_0;

		internal bool method_0(ListViewItem listViewItem_0)
		{
			return listViewItem_0.Tag as GClass5 == gclass5_0;
		}
	}

	private EventHandler eventHandler_0;

	private EventHandler eventHandler_1;

	private KeyEventHandler keyEventHandler_0;

	private MouseEventHandler mouseEventHandler_0;

	private IContainer icontainer_0;

	private GClass0 gclass0_0;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private ColumnHeader columnHeader_2;

	private ColumnHeader columnHeader_3;

	public bool Boolean_0 => gclass0_0.Boolean_1;

	public GClass5[] GClass5_0
	{
		get
		{
			IEnumerable<ListViewItem> source = gclass0_0.SelectedItems.Cast<ListViewItem>();
			Func<ListViewItem, bool> predicate = _003C_003Ec._003C_003E9.method_0;
			IEnumerable<ListViewItem> source2 = source.Where(predicate);
			Func<ListViewItem, GClass5> selector = _003C_003Ec._003C_003E9.method_1;
			return source2.Select(selector).ToArray();
		}
	}

	public GClass5[] GClass5_1
	{
		get
		{
			IEnumerable<ListViewItem> source = gclass0_0.Items.Cast<ListViewItem>();
			Func<ListViewItem, bool> predicate = _003C_003Ec._003C_003E9.method_2;
			IEnumerable<ListViewItem> source2 = source.Where(predicate);
			Func<ListViewItem, GClass5> selector = _003C_003Ec._003C_003E9.method_3;
			return source2.Select(selector).ToArray();
		}
		set
		{
			gclass0_0.Items.Clear();
			method_1(value);
		}
	}

	private ListViewItem ListViewItem_0
	{
		get
		{
			IEnumerable<ListViewItem> source = gclass0_0.Items.Cast<ListViewItem>();
			Func<ListViewItem, bool> predicate = _003C_003Ec._003C_003E9.method_4;
			return source.FirstOrDefault(predicate);
		}
	}

	private bool Boolean_1 => ListViewItem_0 != null;

	public bool Boolean_2
	{
		get
		{
			if (Boolean_1)
			{
				return ListViewItem_0.Selected;
			}
			return false;
		}
	}

	public IPListEntry[] IPListEntry_0
	{
		get
		{
			if (!Boolean_1)
			{
				return new IPListEntry[0];
			}
			return ((List<IPListEntry>)ListViewItem_0.Tag).ToArray();
		}
		set
		{
			ListViewItem_0?.Remove();
			method_3(value);
		}
	}

	private Class7 Class7_0
	{
		get
		{
			IEnumerable<ListViewItem> source = gclass0_0.Items.Cast<ListViewItem>();
			Func<ListViewItem, bool> predicate = _003C_003Ec._003C_003E9.method_5;
			return source.Where(predicate).Cast<Class7>().FirstOrDefault();
		}
	}

	private Class8 Class8_0
	{
		get
		{
			IEnumerable<ListViewItem> source = gclass0_0.Items.Cast<ListViewItem>();
			Func<ListViewItem, bool> predicate = _003C_003Ec._003C_003E9.method_6;
			return source.Where(predicate).Cast<Class8>().FirstOrDefault();
		}
	}

	public event EventHandler Event_0
	{
		add
		{
			EventHandler eventHandler = eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		remove
		{
			EventHandler eventHandler = eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler Event_1
	{
		add
		{
			EventHandler eventHandler = eventHandler_1;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		remove
		{
			EventHandler eventHandler = eventHandler_1;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event KeyEventHandler Event_2
	{
		add
		{
			KeyEventHandler keyEventHandler = keyEventHandler_0;
			KeyEventHandler keyEventHandler2;
			do
			{
				keyEventHandler2 = keyEventHandler;
				KeyEventHandler value2 = (KeyEventHandler)Delegate.Combine(keyEventHandler2, value);
				keyEventHandler = Interlocked.CompareExchange(ref keyEventHandler_0, value2, keyEventHandler2);
			}
			while ((object)keyEventHandler != keyEventHandler2);
		}
		remove
		{
			KeyEventHandler keyEventHandler = keyEventHandler_0;
			KeyEventHandler keyEventHandler2;
			do
			{
				keyEventHandler2 = keyEventHandler;
				KeyEventHandler value2 = (KeyEventHandler)Delegate.Remove(keyEventHandler2, value);
				keyEventHandler = Interlocked.CompareExchange(ref keyEventHandler_0, value2, keyEventHandler2);
			}
			while ((object)keyEventHandler != keyEventHandler2);
		}
	}

	public event MouseEventHandler Event_3
	{
		add
		{
			MouseEventHandler mouseEventHandler = mouseEventHandler_0;
			MouseEventHandler mouseEventHandler2;
			do
			{
				mouseEventHandler2 = mouseEventHandler;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine(mouseEventHandler2, value);
				mouseEventHandler = Interlocked.CompareExchange(ref mouseEventHandler_0, value2, mouseEventHandler2);
			}
			while ((object)mouseEventHandler != mouseEventHandler2);
		}
		remove
		{
			MouseEventHandler mouseEventHandler = mouseEventHandler_0;
			MouseEventHandler mouseEventHandler2;
			do
			{
				mouseEventHandler2 = mouseEventHandler;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove(mouseEventHandler2, value);
				mouseEventHandler = Interlocked.CompareExchange(ref mouseEventHandler_0, value2, mouseEventHandler2);
			}
			while ((object)mouseEventHandler != mouseEventHandler2);
		}
	}

	public Control1()
	{
		method_7();
		method_0();
	}

	private void method_0()
	{
		gclass0_0.SelectedIndexChanged += gclass0_0_SelectedIndexChanged;
		gclass0_0.KeyUp += gclass0_0_KeyUp;
		gclass0_0.MouseDoubleClick += gclass0_0_MouseDoubleClick;
	}

	public void method_1(GClass5[] gclass5_0)
	{
		gclass0_0.BeginUpdate();
		gclass5_0?.smethod_0(method_8);
		gclass0_0.EndUpdate();
		method_6();
	}

	private void method_2(GClass5 gclass5_0)
	{
		gclass0_0.Items.Add(new ListViewItem(new string[4]
		{
			gclass5_0.Name + " (" + gclass5_0.string_1 + ")",
			gclass5_0.long_0.ToString(),
			gclass5_0.long_1.ToString(),
			gclass5_0.dateTime_0.ToString()
		})
		{
			Tag = gclass5_0
		});
		eventHandler_1?.Invoke(this, EventArgs.Empty);
	}

	public void method_3(IPListEntry[] iplistEntry_0)
	{
		if (!iplistEntry_0.IsNullOrEmpty())
		{
			if (!Boolean_1)
			{
				gclass0_0.method_1(new ListViewItem(new string[4]
				{
					"Custom allow list",
					string.Empty,
					string.Empty,
					"-"
				})
				{
					Tag = new List<IPListEntry>()
				});
			}
			ListViewItem listViewItem_ = ListViewItem_0;
			List<IPListEntry> list = (List<IPListEntry>)listViewItem_.Tag;
			list.AddRange(iplistEntry_0);
			listViewItem_.SubItems[1].Text = list.Count.ToString();
			ListViewItem.ListViewSubItem listViewSubItem = listViewItem_.SubItems[2];
			Func<IPListEntry, GStruct1> selector = _003C_003Ec._003C_003E9.method_7;
			listViewSubItem.Text = list.Select(selector).smethod_0().ToString();
			method_6();
		}
	}

	public void method_4()
	{
		gclass0_0.BeginUpdate();
		GClass5_0.smethod_0(method_9);
		if (Boolean_2)
		{
			ListViewItem_0?.Remove();
		}
		method_6();
		gclass0_0.EndUpdate();
	}

	private void method_5(GClass5 gclass5_0)
	{
		Class6 @class = new Class6();
		@class.gclass5_0 = gclass5_0;
		IEnumerable<ListViewItem> ienumerable_ = gclass0_0.Items.Cast<ListViewItem>().Where(@class.method_0);
		Action<ListViewItem> action_ = _003C_003Ec._003C_003E9.method_8;
		ienumerable_.smethod_0(action_);
		eventHandler_1?.Invoke(this, EventArgs.Empty);
	}

	private void method_6()
	{
		Class7_0?.Remove();
		Class8_0?.Remove();
		if (GClass5_1.Length + (Boolean_1 ? 1 : 0) >= 2)
		{
			gclass0_0.method_1(new Class7());
			gclass0_0.method_1(new Class8());
			GClass5[] gClass5_ = GClass5_1;
			Func<GClass5, long> selector = _003C_003Ec._003C_003E9.method_9;
			long int64_ = gClass5_.Select(selector).Sum() + IPListEntry_0.Length;
			GClass5[] gClass5_2 = GClass5_1;
			Func<GClass5, long> selector2 = _003C_003Ec._003C_003E9.method_10;
			GStruct1 gStruct = (GStruct1)gClass5_2.Select(selector2).Sum();
			IPListEntry[] iPListEntry_ = IPListEntry_0;
			Func<IPListEntry, GStruct1> selector3 = _003C_003Ec._003C_003E9.method_11;
			GStruct1 gStruct1_ = gStruct + iPListEntry_.Select(selector3).smethod_0();
			Class8_0.Int64_0 = int64_;
			Class8_0.GStruct1_0 = gStruct1_;
			Class8_0.Int64_1 = GClass5_1.Count();
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_7()
	{
		gclass0_0 = new GClass0();
		columnHeader_0 = new ColumnHeader();
		columnHeader_1 = new ColumnHeader();
		columnHeader_2 = new ColumnHeader();
		columnHeader_3 = new ColumnHeader();
		SuspendLayout();
		gclass0_0.Columns.AddRange(new ColumnHeader[4] { columnHeader_0, columnHeader_1, columnHeader_2, columnHeader_3 });
		gclass0_0.Dock = DockStyle.Fill;
		gclass0_0.ColumnHeader_0 = new ColumnHeader[4] { columnHeader_0, columnHeader_1, columnHeader_2, columnHeader_3 };
		gclass0_0.FullRowSelect = true;
		gclass0_0.GridLines = true;
		gclass0_0.HideSelection = false;
		gclass0_0.Location = new Point(0, 0);
		gclass0_0.Name = "m_lstCountries";
		gclass0_0.Size = new Size(535, 214);
		gclass0_0.TabIndex = 26;
		gclass0_0.UseCompatibleStateImageBehavior = false;
		gclass0_0.View = View.Details;
		columnHeader_0.Text = "Country";
		columnHeader_0.Width = 190;
		columnHeader_1.Text = "Entries";
		columnHeader_1.Width = 100;
		columnHeader_2.Text = "Addresses";
		columnHeader_2.Width = 100;
		columnHeader_3.Text = "Updated";
		columnHeader_3.Width = 120;
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.Controls.Add(gclass0_0);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(4);
		base.Name = "GeoIPCountriesTable";
		base.Size = new Size(535, 214);
		ResumeLayout(performLayout: false);
	}

	private void gclass0_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		eventHandler_0?.Invoke(sender, e);
	}

	private void gclass0_0_KeyUp(object sender, KeyEventArgs e)
	{
		keyEventHandler_0?.Invoke(sender, e);
	}

	private void gclass0_0_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		mouseEventHandler_0?.Invoke(sender, e);
	}

	private void method_8(GClass5 gclass5_0)
	{
		method_2(gclass5_0);
	}

	private void method_9(GClass5 gclass5_0)
	{
		method_5(gclass5_0);
	}
}
