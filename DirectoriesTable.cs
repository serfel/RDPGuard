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

		internal string InitializeHandlers(ListViewItem listViewItem_0)
		{
			return listViewItem_0.Text;
		}
	}

	public EventHandler eventHandler_0;

	private IContainer icontainer_0;

	private Class67 toolStrip1;

	private ToolStripButton mbtnDelete;

	private ToolStripButton mbtnEdit;

	private ToolStripButton mbtnAdd;

	private GClass0 mlstFolders;

	private ImageList imageList_0;

	private ImageList imageList_1;

	public string[] String_0
	{
		get
		{
			ListViewItem[] listViewItem_ = mlstFolders.ListViewItem_0;
			Func<ListViewItem, string> selector = _003C_003Ec._003C_003E9.InitializeHandlers;
			return listViewItem_.Select(selector).ToArray();
		}
		set
		{
			RemoveItem(value);
		}
	}

	public DirectoriesTable()
	{
		InitializeComponent();
		InitializeHandlers();
		AddItems();
	}

	private void InitializeHandlers()
	{
		mlstFolders.ContextMenuStrip = RemoveCountry();
	}

	private void AddItems()
	{
		AddItem();
		UpdateCustomList();
	}

	private void AddItem()
	{
		mlstFolders.SelectedIndexChanged += gclass0_0_SelectedIndexChanged;
		mlstFolders.MouseDoubleClick += mlstFolders_MouseDoubleClick;
		mlstFolders.EnabledChanged += gclass0_0_EnabledChanged;
	}

	private void UpdateCustomList()
	{
		mbtnAdd.Click += mbtnAdd_Click;
		mbtnEdit.Click += mbtnEdit_Click;
		mbtnDelete.Click += mbtnDelete_Click;
	}

	private void RemoveSelected()
	{
		mbtnEdit.Enabled = mlstFolders.Boolean_2;
		mbtnDelete.Enabled = mlstFolders.Boolean_1;
	}

	private void RemoveItem(string[] string_0)
	{
		string_0.Where(GetAddressCount).smethod_0(method_12);
	}

	private void UpdateTotals()
	{
		Class42 @class = new Class42
		{
			Boolean_0 = true
		};
		if (@class.InitializeHandlers(base.Handle))
		{
			RemoveItem(@class.String_1);
		}
		eventHandler_0?.Invoke(new object(), EventArgs.Empty);
	}

	private void InitializeComponent()
	{
		mlstFolders.UpdateCustomList();
		eventHandler_0?.Invoke(new object(), EventArgs.Empty);
	}

	private void RemoveListItem()
	{
		if (!mlstFolders.Boolean_2)
		{
			return;
		}
		ListViewItem listViewItem = mlstFolders.SelectedItems[0];
		Class42 @class = new Class42
		{
			String_0 = listViewItem.Text
		};
		if (@class.InitializeHandlers(base.Handle) ? true : false)
		{
			if (!String_0.Contains(@class.String_1[0]))
			{
				listViewItem.Text = @class.String_1[0];
			}
			eventHandler_0?.Invoke(new object(), EventArgs.Empty);
		}
	}

	private ContextMenuStrip RemoveCountry()
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
		this.toolStrip1 = new Class67();
		this.mbtnDelete = new System.Windows.Forms.ToolStripButton();
		this.mbtnEdit = new System.Windows.Forms.ToolStripButton();
		this.mbtnAdd = new System.Windows.Forms.ToolStripButton();
		this.imageList_1 = new System.Windows.Forms.ImageList(this.icontainer_0);
		this.imageList_0 = new System.Windows.Forms.ImageList(this.icontainer_0);
		this.mlstFolders = new GClass0();
		this.toolStrip1.SuspendLayout();
		base.SuspendLayout();
		this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
		this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.mbtnDelete, this.mbtnEdit, this.mbtnAdd });
		this.toolStrip1.Location = new System.Drawing.Point(0, 238);
		this.toolStrip1.Name = "toolStrip1";
		this.toolStrip1.Padding = new System.Windows.Forms.Padding(1);
		this.toolStrip1.Size = new System.Drawing.Size(470, 25);
		this.toolStrip1.TabIndex = 0;
		this.toolStrip1.Text = "toolStrip1";
		this.mbtnDelete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
		this.mbtnDelete.Image = Properties.Resources.delete_16_pale;
		this.mbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.mbtnDelete.Name = "m_btnDelete";
		this.mbtnDelete.Size = new System.Drawing.Size(60, 20);
		this.mbtnDelete.Text = "Delete";
		this.mbtnEdit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
		this.mbtnEdit.Image = Properties.Resources.edit_16_pale;
		this.mbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.mbtnEdit.Name = "m_btnEdit";
		this.mbtnEdit.Size = new System.Drawing.Size(47, 20);
		this.mbtnEdit.Text = "Edit";
		this.mbtnAdd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
		this.mbtnAdd.Image = Properties.Resources.add_16_pale;
		this.mbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.mbtnAdd.Name = "m_btnAdd";
		this.mbtnAdd.Size = new System.Drawing.Size(49, 20);
		this.mbtnAdd.Text = "Add";
		this.imageList_1.TransparentColor = System.Drawing.Color.Transparent;
		this.imageList_0.TransparentColor = System.Drawing.Color.Transparent;
		this.mlstFolders.Dock = System.Windows.Forms.DockStyle.Fill;
		this.mlstFolders.ColumnHeader_0 = new System.Windows.Forms.ColumnHeader[0];
		this.mlstFolders.HideSelection = false;
		this.mlstFolders.LargeImageList = this.imageList_1;
		this.mlstFolders.Location = new System.Drawing.Point(0, 0);
		this.mlstFolders.Margin = new System.Windows.Forms.Padding(4);
		this.mlstFolders.Name = "m_lstFolders";
		this.mlstFolders.Size = new System.Drawing.Size(470, 238);
		this.mlstFolders.SmallImageList = this.imageList_0;
		this.mlstFolders.TabIndex = 1;
		this.mlstFolders.UseCompatibleStateImageBehavior = false;
		this.mlstFolders.View = System.Windows.Forms.View.List;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.Controls.Add(this.mlstFolders);
		base.Controls.Add(this.toolStrip1);
		this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.Margin = new System.Windows.Forms.Padding(4);
		base.Name = "DirectoriesTable";
		base.Size = new System.Drawing.Size(470, 263);
		this.toolStrip1.ResumeLayout(false);
		this.toolStrip1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void gclass0_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		RemoveSelected();
	}

	private void mlstFolders_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		RemoveListItem();
	}

	private void gclass0_0_EnabledChanged(object sender, EventArgs e)
	{
		ListViewItem[] listViewItem_ = mlstFolders.ListViewItem_0;
		for (int i = 0; i < listViewItem_.Length; i++)
		{
			listViewItem_[i].ImageIndex = ((!mlstFolders.Enabled) ? 1 : 0);
		}
	}

	private void mbtnAdd_Click(object sender, EventArgs e)
	{
		UpdateTotals();
	}

	private void mbtnEdit_Click(object sender, EventArgs e)
	{
		RemoveListItem();
	}

	private void mbtnDelete_Click(object sender, EventArgs e)
	{
		InitializeComponent();
	}

	private bool GetAddressCount(string string_0)
	{
		if (!string.IsNullOrEmpty(string_0))
		{
			return !String_0.Contains(string_0);
		}
		return false;
	}

	private void method_12(string string_0)
	{
		mlstFolders.Items.Add(new ListViewItem(string_0)
		{
			ImageIndex = ((!mlstFolders.Enabled) ? 1 : 0)
		});
	}

	private void method_13(object sender, EventArgs e)
	{
		UpdateTotals();
	}

	private void method_14(object sender, EventArgs e)
	{
		RemoveListItem();
	}

	private void method_15(object sender, EventArgs e)
	{
		InitializeComponent();
	}

	private void method_16(object sender, EventArgs e)
	{
		mlstFolders.View = View.LargeIcon;
	}

	private void method_17(object sender, EventArgs e)
	{
		mlstFolders.View = View.List;
	}

	private void method_18(object sender, EventArgs e)
	{
		mlstFolders.View = View.SmallIcon;
	}

	private void method_19(object sender, EventArgs e)
	{
		mlstFolders.View = View.Tile;
	}

	private void method_20(object sender, CancelEventArgs e)
	{
		((Class57)sender).Items["EditFolder"].Enabled = mlstFolders.Boolean_2;
		((Class57)sender).Items["DeleteFolder"].Enabled = mlstFolders.Boolean_1;
	}
}
