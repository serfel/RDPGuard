using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class AdvancedHttpSettingsDialog : Form0
{
	private readonly string string_0 = string.Empty;

	private IContainer icontainer_0;

	private Class66 mbtnSave;

	private Class66 mbtnCancel;

	private GControl0 separatorLine1;

	private Class62 mlblCaption;

	private PictureBox mimgBigIcon;

	private Class62 mlblSubCaption;

	private GClass3 mlnkOnlineHelp;

	private Class61 mchbUseXForwardedFor;

	private Class63 mchbUseXForwardedForHint;

	private GClass3 mlnkIISConfiguration;

	private Class61 mchbXffFallbackToRemoteAddr;

	private Class63 mlblXffFallbackHint;

	public bool Boolean_0
	{
		get
		{
			return mchbUseXForwardedFor.Checked;
		}
		set
		{
			mchbUseXForwardedFor.Checked = value;
		}
	}

	public bool Boolean_1
	{
		get
		{
			return mchbXffFallbackToRemoteAddr.Checked;
		}
		set
		{
			mchbXffFallbackToRemoteAddr.Checked = value;
		}
	}

	public AdvancedHttpSettingsDialog(string string_1)
		: base(new Size(470, 330))
	{
		string_0 = string_1;
		OnLoad();
		InitializeFormPosition();
		InitializeComponent();
		OnButtonOk();
	}

	private void InitializeComponent()
	{
		OnButtonCancel();
	}

	private void OnButtonOk()
	{
		mlnkOnlineHelp.Click += mlnkOnlineHelp_Click;
		mchbUseXForwardedFor.CheckedChanged += mchbUseXForwardedFor_CheckedChanged;
		mlnkIISConfiguration.Click += mlnkIISConfiguration_Click;
		mbtnSave.Click += mbtnSave_Click;
		mbtnCancel.Click += mbtnCancel_Click;
	}

	private void OnButtonCancel()
	{
		bool enabled = mchbUseXForwardedFor.Checked;
		mchbXffFallbackToRemoteAddr.Enabled = enabled;
		mlblXffFallbackHint.Enabled = enabled;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void OnLoad()
	{
		icontainer_0 = new Container();
		mbtnSave = new Class66();
		mbtnCancel = new Class66();
		separatorLine1 = new GControl0();
		mlblCaption = new Class62();
		mimgBigIcon = new PictureBox();
		mlblSubCaption = new Class62();
		mlnkOnlineHelp = new GClass3();
		mchbUseXForwardedFor = new Class61();
		mchbUseXForwardedForHint = new Class63();
		mlnkIISConfiguration = new GClass3();
		mchbXffFallbackToRemoteAddr = new Class61();
		mlblXffFallbackHint = new Class63();
		((ISupportInitialize)mimgBigIcon).BeginInit();
		SuspendLayout();
		mbtnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mbtnSave.Image = Resources.opts_16;
		mbtnSave.Location = new Point(213, 206);
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
		mbtnCancel.Location = new Point(321, 206);
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
		separatorLine1.Size = new Size(406, 2);
		separatorLine1.TabIndex = 50;
		separatorLine1.TabStop = false;
		mlblCaption.AutoSize = true;
		mlblCaption.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		mlblCaption.Location = new Point(79, 15);
		mlblCaption.Margin = new Padding(4, 0, 4, 0);
		mlblCaption.Name = "m_lblCaption";
		mlblCaption.Size = new Size(108, 16);
		mlblCaption.TabIndex = 49;
		mlblCaption.Text = "HTTP Settings";
		mimgBigIcon.Image = Resources.http_48;
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
		mlblSubCaption.Size = new Size(220, 16);
		mlblSubCaption.TabIndex = 48;
		mlblSubCaption.Text = "Advanced HTTP protection settings";
		mlnkOnlineHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		mlnkOnlineHelp.AutoSize = true;
		mlnkOnlineHelp.LinkBehavior = LinkBehavior.NeverUnderline;
		mlnkOnlineHelp.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkOnlineHelp.Location = new Point(349, 9);
		mlnkOnlineHelp.Name = "m_lnkOnlineHelp";
		mlnkOnlineHelp.Size = new Size(72, 16);
		mlnkOnlineHelp.TabIndex = 9;
		mlnkOnlineHelp.TabStop = true;
		mlnkOnlineHelp.Text = "online help";
		mlnkOnlineHelp.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		mchbUseXForwardedFor.AutoSize = true;
		mchbUseXForwardedFor.Location = new Point(16, 97);
		mchbUseXForwardedFor.Name = "m_chbUseXForwardedFor";
		mchbUseXForwardedFor.Size = new Size(351, 20);
		mchbUseXForwardedFor.TabIndex = 65;
		mchbUseXForwardedFor.Text = "Use the X-Forwarded-For field to read client IP address";
		mchbUseXForwardedFor.UseVisualStyleBackColor = true;
		mchbUseXForwardedForHint.AutoSize = true;
		mchbUseXForwardedForHint.ForeColor = Color.Red;
		mchbUseXForwardedForHint.Location = new Point(13, 122);
		mchbUseXForwardedForHint.Name = "m_chbUseXForwardedForHint";
		mchbUseXForwardedForHint.Size = new Size(391, 16);
		mchbUseXForwardedForHint.TabIndex = 67;
		mchbUseXForwardedForHint.Text = "Do not enable unless you are hosting the website behind a proxy.";
		mchbUseXForwardedForHint.Boolean_0 = true;
		mlnkIISConfiguration.AutoSize = true;
		mlnkIISConfiguration.LinkBehavior = LinkBehavior.NeverUnderline;
		mlnkIISConfiguration.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkIISConfiguration.Location = new Point(13, 145);
		mlnkIISConfiguration.Name = "m_lnkIISConfiguration";
		mlnkIISConfiguration.Size = new Size(405, 16);
		mlnkIISConfiguration.TabIndex = 68;
		mlnkIISConfiguration.TabStop = true;
		mlnkIISConfiguration.Text = "Additional configuration required for the proxy and the HTTP server.";
		mlnkIISConfiguration.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		mchbXffFallbackToRemoteAddr = new Class61();
		mchbXffFallbackToRemoteAddr.AutoSize = true;
		mchbXffFallbackToRemoteAddr.Location = new Point(16, 180);
		mchbXffFallbackToRemoteAddr.Name = "m_chbXffFallbackToRemoteAddr";
		mchbXffFallbackToRemoteAddr.Size = new Size(382, 20);
		mchbXffFallbackToRemoteAddr.TabIndex = 69;
		mchbXffFallbackToRemoteAddr.Text = "Fall back to the client IP address if the header is missing";
		mchbXffFallbackToRemoteAddr.UseVisualStyleBackColor = true;
		mlblXffFallbackHint = new Class63();
		mlblXffFallbackHint.AutoSize = true;
		mlblXffFallbackHint.ForeColor = SystemColors.ControlDarkDark;
		mlblXffFallbackHint.Location = new Point(13, 205);
		mlblXffFallbackHint.Name = "m_lblXffFallbackHint";
		mlblXffFallbackHint.Size = new Size(382, 16);
		mlblXffFallbackHint.TabIndex = 70;
		mlblXffFallbackHint.Text = "Allows using the client IP when the X-Forwarded-For header is not set.";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(434, 255);
		base.Controls.Add(mlnkIISConfiguration);
		base.Controls.Add(mchbUseXForwardedForHint);
		base.Controls.Add(mchbUseXForwardedFor);
		base.Controls.Add(mchbXffFallbackToRemoteAddr);
		base.Controls.Add(mlblXffFallbackHint);
		base.Controls.Add(mlnkOnlineHelp);
		base.Controls.Add(separatorLine1);
		base.Controls.Add(mlblCaption);
		base.Controls.Add(mlblSubCaption);
		base.Controls.Add(mimgBigIcon);
		base.Controls.Add(mbtnSave);
		base.Controls.Add(mbtnCancel);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(5, 4, 5, 4);
		base.Name = "AdvancedHttpSettingsDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "Advanced HTTP Settings";
		((ISupportInitialize)mimgBigIcon).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void mlnkOnlineHelp_Click(object sender, EventArgs e)
	{
		ShowOnlineHelp(string_0);
	}

	private void mchbUseXForwardedFor_CheckedChanged(object sender, EventArgs e)
	{
		OnButtonCancel();
	}

	private void mlnkIISConfiguration_Click(object sender, EventArgs e)
	{
		ShowOnlineHelp(Class148.String_7);
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
