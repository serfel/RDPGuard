using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class WebFormsSettingsDialog : Form0
{
	private IContainer icontainer_0;

	private Class66 mbtnSave;

	private Class66 btnCancel;

	private GControl0 separatorLine1;

	private Class62 mlblCaption;

	private PictureBox mimgIcon;

	private Class62 mlblSubCaption;

	private GClass3 mlnkOnlineHelp;

	private Class61 mchbEnableProtection;

	private Class61 mchbUseCustomRules;

	private Class63 mlblEnableProtectionHint;

	private Class63 mlblUseCustomRulesHint;

	private TextBox medCustomRules;

	private Class62 mlblLogFilesLocation;

	private Class63 mlblCustomRulesHint;

	public Class126 Class126_0
	{
		get
		{
			return new Class126
			{
				bool_0 = mchbEnableProtection.Checked,
				bool_3 = mchbUseCustomRules.Checked,
				string_11 = medCustomRules.Text
			};
		}
		set
		{
			mchbEnableProtection.Checked = value.bool_0;
			mchbUseCustomRules.Checked = value.bool_3;
			medCustomRules.Text = value.String_2;
			OnLoad();
		}
	}

	public WebFormsSettingsDialog(Class126 class126_0)
		: base(new Size(500, 560))
	{
		ValidateInput();
		InitializeFormPosition();
		InitializeComponent();
		OnButtonOk();
		Class126_0 = class126_0;
	}

	private void InitializeComponent()
	{
	}

	private void OnButtonOk()
	{
		mlnkOnlineHelp.Click += mlnkOnlineHelp_Click;
		mchbEnableProtection.CheckedChanged += mchbEnableProtection_CheckedChanged;
		mchbUseCustomRules.CheckedChanged += mchbUseCustomRules_CheckedChanged;
		medCustomRules.TextChanged += medCustomRules_TextChanged;
		mbtnSave.Click += mbtnSave_Click;
		btnCancel.Click += btnCancel_Click;
	}

	private void OnButtonCancel()
	{
		bool flag = true;
		if (mchbEnableProtection.Checked && mchbUseCustomRules.Checked)
		{
			flag &= !string.IsNullOrEmpty(medCustomRules.Text);
		}
		mbtnSave.Enabled = flag;
	}

	private void OnLoad()
	{
		bool flag = mchbEnableProtection.Checked;
		mchbUseCustomRules.Enabled = flag;
		mlblUseCustomRulesHint.Enabled = flag;
		bool flag2 = mchbUseCustomRules.Checked;
		mlblLogFilesLocation.Enabled = flag && flag2;
		medCustomRules.Enabled = flag && flag2;
		mlblCustomRulesHint.Enabled = flag && flag2;
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
		btnCancel = new Class66();
		separatorLine1 = new GControl0();
		mlblCaption = new Class62();
		mimgIcon = new PictureBox();
		mlblSubCaption = new Class62();
		mlnkOnlineHelp = new GClass3();
		mchbEnableProtection = new Class61();
		mchbUseCustomRules = new Class61();
		mlblEnableProtectionHint = new Class63();
		mlblUseCustomRulesHint = new Class63();
		medCustomRules = new TextBox();
		mlblLogFilesLocation = new Class62();
		mlblCustomRulesHint = new Class63();
		((ISupportInitialize)mimgIcon).BeginInit();
		SuspendLayout();
		mbtnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mbtnSave.Image = Resources.opts_16;
		mbtnSave.Location = new Point(263, 472);
		mbtnSave.Margin = new Padding(4);
		mbtnSave.Name = "m_btnSave";
		mbtnSave.Size = new Size(100, 36);
		mbtnSave.TabIndex = 7;
		mbtnSave.Text = "Save";
		mbtnSave.TextAlign = ContentAlignment.MiddleRight;
		mbtnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
		mbtnSave.UseVisualStyleBackColor = true;
		btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		btnCancel.Image = Resources.cancl_16;
		btnCancel.Location = new Point(371, 472);
		btnCancel.Margin = new Padding(4);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(100, 36);
		btnCancel.TabIndex = 8;
		btnCancel.Text = "Cancel";
		btnCancel.TextAlign = ContentAlignment.MiddleRight;
		btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
		btnCancel.UseVisualStyleBackColor = true;
		separatorLine1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		separatorLine1.Location = new Point(16, 81);
		separatorLine1.Name = "separatorLine1";
		separatorLine1.Size = new Size(456, 2);
		separatorLine1.TabIndex = 50;
		separatorLine1.TabStop = false;
		mlblCaption.AutoSize = true;
		mlblCaption.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		mlblCaption.Location = new Point(79, 15);
		mlblCaption.Margin = new Padding(4, 0, 4, 0);
		mlblCaption.Name = "m_lblCaption";
		mlblCaption.Size = new Size(230, 16);
		mlblCaption.TabIndex = 49;
		mlblCaption.Text = "ASP.NET Web Forms Protection";
		mimgIcon.Image = Resources.aspdotnet_48;
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
		mlblSubCaption.Size = new Size(241, 16);
		mlblSubCaption.TabIndex = 48;
		mlblSubCaption.Text = "ASP.NET web forms protection settings";
		mlnkOnlineHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		mlnkOnlineHelp.AutoSize = true;
		mlnkOnlineHelp.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkOnlineHelp.Location = new Point(399, 9);
		mlnkOnlineHelp.Name = "m_lnkOnlineHelp";
		mlnkOnlineHelp.Size = new Size(73, 16);
		mlnkOnlineHelp.TabIndex = 9;
		mlnkOnlineHelp.TabStop = true;
		mlnkOnlineHelp.Text = "online help";
		mlnkOnlineHelp.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		mchbEnableProtection.AutoSize = true;
		mchbEnableProtection.Location = new Point(16, 97);
		mchbEnableProtection.Name = "m_chbEnableProtection";
		mchbEnableProtection.Size = new Size(257, 20);
		mchbEnableProtection.TabIndex = 0;
		mchbEnableProtection.Text = "Enable ASP.NET web forms protection";
		mchbEnableProtection.UseVisualStyleBackColor = true;
		mchbUseCustomRules.AutoSize = true;
		mchbUseCustomRules.Location = new Point(16, 157);
		mchbUseCustomRules.Name = "m_chbUseCustomRules";
		mchbUseCustomRules.Size = new Size(225, 20);
		mchbUseCustomRules.TabIndex = 1;
		mchbUseCustomRules.Text = "Override standard detection rules";
		mchbUseCustomRules.UseVisualStyleBackColor = true;
		mlblEnableProtectionHint.AutoSize = true;
		mlblEnableProtectionHint.ForeColor = SystemColors.ControlDarkDark;
		mlblEnableProtectionHint.Location = new Point(13, 122);
		mlblEnableProtectionHint.Name = "m_lblEnableProtectionHint";
		mlblEnableProtectionHint.Size = new Size(299, 16);
		mlblEnableProtectionHint.TabIndex = 58;
		mlblEnableProtectionHint.Text = "Turn on to enable ASP.NET web forms protection";
		mlblUseCustomRulesHint.AutoSize = true;
		mlblUseCustomRulesHint.ForeColor = SystemColors.ControlDarkDark;
		mlblUseCustomRulesHint.Location = new Point(13, 182);
		mlblUseCustomRulesHint.Name = "m_lblUseCustomRulesHint";
		mlblUseCustomRulesHint.Size = new Size(425, 16);
		mlblUseCustomRulesHint.TabIndex = 59;
		mlblUseCustomRulesHint.Text = "Do not enable this feature if you are not sure. Please check online help.";
		medCustomRules.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		medCustomRules.Enabled = false;
		medCustomRules.Location = new Point(23, 243);
		medCustomRules.Multiline = true;
		medCustomRules.Name = "m_edCustomRules";
		medCustomRules.ScrollBars = ScrollBars.Both;
		medCustomRules.Size = new Size(448, 185);
		medCustomRules.TabIndex = 2;
		medCustomRules.WordWrap = false;
		mlblLogFilesLocation.AutoSize = true;
		mlblLogFilesLocation.Enabled = false;
		mlblLogFilesLocation.Location = new Point(13, 217);
		mlblLogFilesLocation.Name = "m_lblLogFilesLocation";
		mlblLogFilesLocation.Size = new Size(146, 16);
		mlblLogFilesLocation.TabIndex = 61;
		mlblLogFilesLocation.Text = "Custom detection rules:";
		mlblCustomRulesHint.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		mlblCustomRulesHint.AutoSize = true;
		mlblCustomRulesHint.Enabled = false;
		mlblCustomRulesHint.ForeColor = SystemColors.ControlDarkDark;
		mlblCustomRulesHint.Location = new Point(20, 435);
		mlblCustomRulesHint.Name = "m_lblCustomRulesHint";
		mlblCustomRulesHint.Size = new Size(393, 16);
		mlblCustomRulesHint.TabIndex = 62;
		mlblCustomRulesHint.Text = "Enter custom detection rules. Please check online help for syntax.";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(484, 521);
		base.Controls.Add(mlblCustomRulesHint);
		base.Controls.Add(mlblLogFilesLocation);
		base.Controls.Add(medCustomRules);
		base.Controls.Add(mlblUseCustomRulesHint);
		base.Controls.Add(mlblEnableProtectionHint);
		base.Controls.Add(mchbUseCustomRules);
		base.Controls.Add(mchbEnableProtection);
		base.Controls.Add(mlnkOnlineHelp);
		base.Controls.Add(separatorLine1);
		base.Controls.Add(mlblCaption);
		base.Controls.Add(mlblSubCaption);
		base.Controls.Add(mimgIcon);
		base.Controls.Add(mbtnSave);
		base.Controls.Add(btnCancel);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(5, 4, 5, 4);
		base.Name = "WebFormsSettingsDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "ASP.NET Web Forms Protection Settings";
		((ISupportInitialize)mimgIcon).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void mlnkOnlineHelp_Click(object sender, EventArgs e)
	{
		ShowOnlineHelp(Class148.Class151.String_14);
	}

	private void mchbEnableProtection_CheckedChanged(object sender, EventArgs e)
	{
		OnLoad();
	}

	private void mchbUseCustomRules_CheckedChanged(object sender, EventArgs e)
	{
		OnLoad();
		OnButtonCancel();
	}

	private void medCustomRules_TextChanged(object sender, EventArgs e)
	{
		OnButtonCancel();
	}

	private void mbtnSave_Click(object sender, EventArgs e)
	{
		CloseDialog(DialogResult.OK);
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		CloseDialog(DialogResult.Cancel);
	}
}
