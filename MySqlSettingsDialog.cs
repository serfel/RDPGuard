using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Properties;

internal sealed class MySqlSettingsDialog : Form0
{
	private IContainer icontainer_0;

	private Class66 mbtnSave;

	private Class66 btnCancel;

	private GControl0 separatorLine1;

	private Class62 label2;

	private PictureBox imgBigIcon;

	private Class62 lblCaption;

	private GClass3 mlnkOnlineHelp;

	private Class61 mchbEnableMySqlEngine;

	private Class61 mchbAutomaticConfigLocation;

	private Class63 mlblEnableMySqlProtectionHInt;

	private Class63 mlblAutomaticConfigLocationHint;

	private Class54 medConfigFileLocation;

	private Class62 mlblConfigFileLocation;

	private Class63 mlblConfigFileLocationHint;

	private Class63 mlblLogFileLocationHint;

	private Class62 mlblLogFileLocation;

	private Class54 medLogFileLocation;

	private Class63 mlblAutomaticLogFileLocationHint;

	private Class61 mchbAutomaticLogFileLocation;

	private Class63 mlblMonitoringViaGeneralLogHint;

	private Class63 mlblMonitoringViaApplicationEventLogHint;

	private Class64 mrbMonitoringViaGeneralLog;

	private Class64 mrbMonitoringViaApplicationEventLog;

	private Class62 mlblSelectMonitoringMethod;

	private GEnum9 GEnum9_0
	{
		get
		{
			if (mrbMonitoringViaApplicationEventLog.Checked)
			{
				return GEnum9.const_1;
			}
			if (!mrbMonitoringViaGeneralLog.Checked)
			{
				throw new NotImplementedException("MySqlSettingsDialog::MonitoringMethod::get: unknown_monitoring_method");
			}
			return GEnum9.const_0;
		}
		set
		{
			switch (value)
			{
			default:
				throw new NotImplementedException("MySqlSettingsDialog::MonitoringMethod::set: unknown_monitoring_method");
			case GEnum9.const_1:
				mrbMonitoringViaApplicationEventLog.Checked = true;
				mrbMonitoringViaGeneralLog.Checked = false;
				break;
			case GEnum9.const_0:
				mrbMonitoringViaApplicationEventLog.Checked = false;
				mrbMonitoringViaGeneralLog.Checked = true;
				break;
			}
		}
	}

	public Class119 Class119_0
	{
		get
		{
			Class119 @class = new Class119();
			@class.bool_0 = mchbEnableMySqlEngine.Checked;
			@class.genum9_0 = GEnum9_0;
			@class.bool_3 = mchbAutomaticConfigLocation.Checked;
			@class.bool_2 = mchbAutomaticLogFileLocation.Checked;
			@class.string_10 = medConfigFileLocation.Text;
			@class.String_1 = new string[1] { medLogFileLocation.Text };
			return @class;
		}
		set
		{
			mchbEnableMySqlEngine.Checked = value.bool_0;
			GEnum9_0 = value.genum9_0;
			mchbAutomaticConfigLocation.Checked = value.bool_3;
			mchbAutomaticLogFileLocation.Checked = value.bool_2;
			medConfigFileLocation.Text = value.string_10;
			medLogFileLocation.Text = value.String_1[0];
			OnLoad();
		}
	}

	public MySqlSettingsDialog(Class119 class119_0)
		: base(new Size(595, 680))
	{
		ValidateInput();
		InitializeFormPosition();
		InitializeComponent();
		OnButtonOk();
		Class119_0 = class119_0;
	}

