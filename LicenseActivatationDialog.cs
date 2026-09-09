using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class LicenseActivatationDialog : Form0
{
	private sealed class Class21
	{
		public LicenseActivatationDialog form30_0;

		public object object_0;

		public EventArgs11 eventArgs11_0;

		internal void method_0()
		{
			form30_0.method_11(object_0, eventArgs11_0);
		}
	}

	private sealed class Class22
	{
		public LicenseActivatationDialog form30_0;

		public object object_0;

		public EventArgs11 eventArgs11_0;

		internal void method_0()
		{
			form30_0.method_12(object_0, eventArgs11_0);
		}

		internal void method_1(object sender, EventArgs e)
		{
			form30_0.method_17();
		}
	}

	private sealed class Class23
	{
		public LicenseActivatationDialog form30_0;

		public object object_0;

		public EventArgs11 eventArgs11_0;

		internal void method_0()
		{
			form30_0.method_13(object_0, eventArgs11_0);
		}

		internal void method_1(object sender, EventArgs e)
		{
			form30_0.method_9(Class148.Class150.smethod_1(form30_0.class146_0.string_1));
		}

		internal void method_2(object sender, EventArgs e)
		{
			form30_0.method_9(Class148.Class150.String_1);
		}
	}

	private sealed class Class24
	{
		public LicenseActivatationDialog form30_0;

		public object object_0;

		public EventArgs11 eventArgs11_0;

		internal void method_0()
		{
			form30_0.method_15(object_0, eventArgs11_0);
		}
	}

	private sealed class Class25
	{
		public LicenseActivatationDialog form30_0;

		public object object_0;

		public EventArgs11 eventArgs11_0;

		internal void method_0()
		{
			form30_0.method_18(object_0, eventArgs11_0);
		}
	}

	private Class146 class146_0 = new Class146();

	private IContainer icontainer_0;

	private PictureBox pictureBox_0;

	private Class62 class62_0;

	private GClass3 gclass3_0;

	private Class62 class62_1;

	private Class66 class66_0;

	private Class66 class66_1;

	private TextBox textBox_0;

	private Class55 class55_0;

	private GControl0 gcontrol0_0;

	private StatusStrip statusStrip_0;

	private ToolStripStatusLabel toolStripStatusLabel_0;

	private PictureBox pictureBox_1;

	private GClass3 gclass3_1;

	public Class62 class62_2;

	public Class62 class62_3;

	public Class62 class62_4;

	protected override Button Button_0 => class66_0;

	public LicenseActivatationDialog()
		: base(new Size(700, 285))
	{
		InitializeComponent();
		vmethod_1();
		method_19();
		method_20();
		Class89.eventHandler_11 = (EventHandler<EventArgs11>)Delegate.Combine(Class89.eventHandler_11, new EventHandler<EventArgs11>(method_11));
		Class89.smethod_10();
		Class89.eventHandler_6 = (EventHandler<EventArgs11>)Delegate.Combine(Class89.eventHandler_6, new EventHandler<EventArgs11>(method_12));
		Class89.smethod_8();
	}

	private void method_11(object sender, EventArgs11 e)
	{
		Class21 @class = new Class21();
		@class.form30_0 = this;
		@class.object_0 = sender;
		@class.eventArgs11_0 = e;
		Class89.eventHandler_11 = (EventHandler<EventArgs11>)Delegate.Remove(Class89.eventHandler_11, new EventHandler<EventArgs11>(method_11));
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
		}
		else
		{
			class55_0.Text = @class.eventArgs11_0.class146_0.string_0;
		}
	}

	private void method_12(object sender, EventArgs11 e)
	{
		Class22 @class = new Class22();
		@class.form30_0 = this;
		@class.object_0 = sender;
		@class.eventArgs11_0 = e;
		Class89.eventHandler_6 = (EventHandler<EventArgs11>)Delegate.Remove(Class89.eventHandler_6, new EventHandler<EventArgs11>(method_12));
		class146_0 = @class.eventArgs11_0.class146_0;
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
		}
		else if (@class.eventArgs11_0.class146_0.Boolean_0)
		{
			Class89.eventHandler_10 = (EventHandler<EventArgs11>)Delegate.Combine(Class89.eventHandler_10, new EventHandler<EventArgs11>(method_13));
			Class89.smethod_14();
			class62_4.Left = class62_2.Left;
			class62_4.Top = class62_2.Top;
			class62_4.Visible = true;
			gclass3_1.Left = class62_4.Left + class62_4.Width + 2;
			gclass3_1.Top = class62_4.Top;
			gclass3_1.Visible = true;
			gclass3_1.Click += @class.method_1;
			gclass3_0.Visible = false;
			class66_0.Visible = false;
			class66_1.Text = "Закрыть";
			class66_1.Image = Resources.opts_16;
			class62_2.Visible = false;
			textBox_0.Visible = false;
			pictureBox_1.Left = class66_1.Left - pictureBox_1.Width - 10;
		}
	}

	private void method_13(object sender, EventArgs11 e)
	{
		Class23 @class = new Class23();
		@class.form30_0 = this;
		@class.object_0 = sender;
		@class.eventArgs11_0 = e;
		Class89.eventHandler_6 = (EventHandler<EventArgs11>)Delegate.Remove(Class89.eventHandler_6, new EventHandler<EventArgs11>(method_13));
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
			return;
		}
		uint uint_ = @class.eventArgs11_0.class146_0.uint_1;
		base.Controls.Add(new GClass3
		{
			AutoSize = true,
			Text = ((uint_ != 0) ? ($"Maintenance expires in {uint_} day{GClass21.smethod_2(uint_)} " + "( " + DateTime.Now.AddDays(uint_).ToShortDateString() + " )") : "Maintenance expired,"),
			eventHandler_0 = @class.method_1,
			Name = "expired_label",
			Location = gclass3_0.Location,
			Anchor = (AnchorStyles.Bottom | AnchorStyles.Left)
		});
		if (uint_ < 3)
		{
			base.Controls.Add(new GClass3
			{
				AutoSize = true,
				Text = "click here to renew.",
				eventHandler_0 = @class.method_2,
				Top = base.Controls["expired_label"].Top,
				Left = base.Controls["expired_label"].Right,
				Anchor = (AnchorStyles.Bottom | AnchorStyles.Left)
			});
		}
	}

	private void method_14(string string_0)
	{
		Class89.eventHandler_7 = (EventHandler<EventArgs11>)Delegate.Combine(Class89.eventHandler_7, new EventHandler<EventArgs11>(method_15));
		Class89.smethod_11(string_0.Trim());
		method_21(Class147.string_0);
		method_22(bool_0: true);
	}

	private void method_15(object sender, EventArgs11 e)
	{
		Class24 @class = new Class24();
		@class.form30_0 = this;
		@class.object_0 = sender;
		@class.eventArgs11_0 = e;
		Class89.eventHandler_7 = (EventHandler<EventArgs11>)Delegate.Remove(Class89.eventHandler_7, new EventHandler<EventArgs11>(method_15));
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
			return;
		}
		method_22(bool_0: false);
		method_16(@class.eventArgs11_0.class146_0);
	}

	private void method_16(Class146 class146_1)
	{
		if (class146_1.Boolean_0)
		{
			method_21(Class147.string_1);
			MessageBox.Show(Class147.string_1, Class138.String_1, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			method_8(DialogResult.OK);
			return;
		}
		string string_ = Class147.smethod_0(class146_1.genum19_0);
		method_21(string_);
		bool flag = GEnum19.const_4 == class146_1.genum19_0;
		bool flag2 = GEnum19.const_7 == class146_1.genum19_0;
		MessageBoxButtons buttons = (((flag || flag2) ? true : false) ? MessageBoxButtons.YesNo : MessageBoxButtons.OK);
		DialogResult dialogResult = MessageBox.Show(string_, Class138.String_1, buttons, MessageBoxIcon.Exclamation);
		if (DialogResult.Yes == dialogResult && flag)
		{
			method_9(Class148.Class150.String_0);
		}
		if (DialogResult.Yes == dialogResult && flag2)
		{
			method_9(Class148.Class150.String_1);
		}
	}

	private void method_17()
	{
		Class89.eventHandler_9 = (EventHandler<EventArgs11>)Delegate.Combine(Class89.eventHandler_9, new EventHandler<EventArgs11>(method_18));
		Class89.smethod_13();
		method_21(Class147.string_0);
		method_22(bool_0: true);
		method_9(Class148.Class150.smethod_1(class146_0.string_1));
	}

	private void method_18(object sender, EventArgs11 e)
	{
		Class25 @class = new Class25();
		@class.form30_0 = this;
		@class.object_0 = sender;
		@class.eventArgs11_0 = e;
		Class89.eventHandler_9 = (EventHandler<EventArgs11>)Delegate.Remove(Class89.eventHandler_9, new EventHandler<EventArgs11>(method_18));
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
			return;
		}
		method_22(bool_0: false);
		if (@class.eventArgs11_0.class146_0.bool_0)
		{
			method_21(Class147.string_2);
			MessageBox.Show(Class147.string_2, Class138.String_1, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			method_8(DialogResult.OK);
		}
		else
		{
			MessageBox.Show(Class147.smethod_0(GEnum19.const_6), Class138.String_1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void method_19()
	{
		class62_0.Text = "To activate RdpGuard enter your License Key into the box below and click Activate.";
		string text = (class62_1"RdpGuard Activation");
		string text3 = text;
		Text = text3;
		pictureBox_1.Image = ((Class163.Class163_0.Boolean_0 ? true : false) ? Resources.wait_25_dark : Resources.wait_25);
	}

	private void method_20()
	{
		gclass3_0.LinkClicked += gclass3_0_LinkClicked;
		pictureBox_0.MouseDoubleClick += pictureBox_0_MouseDoubleClick;
		class66_0.Click += class66_0_Click;
		class66_1.Click += class66_1_Click;
	}

	private void method_21(string string_0)
	{
		string_0 = string_0.Replace("\r\n", "");
		toolStripStatusLabel_0.Text = string_0;
	}

	private void method_22(bool bool_0)
	{
		pictureBox_1.Visible = bool_0;
		class55_0.Enabled = !bool_0;
		textBox_0.Enabled = !bool_0;
		class66_0.Enabled = !bool_0;
		class66_1.Enabled = !bool_0;
	}

	protected override void vmethod_0()
	{
		class66_0.Enabled = textBox_0.Text.Trim().StartsWith("RDPG-");
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(LicenseActivatationDialog));
		pictureBox_0 = new PictureBox();
		class62_0 = new Class62();
		gclass3_0 = new GClass3();
		class62_1 = new Class62();
		class66_0 = new Class66();
		class66_1 = new Class66();
		textBox_0 = new TextBox();
		class62_2 = new Class62();
		class55_0 = new Class55();
		class62_3 = new Class62();
		gcontrol0_0 = new GControl0();
		statusStrip_0 = new StatusStrip();
		toolStripStatusLabel_0 = new ToolStripStatusLabel();
		pictureBox_1 = new PictureBox();
		class62_4 = new Class62();
		gclass3_1 = new GClass3();
		((ISupportInitialize)pictureBox_0).BeginInit();
		statusStrip_0.SuspendLayout();
		((ISupportInitialize)pictureBox_1).BeginInit();
		SuspendLayout();
		pictureBox_0.Image = Resources.activate_pro_48;
		pictureBox_0.Location = new Point(16, 15);
		pictureBox_0.Margin = new Padding(4);
		pictureBox_0.Name = "pictureBox1";
		pictureBox_0.Size = new Size(48, 48);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 0;
		pictureBox_0.TabStop = false;
		class62_0.AutoSize = true;
		class62_0.Location = new Point(79, 47);
		class62_0.Margin = new Padding(4, 0, 4, 0);
		class62_0.Name = "m_lblSubCaption";
		class62_0.Size = new Size(0, 16);
		class62_0.TabIndex = 4;
		gclass3_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		gclass3_0.AutoSize = true;
		gclass3_0.LinkBehavior = LinkBehavior.NeverUnderline;
		gclass3_0.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_0.Location = new Point(12, 199);
		gclass3_0.Name = "m_lnkBuyProVersion";
		gclass3_0.RightToLeft = RightToLeft.No;
		gclass3_0.Size = new Size(217, 16);
		gclass3_0.TabIndex = 12;
		gclass3_0.TabStop = true;
		gclass3_0.Text = "Click here to obtain the License Key";
		gclass3_0.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		class62_1.AutoSize = true;
		class62_1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		class62_1.Location = new Point(79, 15);
		class62_1.Margin = new Padding(4, 0, 4, 0);
		class62_1.Name = "lblCaption";
		class62_1.Size = new Size(0, 16);
		class62_1.TabIndex = 14;
		class66_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_0.Enabled = false;
		class66_0.Image = Resources.opts_16;
		class66_0.Location = new Point(462, 179);
		class66_0.Margin = new Padding(4);
		class66_0.Name = "m_btnActivate";
		class66_0.Size = new Size(100, 36);
		class66_0.TabIndex = 17;
		class66_0.Text = "Activate";
		class66_0.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_0.UseVisualStyleBackColor = true;
		class66_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_1.Image = Resources.cancl_16;
		class66_1.Location = new Point(570, 179);
		class66_1.Margin = new Padding(4);
		class66_1.Name = "m_btnCancel";
		class66_1.Size = new Size(100, 36);
		class66_1.TabIndex = 18;
		class66_1.Text = "Отмена";
		class66_1.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_1.UseVisualStyleBackColor = true;
		textBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		textBox_0.Location = new Point(119, 149);
		textBox_0.Margin = new Padding(4);
		textBox_0.Name = "m_edLicenseKey";
		textBox_0.Size = new Size(552, 22);
		textBox_0.TabIndex = 0;
		class62_2.AutoSize = true;
		class62_2.Location = new Point(16, 152);
		class62_2.Margin = new Padding(4, 0, 4, 0);
		class62_2.Name = "m_lblActivationKey";
		class62_2.Size = new Size(83, 16);
		class62_2.TabIndex = 15;
		class62_2.Text = "License Key:";
		class55_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		class55_0.Location = new Point(119, 102);
		class55_0.Margin = new Padding(4);
		class55_0.Name = "m_edInstallationId";
		class55_0.ReadOnly = true;
		class55_0.Size = new Size(555, 22);
		class55_0.TabIndex = 23;
		class62_3.AutoSize = true;
		class62_3.Location = new Point(16, 105);
		class62_3.Margin = new Padding(4, 0, 4, 0);
		class62_3.Name = "label2";
		class62_3.Size = new Size(85, 16);
		class62_3.TabIndex = 22;
		class62_3.Text = "Hardware ID:";
		gcontrol0_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		gcontrol0_0.Location = new Point(16, 81);
		gcontrol0_0.Name = "separatorLine1";
		gcontrol0_0.Size = new Size(655, 2);
		gcontrol0_0.TabIndex = 36;
		gcontrol0_0.TabStop = false;
		statusStrip_0.Location = new Point(0, 224);
		statusStrip_0.Name = "statusStrip1";
		statusStrip_0.Size = new Size(684, 22);
		statusStrip_0.TabIndex = 42;
		statusStrip_0.Text = "statusStrip1";
		toolStripStatusLabel_0.Name = "toolStripStatusLabel1";
		toolStripStatusLabel_0.Size = new Size(669, 17);
		toolStripStatusLabel_0.Spring = true;
		toolStripStatusLabel_0.TextAlign = ContentAlignment.MiddleLeft;
		pictureBox_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		pictureBox_1.Location = new Point(430, 184);
		pictureBox_1.Name = "imgWait";
		pictureBox_1.Size = new Size(25, 25);
		pictureBox_1.TabIndex = 43;
		pictureBox_1.TabStop = false;
		pictureBox_1.Visible = false;
		class62_4.AutoSize = true;
		class62_4.ForeColor = Color.Green;
		class62_4.Location = new Point(16, 175);
		class62_4.Margin = new Padding(4, 0, 4, 0);
		class62_4.Name = "m_lblAlreadyActivated";
		class62_4.Size = new Size(258, 16);
		class62_4.TabIndex = 44;
		class62_4.Text = "License key already activated. Thank you.";
		class62_4.Boolean_0 = true;
		class62_4.Visible = false;
		gclass3_1.AutoSize = true;
		gclass3_1.LinkBehavior = LinkBehavior.NeverUnderline;
		gclass3_1.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_1.Location = new Point(273, 175);
		gclass3_1.Name = "m_lnkDeactivate";
		gclass3_1.RightToLeft = RightToLeft.No;
		gclass3_1.Size = new Size(353, 16);
		gclass3_1.TabIndex = 45;
		gclass3_1.TabStop = true;
		gclass3_1.Text = "Щёлкните здесь, чтобы деактивировать ключ лицензии на этом компьютере.";
		gclass3_1.Visible = false;
		gclass3_1.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(684, 246);
		base.Controls.Add(gclass3_1);
		base.Controls.Add(class62_4);
		base.Controls.Add(pictureBox_1);
		base.Controls.Add(statusStrip_0);
		base.Controls.Add(gcontrol0_0);
		base.Controls.Add(class55_0);
		base.Controls.Add(class62_3);
		base.Controls.Add(class66_0);
		base.Controls.Add(class66_1);
		base.Controls.Add(textBox_0);
		base.Controls.Add(class62_2);
		base.Controls.Add(class62_1);
		base.Controls.Add(gclass3_0);
		base.Controls.Add(class62_0);
		base.Controls.Add(pictureBox_0);
		Font = new Font("Microsoft Sans Serif", 9.75f);
		base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		base.Margin = new Padding(4);
		base.Name = "LicenseActivatationDialog";
		base.StartPosition = FormStartPosition.Manual;
		((ISupportInitialize)pictureBox_0).EndInit();
		statusStrip_0.ResumeLayout(performLayout: false);
		statusStrip_0.PerformLayout();
		((ISupportInitialize)pictureBox_1).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void gclass3_0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		method_9(Class148.Class150.smethod_0("activate_pro"));
	}

	private void pictureBox_0_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		LicenseActivatationOfflineDialog form = new LicenseActivatationOfflineDialog();
		using (form)
		{
			if (DialogResult.OK == form.ShowDialog())
			{
				method_16(form.class146_0);
			}
		}
	}

	private void class66_0_Click(object sender, EventArgs e)
	{
		method_14(textBox_0.Text.Trim());
	}

	private void class66_1_Click(object sender, EventArgs e)
	{
		method_8(DialogResult.Cancel);
	}
}
