using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Properties;

internal sealed class Class12
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<Class157, ListViewItem> _003C_003E9__9_0;

		public static EventHandler _003C_003E9__15_6;

		public static Func<ListViewItem, string> _003C_003E9__17_0;

		public static Func<ListViewItem, string> _003C_003E9__19_0;

		public static Action<ListViewItem> _003C_003E9__21_0;

		internal ListViewItem method_0(Class157 class157_0)
		{
			return new ListViewItem(class157_0.ToString(), dictionary_0[class157_0.genum12_0]);
		}

		internal void method_1(object sender, EventArgs e)
		{
			smethod_0();
		}

		internal string method_2(ListViewItem listViewItem_0)
		{
			return listViewItem_0.Text + "\r\n";
		}

		internal string method_3(ListViewItem listViewItem_0)
		{
			return listViewItem_0.Text + "\r\n";
		}

		internal void method_4(ListViewItem listViewItem_0)
		{
			listViewItem_0.Selected = true;
		}
	}

	private static readonly Dictionary<GEnum12, int> dictionary_0 = new Dictionary<GEnum12, int>
	{
		{
			GEnum12.const_0,
			0
		},
		{
			GEnum12.const_1,
			0
		},
		{
			GEnum12.const_2,
			0
		},
		{
			GEnum12.const_3,
			0
		}
	};

	private readonly GClass0 gclass0_0;

	private readonly List<Class157> list_0 = new List<Class157>();

	private Class78 class78_0;

	public Class12(GClass0 gclass0_1)
	{
		gclass0_0 = gclass0_1;
		method_6();
		method_7();
		Class89.eventHandler_1 = (EventHandler<EventArgs12>)Delegate.Combine(Class89.eventHandler_1, new EventHandler<EventArgs12>(method_1));
		if (Class89.Boolean_0)
		{
			Class89.smethod_38();
		}
		class78_0 = new Class78
		{
			Interval = 100,
			Enabled = true,
			eventHandler_0 = method_16
		};
	}

	public void method_0()
	{
		if (class78_0 != null)
		{
			class78_0.Stop();
			class78_0.Dispose();
			class78_0 = null;
		}
		Class89.eventHandler_1 = (EventHandler<EventArgs12>)Delegate.Remove(Class89.eventHandler_1, new EventHandler<EventArgs12>(method_1));
	}

	private void method_1(object sender, EventArgs12 e)
	{
		lock (list_0)
		{
			list_0.AddRange(e.class157_0);
		}
	}

	private void method_2()
	{
		if (gclass0_0 != null && !gclass0_0.IsDisposed)
		{
			ListViewItem[] array = method_3();
			if (array.Any())
			{
				gclass0_0.BeginUpdate();
				gclass0_0.method_2(array);
				method_4();
				method_5();
				gclass0_0.EndUpdate();
			}
		}
	}

	private ListViewItem[] method_3()
	{
		lock (list_0)
		{
			try
			{
				List<Class157> source = list_0;
				Func<Class157, ListViewItem> selector = _003C_003Ec._003C_003E9.method_0;
				return source.Select(selector).ToArray();
			}
			finally
			{
				list_0.Clear();
			}
		}
	}

	private void method_4()
	{
		while (gclass0_0.Items.Count > 1000)
		{
			gclass0_0.Items.RemoveAt(0);
		}
	}

	private void method_5()
	{
		try
		{
			if (gclass0_0.Items.Count > 0)
			{
				gclass0_0.EnsureVisible(gclass0_0.Items.Count - 1);
			}
		}
		catch
		{
		}
	}

	private void method_6()
	{
		method_8();
		gclass0_0.ContextMenuStrip = method_9();
	}

	private void method_7()
	{
		gclass0_0.Resize += gclass0_0_Resize;
	}

	private void method_8()
	{
		if (gclass0_0.SmallImageList == null)
		{
			gclass0_0.SmallImageList = new ImageList
			{
				ImageSize = new Size(16, 16),
				ColorDepth = ColorDepth.Depth8Bit,
				TransparentColor = Color.Transparent
			};
		}
		dictionary_0[GEnum12.const_0] = gclass0_0.SmallImageList.Images.Count;
		dictionary_0[GEnum12.const_1] = gclass0_0.SmallImageList.Images.Count;
		gclass0_0.SmallImageList.Images.Add(Resources.informaion_16);
		dictionary_0[GEnum12.const_2] = gclass0_0.SmallImageList.Images.Count;
		gclass0_0.SmallImageList.Images.Add(Resources.warning_16);
		dictionary_0[GEnum12.const_3] = gclass0_0.SmallImageList.Images.Count;
		gclass0_0.SmallImageList.Images.Add(Resources.error_16);
	}

	private ContextMenuStrip method_9()
	{
		Class57 @class = new Class57();
		ToolStripItem[] array = new ToolStripItem[9]
		{
			new Class56
			{
				Text = "Clear Event Log",
				Name = "Clear",
				ShortcutKeys = (Keys.L | Keys.Control),
				Image = Resources.trash_16,
				Enabled = false,
				eventHandler_0 = method_17
			},
			new ToolStripSeparator(),
			new Class56
			{
				Text = "Copy All Messages",
				Name = "CopyAll",
				ShortcutKeys = (Keys.C | Keys.Shift | Keys.Control),
				Image = Resources.copy_16,
				Enabled = false,
				eventHandler_0 = method_18
			},
			new Class56
			{
				Text = "Copy Selection",
				Name = "CopySelection",
				ShortcutKeys = (Keys.C | Keys.Control),
				Image = Resources.copy_16,
				Enabled = false,
				eventHandler_0 = method_19
			},
			new ToolStripSeparator(),
			new Class56
			{
				Text = "Save All Messages",
				Name = "SaveAll",
				ShortcutKeys = (Keys.S | Keys.Control),
				Image = Resources.save_16,
				Enabled = false,
				eventHandler_0 = method_20
			},
			new Class56
			{
				Text = "Select All Messages",
				Name = "SelectAll",
				ShortcutKeys = (Keys.A | Keys.Control),
				Image = Resources.select_all,
				Enabled = false,
				eventHandler_0 = method_21
			},
			new ToolStripSeparator(),
			null
		};
		Class56 class2 = new Class56
		{
			Text = "View Log Files",
			ShortcutKeys = (Keys.E | Keys.Control),
			Image = Resources.foldr_16_aqua,
			Enabled = true
		};
		EventHandler eventHandler_ = _003C_003Ec._003C_003E9.method_1;
		class2.eventHandler_0 = eventHandler_;
		array[8] = class2;
		@class.ToolStripItem_0 = array;
		@class.cancelEventHandler_0 = method_22;
		return @class;
	}

	private void method_10()
	{
		gclass0_0.Items.Clear();
	}

	private string method_11()
	{
		IEnumerable<ListViewItem> source = gclass0_0.Items.Cast<ListViewItem>();
		Func<ListViewItem, string> selector = _003C_003Ec._003C_003E9.method_2;
		return string.Join(null, source.Select(selector));
	}

	private void method_12()
	{
		Class77.smethod_0(method_11());
	}

	private void method_13()
	{
		IEnumerable<ListViewItem> source = gclass0_0.SelectedItems.Cast<ListViewItem>();
		Func<ListViewItem, string> selector = _003C_003Ec._003C_003E9.method_3;
		Class77.smethod_0(string.Join(null, source.Select(selector)));
	}

	private void method_14()
	{
		SaveFileDialog saveFileDialog = new SaveFileDialog
		{
			Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
		};
		using (saveFileDialog)
		{
			if (DialogResult.OK == saveFileDialog.ShowDialog())
			{
				File.WriteAllText(saveFileDialog.FileName, method_11(), Encoding.UTF8);
			}
		}
	}

	private void method_15()
	{
		IEnumerable<ListViewItem> ienumerable_ = gclass0_0.Items.Cast<ListViewItem>();
		Action<ListViewItem> action_ = _003C_003Ec._003C_003E9.method_4;
		ienumerable_.smethod_0(action_);
	}

	public static void smethod_0()
	{
		Process.Start("explorer.exe", Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "RdpGuard"), "logs"));
	}

	private void method_16(object sender, EventArgs e)
	{
		method_2();
	}

	private void gclass0_0_Resize(object sender, EventArgs e)
	{
		gclass0_0.Columns[0].Width = gclass0_0.ClientSize.Width - 4;
	}

	private void method_17(object sender, EventArgs e)
	{
		method_10();
	}

	private void method_18(object sender, EventArgs e)
	{
		method_12();
	}

	private void method_19(object sender, EventArgs e)
	{
		method_13();
	}

	private void method_20(object sender, EventArgs e)
	{
		method_14();
	}

	private void method_21(object sender, EventArgs e)
	{
		method_15();
	}

	private void method_22(object sender, CancelEventArgs e)
	{
		gclass0_0.ContextMenuStrip.Items["Clear"].Enabled = gclass0_0.Boolean_0;
		gclass0_0.ContextMenuStrip.Items["CopyAll"].Enabled = gclass0_0.Boolean_0;
		gclass0_0.ContextMenuStrip.Items["CopySelection"].Enabled = gclass0_0.Boolean_1;
		gclass0_0.ContextMenuStrip.Items["SaveAll"].Enabled = gclass0_0.Boolean_0;
		gclass0_0.ContextMenuStrip.Items["SelectAll"].Enabled = gclass0_0.Boolean_0;
	}
}
