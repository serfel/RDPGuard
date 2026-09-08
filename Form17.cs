using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class ImapSettingsDialog : Form0
{
	private TrafficMonitoringControl control12_0;

	private ImapMonitoringViaLogsControl control11_0;

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
			Class208.smethod_0("ImapSettingsDialog::MonitoringMethod::get unknown_method");
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
			Class208.smethod_0("ImapSettingsDialog::MonitoringMethod::set unknown_method " + num);
		}
	}

	public Class116 Class116_0
	{
		get
		{
			Class116 @class = new Class116();
			@class.bool_0 = class61_0.Checked;
			@class.GEnum4_0 = GEnum4_0;
			@class.UInt16_0 = control12_0.UInt16_0;
			@class.genum5_0 = control12_0.GEnum5_0;
			@class.bool_1 = control12_0.bool_1;
			@class.GClass24_0 = control12_0.gclass24_0;
			@class.class127_0 = control12_0.class127_0;
			@class.genum8_0 = control11_0.GEnum8_0;
			@class.String_1 = new string[1] { control11_0.String_0 };
			return @class;
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
			control11_0.GEnum8_0 = value.genum8_0;
			control11_0.String_0 = value.String_1[0];
		}
	}

	public ImapSettingsDialog(Class116 class116_0)
		: base(new Size(565, 655))
	{
		method_14();
		vmethod_1();
		method_11();
		method_12();
		Class116_0 = class116_0;
		method_13();
	}

	private void method_11()
	{
		control12_0 = new TrafficMonitoringControl(new Class116().UInt16_1)
		{
			String_0 = "Select monitoring method for IMAP traffic:",
			String_1 = "Specify IMAP port:",
			String_2 = "You can also specify multiple comma-separated ports, i.e. 143, 993",
			Dock = DockStyle.Fill
		};
		panel_0.Controls.Add(control12_0);
		control11_0 = new ImapMonitoringViaLogsControl
		{
			Dock = DockStyle.Fill
		};
		panel_0.Controls.Add(control11_0);
	}

	private void method_12()
	{
		gclass3_0.Click += gclass3_0_Click;
		class61_0.CheckedChanged += class61_0_CheckedChanged;
		class64_1.CheckedChanged += class64_1_CheckedChanged;
		class64_0.CheckedChanged += class64_0_CheckedChanged;
		control12_0.Event_1 += method_15;
		control12_0.Event_0 += method_16;
		control11_0.Event_1 += method_17;
		control11_0.Event_0 += method_18;
		class66_0.Click += class66_0_Click;
		class66_1.Click += class66_1_Click;
	}

	private void method_13()
	{
		bool flag = class61_0.Checked;
		class65_0.Enabled = flag;
		control12_0.Enabled = flag && class64_1.Checked;
		control12_0.Visible = class64_1.Checked;
		control11_0.Enabled = flag && class64_0.Checked;
		control11_0.Visible = class64_0.Checked;
		if (class64_1.Checked)
		{
			class66_0.Enabled = !flag || control12_0.Boolean_0;
		}
		if (class64_0.Checked)
		{
			class66_0.Enabled = !flag || control11_0.Boolean_0;
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

	private void method_14()
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
		class66_0.Location = new Point(328, 567);
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
		class66_1.Location = new Point(436, 567);
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
		gcontrol0_0.Size = new Size(521, 2);
		gcontrol0_0.TabIndex = 50;
		gcontrol0_0.TabStop = false;
		class62_0.AutoSize = true;
		class62_0.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		class62_0.Location = new Point(79, 15);
		class62_0.Margin = new Padding(4, 0, 4, 0);
		class62_0.Name = "m_lblCaption";
		class62_0.Size = new Size(103, 16);
		class62_0.TabIndex = 49;
		class62_0.Text = "IMAP Settings";
		pictureBox_0.Image = Resources.imap_48;
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
		class62_1.Size = new Size(210, 16);
		class62_1.TabIndex = 48;
		class62_1.Text = "Configure IMAP protection settings";
		gclass3_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		gclass3_0.AutoSize = true;
		gclass3_0.LinkBehavior = LinkBehavior.NeverUnderline;
		gclass3_0.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_0.Location = new Point(464, 9);
		gclass3_0.Name = "m_lnkOnlineHelp";
		gclass3_0.Size = new Size(72, 16);
		gclass3_0.TabIndex = 9;
		gclass3_0.TabStop = true;
		gclass3_0.Text = "online help";
		gclass3_0.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		panel_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		panel_0.Location = new Point(12, 304);
		panel_0.Name = "m_panel";
		panel_0.Size = new Size(525, 256);
		panel_0.TabIndex = 111;
		panel_1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		panel_1.Controls.Add(class65_0);
		panel_1.Controls.Add(class63_2);
		panel_1.Controls.Add(class61_0);
		panel_1.Location = new Point(12, 89);
		panel_1.Name = "panel1";
		panel_1.Size = new Size(525, 209);
		panel_1.TabIndex = 112;
		class65_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		class65_0.Controls.Add(class63_0);
		class65_0.Controls.Add(class63_1);
		class65_0.Controls.Add(class64_0);
		class65_0.Controls.Add(class64_1);
		class65_0.Location = new Point(0, 61);
		class65_0.Name = "m_gbProtocolMonitoring";
		class65_0.Size = new Size(525, 145);
		class65_0.TabIndex = 113;
		class65_0.TabStop = false;
		class65_0.Text = "Select monitoring method for IMAP protocol:";
		class63_0.AutoSize = true;
		class63_0.ForeColor = SystemColors.ControlDarkDark;
		class63_0.Location = new Point(12, 55);
		class63_0.Name = "m_lblProtocolMonitoring_LogBasedHint";
		class63_0.Size = new Size(469, 16);
		class63_0.TabIndex = 113;
		class63_0.Text = "Works with particular IMAP server's logs, SSL/TLS connections are supported.";
		class63_1.AutoSize = true;
		class63_1.ForeColor = SystemColors.ControlDarkDark;
		class63_1.Location = new Point(12, 108);
		class63_1.Name = "m_lblProtocolMonitoring_TrafficBasedHint";
		class63_1.Size = new Size(420, 16);
		class63_1.TabIndex = 112;
		class63_1.Text = "Works with any IMAP Server. SSL/TLS connections are not supported.";
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
		class63_2.Name = "m_lblEnableImapProtectionHint";
		class63_2.Size = new Size(208, 16);
		class63_2.TabIndex = 112;
		class63_2.Text = "Turn on to enable IMAP protection";
		class61_0.AutoSize = true;
		class61_0.Location = new Point(4, 3);
		class61_0.Name = "m_chbEnableImapEngine";
		class61_0.Size = new Size(166, 20);
		class61_0.TabIndex = 111;
		class61_0.Text = "Enable IMAP protection";
		class61_0.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(549, 616);
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
		base.Name = "ImapSettingsDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "IMAP Settings";
		((ISupportInitialize)pictureBox_0).EndInit();
		panel_1.ResumeLayout(performLayout: false);
		panel_1.PerformLayout();
		class65_0.ResumeLayout(performLayout: false);
		class65_0.PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void gclass3_0_Click(object sender, EventArgs e)
	{
		method_9(Class148.Class151.String_5);
	}

	private void class61_0_CheckedChanged(object sender, EventArgs e)
	{
		method_13();
	}

	private void class64_1_CheckedChanged(object sender, EventArgs e)
	{
		method_13();
	}

	private void class64_0_CheckedChanged(object sender, EventArgs e)
	{
		method_13();
	}

	private void method_15(object sender, EventArgs e)
	{
		class66_0.Enabled = control12_0.Boolean_0;
	}

	private void method_16(object sender, EventArgs e)
	{
		class66_0.PerformClick();
	}

	private void method_17(object sender, EventArgs e)
	{
		class66_0.Enabled = control11_0.Boolean_0;
	}

	private void method_18(object sender, EventArgs e)
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
