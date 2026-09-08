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

	private Class66 class66_0;

	private Class66 class66_1;

	private GControl0 gcontrol0_0;

	private Class62 class62_0;

	private PictureBox pictureBox_0;

	private Class62 class62_1;

	private GClass3 gclass3_0;

	private Class61 class61_0;

	private Class63 class63_0;

	private Panel panel_0;

	private Class63 class63_1;

	private Class61 class61_1;

	private GClass3 gclass3_1;

	public Class122 Class122_0
	{
		get
		{
			return new Class122
			{
				bool_0 = class61_0.Checked,
				genum5_0 = control12_0.GEnum5_0,
				UInt16_0 = control12_0.UInt16_0,
				bool_1 = control12_0.bool_1,
				GClass24_0 = control12_0.gclass24_0,
				class127_0 = control12_0.class127_0,
				Boolean_0 = class61_1.Checked,
				string_10 = string_0
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
			class61_1.Checked = value.Boolean_0;
			string_0 = value.string_10;
			OnButtonCancel();
		}
	}

	protected override Button Button_0 => class66_0;

	public RdpSettingsDialog()
		: base(new Size(565, 550))
	{
		ValidateInput();
		vmethod_1();
		InitializeComponents();
		OnButtonOk();
	}

	private void InitializeComponents()
	{
		control12_0 = new TrafficMonitoringControl(null)
		{
			String_0 = "Select monitoring method for RDP over TLS:",
			String_1 = "RDP port (leave it empty to detect automatically):",
			String_2 = "You can also specify multiple comma-separated ports, i.e. 3389, 3390",
			Dock = DockStyle.Fill
		};
		panel_0.Controls.Add(control12_0);
	}

	private void OnButtonOk()
	{
		gclass3_0.Click += gclass3_0_Click;
		class61_0.CheckedChanged += class61_0_CheckedChanged;
		class61_1.CheckedChanged += class61_1_CheckedChanged;
		control12_0.Event_1 += SaveSettings;
		control12_0.Event_0 += LoadSettings;
		gclass3_1.Click += gclass3_1_Click;
		class66_0.Click += class66_0_Click;
		class66_1.Click += class66_1_Click;
	}

	private void OnButtonCancel()
	{
		bool flag = class61_0.Checked;
		class61_1.Enabled = flag;
		class63_1.Enabled = flag;
		control12_0.Enabled = flag && class61_1.Checked;
		gclass3_1.Enabled = flag;
		vmethod_0();
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

	protected override void vmethod_0()
	{
		Button_0.Enabled = !class61_1.Checked || control12_0.Boolean_0;
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
		class66_0 = new Class66();
		class66_1 = new Class66();
		gcontrol0_0 = new GControl0();
		class62_0 = new Class62();
		pictureBox_0 = new PictureBox();
		class62_1 = new Class62();
		gclass3_0 = new GClass3();
		class61_0 = new Class61();
		class63_0 = new Class63();
		panel_0 = new Panel();
		class63_1 = new Class63();
		class61_1 = new Class61();
		gclass3_1 = new GClass3();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		class66_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_0.Enabled = false;
		class66_0.Image = Resources.opts_16;
		class66_0.Location = new Point(336, 462);
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
		class66_1.Location = new Point(444, 462);
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
		gcontrol0_0.Size = new Size(529, 2);
		gcontrol0_0.TabIndex = 50;
		gcontrol0_0.TabStop = false;
		class62_0.AutoSize = true;
		class62_0.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		class62_0.Location = new Point(79, 15);
		class62_0.Margin = new Padding(4, 0, 4, 0);
		class62_0.Name = "m_lblCaption";
		class62_0.Size = new Size(99, 16);
		class62_0.TabIndex = 49;
		class62_0.Text = "RDP Settings";
		pictureBox_0.Image = Resources.rdp_48;
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
		class62_1.Size = new Size(212, 16);
		class62_1.TabIndex = 48;
		class62_1.Text = "Advanced RDP protection settings";
		gclass3_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		gclass3_0.AutoSize = true;
		gclass3_0.LinkBehavior = LinkBehavior.NeverUnderline;
		gclass3_0.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_0.Location = new Point(472, 9);
		gclass3_0.Name = "m_lnkOnlineHelp";
		gclass3_0.Size = new Size(72, 16);
		gclass3_0.TabIndex = 9;
		gclass3_0.TabStop = true;
		gclass3_0.Text = "online help";
		gclass3_0.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		class61_0.AutoSize = true;
		class61_0.Location = new Point(16, 97);
		class61_0.Name = "m_chbEnableRdpEngine";
		class61_0.Size = new Size(163, 20);
		class61_0.TabIndex = 0;
		class61_0.Text = "Enable RDP protection";
		class61_0.UseVisualStyleBackColor = true;
		class63_0.AutoSize = true;
		class63_0.ForeColor = SystemColors.ControlDarkDark;
		class63_0.Location = new Point(13, 122);
		class63_0.Name = "m_lblEnableRdpProtectionHint";
		class63_0.Size = new Size(205, 16);
		class63_0.TabIndex = 58;
		class63_0.Text = "Turn on to enable RDP protection";
		panel_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		panel_0.Location = new Point(12, 211);
		panel_0.Name = "m_panel";
		panel_0.Size = new Size(533, 244);
		panel_0.TabIndex = 112;
		class63_1.AutoSize = true;
		class63_1.ForeColor = SystemColors.ControlDarkDark;
		class63_1.Location = new Point(13, 178);
		class63_1.Name = "m_lblEnableTrafficMonitoringHint";
		class63_1.Size = new Size(514, 16);
		class63_1.TabIndex = 114;
		class63_1.Text = "Required on Windows Server 2008, usually not needed on other versions, check help..";
		class61_1.AutoSize = true;
		class61_1.Location = new Point(16, 153);
		class61_1.Name = "m_chbEnableTrafficMonitoring";
		class61_1.Size = new Size(168, 20);
		class61_1.TabIndex = 113;
		class61_1.Text = "Enable traffic monitoring";
		class61_1.UseVisualStyleBackColor = true;
		gclass3_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		gclass3_1.AutoSize = true;
		gclass3_1.LinkBehavior = LinkBehavior.NeverUnderline;
		gclass3_1.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_1.Location = new Point(9, 482);
		gclass3_1.Name = "m_lnkExclusions";
		gclass3_1.Size = new Size(77, 16);
		gclass3_1.TabIndex = 115;
		gclass3_1.TabStop = true;
		gclass3_1.Text = "Exclusions..";
		gclass3_1.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(557, 511);
		base.Controls.Add(gclass3_1);
		base.Controls.Add(class63_1);
		base.Controls.Add(class61_1);
		base.Controls.Add(panel_0);
		base.Controls.Add(class63_0);
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
		base.Name = "RdpSettingsDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "RDP Settings";
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void gclass3_0_Click(object sender, EventArgs e)
	{
		method_9(Class148.Class151.String_0);
	}

	private void class61_0_CheckedChanged(object sender, EventArgs e)
	{
		OnButtonCancel();
	}

	private void class61_1_CheckedChanged(object sender, EventArgs e)
	{
		OnButtonCancel();
	}

	private void SaveSettings(object sender, EventArgs e)
	{
		vmethod_0();
	}

	private void LoadSettings(object sender, EventArgs e)
	{
		class66_0.PerformClick();
	}

	private void gclass3_1_Click(object sender, EventArgs e)
	{
		OnLoad();
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
