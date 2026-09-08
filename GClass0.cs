using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Threading;
using System.Windows.Forms;
using Properties;

public class GClass0 : ListView
{
	private class Class48 : Panel
	{
		private readonly Label label_0;

		private readonly System.Windows.Forms.Timer timer_0;

		public Class48(Control control_0)
		{
			timer_0 = new Class78
			{
				Enabled = false,
				eventHandler_0 = method_2
			};
			base.Visible = false;
			base.Parent = control_0;
			Dock = DockStyle.Bottom;
			ForeColor = Color.Blue;
			label_0 = new Label
			{
				Parent = this,
				Text = "",
				AutoSize = true,
				Top = 2
			};
			method_0();
		}

		private void method_0()
		{
			base.Height = TextRenderer.MeasureText(label_0.Text, label_0.Font).Height + 6;
			base.Padding = new Padding(2);
			base.Top = base.Parent.Height - base.Height;
		}

		public void method_1(string string_0, int int_0)
		{
			label_0.Text = string_0;
			timer_0.Interval = int_0;
			timer_0.Start();
			method_0();
			Show();
		}

		private void method_2(object sender, EventArgs e)
		{
			timer_0.Enabled = false;
			Hide();
		}
	}

	private class Class49 : NativeWindow
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

			public static Func<ColumnHeader, int> _003C_003E9__2_0;

