using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class SmtpServerAddEditDialog : Form0
{
	private Class109 class109_0;

	private IContainer icontainer_0;

	private PictureBox mimgBigIcon;

	private Class62 mlblSubCaption;

	private Class62 mlblCaption;

	private Class66 mbtnCancel;

	private Class66 mbtnOK;

	private GControl0 separatorLine1;

	private GClass3 mlnkOnlineHelp;

	private Class65 mgrbTransport;

	private TextBox medHost;

	private Class62 mlblHost;

	private Class63 mlblHostHint;

	private Class62 mlblPort;

	private Class63 mlblPortHint;

	private NumericUpDown mnumPort;

	private Class65 mgrbAuthentication;

	private TextBox medPassword;

	private Class62 mlblPassword;

	private Class63 mlblPasswordHint;

	private TextBox medUsername;

	private Class62 mlblUsername;

	private Class63 mlblUsernameHint;

	private Class63 mlblSSLHint;

	private Class61 mchbSSL;

	public Class109 Class109_0
	{
		get
		{
			class109_0.string_1 = medHost.Text;
			class109_0.ushort_0 = (ushort)mnumPort.Value;
			class109_0.bool_0 = mchbSSL.Checked;
			class109_0.string_2 = medUsername.Text;
			class109_0.string_3 = medPassword.Text;
			return class109_0;
		}
		set
		{
			class109_0 = value;
			medHost.Text = class109_0.string_1;
			mnumPort.Value = class109_0.ushort_0;
			mchbSSL.Checked = class109_0.bool_0;
			medUsername.Text = class109_0.string_2;
			medPassword.Text = class109_0.string_3;
		}
	}

	protected override Button Button_0 => mbtnOK;

	public SmtpServerAddEditDialog(Class109 class109_1)
		: base(new Size(560, 580))
	{
		OnButtonOk();
		InitializeFormPosition();
		if (class109_1 == null)
		{
			Class109_0 = new Class109();
			Text = "Add New SMTP Server";
			mlblCaption.Text = "New SMTP Server";
			mlblSubCaption.Text = "Specify SMTP Server properties and click Add new server";
			mbtnOK.Text = "Add new server";
			mimgBigIcon.Image = Resources.mail_server_add_48;
			mlnkOnlineHelp.Click += mlnkOnlineHelp_Click;
		}
		else
		{
			Class109_0 = class109_1;
			Text = "Edit SMTP Server";
			mlblCaption.Text = "Edit SMTP Server";
			mlblSubCaption.Text = "Edit SMTP Server properties and click Save changes";
			mbtnOK.Text = "Save changes";
			mimgBigIcon.Image = Resources.mail_server_edit_48;
			mlnkOnlineHelp.Click += gclass3_0_Click_1;
		}
		InitializeComponent();
		OnFormClosing();
	}

	private void InitializeComponent()
	{
		base.Shown += Form26_Shown;
		mbtnOK.Click += mbtnOK_Click;
		mbtnCancel.Click += mbtnCancel_Click;
	}

	protected override void OnFormClosing()
	{
		Button_0.Enabled = !string.IsNullOrEmpty(medHost.Text);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void OnButtonOk()
	{
		mimgBigIcon = new PictureBox();
		mlblSubCaption = new Class62();
		mlblCaption = new Class62();
		mbtnCancel = new Class66();
		mbtnOK = new Class66();
		separatorLine1 = new GControl0();
		mlnkOnlineHelp = new GClass3();
		mgrbTransport = new Class65();
		mlblSSLHint = new Class63();
		mchbSSL = new Class61();
		mnumPort = new NumericUpDown();
		mlblPort = new Class62();
		mlblPortHint = new Class63();
		medHost = new TextBox();
		mlblHost = new Class62();
		mlblHostHint = new Class63();
		mgrbAuthentication = new Class65();
		medPassword = new TextBox();
		mlblPassword = new Class62();
		mlblPasswordHint = new Class63();
		medUsername = new TextBox();
		mlblUsername = new Class62();
		mlblUsernameHint = new Class63();
		((ISupportInitialize)mimgBigIcon).BeginInit();
		mgrbTransport.SuspendLayout();
		((ISupportInitialize)mnumPort).BeginInit();
		mgrbAuthentication.SuspendLayout();
		SuspendLayout();
		mimgBigIcon.Location = new Point(16, 15);
		mimgBigIcon.Margin = new Padding(4);
		mimgBigIcon.Name = "m_imgBigIcon";
		mimgBigIcon.Size = new Size(48, 48);
		mimgBigIcon.SizeMode = PictureBoxSizeMode.AutoSize;
		mimgBigIcon.TabIndex = 0;
		mimgBigIcon.TabStop = false;
		mlblSubCaption.AutoSize = true;
		mlblSubCaption.Location = new Point(79, 47);
		mlblSubCaption.Margin = new Padding(4, 0, 4, 0);
		mlblSubCaption.Name = "m_lblSubCaption";
		mlblSubCaption.Size = new Size(163, 16);
		mlblSubCaption.TabIndex = 4;
		mlblSubCaption.Text = "<description placeholder>";
		mlblCaption.AutoSize = true;
		mlblCaption.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		mlblCaption.Location = new Point(79, 15);
		mlblCaption.Margin = new Padding(4, 0, 4, 0);
		mlblCaption.Name = "m_lblCaption";
		mlblCaption.Size = new Size(187, 16);
		mlblCaption.TabIndex = 14;
		mlblCaption.Text = "<subcaption placeholder>";
		mbtnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mbtnCancel.Image = Resources.cancl_16;
		mbtnCancel.Location = new Point(431, 493);
		mbtnCancel.Margin = new Padding(4);
		mbtnCancel.Name = "m_btnCancel";
		mbtnCancel.Size = new Size(100, 36);
		mbtnCancel.TabIndex = 6;
		mbtnCancel.Text = "Cancel";
		mbtnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
		mbtnCancel.UseVisualStyleBackColor = true;
		mbtnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		mbtnOK.Enabled = false;
		mbtnOK.Image = Resources.opts_16;
		mbtnOK.Location = new Point(271, 493);
		mbtnOK.Margin = new Padding(4);
		mbtnOK.Name = "m_btnOK";
		mbtnOK.Size = new Size(152, 36);
		mbtnOK.TabIndex = 5;
		mbtnOK.Text = "<ok_button>";
		mbtnOK.TextImageRelation = TextImageRelation.ImageBeforeText;
		mbtnOK.UseVisualStyleBackColor = true;
		separatorLine1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		separatorLine1.Location = new Point(16, 73);
		separatorLine1.Name = "separatorLine1";
		separatorLine1.Size = new Size(513, 10);
		separatorLine1.TabIndex = 35;
		separatorLine1.TabStop = false;
		mlnkOnlineHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		mlnkOnlineHelp.AutoSize = true;
		mlnkOnlineHelp.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkOnlineHelp.Location = new Point(459, 9);
		mlnkOnlineHelp.Name = "m_lnkOnlineHelp";
		mlnkOnlineHelp.Size = new Size(73, 16);
		mlnkOnlineHelp.TabIndex = 7;
		mlnkOnlineHelp.TabStop = true;
		mlnkOnlineHelp.Text = "online help";
		mlnkOnlineHelp.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		mgrbTransport.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		mgrbTransport.Controls.Add(mlblSSLHint);
		mgrbTransport.Controls.Add(mchbSSL);
		mgrbTransport.Controls.Add(mnumPort);
		mgrbTransport.Controls.Add(mlblPort);
		mgrbTransport.Controls.Add(mlblPortHint);
		mgrbTransport.Controls.Add(medHost);
		mgrbTransport.Controls.Add(mlblHost);
		mgrbTransport.Controls.Add(mlblHostHint);
		mgrbTransport.Location = new Point(16, 89);
		mgrbTransport.Name = "m_grbTransport";
		mgrbTransport.Size = new Size(516, 224);
		mgrbTransport.TabIndex = 36;
		mgrbTransport.TabStop = false;
		mgrbTransport.Text = "Transport";
		mlblSSLHint.AutoSize = true;
		mlblSSLHint.ForeColor = SystemColors.ControlDarkDark;
		mlblSSLHint.Location = new Point(16, 188);
		mlblSSLHint.Name = "m_lblSSLHint";
		mlblSSLHint.Size = new Size(356, 16);
		mlblSSLHint.TabIndex = 69;
		mlblSSLHint.Text = " Turn on if your server supports secure SMTP connections. ";
		mchbSSL.AutoSize = true;
		mchbSSL.Location = new Point(19, 162);
		mchbSSL.Name = "m_chbSSL";
		mchbSSL.Size = new Size(127, 20);
		mchbSSL.TabIndex = 2;
		mchbSSL.Text = "Enable SSL/TLS";
		mchbSSL.UseVisualStyleBackColor = true;
		mnumPort.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		mnumPort.Location = new Point(140, 96);
		mnumPort.Maximum = new decimal(new int[4] { 65535, 0, 0, 0 });
		mnumPort.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		mnumPort.Name = "m_numPort";
		mnumPort.Size = new Size(372, 22);
		mnumPort.TabIndex = 1;
		mnumPort.Value = new decimal(new int[4] { 25, 0, 0, 0 });
		mlblPort.AutoSize = true;
		mlblPort.Location = new Point(16, 102);
		mlblPort.Name = "m_lblPort";
		mlblPort.Size = new Size(35, 16);
		mlblPort.TabIndex = 67;
		mlblPort.Text = "Port:";
		mlblPortHint.AutoSize = true;
		mlblPortHint.ForeColor = SystemColors.ControlDarkDark;
		mlblPortHint.Location = new Point(137, 124);
		mlblPortHint.Name = "m_lblPortHint";
		mlblPortHint.Size = new Size(348, 16);
		mlblPortHint.TabIndex = 66;
		mlblPortHint.Text = "Most common SMTP ports are 25 (plain) and 587 (secure)";
		medHost.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		medHost.Location = new Point(140, 26);
		medHost.Name = "m_edHost";
		medHost.Size = new Size(370, 22);
		medHost.TabIndex = 0;
		mlblHost.AutoSize = true;
		mlblHost.Location = new Point(16, 32);
		mlblHost.Name = "m_lblHost";
		mlblHost.Size = new Size(39, 16);
		mlblHost.TabIndex = 64;
		mlblHost.Text = "Host:";
		mlblHostHint.AutoSize = true;
		mlblHostHint.ForeColor = SystemColors.ControlDarkDark;
		mlblHostHint.Location = new Point(137, 54);
		mlblHostHint.Name = "m_lblHostHint";
		mlblHostHint.Size = new Size(289, 16);
		mlblHostHint.TabIndex = 63;
		mlblHostHint.Text = " Specify SMTP server to use for sending emails";
		mgrbAuthentication.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		mgrbAuthentication.Controls.Add(medPassword);
		mgrbAuthentication.Controls.Add(mlblPassword);
		mgrbAuthentication.Controls.Add(mlblPasswordHint);
		mgrbAuthentication.Controls.Add(medUsername);
		mgrbAuthentication.Controls.Add(mlblUsername);
		mgrbAuthentication.Controls.Add(mlblUsernameHint);
		mgrbAuthentication.Location = new Point(16, 319);
		mgrbAuthentication.Name = "m_grbAuthentication";
		mgrbAuthentication.Size = new Size(516, 160);
		mgrbAuthentication.TabIndex = 37;
		mgrbAuthentication.TabStop = false;
		mgrbAuthentication.Text = "Authentication";
		medPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		medPassword.Location = new Point(140, 95);
		medPassword.Name = "m_edPassword";
		medPassword.Size = new Size(370, 22);
		medPassword.TabIndex = 4;
		medPassword.UseSystemPasswordChar = true;
		mlblPassword.AutoSize = true;
		mlblPassword.Location = new Point(16, 101);
		mlblPassword.Name = "m_lblPassword";
		mlblPassword.Size = new Size(71, 16);
		mlblPassword.TabIndex = 67;
		mlblPassword.Text = "Password:";
		mlblPasswordHint.AutoSize = true;
		mlblPasswordHint.ForeColor = SystemColors.ControlDarkDark;
		mlblPasswordHint.Location = new Point(137, 123);
		mlblPasswordHint.Name = "m_lblPasswordHint";
		mlblPasswordHint.Size = new Size(265, 16);
		mlblPasswordHint.TabIndex = 66;
		mlblPasswordHint.Text = " Specify password for SMTP authentication ";
		medUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		medUsername.Location = new Point(140, 26);
		medUsername.Name = "m_edUsername";
		medUsername.Size = new Size(370, 22);
		medUsername.TabIndex = 3;
		mlblUsername.AutoSize = true;
		mlblUsername.Location = new Point(16, 32);
		mlblUsername.Name = "m_lblUsername";
		mlblUsername.Size = new Size(77, 16);
		mlblUsername.TabIndex = 64;
		mlblUsername.Text = "User name:";
		mlblUsernameHint.AutoSize = true;
		mlblUsernameHint.ForeColor = SystemColors.ControlDark;
		mlblUsernameHint.Location = new Point(137, 54);
		mlblUsernameHint.Name = "m_lblUsernameHint";
		mlblUsernameHint.Size = new Size(269, 16);
		mlblUsernameHint.TabIndex = 63;
		mlblUsernameHint.Text = " Specify user name for SMTP authentication ";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(544, 542);
		base.Controls.Add(mgrbAuthentication);
		base.Controls.Add(mgrbTransport);
		base.Controls.Add(mlnkOnlineHelp);
		base.Controls.Add(separatorLine1);
		base.Controls.Add(mbtnOK);
		base.Controls.Add(mbtnCancel);
		base.Controls.Add(mlblCaption);
		base.Controls.Add(mlblSubCaption);
		base.Controls.Add(mimgBigIcon);
		Font = new Font("Microsoft Sans Serif", 9.75f);
		base.Margin = new Padding(4);
		base.Name = "SmtpServerAddEditDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "<caption placeholder>";
		((ISupportInitialize)mimgBigIcon).EndInit();
		mgrbTransport.ResumeLayout(performLayout: false);
		mgrbTransport.PerformLayout();
		((ISupportInitialize)mnumPort).EndInit();
		mgrbAuthentication.ResumeLayout(performLayout: false);
		mgrbAuthentication.PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void mlnkOnlineHelp_Click(object sender, EventArgs e)
	{
		ShowOnlineHelp(Class148.Class154.String_1);
	}

	private void gclass3_0_Click_1(object sender, EventArgs e)
	{
		ShowOnlineHelp(Class148.Class154.String_2);
	}

	private void Form26_Shown(object sender, EventArgs e)
	{
		mgrbAuthentication.Focus();
		medHost.Focus();
	}

	private void mbtnOK_Click(object sender, EventArgs e)
	{
		CloseDialog(DialogResult.OK);
	}

	private void mbtnCancel_Click(object sender, EventArgs e)
	{
		CloseDialog(DialogResult.Cancel);
	}
}
