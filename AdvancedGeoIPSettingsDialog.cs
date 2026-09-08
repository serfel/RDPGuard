using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;
using rdpguard.lib;

internal sealed class AdvancedGeoIPSettingsDialog : Form0
{
	private static Size size_0 = new Size(580, 485);

	private static Size size_1 = new Size(580, 810);

	private IContainer icontainer_0;

	private Class66 class66_0;

	private GControl0 gcontrol0_0;

	private Class62 class62_0;

	private PictureBox pictureBox_0;

	private Class62 class62_1;

	private GClass3 gclass3_0;

	private Control14 control14_0;

	private TabPage tabPage_0;

	private TabPage tabPage_1;

	private TabPage tabPage_2;

	private Class65 class65_0;

	private Class63 class63_0;

	private Class61 class61_0;

	private Class63 class63_1;

	private Class61 class61_1;

	private Class63 class63_2;

	private Class61 class61_2;

	private Class63 class63_3;

	private Class61 class61_3;

	private Class65 class65_1;

	private Class64 class64_0;

	private Class64 class64_1;

	private Class65 class65_2;

	private Class64 class64_2;

	private Class64 class64_3;

	private Class63 class63_4;

	private Class63 class63_5;

	private TextBox textBox_0;

	private Class63 class63_6;

	private Class64 class64_4;

	private TextBox textBox_1;

	private Class65 class65_3;

	private TextBox textBox_2;

	private Class63 class63_7;

	private Class63 class63_8;

	private Class64 class64_5;

	private Class64 class64_6;

	private Class65 class65_4;

	private TextBox textBox_3;

	private Class63 class63_9;

	private Class63 class63_10;

	private Class64 class64_7;

	private Class64 class64_8;

	private Class3 Class3_0 => new Class3(class64_1, class64_0, textBox_1, class64_4, textBox_0);

	public GClass7 GClass7_0
	{
		get
		{
			return Class3_0.method_1();
		}
		set
		{
			Class3_0.method_2(value);
		}
	}

	private Class3 Class3_1 => new Class3(class64_6, null, null, class64_5, textBox_2);

	public GClass7 GClass7_1
	{
		get
		{
			return Class3_1.method_1();
		}
		set
		{
			Class3_1.method_2(value);
		}
	}

	private Class3 Class3_2 => new Class3(class64_8, class64_7, textBox_3, null, null);

	public GClass7 GClass7_2
	{
		get
		{
			return Class3_2.method_1();
		}
		set
		{
			Class3_2.method_2(value);
		}
	}

	public bool Boolean_0
	{
		get
		{
			return class61_3.Checked;
		}
		set
		{
			class61_3.Checked = value;
		}
	}

	public bool Boolean_1
	{
		get
		{
			return class61_2.Checked;
		}
		set
		{
			class61_2.Checked = value;
		}
	}

	public bool Boolean_2
	{
		get
		{
			return class61_1.Checked;
		}
		set
		{
			class61_1.Checked = value;
		}
	}

	public bool Boolean_3
	{
		get
		{
			return class61_0.Checked;
		}
		set
		{
			class61_0.Checked = value;
		}
	}

	public GeoIPDBVersion GeoIPDBVersion_0
	{
		get
		{
			if (class64_3.Checked)
			{
				return GeoIPDBVersion.Lite;
			}
			if (class64_2.Checked)
			{
				return GeoIPDBVersion.Max;
			}
			Class208.smethod_0("AdvancedGeoIPSettingsDialog::Version::get:unknown_db_version");
			return GeoIPDBVersion.Unknown;
		}
		set
		{
			if (value == GeoIPDBVersion.Lite)
			{
				class64_3.Checked = true;
			}
			else if (GeoIPDBVersion.Max == value)
			{
				class64_2.Checked = true;
			}
			else
			{
				Class208.smethod_0("AdvancedGeoIPSettingsDialog::Version::set:unknown_db_version");
			}
		}
	}

	public AdvancedGeoIPSettingsDialog()
		: base(size_0)
	{
		OnLoad();
		vmethod_1();
		InitializeComponents();
		OnButtonOk();
	}

	private void InitializeComponents()
	{
		MinimumSize = size_0;
		base.Size = size_0;
		class64_2.Enabled = !Class178.Boolean_0;
		pictureBox_0.Image = ((Class163.Class163_0.Boolean_0 ? true : false) ? Resources.location_pin_settings_48_dark : Resources.location_pin_settings_48);
	}

