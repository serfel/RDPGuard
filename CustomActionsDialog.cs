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
			form24_0.method_11(object_0, eventArgs2_0);
		}

		internal void method_1(Class94 class94_0)
		{
			form24_0.method_19(class94_0);
		}
	}

	private readonly bool bool_0 = Class161.Boolean_0;

	private IContainer icontainer_0;

	private GControl0 gcontrol0_0;

	private Class62 class62_0;

	private PictureBox pictureBox_0;

	private Class62 class62_1;

	private Class47 class47_0;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private GClass3 gclass3_0;

	private ColumnHeader columnHeader_2;

	private ColumnHeader columnHeader_3;

	private Class67 class67_0;

	private ToolStripButton toolStripButton_0;

	private ToolStripButton toolStripButton_1;

	private ToolStripButton toolStripButton_2;

	private ToolStripButton toolStripButton_3;

	private ToolStripButton toolStripButton_4;

	private ToolStripLabel toolStripLabel_0;

	private Class94[] Class94_0
	{
		get
		{
			IEnumerable<ListViewItem> source = class47_0.Items.Cast<ListViewItem>();
			Func<ListViewItem, Class94> selector = _003C_003Ec._003C_003E9.method_0;
			return source.Select(selector).ToArray();
		}
	}

	public CustomActionsDialog()
		: base(new Size(750, 525))
	{
		InitializeComponent();
		vmethod_1();
		Class89.eventHandler_25 = (EventHandler<EventArgs2>)Delegate.Combine(Class89.eventHandler_25, new EventHandler<EventArgs2>(method_11));
		Class89.smethod_34();
		method_16();
		method_17();
	}

	private void method_11(object sender, EventArgs2 e)
	{
		Class18 @class = new Class18();
		@class.form24_0 = this;
		@class.object_0 = sender;
		@class.eventArgs2_0 = e;
		Class89.eventHandler_25 = (EventHandler<EventArgs2>)Delegate.Remove(Class89.eventHandler_25, new EventHandler<EventArgs2>(method_11));
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
			return;
		}
		@class.eventArgs2_0.class94_0.smethod_0(@class.method_1);
		method_20();
	}

	private void method_12()
	{
		Class89.smethod_35(Class94_0);
	}

	private void method_13()
	{
		CustomActionAddEditDialog form = new CustomActionAddEditDialog(null);
		using (form)
		{
			if (DialogResult.OK == form.ShowDialog())
			{
				method_19(form.Class94_0);
				method_20();
			}
		}
	}

	private void method_14()
	{
		if (!class47_0.Boolean_2)
		{
			return;
		}
		CustomActionAddEditDialog form = new CustomActionAddEditDialog(class47_0.SelectedItems[0].Tag as Class94);
		using (form)
		{
			if (DialogResult.OK == form.ShowDialog())
			{
				class47_0.SelectedItems[0].Tag = form.Class94_0;
				method_20();
			}
		}
	}

	private void method_15()
	{
		if (class47_0.Boolean_1 ? true : false)
		{
			IEnumerable<ListViewItem> ienumerable_ = class47_0.SelectedItems.Cast<ListViewItem>();
			Action<ListViewItem> action_ = _003C_003Ec._003C_003E9.method_1;
			ienumerable_.smethod_0(action_);
		}
	}

	private void method_16()
	{
		class67_0.Renderer = new GClass4();
		toolStripLabel_0.Visible = !bool_0;
		toolStripButton_0.Enabled = bool_0;
		toolStripButton_4.Enabled = bool_0;
	}

	private void method_17()
	{
		class47_0.SelectedIndexChanged += class47_0_SelectedIndexChanged;
		class47_0.MouseDoubleClick += class47_0_MouseDoubleClick;
		class47_0.KeyUp += class47_0_KeyUp;
		Class47 @class = class47_0;
		ItemCheckedEventHandler value = _003C_003Ec._003C_003E9.method_2;
		@class.ItemChecked += value;
		toolStripButton_0.Click += toolStripButton_0_Click;
		toolStripButton_1.Click += toolStripButton_1_Click;
		toolStripButton_2.Click += toolStripButton_2_Click;
		toolStripButton_4.Click += toolStripButton_4_Click;
		toolStripButton_3.Click += toolStripButton_3_Click;
		gclass3_0.Click += gclass3_0_Click;
	}

	private void method_18()
	{
		toolStripButton_1.Enabled = bool_0 && class47_0.Boolean_2;
		toolStripButton_2.Enabled = bool_0 && class47_0.Boolean_1;
	}

	private void method_19(Class94 class94_0)
	{
		class47_0.Items.Add(new ListViewItem
		{
			Tag = class94_0,
			Checked = class94_0.bool_0
		});
	}

	private void method_20()
	{
		IEnumerator enumerator = class47_0.Items.GetEnumerator();
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

	private void InitializeComponent()
	{
		gcontrol0_0 = new GControl0();
		class62_0 = new Class62();
		pictureBox_0 = new PictureBox();
		class62_1 = new Class62();
		class47_0 = new Class47();
		columnHeader_3 = new ColumnHeader();
		columnHeader_0 = new ColumnHeader();
		columnHeader_1 = new ColumnHeader();
		columnHeader_2 = new ColumnHeader();
		gclass3_0 = new GClass3();
		class67_0 = new Class67();
		toolStripButton_0 = new ToolStripButton();
		toolStripButton_1 = new ToolStripButton();
		toolStripButton_2 = new ToolStripButton();
		toolStripButton_3 = new ToolStripButton();
		toolStripButton_4 = new ToolStripButton();
		toolStripLabel_0 = new ToolStripLabel();
		((ISupportInitialize)pictureBox_0).BeginInit();
		class67_0.SuspendLayout();
		SuspendLayout();
		gcontrol0_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		gcontrol0_0.Location = new Point(10, 86);
		gcontrol0_0.Name = "separatorLine1";
		gcontrol0_0.Size = new Size(827, 2);
		gcontrol0_0.TabIndex = 50;
		gcontrol0_0.TabStop = false;
		class62_0.AutoSize = true;
		class62_0.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		class62_0.Location = new Point(87, 19);
		class62_0.Margin = new Padding(4, 0, 4, 0);
		class62_0.Name = "label2";
		class62_0.Size = new Size(113, 16);
		class62_0.TabIndex = 49;
		class62_0"Custom Actions";
		class62_0.Boolean_0 = false;
		pictureBox_0.Image = Resources.notifications_48;
		pictureBox_0.Location = new Point(16, 19);
		pictureBox_0.Margin = new Padding(4);
		pictureBox_0.Name = "imgBigIcon";
		pictureBox_0.Size = new Size(48, 48);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 47;
		pictureBox_0.TabStop = false;
		class62_1.AutoSize = true;
		class62_1.Location = new Point(87, 51);
		class62_1.Margin = new Padding(4, 0, 4, 0);
		class62_1.Name = "lblCaption";
		class62_1.Size = new Size(321, 16);
		class62_1.TabIndex = 48;
		class62_1"Define your own custom actions for RdpGuard events";
		class62_1.Boolean_0 = false;
		class47_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		class47_0.CheckBoxes = true;
		class47_0.Columns.AddRange(new ColumnHeader[4] { columnHeader_3, columnHeader_0, columnHeader_1, columnHeader_2 });
		class47_0.ColumnHeader_0 = new ColumnHeader[4] { columnHeader_3, columnHeader_0, columnHeader_1, columnHeader_2 };
		class47_0.FullRowSelect = true;
		class47_0.GridLines = true;
		class47_0.HideSelection = false;
		class47_0.Location = new Point(10, 105);
		class47_0.Margin = new Padding(0, 0, 0, 20);
		class47_0.Name = "m_lstActions";
		class47_0.Size = new Size(827, 530);
		class47_0.TabIndex = 6;
		class47_0.UseCompatibleStateImageBehavior = false;
		class47_0.View = View.Details;
		columnHeader_3"✓";
		columnHeader_3.Width = 30;
		columnHeader_0"Event";
		columnHeader_0.Width = 100;
		columnHeader_1"Task";
		columnHeader_1.Width = 150;
		columnHeader_2"Details";
		columnHeader_2.Width = 100;
		gclass3_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		gclass3_0.AutoSize = true;
		gclass3_0.LinkBehavior = LinkBehavior.NeverUnderline;
		gclass3_0.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_0.Location = new Point(764, 15);
		gclass3_0.Name = "m_lnkOnlineHelp";
		gclass3_0.Size = new Size(72, 16);
		gclass3_0.TabIndex = 5;
		gclass3_0.TabStop = true;
		gclass3_0.Text = "справка онлайн";
		gclass3_0.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		class67_0.Dock = DockStyle.Bottom;
		class67_0.GripStyle = ToolStripGripStyle.Hidden;
		class67_0.Items.AddRange(new ToolStripItem[6] { toolStripButton_0, toolStripButton_1, toolStripButton_2, toolStripButton_3, toolStripButton_4, toolStripLabel_0 });
		class67_0.Location = new Point(7, 640);
		class67_0.Name = "toolStrip1";
		class67_0.Padding = new Padding(3, 0, 3, 0);
		class67_0.RenderMode = ToolStripRenderMode.Professional;
		class67_0.Size = new Size(834, 26);
		class67_0.TabIndex = 51;
		toolStripButton_0.Image = Resources.add_16_pale;
		toolStripButton_0.ImageTransparentColor = Color.Magenta;
		toolStripButton_0.Margin = new Padding(0);
		toolStripButton_0.Name = "m_btnAdd";
		toolStripButton_0.Padding = new Padding(3);
		toolStripButton_0.Size = new Size(55, 26);
		toolStripButton_0.Text = "Добавить";
		toolStripButton_1.Enabled = false;
		toolStripButton_1.Image = Resources.edit_16_pale;
		toolStripButton_1.ImageTransparentColor = Color.Magenta;
		toolStripButton_1.Margin = new Padding(0);
		toolStripButton_1.Name = "m_btnEdit";
		toolStripButton_1.Padding = new Padding(3);
		toolStripButton_1.Size = new Size(53, 26);
		toolStripButton_1.Text = "Изменить";
		toolStripButton_2.Enabled = false;
		toolStripButton_2.Image = Resources.delete_16_pale;
		toolStripButton_2.ImageTransparentColor = Color.Magenta;
		toolStripButton_2.Margin = new Padding(0);
		toolStripButton_2.Name = "m_btnDelete";
		toolStripButton_2.Padding = new Padding(3);
		toolStripButton_2.Size = new Size(66, 26);
		toolStripButton_2.Text = "Удалить";
		toolStripButton_3.Alignment = ToolStripItemAlignment.Right;
		toolStripButton_3.Image = Resources.cancel_16_pale;
		toolStripButton_3.ImageTransparentColor = Color.Magenta;
		toolStripButton_3.Margin = new Padding(0);
		toolStripButton_3.Name = "m_btnCancel";
		toolStripButton_3.Padding = new Padding(3);
		toolStripButton_3.Size = new Size(69, 26);
		toolStripButton_3.Text = "Отмена";
		toolStripButton_4.Alignment = ToolStripItemAlignment.Right;
		toolStripButton_4.Image = Resources.ok_16_pale;
		toolStripButton_4.ImageTransparentColor = Color.Magenta;
		toolStripButton_4.Margin = new Padding(0);
		toolStripButton_4.Name = "m_btnSaveChanges";
		toolStripButton_4.Padding = new Padding(3);
		toolStripButton_4.Size = new Size(106, 26);
		toolStripButton_4.Text = "Сохранить Changes";
		toolStripLabel_0.Alignment = ToolStripItemAlignment.Right;
		toolStripLabel_0.ForeColor = Color.Red;
		toolStripLabel_0.Name = "m_lblAdminRightsRequiredWarning";
		toolStripLabel_0.Padding = new Padding(0, 0, 10, 0);
		toolStripLabel_0.Size = new Size(348, 23);
		toolStripLabel_0.Tag = "ThemeIndependentForeColor";
		toolStripLabel_0"Administrator privileges are required to modify custom actions";
		toolStripLabel_0.Visible = false;
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(848, 671);
		base.Controls.Add(gclass3_0);
		base.Controls.Add(class47_0);
		base.Controls.Add(gcontrol0_0);
		base.Controls.Add(class62_0);
		base.Controls.Add(class62_1);
		base.Controls.Add(pictureBox_0);
		base.Controls.Add(class67_0);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(5, 4, 5, 4);
		base.Name = "CustomActionsDialog";
		base.Padding = new Padding(7, 10, 7, 5);
		base.StartPosition = FormStartPosition.Manual;
		Text = "Custom Actions";
		((ISupportInitialize)pictureBox_0).EndInit();
		class67_0.ResumeLayout(performLayout: false);
		class67_0.PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void class47_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		method_18();
	}

	private void class47_0_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		method_14();
	}

	private void class47_0_KeyUp(object sender, KeyEventArgs e)
	{
		if (Keys.Delete == e.KeyCode)
		{
			toolStripButton_2.PerformClick();
		}
		if (Keys.Insert == e.KeyCode)
		{
			toolStripButton_0.PerformClick();
		}
		if (Keys.F2 == e.KeyCode)
		{
			toolStripButton_1.PerformClick();
		}
	}

	private void toolStripButton_0_Click(object sender, EventArgs e)
	{
		method_13();
	}

	private void toolStripButton_1_Click(object sender, EventArgs e)
	{
		method_14();
	}

	private void toolStripButton_2_Click(object sender, EventArgs e)
	{
		method_15();
	}

	private void toolStripButton_4_Click(object sender, EventArgs e)
	{
		method_12();
		method_8(DialogResult.OK);
	}

	private void toolStripButton_3_Click(object sender, EventArgs e)
	{
		method_8(DialogResult.Cancel);
	}

	private void gclass3_0_Click(object sender, EventArgs e)
	{
		method_9(Class148.Class153.String_0);
	}
}
