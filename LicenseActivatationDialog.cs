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
			form30_0.InitializeComponent(object_0, eventArgs11_0);
		}
	}

	private sealed class Class22
	{
		public LicenseActivatationDialog form30_0;

		public object object_0;

		public EventArgs11 eventArgs11_0;

		internal void method_0()
		{
			form30_0.OnButtonOk(object_0, eventArgs11_0);
		}

		internal void method_1(object sender, EventArgs e)
		{
			form30_0.LoadSettings();
		}
	}

	private sealed class Class23
	{
		public LicenseActivatationDialog form30_0;

		public object object_0;

		public EventArgs11 eventArgs11_0;

		internal void method_0()
		{
			form30_0.OnButtonCancel(object_0, eventArgs11_0);
		}

		internal void method_1(object sender, EventArgs e)
		{
			form30_0.ShowOnlineHelp(Class148.Class150.smethod_1(form30_0.class146_0.string_1));
		}

		internal void method_2(object sender, EventArgs e)
		{
			form30_0.ShowOnlineHelp(Class148.Class150.String_1);
		}
	}

	private sealed class Class24
	{
		public LicenseActivatationDialog form30_0;

		public object object_0;

		public EventArgs11 eventArgs11_0;

		internal void method_0()
		{
			form30_0.ValidateInput(object_0, eventArgs11_0);
		}
	}

	private sealed class Class25
	{
		public LicenseActivatationDialog form30_0;

		public object object_0;

		public EventArgs11 eventArgs11_0;

		internal void method_0()
		{
			form30_0.OnTextChanged(object_0, eventArgs11_0);
		}
	}

	private Class146 class146_0 = new Class146();

	private IContainer icontainer_0;

	private PictureBox pictureBox1;

	private Class62 mlblSubCaption;

	private GClass3 mlnkBuyProVersion;

	private Class62 lblCaption;

	private Class66 mbtnActivate;

	private Class66 mbtnCancel;

	private TextBox medLicenseKey;

	private Class55 medInstallationId;

	private GControl0 separatorLine1;

	private StatusStrip statusStrip1;

	private ToolStripStatusLabel toolStripStatusLabel1;

	private PictureBox imgWait;

	private GClass3 mlnkDeactivate;

	public Class62 mlblActivationKey;

	public Class62 label2;

	public Class62 mlblAlreadyActivated;

	protected override Button Button_0 => mbtnActivate;

	public LicenseActivatationDialog()
		: base(new Size(700, 285))
	{
		ValidateInput();
		InitializeFormPosition();
		OnCheckedChanged();
		OnSelectedIndexChanged();
		Class89.eventHandler_11 = (EventHandler<EventArgs11>)Delegate.Combine(Class89.eventHandler_11, new EventHandler<EventArgs11>(InitializeComponent));
		Class89.smethod_10();
		Class89.eventHandler_6 = (EventHandler<EventArgs11>)Delegate.Combine(Class89.eventHandler_6, new EventHandler<EventArgs11>(OnButtonOk));
		Class89.smethod_8();
	}

	private void InitializeComponent(object sender, EventArgs11 e)
	{
		Class21 @class = new Class21();
		@class.form30_0 = this;
		@class.object_0 = sender;
		@class.eventArgs11_0 = e;
		Class89.eventHandler_11 = (EventHandler<EventArgs11>)Delegate.Remove(Class89.eventHandler_11, new EventHandler<EventArgs11>(InitializeComponent));
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
		}
		else
		{
			medInstallationId.Text = @class.eventArgs11_0.class146_0.string_0;
		}
	}

	private void OnButtonOk(object sender, EventArgs11 e)
	{
		Class22 @class = new Class22();
		@class.form30_0 = this;
		@class.object_0 = sender;
		@class.eventArgs11_0 = e;
		Class89.eventHandler_6 = (EventHandler<EventArgs11>)Delegate.Remove(Class89.eventHandler_6, new EventHandler<EventArgs11>(OnButtonOk));
		class146_0 = @class.eventArgs11_0.class146_0;
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
		}
		else if (@class.eventArgs11_0.class146_0.Boolean_0)
		{
			Class89.eventHandler_10 = (EventHandler<EventArgs11>)Delegate.Combine(Class89.eventHandler_10, new EventHandler<EventArgs11>(OnButtonCancel));
			Class89.smethod_14();
			mlblAlreadyActivated.Left = mlblActivationKey.Left;
			mlblAlreadyActivated.Top = mlblActivationKey.Top;
			mlblAlreadyActivated.Visible = true;
			mlnkDeactivate.Left = mlblAlreadyActivated.Left + mlblAlreadyActivated.Width + 2;
			mlnkDeactivate.Top = mlblAlreadyActivated.Top;
			mlnkDeactivate.Visible = true;
			mlnkDeactivate.Click += @class.method_1;
			mlnkBuyProVersion.Visible = false;
			mbtnActivate.Visible = false;
			mbtnCancel.Text = "Close";
			mbtnCancel.Image = Resources.opts_16;
			mlblActivationKey.Visible = false;
			medLicenseKey.Visible = false;
			imgWait.Left = mbtnCancel.Left - imgWait.Width - 10;
		}
	}

	private void OnButtonCancel(object sender, EventArgs11 e)
	{
		Class23 @class = new Class23();
		@class.form30_0 = this;
		@class.object_0 = sender;
		@class.eventArgs11_0 = e;
		Class89.eventHandler_6 = (EventHandler<EventArgs11>)Delegate.Remove(Class89.eventHandler_6, new EventHandler<EventArgs11>(OnButtonCancel));
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
			Location = mlnkBuyProVersion.Location,
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

	private void OnLoad(string string_0)
	{
		Class89.eventHandler_7 = (EventHandler<EventArgs11>)Delegate.Combine(Class89.eventHandler_7, new EventHandler<EventArgs11>(ValidateInput));
		Class89.smethod_11(string_0.Trim());
		method_21(Class147.string_0);
		method_22(bool_0: true);
	}

	private void ValidateInput(object sender, EventArgs11 e)
	{
		Class24 @class = new Class24();
		@class.form30_0 = this;
		@class.object_0 = sender;
		@class.eventArgs11_0 = e;
		Class89.eventHandler_7 = (EventHandler<EventArgs11>)Delegate.Remove(Class89.eventHandler_7, new EventHandler<EventArgs11>(ValidateInput));
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
			return;
		}
		method_22(bool_0: false);
		SaveSettings(@class.eventArgs11_0.class146_0);
	}

	private void SaveSettings(Class146 class146_1)
	{
		if (class146_1.Boolean_0)
		{
			method_21(Class147.string_1);
			MessageBox.Show(Class147.string_1, Class138.String_1, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			CloseDialog(DialogResult.OK);
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
			ShowOnlineHelp(Class148.Class150.String_0);
		}
		if (DialogResult.Yes == dialogResult && flag2)
		{
			ShowOnlineHelp(Class148.Class150.String_1);
		}
	}

	private void LoadSettings()
	{
		Class89.eventHandler_9 = (EventHandler<EventArgs11>)Delegate.Combine(Class89.eventHandler_9, new EventHandler<EventArgs11>(OnTextChanged));
		Class89.smethod_13();
		method_21(Class147.string_0);
		method_22(bool_0: true);
		ShowOnlineHelp(Class148.Class150.smethod_1(class146_0.string_1));
	}

	private void OnTextChanged(object sender, EventArgs11 e)
	{
		Class25 @class = new Class25();
		@class.form30_0 = this;
		@class.object_0 = sender;
		@class.eventArgs11_0 = e;
		Class89.eventHandler_9 = (EventHandler<EventArgs11>)Delegate.Remove(Class89.eventHandler_9, new EventHandler<EventArgs11>(OnTextChanged));
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
			CloseDialog(DialogResult.OK);
		}
		else
		{
			MessageBox.Show(Class147.smethod_0(GEnum19.const_6), Class138.String_1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void OnCheckedChanged()
	{
		mlblSubCaption.Text = "To activate RdpGuard enter your License Key into the box below and click Activate.";
		string text = (lblCaption.Text = "RdpGuard Activation");
		string text3 = text;
		Text = text3;
		imgWait.Image = ((Class163.Class163_0.Boolean_0 ? true : false) ? Resources.wait_25_dark : Resources.wait_25);
	}

	private void OnSelectedIndexChanged()
	{
		mlnkBuyProVersion.LinkClicked += mlnkBuyProVersion_LinkClicked;
		pictureBox1.MouseDoubleClick += pictureBox1_MouseDoubleClick;
		mbtnActivate.Click += mbtnActivate_Click;
		mbtnCancel.Click += mbtnCancel_Click;
	}

	private void method_21(string string_0)
	{
		string_0 = string_0.Replace("\r\n", "");
		toolStripStatusLabel1.Text = string_0;
	}

	private void method_22(bool bool_0)
	{
		imgWait.Visible = bool_0;
		medInstallationId.Enabled = !bool_0;
		medLicenseKey.Enabled = !bool_0;
		mbtnActivate.Enabled = !bool_0;
		mbtnCancel.Enabled = !bool_0;
	}

	protected override void OnFormClosing()
	{
		mbtnActivate.Enabled = medLicenseKey.Text.Trim().StartsWith("RDPG-");
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(LicenseActivatationDialog));
		pictureBox1 = new PictureBox();
		mlblSubCaption = new Class62();
		mlnkBuyProVersion = new GClass3();
		lblCaption = new Class62();
		mbtnActivate = new Class66();
		mbtnCancel = new Class66();
		medLicenseKey = new TextBox();
		mlblActivationKey = new Class62();
		medInstallationId = new Class55();
		label2 = new Class62();
		separatorLine1 = new GControl0();
		statusStrip1 = new StatusStrip();
		toolStripStatusLabel1 = new ToolStripStatusLabel();
		imgWait = new PictureBox();
		mlblAlreadyActivated = new Class62();
		mlnkDeactivate = new GClass3();
		((ISupportInitialize)pictureBox1).BeginInit();
		statusStrip1.SuspendLayout();
		((ISupportInitialize)imgWait).BeginInit();
		SuspendLayout();
		pictureBox1.Image = Resources.activate_pro_48;
		pictureBox1.Location = new Point(16, 15);
		pictureBox1.Margin = new Padding(4);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(48, 48);
		pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox1.TabIndex = 0;
		pictureBox1.TabStop = false;
		mlblSubCaption.AutoSize = true;
		mlblSubCaption.Location = new Point(79, 47);
		mlblSubCaption.Margin = new Padding(4, 0, 4, 0);
		mlblSubCaption.Name = "m_lblSubCaption";
		mlblSubCaption.Size = new Size(0, 16);
		mlblSubCaption.TabIndex = 4;
		mlnkBuyProVersion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		mlnkBuyProVersion.AutoSize = true;
		mlnkBuyProVersion.LinkBehavior = LinkBehavior.NeverUnderline;
		mlnkBuyProVersion.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkBuyProVersion.Location = new Point(12, 199);
		mlnkBuyProVersion.Name = "m_lnkBuyProVersion";
		mlnkBuyProVersion.RightToLeft = RightToLeft.No;
		mlnkBuyProVersion.Size = new Size(217, 16);
		mlnkBuyProVersion.TabIndex = 12;
		mlnkBuyProVersion.TabStop = true;
		mlnkBuyProVersion.Text = "Click here to obtain the License Key";
		mlnkBuyProVersion.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		lblCaption.AutoSize = true;
		lblCaption.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		lblCaption.Location = new Point(79, 15);
		lblCaption.Margin = new Padding(4, 0, 4, 0);
		lblCaption.Name = "lblCaption";
		lblCaption.Size = new Size(0, 16);
		lblCaption.TabIndex = 14;
		mbtnActivate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mbtnActivate.Enabled = false;
		mbtnActivate.Image = Resources.opts_16;
		mbtnActivate.Location = new Point(462, 179);
		mbtnActivate.Margin = new Padding(4);
		mbtnActivate.Name = "m_btnActivate";
		mbtnActivate.Size = new Size(100, 36);
		mbtnActivate.TabIndex = 17;
		mbtnActivate.Text = "Activate";
		mbtnActivate.TextImageRelation = TextImageRelation.ImageBeforeText;
		mbtnActivate.UseVisualStyleBackColor = true;
		mbtnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mbtnCancel.Image = Resources.cancl_16;
		mbtnCancel.Location = new Point(570, 179);
		mbtnCancel.Margin = new Padding(4);
		mbtnCancel.Name = "m_btnCancel";
		mbtnCancel.Size = new Size(100, 36);
		mbtnCancel.TabIndex = 18;
		mbtnCancel.Text = "Cancel";
		mbtnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
		mbtnCancel.UseVisualStyleBackColor = true;
		medLicenseKey.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		medLicenseKey.Location = new Point(119, 149);
		medLicenseKey.Margin = new Padding(4);
		medLicenseKey.Name = "m_edLicenseKey";
		medLicenseKey.Size = new Size(552, 22);
		medLicenseKey.TabIndex = 0;
		mlblActivationKey.AutoSize = true;
		mlblActivationKey.Location = new Point(16, 152);
		mlblActivationKey.Margin = new Padding(4, 0, 4, 0);
		mlblActivationKey.Name = "m_lblActivationKey";
		mlblActivationKey.Size = new Size(83, 16);
		mlblActivationKey.TabIndex = 15;
		mlblActivationKey.Text = "License Key:";
		medInstallationId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		medInstallationId.Location = new Point(119, 102);
		medInstallationId.Margin = new Padding(4);
		medInstallationId.Name = "m_edInstallationId";
		medInstallationId.ReadOnly = true;
		medInstallationId.Size = new Size(555, 22);
		medInstallationId.TabIndex = 23;
		label2.AutoSize = true;
		label2.Location = new Point(16, 105);
		label2.Margin = new Padding(4, 0, 4, 0);
		label2.Name = "label2";
		label2.Size = new Size(85, 16);
		label2.TabIndex = 22;
		label2.Text = "Hardware ID:";
		separatorLine1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		separatorLine1.Location = new Point(16, 81);
		separatorLine1.Name = "separatorLine1";
		separatorLine1.Size = new Size(655, 2);
		separatorLine1.TabIndex = 36;
		separatorLine1.TabStop = false;
		statusStrip1.Location = new Point(0, 224);
		statusStrip1.Name = "statusStrip1";
		statusStrip1.Size = new Size(684, 22);
		statusStrip1.TabIndex = 42;
		statusStrip1.Text = "statusStrip1";
		toolStripStatusLabel1.Name = "toolStripStatusLabel1";
		toolStripStatusLabel1.Size = new Size(669, 17);
		toolStripStatusLabel1.Spring = true;
		toolStripStatusLabel1.TextAlign = ContentAlignment.MiddleLeft;
		imgWait.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		imgWait.Location = new Point(430, 184);
		imgWait.Name = "imgWait";
		imgWait.Size = new Size(25, 25);
		imgWait.TabIndex = 43;
		imgWait.TabStop = false;
		imgWait.Visible = false;
		mlblAlreadyActivated.AutoSize = true;
		mlblAlreadyActivated.ForeColor = Color.Green;
		mlblAlreadyActivated.Location = new Point(16, 175);
		mlblAlreadyActivated.Margin = new Padding(4, 0, 4, 0);
		mlblAlreadyActivated.Name = "m_lblAlreadyActivated";
		mlblAlreadyActivated.Size = new Size(258, 16);
		mlblAlreadyActivated.TabIndex = 44;
		mlblAlreadyActivated.Text = "License key already activated. Thank you.";
		mlblAlreadyActivated.Boolean_0 = true;
		mlblAlreadyActivated.Visible = false;
		mlnkDeactivate.AutoSize = true;
		mlnkDeactivate.LinkBehavior = LinkBehavior.NeverUnderline;
		mlnkDeactivate.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkDeactivate.Location = new Point(273, 175);
		mlnkDeactivate.Name = "m_lnkDeactivate";
		mlnkDeactivate.RightToLeft = RightToLeft.No;
		mlnkDeactivate.Size = new Size(353, 16);
		mlnkDeactivate.TabIndex = 45;
		mlnkDeactivate.TabStop = true;
		mlnkDeactivate.Text = "Click here to deactivate your License key on this computer.";
		mlnkDeactivate.Visible = false;
		mlnkDeactivate.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(684, 246);
		base.Controls.Add(mlnkDeactivate);
		base.Controls.Add(mlblAlreadyActivated);
		base.Controls.Add(imgWait);
		base.Controls.Add(statusStrip1);
		base.Controls.Add(separatorLine1);
		base.Controls.Add(medInstallationId);
		base.Controls.Add(label2);
		base.Controls.Add(mbtnActivate);
		base.Controls.Add(mbtnCancel);
		base.Controls.Add(medLicenseKey);
		base.Controls.Add(mlblActivationKey);
		base.Controls.Add(lblCaption);
		base.Controls.Add(mlnkBuyProVersion);
		base.Controls.Add(mlblSubCaption);
		base.Controls.Add(pictureBox1);
		Font = new Font("Microsoft Sans Serif", 9.75f);
		base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		base.Margin = new Padding(4);
		base.Name = "LicenseActivatationDialog";
		base.StartPosition = FormStartPosition.Manual;
		((ISupportInitialize)pictureBox1).EndInit();
		statusStrip1.ResumeLayout(performLayout: false);
		statusStrip1.PerformLayout();
		((ISupportInitialize)imgWait).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void mlnkBuyProVersion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		ShowOnlineHelp(Class148.Class150.smethod_0("activate_pro"));
	}

	private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		LicenseActivatationOfflineDialog form = new LicenseActivatationOfflineDialog();
		using (form)
		{
			if (DialogResult.OK == form.ShowDialog())
			{
				SaveSettings(form.class146_0);
			}
		}
	}

	private void mbtnActivate_Click(object sender, EventArgs e)
	{
		OnLoad(medLicenseKey.Text.Trim());
	}

	private void mbtnCancel_Click(object sender, EventArgs e)
	{
		CloseDialog(DialogResult.Cancel);
	}
}
