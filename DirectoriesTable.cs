using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Properties;

internal sealed class DirectoriesTable : UserControl
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<ListViewItem, string> _003C_003E9__2_0;

		internal string method_0(ListViewItem listViewItem_0)
		{
			return listViewItem_0.Text;
		}
	}

	public EventHandler eventHandler_0;

	private IContainer icontainer_0;

	private Class67 class67_0;

	private ToolStripButton toolStripButton_0;

	private ToolStripButton toolStripButton_1;

	private ToolStripButton toolStripButton_2;

	private ListViewWithScroll gclass0_0;

	private ImageList imageList_0;

	private ImageList imageList_1;

	public string[] String_0
	{
		get
		{
			ListViewItem[] listViewItem_ = gclass0_0.ListViewItem_0;
			Func<ListViewItem, string> selector = _003C_003Ec._003C_003E9.method_0;
			return listViewItem_.Select(selector).ToArray();
		}
		set
		{
			method_5(value);
		}
	}

	public DirectoriesTable()
	{
		InitializeComponent();
		method_0();
		method_1();
	}

	private void method_0()
	{
		gclass0_0.ContextMenuStrip = method_9();
	}

	private void method_1()
	{
		method_2();
		method_3();
	}

	private void method_2()
	{
		gclass0_0.SelectedIndexChanged += gclass0_0_SelectedIndexChanged;
		gclass0_0.MouseDoubleClick += gclass0_0_MouseDoubleClick;
		gclass0_0.EnabledChanged += gclass0_0_EnabledChanged;
	}

	private void method_3()
	{
		toolStripButton_2.Click += toolStripButton_2_Click;
		toolStripButton_1.Click += toolStripButton_1_Click;
		toolStripButton_0.Click += toolStripButton_0_Click;
	}

	private void method_4()
	{
		toolStripButton_1.Enabled = gclass0_0.Boolean_2;
		toolStripButton_0.Enabled = gclass0_0.Boolean_1;
	}

	private void method_5(string[] string_0)
	{
		string_0.Where(method_11).smethod_0(method_12);
	}

	private void method_6()
	{
		Class42 @class = new Class42
		{
			Boolean_0 = true
		};
		if (@class.method_0(base.Handle))
		{
			method_5(@class.String_1);
		}
		eventHandler_0?.Invoke(new object(), EventArgs.Empty);
	}

	private void method_7()
	{
		gclass0_0.method_3();
		eventHandler_0?.Invoke(new object(), EventArgs.Empty);
	}

	private void method_8()
	{
		if (!gclass0_0.Boolean_2)
		{
			return;
		}
		ListViewItem listViewItem = gclass0_0.SelectedItems[0];
		Class42 @class = new Class42
		{
			String_0 = listViewItem.Text
		};
		if (@class.method_0(base.Handle) ? true : false)
		{
			if (!String_0.Contains(@class.String_1[0]))
			{
				listViewItem.Text = @class.String_1[0];
			}
			eventHandler_0?.Invoke(new object(), EventArgs.Empty);
		}
	}

	private ContextMenuStrip method_9()
	{
		Class57 @class = new Class57();
		ToolStripItem[] array = new ToolStripItem[5]
		{
			new Class56
			{
				Text = "Add folder..",
				Image = Resources.folder_add_16,
				ShortcutKeys = Keys.Insert,
				eventHandler_0 = method_13
			},
			new Class56
			{
				Text = "Edit folder..",
				Name = "EditFolder",
				Image = Resources.folder_edit_16,
				ShortcutKeys = Keys.F2,
				eventHandler_0 = method_14
			},
			new Class56
			{
				Text = "Delete folder..",
				Name = "DeleteFolder",
				Image = Resources.folder_delete_16,
				ShortcutKeys = Keys.Delete,
				eventHandler_0 = method_15
			},
			new ToolStripSeparator(),
			null
		};
		Class56 class2 = new Class56
		{
			Text = "View"
		};
		ToolStripItem[] array2 = new Class56[4]
		{
			new Class56
			{
				Text = "Large Icons",
				eventHandler_0 = method_16
			},
			new Class56
			{
				Text = "List",
				eventHandler_0 = method_17
			},
			new Class56
			{
				Text = "Small Icons",
				eventHandler_0 = method_18
			},
			new Class56
			{
				Text = "Tile",
				eventHandler_0 = method_19
			}
		};
		ToolStripItem[] toolStripItem_ = array2;
		class2.ToolStripItem_0 = toolStripItem_;
		array[4] = class2;
		@class.ToolStripItem_0 = array;
		@class.cancelEventHandler_0 = method_20;
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
		this.icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectoriesTable));
		this.class67_0 = new Class67();
		this.toolStripButton_0 = new System.Windows.Forms.ToolStripButton();
		this.toolStripButton_1 = new System.Windows.Forms.ToolStripButton();
		this.toolStripButton_2 = new System.Windows.Forms.ToolStripButton();
		this.imageList_1 = new System.Windows.Forms.ImageList(this.icontainer_0);
		this.imageList_0 = new System.Windows.Forms.ImageList(this.icontainer_0);
		this.gclass0_0 = new ListViewWithScroll();
		this.class67_0.SuspendLayout();
		base.SuspendLayout();
		this.class67_0.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.class67_0.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
		this.class67_0.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.toolStripButton_0, this.toolStripButton_1, this.toolStripButton_2 });
		this.class67_0.Location = new System.Drawing.Point(0, 238);
		this.class67_0.Name = "toolStrip1";
		this.class67_0.Padding = new System.Windows.Forms.Padding(1);
		this.class67_0.Size = new System.Drawing.Size(470, 25);
		this.class67_0.TabIndex = 0;
		this.class67_0.Text = "панель инструментов 1";
		this.toolStripButton_0.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
		this.toolStripButton_0.Image = Properties.Resources.delete_16_pale;
		this.toolStripButton_0.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.toolStripButton_0.Name = "m_btnDelete";
		this.toolStripButton_0.Size = new System.Drawing.Size(60, 20);
		this.toolStripButton_0.Text = "Удалить";
		this.toolStripButton_1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
		this.toolStripButton_1.Image = Properties.Resources.edit_16_pale;
		this.toolStripButton_1.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.toolStripButton_1.Name = "m_btnEdit";
		this.toolStripButton_1.Size = new System.Drawing.Size(47, 20);
		this.toolStripButton_1.Text = "Изменить";
		this.toolStripButton_2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
		this.toolStripButton_2.Image = Properties.Resources.add_16_pale;
		this.toolStripButton_2.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.toolStripButton_2.Name = "m_btnAdd";
		this.toolStripButton_2.Size = new System.Drawing.Size(49, 20);
		this.toolStripButton_2.Text = "Добавить";
		this.imageList_1.TransparentColor = System.Drawing.Color.Transparent;
		this.imageList_0.TransparentColor = System.Drawing.Color.Transparent;
		this.gclass0_0.Dock = System.Windows.Forms.DockStyle.Fill;
		this.gclass0_0.ColumnHeader_0 = new System.Windows.Forms.ColumnHeader[0];
		this.gclass0_0.HideSelection = false;
		this.gclass0_0.LargeImageList = this.imageList_1;
		this.gclass0_0.Location = new System.Drawing.Point(0, 0);
		this.gclass0_0.Margin = new System.Windows.Forms.Padding(4);
		this.gclass0_0.Name = "m_lstFolders";
		this.gclass0_0.Size = new System.Drawing.Size(470, 238);
		this.gclass0_0.SmallImageList = this.imageList_0;
		this.gclass0_0.TabIndex = 1;
		this.gclass0_0.UseCompatibleStateImageBehavior = false;
		this.gclass0_0.View = System.Windows.Forms.View.List;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.Controls.Add(this.gclass0_0);
		base.Controls.Add(this.class67_0);
		this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.Margin = new System.Windows.Forms.Padding(4);
		base.Name = "DirectoriesTable";
		base.Size = new System.Drawing.Size(470, 263);
		this.class67_0.ResumeLayout(false);
		this.class67_0.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void gclass0_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		method_4();
	}

	private void gclass0_0_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		method_8();
	}

	private void gclass0_0_EnabledChanged(object sender, EventArgs e)
	{
		ListViewItem[] listViewItem_ = gclass0_0.ListViewItem_0;
		for (int i = 0; i < listViewItem_.Length; i++)
		{
			listViewItem_[i].ImageIndex = ((!gclass0_0.Enabled) ? 1 : 0);
		}
	}

	private void toolStripButton_2_Click(object sender, EventArgs e)
	{
		method_6();
	}

	private void toolStripButton_1_Click(object sender, EventArgs e)
	{
		method_8();
	}

	private void toolStripButton_0_Click(object sender, EventArgs e)
	{
		method_7();
	}

	private bool method_11(string string_0)
	{
		if (!string.IsNullOrEmpty(string_0))
		{
			return !String_0.Contains(string_0);
		}
		return false;
	}

	private void method_12(string string_0)
	{
		gclass0_0.Items.Add(new ListViewItem(string_0)
		{
			ImageIndex = ((!gclass0_0.Enabled) ? 1 : 0)
		});
	}

	private void method_13(object sender, EventArgs e)
	{
		method_6();
	}

	private void method_14(object sender, EventArgs e)
	{
		method_8();
	}

	private void method_15(object sender, EventArgs e)
	{
		method_7();
	}

	private void method_16(object sender, EventArgs e)
	{
		gclass0_0.View = View.LargeIcon;
	}

	private void method_17(object sender, EventArgs e)
	{
		gclass0_0.View = View.List;
	}

	private void method_18(object sender, EventArgs e)
	{
		gclass0_0.View = View.SmallIcon;
	}

	private void method_19(object sender, EventArgs e)
	{
		gclass0_0.View = View.Tile;
	}

	private void method_20(object sender, CancelEventArgs e)
	{
		((Class57)sender).Items["EditFolder"].Enabled = gclass0_0.Boolean_2;
		((Class57)sender).Items["DeleteFolder"].Enabled = gclass0_0.Boolean_1;
	}
}
