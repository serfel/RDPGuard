using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Properties;

internal sealed class SmtpServersDialog : Form0
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<ListViewItem, Class109> _003C_003E9__4_0;

		public static Action<ListViewItem> _003C_003E9__8_0;

		internal Class109 method_0(ListViewItem listViewItem_0)
		{
			return listViewItem_0.Tag as Class109;
		}

		internal void method_1(ListViewItem listViewItem_0)
		{
			listViewItem_0.Remove();
		}
	}

	private sealed class Class19
	{
		public SmtpServersDialog form25_0;

		public object object_0;

		public EventArgs4 eventArgs4_0;

		internal void method_0()
		{
			form25_0.method_12(object_0, eventArgs4_0);
		}

		internal void method_1(Class109 class109_0)
		{
			form25_0.method_19(class109_0);
		}
	}

	private IContainer icontainer_0;

	private Class66 class66_0;

	private Class66 class66_1;

	private GControl0 gcontrol0_0;

	private Class62 class62_0;

	private PictureBox pictureBox_0;

	private Class62 class62_1;

	private GClass0 gclass0_0;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private Class66 class66_2;

	private Class66 class66_3;

	private Class66 class66_4;

	private GClass3 gclass3_0;

	private ColumnHeader columnHeader_2;

	private ColumnHeader columnHeader_3;

	private ColumnHeader columnHeader_4;

	private Class109[] Class109_0
	{
		get
		{
			IEnumerable<ListViewItem> source = gclass0_0.Items.Cast<ListViewItem>();
			Func<ListViewItem, Class109> selector = _003C_003Ec._003C_003E9.method_0;
			return source.Select(selector).ToArray();
		}
	}

	public SmtpServersDialog()
		: base(new Size(700, 525))
	{
		InitializeComponent();
		vmethod_1();
		method_17();
		base.Shown += Form25_Shown;
	}

	private void method_11()
	{
		Class89.eventHandler_23 = (EventHandler<EventArgs4>)Delegate.Combine(Class89.eventHandler_23, new EventHandler<EventArgs4>(method_12));
		Class89.smethod_32();
	}

	private void method_12(object sender, EventArgs4 e)
	{
		Class19 @class = new Class19();
		@class.form25_0 = this;
		@class.object_0 = sender;
		@class.eventArgs4_0 = e;
		Class89.eventHandler_23 = (EventHandler<EventArgs4>)Delegate.Remove(Class89.eventHandler_23, new EventHandler<EventArgs4>(method_12));
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
			return;
		}
		@class.eventArgs4_0.class109_0.smethod_0(@class.method_1);
		method_20();
	}

	private void method_13()
	{
		Class89.smethod_33(Class109_0);
	}

	private void method_14()
	{
		using SmtpServerAddEditDialog form = new SmtpServerAddEditDialog(null);
		if (DialogResult.OK == form.ShowDialog())
		{
			method_19(form.Class109_0);
			method_20();
		}
	}

	private void method_15()
	{
		using SmtpServerAddEditDialog form = new SmtpServerAddEditDialog(gclass0_0.SelectedItems[0].Tag as Class109);
		if (DialogResult.OK == form.ShowDialog())
		{
			gclass0_0.SelectedItems[0].Tag = form.Class109_0;
			method_20();
		}
	}

	private void method_16()
	{
		IEnumerable<ListViewItem> ienumerable_ = gclass0_0.SelectedItems.Cast<ListViewItem>();
		Action<ListViewItem> action_ = _003C_003Ec._003C_003E9.method_1;
		ienumerable_.smethod_0(action_);
	}

	private void method_17()
	{
		gclass0_0.SelectedIndexChanged += gclass0_0_SelectedIndexChanged;
		gclass0_0.MouseDoubleClick += gclass0_0_MouseDoubleClick;
		gclass0_0.KeyUp += gclass0_0_KeyUp;
		class66_4.Click += class66_4_Click;
		class66_3.Click += class66_3_Click;
		class66_2.Click += class66_2_Click;
		class66_0.Click += class66_0_Click;
		class66_1.Click += class66_1_Click;
		gclass3_0.Click += gclass3_0_Click;
	}

	private void method_18()
	{
		class66_3.Enabled = gclass0_0.Boolean_2;
		class66_2.Enabled = gclass0_0.Boolean_1;
	}

	private void method_19(Class109 class109_0)
	{
		gclass0_0.Items.Add(new ListViewItem
		{
			Tag = class109_0
		});
	}

	private void method_20()
	{
		IEnumerator enumerator = gclass0_0.Items.GetEnumerator();
		try
		{
			while (enumerator.MoveNext() ? true : false)
			{
				ListViewItem listViewItem = (ListViewItem)enumerator.Current;
				Class109 @class = listViewItem.Tag as Class109;
				listViewItem.SubItems.Clear();
				listViewItem.Text = @class.string_1;
				listViewItem.SubItems.Add(@class.ushort_0.ToString());
				listViewItem.SubItems.Add((@class.bool_0 ? true : false) ? "Yes" : "No");
				listViewItem.SubItems.Add(@class.string_2);
				listViewItem.SubItems.Add((string.IsNullOrEmpty(@class.string_3) ? true : false) ? string.Empty : "**************");
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
		class66_0 = new Class66();
		class66_1 = new Class66();
		gcontrol0_0 = new GControl0();
		class62_0 = new Class62();
		pictureBox_0 = new PictureBox();
		class62_1 = new Class62();
		gclass0_0 = new GClass0();
		columnHeader_0 = new ColumnHeader();
		columnHeader_1 = new ColumnHeader();
		columnHeader_2 = new ColumnHeader();
		columnHeader_3 = new ColumnHeader();
		columnHeader_4 = new ColumnHeader();
		class66_2 = new Class66();
		class66_3 = new Class66();
		class66_4 = new Class66();
		gclass3_0 = new GClass3();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		class66_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_0.Image = Resources.opts_16;
		class66_0.Location = new Point(463, 438);
		class66_0.Margin = new Padding(4);
		class66_0.Name = "m_btnSave";
		class66_0.Size = new Size(100, 36);
		class66_0.TabIndex = 3;
		class66_0.Text = "Save";
		class66_0.TextAlign = ContentAlignment.MiddleRight;
		class66_0.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_0.UseVisualStyleBackColor = true;
		class66_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_1.Image = Resources.cancl_16;
		class66_1.Location = new Point(571, 438);
		class66_1.Margin = new Padding(4);
		class66_1.Name = "btnCancel";
		class66_1.Size = new Size(100, 36);
		class66_1.TabIndex = 4;
		class66_1.Text = "Cancel";
		class66_1.TextAlign = ContentAlignment.MiddleRight;
		class66_1.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_1.UseVisualStyleBackColor = true;
		gcontrol0_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		gcontrol0_0.Location = new Point(16, 81);
		gcontrol0_0.Name = "separatorLine1";
		gcontrol0_0.Size = new Size(656, 2);
		gcontrol0_0.TabIndex = 50;
		gcontrol0_0.TabStop = false;
		class62_0.AutoSize = true;
		class62_0.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		class62_0.Location = new Point(79, 15);
		class62_0.Margin = new Padding(4, 0, 4, 0);
		class62_0.Name = "label2";
		class62_0.Size = new Size(108, 16);
		class62_0.TabIndex = 49;
		class62_0.Text = "SMTP Servers";
		pictureBox_0.Image = Resources.mail_server_48;
		pictureBox_0.Location = new Point(16, 15);
		pictureBox_0.Margin = new Padding(4);
		pictureBox_0.Name = "imgBigIcon";
		pictureBox_0.Size = new Size(48, 48);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 47;
		pictureBox_0.TabStop = false;
		class62_1.AutoSize = true;
		class62_1.Location = new Point(79, 47);
		class62_1.Margin = new Padding(4, 0, 4, 0);
		class62_1.Name = "lblCaption";
		class62_1.Size = new Size(251, 16);
		class62_1.TabIndex = 48;
		class62_1.Text = "SMTP servers  to use for sending emails.";
		gclass0_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gclass0_0.Columns.AddRange(new ColumnHeader[5] { columnHeader_0, columnHeader_1, columnHeader_2, columnHeader_3, columnHeader_4 });
		gclass0_0.FullRowSelect = true;
		gclass0_0.GridLines = true;
		gclass0_0.HideSelection = false;
		gclass0_0.Location = new Point(15, 98);
		gclass0_0.Name = "m_lstSmtpServers";
		gclass0_0.Size = new Size(657, 325);
		gclass0_0.TabIndex = 6;
		gclass0_0.UseCompatibleStateImageBehavior = false;
		gclass0_0.View = View.Details;
		columnHeader_0.Text = "Host";
		columnHeader_0.Width = 100;
		columnHeader_1.Text = "Port";
		columnHeader_1.Width = 100;
		columnHeader_2.Text = "SSL/TLS";
		columnHeader_2.Width = 100;
		columnHeader_3.Text = "User name";
		columnHeader_3.Width = 100;
		columnHeader_4.Text = "Password";
		columnHeader_4.Width = 100;
		class66_2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		class66_2.Enabled = false;
		class66_2.Image = Resources.del_16;
		class66_2.ImageAlign = ContentAlignment.MiddleRight;
		class66_2.Location = new Point(232, 438);
		class66_2.Margin = new Padding(4);
		class66_2.Name = "m_btnDelete";
		class66_2.Size = new Size(100, 36);
		class66_2.TabIndex = 2;
		class66_2.Text = "Delete";
		class66_2.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_2.UseVisualStyleBackColor = true;
		class66_3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		class66_3.Enabled = false;
		class66_3.Image = Resources.edit_16;
		class66_3.ImageAlign = ContentAlignment.MiddleRight;
		class66_3.Location = new Point(124, 438);
		class66_3.Margin = new Padding(4);
		class66_3.Name = "m_btnEdit";
		class66_3.Size = new Size(100, 36);
		class66_3.TabIndex = 1;
		class66_3.Text = "Edit";
		class66_3.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_3.UseVisualStyleBackColor = true;
		class66_4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		class66_4.Image = Resources.add_16;
		class66_4.ImageAlign = ContentAlignment.MiddleRight;
		class66_4.Location = new Point(16, 438);
		class66_4.Margin = new Padding(4);
		class66_4.Name = "m_btnAdd";
		class66_4.Size = new Size(100, 36);
		class66_4.TabIndex = 0;
		class66_4.Text = "Add";
		class66_4.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_4.UseVisualStyleBackColor = true;
		gclass3_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		gclass3_0.AutoSize = true;
		gclass3_0.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_0.Location = new Point(599, 9);
		gclass3_0.Name = "m_lnkOnlineHelp";
		gclass3_0.Size = new Size(73, 16);
		gclass3_0.TabIndex = 5;
		gclass3_0.TabStop = true;
		gclass3_0.Text = "online help";
		gclass3_0.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(684, 487);
		base.Controls.Add(gclass3_0);
		base.Controls.Add(class66_2);
		base.Controls.Add(class66_3);
		base.Controls.Add(class66_4);
		base.Controls.Add(gclass0_0);
		base.Controls.Add(gcontrol0_0);
		base.Controls.Add(class62_0);
		base.Controls.Add(class62_1);
		base.Controls.Add(pictureBox_0);
		base.Controls.Add(class66_0);
		base.Controls.Add(class66_1);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(5, 4, 5, 4);
		base.Name = "SmtpServersDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "SMTP Servers";
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void Form25_Shown(object sender, EventArgs e)
	{
		method_11();
	}

	private void gclass0_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		method_18();
	}

	private void gclass0_0_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		method_15();
	}

	private void gclass0_0_KeyUp(object sender, KeyEventArgs e)
	{
		if (Keys.Delete == e.KeyCode)
		{
			class66_2.PerformClick();
		}
		if (Keys.Insert == e.KeyCode)
		{
			class66_4.PerformClick();
		}
		if (Keys.F2 == e.KeyCode)
		{
			class66_3.PerformClick();
		}
	}

	private void class66_4_Click(object sender, EventArgs e)
	{
		method_14();
	}

	private void class66_3_Click(object sender, EventArgs e)
	{
		method_15();
	}

	private void class66_2_Click(object sender, EventArgs e)
	{
		method_16();
	}

	private void class66_0_Click(object sender, EventArgs e)
	{
		method_13();
		method_8(DialogResult.OK);
	}

	private void class66_1_Click(object sender, EventArgs e)
	{
		method_8(DialogResult.Cancel);
	}

	private void gclass3_0_Click(object sender, EventArgs e)
	{
		method_9(Class148.Class154.String_0);
	}
}
