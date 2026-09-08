using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal class Form0 : Form
{
	private sealed class Class44
	{
		public Action action_0;

		public Action action_1;

		public KeyEventHandler keyEventHandler_0;

		public EventHandler eventHandler_0;

		internal void method_0(object sender, KeyEventArgs e)
		{
			bool flag = Keys.Return == e.KeyCode;
			if (sender is TextBox { Multiline: not false })
			{
				flag &= e.Control;
			}
			if (flag)
			{
				action_0();
			}
		}

		internal void method_1(object sender, EventArgs e)
		{
			action_1();
		}
	}

	private sealed class Class45
	{
		public Control control_0;

		internal void method_0(object sender, EventArgs e)
		{
			control_0.ForeColor = ((control_0.Enabled ? true : false) ? Class70.color_2 : Class70.color_10);
		}
	}

	protected virtual Button Button_0 => null;

	public Form0()
		: this(Size.Empty)
	{
	}

	public Form0(Size size_0)
	{
		base.Icon = Resources.rdpguard_16x16_icon;
		MinimumSize = ((size_0.IsEmpty ? true : false) ? new Size(800, 600) : size_0);
		base.Shown += Form0_Shown;
		base.FormClosing += Form0_FormClosing;
		smethod_0(this);
		smethod_1(this);
	}

	protected void method_0()
	{
		if (Class161.Boolean_0)
		{
			Text += " (Administrator)";
		}
	}

	public static void smethod_0(Control control_0)
	{
		Class45 @class = new Class45();
		@class.control_0 = control_0;
		if (!Class163.Class163_0.Boolean_0)
		{
			return;
		}
		@class.control_0.BackColor = Class70.color_1;
		@class.control_0.ForeColor = ((@class.control_0.Enabled ? true : false) ? Class70.color_2 : Class70.color_10);
		@class.control_0.EnabledChanged += @class.method_0;
		IEnumerator enumerator = @class.control_0.Controls.GetEnumerator();
		try
		{
			while (enumerator.MoveNext() ? true : false)
			{
				Control control = (Control)enumerator.Current;
				Color foreColor = control.ForeColor;
				control.BackColor = Class70.color_1;
				control.ForeColor = Class70.color_2;
				if (control is Button button)
				{
					button.FlatStyle = FlatStyle.Flat;
				}
				if (control is TextBox textBox)
				{
					textBox.BackColor = Class70.color_8;
					textBox.BorderStyle = BorderStyle.FixedSingle;
				}
				if (control.Parent != null && control.Parent is TextBox textBox2)
				{
					textBox2.BackColor = Class70.color_8;
				}
				if (control.Name.EndsWith("Hint") || false || control is GClass2)
				{
					control.BackColor = Class70.color_1;
					control.ForeColor = Class70.color_9;
				}
				if (control is GClass2 gClass)
				{
					gClass.BorderStyle = BorderStyle.None;
					if (gClass.Boolean_0)
					{
						gClass.ForeColor = foreColor;
					}
				}
				if (control is Class62 { Boolean_0: not false } class2)
				{
					class2.ForeColor = foreColor;
				}
				if ("ThemeIndependentForeColor" == control.Tag?.ToString())
				{
					control.ForeColor = foreColor;
				}
				if (control is ComboBox comboBox)
				{
					comboBox.FlatStyle = FlatStyle.Flat;
				}
				if (control is Class0 class3)
				{
					class3.DrawMode = DrawMode.OwnerDrawFixed;
				}
				if (control is ListView listView)
				{
					listView.BorderStyle = BorderStyle.FixedSingle;
					if (listView is ListViewWithScroll gClass2)
					{
						gClass2.method_7();
					}
				}
				if (control is ToolStrip toolStrip)
				{
					toolStrip.GripStyle = ToolStripGripStyle.Hidden;
					toolStrip.RenderMode = ToolStripRenderMode.Professional;
					toolStrip.Renderer = new Class59();
					smethod_2(toolStrip.Items);
				}
				if (control is StatusStrip statusStrip)
				{
					statusStrip.RenderMode = ToolStripRenderMode.Professional;
					statusStrip.Renderer = new Class59();
					smethod_2(statusStrip.Items);
				}
				if (control is DataGridView dataGridView)
				{
					dataGridView.BackgroundColor = Class70.color_1;
					dataGridView.DefaultCellStyle.BackColor = Class70.color_1;
					dataGridView.DefaultCellStyle.ForeColor = Class70.color_2;
					dataGridView.DefaultCellStyle.SelectionBackColor = Class70.color_5;
					dataGridView.DefaultCellStyle.SelectionForeColor = Class70.color_4;
					dataGridView.GridColor = Class70.color_14;
					dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Class70.color_15;
					dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Class70.color_2;
					dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Class70.color_3;
					dataGridView.ColumnHeadersDefaultCellStyle.SelectionForeColor = Class70.color_4;
					dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
					dataGridView.BorderStyle = BorderStyle.FixedSingle;
					dataGridView.EnableHeadersVisualStyles = false;
				}
				if (control.ContextMenuStrip != null)
				{
					smethod_2(control.ContextMenuStrip.Items);
				}
				if (control.HasChildren)
				{
					smethod_0(control);
				}
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
	}

	public static void smethod_1(Control control_0)
	{
		if (!Class163.Class163_0.Boolean_0)
		{
			return;
		}
		int[] int_ = new int[1] { 1 };
		Class181.SetWindowTheme(control_0.Handle, "DarkMode_Explorer", null);
		if (Class181.DwmSetWindowAttribute(control_0.Handle, 19, int_, 4) != 0)
		{
			Class181.DwmSetWindowAttribute(control_0.Handle, 20, int_, 4);
		}
		IEnumerator enumerator = control_0.Controls.GetEnumerator();
		try
		{
			while (enumerator.MoveNext() ? true : false)
			{
				smethod_1((Control)enumerator.Current);
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
	}

	public static void smethod_2(ToolStripItemCollection toolStripItemCollection_0)
	{
		if (!Class163.Class163_0.Boolean_0)
		{
			return;
		}
		IEnumerator enumerator = toolStripItemCollection_0.GetEnumerator();
		try
		{
			while (enumerator.MoveNext() ? true : false)
			{
				ToolStripItem toolStripItem = (ToolStripItem)enumerator.Current;
				Color foreColor = toolStripItem.ForeColor;
				toolStripItem.BackColor = Class70.color_1;
				toolStripItem.ForeColor = Class70.color_2;
				if (toolStripItem is ToolStripMenuItem toolStripMenuItem)
				{
					smethod_2(toolStripMenuItem.DropDownItems);
				}
				if (toolStripItem is ToolStripDropDownItem toolStripDropDownItem)
				{
					smethod_2(toolStripDropDownItem.DropDownItems);
				}
				if (toolStripItem is ToolStripTextBox toolStripTextBox)
				{
					toolStripTextBox.BackColor = Class70.color_8;
				}
				if ("ThemeIndependentForeColor" == toolStripItem.Tag?.ToString())
				{
					toolStripItem.ForeColor = foreColor;
				}
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
	}

	public void method_1()
	{
		IEnumerator enumerator = Application.OpenForms.GetEnumerator();
		try
		{
			while (enumerator.MoveNext() ? true : false)
			{
				Form form = (Form)enumerator.Current;
				if (form.GetType() == GetType())
				{
					form.Focus();
					return;
				}
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
		Show();
	}

	protected virtual void vmethod_0()
	{
	}

	public static void smethod_3(Control control_0, Action action_0, Action action_1)
	{
		Class44 @class = new Class44();
		@class.action_0 = action_0;
		@class.action_1 = action_1;
		IEnumerator enumerator = control_0.Controls.GetEnumerator();
		try
		{
			while (enumerator.MoveNext() ? true : false)
			{
				Control control = (Control)enumerator.Current;
				KeyEventHandler value = @class.method_0;
				control.KeyUp += value;
				EventHandler value2 = @class.method_1;
				control.TextChanged += value2;
				if (control.HasChildren)
				{
					smethod_3(control, @class.action_0, @class.action_1);
				}
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
	}

	protected void method_2(Control control_0)
	{
		IEnumerator enumerator = control_0.Controls.GetEnumerator();
		try
		{
			while (enumerator.MoveNext() ? true : false)
			{
				Control control = (Control)enumerator.Current;
				control.KeyDown += Form0_KeyDown;
				if (control.HasChildren)
				{
					method_2(control);
				}
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
		base.KeyDown += Form0_KeyDown;
	}

	private void Form0_KeyDown(object sender, KeyEventArgs e)
	{
		if (Keys.Escape == e.KeyCode)
		{
			if ((0 | (method_3(this, "btnCancel") ? 1 : 0) | (method_3(this, "m_btnCancel") ? 1 : 0) | (method_3(this, "btnClose") ? 1 : 0) | (method_3(this, "m_btnClose") ? 1 : 0)) == 0 && !(this is DashboardDialog))
			{
				method_8(DialogResult.Cancel);
			}
		}
		else if (Keys.F1 == e.KeyCode)
		{
			method_3(this, "lnkOnlineHelp");
			method_3(this, "m_lnkOnlineHelp");
		}
	}

	private bool method_3(Control control_0, string string_0)
	{
		IEnumerator enumerator = control_0.Controls.GetEnumerator();
		try
		{
			while (enumerator.MoveNext() ? true : false)
			{
				Control control = (Control)enumerator.Current;
				if (string_0 == control.Name)
				{
					if (control is Button button)
					{
						button.PerformClick();
						return true;
					}
					if (control is GClass3 gClass)
					{
						gClass.method_0();
						return true;
					}
				}
				if (!control.HasChildren || !method_3(control, string_0))
				{
					if (!(control is ToolStrip toolStrip))
					{
						continue;
					}
					{
						IEnumerator enumerator2 = toolStrip.Items.GetEnumerator();
						try
						{
							while (enumerator2.MoveNext() ? true : false)
							{
								ToolStripItem toolStripItem = (ToolStripItem)enumerator2.Current;
								if (string_0 == toolStripItem.Name)
								{
									toolStripItem.PerformClick();
									return true;
								}
							}
						}
						finally
						{
							IDisposable disposable2 = enumerator2 as IDisposable;
							if (disposable2 != null)
							{
								disposable2.Dispose();
							}
						}
					}
					continue;
				}
				return true;
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
		return false;
	}

	private Size method_4(Size size_0, int int_0, int int_1)
	{
		float num = (float)Class11.smethod_0(int_0, int_1) / 100f;
		return new Size((int)((float)size_0.Width * num), (int)((float)size_0.Height * num));
	}

	public virtual void vmethod_1(bool bool_0 = false)
	{
		if (base.StartPosition != FormStartPosition.Manual)
		{
			base.StartPosition = FormStartPosition.Manual;
		}
		Rectangle virtualScreen = SystemInformation.VirtualScreen;
		Point point = new Point(SystemInformation.PrimaryMonitorSize.Width / 2 - base.Width / 2, SystemInformation.PrimaryMonitorSize.Height / 2 - base.Height / 2);
		int int32_ = base.Width;
		int int32_2 = base.Height;
		int int32_3 = point.X;
		int int32_4 = point.Y;
		bool flag = false;
		Class166 @class = Class163.Class163_0.class166_5.method_1(base.Name);
		if (@class != null)
		{
			Class166 class2 = @class.method_1("Width");
			if (class2 != null)
			{
				int32_ = class2.Int32_0;
			}
			Class166 class3 = @class.method_1("Height");
			if (class3 != null)
			{
				int32_2 = class3.Int32_0;
			}
			Class166 class4 = @class.method_1("Left");
			if (class4 != null)
			{
				int32_3 = class4.Int32_0;
			}
			Class166 class5 = @class.method_1("Top");
			if (class5 != null)
			{
				int32_4 = class5.Int32_0;
			}
			Class166 class6 = @class.method_1("Maximized");
			if (class6 != null)
			{
				flag = class6.Boolean_0;
			}
		}
		if (int32_3 >= virtualScreen.Left && int32_3 < virtualScreen.Width)
		{
			base.Left = int32_3;
		}
		if (int32_4 >= virtualScreen.Top - 4 && int32_4 < virtualScreen.Height)
		{
			base.Top = int32_4;
		}
		if (bool_0)
		{
			MinimumSize = method_4(MinimumSize, base.Left, base.Top);
		}
		if (int32_ >= MinimumSize.Width && int32_ <= virtualScreen.Width)
		{
			base.Width = int32_;
		}
		if (int32_2 >= MinimumSize.Height && int32_2 <= virtualScreen.Height)
		{
			base.Height = int32_2;
		}
		base.WindowState = ((flag ? true : false) ? FormWindowState.Maximized : FormWindowState.Normal);
		vmethod_2();
	}

	public virtual void vmethod_2()
	{
		IEnumerator enumerator = base.Controls.GetEnumerator();
		try
		{
			while (enumerator.MoveNext() ? true : false)
			{
				Control control = (Control)enumerator.Current;
				if (control is Label)
				{
					int num = control.Left + control.Width + SystemInformation.Border3DSize.Width * 2 + 15;
					int left = control.Left;
					if (base.Width < num)
					{
						base.Width = num;
					}
					if (control is LinkLabel && control.Left > left)
					{
						control.Left = left;
					}
				}
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
	}

	public void method_5(Control.ControlCollection controlCollection_0)
	{
		if (controlCollection_0 == null || controlCollection_0.Count == 0)
		{
			return;
		}
		Class166 @class = Class163.Class163_0.class166_5.method_1(base.Name);
		if (@class == null)
		{
			return;
		}
		IEnumerator enumerator = controlCollection_0.GetEnumerator();
		try
		{
			while (enumerator.MoveNext() ? true : false)
			{
				Control control = (Control)enumerator.Current;
				if (control is ListView listView)
				{
					{
						IEnumerator enumerator2 = listView.Columns.GetEnumerator();
						try
						{
							while (enumerator2.MoveNext() ? true : false)
							{
								ColumnHeader columnHeader = (ColumnHeader)enumerator2.Current;
								if (columnHeader.smethod_0(@class, out var class166_))
								{
									columnHeader.Width = class166_.Int32_0;
								}
							}
						}
						finally
						{
							IDisposable disposable2 = enumerator2 as IDisposable;
							if (disposable2 != null)
							{
								disposable2.Dispose();
							}
						}
					}
				}
				if (control is DataGridView dataGridView)
				{
					{
						IEnumerator enumerator3 = dataGridView.Columns.GetEnumerator();
						try
						{
							while (enumerator3.MoveNext() ? true : false)
							{
								DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)enumerator3.Current;
								if (dataGridViewColumn.smethod_0(@class, out var class166_2))
								{
									dataGridViewColumn.Width = class166_2.Int32_0;
								}
							}
						}
						finally
						{
							IDisposable disposable3 = enumerator3 as IDisposable;
							if (disposable3 != null)
							{
								disposable3.Dispose();
							}
						}
					}
				}
				if (control is SplitContainer splitContainer)
				{
					try
					{
						if (splitContainer.smethod_0(@class, out var class166_3))
						{
							splitContainer.SplitterDistance = class166_3.Int32_0;
						}
					}
					catch (InvalidOperationException ex)
					{
						Class208.smethod_0(ex.ToString());
					}
				}
				method_5(control.Controls);
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
	}

	public void method_6()
	{
		Class166 @class = new Class166(base.Name);
		if (FormWindowState.Minimized != base.WindowState)
		{
			@class.method_0(new Class166("Top", base.Top));
			@class.method_0(new Class166("Left", base.Left));
		}
		if (FormWindowState.Maximized != base.WindowState && FormWindowState.Minimized != base.WindowState)
		{
			@class.method_0(new Class166("Width", base.Width));
			@class.method_0(new Class166("Height", base.Height));
		}
		@class.method_0(new Class166("Maximized", FormWindowState.Maximized == base.WindowState));
		try
		{
			method_7(@class, base.Controls);
		}
		catch (Exception ex)
		{
			Class208.smethod_1(ex.ToString());
		}
		Class163.Class163_0.class166_5.method_0(@class);
		Class163.Class163_0.method_3();
	}

	public void method_7(Class166 class166_0, Control.ControlCollection controlCollection_0)
	{
		if (controlCollection_0 == null || controlCollection_0.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = controlCollection_0.GetEnumerator();
		try
		{
			while (enumerator.MoveNext() ? true : false)
			{
				Control control = (Control)enumerator.Current;
				if (control is ListView listView)
				{
					{
						IEnumerator enumerator2 = listView.Columns.GetEnumerator();
						try
						{
							while (enumerator2.MoveNext() ? true : false)
							{
								ColumnHeader columnHeader = (ColumnHeader)enumerator2.Current;
								if (columnHeader.smethod_1(out var string_))
								{
									class166_0.method_0(new Class166(string_, columnHeader.Width));
								}
							}
						}
						finally
						{
							IDisposable disposable2 = enumerator2 as IDisposable;
							if (disposable2 != null)
							{
								disposable2.Dispose();
							}
						}
					}
				}
				if (control is DataGridView dataGridView)
				{
					{
						IEnumerator enumerator3 = dataGridView.Columns.GetEnumerator();
						try
						{
							while (enumerator3.MoveNext() ? true : false)
							{
								DataGridViewTextBoxColumn dataGridViewTextBoxColumn = (DataGridViewTextBoxColumn)enumerator3.Current;
								if (dataGridViewTextBoxColumn.smethod_1(out var string_2))
								{
									class166_0.method_0(new Class166(string_2, dataGridViewTextBoxColumn.Width));
								}
							}
						}
						finally
						{
							IDisposable disposable3 = enumerator3 as IDisposable;
							if (disposable3 != null)
							{
								disposable3.Dispose();
							}
						}
					}
				}
				if (control is SplitContainer splitContainer && splitContainer.smethod_1(out var string_3))
				{
					class166_0.method_0(new Class166(string_3, splitContainer.SplitterDistance));
				}
				method_7(class166_0, control.Controls);
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
	}

	protected void method_8(DialogResult dialogResult_0)
	{
		base.DialogResult = dialogResult_0;
		Close();
	}

	protected void method_9(string string_0)
	{
		Help.ShowHelp(this, string_0);
	}

	private void Form0_Shown(object sender, EventArgs e)
	{
		method_5(base.Controls);
		smethod_3(this, method_10, vmethod_0);
		method_2(this);
		smethod_0(this);
		smethod_1(this);
		method_0();
	}

	private void method_10()
	{
		Button_0?.PerformClick();
	}

	private void Form0_FormClosing(object sender, FormClosingEventArgs e)
	{
		method_6();
	}
}
