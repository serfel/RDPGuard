using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class FtpSettingsDialog : Form0
{
	private TrafficMonitoringControl control12_0;

	private FtpMonitoringViaLogsControl control3_0;

	private IContainer icontainer_0;

	private Class66 class66_0;

	private Class66 class66_1;

	private GControl0 gcontrol0_0;

	private Class62 class62_0;

	private PictureBox pictureBox_0;

	private Class62 class62_1;

	private GClass3 gclass3_0;

	private Panel panel_0;

	private Panel panel_1;

	private Class65 class65_0;

	private Class63 class63_0;

	private Class63 class63_1;

	private Class64 class64_0;

	private Class64 class64_1;

	private Class63 class63_2;

	private Class61 class61_0;

	public GEnum4 GEnum4_0
	{
		get
		{
			if (class64_1.Checked)
			{
				return GEnum4.const_0;
			}
			if (class64_0.Checked)
			{
				return GEnum4.const_1;
			}
			Class208.smethod_0("FtpSettingsDialog::MonitoringMethod::get unknown_method");
			return GEnum4.const_2;
		}
		set
		{
			if (value == GEnum4.const_0)
			{
				class64_1.Checked = true;
				return;
			}
			if (GEnum4.const_1 == value)
			{
				class64_0.Checked = true;
				return;
			}
			int num = (int)value;
			Class208.smethod_0("FtpSettingsDialog::MonitoringMethod::set unknown_method " + num);
		}
	}

	public Class114 Class114_0
	{
		get
		{
			return new Class114
			{
				bool_0 = class61_0.Checked,
				GEnum4_0 = GEnum4_0,
				UInt16_0 = control12_0.UInt16_0,
				genum5_0 = control12_0.GEnum5_0,
				bool_1 = control12_0.bool_1,
				GClass24_0 = control12_0.gclass24_0,
				class127_0 = control12_0.class127_0,
				genum7_0 = control3_0.GEnum7_0,
				String_1 = control3_0.String_0
			};
		}
		set
		{
			class61_0.Checked = value.bool_0;
			GEnum4_0 = value.GEnum4_0;
			control12_0.UInt16_0 = value.UInt16_0;
			control12_0.class127_0 = value.class127_0;
			control12_0.GEnum5_0 = value.genum5_0;
			control12_0.bool_1 = value.bool_1;
			control12_0.gclass24_0 = value.GClass24_0;
			control3_0.GEnum7_0 = value.genum7_0;
			control3_0.String_0 = value.String_1;
		}
	}

	public FtpSettingsDialog(Class114 class114_0)
		: base(new Size(570, 670))
	{
		OnLoad();
		vmethod_1();
		InitializeComponents();
		OnButtonOk();
		Class114_0 = class114_0;
		OnButtonCancel();
	}

	private void InitializeComponents()
	{
		control12_0 = new TrafficMonitoringControl(new Class114().UInt16_1)
		{
			String_0 = "Select monitoring method for FTP traffic:",
			String_1 = "Specify FTP port:",
			String_2 = "You can specify multiple comma-separated ports, i.e. 21, 2121",
			Dock = DockStyle.Fill
		};
		panel_0.Controls.Add(control12_0);
		control3_0 = new FtpMonitoringViaLogsControl
		{
			Dock = DockStyle.Fill,
			eventHandler_2 = ValidateInput
		};
		panel_0.Controls.Add(control3_0);
	}

	private void OnButtonOk()
	{
		gclass3_0.Click += gclass3_0_Click;
		class61_0.CheckedChanged += class61_0_CheckedChanged;
		class64_1.CheckedChanged += class64_1_CheckedChanged;
		class64_0.CheckedChanged += class64_0_CheckedChanged;
		control12_0.Event_1 += SaveSettings;
		control12_0.Event_0 += LoadSettings;
		control3_0.Event_1 += OnTextChanged;
		control3_0.Event_0 += OnCheckedChanged;
		class66_0.Click += class66_0_Click;
		class66_1.Click += class66_1_Click;
	}

	private void OnButtonCancel()
	{
		bool flag = class61_0.Checked;
		class65_0.Enabled = flag;
		control12_0.Enabled = flag && class64_1.Checked;
		control12_0.Visible = class64_1.Checked;
		control3_0.Enabled = flag && class64_0.Checked;
		control3_0.Visible = class64_0.Checked;
		if (class64_1.Checked)
		{
			class66_0.Enabled = !flag || control12_0.Boolean_0;
		}
		if (class64_0.Checked)
		{
			class66_0.Enabled = !flag || control3_0.Boolean_0;
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
		class66_0 = new Class66();
		class66_1 = new Class66();
		gcontrol0_0 = new GControl0();
		class62_0 = new Class62();
		pictureBox_0 = new PictureBox();
		class62_1 = new Class62();
		gclass3_0 = new GClass3();
		panel_0 = new Panel();
		panel_1 = new Panel();
		class65_0 = new Class65();
		class63_0 = new Class63();
		class63_1 = new Class63();
		class64_0 = new Class64();
		class64_1 = new Class64();
		class63_2 = new Class63();
		class61_0 = new Class61();
		((ISupportInitialize)pictureBox_0).BeginInit();
		panel_1.SuspendLayout();
		class65_0.SuspendLayout();
		SuspendLayout();
		class66_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_0.Image = Resources.opts_16;
		class66_0.Location = new Point(333, 582);
		class66_0.Margin = new Padding(4);
		class66_0.Name = "m_btnSave";
		class66_0.Size = new Size(100, 36);
		class66_0.TabIndex = 7;
		class66_0.Text = "Save";
		class66_0.TextAlign = ContentAlignment.MiddleRight;
		class66_0.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_0.UseVisualStyleBackColor = true;
		class66_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_1.Image = Resources.cancl_16;
		class66_1.Location = new Point(441, 582);
		class66_1.Margin = new Padding(4);
		class66_1.Name = "m_btnCancel";
		class66_1.Size = new Size(100, 36);
		class66_1.TabIndex = 8;
		class66_1.Text = "Cancel";
		class66_1.TextAlign = ContentAlignment.MiddleRight;
		class66_1.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_1.UseVisualStyleBackColor = true;
		gcontrol0_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		gcontrol0_0.Location = new Point(16, 81);
		gcontrol0_0.Name = "separatorLine1";
		gcontrol0_0.Size = new Size(526, 2);
		gcontrol0_0.TabIndex = 50;
		gcontrol0_0.TabStop = false;
		class62_0.AutoSize = true;
		class62_0.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		class62_0.Location = new Point(79, 15);
		class62_0.Margin = new Padding(4, 0, 4, 0);
		class62_0.Name = "m_lblCaption";
		class62_0.Size = new Size(96, 16);
		class62_0.TabIndex = 49;
		class62_0.Text = "FTP Settings";
		pictureBox_0.Image = Resources.ftp_48;
		pictureBox_0.Location = new Point(16, 15);
		pictureBox_0.Margin = new Padding(4);
		pictureBox_0.Name = "m_imgBigIcon";
		pictureBox_0.Size = new Size(48, 48);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 47;
		pictureBox_0.TabStop = false;
		class62_1.AutoSize = true;
		class62_1.Location = new Point(79, 47);
		class62_1.Margin = new Padding(4, 0, 4, 0);
		class62_1.Name = "m_lblSubCaption";
		class62_1.Size = new Size(207, 16);
		class62_1.TabIndex = 48;
		class62_1.Text = "Configure FTP protection settings.";
		gclass3_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		gclass3_0.AutoSize = true;
		gclass3_0.LinkBehavior = LinkBehavior.NeverUnderline;
		gclass3_0.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_0.Location = new Point(469, 9);
		gclass3_0.Name = "m_lnkOnlineHelp";
		gclass3_0.Size = new Size(72, 16);
		gclass3_0.TabIndex = 9;
		gclass3_0.TabStop = true;
		gclass3_0.Text = "online help";
		gclass3_0.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		panel_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		panel_0.Location = new Point(12, 304);
		panel_0.Name = "m_panel";
		panel_0.Size = new Size(530, 271);
		panel_0.TabIndex = 111;
		panel_1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		panel_1.Controls.Add(class65_0);
		panel_1.Controls.Add(class63_2);
		panel_1.Controls.Add(class61_0);
		panel_1.Location = new Point(12, 89);
		panel_1.Name = "panel1";
		panel_1.Size = new Size(530, 209);
		panel_1.TabIndex = 112;
		class65_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		class65_0.Controls.Add(class63_0);
		class65_0.Controls.Add(class63_1);
		class65_0.Controls.Add(class64_0);
		class65_0.Controls.Add(class64_1);
		class65_0.Location = new Point(0, 61);
		class65_0.Name = "m_gbProtocolMonitoring";
		class65_0.Size = new Size(530, 145);
		class65_0.TabIndex = 113;
		class65_0.TabStop = false;
		class65_0.Text = "Monitoring method for FTP protocol:";
		class63_0.AutoSize = true;
		class63_0.ForeColor = SystemColors.ControlDarkDark;
		class63_0.Location = new Point(12, 55);
		class63_0.Name = "m_lblProtocolMonitoring_LogBasedHint";
		class63_0.Size = new Size(453, 16);
		class63_0.TabIndex = 113;
		class63_0.Text = "Works with particular FTP server logs, SSL/TLS connections are supported.";
		class63_1.AutoSize = true;
		class63_1.ForeColor = SystemColors.ControlDarkDark;
		class63_1.Location = new Point(12, 108);
		class63_1.Name = "m_lblProtocolMonitoring_TrafficBasedHint";
		class63_1.Size = new Size(414, 16);
		class63_1.TabIndex = 112;
		class63_1.Text = "Works with any FTP Server. SSL/TLS connections are not supported.";
		class64_0.AutoSize = true;
		class64_0.Location = new Point(15, 32);
		class64_0.Name = "m_rbProtocolMonitoring_LogBased";
		class64_0.Size = new Size(55, 20);
		class64_0.TabIndex = 111;
		class64_0.TabStop = true;
		class64_0.Text = "Logs";
		class64_0.UseVisualStyleBackColor = true;
		class64_1.AutoSize = true;
		class64_1.Location = new Point(15, 85);
		class64_1.Name = "m_rbProtocolMonitoring_TrafficBased";
		class64_1.Size = new Size(62, 20);
		class64_1.TabIndex = 110;
		class64_1.TabStop = true;
		class64_1.Text = "Traffic";
		class64_1.UseVisualStyleBackColor = true;
		class63_2.AutoSize = true;
		class63_2.ForeColor = SystemColors.ControlDarkDark;
		class63_2.Location = new Point(3, 26);
		class63_2.Name = "m_lblEnableFtpProtectionHint";
		class63_2.Size = new Size(202, 16);
		class63_2.TabIndex = 112;
		class63_2.Text = "Turn on to enable FTP protection";
		class61_0.AutoSize = true;
		class61_0.Location = new Point(4, 3);
		class61_0.Name = "m_chbEnableFtpEngine";
		class61_0.Size = new Size(160, 20);
		class61_0.TabIndex = 111;
		class61_0.Text = "Enable FTP protection";
		class61_0.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(554, 631);
		base.Controls.Add(panel_1);
		base.Controls.Add(panel_0);
		base.Controls.Add(gclass3_0);
		base.Controls.Add(gcontrol0_0);
		base.Controls.Add(class62_0);
		base.Controls.Add(class62_1);
		base.Controls.Add(pictureBox_0);
		base.Controls.Add(class66_0);
		base.Controls.Add(class66_1);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(5, 4, 5, 4);
		base.Name = "FtpSettingsDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "FTP Settings";
		((ISupportInitialize)pictureBox_0).EndInit();
		panel_1.ResumeLayout(performLayout: false);
		panel_1.PerformLayout();
		class65_0.ResumeLayout(performLayout: false);
		class65_0.PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void ValidateInput(object sender, EventArgs e)
	{
		base.Height += control3_0.Size_0.Height - panel_0.Height;
	}

	private void gclass3_0_Click(object sender, EventArgs e)
	{
		method_9(Class148.Class151.String_2);
	}

	private void class61_0_CheckedChanged(object sender, EventArgs e)
	{
		OnButtonCancel();
	}

	private void class64_1_CheckedChanged(object sender, EventArgs e)
	{
		OnButtonCancel();
	}

	private void class64_0_CheckedChanged(object sender, EventArgs e)
	{
		OnButtonCancel();
	}

	private void SaveSettings(object sender, EventArgs e)
	{
		class66_0.Enabled = control12_0.Boolean_0;
	}

	private void LoadSettings(object sender, EventArgs e)
	{
		class66_0.PerformClick();
	}

	private void OnTextChanged(object sender, EventArgs e)
	{
		class66_0.Enabled = control3_0.Boolean_0;
	}

	private void OnCheckedChanged(object sender, EventArgs e)
	{
		class66_0.PerformClick();
	}

	private void class66_0_Click(object sender, EventArgs e)
	{
		method_8(DialogResult.OK);
	}

	private void class66_1_Click(object sender, EventArgs e)
	{
		method_8(DialogResult.Cancel);
	}
}