			internal int method_0(ColumnHeader columnHeader_0)
			{
				return columnHeader_0.Width;
			}
		}

		private readonly ListView listView_0;

		public Class49(IntPtr intptr_0, ListView listView_1)
		{
			AssignHandle(intptr_0);
			listView_0 = listView_1;
		}

		protected override void WndProc(ref Message message_0)
		{
			base.WndProc(ref message_0);
			if (message_0.Msg != 15)
			{
				return;
			}
			using Graphics graphics = Graphics.FromHwnd(base.Handle);
			IEnumerable<ColumnHeader> source = listView_0.Columns.Cast<ColumnHeader>();
			Func<ColumnHeader, int> selector = _003C_003Ec._003C_003E9.method_0;
			Rectangle rect = new Rectangle(source.Sum(selector), 0, listView_0.Width - listView_0.Columns[listView_0.Columns.Count - 1].Width, listView_0.Height);
			using SolidBrush brush = new SolidBrush(Class70.color_1);
			graphics.FillRectangle(brush, rect);
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Action<ListViewItem> _003C_003E9__31_0;

		public static Action<ListViewItem> _003C_003E9__34_0;

		public static Action<ListViewItem> _003C_003E9__35_0;

		public static Action<ListViewItem> _003C_003E9__36_0;

		public static DrawListViewItemEventHandler _003C_003E9__39_1;

		internal void method_0(ListViewItem listViewItem_0)
		{
			listViewItem_0.Remove();
		}

		internal void method_1(ListViewItem listViewItem_0)
		{
			listViewItem_0.Selected = true;
		}

		internal void method_2(ListViewItem listViewItem_0)
		{
			listViewItem_0.Selected = !listViewItem_0.Selected;
		}

		internal void method_3(ListViewItem listViewItem_0)
		{
			listViewItem_0.Selected = false;
		}

		internal void method_4(object sender, DrawListViewItemEventArgs e)
		{
		}
	}

	private readonly Class48 class48_0;

	private Class49 class49_0;

	private EventHandler eventHandler_0;

	private EventHandler eventHandler_1;

	private bool bool_0;

	public bool Boolean_0 => base.Items.Count > 0;

	public bool Boolean_1
	{
		get
		{
			if (base.SelectedItems != null)
			{
				return base.SelectedItems.Count > 0;
			}
			return false;
		}
	}

	public bool Boolean_2
	{
		get
		{
			if (Boolean_1)
			{
				return 1 == base.SelectedItems.Count;
			}
			return false;
		}
	}

	public ColumnHeader[] ColumnHeader_0
	{
		get
		{
			return base.Columns.Cast<ColumnHeader>().ToArray();
		}
		set
		{
			base.Columns.Clear();
			base.Columns.AddRange(value);
		}
	}

	public ListViewItem[] ListViewItem_0 => base.Items.Cast<ListViewItem>().ToArray();

	public ListViewItem[] ListViewItem_1 => base.SelectedItems.Cast<ListViewItem>().ToArray();

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

	public GClass0()
	{
		SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
		SetStyle(ControlStyles.EnableNotifyMessage, value: true);
		if (!SystemInformation.TerminalServerSession)
		{
			DoubleBuffered = true;
			SetStyle(ControlStyles.ResizeRedraw, value: true);
		}
		class48_0 = new Class48(this);
		if (Class163.Class163_0.Boolean_0)
		{
			base.HandleCreated += GClass0_HandleCreated;
			base.HandleDestroyed += GClass0_HandleDestroyed;
		}
	}

	protected override void OnNotifyMessage(Message message_0)
	{
		if (message_0.Msg != 20)
		{
			base.OnNotifyMessage(message_0);
		}
	}

	protected void method_0()
	{
		eventHandler_0?.Invoke(this, EventArgs.Empty);
	}

	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	protected override void WndProc(ref Message message_0)
	{
		base.WndProc(ref message_0);
		if (message_0.Msg == 276 || message_0.Msg == 277 || message_0.Msg == 522)
		{
			method_0();
		}
	}

	public void method_1(ListViewItem listViewItem_0)
	{
		base.Items.Add(listViewItem_0);
		eventHandler_1?.Invoke(this, new EventArgs());
	}

	public void method_2(ListViewItem[] listViewItem_0)
	{
		base.Items.AddRange(listViewItem_0);
		eventHandler_1?.Invoke(this, new EventArgs());
	}

	public void method_3()
	{
		BeginUpdate();
		ListViewItem[] listViewItem_ = ListViewItem_1;
		Action<ListViewItem> action_ = _003C_003Ec._003C_003E9.method_0;
		listViewItem_.smethod_0(action_);
		EndUpdate();
	}

	public void method_4()
	{
		ListViewItem[] array = new ListViewItem[base.SelectedItems.Count];
		base.SelectedItems.CopyTo(array, 0);
		int num = array[0].Index - 1;
		if (num >= 0)
		{
			ListViewItem[] array2 = array;
			ListViewItem[] array3 = array2;
			foreach (ListViewItem listViewItem in array3)
			{
				listViewItem.Remove();
				base.Items.Insert(num++, listViewItem);
			}
		}
	}

	public void method_5()
	{
		ListViewItem[] array = new ListViewItem[base.SelectedItems.Count];
		base.SelectedItems.CopyTo(array, 0);
		int num = array[array.Length - 1].Index + 1;
		if (num < base.Items.Count)
		{
			ListViewItem[] array2 = array;
			ListViewItem[] array3 = array2;
			foreach (ListViewItem listViewItem in array3)
			{
				listViewItem.Remove();
				base.Items.Insert(num, listViewItem);
			}
		}
	}

	public virtual void SelectAll()
	{
		BeginUpdate();
		ListViewItem[] listViewItem_ = ListViewItem_0;
		Action<ListViewItem> action_ = _003C_003Ec._003C_003E9.method_1;
		listViewItem_.smethod_0(action_);
		EndUpdate();
	}

	public virtual void InvertSelection()
	{
		BeginUpdate();
		ListViewItem[] listViewItem_ = ListViewItem_0;
		Action<ListViewItem> action_ = _003C_003Ec._003C_003E9.method_2;
		listViewItem_.smethod_0(action_);
		EndUpdate();
	}

	public virtual void SelectNone()
	{
		BeginUpdate();
		ListViewItem[] listViewItem_ = ListViewItem_0;
		Action<ListViewItem> action_ = _003C_003Ec._003C_003E9.method_3;
		listViewItem_.smethod_0(action_);
		EndUpdate();
	}

	public void method_6(string string_0, int int_0)
	{
		class48_0.method_1(string_0, int_0);
	}

	public void method_7()
	{
		if (Class163.Class163_0.Boolean_0 && !bool_0)
		{
			method_8();
			if (View.Details == base.View && base.Columns.Count >= 1)
			{
				base.GridLines = false;
				base.OwnerDraw = true;
				base.ResizeRedraw = true;
				base.DrawColumnHeader += GClass0_DrawColumnHeader;
				DrawListViewItemEventHandler value = _003C_003Ec._003C_003E9.method_4;
				base.DrawItem += value;
				base.DrawSubItem += GClass0_DrawSubItem;
				bool_0 = true;
			}
		}
	}

	private void method_8()
	{
		if (BackgroundImage == null)
		{
			Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.Clear(BackColor);
			}
			BackgroundImage = bitmap;
		}
	}

	public void method_9(int int_0 = 30)
	{
		if (base.Columns.Count < 1)
		{
			return;
		}
		int[] array = new int[base.Columns.Count];
		IEnumerator enumerator = base.Columns.GetEnumerator();
		try
		{
			while (enumerator.MoveNext() ? true : false)
			{
				ColumnHeader columnHeader = (ColumnHeader)enumerator.Current;
				array[columnHeader.Index] = TextRenderer.MeasureText(columnHeader.Text, Font).Width;
			}
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}
		enumerator = base.Items.GetEnumerator();
		try
		{
			while (enumerator.MoveNext() ? true : false)
			{
				ListViewItem listViewItem = (ListViewItem)enumerator.Current;
				if (listViewItem == null)
				{
					continue;
				}
				for (int i = 0; i < base.Columns.Count; i++)
				{
					if (listViewItem.SubItems.Count > i)
					{
						int num = TextRenderer.MeasureText(listViewItem.SubItems[i].Text, Font).Width;
						if (num > array[i])
						{
							array[i] = num;
						}
					}
				}
			}
		}
		finally
		{
			IDisposable disposable2 = enumerator as IDisposable;
			if (disposable2 != null)
			{
				disposable2.Dispose();
			}
		}
		int num2 = ((base.CheckBoxes ? true : false) ? array.Skip(1).Sum() : array.Sum());
		if (num2 < 1)
		{
			return;
		}
		double[] array2 = new double[base.Columns.Count];
		if (base.CheckBoxes)
		{
			array2[0] = int_0;
			for (int j = 1; j < base.Columns.Count; j++)
			{
				array2[j] = (double)array[j] / (double)num2;
			}
		}
		else
		{
			for (int k = 0; k < base.Columns.Count; k++)
			{
				array2[k] = (double)array[k] / (double)num2;
			}
		}
		int num3 = base.Width - ((method_10() ? true : false) ? SystemInformation.VerticalScrollBarWidth : 0) - ((base.CheckBoxes ? true : false) ? int_0 : 0);
		if (!Class163.Class163_0.Boolean_0)
		{
			num3 -= 4;
		}
		if (base.CheckBoxes)
		{
			for (int l = 1; l < base.Columns.Count; l++)
			{
				base.Columns[l].Width = (int)((double)num3 * array2[l]);
			}
			base.Columns[0].Width = int_0;
		}
		else
		{
			for (int m = 0; m < base.Columns.Count; m++)
			{
				base.Columns[m].Width = (int)((double)num3 * array2[m]);
			}
		}
		Class181.SendMessage(base.Handle, 4116u, IntPtr.Zero, IntPtr.Zero);
	}

	private bool method_10()
	{
		return (Class181.GetWindowLong(base.Handle, -16) & 0x200000) != 0;
	}

	private void GClass0_HandleCreated(object sender, EventArgs e)
	{
		IntPtr intptr_ = Class181.SendMessage(base.Handle, 4127u, IntPtr.Zero, IntPtr.Zero);
		class49_0 = new Class49(intptr_, this);
	}

	private void GClass0_HandleDestroyed(object sender, EventArgs e)
	{
		class49_0?.ReleaseHandle();
	}

	private void GClass0_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
	{
		using (SolidBrush brush = new SolidBrush((e.State.HasFlag(ListViewItemStates.Selected) ? true : false) ? Class70.color_5 : Class70.color_15))
		{
			e.Graphics.FillRectangle(brush, e.Bounds);
		}
		using (Pen pen = new Pen(Class70.color_14))
		{
			e.Graphics.DrawLine(pen, e.Bounds.Left, e.Bounds.Bottom - 1, e.Bounds.Right, e.Bounds.Bottom - 1);
			e.Graphics.DrawLine(pen, e.Bounds.Right - 1, e.Bounds.Top, e.Bounds.Right - 1, e.Bounds.Bottom);
		}
		using (SolidBrush brush2 = new SolidBrush((base.Enabled ? true : false) ? Class70.color_2 : Class70.color_10))
		{
			Point point = new Point(e.Bounds.X + 6, e.Bounds.Y + (e.Bounds.Height - e.Font.Height) / 2);
			e.Graphics.DrawString(e.Header.Text, e.Font, brush2, point);
		}
		int int_;
		SortOrder sortOrder = this.smethod_1(out int_);
		if (sortOrder != SortOrder.None && e.ColumnIndex == int_)
		{
			Bitmap bitmap = ((SortOrder.Ascending == sortOrder) ? Resources.sort_ascending : Resources.sort_descending);
			Point point2 = new Point(e.Bounds.X + (e.Bounds.Width - bitmap.Width) / 2, 1);
			e.Graphics.DrawImage(bitmap, point2);
		}
	}

	private void GClass0_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
	{
		if (e.Item.Selected)
		{
			using SolidBrush brush = new SolidBrush(Class70.color_5);
			e.Graphics.FillRectangle(brush, e.Bounds);
		}
		else
		{
			using SolidBrush brush2 = new SolidBrush(Class70.color_1);
			e.Graphics.FillRectangle(brush2, e.Bounds);
		}
		int num;
		int num2;
		if (base.SmallImageList != null && e.ColumnIndex == 0)
		{
			num = ((e.Item.ImageIndex > -1) ? 1 : 0);
			if ((num != 0) ? true : false)
			{
				num2 = base.SmallImageList.ImageSize.Width + 6;
				goto IL_00f0;
			}
		}
		else
		{
			num = 0;
		}
		num2 = 0;
		goto IL_00f0;
		IL_00f0:
		int num3 = num2;
		if (num != 0)
		{
			Image image = base.SmallImageList.Images[e.Item.ImageIndex];
			Point point = new Point(e.Bounds.X + 6, e.Bounds.Y + (e.Bounds.Height - image.Height) / 2);
			e.Graphics.DrawImage(image, point);
		}
		using (Pen pen = new Pen(Class70.color_14))
		{
			e.Graphics.DrawLine(pen, e.Bounds.Right - 1, e.Bounds.Top, e.Bounds.Right - 1, e.Bounds.Bottom);
			e.Graphics.DrawLine(pen, e.Bounds.Left, e.Bounds.Bottom - 1, e.Bounds.Right, e.Bounds.Bottom - 1);
		}
		if (!string.IsNullOrEmpty(e.SubItem.Text))
		{
			Color color = ((base.Enabled ? true : false) ? Class70.color_2 : Class70.color_10);
			if (base.CheckBoxes && !e.Item.Checked)
			{
				color = Class70.color_16;
			}
			using (new SolidBrush(color))
			{
				Point location = new Point(e.Bounds.X + num3 + 6, e.Bounds.Y + (e.Bounds.Height - Font.Height) / 2);
				string text = e.SubItem.Text;
				if (text.smethod_1(new string[2] { "\r", "\n" }))
				{
					text = text.Replace("\r", " ").Replace("\n", " ");
				}
				if (text.Length > 10000)
				{
					text = text.Substring(0, 10000);
				}
				Rectangle bounds = new Rectangle(location, e.Bounds.Size);
				try
				{
					TextRenderer.DrawText(e.Graphics, text, Font, bounds, color, TextFormatFlags.EndEllipsis);
				}
				catch (Exception arg)
				{
					Class208.smethod_0($"ListViewWithScroll::DrawSubItem::DrawString:{arg}");
				}
			}
		}
		if (e.ColumnIndex == 0 && base.CheckBoxes)
		{
			Bitmap bitmap = ((e.Item.Checked ? true : false) ? Resources.checkbox_dark_enabled_checked : Resources.checkbox_dark_enabled_unchecked);
			Point point2 = new Point(e.Bounds.X + 6, e.Bounds.Y + (e.Bounds.Height - bitmap.Height) / 2);
			e.Graphics.DrawImage(bitmap, point2);
		}
	}
}
