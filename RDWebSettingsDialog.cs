using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Properties;

internal sealed class RDWebSettingsDialog : Form0
{
	private AdvancedHttpSettingsDialog form2_0 = new AdvancedHttpSettingsDialog(Class148.Class151.String_13);

	private IContainer icontainer_0;

	private Class66 mbtnSave;

	private Class66 mbtnCancel;

	private GControl0 separatorLine1;

	private Class62 mlblCaption;

	private PictureBox mimgBigIcon;

	private Class62 mlblSubCaption;

	private GClass3 mlnkOnlineHelp;

	private Class61 mchbEnableRDWebEngine;

	private Class61 mchbAutodetectLogsLocation;

	private Class63 mlblEnableRDWebProtectionHint;

	private Class63 mlblAutomaticConfigLocationHint;

	private Class54 medLogFilesDirectory;

	private Class62 mlblLogFilesLocation;

	private Class63 mlblLogFilesLocationHint;

	private GClass3 mlnkAdvancedSettings;

	public Class123 Class123_0
	{
		get
		{
			Class123 @class = new Class123();
			@class.bool_0 = mchbEnableRDWebEngine.Checked;
			@class.bool_2 = mchbAutodetectLogsLocation.Checked;
			@class.String_1 = new string[1] { medLogFilesDirectory.Text };
			@class.bool_3 = form2_0.Boolean_0;
			@class.bool_4 = form2_0.Boolean_1;
			return @class;
		}
		set
		{
			mchbEnableRDWebEngine.Checked = value.bool_0;
			mchbAutodetectLogsLocation.Checked = value.bool_2;
			medLogFilesDirectory.Text = value.String_1[0];
			form2_0.Boolean_0 = value.bool_3;
			form2_0.Boolean_1 = value.bool_4;
			OnLoad();
		}
	}

	public RDWebSettingsDialog(Class123 class123_0)
		: base(new Size(550, 390))
	{
		ValidateInput();
		InitializeFormPosition();
		InitializeComponent();
		OnButtonOk();
		Class123_0 = class123_0;
	}

	private void InitializeComponent()
	{
		medLogFilesDirectory.bool_0 = true;
		medLogFilesDirectory.String_0 = "Click to specify IIS log files location for RDWeb enabled website";
		if (string.IsNullOrEmpty(medLogFilesDirectory.Text))
		{
			string text = "C:\\inetpub\\logs\\LogFiles";
			if (Directory.Exists(text))
			{
				medLogFilesDirectory.String_1 = text;
			}
		}
		else
		{
			medLogFilesDirectory.String_1 = medLogFilesDirectory.Text;
		}
	}

	private void OnButtonOk()
	{
		mlnkOnlineHelp.Click += mlnkOnlineHelp_Click;
		mchbEnableRDWebEngine.CheckedChanged += mchbEnableRDWebEngine_CheckedChanged;
		mchbAutodetectLogsLocation.CheckedChanged += mchbAutodetectLogsLocation_CheckedChanged;
		medLogFilesDirectory.TextChanged += medLogFilesDirectory_TextChanged;
		mbtnSave.Click += mbtnSave_Click;
		mbtnCancel.Click += mbtnCancel_Click;
		mlnkAdvancedSettings.Click += mlnkAdvancedSettings_Click;
	}

	private void OnButtonCancel()
	{
		bool flag = true;
		if (mchbEnableRDWebEngine.Checked && !mchbAutodetectLogsLocation.Checked)
		{
			flag &= !string.IsNullOrEmpty(medLogFilesDirectory.Text);
		}
		mbtnSave.Enabled = flag;
	}

