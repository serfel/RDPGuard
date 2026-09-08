using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Properties;

internal sealed class CustomActionsDialog : Form0
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<ListViewItem, Class94> _003C_003E9__4_0;

		public static Action<ListViewItem> _003C_003E9__8_0;

		public static ItemCheckedEventHandler _003C_003E9__10_3;

		internal Class94 method_0(ListViewItem listViewItem_0)
		{
			return listViewItem_0.Tag as Class94;
		}

		internal void method_1(ListViewItem listViewItem_0)
		{
			listViewItem_0.Remove();
		}

		internal void method_2(object sender, ItemCheckedEventArgs e)
		{
			(e.Item.Tag as Class94).bool_0 = e.Item.Checked;
			e.Item.ForeColor = ((e.Item.Checked ? true : false) ? SystemColors.WindowText : SystemColors.GrayText);
		}
	}

	private sealed class Class18
	{
		public CustomActionsDialog form24_0;

		public object object_0;

		public EventArgs2 eventArgs2_0;

		internal void method_0()
		{
			form24_0.InitializeComponent(object_0, eventArgs2_0);
		}

		internal void method_1(Class94 class94_0)
		{
			form24_0.OnCheckedChanged(class94_0);
		}
	}

	private readonly bool bool_0 = Class161.Boolean_0;

	private IContainer icontainer_0;

	private GControl0 separatorLine1;

	private Class62 label2;

	private PictureBox imgBigIcon;

	private Class62 lblCaption;

	private Class47 mlstActions;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private GClass3 mlnkOnlineHelp;

	private ColumnHeader columnHeader_2;

	private ColumnHeader columnHeader_3;

	private Class67 toolStrip1;

	private ToolStripButton mbtnAdd;

	private ToolStripButton mbtnEdit;

	private ToolStripButton mbtnDelete;

	private ToolStripButton mbtnCancel;

	private ToolStripButton mbtnSaveChanges;

	private ToolStripLabel mlblAdminRightsRequiredWarning;

	private Class94[] Class94_0
	{
		get
		{
			IEnumerable<ListViewItem> source = mlstActions.Items.Cast<ListViewItem>();
			Func<ListViewItem, Class94> selector = _003C_003Ec._003C_003E9.method_0;
			return source.Select(selector).ToArray();
		}
	}

	public CustomActionsDialog()
		: base(new Size(750, 525))
	{
		ValidateInput();
		InitializeFormPosition();
		Class89.eventHandler_25 = (EventHandler<EventArgs2>)Delegate.Combine(Class89.eventHandler_25, new EventHandler<EventArgs2>(InitializeComponent));
		Class89.smethod_34();
		SaveSettings();
		LoadSettings();
	}

	private void InitializeComponent(object sender, EventArgs2 e)
	{
		Class18 @class = new Class18();
		@class.form24_0 = this;
		@class.object_0 = sender;
		@class.eventArgs2_0 = e;
		Class89.eventHandler_25 = (EventHandler<EventArgs2>)Delegate.Remove(Class89.eventHandler_25, new EventHandler<EventArgs2>(InitializeComponent));
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
			return;
		}
		@class.eventArgs2_0.class94_0.smethod_0(@class.method_1);
		OnSelectedIndexChanged();
	}

	private void OnButtonOk()
	{
		Class89.smethod_35(Class94_0);
	}

	private void OnButtonCancel()
	{
		CustomActionAddEditDialog form = new CustomActionAddEditDialog(null);
		using (form)
		{
			if (DialogResult.OK == form.ShowDialog())
			{
				OnCheckedChanged(form.Class94_0);
				OnSelectedIndexChanged();
			}
		}
	}

	private void OnLoad()
	{
		if (!mlstActions.Boolean_2)
		{
			return;
		}
		CustomActionAddEditDialog form = new CustomActionAddEditDialog(mlstActions.SelectedItems[0].Tag as Class94);
		using (form)
		{
			if (DialogResult.OK == form.ShowDialog())
			{
				mlstActions.SelectedItems[0].Tag = form.Class94_0;
				OnSelectedIndexChanged();
			}
		}
	}

	private void ValidateInput()
	{
		if (mlstActions.Boolean_1 ? true : false)
		{
			IEnumerable<ListViewItem> ienumerable_ = mlstActions.SelectedItems.Cast<ListViewItem>();
			Action<ListViewItem> action_ = _003C_003Ec._003C_003E9.method_1;
			ienumerable_.smethod_0(action_);
		}
	}

	private void SaveSettings()
	{
		toolStrip1.Renderer = new GClass4();
		mlblAdminRightsRequiredWarning.Visible = !bool_0;
		mbtnAdd.Enabled = bool_0;
		mbtnSaveChanges.Enabled = bool_0;
	}

	private void LoadSettings()
	{
		mlstActions.SelectedIndexChanged += class47_0_SelectedIndexChanged;
		mlstActions.MouseDoubleClick += mlstActions_MouseDoubleClick;
		mlstActions.KeyUp += mlstActions_KeyUp;
		Class47 @class = mlstActions;
		ItemCheckedEventHandler value = _003C_003Ec._003C_003E9.method_2;
		@class.ItemChecked += value;
		mbtnAdd.Click += mbtnAdd_Click;
		mbtnEdit.Click += mbtnEdit_Click;
		mbtnDelete.Click += mbtnDelete_Click;
		mbtnSaveChanges.Click += mbtnSaveChanges_Click;
		mbtnCancel.Click += mbtnCancel_Click;
		mlnkOnlineHelp.Click += mlnkOnlineHelp_Click;
	}

	private void OnTextChanged()
	{
		mbtnEdit.Enabled = bool_0 && mlstActions.Boolean_2;
		mbtnDelete.Enabled = bool_0 && mlstActions.Boolean_1;
	}

	private void OnCheckedChanged(Class94 class94_0)
	{
		mlstActions.Items.Add(new ListViewItem
		{
			Tag = class94_0,
			Checked = class94_0.bool_0
		});
	}

	private void OnSelectedIndexChanged()
	{
		IEnumerator enumerator = mlstActions.Items.GetEnumerator();
		try
		{
			while (enumerator.MoveNext() ? true : false)
			{
				ListViewItem listViewItem = (ListViewItem)enumerator.Current;
				Class94 @class = listViewItem.Tag as Class94;
				listViewItem.SubItems.Clear();
				listViewItem.Text = string.Empty;
				listViewItem.SubItems.Add(Class185.Class185_0[@class.class95_0.GEnum2_0]);
				listViewItem.SubItems.Add(Class186.Class186_0[@class.gclass10_0.GEnum3_0]);
				listViewItem.SubItems.Add(@class.gclass10_0.method_2(bool_0: false));
				listViewItem.Checked = @class.bool_0;
				listViewItem.ForeColor = ((@class.bool_0 ? true : false) ? SystemColors.WindowText : SystemColors.GrayText);
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
		label2 = new Class62();
		imgBigIcon = new PictureBox();
		lblCaption = new Class62();
		mlstActions = new Class47();
		columnHeader_3 = new ColumnHeader();
		columnHeader_0 = new ColumnHeader();
		columnHeader_1 = new ColumnHeader();
		columnHeader_2 = new ColumnHeader();
		mlnkOnlineHelp = new GClass3();
		toolStrip1 = new Class67();
		mbtnAdd = new ToolStripButton();
		mbtnEdit = new ToolStripButton();
		mbtnDelete = new ToolStripButton();
		mbtnCancel = new ToolStripButton();
		mbtnSaveChanges = new ToolStripButton();
		mlblAdminRightsRequiredWarning = new ToolStripLabel();
		((ISupportInitialize)imgBigIcon).BeginInit();
		toolStrip1.SuspendLayout();
		SuspendLayout();
		separatorLine1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		separatorLine1.Location = new Point(10, 86);
		separatorLine1.Name = "separatorLine1";
		separatorLine1.Size = new Size(827, 2);
		separatorLine1.TabIndex = 50;
		separatorLine1.TabStop = false;
		label2.AutoSize = true;
		label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		label2.Location = new Point(87, 19);
		label2.Margin = new Padding(4, 0, 4, 0);
		label2.Name = "label2";
		label2.Size = new Size(113, 16);
		label2.TabIndex = 49;
		label2.Text = "Custom Actions";
		label2.Boolean_0 = false;
		imgBigIcon.Image = Resources.notifications_48;
		imgBigIcon.Location = new Point(16, 19);
		imgBigIcon.Margin = new Padding(4);
		imgBigIcon.Name = "imgBigIcon";
		imgBigIcon.Size = new Size(48, 48);
		imgBigIcon.SizeMode = PictureBoxSizeMode.AutoSize;
		imgBigIcon.TabIndex = 47;
		imgBigIcon.TabStop = false;
		lblCaption.AutoSize = true;
		lblCaption.Location = new Point(87, 51);
		lblCaption.Margin = new Padding(4, 0, 4, 0);
		lblCaption.Name = "lblCaption";
		lblCaption.Size = new Size(321, 16);
		lblCaption.TabIndex = 48;
		lblCaption.Text = "Define your own custom actions for RdpGuard events";
		lblCaption.Boolean_0 = false;
		mlstActions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		mlstActions.CheckBoxes = true;
		mlstActions.Columns.AddRange(new ColumnHeader[4] { columnHeader_3, columnHeader_0, columnHeader_1, columnHeader_2 });
		mlstActions.ColumnHeader_0 = new ColumnHeader[4] { columnHeader_3, columnHeader_0, columnHeader_1, columnHeader_2 };
		mlstActions.FullRowSelect = true;
		mlstActions.GridLines = true;
		mlstActions.HideSelection = false;
		mlstActions.Location = new Point(10, 105);
		mlstActions.Margin = new Padding(0, 0, 0, 20);
		mlstActions.Name = "m_lstActions";
		mlstActions.Size = new Size(827, 530);
		mlstActions.TabIndex = 6;
		mlstActions.UseCompatibleStateImageBehavior = false;
		mlstActions.View = View.Details;
		columnHeader_3.Text = "✓";
		columnHeader_3.Width = 30;
		columnHeader_0.Text = "Event";
		columnHeader_0.Width = 100;
		columnHeader_1.Text = "Task";
		columnHeader_1.Width = 150;
		columnHeader_2.Text = "Details";
		columnHeader_2.Width = 100;
		mlnkOnlineHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		mlnkOnlineHelp.AutoSize = true;
		mlnkOnlineHelp.LinkBehavior = LinkBehavior.NeverUnderline;
		mlnkOnlineHelp.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkOnlineHelp.Location = new Point(764, 15);
		mlnkOnlineHelp.Name = "m_lnkOnlineHelp";
		mlnkOnlineHelp.Size = new Size(72, 16);
		mlnkOnlineHelp.TabIndex = 5;
		mlnkOnlineHelp.TabStop = true;
		mlnkOnlineHelp.Text = "online help";
		mlnkOnlineHelp.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		toolStrip1.Dock = DockStyle.Bottom;
		toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
		toolStrip1.Items.AddRange(new ToolStripItem[6] { mbtnAdd, mbtnEdit, mbtnDelete, mbtnCancel, mbtnSaveChanges, mlblAdminRightsRequiredWarning });
		toolStrip1.Location = new Point(7, 640);
		toolStrip1.Name = "toolStrip1";
		toolStrip1.Padding = new Padding(3, 0, 3, 0);
		toolStrip1.RenderMode = ToolStripRenderMode.Professional;
		toolStrip1.Size = new Size(834, 26);
		toolStrip1.TabIndex = 51;
		mbtnAdd.Image = Resources.add_16_pale;
		mbtnAdd.ImageTransparentColor = Color.Magenta;
		mbtnAdd.Margin = new Padding(0);
		mbtnAdd.Name = "m_btnAdd";
		mbtnAdd.Padding = new Padding(3);
		mbtnAdd.Size = new Size(55, 26);
		mbtnAdd.Text = "Add";
		mbtnEdit.Enabled = false;
		mbtnEdit.Image = Resources.edit_16_pale;
		mbtnEdit.ImageTransparentColor = Color.Magenta;
		mbtnEdit.Margin = new Padding(0);
		mbtnEdit.Name = "m_btnEdit";
		mbtnEdit.Padding = new Padding(3);
		mbtnEdit.Size = new Size(53, 26);
		mbtnEdit.Text = "Edit";
		mbtnDelete.Enabled = false;
		mbtnDelete.Image = Resources.delete_16_pale;
		mbtnDelete.ImageTransparentColor = Color.Magenta;
		mbtnDelete.Margin = new Padding(0);
		mbtnDelete.Name = "m_btnDelete";
		mbtnDelete.Padding = new Padding(3);
		mbtnDelete.Size = new Size(66, 26);
		mbtnDelete.Text = "Delete";
		mbtnCancel.Alignment = ToolStripItemAlignment.Right;
		mbtnCancel.Image = Resources.cancel_16_pale;
		mbtnCancel.ImageTransparentColor = Color.Magenta;
		mbtnCancel.Margin = new Padding(0);
		mbtnCancel.Name = "m_btnCancel";
		mbtnCancel.Padding = new Padding(3);
		mbtnCancel.Size = new Size(69, 26);
		mbtnCancel.Text = "Cancel";
		mbtnSaveChanges.Alignment = ToolStripItemAlignment.Right;
		mbtnSaveChanges.Image = Resources.ok_16_pale;
		mbtnSaveChanges.ImageTransparentColor = Color.Magenta;
		mbtnSaveChanges.Margin = new Padding(0);
		mbtnSaveChanges.Name = "m_btnSaveChanges";
		mbtnSaveChanges.Padding = new Padding(3);
		mbtnSaveChanges.Size = new Size(106, 26);
		mbtnSaveChanges.Text = "Save Changes";
		mlblAdminRightsRequiredWarning.Alignment = ToolStripItemAlignment.Right;
		mlblAdminRightsRequiredWarning.ForeColor = Color.Red;
		mlblAdminRightsRequiredWarning.Name = "m_lblAdminRightsRequiredWarning";
		mlblAdminRightsRequiredWarning.Padding = new Padding(0, 0, 10, 0);
		mlblAdminRightsRequiredWarning.Size = new Size(348, 23);
		mlblAdminRightsRequiredWarning.Tag = "ThemeIndependentForeColor";
		mlblAdminRightsRequiredWarning.Text = "Administrator privileges are required to modify custom actions";
		mlblAdminRightsRequiredWarning.Visible = false;
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(848, 671);
		base.Controls.Add(mlnkOnlineHelp);
		base.Controls.Add(mlstActions);
		base.Controls.Add(separatorLine1);
		base.Controls.Add(label2);
		base.Controls.Add(lblCaption);
		base.Controls.Add(imgBigIcon);
		base.Controls.Add(toolStrip1);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(5, 4, 5, 4);
		base.Name = "CustomActionsDialog";
		base.Padding = new Padding(7, 10, 7, 5);
		base.StartPosition = FormStartPosition.Manual;
		Text = "Custom Actions";
		((ISupportInitialize)imgBigIcon).EndInit();
		toolStrip1.ResumeLayout(performLayout: false);
		toolStrip1.PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void class47_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		OnTextChanged();
	}

	private void mlstActions_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		OnLoad();
	}

	private void mlstActions_KeyUp(object sender, KeyEventArgs e)
	{
		if (Keys.Delete == e.KeyCode)
		{
			mbtnDelete.PerformClick();
		}
		if (Keys.Insert == e.KeyCode)
		{
			mbtnAdd.PerformClick();
		}
		if (Keys.F2 == e.KeyCode)
		{
			mbtnEdit.PerformClick();
		}
	}

	private void mbtnAdd_Click(object sender, EventArgs e)
	{
		OnButtonCancel();
	}

	private void mbtnEdit_Click(object sender, EventArgs e)
	{
		OnLoad();
	}

	private void mbtnDelete_Click(object sender, EventArgs e)
	{
		ValidateInput();
	}

	private void mbtnSaveChanges_Click(object sender, EventArgs e)
	{
		OnButtonOk();
		CloseDialog(DialogResult.OK);
	}

	private void mbtnCancel_Click(object sender, EventArgs e)
	{
		CloseDialog(DialogResult.Cancel);
	}

	private void mlnkOnlineHelp_Click(object sender, EventArgs e)
	{
		ShowOnlineHelp(Class148.Class153.String_0);
	}
}
