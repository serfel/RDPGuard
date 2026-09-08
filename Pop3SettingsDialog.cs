using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class Pop3SettingsDialog : Form0
{
	private TrafficMonitoringControl control12_0;

	private Pop3MonitoringViaLogsControl control10_0;

	private IContainer icontainer_0;

	private Class66 mbtnSave;

	private Class66 mbtnCancel;

	private GControl0 separatorLine1;

	private Class62 mlblCaption;

	private PictureBox mimgBigIcon;

	private Class62 mlblSubCaption;

	private GClass3 mlnkOnlineHelp;

	private Panel mpanel;

	private Panel panel1;

	private Class65 mgbProtocolMonitoring;

	private Class63 mlblProtocolMonitoringLogBasedHint;

	private Class63 mlblProtocolMonitoringTrafficBasedHint;

	private Class64 mrbProtocolMonitoringLogBased;

	private Class64 mrbProtocolMonitoringTrafficBased;

	private Class63 mlblEnablePop3ProtectionHint;

	private Class61 mchbEnablePop3Engine;

	public GEnum4 GEnum4_0
	{
		get
		{
			if (mrbProtocolMonitoringTrafficBased.Checked)
			{
				return GEnum4.const_0;
			}
			if (mrbProtocolMonitoringLogBased.Checked)
			{
				return GEnum4.const_1;
			}
			Class208.smethod_0("Pop3SettingsDialog::MonitoringMethod::get unknown_method");
			return GEnum4.const_2;
		}
		set
		{
			if (value == GEnum4.const_0)
			{
				mrbProtocolMonitoringTrafficBased.Checked = true;
				return;
			}
			if (GEnum4.const_1 == value)
			{
				mrbProtocolMonitoringLogBased.Checked = true;
				return;
			}
			int num = (int)value;
			Class208.smethod_0("Pop3SettingsDialog::MonitoringMethod::set unknown_method " + num);
		}
	}

	public Class121 Class121_0
	{
		get
		{
			Class121 @class = new Class121();
			@class.bool_0 = mchbEnablePop3Engine.Checked;
			@class.GEnum4_0 = GEnum4_0;
			@class.UInt16_0 = control12_0.UInt16_0;
			@class.genum5_0 = control12_0.GEnum5_0;
			@class.bool_1 = control12_0.bool_1;
			@class.GClass24_0 = control12_0.gclass24_0;
			@class.class127_0 = control12_0.class127_0;
			@class.genum10_0 = control10_0.GEnum10_0;
			@class.String_1 = new string[1] { control10_0.String_0 };
			return @class;
		}
		set
		{
			mchbEnablePop3Engine.Checked = value.bool_0;
			GEnum4_0 = value.GEnum4_0;
			control12_0.UInt16_0 = value.UInt16_0;
			control12_0.class127_0 = value.class127_0;
			control12_0.GEnum5_0 = value.genum5_0;
			control12_0.bool_1 = value.bool_1;
			control12_0.gclass24_0 = value.GClass24_0;
			control10_0.GEnum10_0 = value.genum10_0;
			control10_0.String_0 = value.String_1[0];
		}
	}

	public Pop3SettingsDialog(Class121 class121_0)
		: base(new Size(565, 655))
	{
		OnLoad();
		InitializeFormPosition();
		InitializeComponent();
		OnButtonOk();
		Class121_0 = class121_0;
		OnButtonCancel();
	}

	private void InitializeComponent()
	{
		control12_0 = new TrafficMonitoringControl(new Class121().UInt16_1)
		{
			String_0 = "Select monitoring method for POP3 traffic:",
			String_1 = "Specify POP3 port:",
			String_2 = "You can specify multiple comma-separated ports, i.e. 110, 995",
			Dock = DockStyle.Fill
		};
		mpanel.Controls.Add(control12_0);
		control10_0 = new Pop3MonitoringViaLogsControl
		{
			Dock = DockStyle.Fill
		};
		mpanel.Controls.Add(control10_0);
	}

	private void OnButtonOk()
	{
		mlnkOnlineHelp.Click += mlnkOnlineHelp_Click;
		mchbEnablePop3Engine.CheckedChanged += mchbEnablePop3Engine_CheckedChanged;
		mrbProtocolMonitoringTrafficBased.CheckedChanged += mrbProtocolMonitoringTrafficBased_CheckedChanged;
		mrbProtocolMonitoringLogBased.CheckedChanged += mrbProtocolMonitoringLogBased_CheckedChanged;
		control12_0.Event_1 += ValidateInput;
		control12_0.Event_0 += SaveSettings;
		control10_0.Event_1 += LoadSettings;
		control10_0.Event_0 += OnTextChanged;
		mbtnSave.Click += mbtnSave_Click;
		mbtnCancel.Click += mbtnCancel_Click;
	}

	private void OnButtonCancel()
	{
		bool flag = mchbEnablePop3Engine.Checked;
		mgbProtocolMonitoring.Enabled = flag;
		control12_0.Enabled = flag && mrbProtocolMonitoringTrafficBased.Checked;
		control12_0.Visible = mrbProtocolMonitoringTrafficBased.Checked;
		control10_0.Enabled = flag && mrbProtocolMonitoringLogBased.Checked;
		control10_0.Visible = mrbProtocolMonitoringLogBased.Checked;
		if (mrbProtocolMonitoringTrafficBased.Checked)
		{
			mbtnSave.Enabled = !flag || control12_0.Boolean_0;
		}
		if (mrbProtocolMonitoringLogBased.Checked)
		{
			mbtnSave.Enabled = !flag || control10_0.Boolean_0;
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
		mpanel = new Panel();
		panel1 = new Panel();
		mgbProtocolMonitoring = new Class65();
		mlblProtocolMonitoringLogBasedHint = new Class63();
		mlblProtocolMonitoringTrafficBasedHint = new Class63();
		mrbProtocolMonitoringLogBased = new Class64();
		mrbProtocolMonitoringTrafficBased = new Class64();
		mlblEnablePop3ProtectionHint = new Class63();
		mchbEnablePop3Engine = new Class61();
		((ISupportInitialize)mimgBigIcon).BeginInit();
		panel1.SuspendLayout();
		mgbProtocolMonitoring.SuspendLayout();
		SuspendLayout();
		mbtnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mbtnSave.Image = Resources.opts_16;
		mbtnSave.Location = new Point(328, 567);
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
		mbtnCancel.Location = new Point(436, 567);
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
		separatorLine1.Size = new Size(521, 2);
		separatorLine1.TabIndex = 50;
		separatorLine1.TabStop = false;
		mlblCaption.AutoSize = true;
		mlblCaption.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		mlblCaption.Location = new Point(79, 15);
		mlblCaption.Margin = new Padding(4, 0, 4, 0);
		mlblCaption.Name = "m_lblCaption";
		mlblCaption.Size = new Size(106, 16);
		mlblCaption.TabIndex = 49;
		mlblCaption.Text = "POP3 Settings";
		mimgBigIcon.Image = Resources.pop3_48;
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
		mlblSubCaption.Size = new Size(213, 16);
		mlblSubCaption.TabIndex = 48;
		mlblSubCaption.Text = "Configure POP3 protection settings";
		mlnkOnlineHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		mlnkOnlineHelp.AutoSize = true;
		mlnkOnlineHelp.LinkBehavior = LinkBehavior.NeverUnderline;
		mlnkOnlineHelp.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkOnlineHelp.Location = new Point(464, 9);
		mlnkOnlineHelp.Name = "m_lnkOnlineHelp";
		mlnkOnlineHelp.Size = new Size(72, 16);
		mlnkOnlineHelp.TabIndex = 9;
		mlnkOnlineHelp.TabStop = true;
		mlnkOnlineHelp.Text = "online help";
		mlnkOnlineHelp.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		mpanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		mpanel.Location = new Point(12, 304);
		mpanel.Name = "m_panel";
		mpanel.Size = new Size(525, 256);
		mpanel.TabIndex = 111;
		panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		panel1.Controls.Add(mgbProtocolMonitoring);
		panel1.Controls.Add(mlblEnablePop3ProtectionHint);
		panel1.Controls.Add(mchbEnablePop3Engine);
		panel1.Location = new Point(12, 89);
		panel1.Name = "panel1";
		panel1.Size = new Size(525, 209);
		panel1.TabIndex = 112;
		mgbProtocolMonitoring.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		mgbProtocolMonitoring.Controls.Add(mlblProtocolMonitoringLogBasedHint);
		mgbProtocolMonitoring.Controls.Add(mlblProtocolMonitoringTrafficBasedHint);
		mgbProtocolMonitoring.Controls.Add(mrbProtocolMonitoringLogBased);
		mgbProtocolMonitoring.Controls.Add(mrbProtocolMonitoringTrafficBased);
		mgbProtocolMonitoring.Location = new Point(0, 61);
		mgbProtocolMonitoring.Name = "m_gbProtocolMonitoring";
		mgbProtocolMonitoring.Size = new Size(525, 145);
		mgbProtocolMonitoring.TabIndex = 113;
		mgbProtocolMonitoring.TabStop = false;
		mgbProtocolMonitoring.Text = "Select monitoring method for POP3 protocol:";
		mlblProtocolMonitoringLogBasedHint.AutoSize = true;
		mlblProtocolMonitoringLogBasedHint.ForeColor = SystemColors.ControlDarkDark;
		mlblProtocolMonitoringLogBasedHint.Location = new Point(12, 55);
		mlblProtocolMonitoringLogBasedHint.Name = "m_lblProtocolMonitoring_LogBasedHint";
		mlblProtocolMonitoringLogBasedHint.Size = new Size(472, 16);
		mlblProtocolMonitoringLogBasedHint.TabIndex = 113;
		mlblProtocolMonitoringLogBasedHint.Text = "Works with particular POP3 server's logs, SSL/TLS connections are supported.";
		mlblProtocolMonitoringTrafficBasedHint.AutoSize = true;
		mlblProtocolMonitoringTrafficBasedHint.ForeColor = SystemColors.ControlDarkDark;
		mlblProtocolMonitoringTrafficBasedHint.Location = new Point(12, 108);
		mlblProtocolMonitoringTrafficBasedHint.Name = "m_lblProtocolMonitoring_TrafficBasedHint";
		mlblProtocolMonitoringTrafficBasedHint.Size = new Size(423, 16);
		mlblProtocolMonitoringTrafficBasedHint.TabIndex = 112;
		mlblProtocolMonitoringTrafficBasedHint.Text = "Works with any POP3 Server. SSL/TLS connections are not supported.";
		mrbProtocolMonitoringLogBased.AutoSize = true;
		mrbProtocolMonitoringLogBased.Location = new Point(15, 32);
		mrbProtocolMonitoringLogBased.Name = "m_rbProtocolMonitoring_LogBased";
		mrbProtocolMonitoringLogBased.Size = new Size(55, 20);
		mrbProtocolMonitoringLogBased.TabIndex = 111;
		mrbProtocolMonitoringLogBased.TabStop = true;
		mrbProtocolMonitoringLogBased.Text = "Logs";
		mrbProtocolMonitoringLogBased.UseVisualStyleBackColor = true;
		mrbProtocolMonitoringTrafficBased.AutoSize = true;
		mrbProtocolMonitoringTrafficBased.Location = new Point(15, 85);
		mrbProtocolMonitoringTrafficBased.Name = "m_rbProtocolMonitoring_TrafficBased";
		mrbProtocolMonitoringTrafficBased.Size = new Size(62, 20);
		mrbProtocolMonitoringTrafficBased.TabIndex = 110;
		mrbProtocolMonitoringTrafficBased.TabStop = true;
		mrbProtocolMonitoringTrafficBased.Text = "Traffic";
		mrbProtocolMonitoringTrafficBased.UseVisualStyleBackColor = true;
		mlblEnablePop3ProtectionHint.AutoSize = true;
		mlblEnablePop3ProtectionHint.ForeColor = SystemColors.ControlDarkDark;
		mlblEnablePop3ProtectionHint.Location = new Point(3, 26);
		mlblEnablePop3ProtectionHint.Name = "m_lblEnablePop3ProtectionHint";
		mlblEnablePop3ProtectionHint.Size = new Size(211, 16);
		mlblEnablePop3ProtectionHint.TabIndex = 112;
		mlblEnablePop3ProtectionHint.Text = "Turn on to enable POP3 protection";
		mchbEnablePop3Engine.AutoSize = true;
		mchbEnablePop3Engine.Location = new Point(4, 3);
		mchbEnablePop3Engine.Name = "m_chbEnablePop3Engine";
		mchbEnablePop3Engine.Size = new Size(169, 20);
		mchbEnablePop3Engine.TabIndex = 111;
		mchbEnablePop3Engine.Text = "Enable POP3 protection";
		mchbEnablePop3Engine.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(549, 616);
		base.Controls.Add(panel1);
		base.Controls.Add(mpanel);
		base.Controls.Add(mlnkOnlineHelp);
		base.Controls.Add(separatorLine1);
		base.Controls.Add(mlblCaption);
		base.Controls.Add(mlblSubCaption);
		base.Controls.Add(mimgBigIcon);
		base.Controls.Add(mbtnSave);
		base.Controls.Add(mbtnCancel);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(5, 4, 5, 4);
		base.Name = "Pop3SettingsDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "POP3 Settings";
		((ISupportInitialize)mimgBigIcon).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		mgbProtocolMonitoring.ResumeLayout(performLayout: false);
		mgbProtocolMonitoring.PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void mlnkOnlineHelp_Click(object sender, EventArgs e)
	{
		ShowOnlineHelp(Class148.Class151.String_6);
	}

	private void mchbEnablePop3Engine_CheckedChanged(object sender, EventArgs e)
	{
		OnButtonCancel();
	}

	private void mrbProtocolMonitoringTrafficBased_CheckedChanged(object sender, EventArgs e)
	{
		OnButtonCancel();
	}

	private void mrbProtocolMonitoringLogBased_CheckedChanged(object sender, EventArgs e)
	{
		OnButtonCancel();
	}

	private void ValidateInput(object sender, EventArgs e)
	{
		mbtnSave.Enabled = control12_0.Boolean_0;
	}

	private void SaveSettings(object sender, EventArgs e)
	{
		mbtnSave.PerformClick();
	}

	private void LoadSettings(object sender, EventArgs e)
	{
		mbtnSave.Enabled = control10_0.Boolean_0;
	}

	private void OnTextChanged(object sender, EventArgs e)
	{
		mbtnSave.PerformClick();
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
