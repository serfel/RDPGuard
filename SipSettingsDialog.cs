using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class SipSettingsDialog : Form0
{
	private TrafficMonitoringControl control12_0;

	private IContainer icontainer_0;

	private Class66 class66_0;

	private Class66 class66_1;

	private GControl0 gcontrol0_0;

	private Class62 class62_0;

	private PictureBox pictureBox_0;

	private Class62 class62_1;

	private GClass3 gclass3_0;

	private Class61 class61_0;

	private Class62 class62_2;

	private Panel panel_0;

	public Class124 Class124_0
	{
		get
		{
			return new Class124
			{
				bool_0 = class61_0.Checked,
				genum5_0 = control12_0.GEnum5_0,
				UInt16_0 = control12_0.UInt16_0,
				bool_1 = control12_0.bool_1,
				GClass24_0 = control12_0.gclass24_0,
				class127_0 = control12_0.class127_0
			};
		}
		set
		{
			class61_0.Checked = value.bool_0;
			control12_0.UInt16_0 = value.UInt16_0;
			control12_0.class127_0 = value.class127_0;
			control12_0.GEnum5_0 = value.genum5_0;
			control12_0.bool_1 = value.bool_1;
			control12_0.gclass24_0 = value.GClass24_0;
		}
	}

	public SipSettingsDialog(Class124 class124_0)
		: base(new Size(565, 495))
	{
		method_14();
		vmethod_1();
		InitializeControls();
		InitializeComponent();
		Class124_0 = class124_0;
		InitializeComponent();
	}

	private void InitializeControls()
	{
		control12_0 = new TrafficMonitoringControl(new Class124().UInt16_1)
		{
			String_0 = "Select monitoring method for SIP protocol:",
			String_1 = "Specify SIP port:",
			String_2 = "You can also specify multiple comma-separated ports, i.e. 5060, 5070",
			Dock = DockStyle.Fill
		};
		panel_0.Controls.Add(control12_0);
	}

	private void InitializeComponent()
	{
		gclass3_0.Click += gclass3_0_Click;
		class61_0.CheckedChanged += class61_0_CheckedChanged;
		control12_0.Event_1 += method_15;
		control12_0.Event_0 += method_16;
		class66_0.Click += class66_0_Click;
		class66_1.Click += class66_1_Click;
	}

	private void InitializeComponent()
	{
		bool flag = class61_0.Checked;
		control12_0.Enabled = flag;
		class66_0.Enabled = !flag || control12_0.Boolean_0;
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
		new ComponentResourceManager(typeof(SipSettingsDialog));
		class66_0 = new Class66();
		class66_1 = new Class66();
		gcontrol0_0 = new GControl0();
		class62_0 = new Class62();
		pictureBox_0 = new PictureBox();
		class62_1 = new Class62();
		gclass3_0 = new GClass3();
		class61_0 = new Class61();
		class62_2 = new Class62();
		panel_0 = new Panel();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		class66_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_0.Enabled = false;
		class66_0.Image = Resources.opts_16;
		class66_0.Location = new Point(318, 455);
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
		class66_1.Location = new Point(426, 455);
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
		gcontrol0_0.Size = new Size(511, 2);
		gcontrol0_0.TabIndex = 50;
		gcontrol0_0.TabStop = false;
		class62_0.AutoSize = true;
		class62_0.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		class62_0.Location = new Point(79, 15);
		class62_0.Margin = new Padding(4, 0, 4, 0);
		class62_0.Name = "m_lblCaption";
		class62_0.Size = new Size(92, 16);
		class62_0.TabIndex = 49;
		class62_0.Text = "SIP Settings";
		pictureBox_0.Image = Resources.telephone_48;
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
		class62_1.Size = new Size(205, 16);
		class62_1.TabIndex = 48;
		class62_1.Text = "Advanced SIP protection settings";
		gclass3_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		gclass3_0.AutoSize = true;
		gclass3_0.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_0.Location = new Point(454, 9);
		gclass3_0.Name = "m_lnkOnlineHelp";
		gclass3_0.Size = new Size(73, 16);
		gclass3_0.TabIndex = 9;
		gclass3_0.TabStop = true;
		gclass3_0.Text = "online help";
		gclass3_0.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		class61_0.AutoSize = true;
		class61_0.Location = new Point(16, 97);
		class61_0.Name = "m_chbEnableSipEngine";
		class61_0.Size = new Size(156, 20);
		class61_0.TabIndex = 0;
		class61_0.Text = "Enable SIP protection";
		class61_0.UseVisualStyleBackColor = true;
		class62_2.AutoSize = true;
		class62_2.ForeColor = SystemColors.ControlDarkDark;
		class62_2.Location = new Point(13, 122);
		class62_2.Name = "m_lblEnableSipProtectionHint";
		class62_2.Size = new Size(198, 16);
		class62_2.TabIndex = 58;
		class62_2.Text = "Turn on to enable SIP protection";
		panel_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		panel_0.Location = new Point(12, 154);
		panel_0.Name = "m_panel";
		panel_0.Size = new Size(515, 284);
		panel_0.TabIndex = 113;
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(539, 504);
		base.Controls.Add(panel_0);
		base.Controls.Add(class62_2);
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
		base.Name = "SipSettingsDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "SIP Settings";
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void gclass3_0_Click(object sender, EventArgs e)
	{
		method_9(Class148.Class151.String_11);
	}

	private void class61_0_CheckedChanged(object sender, EventArgs e)
	{
		InitializeComponent();
	}

	private void method_15(object sender, EventArgs e)
	{
		class66_0.Enabled = control12_0.Boolean_0;
	}

	private void method_16(object sender, EventArgs e)
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
