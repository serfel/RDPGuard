using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Properties;

internal sealed class MySqlSettingsDialog : Form0
{
	private IContainer icontainer_0;

	private Class66 class66_0;

	private Class66 class66_1;

	private GControl0 gcontrol0_0;

	private Class62 class62_0;

	private PictureBox pictureBox_0;

	private Class62 class62_1;

	private GClass3 gclass3_0;

	private Class61 class61_0;

	private Class61 class61_1;

	private Class63 class63_0;

	private Class63 class63_1;

	private Class54 class54_0;

	private Class62 class62_2;

	private Class63 class63_2;

	private Class63 class63_3;

	private Class62 class62_3;

	private Class54 class54_1;

	private Class63 class63_4;

	private Class61 class61_2;

	private Class63 class63_5;

	private Class63 class63_6;

	private Class64 class64_0;

	private Class64 class64_1;

	private Class62 class62_4;

	private GEnum9 GEnum9_0
	{
		get
		{
			if (class64_1.Checked)
			{
				return GEnum9.const_1;
			}
			if (!class64_0.Checked)
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
				class64_1.Checked = true;
				class64_0.Checked = false;
				break;
			case GEnum9.const_0:
				class64_1.Checked = false;
				class64_0.Checked = true;
				break;
			}
		}
	}

	public Class119 Class119_0
	{
		get
		{
			Class119 @class = new Class119();
			@class.bool_0 = class61_0.Checked;
			@class.genum9_0 = GEnum9_0;
			@class.bool_3 = class61_1.Checked;
			@class.bool_2 = class61_2.Checked;
			@class.string_10 = class54_0.Text;
			@class.String_1 = new string[1] { class54_1.Text };
			return @class;
		}
		set
		{
			class61_0.Checked = value.bool_0;
			GEnum9_0 = value.genum9_0;
			class61_1.Checked = value.bool_3;
			class61_2.Checked = value.bool_2;
			class54_0.Text = value.string_10;
			class54_1.Text = value.String_1[0];
			method_14();
		}
	}

	public MySqlSettingsDialog(Class119 class119_0)
		: base(new Size(595, 680))
	{
		method_15();
		vmethod_1();
		method_11();
		method_12();
		Class119_0 = class119_0;
	}

	private void method_11()
	{
		class54_0.String_0 = "Click to specify MySQL config file location";
		class54_0.String_2 = "MySQL Config Files|my.ini; my.cnf";
		class54_1.String_0 = "Click to specify MySQL general log file location";
		class54_1.String_2 = "MySQL General Log File|*.*";
		string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "MySQL");
		if (Directory.Exists(text))
		{
			class54_0.String_1 = text;
			class54_1.String_1 = text;
		}
	}

	private void method_12()
	{
		gclass3_0.Click += gclass3_0_Click;
		class61_0.CheckedChanged += class61_0_CheckedChanged;
		class64_1.CheckedChanged += class64_1_CheckedChanged;
		class64_0.CheckedChanged += class64_0_CheckedChanged;
		class61_1.CheckedChanged += class61_1_CheckedChanged;
		class61_2.CheckedChanged += class61_2_CheckedChanged;
		class54_0.TextChanged += class54_0_TextChanged;
		class54_1.TextChanged += class54_1_TextChanged;
		class66_0.Click += class66_0_Click;
		class66_1.Click += class66_1_Click;
	}

	private void method_13()
	{
		bool flag = true;
		if (class61_0.Checked)
		{
			if (!class61_1.Checked)
			{
				flag &= !string.IsNullOrEmpty(class54_0.Text);
			}
			if (!class61_2.Checked)
			{
				flag &= !string.IsNullOrEmpty(class54_1.Text);
			}
		}
		class66_0.Enabled = flag;
	}

	private void method_14()
	{
		bool flag = class61_0.Checked;
		class62_4.Enabled = flag;
		class64_1.Enabled = flag;
		class63_6.Enabled = flag;
		class64_0.Enabled = flag;
		class63_5.Enabled = flag;
		bool flag2 = class64_0.Checked;
		class61_1.Enabled = flag && flag2;
		class63_1.Enabled = flag && flag2;
		bool flag3 = class61_1.Checked;
		class62_2.Enabled = flag && flag2 && !flag3;
		class54_0.Enabled = flag && flag2 && !flag3;
		class63_2.Enabled = flag && flag2 && !flag3;
		class61_2.Enabled = flag && flag2;
		class63_4.Enabled = flag && flag2;
		bool flag4 = class61_2.Checked;
		class62_3.Enabled = flag && flag2 && !flag4;
		class54_1.Enabled = flag && flag2 && !flag4;
		class63_3.Enabled = flag && flag2 && !flag4;
		method_13();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_15()
	{
		icontainer_0 = new Container();
		class66_0 = new Class66();
		class66_1 = new Class66();
		gcontrol0_0 = new GControl0();
		class62_0 = new Class62();
		pictureBox_0 = new PictureBox();
		class62_1 = new Class62();
		gclass3_0 = new GClass3();
		class61_0 = new Class61();
		class61_1 = new Class61();
		class63_0 = new Class63();
		class63_1 = new Class63();
		class54_0 = new Class54();
		class62_2 = new Class62();
		class63_2 = new Class63();
		class63_3 = new Class63();
		class62_3 = new Class62();
		class54_1 = new Class54();
		class63_4 = new Class63();
		class61_2 = new Class61();
		class63_5 = new Class63();
		class63_6 = new Class63();
		class64_0 = new Class64();
		class64_1 = new Class64();
		class62_4 = new Class63();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		class66_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_0.Image = Resources.opts_16;
		class66_0.Location = new Point(358, 593);
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
		class66_1.Location = new Point(466, 593);
		class66_1.Margin = new Padding(4);
		class66_1.Name = "btnCancel";
		class66_1.Size = new Size(100, 36);
		class66_1.TabIndex = 8;
		class66_1.Text = "Cancel";
		class66_1.TextAlign = ContentAlignment.MiddleRight;
		class66_1.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_1.UseVisualStyleBackColor = true;
		gcontrol0_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		gcontrol0_0.Location = new Point(16, 81);
		gcontrol0_0.Name = "separatorLine1";
		gcontrol0_0.Size = new Size(551, 2);
		gcontrol0_0.TabIndex = 50;
		gcontrol0_0.TabStop = false;
		class62_0.AutoSize = true;
		class62_0.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		class62_0.Location = new Point(79, 15);
		class62_0.Margin = new Padding(4, 0, 4, 0);
		class62_0.Name = "label2";
		class62_0.Size = new Size(116, 16);
		class62_0.TabIndex = 49;
		class62_0.Text = "MySQL Settings";
		pictureBox_0.Image = Resources.mysql_logo_48;
		pictureBox_0.Location = new Point(16, 15);
		pictureBox_0.Margin = new Padding(4);
		pictureBox_0.Name = "imgBigIcon";
		pictureBox_0.Size = new Size(48, 45);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 47;
		pictureBox_0.TabStop = false;
		class62_1.AutoSize = true;
		class62_1.Location = new Point(79, 47);
		class62_1.Margin = new Padding(4, 0, 4, 0);
		class62_1.Name = "lblCaption";
		class62_1.Size = new Size(227, 16);
		class62_1.TabIndex = 48;
		class62_1.Text = "Advanced MySQL protection settings";
		gclass3_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		gclass3_0.AutoSize = true;
		gclass3_0.LinkBehavior = LinkBehavior.NeverUnderline;
		gclass3_0.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_0.Location = new Point(494, 9);
		gclass3_0.Name = "m_lnkOnlineHelp";
		gclass3_0.Size = new Size(72, 16);
		gclass3_0.TabIndex = 9;
		gclass3_0.TabStop = true;
		gclass3_0.Text = "online help";
		gclass3_0.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		class61_0.AutoSize = true;
		class61_0.Location = new Point(16, 97);
		class61_0.Name = "m_chbEnableMySqlEngine";
		class61_0.Size = new Size(178, 20);
		class61_0.TabIndex = 0;
		class61_0.Text = "Enable MySQL protection";
		class61_0.UseVisualStyleBackColor = true;
		class61_1.AutoSize = true;
		class61_1.Location = new Point(16, 294);
		class61_1.Name = "m_chbAutomaticConfigLocation";
		class61_1.Size = new Size(255, 20);
		class61_1.TabIndex = 3;
		class61_1.Text = "Automatically detect config file location";
		class61_1.UseVisualStyleBackColor = true;
		class63_0.AutoSize = true;
		class63_0.ForeColor = SystemColors.ControlDarkDark;
		class63_0.Location = new Point(13, 122);
		class63_0.Name = "m_lblEnableMySqlProtectionHInt";
		class63_0.Size = new Size(220, 16);
		class63_0.TabIndex = 58;
		class63_0.Text = "Turn on to enable MySQL protection";
		class63_1.AutoSize = true;
		class63_1.ForeColor = SystemColors.ControlDarkDark;
		class63_1.Location = new Point(13, 319);
		class63_1.Name = "m_lblAutomaticConfigLocationHint";
		class63_1.Size = new Size(349, 16);
		class63_1.TabIndex = 59;
		class63_1.Text = "RdpGuard will detect my.ini (my.cnf) location automatically";
		class54_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		class54_0.Enabled = false;
		class54_0.String_1 = null;
		class54_0.Location = new Point(23, 380);
		class54_0.Name = "m_edConfigFileLocation";
		class54_0.Size = new Size(543, 22);
		class54_0.TabIndex = 4;
		class62_2.AutoSize = true;
		class62_2.Enabled = false;
		class62_2.Location = new Point(13, 354);
		class62_2.Name = "m_lblConfigFileLocation";
		class62_2.Size = new Size(118, 16);
		class62_2.TabIndex = 61;
		class62_2.Text = "Config file location:";
		class63_2.AutoSize = true;
		class63_2.Enabled = false;
		class63_2.ForeColor = SystemColors.ControlDarkDark;
		class63_2.Location = new Point(20, 405);
		class63_2.Name = "m_lblConfigFileLocationHint";
		class63_2.Size = new Size(313, 16);
		class63_2.TabIndex = 62;
		class63_2.Text = "You can specify location of my.ini (my.cnf) manually";
		class63_3.AutoSize = true;
		class63_3.Enabled = false;
		class63_3.ForeColor = SystemColors.ControlDarkDark;
		class63_3.Location = new Point(20, 551);
		class63_3.Name = "m_lblLogFileLocationHint";
		class63_3.Size = new Size(526, 16);
		class63_3.TabIndex = 68;
		class63_3.Text = "You can specify location of general log file manually. General logging must be enabled.";
		class62_3.AutoSize = true;
		class62_3.Enabled = false;
		class62_3.Location = new Point(13, 500);
		class62_3.Name = "m_lblLogFileLocation";
		class62_3.Size = new Size(150, 16);
		class62_3.TabIndex = 67;
		class62_3.Text = "General log file location:";
		class54_1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		class54_1.Enabled = false;
		class54_1.String_1 = null;
		class54_1.Location = new Point(23, 526);
		class54_1.Name = "m_edLogFileLocation";
		class54_1.Size = new Size(543, 22);
		class54_1.TabIndex = 6;
		class63_4.AutoSize = true;
		class63_4.ForeColor = SystemColors.ControlDarkDark;
		class63_4.Location = new Point(13, 465);
		class63_4.Name = "m_lblAutomaticLogFileLocationHint";
		class63_4.Size = new Size(354, 16);
		class63_4.TabIndex = 65;
		class63_4.Text = "RdpGuard will detect general log file location automatically";
		class61_2.AutoSize = true;
		class61_2.Location = new Point(16, 440);
		class61_2.Name = "m_chbAutomaticLogFileLocation";
		class61_2.Size = new Size(287, 20);
		class61_2.TabIndex = 5;
		class61_2.Text = "Automatically detect general log file location";
		class61_2.UseVisualStyleBackColor = true;
		class63_5.AutoSize = true;
		class63_5.Enabled = false;
		class63_5.ForeColor = SystemColors.ControlDarkDark;
		class63_5.Location = new Point(25, 260);
		class63_5.Name = "m_lblMonitoringViaGeneralLogHint";
		class63_5.Size = new Size(480, 16);
		class63_5.TabIndex = 86;
		class63_5.Text = "Works with all MySQL editions. May work slow on heavy loaded MySQL servers.";
		class63_6.AutoSize = true;
		class63_6.Enabled = false;
		class63_6.ForeColor = SystemColors.ControlDarkDark;
		class63_6.Location = new Point(25, 207);
		class63_6.Name = "m_lblMonitoringViaApplicationEventLogHint";
		class63_6.Size = new Size(529, 16);
		class63_6.TabIndex = 85;
		class63_6.Text = "Works with MySQL 5.7 and higher. Faster and less resource consuming. Recommended.";
		class64_0.AutoSize = true;
		class64_0.Enabled = false;
		class64_0.Location = new Point(28, 235);
		class64_0.Name = "m_rbMonitoringViaGeneralLog";
		class64_0.Size = new Size(146, 20);
		class64_0.TabIndex = 2;
		class64_0.TabStop = true;
		class64_0.Text = "MySQL General Log";
		class64_0.UseVisualStyleBackColor = true;
		class64_1.AutoSize = true;
		class64_1.Enabled = false;
		class64_1.Location = new Point(28, 182);
		class64_1.Name = "m_rbMonitoringViaApplicationEventLog";
		class64_1.Size = new Size(155, 20);
		class64_1.TabIndex = 1;
		class64_1.TabStop = true;
		class64_1.Text = "Application Event Log";
		class64_1.UseVisualStyleBackColor = true;
		class62_4.AutoSize = true;
		class62_4.Enabled = false;
		class62_4.Location = new Point(13, 154);
		class62_4.Name = "m_lblSelectMonitoringMethod";
		class62_4.Size = new Size(158, 16);
		class62_4.TabIndex = 82;
		class62_4.Text = "Select monitoring method";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(579, 642);
		base.Controls.Add(class63_5);
		base.Controls.Add(class63_6);
		base.Controls.Add(class64_0);
		base.Controls.Add(class64_1);
		base.Controls.Add(class62_4);
		base.Controls.Add(class63_3);
		base.Controls.Add(class62_3);
		base.Controls.Add(class54_1);
		base.Controls.Add(class63_4);
		base.Controls.Add(class61_2);
		base.Controls.Add(class63_2);
		base.Controls.Add(class62_2);
		base.Controls.Add(class54_0);
		base.Controls.Add(class63_1);
		base.Controls.Add(class63_0);
		base.Controls.Add(class61_1);
		base.Controls.Add(class61_0);
		base.Controls.Add(gclass3_0);
		base.Controls.Add(gcontrol0_0);
		base.Controls.Add(class62_0);
		base.Controls.Add(class62_1);
		base.Controls.Add(pictureBox_0);
		base.Controls.Add(class66_0);
		base.Controls.Add(class66_1);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(5, 4, 5, 4);
		base.Name = "MySqlSettingsDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "MySQL Settings";
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void gclass3_0_Click(object sender, EventArgs e)
	{
		method_9(Class148.Class151.String_8);
	}

	private void class61_0_CheckedChanged(object sender, EventArgs e)
	{
		method_14();
	}

	private void class64_1_CheckedChanged(object sender, EventArgs e)
	{
		method_14();
	}

	private void class64_0_CheckedChanged(object sender, EventArgs e)
	{
		method_14();
	}

	private void class61_1_CheckedChanged(object sender, EventArgs e)
	{
		method_14();
		method_13();
	}

	private void class61_2_CheckedChanged(object sender, EventArgs e)
	{
		method_14();
		method_13();
	}

	private void class54_0_TextChanged(object sender, EventArgs e)
	{
		method_13();
	}

	private void class54_1_TextChanged(object sender, EventArgs e)
	{
		method_13();
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