	private void OnButtonOk()
	{
		gclass3_0.Click += gclass3_0_Click;
		control14_0.SelectedIndexChanged += control14_0_SelectedIndexChanged;
		Class3 class3_ = Class3_0;
		class3_.eventHandler_0 = (EventHandler<EventArgs>)Delegate.Combine(class3_.eventHandler_0, new EventHandler<EventArgs>(ValidateInput));
		Class3 class3_2 = Class3_1;
		class3_2.eventHandler_0 = (EventHandler<EventArgs>)Delegate.Combine(class3_2.eventHandler_0, new EventHandler<EventArgs>(SaveSettings));
		Class3 class3_3 = Class3_2;
		class3_3.eventHandler_0 = (EventHandler<EventArgs>)Delegate.Combine(class3_3.eventHandler_0, new EventHandler<EventArgs>(LoadSettings));
		class66_0.Click += class66_0_Click;
	}

	private void OnButtonCancel()
	{
		class66_0.Enabled = Class3_0.method_1().Boolean_0 && Class3_1.method_1().Boolean_0 && Class3_2.method_1().Boolean_0;
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
		class66_0 = new Class66();
		gcontrol0_0 = new GControl0();
		class62_0 = new Class62();
		pictureBox_0 = new PictureBox();
		class62_1 = new Class62();
		gclass3_0 = new GClass3();
		control14_0 = new Control14();
		tabPage_0 = new TabPage();
		class65_1 = new Class65();
		textBox_0 = new TextBox();
		class63_6 = new Class63();
		class64_4 = new Class64();
		textBox_1 = new TextBox();
		class63_4 = new Class63();
		class63_5 = new Class63();
		class64_0 = new Class64();
		class64_1 = new Class64();
		tabPage_1 = new TabPage();
		class65_4 = new Class65();
		textBox_3 = new TextBox();
		class63_9 = new Class63();
		class63_10 = new Class63();
		class64_7 = new Class64();
		class64_8 = new Class64();
		class65_3 = new Class65();
		textBox_2 = new TextBox();
		class63_7 = new Class63();
		class63_8 = new Class63();
		class64_5 = new Class64();
		class64_6 = new Class64();
		class65_0 = new Class65();
		class63_0 = new Class63();
		class61_0 = new Class61();
		class63_1 = new Class63();
		class61_1 = new Class61();
		class63_2 = new Class63();
		class61_2 = new Class61();
		class63_3 = new Class63();
		class61_3 = new Class61();
		tabPage_2 = new TabPage();
		class65_2 = new Class65();
		class64_2 = new Class64();
		class64_3 = new Class64();
		((ISupportInitialize)pictureBox_0).BeginInit();
		control14_0.SuspendLayout();
		tabPage_0.SuspendLayout();
		class65_1.SuspendLayout();
		tabPage_1.SuspendLayout();
		class65_4.SuspendLayout();
		class65_3.SuspendLayout();
		class65_0.SuspendLayout();
		tabPage_2.SuspendLayout();
		class65_2.SuspendLayout();
		SuspendLayout();
		class66_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_0.Image = Resources.opts_16;
		class66_0.Location = new Point(451, 722);
		class66_0.Margin = new Padding(4);
		class66_0.Name = "m_btnClose";
		class66_0.Size = new Size(100, 36);
		class66_0.TabIndex = 7;
		class66_0.Text = "Close";
		class66_0.TextAlign = ContentAlignment.MiddleRight;
		class66_0.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_0.UseVisualStyleBackColor = false;
		gcontrol0_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		gcontrol0_0.Location = new Point(16, 81);
		gcontrol0_0.Name = "separatorLine1";
		gcontrol0_0.Size = new Size(532, 2);
		gcontrol0_0.TabIndex = 50;
		gcontrol0_0.TabStop = false;
		class62_0.AutoSize = true;
		class62_0.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		class62_0.Location = new Point(79, 15);
		class62_0.Margin = new Padding(4, 0, 4, 0);
		class62_0.Name = "m_lblCaption";
		class62_0.Size = new Size(115, 16);
		class62_0.TabIndex = 49;
		class62_0.Text = "Geo-IP Settings";
		class62_0.Boolean_0 = false;
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
		class62_1.Size = new Size(163, 16);
		class62_1.TabIndex = 48;
		class62_1.Text = "Advanced Geo-IP settings";
		class62_1.Boolean_0 = false;
		gclass3_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		gclass3_0.AutoSize = true;
		gclass3_0.LinkBehavior = LinkBehavior.NeverUnderline;
		gclass3_0.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_0.Location = new Point(476, 9);
		gclass3_0.Name = "m_lnkOnlineHelp";
		gclass3_0.Size = new Size(72, 16);
		gclass3_0.TabIndex = 9;
		gclass3_0.TabStop = true;
		gclass3_0.Text = "online help";
		gclass3_0.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		control14_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		control14_0.Controls.Add(tabPage_0);
		control14_0.Controls.Add(tabPage_1);
		control14_0.Controls.Add(tabPage_2);
		control14_0.Location = new Point(16, 97);
		control14_0.Name = "m_tabMain";
		control14_0.SelectedIndex = 0;
		control14_0.Size = new Size(536, 618);
		control14_0.TabIndex = 57;
		tabPage_0.Controls.Add(class65_1);
		tabPage_0.Location = new Point(4, 25);
		tabPage_0.Name = "m_tpDenyMode";
		tabPage_0.Padding = new Padding(3);
		tabPage_0.Size = new Size(528, 589);
		tabPage_0.TabIndex = 0;
		tabPage_0.Text = "Deny Mode";
		class65_1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		class65_1.Controls.Add(textBox_0);
		class65_1.Controls.Add(class63_6);
		class65_1.Controls.Add(class64_4);
		class65_1.Controls.Add(textBox_1);
		class65_1.Controls.Add(class63_4);
		class65_1.Controls.Add(class63_5);
		class65_1.Controls.Add(class64_0);
		class65_1.Controls.Add(class64_1);
		class65_1.Location = new Point(6, 6);
		class65_1.Name = "m_gbDenyModeScope";
		class65_1.Size = new Size(516, 247);
		class65_1.TabIndex = 53;
		class65_1.TabStop = false;
		class65_1.Text = "Blocking scope:";
		textBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		textBox_0.Enabled = false;
		textBox_0.Location = new Point(36, 209);
		textBox_0.Name = "m_edDenyModeSelectedOnlyPorts";
		textBox_0.Size = new Size(474, 22);
		textBox_0.TabIndex = 63;
		class63_6.AutoSize = true;
		class63_6.ForeColor = SystemColors.ControlDarkDark;
		class63_6.Location = new Point(33, 186);
		class63_6.Name = "m_txtDenyModeSelectedOnlyHint";
		class63_6.Size = new Size(394, 16);
		class63_6.TabIndex = 62;
		class63_6.Text = "Deny access from blocked countries only to the ports listed below";
		class63_6.Boolean_0 = false;
		class64_4.AutoSize = true;
		class64_4.Location = new Point(17, 163);
		class64_4.Name = "m_rbDenyModeSelectedOnly";
		class64_4.Size = new Size(175, 20);
		class64_4.TabIndex = 61;
		class64_4.TabStop = true;
		class64_4.Text = "Block selected ports only";
		class64_4.UseVisualStyleBackColor = false;
		textBox_1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		textBox_1.Enabled = false;
		textBox_1.Location = new Point(36, 125);
		textBox_1.Name = "m_edDenyModeAllExceptSelectedPorts";
		textBox_1.Size = new Size(474, 22);
		textBox_1.TabIndex = 60;
		class63_4.AutoSize = true;
		class63_4.ForeColor = SystemColors.ControlDarkDark;
		class63_4.Location = new Point(33, 102);
		class63_4.Name = "m_txtDenyModeAllExceptSelectedHint";
		class63_4.Size = new Size(441, 16);
		class63_4.TabIndex = 59;
		class63_4.Text = "Deny access from blocked countries to all ports except those listed below";
		class63_4.Boolean_0 = false;
		class63_5.AutoSize = true;
		class63_5.ForeColor = SystemColors.ControlDarkDark;
		class63_5.Location = new Point(33, 47);
		class63_5.Name = "m_txtDenyModeAllPortsHint";
		class63_5.Size = new Size(288, 16);
		class63_5.TabIndex = 58;
		class63_5.Text = "Deny access from blocked countries to all ports";
		class63_5.Boolean_0 = false;
		class64_0.AutoSize = true;
		class64_0.Location = new Point(17, 79);
		class64_0.Name = "m_rbDenyModeAllExceptSelected";
		class64_0.Size = new Size(207, 20);
		class64_0.TabIndex = 2;
		class64_0.TabStop = true;
		class64_0.Text = "Block all ports except selected";
		class64_0.UseVisualStyleBackColor = false;
		class64_1.AutoSize = true;
		class64_1.Location = new Point(17, 24);
		class64_1.Name = "m_rbDenyModeAllPorts";
		class64_1.Size = new Size(109, 20);
		class64_1.TabIndex = 1;
		class64_1.TabStop = true;
		class64_1.Text = "Block all ports";
		class64_1.UseVisualStyleBackColor = false;
		tabPage_1.Controls.Add(class65_4);
		tabPage_1.Controls.Add(class65_3);
		tabPage_1.Controls.Add(class65_0);
		tabPage_1.Location = new Point(4, 25);
		tabPage_1.Name = "m_tpAllowMode";
		tabPage_1.Padding = new Padding(3);
		tabPage_1.Size = new Size(528, 589);
		tabPage_1.TabIndex = 1;
		tabPage_1.Text = "Allow Mode";
		class65_4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		class65_4.Controls.Add(textBox_3);
		class65_4.Controls.Add(class63_9);
		class65_4.Controls.Add(class63_10);
		class65_4.Controls.Add(class64_7);
		class65_4.Controls.Add(class64_8);
		class65_4.Location = new Point(6, 175);
		class65_4.Name = "m_gbAllowModeOther";
		class65_4.Size = new Size(516, 163);
		class65_4.TabIndex = 59;
		class65_4.TabStop = false;
		class65_4.Text = "Other connections (from disallowed countries):";
		textBox_3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		textBox_3.Enabled = false;
		textBox_3.Location = new Point(36, 125);
		textBox_3.Name = "m_edAllowModeBlockAllPortsExceptSelectedPorts";
		textBox_3.Size = new Size(474, 22);
		textBox_3.TabIndex = 60;
		class63_9.AutoSize = true;
		class63_9.ForeColor = SystemColors.ControlDarkDark;
		class63_9.Location = new Point(33, 102);
		class63_9.Name = "m_txtAllowModeDenyAllExceptSelectedHint";
		class63_9.Size = new Size(457, 16);
		class63_9.TabIndex = 59;
		class63_9.Text = "Deny access from disallowed countries to all ports except those listed below";
		class63_9.Boolean_0 = false;
		class63_10.AutoSize = true;
		class63_10.ForeColor = SystemColors.ControlDarkDark;
		class63_10.Location = new Point(33, 47);
		class63_10.Name = "m_txtAllowModeOtherBlockAllPortsHint";
		class63_10.Size = new Size(257, 16);
		class63_10.TabIndex = 58;
		class63_10.Text = "Deny all access from disallowed countries";
		class63_10.Boolean_0 = false;
		class64_7.AutoSize = true;
		class64_7.Location = new Point(17, 79);
		class64_7.Name = "m_rbAllowModeBlockAllPortsExceptSelected";
		class64_7.Size = new Size(207, 20);
		class64_7.TabIndex = 2;
		class64_7.TabStop = true;
		class64_7.Text = "Block all ports except selected";
		class64_7.UseVisualStyleBackColor = false;
		class64_8.AutoSize = true;
		class64_8.Location = new Point(17, 24);
		class64_8.Name = "m_rbAllowModeBlockAllPorts";
		class64_8.Size = new Size(109, 20);
		class64_8.TabIndex = 1;
		class64_8.TabStop = true;
		class64_8.Text = "Block all ports";
		class64_8.UseVisualStyleBackColor = false;
		class65_3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		class65_3.Controls.Add(textBox_2);
		class65_3.Controls.Add(class63_7);
		class65_3.Controls.Add(class63_8);
		class65_3.Controls.Add(class64_5);
		class65_3.Controls.Add(class64_6);
		class65_3.Location = new Point(6, 6);
		class65_3.Name = "m_gbAllowModeRules";
		class65_3.Size = new Size(516, 163);
		class65_3.TabIndex = 58;
		class65_3.TabStop = false;
		class65_3.Text = "Allow rules:";
		textBox_2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		textBox_2.Enabled = false;
		textBox_2.Location = new Point(36, 125);
		textBox_2.Name = "m_edAllowModeAllowSelectedOnlyPorts";
		textBox_2.Size = new Size(474, 22);
		textBox_2.TabIndex = 60;
		class63_7.AutoSize = true;
		class63_7.ForeColor = SystemColors.ControlDarkDark;
		class63_7.Location = new Point(33, 102);
		class63_7.Name = "m_txtAllowModeSelectedOnlyHint";
		class63_7.Size = new Size(392, 16);
		class63_7.TabIndex = 59;
		class63_7.Text = "Allow connections from allowed countries to the ports listed below";
		class63_7.Boolean_0 = false;
		class63_8.AutoSize = true;
		class63_8.ForeColor = SystemColors.ControlDarkDark;
		class63_8.Location = new Point(33, 47);
		class63_8.Name = "m_txtAllowModeAllPortsHint";
		class63_8.Size = new Size(314, 16);
		class63_8.TabIndex = 58;
		class63_8.Text = "Allow connections from allowed countries to all ports";
		class63_8.Boolean_0 = false;
		class64_5.AutoSize = true;
		class64_5.Location = new Point(17, 79);
		class64_5.Name = "m_rbAllowModeAllowSelectedOnly";
		class64_5.Size = new Size(234, 20);
		class64_5.TabIndex = 2;
		class64_5.TabStop = true;
		class64_5.Text = "Allow access to selected ports only";
		class64_5.UseVisualStyleBackColor = false;
		class64_6.AutoSize = true;
		class64_6.Location = new Point(17, 24);
		class64_6.Name = "m_rbAllowModeAllowAllPorts";
		class64_6.Size = new Size(168, 20);
		class64_6.TabIndex = 1;
		class64_6.TabStop = true;
		class64_6.Text = "Allow access to all ports";
		class64_6.UseVisualStyleBackColor = false;
		class65_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		class65_0.Controls.Add(class63_0);
		class65_0.Controls.Add(class61_0);
		class65_0.Controls.Add(class63_1);
		class65_0.Controls.Add(class61_1);
		class65_0.Controls.Add(class63_2);
		class65_0.Controls.Add(class61_2);
		class65_0.Controls.Add(class63_3);
		class65_0.Controls.Add(class61_3);
		class65_0.Location = new Point(6, 344);
		class65_0.Name = "m_gbExceptionsAndSpecialNetworks";
		class65_0.Size = new Size(516, 232);
		class65_0.TabIndex = 57;
		class65_0.TabStop = false;
		class65_0.Text = "Exceptions and special networks";
		class63_0.AutoSize = true;
		class63_0.ForeColor = SystemColors.ControlDarkDark;
		class63_0.Location = new Point(33, 200);
		class63_0.Name = "m_chbExcludeDatacentersHint";
		class63_0.Size = new Size(344, 16);
		class63_0.TabIndex = 63;
		class63_0.Text = "Exclude known data center networks from the allowed IPs";
		class63_0.Boolean_0 = false;
		class61_0.AutoSize = true;
		class61_0.Location = new Point(17, 177);
		class61_0.Name = "m_chbExcludeDatacenters";
		class61_0.Size = new Size(375, 20);
		class61_0.TabIndex = 62;
		class61_0.Text = "Exclude data center networks from the allowed connections";
		class61_0.UseVisualStyleBackColor = false;
		class63_1.AutoSize = true;
		class63_1.ForeColor = SystemColors.ControlDarkDark;
		class63_1.Location = new Point(33, 150);
		class63_1.Name = "m_lblExcludeVpnAndTorHint";
		class63_1.Size = new Size(419, 16);
		class63_1.TabIndex = 61;
		class63_1.Text = "Exclude known VPN networks and Tor exit nodes from the allowed IPs";
		class63_1.Boolean_0 = false;
		class61_1.AutoSize = true;
		class61_1.Location = new Point(17, 127);
		class61_1.Name = "m_chbExcludeVpnAndTor";
		class61_1.Size = new Size(450, 20);
		class61_1.TabIndex = 60;
		class61_1.Text = "Exclude VPN networks and Tor exit nodes from the allowed connections";
		class61_1.UseVisualStyleBackColor = false;
		class63_2.AutoSize = true;
		class63_2.ForeColor = SystemColors.ControlDarkDark;
		class63_2.Location = new Point(33, 100);
		class63_2.Name = "m_lblAllowLocalHint";
		class63_2.Size = new Size(425, 16);
		class63_2.TabIndex = 59;
		class63_2.Text = "Turn on if you want the machine to be accessible over the local network";
		class63_2.Boolean_0 = false;
		class61_2.AutoSize = true;
		class61_2.Location = new Point(17, 77);
		class61_2.Name = "m_chbAllowLocal";
		class61_2.Size = new Size(165, 20);
		class61_2.TabIndex = 58;
		class61_2.Text = "Allow local connections";
		class61_2.UseVisualStyleBackColor = false;
		class63_3.AutoSize = true;
		class63_3.ForeColor = SystemColors.ControlDarkDark;
		class63_3.Location = new Point(33, 50);
		class63_3.Name = "m_lblAllowLoopbackHint";
		class63_3.Size = new Size(437, 16);
		class63_3.TabIndex = 57;
		class63_3.Text = "Blocking these connections could disrupt normal operation of many apps";
		class63_3.Boolean_0 = false;
		class61_3.AutoSize = true;
		class61_3.Location = new Point(17, 27);
		class61_3.Name = "m_chbAllowLoopback";
		class61_3.Size = new Size(292, 20);
		class61_3.TabIndex = 56;
		class61_3.Text = "Allow loopback connections (recommended)";
		class61_3.UseVisualStyleBackColor = false;
		tabPage_2.Controls.Add(class65_2);
		tabPage_2.Location = new Point(4, 25);
		tabPage_2.Name = "m_tpMiscellaneous";
		tabPage_2.Size = new Size(528, 589);
		tabPage_2.TabIndex = 2;
		tabPage_2.Text = "Miscellaneous";
		class65_2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		class65_2.Controls.Add(class64_2);
		class65_2.Controls.Add(class64_3);
		class65_2.Location = new Point(6, 6);
		class65_2.Name = "m_gbDbVersion";
		class65_2.Size = new Size(516, 83);
		class65_2.TabIndex = 52;
		class65_2.TabStop = false;
		class65_2.Text = "Database version:";
		class64_2.Location = new Point(17, 50);
		class64_2.Name = "m_rbDbVersionMax";
		class64_2.Size = new Size(434, 20);
		class64_2.TabIndex = 2;
		class64_2.TabStop = true;
		class64_2.Text = "Max (more entries, higher impact on OS performance, more accurate)";
		class64_2.UseVisualStyleBackColor = false;
		class64_3.Location = new Point(17, 24);
		class64_3.Name = "m_rbDbVersionLite";
		class64_3.Size = new Size(420, 20);
		class64_3.TabIndex = 1;
		class64_3.TabStop = true;
		class64_3.Text = "Lite (fewer entries, lower impact on OS performance, less accurate)";
		class64_3.UseVisualStyleBackColor = false;
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.Controls.Add(control14_0);
		base.Controls.Add(gclass3_0);
		base.Controls.Add(gcontrol0_0);
		base.Controls.Add(class62_0);
		base.Controls.Add(class62_1);
		base.Controls.Add(pictureBox_0);
		base.Controls.Add(class66_0);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(5, 4, 5, 4);
		base.Name = "AdvancedGeoIPSettingsDialog";
		base.Size = new Size(580, 810);
		base.StartPosition = FormStartPosition.Manual;
		Text = "Advanced Geo-IP Settings";
		((ISupportInitialize)pictureBox_0).EndInit();
		control14_0.ResumeLayout(performLayout: false);
		tabPage_0.ResumeLayout(performLayout: false);
		class65_1.ResumeLayout(performLayout: false);
		class65_1.PerformLayout();
		tabPage_1.ResumeLayout(performLayout: false);
		class65_4.ResumeLayout(performLayout: false);
		class65_4.PerformLayout();
		class65_3.ResumeLayout(performLayout: false);
		class65_3.PerformLayout();
		class65_0.ResumeLayout(performLayout: false);
		class65_0.PerformLayout();
		tabPage_2.ResumeLayout(performLayout: false);
		class65_2.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void gclass3_0_Click(object sender, EventArgs e)
	{
		method_9(Class148.Class156.string_1);
	}

	private void control14_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (tabPage_1 == control14_0.SelectedTab)
		{
			MinimumSize = size_1;
			base.Size = size_1;
		}
		else
		{
			MinimumSize = size_0;
			base.Size = size_0;
		}
	}

	private void ValidateInput(object sender, EventArgs e)
	{
		OnButtonCancel();
	}

	private void SaveSettings(object sender, EventArgs e)
	{
		OnButtonCancel();
	}

	private void LoadSettings(object sender, EventArgs e)
	{
		OnButtonCancel();
	}

	private void class66_0_Click(object sender, EventArgs e)
	{
		method_8(DialogResult.OK);
	}
}
