using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Properties;
using rdpguard_ui;
using rdpguard.lib;

internal sealed class IPListDialog : Form0
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Action<IPListViewItem> _003C_003E9__22_0;

		public static Func<string, string[]> _003C_003E9__30_0;

		public static Func<string[], IPListEntry> _003C_003E9__30_1;

		public static Func<IPListViewItem, IPListEntry> _003C_003E9__31_0;

		public static Func<IPListEntry, string> _003C_003E9__32_0;

		public static Func<IPListEntry, string> _003C_003E9__33_0;

		public static Action<ListViewItem> _003C_003E9__40_6;

		internal void method_0(IPListViewItem iplistViewItem_0)
		{
			iplistViewItem_0.Remove();
		}

		internal string[] method_1(string string_0)
		{
			return string_0.smethod_7();
		}

		internal IPListEntry method_2(string[] string_0)
		{
			if (string_0.Length <= 1)
			{
				return new IPListEntry(string_0[0], string.Empty);
			}
			return new IPListEntry(string_0[0], string_0[1]);
		}

		internal IPListEntry method_3(IPListViewItem iplistViewItem_0)
		{
			return iplistViewItem_0.IPListEntry;
		}

		internal string method_4(IPListEntry iplistEntry_0)
		{
			object obj = iplistEntry_0.gclass24_0.method_5();
			if (obj == null)
			{
				obj = "";
			}
			return (string)obj;
		}

		internal string method_5(IPListEntry iplistEntry_0)
		{
			return iplistEntry_0.gclass24_0.method_5() + "," + iplistEntry_0.Comment;
		}

		internal void method_6(ListViewItem listViewItem_0)
		{
			listViewItem_0.Selected = true;
		}
	}

	private Image image_0;

	private Image image_1;

	public string string_0;

	private Class56 class56_0;

	private Class56 class56_1;

	private Class56 class56_2;

	private Class56 class56_3;

	private Class56 class56_4;

	private IContainer icontainer_0;

	private GControl0 gcontrol0_0;

	private Class62 class62_0;

	private PictureBox pictureBox_0;

	private Class62 class62_1;

	private GClass3 gclass3_0;

	private Panel panel_0;

	private Class67 class67_0;

	private ToolStripButton toolStripButton_0;

	private ToolStripSeparator toolStripSeparator_0;

	private ToolStripButton toolStripButton_1;

	private ToolStripSeparator toolStripSeparator_1;

	private ToolStripButton toolStripButton_2;

	private ToolStripSeparator toolStripSeparator_2;

	private ToolStripButton toolStripButton_3;

	private ToolStripSeparator toolStripSeparator_3;

	private ToolStripButton toolStripButton_4;

	private ToolStripDropDownButton toolStripDropDownButton_0;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripSeparator toolStripSeparator_4;

	private ToolStripMenuItem toolStripMenuItem_2;

	private ToolStripMenuItem toolStripMenuItem_3;

	private Class46 class46_0;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private ColumnHeader columnHeader_2;

	public IPListEntry[] IPListEntry_0 => class46_0.IPListEntry_0;

	public string String_0
	{
		set
		{
			Text = value;
		}
	}

	public string String_1
	{
		set
		{
			class62_0.Text = value;
		}
	}

	public string String_2
	{
		set
		{
			class62_1.Text = value;
		}
	}

	public Image Image_0
	{
		set
		{
			pictureBox_0.Image = value;
		}
	}

	public Image Image_1
	{
		private get
		{
			return image_0;
		}
		set
		{
			image_0 = value;
		}
	}

	public Image Image_2
	{
		private get
		{
			return image_1;
		}
		set
		{
			image_1 = value;
		}
	}

	public IPListDialog(IPListEntry[] iplistEntry_0)
		: base(new Size(640, 480))
	{
		InitializeComponent();
		vmethod_1();
		method_14(iplistEntry_0);
		method_15();
	}

	private void method_11()
	{
		IPListEntryAddEditDialog form = new IPListEntryAddEditDialog(null)
		{
			Image_0 = Image_1
		};
		using (form)
		{
			if (DialogResult.OK == form.ShowDialog())
			{
				class46_0.method_11(form.IPListEntry_0);
			}
		}
	}

	private void method_12()
	{
		IPListEntryAddEditDialog form = new IPListEntryAddEditDialog(class46_0.IPListEntry_1)
		{
			Image_0 = Image_2
		};
		using (form)
		{
			if (DialogResult.OK == form.ShowDialog())
			{
				class46_0.IPListEntry_1 = form.IPListEntry_0[0];
			}
		}
	}

	private void method_13()
	{
		class46_0.BeginUpdate();
		IPListViewItem[] iPListViewItem_ = class46_0.IPListViewItem_0;
		Action<IPListViewItem> action_ = _003C_003Ec._003C_003E9.method_0;
		iPListViewItem_.smethod_0(action_);
		class46_0.EndUpdate();
	}

	private void method_14(IPListEntry[] iplistEntry_0)
	{
		class46_0.method_11(iplistEntry_0);
		class46_0.ContextMenuStrip = method_23();
	}

	private void method_15()
	{
		gclass3_0.Click += gclass3_0_Click;
		class46_0.MouseDoubleClick += class46_0_MouseDoubleClick;
		class46_0.SelectedIndexChanged += class46_0_SelectedIndexChanged;
		toolStripButton_0.Click += toolStripButton_0_Click;
		toolStripButton_1.Click += toolStripButton_1_Click;
		toolStripButton_2.Click += toolStripButton_2_Click;
		toolStripMenuItem_2.Click += toolStripMenuItem_2_Click;
		toolStripMenuItem_3.Click += toolStripMenuItem_3_Click;
		toolStripMenuItem_0.Click += toolStripMenuItem_0_Click;
		toolStripMenuItem_1.Click += toolStripMenuItem_1_Click;
		toolStripButton_4.Click += toolStripButton_4_Click;
		toolStripButton_3.Click += toolStripButton_3_Click;
	}

	private void method_16()
	{
		toolStripButton_1.Enabled = class46_0.Boolean_2;
		class56_0.Enabled = class46_0.Boolean_2;
		toolStripButton_2.Enabled = class46_0.Boolean_1;
		class56_1.Enabled = class46_0.Boolean_1;
		toolStripMenuItem_2.Enabled = class46_0.Boolean_1;
		class56_2.Enabled = class46_0.Boolean_1;
		toolStripMenuItem_3.Enabled = class46_0.Boolean_1;
		class56_3.Enabled = class46_0.Boolean_1;
		toolStripMenuItem_1.Enabled = class46_0.Boolean_1;
		class56_4.Enabled = class46_0.Boolean_1;
	}

	private void method_17()
	{
		class46_0.BeginUpdate();
		int num = class46_0.SelectedItems[0].Index - 1;
		if (num >= 0)
		{
			IPListViewItem[] iPListViewItem_ = class46_0.IPListViewItem_0;
			IPListViewItem[] array = iPListViewItem_;
			foreach (IPListViewItem iPListViewItem in array)
			{
				iPListViewItem.Remove();
				class46_0.Items.Insert(num++, iPListViewItem);
			}
		}
		class46_0.EndUpdate();
	}

	private void method_18()
	{
		class46_0.BeginUpdate();
		int num = class46_0.SelectedItems[class46_0.SelectedItems.Count - 1].Index + 1;
		if (num < class46_0.Items.Count)
		{
			IPListViewItem[] iPListViewItem_ = class46_0.IPListViewItem_0;
			IPListViewItem[] array = iPListViewItem_;
			foreach (IPListViewItem iPListViewItem in array)
			{
				iPListViewItem.Remove();
				class46_0.Items.Insert(num, iPListViewItem);
			}
		}
		class46_0.EndUpdate();
	}

	private void method_19()
	{
		OpenFileDialog openFileDialog = new OpenFileDialog
		{
			Filter = "JSON file|*.json|CSV file|*.csv"
		};
		using (openFileDialog)
		{
			if (DialogResult.OK == openFileDialog.ShowDialog())
			{
				switch (openFileDialog.FilterIndex)
				{
				default:
					throw new NotImplementedException("Format is not supported");
				case 2:
					class46_0.method_11(method_21(openFileDialog.FileName));
					break;
				case 1:
					class46_0.method_11(method_20(openFileDialog.FileName));
					break;
				}
			}
		}
	}

	private IPListEntry[] method_20(string string_1)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		return ((JToken)(JArray)JsonConvert.DeserializeObject<Dictionary<string, object>>(File.ReadAllText(string_1)).First().Value).ToObject<IPListEntry[]>();
	}

	private IPListEntry[] method_21(string string_1)
	{
		string[] source = File.ReadAllLines(string_1);
		Func<string, string[]> selector = _003C_003Ec._003C_003E9.method_1;
		IEnumerable<string[]> source2 = source.Select(selector);
		Func<string[], IPListEntry> selector2 = _003C_003Ec._003C_003E9.method_2;
		return source2.Select(selector2).ToArray();
	}

	private void method_22()
	{
		SaveFileDialog saveFileDialog = new SaveFileDialog
		{
			Filter = "Text file|*.txt|CSV file|*.csv|JSON file|*.json"
		};
		using (saveFileDialog)
		{
			if (DialogResult.OK == saveFileDialog.ShowDialog())
			{
				IPListViewItem[] iPListViewItem_ = class46_0.IPListViewItem_0;
				Func<IPListViewItem, IPListEntry> selector = _003C_003Ec._003C_003E9.method_3;
				IPListEntry[] iplistEntry_ = iPListViewItem_.Select(selector).ToArray();
				switch (saveFileDialog.FilterIndex)
				{
				default:
					throw new NotImplementedException("Format is not supported");
				case 1:
					File.WriteAllText(saveFileDialog.FileName, smethod_4(iplistEntry_));
					break;
				case 2:
					File.WriteAllText(saveFileDialog.FileName, smethod_5(iplistEntry_));
					break;
				case 3:
					File.WriteAllText(saveFileDialog.FileName, smethod_6(iplistEntry_));
					break;
				}
			}
		}
	}

	private static string smethod_4(IPListEntry[] iplistEntry_0)
	{
		Func<IPListEntry, string> selector = _003C_003Ec._003C_003E9.method_4;
		return string.Join("\r\n", iplistEntry_0.Select(selector));
	}

	private static string smethod_5(IPListEntry[] iplistEntry_0)
	{
		Func<IPListEntry, string> selector = _003C_003Ec._003C_003E9.method_5;
		return string.Join("\r\n", iplistEntry_0.Select(selector));
	}

	private static string smethod_6(IPListEntry[] iplistEntry_0)
	{
		return JsonConvert.SerializeObject((object)new Dictionary<string, object> { { "Entries", iplistEntry_0 } });
	}

	private ContextMenuStrip method_23()
	{
		Class57 @class = new Class57();
		ToolStripItem[] array = new ToolStripItem[14]
		{
			new Class56
			{
				Text = "Add..",
				Image = Resources.add_16_pale,
				ShortcutKeys = Keys.Insert,
				eventHandler_0 = method_25
			},
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null
		};
		array[1] = (class56_0 = new Class56
		{
			Text = "Edit..",
			Enabled = false,
			Image = Resources.edit_16_pale,
			ShortcutKeys = Keys.F2,
			eventHandler_0 = method_26
		});
		array[2] = (class56_1 = new Class56
		{
			Text = "Delete",
			Enabled = false,
			Image = Resources.delete_16_pale,
			ShortcutKeys = Keys.Delete,
			eventHandler_0 = method_27
		});
		array[3] = new ToolStripSeparator();
		array[4] = (class56_2 = new Class56
		{
			Text = "Move up",
			Enabled = false,
			Image = Resources.up_16_pale,
			ShortcutKeys = (Keys.Up | Keys.Control),
			eventHandler_0 = method_28
		});
		array[5] = (class56_3 = new Class56
		{
			Text = "Move down",
			Enabled = false,
			Image = Resources.down_16_pale,
			ShortcutKeys = (Keys.Down | Keys.Control),
			eventHandler_0 = method_29
		});
		array[6] = new ToolStripSeparator();
		array[7] = new Class56
		{
			Text = "Select all",
			ShortcutKeys = (Keys.A | Keys.Control),
			Image = Resources.select_all,
			Enabled = true,
			eventHandler_0 = method_30
		};
		array[8] = new ToolStripSeparator();
		array[9] = new Class56
		{
			Text = "Import..",
			Image = Resources.open_16,
			ShortcutKeys = (Keys.I | Keys.Control),
			eventHandler_0 = method_31
		};
		array[10] = (class56_4 = new Class56
		{
			Text = "Export..",
			Enabled = false,
			Image = Resources.save_16_blue,
			ShortcutKeys = (Keys.E | Keys.Control),
			eventHandler_0 = method_32
		});
		array[11] = new ToolStripSeparator();
		array[12] = new Class56
		{
			Text = "Save changes..",
			Image = Resources.ok_16_pale,
			ShortcutKeys = (Keys.S | Keys.Control),
			eventHandler_0 = method_33
		};
		array[13] = new Class56
		{
			Text = "Cancel..",
			Image = Resources.cancel_16_pale,
			ShortcutKeys = (Keys.Escape | Keys.Control),
			eventHandler_0 = method_34
		};
		@class.ToolStripItem_0 = array;
		return @class;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		gcontrol0_0 = new GControl0();
		class62_0 = new Class62();
		pictureBox_0 = new PictureBox();
		class62_1 = new Class62();
		gclass3_0 = new GClass3();
		panel_0 = new Panel();
		class46_0 = new Class46();
		columnHeader_0 = new ColumnHeader();
		columnHeader_1 = new ColumnHeader();
		columnHeader_2 = new ColumnHeader();
		class67_0 = new Class67();
		toolStripButton_0 = new ToolStripButton();
		toolStripSeparator_0 = new ToolStripSeparator();
		toolStripButton_1 = new ToolStripButton();
		toolStripSeparator_1 = new ToolStripSeparator();
		toolStripButton_2 = new ToolStripButton();
		toolStripSeparator_2 = new ToolStripSeparator();
		toolStripButton_3 = new ToolStripButton();
		toolStripSeparator_3 = new ToolStripSeparator();
		toolStripButton_4 = new ToolStripButton();
		toolStripDropDownButton_0 = new ToolStripDropDownButton();
		toolStripMenuItem_0 = new ToolStripMenuItem();
		toolStripMenuItem_1 = new ToolStripMenuItem();
		toolStripSeparator_4 = new ToolStripSeparator();
		toolStripMenuItem_2 = new ToolStripMenuItem();
		toolStripMenuItem_3 = new ToolStripMenuItem();
		((ISupportInitialize)pictureBox_0).BeginInit();
		panel_0.SuspendLayout();
		class67_0.SuspendLayout();
		SuspendLayout();
		gcontrol0_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		gcontrol0_0.Location = new Point(16, 81);
		gcontrol0_0.Name = "separatorLine1";
		gcontrol0_0.Size = new Size(755, 2);
		gcontrol0_0.TabIndex = 50;
		gcontrol0_0.TabStop = false;
		class62_0.AutoSize = true;
		class62_0.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		class62_0.Location = new Point(79, 15);
		class62_0.Margin = new Padding(4, 0, 4, 0);
		class62_0.Name = "m_lblTopTitle";
		class62_0.Size = new Size(100, 16);
		class62_0.TabIndex = 49;
		class62_0"{TOP_TITLE}";
		pictureBox_0.Location = new Point(16, 15);
		pictureBox_0.Margin = new Padding(4);
		pictureBox_0.Name = "m_imgTopIcon";
		pictureBox_0.Size = new Size(48, 48);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 47;
		pictureBox_0.TabStop = false;
		class62_1.AutoSize = true;
		class62_1.Location = new Point(79, 47);
		class62_1.Margin = new Padding(4, 0, 4, 0);
		class62_1.Name = "m_lblTopDescription";
		class62_1.Size = new Size(143, 16);
		class62_1.TabIndex = 48;
		class62_1"{TOP_DESCRIPTION}";
		gclass3_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		gclass3_0.AutoSize = true;
		gclass3_0.LinkBehavior = LinkBehavior.NeverUnderline;
		gclass3_0.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_0.Location = new Point(698, 9);
		gclass3_0.Name = "m_lnkOnlineHelp";
		gclass3_0.Size = new Size(72, 16);
		gclass3_0.TabIndex = 55;
		gclass3_0.TabStop = true;
		gclass3_0.Text = "справка онлайн";
		gclass3_0.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		panel_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		panel_0.Controls.Add(class46_0);
		panel_0.Controls.Add(class67_0);
		panel_0.Location = new Point(12, 90);
		panel_0.Name = "panel1";
		panel_0.Size = new Size(759, 420);
		panel_0.TabIndex = 56;
		class46_0.Columns.AddRange(new ColumnHeader[3] { columnHeader_0, columnHeader_1, columnHeader_2 });
		class46_0.Dock = DockStyle.Fill;
		class46_0.ColumnHeader_0 = new ColumnHeader[3] { columnHeader_0, columnHeader_1, columnHeader_2 };
		class46_0.FullRowSelect = true;
		class46_0.GridLines = true;
		class46_0.HideSelection = false;
		class46_0.Location = new Point(0, 0);
		class46_0.Name = "m_lst";
		class46_0.IPListEntry_1 = null;
		class46_0.Size = new Size(759, 385);
		class46_0.TabIndex = 57;
		class46_0.UseCompatibleStateImageBehavior = false;
		class46_0.View = View.Details;
		columnHeader_0.Text = "IP-адрес/диапазон";
		columnHeader_0.Width = 400;
		columnHeader_1"CIDR";
		columnHeader_1.Width = 139;
		columnHeader_2.Text = "Комментарий";
		columnHeader_2.Width = 215;
		class67_0.Dock = DockStyle.Bottom;
		class67_0.Font = new Font("Segoe UI", 9f);
		class67_0.GripStyle = ToolStripGripStyle.Hidden;
		class67_0.Items.AddRange(new ToolStripItem[10] { toolStripButton_0, toolStripSeparator_0, toolStripButton_1, toolStripSeparator_1, toolStripButton_2, toolStripSeparator_2, toolStripButton_3, toolStripSeparator_3, toolStripButton_4, toolStripDropDownButton_0 });
		class67_0.Location = new Point(0, 385);
		class67_0.Name = "toolStrip1";
		class67_0.Padding = new Padding(0);
		class67_0.Size = new Size(759, 35);
		class67_0.TabIndex = 58;
		toolStripButton_0.Image = Resources.add_16_pale;
		toolStripButton_0.ImageScaling = ToolStripItemImageScaling.None;
		toolStripButton_0.ImageTransparentColor = Color.Magenta;
		toolStripButton_0.Margin = new Padding(3, 2, 0, 3);
		toolStripButton_0.Name = "m_btnAdd";
		toolStripButton_0.Padding = new Padding(5);
		toolStripButton_0.Size = new Size(59, 30);
		toolStripButton_0.Text = "Добавить";
		toolStripSeparator_0.Name = "toolStripSeparator2";
		toolStripSeparator_0.Size = new Size(6, 35);
		toolStripButton_1.Enabled = false;
		toolStripButton_1.Image = Resources.edit_16_pale;
		toolStripButton_1.ImageScaling = ToolStripItemImageScaling.None;
		toolStripButton_1.ImageTransparentColor = Color.Magenta;
		toolStripButton_1.Margin = new Padding(0, 2, 0, 3);
		toolStripButton_1.Name = "m_btnEdit";
		toolStripButton_1.Padding = new Padding(5);
		toolStripButton_1.Size = new Size(57, 30);
		toolStripButton_1.Text = "Изменить";
		toolStripSeparator_1.Name = "toolStripSeparator3";
		toolStripSeparator_1.Size = new Size(6, 35);
		toolStripButton_2.Enabled = false;
		toolStripButton_2.Image = Resources.delete_16_pale;
		toolStripButton_2.ImageScaling = ToolStripItemImageScaling.None;
		toolStripButton_2.ImageTransparentColor = Color.Magenta;
		toolStripButton_2.Margin = new Padding(0, 2, 0, 3);
		toolStripButton_2.Name = "m_btnDelete";
		toolStripButton_2.Padding = new Padding(5);
		toolStripButton_2.Size = new Size(70, 30);
		toolStripButton_2.Text = "Удалить";
		toolStripSeparator_2.Name = "toolStripSeparator5";
		toolStripSeparator_2.Size = new Size(6, 35);
		toolStripButton_3.Alignment = ToolStripItemAlignment.Right;
		toolStripButton_3.Image = Resources.cancel_16_pale;
		toolStripButton_3.ImageScaling = ToolStripItemImageScaling.None;
		toolStripButton_3.ImageTransparentColor = Color.Magenta;
		toolStripButton_3.Margin = new Padding(0, 2, 3, 3);
		toolStripButton_3.Name = "m_btnCancel";
		toolStripButton_3.Padding = new Padding(5);
		toolStripButton_3.Size = new Size(73, 30);
		toolStripButton_3.Text = "Отмена";
		toolStripSeparator_3.Alignment = ToolStripItemAlignment.Right;
		toolStripSeparator_3.Name = "toolStripSeparator8";
		toolStripSeparator_3.Size = new Size(6, 35);
		toolStripButton_4.Alignment = ToolStripItemAlignment.Right;
		toolStripButton_4.Image = Resources.ok_16_pale;
		toolStripButton_4.ImageScaling = ToolStripItemImageScaling.None;
		toolStripButton_4.ImageTransparentColor = Color.Magenta;
		toolStripButton_4.Margin = new Padding(0, 2, 0, 3);
		toolStripButton_4.Name = "m_btnSaveChanges";
		toolStripButton_4.Padding = new Padding(5);
		toolStripButton_4.Size = new Size(108, 30);
		toolStripButton_4.Text = "Сохранить изменения";
		toolStripDropDownButton_0.DropDownItems.AddRange(new ToolStripItem[5] { toolStripMenuItem_0, toolStripMenuItem_1, toolStripSeparator_4, toolStripMenuItem_2, toolStripMenuItem_3 });
		toolStripDropDownButton_0.Image = Resources.more_16;
		toolStripDropDownButton_0.ImageScaling = ToolStripItemImageScaling.None;
		toolStripDropDownButton_0.ImageTransparentColor = Color.Magenta;
		toolStripDropDownButton_0.Margin = new Padding(0, 2, 0, 3);
		toolStripDropDownButton_0.Name = "toolStripDropDownButton1";
		toolStripDropDownButton_0.Size = new Size(70, 30);
		toolStripDropDownButton_0.Text = "Ещё..";
		toolStripMenuItem_0.Image = Resources.open_16;
		toolStripMenuItem_0.Name = "m_btnImport";
		toolStripMenuItem_0.Padding = new Padding(0, 3, 0, 3);
		toolStripMenuItem_0.ShortcutKeys = Keys.I | Keys.Control;
		toolStripMenuItem_0.Size = new Size(202, 26);
		toolStripMenuItem_0.Text = "Импорт..";
		toolStripMenuItem_1.Enabled = false;
		toolStripMenuItem_1.Image = Resources.save_16_blue;
		toolStripMenuItem_1.Name = "m_btnExport";
		toolStripMenuItem_1.Padding = new Padding(0, 3, 0, 3);
		toolStripMenuItem_1.ShortcutKeys = Keys.E | Keys.Control;
		toolStripMenuItem_1.Size = new Size(202, 26);
		toolStripMenuItem_1.Text = "Экспорт..";
		toolStripSeparator_4.Name = "toolStripSeparator1";
		toolStripSeparator_4.Size = new Size(199, 6);
		toolStripMenuItem_2.Enabled = false;
		toolStripMenuItem_2.Image = Resources.up_16_pale;
		toolStripMenuItem_2.Name = "m_btnMoveUp";
		toolStripMenuItem_2.Padding = new Padding(0, 3, 0, 3);
		toolStripMenuItem_2.ShortcutKeys = Keys.Up | Keys.Control;
		toolStripMenuItem_2.Size = new Size(202, 26);
		toolStripMenuItem_2.Text = "Вверх";
		toolStripMenuItem_3.Enabled = false;
		toolStripMenuItem_3.Image = Resources.down_16_pale;
		toolStripMenuItem_3.Name = "m_btnMoveDown";
		toolStripMenuItem_3.Padding = new Padding(0, 3, 0, 3);
		toolStripMenuItem_3.ShortcutKeys = Keys.Down | Keys.Control;
		toolStripMenuItem_3.Size = new Size(202, 26);
		toolStripMenuItem_3.Text = "Вниз";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(783, 522);
		base.Controls.Add(panel_0);
		base.Controls.Add(gclass3_0);
		base.Controls.Add(gcontrol0_0);
		base.Controls.Add(class62_0);
		base.Controls.Add(class62_1);
		base.Controls.Add(pictureBox_0);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(5, 4, 5, 4);
		base.Name = "IPListDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "{TITLE}";
		((ISupportInitialize)pictureBox_0).EndInit();
		panel_0.ResumeLayout(performLayout: false);
		panel_0.PerformLayout();
		class67_0.ResumeLayout(performLayout: false);
		class67_0.PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void gclass3_0_Click(object sender, EventArgs e)
	{
		string text = string_0;
		if (text == null)
		{
			text = Class148.Class152.String_0;
		}
		method_9(text);
	}

	private void class46_0_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		toolStripButton_1.PerformClick();
	}

	private void class46_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		method_16();
	}

	private void toolStripButton_0_Click(object sender, EventArgs e)
	{
		method_11();
	}

	private void toolStripButton_1_Click(object sender, EventArgs e)
	{
		method_12();
	}

	private void toolStripButton_2_Click(object sender, EventArgs e)
	{
		method_13();
	}

	private void toolStripMenuItem_2_Click(object sender, EventArgs e)
	{
		method_17();
	}

	private void toolStripMenuItem_3_Click(object sender, EventArgs e)
	{
		method_18();
	}

	private void toolStripMenuItem_0_Click(object sender, EventArgs e)
	{
		method_19();
	}

	private void toolStripMenuItem_1_Click(object sender, EventArgs e)
	{
		method_22();
	}

	private void toolStripButton_4_Click(object sender, EventArgs e)
	{
		method_8(DialogResult.OK);
	}

	private void toolStripButton_3_Click(object sender, EventArgs e)
	{
		method_8(DialogResult.Cancel);
	}

	private void method_25(object sender, EventArgs e)
	{
		toolStripButton_0.PerformClick();
	}

	private void method_26(object sender, EventArgs e)
	{
		toolStripButton_1.PerformClick();
	}

	private void method_27(object sender, EventArgs e)
	{
		toolStripButton_2.PerformClick();
	}

	private void method_28(object sender, EventArgs e)
	{
		toolStripMenuItem_2.PerformClick();
	}

	private void method_29(object sender, EventArgs e)
	{
		toolStripMenuItem_3.PerformClick();
	}

	private void method_30(object sender, EventArgs e)
	{
		IEnumerable<ListViewItem> ienumerable_ = class46_0.Items.Cast<ListViewItem>();
		Action<ListViewItem> action_ = _003C_003Ec._003C_003E9.method_6;
		ienumerable_.smethod_0(action_);
	}

	private void method_31(object sender, EventArgs e)
	{
		toolStripMenuItem_0.PerformClick();
	}

	private void method_32(object sender, EventArgs e)
	{
		toolStripMenuItem_1.PerformClick();
	}

	private void method_33(object sender, EventArgs e)
	{
		toolStripButton_4.PerformClick();
	}

	private void method_34(object sender, EventArgs e)
	{
		toolStripButton_3.PerformClick();
	}
}
