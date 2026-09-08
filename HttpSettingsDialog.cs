using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Properties;

internal sealed class HttpSettingsDialog : Form0
{
	private readonly AdvancedHttpSettingsDialog form2_0 = new AdvancedHttpSettingsDialog(Class148.Class151.String_4);

	private IContainer icontainer_0;

	private Class66 mbtnSave;

	private Class66 mbtnCancel;

	private GControl0 mspLine;

	private Class62 mlblCaption;

	private PictureBox mimgIcon;

	private Class62 mlblSubCaption;

	private GClass3 mlnkOnlineHelp;

	private Class61 mchbEnableProtection;

	private Class63 mlblEnableProtectionHint;

	private TextBox medRules;

	private Class63 mlblCustomRulesHint;

	private Class62 mlblLogDirectories;

	private DirectoriesTable mlstLogDirectories;

	private Class61 mchbOverrideStandardRules;

	private Class63 mchbOverrideStandardRulesHint;

	private Class63 mlblLogDirectoriesHint;

	private GClass3 mlnkAdvancedSettings;

	public Class115 Class115_0
	{
		get
		{
			return new Class115
			{
				bool_0 = mchbEnableProtection.Checked,
				String_1 = mlstLogDirectories.String_0,
				bool_3 = mchbOverrideStandardRules.Checked,
				string_11 = medRules.Text,
				bool_4 = form2_0.Boolean_0,
				bool_5 = form2_0.Boolean_1
			};
		}
		set
		{
			mchbEnableProtection.Checked = value.bool_0;
			mlstLogDirectories.String_0 = value.String_1;
			mchbOverrideStandardRules.Checked = value.bool_3;
			medRules.Text = value.String_2;
			form2_0.Boolean_0 = value.bool_4;
			form2_0.Boolean_1 = value.bool_5;
			OnLoad();
		}
	}

	public HttpSettingsDialog(Class115 class115_0)
		: base(new Size(505, 675))
	{
		ValidateInput();
		InitializeFormPosition();
		InitializeComponent();
		OnButtonOk();
		Class115_0 = class115_0;
	}

	private void InitializeComponent()
	{
	}

	private void OnButtonOk()
	{
		mlnkOnlineHelp.Click += mlnkOnlineHelp_Click;
		mchbEnableProtection.CheckedChanged += mchbEnableProtection_CheckedChanged;
		DirectoriesTable control = mlstLogDirectories;
		control.eventHandler_0 = (EventHandler)Delegate.Combine(control.eventHandler_0, new EventHandler(SaveSettings));
		mchbOverrideStandardRules.CheckedChanged += mchbOverrideStandardRules_CheckedChanged;
		medRules.TextChanged += medRules_TextChanged;
		mbtnSave.Click += mbtnSave_Click;
		mbtnCancel.Click += mbtnCancel_Click;
		mlnkAdvancedSettings.Click += mlnkAdvancedSettings_Click;
	}

	private void OnButtonCancel()
	{
		bool flag = !mchbEnableProtection.Checked || mlstLogDirectories.String_0.Any();
		if (mchbEnableProtection.Checked && mchbOverrideStandardRules.Checked)
		{
			flag &= !string.IsNullOrEmpty(medRules.Text);
		}
		mbtnSave.Enabled = flag;
	}

