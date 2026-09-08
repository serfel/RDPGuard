using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class AdvancedSmtpSettingsDialog : Form0
{
	private IContainer icontainer_0;

	private Class66 mbtnSave;

	private Class66 mbtnCancel;

	private GControl0 separatorLine1;

	private Class62 mlblCaption;

	private PictureBox mimgBigIcon;

	private Class62 mlblSubCaption;

	private GClass3 mlnkOnlineHelp;

	private Class61 mchbBlockUsernameEnumerationAttempts;

	private Class61 mchbBlockRelayAttempts;

	private Class61 mchbBlockSpamAttacks;

	private Class61 mchbBlockFailedWebAdminLogins;

	private Class61 mchbBlockFailedWebMailLogins;

	private Class61 mchbBlockDnsBlacklistedAddresses;

	private Class61 mchbBlockNoReverseDnsAddresses;

	public Class131 Class131_0
	{
		get
		{
			return new Class131
			{
				bool_0 = mchbBlockFailedWebAdminLogins.Checked,
				bool_1 = mchbBlockFailedWebMailLogins.Checked,
				bool_2 = mchbBlockUsernameEnumerationAttempts.Checked,
				bool_3 = mchbBlockRelayAttempts.Checked,
				bool_4 = mchbBlockSpamAttacks.Checked,
				bool_5 = mchbBlockDnsBlacklistedAddresses.Checked,
				bool_6 = mchbBlockNoReverseDnsAddresses.Checked
			};
		}
		set
		{
			mchbBlockFailedWebAdminLogins.Checked = value.bool_0;
			mchbBlockFailedWebMailLogins.Checked = value.bool_1;
			mchbBlockUsernameEnumerationAttempts.Checked = value.bool_2;
			mchbBlockRelayAttempts.Checked = value.bool_3;
			mchbBlockSpamAttacks.Checked = value.bool_4;
			mchbBlockDnsBlacklistedAddresses.Checked = value.bool_5;
			mchbBlockNoReverseDnsAddresses.Checked = value.bool_6;
		}
	}

	public AdvancedSmtpSettingsDialog(Class131 class131_0)
		: base(new Size(640, 480))
	{
		OnButtonCancel();
		InitializeFormPosition();
		InitializeComponent();
		OnButtonOk();
		Class131_0 = class131_0;
	}

	private void InitializeComponent()
	{
	}

	private void OnButtonOk()
	{
		mlnkOnlineHelp.Click += mlnkOnlineHelp_Click;
		mbtnSave.Click += mbtnSave_Click;
		mbtnCancel.Click += mbtnCancel_Click;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void OnButtonCancel()
	{
		mbtnSave = new Class66();
		mbtnCancel = new Class66();
		separatorLine1 = new GControl0();
		mlblCaption = new Class62();
		mimgBigIcon = new PictureBox();
		mlblSubCaption = new Class62();
		mlnkOnlineHelp = new GClass3();
		mchbBlockUsernameEnumerationAttempts = new Class61();
		mchbBlockRelayAttempts = new Class61();
		mchbBlockSpamAttacks = new Class61();
		mchbBlockFailedWebAdminLogins = new Class61();
		mchbBlockFailedWebMailLogins = new Class61();
		mchbBlockDnsBlacklistedAddresses = new Class61();
		mchbBlockNoReverseDnsAddresses = new Class61();
		((ISupportInitialize)mimgBigIcon).BeginInit();
		SuspendLayout();
		mbtnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mbtnSave.Image = Resources.opts_16;
		mbtnSave.Location = new Point(403, 392);
		mbtnSave.Margin = new Padding(4);
		mbtnSave.Name = "m_btnSave";
		mbtnSave.Size = new Size(100, 36);
		mbtnSave.TabIndex = 7;
		mbtnSave.Text = "Save";
		mbtnSave.TextAlign = ContentAlignment.MiddleRight;
		mbtnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
		mbtnSave.UseVisualStyleBackColor = true;
		mbtnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mbtnCancel.Image = Resources.cancl_16;
		mbtnCancel.Location = new Point(511, 392);
		mbtnCancel.Margin = new Padding(4);
		mbtnCancel.Name = "m_btnCancel";
		mbtnCancel.Size = new Size(100, 36);
		mbtnCancel.TabIndex = 8;
		mbtnCancel.Text = "Cancel";
		mbtnCancel.TextAlign = ContentAlignment.MiddleRight;
		mbtnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
		mbtnCancel.UseVisualStyleBackColor = true;
		separatorLine1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		separatorLine1.Location = new Point(16, 81);
		separatorLine1.Name = "separatorLine1";
		separatorLine1.Size = new Size(596, 2);
		separatorLine1.TabIndex = 50;
		separatorLine1.TabStop = false;
		mlblCaption.AutoSize = true;
		mlblCaption.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		mlblCaption.Location = new Point(79, 15);
		mlblCaption.Margin = new Padding(4, 0, 4, 0);
		mlblCaption.Name = "m_lblCaption";
		mlblCaption.Size = new Size(110, 16);
		mlblCaption.TabIndex = 49;
		mlblCaption.Text = "SMTP Settings";
		mimgBigIcon.Image = Resources.smtp_48;
		mimgBigIcon.Location = new Point(16, 15);
		mimgBigIcon.Margin = new Padding(4);
		mimgBigIcon.Name = "m_imgBigIcon";
		mimgBigIcon.Size = new Size(48, 48);
		mimgBigIcon.SizeMode = PictureBoxSizeMode.AutoSize;
		mimgBigIcon.TabIndex = 47;
		mimgBigIcon.TabStop = false;
		mlblSubCaption.AutoSize = true;
		mlblSubCaption.Location = new Point(79, 47);
		mlblSubCaption.Margin = new Padding(4, 0, 4, 0);
		mlblSubCaption.Name = "m_lblSubCaption";
		mlblSubCaption.Size = new Size(222, 16);
		mlblSubCaption.TabIndex = 48;
		mlblSubCaption.Text = "Advanced SMTP protection settings";
		mlnkOnlineHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		mlnkOnlineHelp.AutoSize = true;
		mlnkOnlineHelp.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkOnlineHelp.Location = new Point(539, 9);
		mlnkOnlineHelp.Name = "m_lnkOnlineHelp";
		mlnkOnlineHelp.Size = new Size(73, 16);
		mlnkOnlineHelp.TabIndex = 9;
		mlnkOnlineHelp.TabStop = true;
		mlnkOnlineHelp.Text = "online help";
		mlnkOnlineHelp.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		mchbBlockUsernameEnumerationAttempts.AutoSize = true;
		mchbBlockUsernameEnumerationAttempts.Location = new Point(16, 182);
		mchbBlockUsernameEnumerationAttempts.Name = "m_chbBlockUsernameEnumerationAttempts";
		mchbBlockUsernameEnumerationAttempts.Size = new Size(258, 20);
		mchbBlockUsernameEnumerationAttempts.TabIndex = 51;
		mchbBlockUsernameEnumerationAttempts.Text = "Block  username enumeration attempts";
		mchbBlockUsernameEnumerationAttempts.UseVisualStyleBackColor = true;
		mchbBlockRelayAttempts.AutoSize = true;
		mchbBlockRelayAttempts.Location = new Point(16, 222);
		mchbBlockRelayAttempts.Name = "m_chbBlockRelayAttempts";
		mchbBlockRelayAttempts.Size = new Size(148, 20);
		mchbBlockRelayAttempts.TabIndex = 52;
		mchbBlockRelayAttempts.Text = "Block relay attempts";
		mchbBlockRelayAttempts.UseVisualStyleBackColor = true;
		mchbBlockSpamAttacks.AutoSize = true;
		mchbBlockSpamAttacks.Location = new Point(16, 262);
		mchbBlockSpamAttacks.Name = "m_chbBlockSpamAttacks";
		mchbBlockSpamAttacks.Size = new Size(144, 20);
		mchbBlockSpamAttacks.TabIndex = 53;
		mchbBlockSpamAttacks.Text = "Block spam attacks";
		mchbBlockSpamAttacks.UseVisualStyleBackColor = true;
		mchbBlockFailedWebAdminLogins.AutoSize = true;
		mchbBlockFailedWebAdminLogins.Location = new Point(16, 102);
		mchbBlockFailedWebAdminLogins.Name = "m_chbBlockFailedWebAdminLogins";
		mchbBlockFailedWebAdminLogins.Size = new Size(204, 20);
		mchbBlockFailedWebAdminLogins.TabIndex = 54;
		mchbBlockFailedWebAdminLogins.Text = "Block failed web admin logins";
		mchbBlockFailedWebAdminLogins.UseVisualStyleBackColor = true;
		mchbBlockFailedWebMailLogins.AutoSize = true;
		mchbBlockFailedWebMailLogins.Location = new Point(16, 142);
		mchbBlockFailedWebMailLogins.Name = "m_chbBlockFailedWebMailLogins";
		mchbBlockFailedWebMailLogins.Size = new Size(192, 20);
		mchbBlockFailedWebMailLogins.TabIndex = 55;
		mchbBlockFailedWebMailLogins.Text = "Block failed web mail logins";
		mchbBlockFailedWebMailLogins.UseVisualStyleBackColor = true;
		mchbBlockDnsBlacklistedAddresses.AutoSize = true;
		mchbBlockDnsBlacklistedAddresses.Location = new Point(16, 302);
		mchbBlockDnsBlacklistedAddresses.Name = "m_chbBlockDnsBlacklistedAddresses";
		mchbBlockDnsBlacklistedAddresses.Size = new Size(244, 20);
		mchbBlockDnsBlacklistedAddresses.TabIndex = 56;
		mchbBlockDnsBlacklistedAddresses.Text = "Block DNS blacklisted IP addresses";
		mchbBlockDnsBlacklistedAddresses.UseVisualStyleBackColor = true;
		mchbBlockNoReverseDnsAddresses.AutoSize = true;
		mchbBlockNoReverseDnsAddresses.Location = new Point(16, 342);
		mchbBlockNoReverseDnsAddresses.Name = "m_chbBlockNoReverseDnsAddresses";
		mchbBlockNoReverseDnsAddresses.Size = new Size(268, 20);
		mchbBlockNoReverseDnsAddresses.TabIndex = 57;
		mchbBlockNoReverseDnsAddresses.Text = "Block IP addresses with no reverse DNS";
		mchbBlockNoReverseDnsAddresses.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(624, 441);
		base.Controls.Add(mchbBlockNoReverseDnsAddresses);
		base.Controls.Add(mchbBlockDnsBlacklistedAddresses);
		base.Controls.Add(mchbBlockFailedWebMailLogins);
		base.Controls.Add(mchbBlockFailedWebAdminLogins);
		base.Controls.Add(mchbBlockSpamAttacks);
		base.Controls.Add(mchbBlockRelayAttempts);
		base.Controls.Add(mchbBlockUsernameEnumerationAttempts);
		base.Controls.Add(mlnkOnlineHelp);
		base.Controls.Add(separatorLine1);
		base.Controls.Add(mlblCaption);
		base.Controls.Add(mlblSubCaption);
		base.Controls.Add(mimgBigIcon);
		base.Controls.Add(mbtnSave);
		base.Controls.Add(mbtnCancel);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(5, 4, 5, 4);
		base.Name = "AdvancedSmtpSettingsDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "Advanced SMTP Settings";
		((ISupportInitialize)mimgBigIcon).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void mlnkOnlineHelp_Click(object sender, EventArgs e)
	{
		ShowOnlineHelp(Class148.Class151.String_7);
	}

	private void mbtnSave_Click(object sender, EventArgs e)
	{
		CloseDialog(DialogResult.OK);
	}

	private void mbtnCancel_Click(object sender, EventArgs e)
	{
		CloseDialog(DialogResult.Cancel);
	}
}
