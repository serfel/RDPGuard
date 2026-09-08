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

	private GControl0 separatorLine1;

	private Class62 mlblTopTitle;

	private PictureBox mimgTopIcon;

	private Class62 mlblTopDescription;

	private GClass3 mlnkOnlineHelp;

	private Panel panel1;

	private Class67 toolStrip1;

	private ToolStripButton mbtnAdd;

	private ToolStripSeparator toolStripSeparator2;

	private ToolStripButton mbtnEdit;

	private ToolStripSeparator toolStripSeparator3;

	private ToolStripButton mbtnDelete;

	private ToolStripSeparator toolStripSeparator5;

	private ToolStripButton mbtnCancel;

	private ToolStripSeparator toolStripSeparator8;

	private ToolStripButton mbtnSaveChanges;

	private ToolStripDropDownButton toolStripDropDownButton1;

	private ToolStripMenuItem mbtnImport;

	private ToolStripMenuItem mbtnExport;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripMenuItem mbtnMoveUp;

	private ToolStripMenuItem mbtnMoveDown;

	private Class46 mlst;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private ColumnHeader columnHeader_2;

	public IPListEntry[] IPListEntry_0 => mlst.IPListEntry_0;

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
			mlblTopTitle.Text = value;
		}
	}

	public string String_2
	{
		set
		{
			mlblTopDescription.Text = value;
		}
	}

	public Image Image_0
	{
		set
		{
			mimgTopIcon.Image = value;
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
		ValidateInput();
		InitializeFormPosition();
		OnLoad(iplistEntry_0);
		ValidateInput();
	}

	private void InitializeComponent()
	{
		IPListEntryAddEditDialog form = new IPListEntryAddEditDialog(null)
		{
			Image_0 = Image_1
		};
		using (form)
		{
			if (DialogResult.OK == form.ShowDialog())
			{
				mlst.InitializeComponent(form.IPListEntry_0);
			}
		}
	}

	private void OnButtonOk()
	{
		IPListEntryAddEditDialog form = new IPListEntryAddEditDialog(mlst.IPListEntry_1)
		{
			Image_0 = Image_2
		};
		using (form)
		{
			if (DialogResult.OK == form.ShowDialog())
			{
				mlst.IPListEntry_1 = form.IPListEntry_0[0];
			}
		}
	}

	private void OnButtonCancel()
	{
		mlst.BeginUpdate();
		IPListViewItem[] iPListViewItem_ = mlst.IPListViewItem_0;
		Action<IPListViewItem> action_ = _003C_003Ec._003C_003E9.method_0;
		iPListViewItem_.smethod_0(action_);
		mlst.EndUpdate();
	}

	private void OnLoad(IPListEntry[] iplistEntry_0)
	{
		mlst.InitializeComponent(iplistEntry_0);
		mlst.ContextMenuStrip = ValidateInput();
	}

	private void ValidateInput()
	{
		mlnkOnlineHelp.Click += mlnkOnlineHelp_Click;
		mlst.MouseDoubleClick += mlst_MouseDoubleClick;
		mlst.SelectedIndexChanged += class46_0_SelectedIndexChanged;
		mbtnAdd.Click += mbtnAdd_Click;
		mbtnEdit.Click += mbtnEdit_Click;
		mbtnDelete.Click += mbtnDelete_Click;
		mbtnMoveUp.Click += mbtnMoveUp_Click;
		mbtnMoveDown.Click += mbtnMoveDown_Click;
		mbtnImport.Click += mbtnImport_Click;
		mbtnExport.Click += mbtnExport_Click;
		mbtnSaveChanges.Click += mbtnSaveChanges_Click;
		mbtnCancel.Click += mbtnCancel_Click;
	}

	private void SaveSettings()
	{
		mbtnEdit.Enabled = mlst.Boolean_2;
		class56_0.Enabled = mlst.Boolean_2;
		mbtnDelete.Enabled = mlst.Boolean_1;
		class56_1.Enabled = mlst.Boolean_1;
		mbtnMoveUp.Enabled = mlst.Boolean_1;
		class56_2.Enabled = mlst.Boolean_1;
		mbtnMoveDown.Enabled = mlst.Boolean_1;
		class56_3.Enabled = mlst.Boolean_1;
		mbtnExport.Enabled = mlst.Boolean_1;
		class56_4.Enabled = mlst.Boolean_1;
	}

	private void LoadSettings()
	{
		mlst.BeginUpdate();
		int num = mlst.SelectedItems[0].Index - 1;
		if (num >= 0)
		{
			IPListViewItem[] iPListViewItem_ = mlst.IPListViewItem_0;
			IPListViewItem[] array = iPListViewItem_;
			foreach (IPListViewItem iPListViewItem in array)
			{
				iPListViewItem.Remove();
				mlst.Items.Insert(num++, iPListViewItem);
			}
		}
		mlst.EndUpdate();
	}

	private void OnTextChanged()
	{
		mlst.BeginUpdate();
		int num = mlst.SelectedItems[mlst.SelectedItems.Count - 1].Index + 1;
		if (num < mlst.Items.Count)
		{
			IPListViewItem[] iPListViewItem_ = mlst.IPListViewItem_0;
			IPListViewItem[] array = iPListViewItem_;
			foreach (IPListViewItem iPListViewItem in array)
			{
				iPListViewItem.Remove();
				mlst.Items.Insert(num, iPListViewItem);
			}
		}
		mlst.EndUpdate();
	}

	private void OnCheckedChanged()
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
					mlst.InitializeComponent(method_21(openFileDialog.FileName));
					break;
				case 1:
					mlst.InitializeComponent(OnSelectedIndexChanged(openFileDialog.FileName));
					break;
				}
			}
		}
	}

	private IPListEntry[] OnSelectedIndexChanged(string string_1)
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

	private void OnButtonOk()
	{
		SaveFileDialog saveFileDialog = new SaveFileDialog
		{
			Filter = "Text file|*.txt|CSV file|*.csv|JSON file|*.json"
		};
		using (saveFileDialog)
		{
			if (DialogResult.OK == saveFileDialog.ShowDialog())
			{
				IPListViewItem[] iPListViewItem_ = mlst.IPListViewItem_0;
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

	private ContextMenuStrip ValidateInput()
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

	private void ValidateInput()
	{
		separatorLine1 = new GControl0();
		mlblTopTitle = new Class62();
		mimgTopIcon = new PictureBox();
		mlblTopDescription = new Class62();
		mlnkOnlineHelp = new GClass3();
		panel1 = new Panel();
		mlst = new Class46();
		columnHeader_0 = new ColumnHeader();
		columnHeader_1 = new ColumnHeader();
		columnHeader_2 = new ColumnHeader();
		toolStrip1 = new Class67();
		mbtnAdd = new ToolStripButton();
		toolStripSeparator2 = new ToolStripSeparator();
		mbtnEdit = new ToolStripButton();
		toolStripSeparator3 = new ToolStripSeparator();
		mbtnDelete = new ToolStripButton();
		toolStripSeparator5 = new ToolStripSeparator();
		mbtnCancel = new ToolStripButton();
		toolStripSeparator8 = new ToolStripSeparator();
		mbtnSaveChanges = new ToolStripButton();
		toolStripDropDownButton1 = new ToolStripDropDownButton();
		mbtnImport = new ToolStripMenuItem();
		mbtnExport = new ToolStripMenuItem();
		toolStripSeparator1 = new ToolStripSeparator();
		mbtnMoveUp = new ToolStripMenuItem();
		mbtnMoveDown = new ToolStripMenuItem();
		((ISupportInitialize)mimgTopIcon).BeginInit();
		panel1.SuspendLayout();
		toolStrip1.SuspendLayout();
		SuspendLayout();
		separatorLine1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		separatorLine1.Location = new Point(16, 81);
		separatorLine1.Name = "separatorLine1";
		separatorLine1.Size = new Size(755, 2);
		separatorLine1.TabIndex = 50;
		separatorLine1.TabStop = false;
		mlblTopTitle.AutoSize = true;
		mlblTopTitle.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		mlblTopTitle.Location = new Point(79, 15);
		mlblTopTitle.Margin = new Padding(4, 0, 4, 0);
		mlblTopTitle.Name = "m_lblTopTitle";
		mlblTopTitle.Size = new Size(100, 16);
		mlblTopTitle.TabIndex = 49;
		mlblTopTitle.Text = "{TOP_TITLE}";
		mimgTopIcon.Location = new Point(16, 15);
		mimgTopIcon.Margin = new Padding(4);
		mimgTopIcon.Name = "m_imgTopIcon";
		mimgTopIcon.Size = new Size(48, 48);
		mimgTopIcon.SizeMode = PictureBoxSizeMode.AutoSize;
		mimgTopIcon.TabIndex = 47;
		mimgTopIcon.TabStop = false;
		mlblTopDescription.AutoSize = true;
		mlblTopDescription.Location = new Point(79, 47);
		mlblTopDescription.Margin = new Padding(4, 0, 4, 0);
		mlblTopDescription.Name = "m_lblTopDescription";
		mlblTopDescription.Size = new Size(143, 16);
		mlblTopDescription.TabIndex = 48;
		mlblTopDescription.Text = "{TOP_DESCRIPTION}";
		mlnkOnlineHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		mlnkOnlineHelp.AutoSize = true;
		mlnkOnlineHelp.LinkBehavior = LinkBehavior.NeverUnderline;
		mlnkOnlineHelp.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkOnlineHelp.Location = new Point(698, 9);
		mlnkOnlineHelp.Name = "m_lnkOnlineHelp";
		mlnkOnlineHelp.Size = new Size(72, 16);
		mlnkOnlineHelp.TabIndex = 55;
		mlnkOnlineHelp.TabStop = true;
		mlnkOnlineHelp.Text = "online help";
		mlnkOnlineHelp.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		panel1.Controls.Add(mlst);
		panel1.Controls.Add(toolStrip1);
		panel1.Location = new Point(12, 90);
		panel1.Name = "panel1";
		panel1.Size = new Size(759, 420);
		panel1.TabIndex = 56;
		mlst.Columns.AddRange(new ColumnHeader[3] { columnHeader_0, columnHeader_1, columnHeader_2 });
		mlst.Dock = DockStyle.Fill;
		mlst.ColumnHeader_0 = new ColumnHeader[3] { columnHeader_0, columnHeader_1, columnHeader_2 };
		mlst.FullRowSelect = true;
		mlst.GridLines = true;
		mlst.HideSelection = false;
		mlst.Location = new Point(0, 0);
		mlst.Name = "m_lst";
		mlst.IPListEntry_1 = null;
		mlst.Size = new Size(759, 385);
		mlst.TabIndex = 57;
		mlst.UseCompatibleStateImageBehavior = false;
		mlst.View = View.Details;
		columnHeader_0.Text = "IP Address/Range";
		columnHeader_0.Width = 400;
		columnHeader_1.Text = "CIDR";
		columnHeader_1.Width = 139;
		columnHeader_2.Text = "Comment";
		columnHeader_2.Width = 215;
		toolStrip1.Dock = DockStyle.Bottom;
		toolStrip1.Font = new Font("Segoe UI", 9f);
		toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
		toolStrip1.Items.AddRange(new ToolStripItem[10] { mbtnAdd, toolStripSeparator2, mbtnEdit, toolStripSeparator3, mbtnDelete, toolStripSeparator5, mbtnCancel, toolStripSeparator8, mbtnSaveChanges, toolStripDropDownButton1 });
		toolStrip1.Location = new Point(0, 385);
		toolStrip1.Name = "toolStrip1";
		toolStrip1.Padding = new Padding(0);
		toolStrip1.Size = new Size(759, 35);
		toolStrip1.TabIndex = 58;
		mbtnAdd.Image = Resources.add_16_pale;
		mbtnAdd.ImageScaling = ToolStripItemImageScaling.None;
		mbtnAdd.ImageTransparentColor = Color.Magenta;
		mbtnAdd.Margin = new Padding(3, 2, 0, 3);
		mbtnAdd.Name = "m_btnAdd";
		mbtnAdd.Padding = new Padding(5);
		mbtnAdd.Size = new Size(59, 30);
		mbtnAdd.Text = "Add";
		toolStripSeparator2.Name = "toolStripSeparator2";
		toolStripSeparator2.Size = new Size(6, 35);
		mbtnEdit.Enabled = false;
		mbtnEdit.Image = Resources.edit_16_pale;
		mbtnEdit.ImageScaling = ToolStripItemImageScaling.None;
		mbtnEdit.ImageTransparentColor = Color.Magenta;
		mbtnEdit.Margin = new Padding(0, 2, 0, 3);
		mbtnEdit.Name = "m_btnEdit";
		mbtnEdit.Padding = new Padding(5);
		mbtnEdit.Size = new Size(57, 30);
		mbtnEdit.Text = "Edit";
		toolStripSeparator3.Name = "toolStripSeparator3";
		toolStripSeparator3.Size = new Size(6, 35);
		mbtnDelete.Enabled = false;
		mbtnDelete.Image = Resources.delete_16_pale;
		mbtnDelete.ImageScaling = ToolStripItemImageScaling.None;
		mbtnDelete.ImageTransparentColor = Color.Magenta;
		mbtnDelete.Margin = new Padding(0, 2, 0, 3);
		mbtnDelete.Name = "m_btnDelete";
		mbtnDelete.Padding = new Padding(5);
		mbtnDelete.Size = new Size(70, 30);
		mbtnDelete.Text = "Delete";
		toolStripSeparator5.Name = "toolStripSeparator5";
		toolStripSeparator5.Size = new Size(6, 35);
		mbtnCancel.Alignment = ToolStripItemAlignment.Right;
		mbtnCancel.Image = Resources.cancel_16_pale;
		mbtnCancel.ImageScaling = ToolStripItemImageScaling.None;
		mbtnCancel.ImageTransparentColor = Color.Magenta;
		mbtnCancel.Margin = new Padding(0, 2, 3, 3);
		mbtnCancel.Name = "m_btnCancel";
		mbtnCancel.Padding = new Padding(5);
		mbtnCancel.Size = new Size(73, 30);
		mbtnCancel.Text = "Cancel";
		toolStripSeparator8.Alignment = ToolStripItemAlignment.Right;
		toolStripSeparator8.Name = "toolStripSeparator8";
		toolStripSeparator8.Size = new Size(6, 35);
		mbtnSaveChanges.Alignment = ToolStripItemAlignment.Right;
		mbtnSaveChanges.Image = Resources.ok_16_pale;
		mbtnSaveChanges.ImageScaling = ToolStripItemImageScaling.None;
		mbtnSaveChanges.ImageTransparentColor = Color.Magenta;
		mbtnSaveChanges.Margin = new Padding(0, 2, 0, 3);
		mbtnSaveChanges.Name = "m_btnSaveChanges";
		mbtnSaveChanges.Padding = new Padding(5);
		mbtnSaveChanges.Size = new Size(108, 30);
		mbtnSaveChanges.Text = "Save changes";
		toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[5] { mbtnImport, mbtnExport, toolStripSeparator1, mbtnMoveUp, mbtnMoveDown });
		toolStripDropDownButton1.Image = Resources.more_16;
		toolStripDropDownButton1.ImageScaling = ToolStripItemImageScaling.None;
		toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
		toolStripDropDownButton1.Margin = new Padding(0, 2, 0, 3);
		toolStripDropDownButton1.Name = "toolStripDropDownButton1";
		toolStripDropDownButton1.Size = new Size(70, 30);
		toolStripDropDownButton1.Text = "More..";
		mbtnImport.Image = Resources.open_16;
		mbtnImport.Name = "m_btnImport";
		mbtnImport.Padding = new Padding(0, 3, 0, 3);
		mbtnImport.ShortcutKeys = Keys.I | Keys.Control;
		mbtnImport.Size = new Size(202, 26);
		mbtnImport.Text = "Import..";
		mbtnExport.Enabled = false;
		mbtnExport.Image = Resources.save_16_blue;
		mbtnExport.Name = "m_btnExport";
		mbtnExport.Padding = new Padding(0, 3, 0, 3);
		mbtnExport.ShortcutKeys = Keys.E | Keys.Control;
		mbtnExport.Size = new Size(202, 26);
		mbtnExport.Text = "Export..";
		toolStripSeparator1.Name = "toolStripSeparator1";
		toolStripSeparator1.Size = new Size(199, 6);
		mbtnMoveUp.Enabled = false;
		mbtnMoveUp.Image = Resources.up_16_pale;
		mbtnMoveUp.Name = "m_btnMoveUp";
		mbtnMoveUp.Padding = new Padding(0, 3, 0, 3);
		mbtnMoveUp.ShortcutKeys = Keys.Up | Keys.Control;
		mbtnMoveUp.Size = new Size(202, 26);
		mbtnMoveUp.Text = "Move up";
		mbtnMoveDown.Enabled = false;
		mbtnMoveDown.Image = Resources.down_16_pale;
		mbtnMoveDown.Name = "m_btnMoveDown";
		mbtnMoveDown.Padding = new Padding(0, 3, 0, 3);
		mbtnMoveDown.ShortcutKeys = Keys.Down | Keys.Control;
		mbtnMoveDown.Size = new Size(202, 26);
		mbtnMoveDown.Text = "Move down";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(783, 522);
		base.Controls.Add(panel1);
		base.Controls.Add(mlnkOnlineHelp);
		base.Controls.Add(separatorLine1);
		base.Controls.Add(mlblTopTitle);
		base.Controls.Add(mlblTopDescription);
		base.Controls.Add(mimgTopIcon);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(5, 4, 5, 4);
		base.Name = "IPListDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "{TITLE}";
		((ISupportInitialize)mimgTopIcon).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		toolStrip1.ResumeLayout(performLayout: false);
		toolStrip1.PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void mlnkOnlineHelp_Click(object sender, EventArgs e)
	{
		string text = string_0;
		if (text == null)
		{
			text = Class148.Class152.String_0;
		}
		ShowOnlineHelp(text);
	}

	private void mlst_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		mbtnEdit.PerformClick();
	}

	private void class46_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		SaveSettings();
	}

	private void mbtnAdd_Click(object sender, EventArgs e)
	{
		InitializeComponent();
	}

	private void mbtnEdit_Click(object sender, EventArgs e)
	{
		OnButtonOk();
	}

	private void mbtnDelete_Click(object sender, EventArgs e)
	{
		OnButtonCancel();
	}

	private void mbtnMoveUp_Click(object sender, EventArgs e)
	{
		LoadSettings();
	}

	private void mbtnMoveDown_Click(object sender, EventArgs e)
	{
		OnTextChanged();
	}

	private void mbtnImport_Click(object sender, EventArgs e)
	{
		OnCheckedChanged();
	}

	private void mbtnExport_Click(object sender, EventArgs e)
	{
		OnButtonOk();
	}

	private void mbtnSaveChanges_Click(object sender, EventArgs e)
	{
		CloseDialog(DialogResult.OK);
	}

	private void mbtnCancel_Click(object sender, EventArgs e)
	{
		CloseDialog(DialogResult.Cancel);
	}

	private void method_25(object sender, EventArgs e)
	{
		mbtnAdd.PerformClick();
	}

	private void method_26(object sender, EventArgs e)
	{
		mbtnEdit.PerformClick();
	}

	private void method_27(object sender, EventArgs e)
	{
		mbtnDelete.PerformClick();
	}

	private void method_28(object sender, EventArgs e)
	{
		mbtnMoveUp.PerformClick();
	}

	private void method_29(object sender, EventArgs e)
	{
		mbtnMoveDown.PerformClick();
	}

	private void method_30(object sender, EventArgs e)
	{
		IEnumerable<ListViewItem> ienumerable_ = mlst.Items.Cast<ListViewItem>();
		Action<ListViewItem> action_ = _003C_003Ec._003C_003E9.method_6;
		ienumerable_.smethod_0(action_);
	}

	private void method_31(object sender, EventArgs e)
	{
		mbtnImport.PerformClick();
	}

	private void method_32(object sender, EventArgs e)
	{
		mbtnExport.PerformClick();
	}

	private void method_33(object sender, EventArgs e)
	{
		mbtnSaveChanges.PerformClick();
	}

	private void method_34(object sender, EventArgs e)
	{
		mbtnCancel.PerformClick();
	}
}