	private void OnLoad()
	{
		bool flag = mchbEnableProtection.Checked;
		mlblLogDirectories.Enabled = flag;
		mlstLogDirectories.Enabled = flag;
		mlblLogDirectoriesHint.Enabled = flag;
		mchbOverrideStandardRules.Enabled = flag;
		mchbOverrideStandardRulesHint.Enabled = flag;
		bool flag2 = mchbOverrideStandardRules.Checked;
		medRules.Enabled = flag && flag2;
		mlblCustomRulesHint.Enabled = flag && flag2;
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
		mspLine = new GControl0();
		mlblCaption = new Class62();
		mimgIcon = new PictureBox();
		mlblSubCaption = new Class62();
		mlnkOnlineHelp = new GClass3();
		mchbEnableProtection = new Class61();
		mlblEnableProtectionHint = new Class63();
		medRules = new TextBox();
		mlblCustomRulesHint = new Class63();
		mlblLogDirectories = new Class62();
		mlstLogDirectories = new DirectoriesTable();
		mchbOverrideStandardRules = new Class61();
		mchbOverrideStandardRulesHint = new Class63();
		mlblLogDirectoriesHint = new Class63();
		mlnkAdvancedSettings = new GClass3();
		((ISupportInitialize)mimgIcon).BeginInit();
		SuspendLayout();
		mbtnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mbtnSave.Image = Resources.opts_16;
		mbtnSave.Location = new Point(268, 587);
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
		mbtnCancel.Location = new Point(376, 587);
		mbtnCancel.Margin = new Padding(4);
		mbtnCancel.Name = "m_btnCancel";
		mbtnCancel.Size = new Size(100, 36);
		mbtnCancel.TabIndex = 8;
		mbtnCancel.Text = "Cancel";
		mbtnCancel.TextAlign = ContentAlignment.MiddleRight;
		mbtnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
		mbtnCancel.UseVisualStyleBackColor = true;
		mspLine.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		mspLine.Location = new Point(16, 81);
		mspLine.Name = "m_spLine";
		mspLine.Size = new Size(461, 2);
		mspLine.TabIndex = 50;
		mspLine.TabStop = false;
		mlblCaption.AutoSize = true;
		mlblCaption.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		mlblCaption.Location = new Point(79, 15);
		mlblCaption.Margin = new Padding(4, 0, 4, 0);
		mlblCaption.Name = "m_lblCaption";
		mlblCaption.Size = new Size(122, 16);
		mlblCaption.TabIndex = 49;
		mlblCaption.Text = "HTTP Protection";
		mimgIcon.Image = Resources.http_48;
		mimgIcon.Location = new Point(16, 15);
		mimgIcon.Margin = new Padding(4);
		mimgIcon.Name = "m_imgIcon";
		mimgIcon.Size = new Size(48, 48);
		mimgIcon.SizeMode = PictureBoxSizeMode.AutoSize;
		mimgIcon.TabIndex = 47;
		mimgIcon.TabStop = false;
		mlblSubCaption.AutoSize = true;
		mlblSubCaption.Location = new Point(79, 47);
		mlblSubCaption.Margin = new Padding(4, 0, 4, 0);
		mlblSubCaption.Name = "m_lblSubCaption";
		mlblSubCaption.Size = new Size(155, 16);
		mlblSubCaption.TabIndex = 48;
		mlblSubCaption.Text = "HTTP protection settings";
		mlnkOnlineHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		mlnkOnlineHelp.AutoSize = true;
		mlnkOnlineHelp.LinkBehavior = LinkBehavior.NeverUnderline;
		mlnkOnlineHelp.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkOnlineHelp.Location = new Point(404, 9);
		mlnkOnlineHelp.Name = "m_lnkOnlineHelp";
		mlnkOnlineHelp.Size = new Size(72, 16);
		mlnkOnlineHelp.TabIndex = 9;
		mlnkOnlineHelp.TabStop = true;
		mlnkOnlineHelp.Text = "online help";
		mlnkOnlineHelp.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		mchbEnableProtection.AutoSize = true;
		mchbEnableProtection.Location = new Point(16, 97);
		mchbEnableProtection.Name = "m_chbEnableProtection";
		mchbEnableProtection.Size = new Size(171, 20);
		mchbEnableProtection.TabIndex = 0;
		mchbEnableProtection.Text = "Enable HTTP protection";
		mchbEnableProtection.UseVisualStyleBackColor = true;
		mlblEnableProtectionHint.AutoSize = true;
		mlblEnableProtectionHint.ForeColor = SystemColors.ControlDarkDark;
		mlblEnableProtectionHint.Location = new Point(13, 122);
		mlblEnableProtectionHint.Name = "m_lblEnableProtectionHint";
		mlblEnableProtectionHint.Size = new Size(213, 16);
		mlblEnableProtectionHint.TabIndex = 58;
		mlblEnableProtectionHint.Text = "Turn on to enable HTTP protection";
		medRules.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		medRules.Enabled = false;
		medRules.Location = new Point(16, 387);
		medRules.Multiline = true;
		medRules.Name = "m_edRules";
		medRules.ScrollBars = ScrollBars.Both;
		medRules.Size = new Size(460, 159);
		medRules.TabIndex = 2;
		medRules.WordWrap = false;
		mlblCustomRulesHint.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		mlblCustomRulesHint.AutoSize = true;
		mlblCustomRulesHint.Enabled = false;
		mlblCustomRulesHint.ForeColor = SystemColors.ControlDarkDark;
		mlblCustomRulesHint.Location = new Point(20, 550);
		mlblCustomRulesHint.Name = "m_lblCustomRulesHint";
		mlblCustomRulesHint.Size = new Size(0, 16);
		mlblCustomRulesHint.TabIndex = 62;
		mlblLogDirectories.AutoSize = true;
		mlblLogDirectories.Enabled = false;
		mlblLogDirectories.Location = new Point(13, 153);
		mlblLogDirectories.Name = "m_lblLogDirectories";
		mlblLogDirectories.Size = new Size(113, 16);
		mlblLogDirectories.TabIndex = 63;
		mlblLogDirectories.Text = "IIS log directories:";
		mlstLogDirectories.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		mlstLogDirectories.String_0 = new string[0];
		mlstLogDirectories.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		mlstLogDirectories.Location = new Point(16, 175);
		mlstLogDirectories.Margin = new Padding(4);
		mlstLogDirectories.Name = "m_lstLogDirectories";
		mlstLogDirectories.Size = new Size(460, 147);
		mlstLogDirectories.TabIndex = 64;
		mchbOverrideStandardRules.AutoSize = true;
		mchbOverrideStandardRules.Location = new Point(16, 361);
		mchbOverrideStandardRules.Name = "m_chbOverrideStandardRules";
		mchbOverrideStandardRules.Size = new Size(224, 20);
		mchbOverrideStandardRules.TabIndex = 65;
		mchbOverrideStandardRules.Text = "Override standard detection rules";
		mchbOverrideStandardRules.UseVisualStyleBackColor = true;
		mchbOverrideStandardRulesHint.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		mchbOverrideStandardRulesHint.AutoSize = true;
		mchbOverrideStandardRulesHint.ForeColor = SystemColors.ControlDarkDark;
		mchbOverrideStandardRulesHint.Location = new Point(13, 554);
		mchbOverrideStandardRulesHint.Name = "m_chbOverrideStandardRulesHint";
		mchbOverrideStandardRulesHint.Size = new Size(472, 16);
		mchbOverrideStandardRulesHint.TabIndex = 67;
		mchbOverrideStandardRulesHint.Text = "Please check online help for rules syntax. Please do not edit if you are not sure.";
		mlblLogDirectoriesHint.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		mlblLogDirectoriesHint.AutoSize = true;
		mlblLogDirectoriesHint.ForeColor = SystemColors.ControlDarkDark;
		mlblLogDirectoriesHint.Location = new Point(12, 328);
		mlblLogDirectoriesHint.Name = "m_lblLogDirectoriesHint";
		mlblLogDirectoriesHint.Size = new Size(352, 16);
		mlblLogDirectoriesHint.TabIndex = 68;
		mlblLogDirectoriesHint.Text = "Select IIS log directories to monitor for dangerous patterns.";
		mlnkAdvancedSettings.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		mlnkAdvancedSettings.AutoSize = true;
		mlnkAdvancedSettings.LinkBehavior = LinkBehavior.NeverUnderline;
		mlnkAdvancedSettings.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkAdvancedSettings.Location = new Point(12, 607);
		mlnkAdvancedSettings.Name = "m_lnkAdvancedSettings";
		mlnkAdvancedSettings.Size = new Size(123, 16);
		mlnkAdvancedSettings.TabIndex = 69;
		mlnkAdvancedSettings.TabStop = true;
		mlnkAdvancedSettings.Text = "advanced settings..";
		mlnkAdvancedSettings.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(489, 636);
		base.Controls.Add(mlnkAdvancedSettings);
		base.Controls.Add(mlblLogDirectoriesHint);
		base.Controls.Add(mchbOverrideStandardRulesHint);
		base.Controls.Add(mchbOverrideStandardRules);
		base.Controls.Add(mlstLogDirectories);
		base.Controls.Add(mlblLogDirectories);
		base.Controls.Add(mlblCustomRulesHint);
		base.Controls.Add(medRules);
		base.Controls.Add(mlblEnableProtectionHint);
		base.Controls.Add(mchbEnableProtection);
		base.Controls.Add(mlnkOnlineHelp);
		base.Controls.Add(mspLine);
		base.Controls.Add(mlblCaption);
		base.Controls.Add(mlblSubCaption);
		base.Controls.Add(mimgIcon);
		base.Controls.Add(mbtnSave);
		base.Controls.Add(mbtnCancel);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(5, 4, 5, 4);
		base.Name = "HttpSettingsDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "HTTP Protection Settings";
		((ISupportInitialize)mimgIcon).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void mlnkOnlineHelp_Click(object sender, EventArgs e)
	{
		ShowOnlineHelp(Class148.Class151.String_3);
	}

	private void mchbEnableProtection_CheckedChanged(object sender, EventArgs e)
	{
		OnLoad();
	}

	private void SaveSettings(object sender, EventArgs e)
	{
		OnButtonCancel();
	}

	private void mchbOverrideStandardRules_CheckedChanged(object sender, EventArgs e)
	{
		OnLoad();
		OnButtonCancel();
	}

	private void medRules_TextChanged(object sender, EventArgs e)
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
