using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class RdpSettingsDialog : Form0
{
	private TrafficMonitoringControl control12_0;

	private string string_0 = string.Empty;

	private IContainer icontainer_0;

	private Class66 mbtnSave;

	private Class66 mbtnCancel;

	private GControl0 separatorLine1;

	private Class62 mlblCaption;

	private PictureBox mimgBigIcon;

	private Class62 mlblSubCaption;

	private GClass3 mlnkOnlineHelp;

	private Class61 mchbEnableRdpEngine;

	private Class63 mlblEnableRdpProtectionHint;

	private Panel mpanel;

	private Class63 mlblEnableTrafficMonitoringHint;

	private Class61 mchbEnableTrafficMonitoring;

	private GClass3 mlnkExclusions;

	public Class122 Class122_0
	{
		get
		{
			return new Class122
			{
				bool_0 = mchbEnableRdpEngine.Checked,
				genum5_0 = control12_0.GEnum5_0,
				UInt16_0 = control12_0.UInt16_0,
				bool_1 = control12_0.bool_1,
				GClass24_0 = control12_0.gclass24_0,
				class127_0 = control12_0.class127_0,
				Boolean_0 = mchbEnableTrafficMonitoring.Checked,
				string_10 = string_0
			};
		}
		set
		{
			mchbEnableRdpEngine.Checked = value.bool_0;
			control12_0.UInt16_0 = value.UInt16_0;
			control12_0.class127_0 = value.class127_0;
			control12_0.GEnum5_0 = value.genum5_0;
			control12_0.bool_1 = value.bool_1;
			control12_0.gclass24_0 = value.GClass24_0;
			mchbEnableTrafficMonitoring.Checked = value.Boolean_0;
			string_0 = value.string_10;
			OnButtonCancel();
		}
	}

	protected override Button Button_0 => mbtnSave;

	public RdpSettingsDialog()
		: base(new Size(565, 550))
	{
		ValidateInput();
		InitializeFormPosition();
		InitializeComponent();
		OnButtonOk();
	}

	private void InitializeComponent()
	{
		control12_0 = new TrafficMonitoringControl(null)
		{
			String_0 = "Select monitoring method for RDP over TLS:",
			String_1 = "RDP port (leave it empty to detect automatically):",
			String_2 = "You can also specify multiple comma-separated ports, i.e. 3389, 3390",
			Dock = DockStyle.Fill
		};
		mpanel.Controls.Add(control12_0);
	}

	private void OnButtonOk()
	{
		mlnkOnlineHelp.Click += mlnkOnlineHelp_Click;
		mchbEnableRdpEngine.CheckedChanged += mchbEnableRdpEngine_CheckedChanged;
		mchbEnableTrafficMonitoring.CheckedChanged += mchbEnableTrafficMonitoring_CheckedChanged;
		control12_0.Event_1 += SaveSettings;
		control12_0.Event_0 += LoadSettings;
		mlnkExclusions.Click += mlnkExclusions_Click;
		mbtnSave.Click += mbtnSave_Click;
		mbtnCancel.Click += mbtnCancel_Click;
	}

	private void OnButtonCancel()
	{
		bool flag = mchbEnableRdpEngine.Checked;
		mchbEnableTrafficMonitoring.Enabled = flag;
		mlblEnableTrafficMonitoringHint.Enabled = flag;
		control12_0.Enabled = flag && mchbEnableTrafficMonitoring.Checked;
		mlnkExclusions.Enabled = flag;
		OnFormClosing();
	}

	private void OnLoad()
	{
		ProtocolRulesDialog form = new ProtocolRulesDialog
		{
			String_0 = "RDP Exclusions",
			String_1 = "RDP Exclusions",
			String_2 = "Exclusions for Event ID 4625",
			string_0 = Class148.Class151.String_1,
			String_3 = "Exclusion rules:",
			String_4 = string_0,
			String_5 = "Exclusion rules for 4625 events, please check online help for syntax"
		};
		using (form)
		{
			if (DialogResult.OK == form.ShowDialog())
			{
				string_0 = form.String_4;
			}
		}
	}

	protected override void OnFormClosing()
	{
		Button_0.Enabled = !mchbEnableTrafficMonitoring.Checked || control12_0.Boolean_0;
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
		new ComponentResourceManager(typeof(RdpSettingsDialog));
		mbtnSave = new Class66();
		mbtnCancel = new Class66();
		separatorLine1 = new GControl0();
		mlblCaption = new Class62();
		mimgBigIcon = new PictureBox();
		mlblSubCaption = new Class62();
		mlnkOnlineHelp = new GClass3();
		mchbEnableRdpEngine = new Class61();
		mlblEnableRdpProtectionHint = new Class63();
		mpanel = new Panel();
		mlblEnableTrafficMonitoringHint = new Class63();
		mchbEnableTrafficMonitoring = new Class61();
		mlnkExclusions = new GClass3();
		((ISupportInitialize)mimgBigIcon).BeginInit();
		SuspendLayout();
		mbtnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mbtnSave.Enabled = false;
		mbtnSave.Image = Resources.opts_16;
		mbtnSave.Location = new Point(336, 462);
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
		mbtnCancel.Location = new Point(444, 462);
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
		separatorLine1.Size = new Size(529, 2);
		separatorLine1.TabIndex = 50;
		separatorLine1.TabStop = false;
		mlblCaption.AutoSize = true;
		mlblCaption.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		mlblCaption.Location = new Point(79, 15);
		mlblCaption.Margin = new Padding(4, 0, 4, 0);
		mlblCaption.Name = "m_lblCaption";
		mlblCaption.Size = new Size(99, 16);
		mlblCaption.TabIndex = 49;
		mlblCaption.Text = "RDP Settings";
		mimgBigIcon.Image = Resources.rdp_48;
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
		mlblSubCaption.Size = new Size(212, 16);
		mlblSubCaption.TabIndex = 48;
		mlblSubCaption.Text = "Advanced RDP protection settings";
		mlnkOnlineHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		mlnkOnlineHelp.AutoSize = true;
		mlnkOnlineHelp.LinkBehavior = LinkBehavior.NeverUnderline;
		mlnkOnlineHelp.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkOnlineHelp.Location = new Point(472, 9);
		mlnkOnlineHelp.Name = "m_lnkOnlineHelp";
		mlnkOnlineHelp.Size = new Size(72, 16);
		mlnkOnlineHelp.TabIndex = 9;
		mlnkOnlineHelp.TabStop = true;
		mlnkOnlineHelp.Text = "online help";
		mlnkOnlineHelp.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		mchbEnableRdpEngine.AutoSize = true;
		mchbEnableRdpEngine.Location = new Point(16, 97);
		mchbEnableRdpEngine.Name = "m_chbEnableRdpEngine";
		mchbEnableRdpEngine.Size = new Size(163, 20);
		mchbEnableRdpEngine.TabIndex = 0;
		mchbEnableRdpEngine.Text = "Enable RDP protection";
		mchbEnableRdpEngine.UseVisualStyleBackColor = true;
		mlblEnableRdpProtectionHint.AutoSize = true;
		mlblEnableRdpProtectionHint.ForeColor = SystemColors.ControlDarkDark;
		mlblEnableRdpProtectionHint.Location = new Point(13, 122);
		mlblEnableRdpProtectionHint.Name = "m_lblEnableRdpProtectionHint";
		mlblEnableRdpProtectionHint.Size = new Size(205, 16);
		mlblEnableRdpProtectionHint.TabIndex = 58;
		mlblEnableRdpProtectionHint.Text = "Turn on to enable RDP protection";
		mpanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		mpanel.Location = new Point(12, 211);
		mpanel.Name = "m_panel";
		mpanel.Size = new Size(533, 244);
		mpanel.TabIndex = 112;
		mlblEnableTrafficMonitoringHint.AutoSize = true;
		mlblEnableTrafficMonitoringHint.ForeColor = SystemColors.ControlDarkDark;
		mlblEnableTrafficMonitoringHint.Location = new Point(13, 178);
		mlblEnableTrafficMonitoringHint.Name = "m_lblEnableTrafficMonitoringHint";
		mlblEnableTrafficMonitoringHint.Size = new Size(514, 16);
		mlblEnableTrafficMonitoringHint.TabIndex = 114;
		mlblEnableTrafficMonitoringHint.Text = "Required on Windows Server 2008, usually not needed on other versions, check help..";
		mchbEnableTrafficMonitoring.AutoSize = true;
		mchbEnableTrafficMonitoring.Location = new Point(16, 153);
		mchbEnableTrafficMonitoring.Name = "m_chbEnableTrafficMonitoring";
		mchbEnableTrafficMonitoring.Size = new Size(168, 20);
		mchbEnableTrafficMonitoring.TabIndex = 113;
		mchbEnableTrafficMonitoring.Text = "Enable traffic monitoring";
		mchbEnableTrafficMonitoring.UseVisualStyleBackColor = true;
		mlnkExclusions.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		mlnkExclusions.AutoSize = true;
		mlnkExclusions.LinkBehavior = LinkBehavior.NeverUnderline;
		mlnkExclusions.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkExclusions.Location = new Point(9, 482);
		mlnkExclusions.Name = "m_lnkExclusions";
		mlnkExclusions.Size = new Size(77, 16);
		mlnkExclusions.TabIndex = 115;
		mlnkExclusions.TabStop = true;
		mlnkExclusions.Text = "Exclusions..";
		mlnkExclusions.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(557, 511);
		base.Controls.Add(mlnkExclusions);
		base.Controls.Add(mlblEnableTrafficMonitoringHint);
		base.Controls.Add(mchbEnableTrafficMonitoring);
		base.Controls.Add(mpanel);
		base.Controls.Add(mlblEnableRdpProtectionHint);
		base.Controls.Add(mchbEnableRdpEngine);
		base.Controls.Add(mlnkOnlineHelp);
		base.Controls.Add(separatorLine1);
		base.Controls.Add(mlblCaption);
		base.Controls.Add(mlblSubCaption);
		base.Controls.Add(mimgBigIcon);
		base.Controls.Add(mbtnSave);
		base.Controls.Add(mbtnCancel);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(5, 4, 5, 4);
		base.Name = "RdpSettingsDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "RDP Settings";
		((ISupportInitialize)mimgBigIcon).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void mlnkOnlineHelp_Click(object sender, EventArgs e)
	{
		ShowOnlineHelp(Class148.Class151.String_0);
	}

	private void mchbEnableRdpEngine_CheckedChanged(object sender, EventArgs e)
	{
		OnButtonCancel();
	}

	private void mchbEnableTrafficMonitoring_CheckedChanged(object sender, EventArgs e)
	{
		OnButtonCancel();
	}

	private void SaveSettings(object sender, EventArgs e)
	{
		OnFormClosing();
	}

	private void LoadSettings(object sender, EventArgs e)
	{
		mbtnSave.PerformClick();
	}

	private void mlnkExclusions_Click(object sender, EventArgs e)
	{
		OnLoad();
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
