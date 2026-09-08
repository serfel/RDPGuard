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
			Class208.smethod_0("Pop3SettingsDialog::MonitoringMethod::get unknown_method");
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
			Class208.smethod_0("Pop3SettingsDialog::MonitoringMethod::set unknown_method " + num);
		}
	}

	public Class121 Class121_0
	{
		get
		{
			Class121 @class = new Class121();
			@class.bool_0 = class61_0.Checked;
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
			class61_0.Checked = value.bool_0;
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
		InitializeComponent();
		vmethod_1();
		InitializeControls();
		WireUpEvents();
		Class121_0 = class121_0;
	}

	private void InitializeControls()
	{
		control12_0 = new TrafficMonitoringControl(new Class121().UInt16_1)
		{
			String_0 = "Select monitoring method for POP3 traffic:",
			String_1 = "Specify POP3 port:",
			String_2 = "You can specify multiple comma-separated ports, i.e. 110, 995",
			Dock = DockStyle.Fill
		};
		panel_0.Controls.Add(control12_0);
		control10_0 = new Pop3MonitoringViaLogsControl
		{
			Dock = DockStyle.Fill
		};
		panel_0.Controls.Add(control10_0);
	}

	private void WireUpEvents()
	{
		gclass3_0.Click += gclass3_0_Click;
		class61_0.CheckedChanged += EnablePop3Engine_CheckedChanged;
		class64_1.CheckedChanged += ProtocolMonitoring_TrafficBased_CheckedChanged;
		class64_0.CheckedChanged += ProtocolMonitoring_LogBased_CheckedChanged;
		control12_0.Event_1 += TrafficMonitoringControl_Event_1;
		control12_0.Event_0 += TrafficMonitoringControl_Event_0;
		control10_0.Event_1 += Pop3MonitoringViaLogsControl_Event_1;
		control10_0.Event_0 += Pop3MonitoringViaLogsControl_Event_0;
		class66_0.Click += btnSave_Click;
		class66_1.Click += btnCancel_Click;
	}

	private void UpdateEnabledState()
	{
		bool flag = class61_0.Checked;
		class65_0.Enabled = flag;
		control12_0.Enabled = flag && class64_1.Checked;
		control12_0.Visible = class64_1.Checked;
		control10_0.Enabled = flag && class64_0.Checked;
		control10_0.Visible = class64_0.Checked;
		if (class64_1.Checked)
		{
			class66_0.Enabled = !flag || control12_0.Boolean_0;
		}
		if (class64_0.Checked)
		{
			class66_0.Enabled = !flag || control10_0.Boolean_0;
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

	private void InitializeComponent()
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
		class66_0.Text = "Сохранить";
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
		class66_1.Text = "Отмена";
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
		class62_0.Size = new Size(106, 16);
		class62_0.TabIndex = 49;
		class62_0.Text = "Настройки POP3";
		pictureBox_0.Image = Resources.pop3_48;
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
		class62_1.Size = new Size(213, 16);
		class62_1.TabIndex = 48;
		class62_1.Text = "Настройка защиты POP3";
		gclass3_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		gclass3_0.AutoSize = true;
		gclass3_0.LinkBehavior = LinkBehavior.NeverUnderline;
		gclass3_0.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_0.Location = new Point(464, 9);
		gclass3_0.Name = "m_lnkOnlineHelp";
		gclass3_0.Size = new Size(72, 16);
		gclass3_0.TabIndex = 9;
		gclass3_0.TabStop = true;
		gclass3_0.Text = "онлайн помощь";
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
		class65_0.Text = "Выберите метод мониторинга протокола POP3:";
		class63_0.AutoSize = true;
		class63_0.ForeColor = SystemColors.ControlDarkDark;
		class63_0.Location = new Point(12, 55);
		class63_0.Name = "m_lblProtocolMonitoring_LogBasedHint";
		class63_0.Size = new Size(472, 16);
		class63_0.TabIndex = 113;
		class63_0.Text = "Работает с логами конкретного POP3 сервера, поддерживаются SSL/TLS соединения.";
		class63_1.AutoSize = true;
		class63_1.ForeColor = SystemColors.ControlDarkDark;
		class63_1.Location = new Point(12, 108);
		class63_1.Name = "m_lblProtocolMonitoring_TrafficBasedHint";
		class63_1.Size = new Size(423, 16);
		class63_1.TabIndex = 112;
		class63_1.Text = "Работает с любым POP3 сервером. SSL/TLS соединения не поддерживаются.";
		class64_0.AutoSize = true;
		class64_0.Location = new Point(15, 32);
		class64_0.Name = "m_rbProtocolMonitoring_LogBased";
		class64_0.Size = new Size(55, 20);
		class64_0.TabIndex = 111;
		class64_0.TabStop = true;
		class64_0.Text = "Логи";
		class64_0.UseVisualStyleBackColor = true;
		class64_1.AutoSize = true;
		class64_1.Location = new Point(15, 85);
		class64_1.Name = "m_rbProtocolMonitoring_TrafficBased";
		class64_1.Size = new Size(62, 20);
		class64_1.TabIndex = 110;
		class64_1.TabStop = true;
		class64_1.Text = "Трафик";
		class64_1.UseVisualStyleBackColor = true;
		class63_2.AutoSize = true;
		class63_2.ForeColor = SystemColors.ControlDarkDark;
		class63_2.Location = new Point(3, 26);
		class63_2.Name = "m_lblEnablePop3ProtectionHint";
		class63_2.Size = new Size(211, 16);
		class63_2.TabIndex = 112;
		class63_2.Text = "Включите для активации защиты POP3";
		class61_0.AutoSize = true;
		class61_0.Location = new Point(4, 3);
		class61_0.Name = "m_chbEnablePop3Engine";
		class61_0.Size = new Size(169, 20);
		class61_0.TabIndex = 111;
		class61_0.Text = "Включить защиту POP3";
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
		base.Name = "Pop3SettingsDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "Настройки POP3";
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
		method_9(Class148.Class151.String_6);
	}

	private void EnablePop3Engine_CheckedChanged(object sender, EventArgs e)
	{
		UpdateEnabledState();
	}

	private void ProtocolMonitoring_TrafficBased_CheckedChanged(object sender, EventArgs e)
	{
		UpdateEnabledState();
	}

	private void ProtocolMonitoring_LogBased_CheckedChanged(object sender, EventArgs e)
	{
		UpdateEnabledState();
	}

	private void TrafficMonitoringControl_Event_1(object sender, EventArgs e)
	{
		class66_0.Enabled = control12_0.Boolean_0;
	}

	private void TrafficMonitoringControl_Event_0(object sender, EventArgs e)
	{
		class66_0.PerformClick();
	}

	private void Pop3MonitoringViaLogsControl_Event_1(object sender, EventArgs e)
	{
		class66_0.Enabled = control10_0.Boolean_0;
	}

	private void Pop3MonitoringViaLogsControl_Event_0(object sender, EventArgs e)
	{
		class66_0.PerformClick();
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		method_8(DialogResult.OK);
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		method_8(DialogResult.Cancel);
	}
}