	private void OnLoad()
	{
		bool flag = mchbEnableRDWebEngine.Checked;
		mchbAutodetectLogsLocation.Enabled = flag;
		mlblAutomaticConfigLocationHint.Enabled = flag;
		bool flag2 = mchbAutodetectLogsLocation.Checked;
		mlblLogFilesLocation.Enabled = flag && !flag2;
		medLogFilesDirectory.Enabled = flag && !flag2;
		mlblLogFilesLocationHint.Enabled = flag && !flag2;
		mlnkAdvancedSettings.Enabled = flag;
		OnButtonCancel();
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
		mbtnSave = new Class66();
		mbtnCancel = new Class66();
		separatorLine1 = new GControl0();
		mlblCaption = new Class62();
		mimgBigIcon = new PictureBox();
		mlblSubCaption = new Class62();
		mlnkOnlineHelp = new GClass3();
		mchbEnableRDWebEngine = new Class61();
		mchbAutodetectLogsLocation = new Class61();
		mlblEnableRDWebProtectionHint = new Class63();
		mlblAutomaticConfigLocationHint = new Class63();
		medLogFilesDirectory = new Class54();
		mlblLogFilesLocation = new Class62();
		mlblLogFilesLocationHint = new Class63();
		mlnkAdvancedSettings = new GClass3();
		((ISupportInitialize)mimgBigIcon).BeginInit();
		SuspendLayout();
		mbtnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mbtnSave.Image = Resources.opts_16;
		mbtnSave.Location = new Point(313, 302);
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
		mbtnCancel.Location = new Point(421, 302);
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
		separatorLine1.Size = new Size(506, 2);
		separatorLine1.TabIndex = 50;
		separatorLine1.TabStop = false;
		mlblCaption.AutoSize = true;
		mlblCaption.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		mlblCaption.Location = new Point(79, 15);
		mlblCaption.Margin = new Padding(4, 0, 4, 0);
		mlblCaption.Name = "m_lblCaption";
		mlblCaption.Size = new Size(121, 16);
		mlblCaption.TabIndex = 49;
		mlblCaption.Text = "RD Web Settings";
		mimgBigIcon.Image = Resources.rdweb_48;
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
		mlblSubCaption.Size = new Size(230, 16);
		mlblSubCaption.TabIndex = 48;
		mlblSubCaption.Text = "Advanced RD Web protection settings";
		mlnkOnlineHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		mlnkOnlineHelp.AutoSize = true;
		mlnkOnlineHelp.LinkBehavior = LinkBehavior.NeverUnderline;
		mlnkOnlineHelp.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkOnlineHelp.Location = new Point(449, 9);
		mlnkOnlineHelp.Name = "m_lnkOnlineHelp";
		mlnkOnlineHelp.Size = new Size(72, 16);
		mlnkOnlineHelp.TabIndex = 9;
		mlnkOnlineHelp.TabStop = true;
		mlnkOnlineHelp.Text = "online help";
		mlnkOnlineHelp.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		mchbEnableRDWebEngine.AutoSize = true;
		mchbEnableRDWebEngine.Location = new Point(16, 97);
		mchbEnableRDWebEngine.Name = "m_chbEnableRDWebEngine";
		mchbEnableRDWebEngine.Size = new Size(183, 20);
		mchbEnableRDWebEngine.TabIndex = 0;
		mchbEnableRDWebEngine.Text = "Enable RD Web protection";
		mchbEnableRDWebEngine.UseVisualStyleBackColor = true;
		mchbAutodetectLogsLocation.AutoSize = true;
		mchbAutodetectLogsLocation.Location = new Point(16, 157);
		mchbAutodetectLogsLocation.Name = "m_chbAutodetectLogsLocation";
		mchbAutodetectLogsLocation.Size = new Size(245, 20);
		mchbAutodetectLogsLocation.TabIndex = 1;
		mchbAutodetectLogsLocation.Text = "Automatically detect log files location";
		mchbAutodetectLogsLocation.UseVisualStyleBackColor = true;
		mlblEnableRDWebProtectionHint.AutoSize = true;
		mlblEnableRDWebProtectionHint.ForeColor = SystemColors.ControlDarkDark;
		mlblEnableRDWebProtectionHint.Location = new Point(13, 122);
		mlblEnableRDWebProtectionHint.Name = "m_lblEnableRDWebProtectionHint";
		mlblEnableRDWebProtectionHint.Size = new Size(225, 16);
		mlblEnableRDWebProtectionHint.TabIndex = 58;
		mlblEnableRDWebProtectionHint.Text = "Turn on to enable RD Web protection";
		mlblAutomaticConfigLocationHint.AutoSize = true;
		mlblAutomaticConfigLocationHint.ForeColor = SystemColors.ControlDarkDark;
		mlblAutomaticConfigLocationHint.Location = new Point(13, 182);
		mlblAutomaticConfigLocationHint.Name = "m_lblAutomaticConfigLocationHint";
		mlblAutomaticConfigLocationHint.Size = new Size(481, 16);
		mlblAutomaticConfigLocationHint.TabIndex = 59;
		mlblAutomaticConfigLocationHint.Text = "RdpGuard will attempt to detect IIS log files location for RD Web enabled website";
		medLogFilesDirectory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		medLogFilesDirectory.Enabled = false;
		medLogFilesDirectory.String_1 = null;
		medLogFilesDirectory.Location = new Point(23, 243);
		medLogFilesDirectory.Name = "m_edLogFilesDirectory";
		medLogFilesDirectory.Size = new Size(498, 22);
		medLogFilesDirectory.TabIndex = 2;
		mlblLogFilesLocation.AutoSize = true;
		mlblLogFilesLocation.Enabled = false;
		mlblLogFilesLocation.Location = new Point(13, 217);
		mlblLogFilesLocation.Name = "m_lblLogFilesLocation";
		mlblLogFilesLocation.Size = new Size(124, 16);
		mlblLogFilesLocation.TabIndex = 61;
		mlblLogFilesLocation.Text = "IIS log files location:";
		mlblLogFilesLocationHint.AutoSize = true;
		mlblLogFilesLocationHint.Enabled = false;
		mlblLogFilesLocationHint.ForeColor = SystemColors.ControlDarkDark;
		mlblLogFilesLocationHint.Location = new Point(20, 268);
		mlblLogFilesLocationHint.Name = "m_lblLogFilesLocationHint";
		mlblLogFilesLocationHint.Size = new Size(341, 16);
		mlblLogFilesLocationHint.TabIndex = 62;
		mlblLogFilesLocationHint.Text = "Specify IIS log files location for RD Web enabled website";
		mlnkAdvancedSettings.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		mlnkAdvancedSettings.AutoSize = true;
		mlnkAdvancedSettings.LinkBehavior = LinkBehavior.NeverUnderline;
		mlnkAdvancedSettings.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkAdvancedSettings.Location = new Point(13, 322);
		mlnkAdvancedSettings.Name = "m_lnkAdvancedSettings";
		mlnkAdvancedSettings.Size = new Size(123, 16);
		mlnkAdvancedSettings.TabIndex = 70;
		mlnkAdvancedSettings.TabStop = true;
		mlnkAdvancedSettings.Text = "advanced settings..";
		mlnkAdvancedSettings.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(534, 351);
		base.Controls.Add(mlnkAdvancedSettings);
		base.Controls.Add(mlblLogFilesLocationHint);
		base.Controls.Add(mlblLogFilesLocation);
		base.Controls.Add(medLogFilesDirectory);
		base.Controls.Add(mlblAutomaticConfigLocationHint);
		base.Controls.Add(mlblEnableRDWebProtectionHint);
		base.Controls.Add(mchbAutodetectLogsLocation);
		base.Controls.Add(mchbEnableRDWebEngine);
		base.Controls.Add(mlnkOnlineHelp);
		base.Controls.Add(separatorLine1);
		base.Controls.Add(mlblCaption);
		base.Controls.Add(mlblSubCaption);
		base.Controls.Add(mimgBigIcon);
		base.Controls.Add(mbtnSave);
		base.Controls.Add(mbtnCancel);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(5, 4, 5, 4);
		base.Name = "RDWebSettingsDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "RD Web Protection Settings";
		((ISupportInitialize)mimgBigIcon).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void mlnkOnlineHelp_Click(object sender, EventArgs e)
	{
		ShowOnlineHelp(Class148.Class151.String_12);
	}

	private void mchbEnableRDWebEngine_CheckedChanged(object sender, EventArgs e)
	{
		OnLoad();
	}

	private void mchbAutodetectLogsLocation_CheckedChanged(object sender, EventArgs e)
	{
		OnLoad();
		OnButtonCancel();
	}

	private void medLogFilesDirectory_TextChanged(object sender, EventArgs e)
	{
		OnButtonCancel();
	}

	private void mbtnSave_Click(object sender, EventArgs e)
	{
		CloseDialog(DialogResult.OK);
	}

	private void mbtnCancel_Click(object sender, EventArgs e)
	{
		CloseDialog(DialogResult.Cancel);
	}

	private void mlnkAdvancedSettings_Click(object sender, EventArgs e)
	{
		form2_0.ShowDialog();
	}
}
