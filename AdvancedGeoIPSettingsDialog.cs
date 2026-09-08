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

	private Class66 mbtnClose;

	private GControl0 separatorLine1;

	private Class62 mlblCaption;

	private PictureBox mimgBigIcon;

	private Class62 mlblSubCaption;

	private GClass3 mlnkOnlineHelp;

	private Control14 mtabMain;

	private TabPage mtpDenyMode;

	private TabPage mtpAllowMode;

	private TabPage mtpMiscellaneous;

	private Class65 mgbExceptionsAndSpecialNetworks;

	private Class63 mchbExcludeDatacentersHint;

	private Class61 mchbExcludeDatacenters;

	private Class63 mlblExcludeVpnAndTorHint;

	private Class61 mchbExcludeVpnAndTor;

	private Class63 mlblAllowLocalHint;

	private Class61 mchbAllowLocal;

	private Class63 mlblAllowLoopbackHint;

	private Class61 mchbAllowLoopback;

	private Class65 mgbDenyModeScope;

	private Class64 mrbDenyModeAllExceptSelected;

	private Class64 mrbDenyModeAllPorts;

	private Class65 mgbDbVersion;

	private Class64 mrbDbVersionMax;

	private Class64 mrbDbVersionLite;

	private Class63 mtxtDenyModeAllExceptSelectedHint;

	private Class63 mtxtDenyModeAllPortsHint;

	private TextBox medDenyModeSelectedOnlyPorts;

	private Class63 mtxtDenyModeSelectedOnlyHint;

	private Class64 mrbDenyModeSelectedOnly;

	private TextBox medDenyModeAllExceptSelectedPorts;

	private Class65 mgbAllowModeRules;

	private TextBox medAllowModeAllowSelectedOnlyPorts;

	private Class63 mtxtAllowModeSelectedOnlyHint;

	private Class63 mtxtAllowModeAllPortsHint;

	private Class64 mrbAllowModeAllowSelectedOnly;

	private Class64 mrbAllowModeAllowAllPorts;

	private Class65 mgbAllowModeOther;

	private TextBox medAllowModeBlockAllPortsExceptSelectedPorts;

	private Class63 mtxtAllowModeDenyAllExceptSelectedHint;

	private Class63 mtxtAllowModeOtherBlockAllPortsHint;

	private Class64 mrbAllowModeBlockAllPortsExceptSelected;

	private Class64 mrbAllowModeBlockAllPorts;

	private Class3 Class3_0 => new Class3(mrbDenyModeAllPorts, mrbDenyModeAllExceptSelected, medDenyModeAllExceptSelectedPorts, mrbDenyModeSelectedOnly, medDenyModeSelectedOnlyPorts);

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

	private Class3 Class3_1 => new Class3(mrbAllowModeAllowAllPorts, null, null, mrbAllowModeAllowSelectedOnly, medAllowModeAllowSelectedOnlyPorts);

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

	private Class3 Class3_2 => new Class3(mrbAllowModeBlockAllPorts, mrbAllowModeBlockAllPortsExceptSelected, medAllowModeBlockAllPortsExceptSelectedPorts, null, null);

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
			return mchbAllowLoopback.Checked;
		}
		set
		{
			mchbAllowLoopback.Checked = value;
		}
	}

	public bool Boolean_1
	{
		get
		{
			return mchbAllowLocal.Checked;
		}
		set
		{
			mchbAllowLocal.Checked = value;
		}
	}

	public bool Boolean_2
	{
		get
		{
			return mchbExcludeVpnAndTor.Checked;
		}
		set
		{
			mchbExcludeVpnAndTor.Checked = value;
		}
	}

	public bool Boolean_3
	{
		get
		{
			return mchbExcludeDatacenters.Checked;
		}
		set
		{
			mchbExcludeDatacenters.Checked = value;
		}
	}

	public GeoIPDBVersion GeoIPDBVersion_0
	{
		get
		{
			if (mrbDbVersionLite.Checked)
			{
				return GeoIPDBVersion.Lite;
			}
			if (mrbDbVersionMax.Checked)
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
				mrbDbVersionLite.Checked = true;
			}
			else if (GeoIPDBVersion.Max == value)
			{
				mrbDbVersionMax.Checked = true;
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
		InitializeFormPosition();
		InitializeComponent();
		OnButtonOk();
	}

	private void InitializeComponent()
	{
		MinimumSize = size_0;
		base.Size = size_0;
		mrbDbVersionMax.Enabled = !Class178.Boolean_0;
		mimgBigIcon.Image = ((Class163.Class163_0.Boolean_0 ? true : false) ? Resources.location_pin_settings_48_dark : Resources.location_pin_settings_48);
	}

	private void OnButtonOk()
	{
		mlnkOnlineHelp.Click += mlnkOnlineHelp_Click;
		mtabMain.SelectedIndexChanged += control14_0_SelectedIndexChanged;
		Class3 class3_ = Class3_0;
		class3_.eventHandler_0 = (EventHandler<EventArgs>)Delegate.Combine(class3_.eventHandler_0, new EventHandler<EventArgs>(ValidateInput));
		Class3 class3_2 = Class3_1;
		class3_2.eventHandler_0 = (EventHandler<EventArgs>)Delegate.Combine(class3_2.eventHandler_0, new EventHandler<EventArgs>(SaveSettings));
		Class3 class3_3 = Class3_2;
		class3_3.eventHandler_0 = (EventHandler<EventArgs>)Delegate.Combine(class3_3.eventHandler_0, new EventHandler<EventArgs>(LoadSettings));
		mbtnClose.Click += mbtnClose_Click;
	}

	private void OnButtonCancel()
	{
		mbtnClose.Enabled = Class3_0.method_1().Boolean_0 && Class3_1.method_1().Boolean_0 && Class3_2.method_1().Boolean_0;
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
		mbtnClose = new Class66();
		separatorLine1 = new GControl0();
		mlblCaption = new Class62();
		mimgBigIcon = new PictureBox();
		mlblSubCaption = new Class62();
		mlnkOnlineHelp = new GClass3();
		mtabMain = new Control14();
		mtpDenyMode = new TabPage();
		mgbDenyModeScope = new Class65();
		medDenyModeSelectedOnlyPorts = new TextBox();
		mtxtDenyModeSelectedOnlyHint = new Class63();
		mrbDenyModeSelectedOnly = new Class64();
		medDenyModeAllExceptSelectedPorts = new TextBox();
		mtxtDenyModeAllExceptSelectedHint = new Class63();
		mtxtDenyModeAllPortsHint = new Class63();
		mrbDenyModeAllExceptSelected = new Class64();
		mrbDenyModeAllPorts = new Class64();
		mtpAllowMode = new TabPage();
		mgbAllowModeOther = new Class65();
		medAllowModeBlockAllPortsExceptSelectedPorts = new TextBox();
		mtxtAllowModeDenyAllExceptSelectedHint = new Class63();
		mtxtAllowModeOtherBlockAllPortsHint = new Class63();
		mrbAllowModeBlockAllPortsExceptSelected = new Class64();
		mrbAllowModeBlockAllPorts = new Class64();
		mgbAllowModeRules = new Class65();
		medAllowModeAllowSelectedOnlyPorts = new TextBox();
		mtxtAllowModeSelectedOnlyHint = new Class63();
		mtxtAllowModeAllPortsHint = new Class63();
		mrbAllowModeAllowSelectedOnly = new Class64();
		mrbAllowModeAllowAllPorts = new Class64();
		mgbExceptionsAndSpecialNetworks = new Class65();
		mchbExcludeDatacentersHint = new Class63();
		mchbExcludeDatacenters = new Class61();
		mlblExcludeVpnAndTorHint = new Class63();
		mchbExcludeVpnAndTor = new Class61();
		mlblAllowLocalHint = new Class63();
		mchbAllowLocal = new Class61();
		mlblAllowLoopbackHint = new Class63();
		mchbAllowLoopback = new Class61();
		mtpMiscellaneous = new TabPage();
		mgbDbVersion = new Class65();
		mrbDbVersionMax = new Class64();
		mrbDbVersionLite = new Class64();
		((ISupportInitialize)mimgBigIcon).BeginInit();
		mtabMain.SuspendLayout();
		mtpDenyMode.SuspendLayout();
		mgbDenyModeScope.SuspendLayout();
		mtpAllowMode.SuspendLayout();
		mgbAllowModeOther.SuspendLayout();
		mgbAllowModeRules.SuspendLayout();
		mgbExceptionsAndSpecialNetworks.SuspendLayout();
		mtpMiscellaneous.SuspendLayout();
		mgbDbVersion.SuspendLayout();
		SuspendLayout();
		mbtnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mbtnClose.Image = Resources.opts_16;
		mbtnClose.Location = new Point(451, 722);
		mbtnClose.Margin = new Padding(4);
		mbtnClose.Name = "m_btnClose";
		mbtnClose.Size = new Size(100, 36);
		mbtnClose.TabIndex = 7;
		mbtnClose.Text = "Close";
		mbtnClose.TextAlign = ContentAlignment.MiddleRight;
		mbtnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
		mbtnClose.UseVisualStyleBackColor = false;
		separatorLine1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		separatorLine1.Location = new Point(16, 81);
		separatorLine1.Name = "separatorLine1";
		separatorLine1.Size = new Size(532, 2);
		separatorLine1.TabIndex = 50;
		separatorLine1.TabStop = false;
		mlblCaption.AutoSize = true;
		mlblCaption.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		mlblCaption.Location = new Point(79, 15);
		mlblCaption.Margin = new Padding(4, 0, 4, 0);
		mlblCaption.Name = "m_lblCaption";
		mlblCaption.Size = new Size(115, 16);
		mlblCaption.TabIndex = 49;
		mlblCaption.Text = "Geo-IP Settings";
		mlblCaption.Boolean_0 = false;
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
		mlblSubCaption.Size = new Size(163, 16);
		mlblSubCaption.TabIndex = 48;
		mlblSubCaption.Text = "Advanced Geo-IP settings";
		mlblSubCaption.Boolean_0 = false;
		mlnkOnlineHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		mlnkOnlineHelp.AutoSize = true;
		mlnkOnlineHelp.LinkBehavior = LinkBehavior.NeverUnderline;
		mlnkOnlineHelp.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkOnlineHelp.Location = new Point(476, 9);
		mlnkOnlineHelp.Name = "m_lnkOnlineHelp";
		mlnkOnlineHelp.Size = new Size(72, 16);
		mlnkOnlineHelp.TabIndex = 9;
		mlnkOnlineHelp.TabStop = true;
		mlnkOnlineHelp.Text = "online help";
		mlnkOnlineHelp.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		mtabMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		mtabMain.Controls.Add(mtpDenyMode);
		mtabMain.Controls.Add(mtpAllowMode);
		mtabMain.Controls.Add(mtpMiscellaneous);
		mtabMain.Location = new Point(16, 97);
		mtabMain.Name = "m_tabMain";
		mtabMain.SelectedIndex = 0;
		mtabMain.Size = new Size(536, 618);
		mtabMain.TabIndex = 57;
		mtpDenyMode.Controls.Add(mgbDenyModeScope);
		mtpDenyMode.Location = new Point(4, 25);
		mtpDenyMode.Name = "m_tpDenyMode";
		mtpDenyMode.Padding = new Padding(3);
		mtpDenyMode.Size = new Size(528, 589);
		mtpDenyMode.TabIndex = 0;
		mtpDenyMode.Text = "Deny Mode";
		mgbDenyModeScope.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		mgbDenyModeScope.Controls.Add(medDenyModeSelectedOnlyPorts);
		mgbDenyModeScope.Controls.Add(mtxtDenyModeSelectedOnlyHint);
		mgbDenyModeScope.Controls.Add(mrbDenyModeSelectedOnly);
		mgbDenyModeScope.Controls.Add(medDenyModeAllExceptSelectedPorts);
		mgbDenyModeScope.Controls.Add(mtxtDenyModeAllExceptSelectedHint);
		mgbDenyModeScope.Controls.Add(mtxtDenyModeAllPortsHint);
		mgbDenyModeScope.Controls.Add(mrbDenyModeAllExceptSelected);
		mgbDenyModeScope.Controls.Add(mrbDenyModeAllPorts);
		mgbDenyModeScope.Location = new Point(6, 6);
		mgbDenyModeScope.Name = "m_gbDenyModeScope";
		mgbDenyModeScope.Size = new Size(516, 247);
		mgbDenyModeScope.TabIndex = 53;
		mgbDenyModeScope.TabStop = false;
		mgbDenyModeScope.Text = "Blocking scope:";
		medDenyModeSelectedOnlyPorts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		medDenyModeSelectedOnlyPorts.Enabled = false;
		medDenyModeSelectedOnlyPorts.Location = new Point(36, 209);
		medDenyModeSelectedOnlyPorts.Name = "m_edDenyModeSelectedOnlyPorts";
		medDenyModeSelectedOnlyPorts.Size = new Size(474, 22);
		medDenyModeSelectedOnlyPorts.TabIndex = 63;
		mtxtDenyModeSelectedOnlyHint.AutoSize = true;
		mtxtDenyModeSelectedOnlyHint.ForeColor = SystemColors.ControlDarkDark;
		mtxtDenyModeSelectedOnlyHint.Location = new Point(33, 186);
		mtxtDenyModeSelectedOnlyHint.Name = "m_txtDenyModeSelectedOnlyHint";
		mtxtDenyModeSelectedOnlyHint.Size = new Size(394, 16);
		mtxtDenyModeSelectedOnlyHint.TabIndex = 62;
		mtxtDenyModeSelectedOnlyHint.Text = "Deny access from blocked countries only to the ports listed below";
		mtxtDenyModeSelectedOnlyHint.Boolean_0 = false;
		mrbDenyModeSelectedOnly.AutoSize = true;
		mrbDenyModeSelectedOnly.Location = new Point(17, 163);
		mrbDenyModeSelectedOnly.Name = "m_rbDenyModeSelectedOnly";
		mrbDenyModeSelectedOnly.Size = new Size(175, 20);
		mrbDenyModeSelectedOnly.TabIndex = 61;
		mrbDenyModeSelectedOnly.TabStop = true;
		mrbDenyModeSelectedOnly.Text = "Block selected ports only";
		mrbDenyModeSelectedOnly.UseVisualStyleBackColor = false;
		medDenyModeAllExceptSelectedPorts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		medDenyModeAllExceptSelectedPorts.Enabled = false;
		medDenyModeAllExceptSelectedPorts.Location = new Point(36, 125);
		medDenyModeAllExceptSelectedPorts.Name = "m_edDenyModeAllExceptSelectedPorts";
		medDenyModeAllExceptSelectedPorts.Size = new Size(474, 22);
		medDenyModeAllExceptSelectedPorts.TabIndex = 60;
		mtxtDenyModeAllExceptSelectedHint.AutoSize = true;
		mtxtDenyModeAllExceptSelectedHint.ForeColor = SystemColors.ControlDarkDark;
		mtxtDenyModeAllExceptSelectedHint.Location = new Point(33, 102);
		mtxtDenyModeAllExceptSelectedHint.Name = "m_txtDenyModeAllExceptSelectedHint";
		mtxtDenyModeAllExceptSelectedHint.Size = new Size(441, 16);
		mtxtDenyModeAllExceptSelectedHint.TabIndex = 59;
		mtxtDenyModeAllExceptSelectedHint.Text = "Deny access from blocked countries to all ports except those listed below";
		mtxtDenyModeAllExceptSelectedHint.Boolean_0 = false;
		mtxtDenyModeAllPortsHint.AutoSize = true;
		mtxtDenyModeAllPortsHint.ForeColor = SystemColors.ControlDarkDark;
		mtxtDenyModeAllPortsHint.Location = new Point(33, 47);
		mtxtDenyModeAllPortsHint.Name = "m_txtDenyModeAllPortsHint";
		mtxtDenyModeAllPortsHint.Size = new Size(288, 16);
		mtxtDenyModeAllPortsHint.TabIndex = 58;
		mtxtDenyModeAllPortsHint.Text = "Deny access from blocked countries to all ports";
		mtxtDenyModeAllPortsHint.Boolean_0 = false;
		mrbDenyModeAllExceptSelected.AutoSize = true;
		mrbDenyModeAllExceptSelected.Location = new Point(17, 79);
		mrbDenyModeAllExceptSelected.Name = "m_rbDenyModeAllExceptSelected";
		mrbDenyModeAllExceptSelected.Size = new Size(207, 20);
		mrbDenyModeAllExceptSelected.TabIndex = 2;
		mrbDenyModeAllExceptSelected.TabStop = true;
		mrbDenyModeAllExceptSelected.Text = "Block all ports except selected";
		mrbDenyModeAllExceptSelected.UseVisualStyleBackColor = false;
		mrbDenyModeAllPorts.AutoSize = true;
		mrbDenyModeAllPorts.Location = new Point(17, 24);
		mrbDenyModeAllPorts.Name = "m_rbDenyModeAllPorts";
		mrbDenyModeAllPorts.Size = new Size(109, 20);
		mrbDenyModeAllPorts.TabIndex = 1;
		mrbDenyModeAllPorts.TabStop = true;
		mrbDenyModeAllPorts.Text = "Block all ports";
		mrbDenyModeAllPorts.UseVisualStyleBackColor = false;
		mtpAllowMode.Controls.Add(mgbAllowModeOther);
		mtpAllowMode.Controls.Add(mgbAllowModeRules);
		mtpAllowMode.Controls.Add(mgbExceptionsAndSpecialNetworks);
		mtpAllowMode.Location = new Point(4, 25);
		mtpAllowMode.Name = "m_tpAllowMode";
		mtpAllowMode.Padding = new Padding(3);
		mtpAllowMode.Size = new Size(528, 589);
		mtpAllowMode.TabIndex = 1;
		mtpAllowMode.Text = "Allow Mode";
		mgbAllowModeOther.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		mgbAllowModeOther.Controls.Add(medAllowModeBlockAllPortsExceptSelectedPorts);
		mgbAllowModeOther.Controls.Add(mtxtAllowModeDenyAllExceptSelectedHint);
		mgbAllowModeOther.Controls.Add(mtxtAllowModeOtherBlockAllPortsHint);
		mgbAllowModeOther.Controls.Add(mrbAllowModeBlockAllPortsExceptSelected);
		mgbAllowModeOther.Controls.Add(mrbAllowModeBlockAllPorts);
		mgbAllowModeOther.Location = new Point(6, 175);
		mgbAllowModeOther.Name = "m_gbAllowModeOther";
		mgbAllowModeOther.Size = new Size(516, 163);
		mgbAllowModeOther.TabIndex = 59;
		mgbAllowModeOther.TabStop = false;
		mgbAllowModeOther.Text = "Other connections (from disallowed countries):";
		medAllowModeBlockAllPortsExceptSelectedPorts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		medAllowModeBlockAllPortsExceptSelectedPorts.Enabled = false;
		medAllowModeBlockAllPortsExceptSelectedPorts.Location = new Point(36, 125);
		medAllowModeBlockAllPortsExceptSelectedPorts.Name = "m_edAllowModeBlockAllPortsExceptSelectedPorts";
		medAllowModeBlockAllPortsExceptSelectedPorts.Size = new Size(474, 22);
		medAllowModeBlockAllPortsExceptSelectedPorts.TabIndex = 60;
		mtxtAllowModeDenyAllExceptSelectedHint.AutoSize = true;
		mtxtAllowModeDenyAllExceptSelectedHint.ForeColor = SystemColors.ControlDarkDark;
		mtxtAllowModeDenyAllExceptSelectedHint.Location = new Point(33, 102);
		mtxtAllowModeDenyAllExceptSelectedHint.Name = "m_txtAllowModeDenyAllExceptSelectedHint";
		mtxtAllowModeDenyAllExceptSelectedHint.Size = new Size(457, 16);
		mtxtAllowModeDenyAllExceptSelectedHint.TabIndex = 59;
		mtxtAllowModeDenyAllExceptSelectedHint.Text = "Deny access from disallowed countries to all ports except those listed below";
		mtxtAllowModeDenyAllExceptSelectedHint.Boolean_0 = false;
		mtxtAllowModeOtherBlockAllPortsHint.AutoSize = true;
		mtxtAllowModeOtherBlockAllPortsHint.ForeColor = SystemColors.ControlDarkDark;
		mtxtAllowModeOtherBlockAllPortsHint.Location = new Point(33, 47);
		mtxtAllowModeOtherBlockAllPortsHint.Name = "m_txtAllowModeOtherBlockAllPortsHint";
		mtxtAllowModeOtherBlockAllPortsHint.Size = new Size(257, 16);
		mtxtAllowModeOtherBlockAllPortsHint.TabIndex = 58;
		mtxtAllowModeOtherBlockAllPortsHint.Text = "Deny all access from disallowed countries";
		mtxtAllowModeOtherBlockAllPortsHint.Boolean_0 = false;
		mrbAllowModeBlockAllPortsExceptSelected.AutoSize = true;
		mrbAllowModeBlockAllPortsExceptSelected.Location = new Point(17, 79);
		mrbAllowModeBlockAllPortsExceptSelected.Name = "m_rbAllowModeBlockAllPortsExceptSelected";
		mrbAllowModeBlockAllPortsExceptSelected.Size = new Size(207, 20);
		mrbAllowModeBlockAllPortsExceptSelected.TabIndex = 2;
		mrbAllowModeBlockAllPortsExceptSelected.TabStop = true;
		mrbAllowModeBlockAllPortsExceptSelected.Text = "Block all ports except selected";
		mrbAllowModeBlockAllPortsExceptSelected.UseVisualStyleBackColor = false;
		mrbAllowModeBlockAllPorts.AutoSize = true;
		mrbAllowModeBlockAllPorts.Location = new Point(17, 24);
		mrbAllowModeBlockAllPorts.Name = "m_rbAllowModeBlockAllPorts";
		mrbAllowModeBlockAllPorts.Size = new Size(109, 20);
		mrbAllowModeBlockAllPorts.TabIndex = 1;
		mrbAllowModeBlockAllPorts.TabStop = true;
		mrbAllowModeBlockAllPorts.Text = "Block all ports";
		mrbAllowModeBlockAllPorts.UseVisualStyleBackColor = false;
		mgbAllowModeRules.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		mgbAllowModeRules.Controls.Add(medAllowModeAllowSelectedOnlyPorts);
		mgbAllowModeRules.Controls.Add(mtxtAllowModeSelectedOnlyHint);
		mgbAllowModeRules.Controls.Add(mtxtAllowModeAllPortsHint);
		mgbAllowModeRules.Controls.Add(mrbAllowModeAllowSelectedOnly);
		mgbAllowModeRules.Controls.Add(mrbAllowModeAllowAllPorts);
		mgbAllowModeRules.Location = new Point(6, 6);
		mgbAllowModeRules.Name = "m_gbAllowModeRules";
		mgbAllowModeRules.Size = new Size(516, 163);
		mgbAllowModeRules.TabIndex = 58;
		mgbAllowModeRules.TabStop = false;
		mgbAllowModeRules.Text = "Allow rules:";
		medAllowModeAllowSelectedOnlyPorts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		medAllowModeAllowSelectedOnlyPorts.Enabled = false;
		medAllowModeAllowSelectedOnlyPorts.Location = new Point(36, 125);
		medAllowModeAllowSelectedOnlyPorts.Name = "m_edAllowModeAllowSelectedOnlyPorts";
		medAllowModeAllowSelectedOnlyPorts.Size = new Size(474, 22);
		medAllowModeAllowSelectedOnlyPorts.TabIndex = 60;
		mtxtAllowModeSelectedOnlyHint.AutoSize = true;
		mtxtAllowModeSelectedOnlyHint.ForeColor = SystemColors.ControlDarkDark;
		mtxtAllowModeSelectedOnlyHint.Location = new Point(33, 102);
		mtxtAllowModeSelectedOnlyHint.Name = "m_txtAllowModeSelectedOnlyHint";
		mtxtAllowModeSelectedOnlyHint.Size = new Size(392, 16);
		mtxtAllowModeSelectedOnlyHint.TabIndex = 59;
		mtxtAllowModeSelectedOnlyHint.Text = "Allow connections from allowed countries to the ports listed below";
		mtxtAllowModeSelectedOnlyHint.Boolean_0 = false;
		mtxtAllowModeAllPortsHint.AutoSize = true;
		mtxtAllowModeAllPortsHint.ForeColor = SystemColors.ControlDarkDark;
		mtxtAllowModeAllPortsHint.Location = new Point(33, 47);
		mtxtAllowModeAllPortsHint.Name = "m_txtAllowModeAllPortsHint";
		mtxtAllowModeAllPortsHint.Size = new Size(314, 16);
		mtxtAllowModeAllPortsHint.TabIndex = 58;
		mtxtAllowModeAllPortsHint.Text = "Allow connections from allowed countries to all ports";
		mtxtAllowModeAllPortsHint.Boolean_0 = false;
		mrbAllowModeAllowSelectedOnly.AutoSize = true;
		mrbAllowModeAllowSelectedOnly.Location = new Point(17, 79);
		mrbAllowModeAllowSelectedOnly.Name = "m_rbAllowModeAllowSelectedOnly";
		mrbAllowModeAllowSelectedOnly.Size = new Size(234, 20);
		mrbAllowModeAllowSelectedOnly.TabIndex = 2;
		mrbAllowModeAllowSelectedOnly.TabStop = true;
		mrbAllowModeAllowSelectedOnly.Text = "Allow access to selected ports only";
		mrbAllowModeAllowSelectedOnly.UseVisualStyleBackColor = false;
		mrbAllowModeAllowAllPorts.AutoSize = true;
		mrbAllowModeAllowAllPorts.Location = new Point(17, 24);
		mrbAllowModeAllowAllPorts.Name = "m_rbAllowModeAllowAllPorts";
		mrbAllowModeAllowAllPorts.Size = new Size(168, 20);
		mrbAllowModeAllowAllPorts.TabIndex = 1;
		mrbAllowModeAllowAllPorts.TabStop = true;
		mrbAllowModeAllowAllPorts.Text = "Allow access to all ports";
		mrbAllowModeAllowAllPorts.UseVisualStyleBackColor = false;
		mgbExceptionsAndSpecialNetworks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		mgbExceptionsAndSpecialNetworks.Controls.Add(mchbExcludeDatacentersHint);
		mgbExceptionsAndSpecialNetworks.Controls.Add(mchbExcludeDatacenters);
		mgbExceptionsAndSpecialNetworks.Controls.Add(mlblExcludeVpnAndTorHint);
		mgbExceptionsAndSpecialNetworks.Controls.Add(mchbExcludeVpnAndTor);
		mgbExceptionsAndSpecialNetworks.Controls.Add(mlblAllowLocalHint);
		mgbExceptionsAndSpecialNetworks.Controls.Add(mchbAllowLocal);
		mgbExceptionsAndSpecialNetworks.Controls.Add(mlblAllowLoopbackHint);
		mgbExceptionsAndSpecialNetworks.Controls.Add(mchbAllowLoopback);
		mgbExceptionsAndSpecialNetworks.Location = new Point(6, 344);
		mgbExceptionsAndSpecialNetworks.Name = "m_gbExceptionsAndSpecialNetworks";
		mgbExceptionsAndSpecialNetworks.Size = new Size(516, 232);
		mgbExceptionsAndSpecialNetworks.TabIndex = 57;
		mgbExceptionsAndSpecialNetworks.TabStop = false;
		mgbExceptionsAndSpecialNetworks.Text = "Exceptions and special networks";
		mchbExcludeDatacentersHint.AutoSize = true;
		mchbExcludeDatacentersHint.ForeColor = SystemColors.ControlDarkDark;
		mchbExcludeDatacentersHint.Location = new Point(33, 200);
		mchbExcludeDatacentersHint.Name = "m_chbExcludeDatacentersHint";
		mchbExcludeDatacentersHint.Size = new Size(344, 16);
		mchbExcludeDatacentersHint.TabIndex = 63;
		mchbExcludeDatacentersHint.Text = "Exclude known data center networks from the allowed IPs";
		mchbExcludeDatacentersHint.Boolean_0 = false;
		mchbExcludeDatacenters.AutoSize = true;
		mchbExcludeDatacenters.Location = new Point(17, 177);
		mchbExcludeDatacenters.Name = "m_chbExcludeDatacenters";
		mchbExcludeDatacenters.Size = new Size(375, 20);
		mchbExcludeDatacenters.TabIndex = 62;
		mchbExcludeDatacenters.Text = "Exclude data center networks from the allowed connections";
		mchbExcludeDatacenters.UseVisualStyleBackColor = false;
		mlblExcludeVpnAndTorHint.AutoSize = true;
		mlblExcludeVpnAndTorHint.ForeColor = SystemColors.ControlDarkDark;
		mlblExcludeVpnAndTorHint.Location = new Point(33, 150);
		mlblExcludeVpnAndTorHint.Name = "m_lblExcludeVpnAndTorHint";
		mlblExcludeVpnAndTorHint.Size = new Size(419, 16);
		mlblExcludeVpnAndTorHint.TabIndex = 61;
		mlblExcludeVpnAndTorHint.Text = "Exclude known VPN networks and Tor exit nodes from the allowed IPs";
		mlblExcludeVpnAndTorHint.Boolean_0 = false;
		mchbExcludeVpnAndTor.AutoSize = true;
		mchbExcludeVpnAndTor.Location = new Point(17, 127);
		mchbExcludeVpnAndTor.Name = "m_chbExcludeVpnAndTor";
		mchbExcludeVpnAndTor.Size = new Size(450, 20);
		mchbExcludeVpnAndTor.TabIndex = 60;
		mchbExcludeVpnAndTor.Text = "Exclude VPN networks and Tor exit nodes from the allowed connections";
		mchbExcludeVpnAndTor.UseVisualStyleBackColor = false;
		mlblAllowLocalHint.AutoSize = true;
		mlblAllowLocalHint.ForeColor = SystemColors.ControlDarkDark;
		mlblAllowLocalHint.Location = new Point(33, 100);
		mlblAllowLocalHint.Name = "m_lblAllowLocalHint";
		mlblAllowLocalHint.Size = new Size(425, 16);
		mlblAllowLocalHint.TabIndex = 59;
		mlblAllowLocalHint.Text = "Turn on if you want the machine to be accessible over the local network";
		mlblAllowLocalHint.Boolean_0 = false;
		mchbAllowLocal.AutoSize = true;
		mchbAllowLocal.Location = new Point(17, 77);
		mchbAllowLocal.Name = "m_chbAllowLocal";
		mchbAllowLocal.Size = new Size(165, 20);
		mchbAllowLocal.TabIndex = 58;
		mchbAllowLocal.Text = "Allow local connections";
		mchbAllowLocal.UseVisualStyleBackColor = false;
		mlblAllowLoopbackHint.AutoSize = true;
		mlblAllowLoopbackHint.ForeColor = SystemColors.ControlDarkDark;
		mlblAllowLoopbackHint.Location = new Point(33, 50);
		mlblAllowLoopbackHint.Name = "m_lblAllowLoopbackHint";
		mlblAllowLoopbackHint.Size = new Size(437, 16);
		mlblAllowLoopbackHint.TabIndex = 57;
		mlblAllowLoopbackHint.Text = "Blocking these connections could disrupt normal operation of many apps";
		mlblAllowLoopbackHint.Boolean_0 = false;
		mchbAllowLoopback.AutoSize = true;
		mchbAllowLoopback.Location = new Point(17, 27);
		mchbAllowLoopback.Name = "m_chbAllowLoopback";
		mchbAllowLoopback.Size = new Size(292, 20);
		mchbAllowLoopback.TabIndex = 56;
		mchbAllowLoopback.Text = "Allow loopback connections (recommended)";
		mchbAllowLoopback.UseVisualStyleBackColor = false;
		mtpMiscellaneous.Controls.Add(mgbDbVersion);
		mtpMiscellaneous.Location = new Point(4, 25);
		mtpMiscellaneous.Name = "m_tpMiscellaneous";
		mtpMiscellaneous.Size = new Size(528, 589);
		mtpMiscellaneous.TabIndex = 2;
		mtpMiscellaneous.Text = "Miscellaneous";
		mgbDbVersion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		mgbDbVersion.Controls.Add(mrbDbVersionMax);
		mgbDbVersion.Controls.Add(mrbDbVersionLite);
		mgbDbVersion.Location = new Point(6, 6);
		mgbDbVersion.Name = "m_gbDbVersion";
		mgbDbVersion.Size = new Size(516, 83);
		mgbDbVersion.TabIndex = 52;
		mgbDbVersion.TabStop = false;
		mgbDbVersion.Text = "Database version:";
		mrbDbVersionMax.Location = new Point(17, 50);
		mrbDbVersionMax.Name = "m_rbDbVersionMax";
		mrbDbVersionMax.Size = new Size(434, 20);
		mrbDbVersionMax.TabIndex = 2;
		mrbDbVersionMax.TabStop = true;
		mrbDbVersionMax.Text = "Max (more entries, higher impact on OS performance, more accurate)";
		mrbDbVersionMax.UseVisualStyleBackColor = false;
		mrbDbVersionLite.Location = new Point(17, 24);
		mrbDbVersionLite.Name = "m_rbDbVersionLite";
		mrbDbVersionLite.Size = new Size(420, 20);
		mrbDbVersionLite.TabIndex = 1;
		mrbDbVersionLite.TabStop = true;
		mrbDbVersionLite.Text = "Lite (fewer entries, lower impact on OS performance, less accurate)";
		mrbDbVersionLite.UseVisualStyleBackColor = false;
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.Controls.Add(mtabMain);
		base.Controls.Add(mlnkOnlineHelp);
		base.Controls.Add(separatorLine1);
		base.Controls.Add(mlblCaption);
		base.Controls.Add(mlblSubCaption);
		base.Controls.Add(mimgBigIcon);
		base.Controls.Add(mbtnClose);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(5, 4, 5, 4);
		base.Name = "AdvancedGeoIPSettingsDialog";
		base.Size = new Size(580, 810);
		base.StartPosition = FormStartPosition.Manual;
		Text = "Advanced Geo-IP Settings";
		((ISupportInitialize)mimgBigIcon).EndInit();
		mtabMain.ResumeLayout(performLayout: false);
		mtpDenyMode.ResumeLayout(performLayout: false);
		mgbDenyModeScope.ResumeLayout(performLayout: false);
		mgbDenyModeScope.PerformLayout();
		mtpAllowMode.ResumeLayout(performLayout: false);
		mgbAllowModeOther.ResumeLayout(performLayout: false);
		mgbAllowModeOther.PerformLayout();
		mgbAllowModeRules.ResumeLayout(performLayout: false);
		mgbAllowModeRules.PerformLayout();
		mgbExceptionsAndSpecialNetworks.ResumeLayout(performLayout: false);
		mgbExceptionsAndSpecialNetworks.PerformLayout();
		mtpMiscellaneous.ResumeLayout(performLayout: false);
		mgbDbVersion.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void mlnkOnlineHelp_Click(object sender, EventArgs e)
	{
		ShowOnlineHelp(Class148.Class156.string_1);
	}

	private void control14_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (mtpAllowMode == mtabMain.SelectedTab)
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

	private void mbtnClose_Click(object sender, EventArgs e)
	{
		CloseDialog(DialogResult.OK);
	}
}