	private void InitializeComponent()
	{
		medConfigFileLocation.String_0 = "Click to specify MySQL config file location";
		medConfigFileLocation.String_2 = "MySQL Config Files|my.ini; my.cnf";
		medLogFileLocation.String_0 = "Click to specify MySQL general log file location";
		medLogFileLocation.String_2 = "MySQL General Log File|*.*";
		string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "MySQL");
		if (Directory.Exists(text))
		{
			medConfigFileLocation.String_1 = text;
			medLogFileLocation.String_1 = text;
		}
	}

	private void OnButtonOk()
	{
		mlnkOnlineHelp.Click += mlnkOnlineHelp_Click;
		mchbEnableMySqlEngine.CheckedChanged += mchbEnableMySqlEngine_CheckedChanged;
		mrbMonitoringViaApplicationEventLog.CheckedChanged += mrbMonitoringViaApplicationEventLog_CheckedChanged;
		mrbMonitoringViaGeneralLog.CheckedChanged += mrbMonitoringViaGeneralLog_CheckedChanged;
		mchbAutomaticConfigLocation.CheckedChanged += mchbAutomaticConfigLocation_CheckedChanged;
		mchbAutomaticLogFileLocation.CheckedChanged += mchbAutomaticLogFileLocation_CheckedChanged;
		medConfigFileLocation.TextChanged += medConfigFileLocation_TextChanged;
		medLogFileLocation.TextChanged += medLogFileLocation_TextChanged;
		mbtnSave.Click += mbtnSave_Click;
		btnCancel.Click += btnCancel_Click;
	}

	private void OnButtonCancel()
	{
		bool flag = true;
		if (mchbEnableMySqlEngine.Checked)
		{
			if (!mchbAutomaticConfigLocation.Checked)
			{
				flag &= !string.IsNullOrEmpty(medConfigFileLocation.Text);
			}
			if (!mchbAutomaticLogFileLocation.Checked)
			{
				flag &= !string.IsNullOrEmpty(medLogFileLocation.Text);
			}
		}
		mbtnSave.Enabled = flag;
	}

	private void OnLoad()
	{
		bool flag = mchbEnableMySqlEngine.Checked;
		mlblSelectMonitoringMethod.Enabled = flag;
		mrbMonitoringViaApplicationEventLog.Enabled = flag;
		mlblMonitoringViaApplicationEventLogHint.Enabled = flag;
		mrbMonitoringViaGeneralLog.Enabled = flag;
		mlblMonitoringViaGeneralLogHint.Enabled = flag;
		bool flag2 = mrbMonitoringViaGeneralLog.Checked;
		mchbAutomaticConfigLocation.Enabled = flag && flag2;
		mlblAutomaticConfigLocationHint.Enabled = flag && flag2;
		bool flag3 = mchbAutomaticConfigLocation.Checked;
		mlblConfigFileLocation.Enabled = flag && flag2 && !flag3;
		medConfigFileLocation.Enabled = flag && flag2 && !flag3;
		mlblConfigFileLocationHint.Enabled = flag && flag2 && !flag3;
		mchbAutomaticLogFileLocation.Enabled = flag && flag2;
		mlblAutomaticLogFileLocationHint.Enabled = flag && flag2;
		bool flag4 = mchbAutomaticLogFileLocation.Checked;
		mlblLogFileLocation.Enabled = flag && flag2 && !flag4;
		medLogFileLocation.Enabled = flag && flag2 && !flag4;
		mlblLogFileLocationHint.Enabled = flag && flag2 && !flag4;
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
		icontainer_0 = new Container();
		mbtnSave = new Class66();
		btnCancel = new Class66();
		separatorLine1 = new GControl0();
		label2 = new Class62();
		imgBigIcon = new PictureBox();
		lblCaption = new Class62();
		mlnkOnlineHelp = new GClass3();
		mchbEnableMySqlEngine = new Class61();
		mchbAutomaticConfigLocation = new Class61();
		mlblEnableMySqlProtectionHInt = new Class63();
		mlblAutomaticConfigLocationHint = new Class63();
		medConfigFileLocation = new Class54();
		mlblConfigFileLocation = new Class62();
		mlblConfigFileLocationHint = new Class63();
		mlblLogFileLocationHint = new Class63();
		mlblLogFileLocation = new Class62();
		medLogFileLocation = new Class54();
		mlblAutomaticLogFileLocationHint = new Class63();
		mchbAutomaticLogFileLocation = new Class61();
		mlblMonitoringViaGeneralLogHint = new Class63();
		mlblMonitoringViaApplicationEventLogHint = new Class63();
		mrbMonitoringViaGeneralLog = new Class64();
		mrbMonitoringViaApplicationEventLog = new Class64();
		mlblSelectMonitoringMethod = new Class63();
		((ISupportInitialize)imgBigIcon).BeginInit();
		SuspendLayout();
		mbtnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mbtnSave.Image = Resources.opts_16;
		mbtnSave.Location = new Point(358, 593);
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
		btnCancel.Location = new Point(466, 593);
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
		separatorLine1.Size = new Size(551, 2);
		separatorLine1.TabIndex = 50;
		separatorLine1.TabStop = false;
		label2.AutoSize = true;
		label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		label2.Location = new Point(79, 15);
		label2.Margin = new Padding(4, 0, 4, 0);
		label2.Name = "label2";
		label2.Size = new Size(116, 16);
		label2.TabIndex = 49;
		label2.Text = "MySQL Settings";
		imgBigIcon.Image = Resources.mysql_logo_48;
		imgBigIcon.Location = new Point(16, 15);
		imgBigIcon.Margin = new Padding(4);
		imgBigIcon.Name = "imgBigIcon";
		imgBigIcon.Size = new Size(48, 45);
		imgBigIcon.SizeMode = PictureBoxSizeMode.AutoSize;
		imgBigIcon.TabIndex = 47;
		imgBigIcon.TabStop = false;
		lblCaption.AutoSize = true;
		lblCaption.Location = new Point(79, 47);
		lblCaption.Margin = new Padding(4, 0, 4, 0);
		lblCaption.Name = "lblCaption";
		lblCaption.Size = new Size(227, 16);
		lblCaption.TabIndex = 48;
		lblCaption.Text = "Advanced MySQL protection settings";
		mlnkOnlineHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		mlnkOnlineHelp.AutoSize = true;
		mlnkOnlineHelp.LinkBehavior = LinkBehavior.NeverUnderline;
		mlnkOnlineHelp.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkOnlineHelp.Location = new Point(494, 9);
		mlnkOnlineHelp.Name = "m_lnkOnlineHelp";
		mlnkOnlineHelp.Size = new Size(72, 16);
		mlnkOnlineHelp.TabIndex = 9;
		mlnkOnlineHelp.TabStop = true;
		mlnkOnlineHelp.Text = "online help";
		mlnkOnlineHelp.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		mchbEnableMySqlEngine.AutoSize = true;
		mchbEnableMySqlEngine.Location = new Point(16, 97);
		mchbEnableMySqlEngine.Name = "m_chbEnableMySqlEngine";
		mchbEnableMySqlEngine.Size = new Size(178, 20);
		mchbEnableMySqlEngine.TabIndex = 0;
		mchbEnableMySqlEngine.Text = "Enable MySQL protection";
		mchbEnableMySqlEngine.UseVisualStyleBackColor = true;
		mchbAutomaticConfigLocation.AutoSize = true;
		mchbAutomaticConfigLocation.Location = new Point(16, 294);
		mchbAutomaticConfigLocation.Name = "m_chbAutomaticConfigLocation";
		mchbAutomaticConfigLocation.Size = new Size(255, 20);
		mchbAutomaticConfigLocation.TabIndex = 3;
		mchbAutomaticConfigLocation.Text = "Automatically detect config file location";
		mchbAutomaticConfigLocation.UseVisualStyleBackColor = true;
		mlblEnableMySqlProtectionHInt.AutoSize = true;
		mlblEnableMySqlProtectionHInt.ForeColor = SystemColors.ControlDarkDark;
		mlblEnableMySqlProtectionHInt.Location = new Point(13, 122);
		mlblEnableMySqlProtectionHInt.Name = "m_lblEnableMySqlProtectionHInt";
		mlblEnableMySqlProtectionHInt.Size = new Size(220, 16);
		mlblEnableMySqlProtectionHInt.TabIndex = 58;
		mlblEnableMySqlProtectionHInt.Text = "Turn on to enable MySQL protection";
		mlblAutomaticConfigLocationHint.AutoSize = true;
		mlblAutomaticConfigLocationHint.ForeColor = SystemColors.ControlDarkDark;
		mlblAutomaticConfigLocationHint.Location = new Point(13, 319);
		mlblAutomaticConfigLocationHint.Name = "m_lblAutomaticConfigLocationHint";
		mlblAutomaticConfigLocationHint.Size = new Size(349, 16);
		mlblAutomaticConfigLocationHint.TabIndex = 59;
		mlblAutomaticConfigLocationHint.Text = "RdpGuard will detect my.ini (my.cnf) location automatically";
		medConfigFileLocation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		medConfigFileLocation.Enabled = false;
		medConfigFileLocation.String_1 = null;
		medConfigFileLocation.Location = new Point(23, 380);
		medConfigFileLocation.Name = "m_edConfigFileLocation";
		medConfigFileLocation.Size = new Size(543, 22);
		medConfigFileLocation.TabIndex = 4;
		mlblConfigFileLocation.AutoSize = true;
		mlblConfigFileLocation.Enabled = false;
		mlblConfigFileLocation.Location = new Point(13, 354);
		mlblConfigFileLocation.Name = "m_lblConfigFileLocation";
		mlblConfigFileLocation.Size = new Size(118, 16);
		mlblConfigFileLocation.TabIndex = 61;
		mlblConfigFileLocation.Text = "Config file location:";
		mlblConfigFileLocationHint.AutoSize = true;
		mlblConfigFileLocationHint.Enabled = false;
		mlblConfigFileLocationHint.ForeColor = SystemColors.ControlDarkDark;
		mlblConfigFileLocationHint.Location = new Point(20, 405);
		mlblConfigFileLocationHint.Name = "m_lblConfigFileLocationHint";
		mlblConfigFileLocationHint.Size = new Size(313, 16);
		mlblConfigFileLocationHint.TabIndex = 62;
		mlblConfigFileLocationHint.Text = "You can specify location of my.ini (my.cnf) manually";
		mlblLogFileLocationHint.AutoSize = true;
		mlblLogFileLocationHint.Enabled = false;
		mlblLogFileLocationHint.ForeColor = SystemColors.ControlDarkDark;
		mlblLogFileLocationHint.Location = new Point(20, 551);
		mlblLogFileLocationHint.Name = "m_lblLogFileLocationHint";
		mlblLogFileLocationHint.Size = new Size(526, 16);
		mlblLogFileLocationHint.TabIndex = 68;
		mlblLogFileLocationHint.Text = "You can specify location of general log file manually. General logging must be enabled.";
		mlblLogFileLocation.AutoSize = true;
		mlblLogFileLocation.Enabled = false;
		mlblLogFileLocation.Location = new Point(13, 500);
		mlblLogFileLocation.Name = "m_lblLogFileLocation";
		mlblLogFileLocation.Size = new Size(150, 16);
		mlblLogFileLocation.TabIndex = 67;
		mlblLogFileLocation.Text = "General log file location:";
		medLogFileLocation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		medLogFileLocation.Enabled = false;
		medLogFileLocation.String_1 = null;
		medLogFileLocation.Location = new Point(23, 526);
		medLogFileLocation.Name = "m_edLogFileLocation";
		medLogFileLocation.Size = new Size(543, 22);
		medLogFileLocation.TabIndex = 6;
		mlblAutomaticLogFileLocationHint.AutoSize = true;
		mlblAutomaticLogFileLocationHint.ForeColor = SystemColors.ControlDarkDark;
		mlblAutomaticLogFileLocationHint.Location = new Point(13, 465);
		mlblAutomaticLogFileLocationHint.Name = "m_lblAutomaticLogFileLocationHint";
		mlblAutomaticLogFileLocationHint.Size = new Size(354, 16);
		mlblAutomaticLogFileLocationHint.TabIndex = 65;
		mlblAutomaticLogFileLocationHint.Text = "RdpGuard will detect general log file location automatically";
		mchbAutomaticLogFileLocation.AutoSize = true;
		mchbAutomaticLogFileLocation.Location = new Point(16, 440);
		mchbAutomaticLogFileLocation.Name = "m_chbAutomaticLogFileLocation";
		mchbAutomaticLogFileLocation.Size = new Size(287, 20);
		mchbAutomaticLogFileLocation.TabIndex = 5;
		mchbAutomaticLogFileLocation.Text = "Automatically detect general log file location";
		mchbAutomaticLogFileLocation.UseVisualStyleBackColor = true;
		mlblMonitoringViaGeneralLogHint.AutoSize = true;
		mlblMonitoringViaGeneralLogHint.Enabled = false;
		mlblMonitoringViaGeneralLogHint.ForeColor = SystemColors.ControlDarkDark;
		mlblMonitoringViaGeneralLogHint.Location = new Point(25, 260);
		mlblMonitoringViaGeneralLogHint.Name = "m_lblMonitoringViaGeneralLogHint";
		mlblMonitoringViaGeneralLogHint.Size = new Size(480, 16);
		mlblMonitoringViaGeneralLogHint.TabIndex = 86;
		mlblMonitoringViaGeneralLogHint.Text = "Works with all MySQL editions. May work slow on heavy loaded MySQL servers.";
		mlblMonitoringViaApplicationEventLogHint.AutoSize = true;
		mlblMonitoringViaApplicationEventLogHint.Enabled = false;
		mlblMonitoringViaApplicationEventLogHint.ForeColor = SystemColors.ControlDarkDark;
		mlblMonitoringViaApplicationEventLogHint.Location = new Point(25, 207);
		mlblMonitoringViaApplicationEventLogHint.Name = "m_lblMonitoringViaApplicationEventLogHint";
		mlblMonitoringViaApplicationEventLogHint.Size = new Size(529, 16);
		mlblMonitoringViaApplicationEventLogHint.TabIndex = 85;
		mlblMonitoringViaApplicationEventLogHint.Text = "Works with MySQL 5.7 and higher. Faster and less resource consuming. Recommended.";
		mrbMonitoringViaGeneralLog.AutoSize = true;
		mrbMonitoringViaGeneralLog.Enabled = false;
		mrbMonitoringViaGeneralLog.Location = new Point(28, 235);
		mrbMonitoringViaGeneralLog.Name = "m_rbMonitoringViaGeneralLog";
		mrbMonitoringViaGeneralLog.Size = new Size(146, 20);
		mrbMonitoringViaGeneralLog.TabIndex = 2;
		mrbMonitoringViaGeneralLog.TabStop = true;
		mrbMonitoringViaGeneralLog.Text = "MySQL General Log";
		mrbMonitoringViaGeneralLog.UseVisualStyleBackColor = true;
		mrbMonitoringViaApplicationEventLog.AutoSize = true;
		mrbMonitoringViaApplicationEventLog.Enabled = false;
		mrbMonitoringViaApplicationEventLog.Location = new Point(28, 182);
		mrbMonitoringViaApplicationEventLog.Name = "m_rbMonitoringViaApplicationEventLog";
		mrbMonitoringViaApplicationEventLog.Size = new Size(155, 20);
		mrbMonitoringViaApplicationEventLog.TabIndex = 1;
		mrbMonitoringViaApplicationEventLog.TabStop = true;
		mrbMonitoringViaApplicationEventLog.Text = "Application Event Log";
		mrbMonitoringViaApplicationEventLog.UseVisualStyleBackColor = true;
		mlblSelectMonitoringMethod.AutoSize = true;
		mlblSelectMonitoringMethod.Enabled = false;
		mlblSelectMonitoringMethod.Location = new Point(13, 154);
		mlblSelectMonitoringMethod.Name = "m_lblSelectMonitoringMethod";
		mlblSelectMonitoringMethod.Size = new Size(158, 16);
		mlblSelectMonitoringMethod.TabIndex = 82;
		mlblSelectMonitoringMethod.Text = "Select monitoring method";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(579, 642);
		base.Controls.Add(mlblMonitoringViaGeneralLogHint);
		base.Controls.Add(mlblMonitoringViaApplicationEventLogHint);
		base.Controls.Add(mrbMonitoringViaGeneralLog);
		base.Controls.Add(mrbMonitoringViaApplicationEventLog);
		base.Controls.Add(mlblSelectMonitoringMethod);
		base.Controls.Add(mlblLogFileLocationHint);
		base.Controls.Add(mlblLogFileLocation);
		base.Controls.Add(medLogFileLocation);
		base.Controls.Add(mlblAutomaticLogFileLocationHint);
		base.Controls.Add(mchbAutomaticLogFileLocation);
		base.Controls.Add(mlblConfigFileLocationHint);
		base.Controls.Add(mlblConfigFileLocation);
		base.Controls.Add(medConfigFileLocation);
		base.Controls.Add(mlblAutomaticConfigLocationHint);
		base.Controls.Add(mlblEnableMySqlProtectionHInt);
		base.Controls.Add(mchbAutomaticConfigLocation);
		base.Controls.Add(mchbEnableMySqlEngine);
		base.Controls.Add(mlnkOnlineHelp);
		base.Controls.Add(separatorLine1);
		base.Controls.Add(label2);
		base.Controls.Add(lblCaption);
		base.Controls.Add(imgBigIcon);
		base.Controls.Add(mbtnSave);
		base.Controls.Add(btnCancel);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(5, 4, 5, 4);
		base.Name = "MySqlSettingsDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "MySQL Settings";
		((ISupportInitialize)imgBigIcon).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void mlnkOnlineHelp_Click(object sender, EventArgs e)
	{
		ShowOnlineHelp(Class148.Class151.String_8);
	}

	private void mchbEnableMySqlEngine_CheckedChanged(object sender, EventArgs e)
	{
		OnLoad();
	}

	private void mrbMonitoringViaApplicationEventLog_CheckedChanged(object sender, EventArgs e)
	{
		OnLoad();
	}

	private void mrbMonitoringViaGeneralLog_CheckedChanged(object sender, EventArgs e)
	{
		OnLoad();
	}

	private void mchbAutomaticConfigLocation_CheckedChanged(object sender, EventArgs e)
	{
		OnLoad();
		OnButtonCancel();
	}

	private void mchbAutomaticLogFileLocation_CheckedChanged(object sender, EventArgs e)
	{
		OnLoad();
		OnButtonCancel();
	}

	private void medConfigFileLocation_TextChanged(object sender, EventArgs e)
	{
		OnButtonCancel();
	}

	private void medLogFileLocation_TextChanged(object sender, EventArgs e)
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
