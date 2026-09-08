using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Properties;
using rdpguard.lib;

internal sealed class OptionsDialog : Form0
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static EventHandler _003C_003E9__3_3;

		public static Func<GClass5, long> _003C_003E9__24_0;

		internal void method_0(object sender, EventArgs e)
		{
			Class12.smethod_0();
		}

		internal long method_1(GClass5 gclass5_0)
		{
			return gclass5_0.long_0;
		}
	}

	private readonly Class164 class164_0;

	private string string_0 = string.Empty;

	private GClass5[] gclass5_0 = new GClass5[0];

	private GClass5[] gclass5_1 = new GClass5[0];

	private IContainer icontainer_0;

	private Control14 tabControl1;

	private TabPage mtabGeneral;

	private TabPage mtabInterface;

	private Class66 mbtnSave;

	private Class66 mbtnCancel;

	private Class61 mchbCheckForSoftwareUpdates;

	private Class62 mchbCheckForSoftwareUpdatesHint;

	private Class62 mchbMinimizeToSystemTrayTip;

	private Class62 mlblShowSystrayIconTip;

	private Class61 mchbAllwaysShowSystemTrayIcon;

	private Class61 mchbMinimizeToSystemTray;

	private TabPage mtabLogging;

	private Class63 mlblMaxFailedLogonAttemptsHint;

	private NumericUpDown mnumMaxFailedLogonAttempts;

	private Class62 mlblMaxFailedLogonAttempts;

	private Class62 mlblAutoUnban;

	private NumericUpDown mnumAutoUnbanPeriod;

	private Class63 mlblAutoUnbanHint;

	private NumericUpDown mnumResetCountersAfter;

	private Class62 mlblResetCountersAfter;

	private Class63 mlblResetCountersAfterHint;

	private Class62 label16;

	private Class61 chbHideWhenMimimized;

	private TabPage mtabConnection;

	private Class65 mgbProxySettings;

	private Class0 mcbProxyMode;

	private NumericUpDown mnumProxyPort;

	private TextBox medProxyDomain;

	private Class62 mlblProxyDomain;

	private Class61 mchbProxyAuthentication;

	private TextBox medProxyPassword;

	private Class62 mlblProxyPassword;

	private TextBox medProxyUsername;

	private Class62 mlblProxyUserName;

	private Class62 mlblProxyPort;

	private TextBox medProxyAddress;

	private Class62 mlblProxyAddress;

	private GClass3 mlnkAdvancedBlockingSettings;

	private Class62 mchbCloseToSystemTrayTip;

	private Class61 mchbCloseToSystemTray;

	private NumericUpDown mnumIPPageSize;

	private Class62 mlblIPPageSize;

	private Class63 mlblIPPageSizeHint;

	private TabPage mtabGeoIP;

	private TabPage mtabCloud;

	private Class63 mlblEnableGeoIPEngineHint;

	private Class61 mchbEnableGeoIPEngine;

	private Class61 mchbEnableIPCloud;

	private EditableGeoIPCountriesTable mlstGeoIPCountries;

	private Class65 mgbGeoIPMode;

	private Class64 mrbGeoIPModeAllow;

	private Class64 mrbGeoIPModeDeny;

	private GClass2 medEnableIPCloudHint;

	private Class62 mlblColorTheme;

	private Class63 mlblColorThemeHint;

	private Class0 mcbColorTheme;

	private Class62 mlblGeoIPWarning;

	private GClass3 mlnkGeoIPHelp;

	private Class65 mgbLogging;

	private Class61 mchbLogSaveToFile;

	private Class63 mlblLogSaveToFileHint;

	private GClass3 mlnkLogsView;

	private Class61 mchbLogRemoveOld;

	private NumericUpDown mnumLogRemoveOldLogsDays;

	private Class63 mlblLogRemoveOldHint;

	private Class62 mlblLogVerbosityLevel;

	private Class0 mcbLogVerbosityLevel;

	private Class63 mlblLogVerbosityLevelHint;

	private GClass3 mlnkLogSuccessfulLoginAttemptsConfiguration;

	private Class63 mchbLogSuccessfulLoginAttemptsHint;

	private Class61 mchbLogSuccessfulLoginAttempts;

	private GClass8 GClass8_0
	{
		get
		{
			return new GClass8
			{
				genum17_0 = GClass18.GClass18_0[mcbLogVerbosityLevel.Text],
				bool_0 = mchbLogSaveToFile.Checked,
				bool_1 = mchbLogRemoveOld.Checked,
				int_0 = (int)mnumLogRemoveOldLogsDays.Value,
				bool_2 = mchbLogSuccessfulLoginAttempts.Checked,
				string_0 = string_0
			};
		}
		set
		{
			mcbLogVerbosityLevel.Text = GClass18.GClass18_0[value.genum17_0];
			mchbLogSaveToFile.Checked = value.bool_0;
			mchbLogRemoveOld.Checked = value.bool_1;
			mnumLogRemoveOldLogsDays.Value = value.int_0;
			mchbLogSuccessfulLoginAttempts.Checked = value.bool_2;
			string_0 = value.string_0;
		}
	}

	private Class159 Class159_0
	{
		get
		{
			return new Class159
			{
				genum13_0 = (GEnum13)mcbProxyMode.SelectedIndex,
				string_0 = medProxyAddress.Text,
				int_0 = (int)mnumProxyPort.Value,
				bool_0 = mchbProxyAuthentication.Checked,
				string_1 = medProxyUsername.Text,
				string_2 = medProxyPassword.Text,
				string_3 = medProxyDomain.Text
			};
		}
		set
		{
			mcbProxyMode.SelectedIndex = (int)value.genum13_0;
			medProxyAddress.Text = value.string_0;
			mnumProxyPort.Value = value.int_0;
			mchbProxyAuthentication.Checked = value.bool_0;
			medProxyUsername.Text = value.string_1;
			medProxyPassword.Text = value.string_2;
			medProxyDomain.Text = value.string_3;
		}
	}

	private GeoIPMode GeoIPMode_0
	{
		get
		{
			if (mrbGeoIPModeDeny.Checked)
			{
				return GeoIPMode.Deny;
			}
			if (mrbGeoIPModeAllow.Checked)
			{
				return GeoIPMode.Allow;
			}
			Class89.smethod_19("OptionsDialog::GeoIPMode_get::unknown_geoip_mode");
			return GeoIPMode.Unknown;
		}
		set
		{
			if (value == GeoIPMode.Deny)
			{
				mrbGeoIPModeDeny.Checked = true;
			}
			else if (GeoIPMode.Allow == value)
			{
				mrbGeoIPModeAllow.Checked = true;
			}
			else
			{
				Class89.smethod_19("OptionsDialog::GeoIPMode_set::unknown_geoip_mode");
			}
		}
	}

	private Class132 Class132_0
	{
		get
		{
			return new Class132
			{
				bool_0 = mchbEnableGeoIPEngine.Checked,
				geoIPMode_0 = GeoIPMode_0,
				geoIPDBVersion_0 = mlstGeoIPCountries.geoIPDBVersion_0,
				bool_1 = mlstGeoIPCountries.Boolean_0,
				bool_2 = false,
				gclass5_0 = mlstGeoIPCountries.GClass5_0,
				iplistEntry_0 = mlstGeoIPCountries.IPListEntry_0,
				gclass7_0 = mlstGeoIPCountries.gclass7_0,
				gclass7_1 = mlstGeoIPCountries.gclass7_1,
				gclass7_2 = mlstGeoIPCountries.gclass7_2,
				bool_3 = mlstGeoIPCountries.bool_0,
				bool_4 = mlstGeoIPCountries.bool_1,
				bool_5 = mlstGeoIPCountries.bool_2,
				bool_6 = mlstGeoIPCountries.bool_3
			};
		}
		set
		{
			mchbEnableGeoIPEngine.Checked = value.bool_0;
			mlstGeoIPCountries.geoIPDBVersion_0 = value.geoIPDBVersion_0;
			GeoIPMode_0 = value.geoIPMode_0;
			mlstGeoIPCountries.Boolean_0 = value.bool_1;
			mlstGeoIPCountries.GClass5_0 = value.gclass5_0;
			mlstGeoIPCountries.IPListEntry_0 = value.iplistEntry_0;
			mlstGeoIPCountries.gclass7_0 = value.gclass7_0;
			mlstGeoIPCountries.gclass7_1 = value.gclass7_1;
			mlstGeoIPCountries.gclass7_2 = value.gclass7_2;
			mlstGeoIPCountries.bool_0 = value.bool_3;
			mlstGeoIPCountries.bool_1 = value.bool_4;
			mlstGeoIPCountries.bool_2 = value.bool_5;
			mlstGeoIPCountries.bool_3 = value.bool_6;
		}
	}

	protected override Button Button_0 => mbtnSave;

	public OptionsDialog(Class164 class164_1)
		: base(new Size(640, 600))
	{
		OnCheckedChanged();
		InitializeFormPosition();
		InitializeComponent();
		OnButtonOk();
		class164_0 = class164_1;
		OnButtonCancel();
	}

	private void InitializeComponent()
	{
		tabControl1.ImageList = new ImageList
		{
			ImageSize = new Size(24, 24),
			TransparentColor = Color.Transparent,
			ColorDepth = ColorDepth.Depth32Bit,
			Images = 
			{
				(Image)Resources.confg_24,
				(Image)((Class163.Class163_0.Boolean_0 ? true : false) ? Resources.cloud_24_dark : Resources.cloud_24),
				(Image)((Class163.Class163_0.Boolean_0 ? true : false) ? Resources.location_pin_24_dark : Resources.location_pin_24),
				(Image)Resources.button_24,
				(Image)Resources.environment_24,
				(Image)Resources.docs_24
			}
		};
		medEnableIPCloudHint.BackColor = mtabCloud.BackColor;
		ComboBox.ObjectCollection items = mcbLogVerbosityLevel.Items;
		object[] prop_ = GClass18.GClass18_0.Prop_1;
		object[] items2 = prop_;
		items.AddRange(items2);
		mlnkLogsView.Left = mlblLogSaveToFileHint.Right;
		mlnkLogSuccessfulLoginAttemptsConfiguration.Left = mchbLogSuccessfulLoginAttempts.Right;
	}

	private void OnButtonOk()
	{
		mlnkAdvancedBlockingSettings.Click += mlnkAdvancedBlockingSettings_Click;
		mcbProxyMode.SelectedIndexChanged += class0_0_SelectedIndexChanged;
		mchbProxyAuthentication.Click += mchbProxyAuthentication_Click;
		GClass3 gClass = mlnkLogsView;
		EventHandler value = _003C_003Ec._003C_003E9.method_0;
		gClass.Click += value;
		mchbLogRemoveOld.Click += mchbLogRemoveOld_Click;
		mlnkLogSuccessfulLoginAttemptsConfiguration.Click += mlnkLogSuccessfulLoginAttemptsConfiguration_Click;
		mchbEnableGeoIPEngine.CheckedChanged += mchbEnableGeoIPEngine_CheckedChanged;
		mrbGeoIPModeDeny.CheckedChanged += mrbGeoIPModeDeny_CheckedChanged;
		mrbGeoIPModeAllow.CheckedChanged += mrbGeoIPModeAllow_CheckedChanged;
		mlstGeoIPCountries.Event_0 += OnSelectedIndexChanged;
		mlnkGeoIPHelp.Click += mlnkGeoIPHelp_Click;
		tabControl1.SelectedIndexChanged += control14_0_SelectedIndexChanged;
		mbtnSave.Click += mbtnSave_Click;
		mbtnCancel.Click += mbtnCancel_Click;
	}

	private void OnButtonCancel()
	{
		mchbCheckForSoftwareUpdates.Checked = class164_0.class166_1.Boolean_0;
		mnumMaxFailedLogonAttempts.Value = class164_0.class166_2.Int32_0;
		mnumResetCountersAfter.Value = class164_0.class166_4.Int32_0;
		mnumAutoUnbanPeriod.Value = class164_0.class166_3.Int32_0;
		Class159_0 = class164_0.Class159_0;
		SaveSettings();
		GClass8_0 = class164_0.GClass8_0;
		ValidateInput();
		mchbEnableIPCloud.Checked = class164_0.class166_19.Boolean_0;
		Class132_0 = class164_0.Class132_0;
		mchbAllwaysShowSystemTrayIcon.Checked = Class163.Class163_0.class166_2.Boolean_0;
		mchbMinimizeToSystemTray.Checked = Class163.Class163_0.class166_3.Boolean_0;
		mchbCloseToSystemTray.Checked = Class163.Class163_0.class166_4.Boolean_0;
		mnumIPPageSize.Value = Class163.Class163_0.class166_7.Int32_0;
		ComboBox.ObjectCollection items = mcbColorTheme.Items;
		object[] prop_ = Class184.Class184_0.Prop_1;
		object[] items2 = prop_;
		items.AddRange(items2);
		mcbColorTheme.Text = Class184.Class184_0[Class163.Class163_0.Int32_0];
	}

	private void OnLoad()
	{
		class164_0.class166_1.Boolean_0 = mchbCheckForSoftwareUpdates.Checked;
		class164_0.class166_2.Int32_0 = (int)mnumMaxFailedLogonAttempts.Value;
		class164_0.class166_4.Int32_0 = (int)mnumResetCountersAfter.Value;
		class164_0.Class159_0 = Class159_0;
		class164_0.class166_3.Int32_0 = (int)mnumAutoUnbanPeriod.Value;
		class164_0.GClass8_0 = GClass8_0;
		class164_0.class166_19.Boolean_0 = mchbEnableIPCloud.Checked;
		class164_0.Class132_0 = Class132_0;
		Class163.Class163_0.class166_2.Boolean_0 = mchbAllwaysShowSystemTrayIcon.Checked;
		Class163.Class163_0.class166_3.Boolean_0 = mchbMinimizeToSystemTray.Checked;
		Class163.Class163_0.class166_4.Boolean_0 = mchbCloseToSystemTray.Checked;
		Class163.Class163_0.class166_7.Int32_0 = (int)mnumIPPageSize.Value;
		Class163.Class163_0.Int32_0 = Class184.Class184_0[mcbColorTheme.Text];
		Class163.Class163_0.method_3();
	}

	private void ValidateInput()
	{
		mnumLogRemoveOldLogsDays.Enabled = mchbLogRemoveOld.Checked;
		mlblLogRemoveOldHint.Enabled = mchbLogRemoveOld.Checked;
	}

	private void SaveSettings()
	{
		bool flag = 2 == mcbProxyMode.SelectedIndex;
		mlblProxyAddress.Enabled = flag;
		medProxyAddress.Enabled = flag;
		mlblProxyPort.Enabled = flag;
		mnumProxyPort.Enabled = flag;
		mchbProxyAuthentication.Enabled = flag;
		bool enabled = mchbProxyAuthentication.Checked && flag;
		mlblProxyUserName.Enabled = enabled;
		medProxyUsername.Enabled = enabled;
		mlblProxyPassword.Enabled = enabled;
		medProxyPassword.Enabled = enabled;
		mlblProxyDomain.Enabled = enabled;
		medProxyDomain.Enabled = enabled;
	}

	private void LoadSettings()
	{
		if (mrbGeoIPModeAllow.Checked)
		{
			gclass5_0 = mlstGeoIPCountries.GClass5_0;
		}
		else
		{
			gclass5_1 = mlstGeoIPCountries.GClass5_0;
		}
		mlstGeoIPCountries.GClass5_0 = ((mrbGeoIPModeAllow.Checked ? true : false) ? gclass5_1 : gclass5_0);
		mlstGeoIPCountries.GeoIPMode_0 = GeoIPMode_0;
		OnTextChanged();
	}

	private void OnTextChanged()
	{
		GClass5[] gClass5_ = mlstGeoIPCountries.GClass5_0;
		Func<GClass5, long> selector = _003C_003Ec._003C_003E9.method_1;
		bool visible = gClass5_.Select(selector).Sum() > 10000 && tabControl1.SelectedTab == mtabGeoIP && mchbEnableGeoIPEngine.Checked;
		mlblGeoIPWarning.Visible = visible;
		mlnkGeoIPHelp.Visible = visible;
	}

	private static string OnButtonOk(string string_1)
	{
		ProtocolRulesDialog form = new ProtocolRulesDialog
		{
			String_0 = "Exclusion Rules for Successful Logins",
			String_1 = "Exclusion Rules for Successful Logins",
			String_2 = "Specify rules to exclude certain successful login events from being logged",
			string_0 = Class148.Class151.String_1,
			String_3 = "Exclusion Rules:",
			String_4 = string_1,
			String_5 = "Define exclusion rules for successful login events. Refer to the online help for syntax."
		};
		using (form)
		{
			if (DialogResult.OK == form.ShowDialog())
			{
				return form.String_4;
			}
			return string_1;
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

	private void OnCheckedChanged()
	{
		tabControl1 = new Control14();
		mtabGeneral = new TabPage();
		mnumResetCountersAfter = new NumericUpDown();
		mlblResetCountersAfter = new Class62();
		mlblResetCountersAfterHint = new Class63();
		mlblAutoUnban = new Class62();
		mnumAutoUnbanPeriod = new NumericUpDown();
		mlblAutoUnbanHint = new Class63();
		mnumMaxFailedLogonAttempts = new NumericUpDown();
		mlblMaxFailedLogonAttempts = new Class62();
		mlblMaxFailedLogonAttemptsHint = new Class63();
		mchbCheckForSoftwareUpdatesHint = new Class62();
		mchbCheckForSoftwareUpdates = new Class61();
		mlnkAdvancedBlockingSettings = new GClass3();
		mtabCloud = new TabPage();
		medEnableIPCloudHint = new GClass2();
		mchbEnableIPCloud = new Class61();
		mtabGeoIP = new TabPage();
		mgbGeoIPMode = new Class65();
		mrbGeoIPModeAllow = new Class64();
		mrbGeoIPModeDeny = new Class64();
		mlstGeoIPCountries = new EditableGeoIPCountriesTable();
		mlblEnableGeoIPEngineHint = new Class63();
		mchbEnableGeoIPEngine = new Class61();
		mtabInterface = new TabPage();
		mlblColorThemeHint = new Class63();
		mcbColorTheme = new Class0();
		mlblColorTheme = new Class62();
		mnumIPPageSize = new NumericUpDown();
		mlblIPPageSize = new Class62();
		mlblIPPageSizeHint = new Class63();
		mchbCloseToSystemTrayTip = new Class62();
		mchbCloseToSystemTray = new Class61();
		mchbMinimizeToSystemTrayTip = new Class62();
		mlblShowSystrayIconTip = new Class62();
		mchbAllwaysShowSystemTrayIcon = new Class61();
		mchbMinimizeToSystemTray = new Class61();
		mtabConnection = new TabPage();
		mgbProxySettings = new Class65();
		medProxyDomain = new TextBox();
		mlblProxyDomain = new Class62();
		mcbProxyMode = new Class0();
		mnumProxyPort = new NumericUpDown();
		mchbProxyAuthentication = new Class61();
		medProxyPassword = new TextBox();
		mlblProxyPassword = new Class62();
		medProxyUsername = new TextBox();
		mlblProxyUserName = new Class62();
		mlblProxyPort = new Class62();
		medProxyAddress = new TextBox();
		mlblProxyAddress = new Class62();
		mtabLogging = new TabPage();
		mgbLogging = new Class65();
		mlnkLogSuccessfulLoginAttemptsConfiguration = new GClass3();
		mchbLogSuccessfulLoginAttemptsHint = new Class63();
		mchbLogSuccessfulLoginAttempts = new Class61();
		mnumLogRemoveOldLogsDays = new NumericUpDown();
		mlblLogRemoveOldHint = new Class63();
		mchbLogRemoveOld = new Class61();
		mlblLogVerbosityLevelHint = new Class63();
		mcbLogVerbosityLevel = new Class0();
		mlnkLogsView = new GClass3();
		mlblLogVerbosityLevel = new Class62();
		mlblLogSaveToFileHint = new Class63();
		mchbLogSaveToFile = new Class61();
		mbtnSave = new Class66();
		mbtnCancel = new Class66();
		label16 = new Class62();
		chbHideWhenMimimized = new Class61();
		mlblGeoIPWarning = new Class62();
		mlnkGeoIPHelp = new GClass3();
		tabControl1.SuspendLayout();
		mtabGeneral.SuspendLayout();
		((ISupportInitialize)mnumResetCountersAfter).BeginInit();
		((ISupportInitialize)mnumAutoUnbanPeriod).BeginInit();
		((ISupportInitialize)mnumMaxFailedLogonAttempts).BeginInit();
		mtabCloud.SuspendLayout();
		mtabGeoIP.SuspendLayout();
		mgbGeoIPMode.SuspendLayout();
		mtabInterface.SuspendLayout();
		((ISupportInitialize)mnumIPPageSize).BeginInit();
		mtabConnection.SuspendLayout();
		mgbProxySettings.SuspendLayout();
		((ISupportInitialize)mnumProxyPort).BeginInit();
		mtabLogging.SuspendLayout();
		mgbLogging.SuspendLayout();
		((ISupportInitialize)mnumLogRemoveOldLogsDays).BeginInit();
		SuspendLayout();
		tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		tabControl1.Controls.Add(mtabGeneral);
		tabControl1.Controls.Add(mtabCloud);
		tabControl1.Controls.Add(mtabGeoIP);
		tabControl1.Controls.Add(mtabInterface);
		tabControl1.Controls.Add(mtabConnection);
		tabControl1.Controls.Add(mtabLogging);
		tabControl1.ImeMode = ImeMode.Disable;
		tabControl1.ItemSize = new Size(96, 36);
		tabControl1.Location = new Point(12, 12);
		tabControl1.Multiline = true;
		tabControl1.Name = "tabControl1";
		tabControl1.Padding = new Point(6, 6);
		tabControl1.SelectedIndex = 0;
		tabControl1.Size = new Size(600, 490);
		tabControl1.SizeMode = TabSizeMode.FillToRight;
		tabControl1.TabIndex = 0;
		mtabGeneral.Controls.Add(mnumResetCountersAfter);
		mtabGeneral.Controls.Add(mlblResetCountersAfter);
		mtabGeneral.Controls.Add(mlblResetCountersAfterHint);
		mtabGeneral.Controls.Add(mlblAutoUnban);
		mtabGeneral.Controls.Add(mnumAutoUnbanPeriod);
		mtabGeneral.Controls.Add(mlblAutoUnbanHint);
		mtabGeneral.Controls.Add(mnumMaxFailedLogonAttempts);
		mtabGeneral.Controls.Add(mlblMaxFailedLogonAttempts);
		mtabGeneral.Controls.Add(mlblMaxFailedLogonAttemptsHint);
		mtabGeneral.Controls.Add(mchbCheckForSoftwareUpdatesHint);
		mtabGeneral.Controls.Add(mchbCheckForSoftwareUpdates);
		mtabGeneral.Controls.Add(mlnkAdvancedBlockingSettings);
		mtabGeneral.ImageIndex = 0;
		mtabGeneral.Location = new Point(4, 40);
		mtabGeneral.Name = "m_tabGeneral";
		mtabGeneral.Padding = new Padding(3);
		mtabGeneral.Size = new Size(592, 446);
		mtabGeneral.TabIndex = 0;
		mtabGeneral.Text = "General";
		mtabGeneral.UseVisualStyleBackColor = true;
		mnumResetCountersAfter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		mnumResetCountersAfter.Location = new Point(34, 184);
		mnumResetCountersAfter.Maximum = new decimal(new int[4] { 999, 0, 0, 0 });
		mnumResetCountersAfter.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		mnumResetCountersAfter.Name = "m_numResetCountersAfter";
		mnumResetCountersAfter.Size = new Size(552, 22);
		mnumResetCountersAfter.TabIndex = 2;
		mnumResetCountersAfter.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		mlblResetCountersAfter.AutoSize = true;
		mlblResetCountersAfter.Location = new Point(20, 163);
		mlblResetCountersAfter.Name = "m_lblResetCountersAfter";
		mlblResetCountersAfter.Size = new Size(314, 16);
		mlblResetCountersAfter.TabIndex = 31;
		mlblResetCountersAfter.Text = "Reset counters of failed logon attempts after (hours):";
		mlblResetCountersAfter.Boolean_0 = false;
		mlblResetCountersAfterHint.AutoSize = true;
		mlblResetCountersAfterHint.ForeColor = SystemColors.ControlDarkDark;
		mlblResetCountersAfterHint.Location = new Point(31, 209);
		mlblResetCountersAfterHint.Name = "m_lblResetCountersAfterHint";
		mlblResetCountersAfterHint.Size = new Size(508, 16);
		mlblResetCountersAfterHint.TabIndex = 30;
		mlblResetCountersAfterHint.Text = "Set the interval (in hours) after which the counters of failed logon attempts will be reset.";
		mlblResetCountersAfterHint.Boolean_0 = false;
		mlblAutoUnban.AutoSize = true;
		mlblAutoUnban.Location = new Point(20, 246);
		mlblAutoUnban.Name = "m_lblAutoUnban";
		mlblAutoUnban.Size = new Size(288, 16);
		mlblAutoUnban.TabIndex = 29;
		mlblAutoUnban.Text = "Unban IP addresses automatically after (hours):";
		mlblAutoUnban.Boolean_0 = false;
		mnumAutoUnbanPeriod.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		mnumAutoUnbanPeriod.Location = new Point(34, 267);
		mnumAutoUnbanPeriod.Maximum = new decimal(new int[4] { 8760, 0, 0, 0 });
		mnumAutoUnbanPeriod.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		mnumAutoUnbanPeriod.Name = "m_numAutoUnbanPeriod";
		mnumAutoUnbanPeriod.Size = new Size(552, 22);
		mnumAutoUnbanPeriod.TabIndex = 3;
		mnumAutoUnbanPeriod.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		mlblAutoUnbanHint.AutoSize = true;
		mlblAutoUnbanHint.ForeColor = SystemColors.ControlDarkDark;
		mlblAutoUnbanHint.Location = new Point(31, 292);
		mlblAutoUnbanHint.Name = "m_lblAutoUnbanHint";
		mlblAutoUnbanHint.Size = new Size(354, 16);
		mlblAutoUnbanHint.TabIndex = 26;
		mlblAutoUnbanHint.Text = "Specify how long should attacker's IP address be blocked.";
		mlblAutoUnbanHint.Boolean_0 = false;
		mnumMaxFailedLogonAttempts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		mnumMaxFailedLogonAttempts.Location = new Point(34, 101);
		mnumMaxFailedLogonAttempts.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		mnumMaxFailedLogonAttempts.Name = "m_numMaxFailedLogonAttempts";
		mnumMaxFailedLogonAttempts.Size = new Size(552, 22);
		mnumMaxFailedLogonAttempts.TabIndex = 1;
		mnumMaxFailedLogonAttempts.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		mlblMaxFailedLogonAttempts.AutoSize = true;
		mlblMaxFailedLogonAttempts.Location = new Point(20, 80);
		mlblMaxFailedLogonAttempts.Name = "m_lblMaxFailedLogonAttempts";
		mlblMaxFailedLogonAttempts.Size = new Size(341, 16);
		mlblMaxFailedLogonAttempts.TabIndex = 24;
		mlblMaxFailedLogonAttempts.Text = "Maximum failed logon attempts from a single IP address:";
		mlblMaxFailedLogonAttempts.Boolean_0 = false;
		mlblMaxFailedLogonAttemptsHint.AutoSize = true;
		mlblMaxFailedLogonAttemptsHint.ForeColor = SystemColors.ControlDarkDark;
		mlblMaxFailedLogonAttemptsHint.Location = new Point(31, 126);
		mlblMaxFailedLogonAttemptsHint.Name = "m_lblMaxFailedLogonAttemptsHint";
		mlblMaxFailedLogonAttemptsHint.Size = new Size(479, 16);
		mlblMaxFailedLogonAttemptsHint.TabIndex = 23;
		mlblMaxFailedLogonAttemptsHint.Text = "How many failed logon attempts should be received before banning IP address.";
		mlblMaxFailedLogonAttemptsHint.Boolean_0 = false;
		mchbCheckForSoftwareUpdatesHint.AutoSize = true;
		mchbCheckForSoftwareUpdatesHint.ForeColor = SystemColors.ControlDarkDark;
		mchbCheckForSoftwareUpdatesHint.Location = new Point(20, 43);
		mchbCheckForSoftwareUpdatesHint.Name = "m_chbCheckForSoftwareUpdatesHint";
		mchbCheckForSoftwareUpdatesHint.Size = new Size(452, 16);
		mchbCheckForSoftwareUpdatesHint.TabIndex = 21;
		mchbCheckForSoftwareUpdatesHint.Text = "RdpGuard will check for updates and notify you when new version available";
		mchbCheckForSoftwareUpdatesHint.Boolean_0 = false;
		mchbCheckForSoftwareUpdates.AutoSize = true;
		mchbCheckForSoftwareUpdates.Location = new Point(23, 20);
		mchbCheckForSoftwareUpdates.Name = "m_chbCheckForSoftwareUpdates";
		mchbCheckForSoftwareUpdates.Size = new Size(274, 20);
		mchbCheckForSoftwareUpdates.TabIndex = 0;
		mchbCheckForSoftwareUpdates.Text = "Automatically check for software updates  ";
		mchbCheckForSoftwareUpdates.UseVisualStyleBackColor = true;
		mlnkAdvancedBlockingSettings.AutoSize = true;
		mlnkAdvancedBlockingSettings.LinkBehavior = LinkBehavior.NeverUnderline;
		mlnkAdvancedBlockingSettings.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkAdvancedBlockingSettings.Location = new Point(20, 326);
		mlnkAdvancedBlockingSettings.Name = "m_lnkAdvancedBlockingSettings";
		mlnkAdvancedBlockingSettings.Size = new Size(177, 16);
		mlnkAdvancedBlockingSettings.TabIndex = 7;
		mlnkAdvancedBlockingSettings.TabStop = true;
		mlnkAdvancedBlockingSettings.Text = "advanced blocking settings..";
		mlnkAdvancedBlockingSettings.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		mtabCloud.Controls.Add(medEnableIPCloudHint);
		mtabCloud.Controls.Add(mchbEnableIPCloud);
		mtabCloud.ImageIndex = 1;
		mtabCloud.Location = new Point(4, 40);
		mtabCloud.Name = "m_tabCloud";
		mtabCloud.Padding = new Padding(3);
		mtabCloud.Size = new Size(592, 446);
		mtabCloud.TabIndex = 8;
		mtabCloud.Text = "IP Cloud";
		mtabCloud.UseVisualStyleBackColor = true;
		medEnableIPCloudHint.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		medEnableIPCloudHint.BackColor = SystemColors.Control;
		medEnableIPCloudHint.BorderStyle = BorderStyle.None;
		medEnableIPCloudHint.Cursor = Cursors.Default;
		medEnableIPCloudHint.ForeColor = SystemColors.ControlDarkDark;
		medEnableIPCloudHint.Location = new Point(23, 46);
		medEnableIPCloudHint.Multiline = true;
		medEnableIPCloudHint.Name = "m_edEnableIPCloudHint";
		medEnableIPCloudHint.ReadOnly = true;
		medEnableIPCloudHint.Size = new Size(563, 52);
		medEnableIPCloudHint.TabIndex = 25;
		medEnableIPCloudHint.TabStop = false;
		medEnableIPCloudHint.Text = "Enable this option for preemptive blocking of IP addresses detected by other participants. Any attacks detected on your PC will also be reported to the cloud.";
		medEnableIPCloudHint.Boolean_0 = false;
		mchbEnableIPCloud.AutoSize = true;
		mchbEnableIPCloud.Location = new Point(23, 20);
		mchbEnableIPCloud.Name = "m_chbEnableIPCloud";
		mchbEnableIPCloud.Size = new Size(188, 20);
		mchbEnableIPCloud.TabIndex = 24;
		mchbEnableIPCloud.Text = "Enable RdpGuard IP Cloud";
		mchbEnableIPCloud.UseVisualStyleBackColor = true;
		mtabGeoIP.Controls.Add(mgbGeoIPMode);
		mtabGeoIP.Controls.Add(mlstGeoIPCountries);
		mtabGeoIP.Controls.Add(mlblEnableGeoIPEngineHint);
		mtabGeoIP.Controls.Add(mchbEnableGeoIPEngine);
		mtabGeoIP.ImageIndex = 2;
		mtabGeoIP.Location = new Point(4, 40);
		mtabGeoIP.Name = "m_tabGeoIP";
		mtabGeoIP.Padding = new Padding(3);
		mtabGeoIP.Size = new Size(592, 446);
		mtabGeoIP.TabIndex = 7;
		mtabGeoIP.Text = "GeoIP";
		mtabGeoIP.UseVisualStyleBackColor = true;
		mgbGeoIPMode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		mgbGeoIPMode.Controls.Add(mrbGeoIPModeAllow);
		mgbGeoIPMode.Controls.Add(mrbGeoIPModeDeny);
		mgbGeoIPMode.Enabled = false;
		mgbGeoIPMode.Location = new Point(9, 75);
		mgbGeoIPMode.Name = "m_gbGeoIPMode";
		mgbGeoIPMode.Size = new Size(576, 83);
		mgbGeoIPMode.TabIndex = 28;
		mgbGeoIPMode.TabStop = false;
		mgbGeoIPMode.Text = "Geo-IP mode:";
		mrbGeoIPModeAllow.AutoSize = true;
		mrbGeoIPModeAllow.Location = new Point(17, 50);
		mrbGeoIPModeAllow.Name = "m_rbGeoIPModeAllow";
		mrbGeoIPModeAllow.Size = new Size(363, 20);
		mrbGeoIPModeAllow.TabIndex = 2;
		mrbGeoIPModeAllow.TabStop = true;
		mrbGeoIPModeAllow.Text = "Allow specific countries (all other countries will be denied)";
		mrbGeoIPModeAllow.UseVisualStyleBackColor = true;
		mrbGeoIPModeDeny.AutoSize = true;
		mrbGeoIPModeDeny.Location = new Point(17, 24);
		mrbGeoIPModeDeny.Name = "m_rbGeoIPModeDeny";
		mrbGeoIPModeDeny.Size = new Size(379, 20);
		mrbGeoIPModeDeny.TabIndex = 1;
		mrbGeoIPModeDeny.TabStop = true;
		mrbGeoIPModeDeny.Text = "Deny specific countries (all other countries will have access)";
		mrbGeoIPModeDeny.UseVisualStyleBackColor = true;
		mlstGeoIPCountries.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		mlstGeoIPCountries.GClass5_0 = new GClass5[0];
		mlstGeoIPCountries.IPListEntry_0 = new IPListEntry[0];
		mlstGeoIPCountries.Boolean_0 = false;
		mlstGeoIPCountries.Enabled = false;
		mlstGeoIPCountries.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		mlstGeoIPCountries.Location = new Point(9, 165);
		mlstGeoIPCountries.Margin = new Padding(4);
		mlstGeoIPCountries.Name = "m_lstGeoIPCountries";
		mlstGeoIPCountries.Size = new Size(576, 274);
		mlstGeoIPCountries.TabIndex = 25;
		mlblEnableGeoIPEngineHint.AutoSize = true;
		mlblEnableGeoIPEngineHint.ForeColor = SystemColors.ControlDarkDark;
		mlblEnableGeoIPEngineHint.Location = new Point(20, 43);
		mlblEnableGeoIPEngineHint.Name = "m_lblEnableGeoIPEngineHint";
		mlblEnableGeoIPEngineHint.Size = new Size(359, 16);
		mlblEnableGeoIPEngineHint.TabIndex = 23;
		mlblEnableGeoIPEngineHint.Text = "Block or allow access to your server from specific countries.";
		mlblEnableGeoIPEngineHint.Boolean_0 = false;
		mchbEnableGeoIPEngine.AutoSize = true;
		mchbEnableGeoIPEngine.Location = new Point(23, 20);
		mchbEnableGeoIPEngine.Name = "m_chbEnableGeoIPEngine";
		mchbEnableGeoIPEngine.Size = new Size(114, 20);
		mchbEnableGeoIPEngine.TabIndex = 22;
		mchbEnableGeoIPEngine.Text = "Enable Geo-IP";
		mchbEnableGeoIPEngine.UseVisualStyleBackColor = true;
		mtabInterface.Controls.Add(mlblColorThemeHint);
		mtabInterface.Controls.Add(mcbColorTheme);
		mtabInterface.Controls.Add(mlblColorTheme);
		mtabInterface.Controls.Add(mnumIPPageSize);
		mtabInterface.Controls.Add(mlblIPPageSize);
		mtabInterface.Controls.Add(mlblIPPageSizeHint);
		mtabInterface.Controls.Add(mchbCloseToSystemTrayTip);
		mtabInterface.Controls.Add(mchbCloseToSystemTray);
		mtabInterface.Controls.Add(mchbMinimizeToSystemTrayTip);
		mtabInterface.Controls.Add(mlblShowSystrayIconTip);
		mtabInterface.Controls.Add(mchbAllwaysShowSystemTrayIcon);
		mtabInterface.Controls.Add(mchbMinimizeToSystemTray);
		mtabInterface.ImageIndex = 3;
		mtabInterface.Location = new Point(4, 40);
		mtabInterface.Name = "m_tabInterface";
		mtabInterface.Padding = new Padding(3);
		mtabInterface.Size = new Size(592, 446);
		mtabInterface.TabIndex = 2;
		mtabInterface.Text = "Interface";
		mtabInterface.UseVisualStyleBackColor = true;
		mlblColorThemeHint.AutoSize = true;
		mlblColorThemeHint.ForeColor = SystemColors.ControlDarkDark;
		mlblColorThemeHint.Location = new Point(29, 311);
		mlblColorThemeHint.Name = "m_lblColorThemeHint";
		mlblColorThemeHint.Size = new Size(385, 16);
		mlblColorThemeHint.TabIndex = 33;
		mlblColorThemeHint.Text = "Changing the theme requires an application restart to take effect.";
		mlblColorThemeHint.Boolean_0 = false;
		mcbColorTheme.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		mcbColorTheme.DropDownStyle = ComboBoxStyle.DropDownList;
		mcbColorTheme.FormattingEnabled = true;
		mcbColorTheme.Location = new Point(32, 284);
		mcbColorTheme.Name = "m_cbColorTheme";
		mcbColorTheme.Size = new Size(554, 24);
		mcbColorTheme.TabIndex = 32;
		mlblColorTheme.AutoSize = true;
		mlblColorTheme.Location = new Point(20, 265);
		mlblColorTheme.Name = "m_lblColorTheme";
		mlblColorTheme.Size = new Size(82, 16);
		mlblColorTheme.TabIndex = 31;
		mlblColorTheme.Text = "Color theme:";
		mlblColorTheme.Boolean_0 = false;
		mnumIPPageSize.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		mnumIPPageSize.Location = new Point(32, 207);
		mnumIPPageSize.Maximum = new decimal(new int[4] { 5000, 0, 0, 0 });
		mnumIPPageSize.Minimum = new decimal(new int[4] { 10, 0, 0, 0 });
		mnumIPPageSize.Name = "m_numIPPageSize";
		mnumIPPageSize.Size = new Size(554, 22);
		mnumIPPageSize.TabIndex = 28;
		mnumIPPageSize.Value = new decimal(new int[4] { 100, 0, 0, 0 });
		mlblIPPageSize.AutoSize = true;
		mlblIPPageSize.Location = new Point(20, 188);
		mlblIPPageSize.Name = "m_lblIPPageSize";
		mlblIPPageSize.Size = new Size(270, 16);
		mlblIPPageSize.TabIndex = 30;
		mlblIPPageSize.Text = "Maximum number of IP addresses per page:";
		mlblIPPageSize.Boolean_0 = false;
		mlblIPPageSizeHint.AutoSize = true;
		mlblIPPageSizeHint.ForeColor = SystemColors.ControlDarkDark;
		mlblIPPageSizeHint.Location = new Point(29, 232);
		mlblIPPageSizeHint.Name = "m_lblIPPageSizeHint";
		mlblIPPageSizeHint.Size = new Size(531, 16);
		mlblIPPageSizeHint.TabIndex = 29;
		mlblIPPageSizeHint.Text = "The number of IP addresses to show on a single page in the Blocked IP Addresses table";
		mlblIPPageSizeHint.Boolean_0 = false;
		mchbCloseToSystemTrayTip.AutoSize = true;
		mchbCloseToSystemTrayTip.ForeColor = SystemColors.ControlDarkDark;
		mchbCloseToSystemTrayTip.Location = new Point(20, 155);
		mchbCloseToSystemTrayTip.Name = "m_chbCloseToSystemTrayTip";
		mchbCloseToSystemTrayTip.Size = new Size(265, 16);
		mchbCloseToSystemTrayTip.TabIndex = 27;
		mchbCloseToSystemTrayTip.Text = "Hide RdpGuard to system tray when closed";
		mchbCloseToSystemTrayTip.Boolean_0 = false;
		mchbCloseToSystemTray.AutoSize = true;
		mchbCloseToSystemTray.Location = new Point(23, 132);
		mchbCloseToSystemTray.Name = "m_chbCloseToSystemTray";
		mchbCloseToSystemTray.Size = new Size(146, 20);
		mchbCloseToSystemTray.TabIndex = 2;
		mchbCloseToSystemTray.Text = "Close to system tray";
		mchbCloseToSystemTray.UseVisualStyleBackColor = true;
		mchbMinimizeToSystemTrayTip.AutoSize = true;
		mchbMinimizeToSystemTrayTip.ForeColor = SystemColors.ControlDarkDark;
		mchbMinimizeToSystemTrayTip.Location = new Point(20, 99);
		mchbMinimizeToSystemTrayTip.Name = "m_chbMinimizeToSystemTrayTip";
		mchbMinimizeToSystemTrayTip.Size = new Size(284, 16);
		mchbMinimizeToSystemTrayTip.TabIndex = 25;
		mchbMinimizeToSystemTrayTip.Text = "Hide RdpGuard to system tray when minimized";
		mchbMinimizeToSystemTrayTip.Boolean_0 = false;
		mlblShowSystrayIconTip.AutoSize = true;
		mlblShowSystrayIconTip.ForeColor = SystemColors.ControlDarkDark;
		mlblShowSystrayIconTip.Location = new Point(20, 43);
		mlblShowSystrayIconTip.Name = "m_lblShowSystrayIconTip";
		mlblShowSystrayIconTip.Size = new Size(390, 16);
		mlblShowSystrayIconTip.TabIndex = 24;
		mlblShowSystrayIconTip.Text = "This check toggles whether RdpGuard has an icon in system tray";
		mlblShowSystrayIconTip.Boolean_0 = false;
		mchbAllwaysShowSystemTrayIcon.AutoSize = true;
		mchbAllwaysShowSystemTrayIcon.Location = new Point(23, 20);
		mchbAllwaysShowSystemTrayIcon.Name = "m_chbAllwaysShowSystemTrayIcon";
		mchbAllwaysShowSystemTrayIcon.Size = new Size(281, 20);
		mchbAllwaysShowSystemTrayIcon.TabIndex = 0;
		mchbAllwaysShowSystemTrayIcon.Text = "Always show RdpGuard icon in system tray";
		mchbAllwaysShowSystemTrayIcon.UseVisualStyleBackColor = true;
		mchbMinimizeToSystemTray.AutoSize = true;
		mchbMinimizeToSystemTray.Location = new Point(23, 76);
		mchbMinimizeToSystemTray.Name = "m_chbMinimizeToSystemTray";
		mchbMinimizeToSystemTray.Size = new Size(163, 20);
		mchbMinimizeToSystemTray.TabIndex = 1;
		mchbMinimizeToSystemTray.Text = "Minimize to system tray";
		mchbMinimizeToSystemTray.UseVisualStyleBackColor = true;
		mtabConnection.Controls.Add(mgbProxySettings);
		mtabConnection.ImageIndex = 4;
		mtabConnection.Location = new Point(4, 40);
		mtabConnection.Name = "m_tabConnection";
		mtabConnection.Padding = new Padding(3);
		mtabConnection.Size = new Size(592, 446);
		mtabConnection.TabIndex = 6;
		mtabConnection.Text = "Connection";
		mtabConnection.UseVisualStyleBackColor = true;
		mgbProxySettings.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		mgbProxySettings.Controls.Add(medProxyDomain);
		mgbProxySettings.Controls.Add(mlblProxyDomain);
		mgbProxySettings.Controls.Add(mcbProxyMode);
		mgbProxySettings.Controls.Add(mnumProxyPort);
		mgbProxySettings.Controls.Add(mchbProxyAuthentication);
		mgbProxySettings.Controls.Add(medProxyPassword);
		mgbProxySettings.Controls.Add(mlblProxyPassword);
		mgbProxySettings.Controls.Add(medProxyUsername);
		mgbProxySettings.Controls.Add(mlblProxyUserName);
		mgbProxySettings.Controls.Add(mlblProxyPort);
		mgbProxySettings.Controls.Add(medProxyAddress);
		mgbProxySettings.Controls.Add(mlblProxyAddress);
		mgbProxySettings.Location = new Point(6, 6);
		mgbProxySettings.Name = "m_gbProxySettings";
		mgbProxySettings.Size = new Size(580, 414);
		mgbProxySettings.TabIndex = 47;
		mgbProxySettings.TabStop = false;
		mgbProxySettings.Text = "Proxy";
		medProxyDomain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		medProxyDomain.Location = new Point(29, 375);
		medProxyDomain.Name = "m_edProxyDomain";
		medProxyDomain.Size = new Size(545, 22);
		medProxyDomain.TabIndex = 6;
		mlblProxyDomain.AutoSize = true;
		mlblProxyDomain.Location = new Point(15, 350);
		mlblProxyDomain.Name = "m_lblProxyDomain";
		mlblProxyDomain.Size = new Size(57, 16);
		mlblProxyDomain.TabIndex = 10;
		mlblProxyDomain.Text = "Domain:";
		mlblProxyDomain.Boolean_0 = false;
		mcbProxyMode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		mcbProxyMode.DropDownStyle = ComboBoxStyle.DropDownList;
		mcbProxyMode.FormattingEnabled = true;
		mcbProxyMode.Items.AddRange(new object[3] { "Do not use proxy (direct connection)", "Autodetect proxy settings", "Use proxy settings below" });
		mcbProxyMode.Location = new Point(17, 30);
		mcbProxyMode.Name = "m_cbProxyMode";
		mcbProxyMode.Size = new Size(557, 24);
		mcbProxyMode.TabIndex = 0;
		mnumProxyPort.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		mnumProxyPort.Location = new Point(17, 150);
		mnumProxyPort.Maximum = new decimal(new int[4] { 65535, 0, 0, 0 });
		mnumProxyPort.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		mnumProxyPort.Name = "m_numProxyPort";
		mnumProxyPort.Size = new Size(557, 22);
		mnumProxyPort.TabIndex = 2;
		mnumProxyPort.Value = new decimal(new int[4] { 8080, 0, 0, 0 });
		mchbProxyAuthentication.AutoSize = true;
		mchbProxyAuthentication.Location = new Point(9, 195);
		mchbProxyAuthentication.Name = "m_chbProxyAuthentication";
		mchbProxyAuthentication.Size = new Size(258, 20);
		mchbProxyAuthentication.TabIndex = 3;
		mchbProxyAuthentication.Text = "My proxy server requires authentication";
		mchbProxyAuthentication.UseVisualStyleBackColor = true;
		medProxyPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		medProxyPassword.Location = new Point(29, 315);
		medProxyPassword.Name = "m_edProxyPassword";
		medProxyPassword.Size = new Size(545, 22);
		medProxyPassword.TabIndex = 5;
		medProxyPassword.UseSystemPasswordChar = true;
		mlblProxyPassword.AutoSize = true;
		mlblProxyPassword.Location = new Point(15, 290);
		mlblProxyPassword.Name = "m_lblProxyPassword";
		mlblProxyPassword.Size = new Size(70, 16);
		mlblProxyPassword.TabIndex = 7;
		mlblProxyPassword.Text = "Password:";
		mlblProxyPassword.Boolean_0 = false;
		medProxyUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		medProxyUsername.Location = new Point(29, 255);
		medProxyUsername.Name = "m_edProxyUsername";
		medProxyUsername.Size = new Size(545, 22);
		medProxyUsername.TabIndex = 4;
		mlblProxyUserName.AutoSize = true;
		mlblProxyUserName.Location = new Point(15, 230);
		mlblProxyUserName.Name = "m_lblProxyUserName";
		mlblProxyUserName.Size = new Size(73, 16);
		mlblProxyUserName.TabIndex = 5;
		mlblProxyUserName.Text = "Username:";
		mlblProxyUserName.Boolean_0 = false;
		mlblProxyPort.AutoSize = true;
		mlblProxyPort.Location = new Point(6, 125);
		mlblProxyPort.Name = "m_lblProxyPort";
		mlblProxyPort.Size = new Size(34, 16);
		mlblProxyPort.TabIndex = 3;
		mlblProxyPort.Text = "Port:";
		mlblProxyPort.Boolean_0 = false;
		medProxyAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		medProxyAddress.Location = new Point(17, 90);
		medProxyAddress.Name = "m_edProxyAddress";
		medProxyAddress.Size = new Size(557, 22);
		medProxyAddress.TabIndex = 1;
		mlblProxyAddress.AutoSize = true;
		mlblProxyAddress.Location = new Point(6, 65);
		mlblProxyAddress.Name = "m_lblProxyAddress";
		mlblProxyAddress.Size = new Size(61, 16);
		mlblProxyAddress.TabIndex = 0;
		mlblProxyAddress.Text = "Address:";
		mlblProxyAddress.Boolean_0 = false;
		mtabLogging.Controls.Add(mgbLogging);
		mtabLogging.ImageIndex = 5;
		mtabLogging.Location = new Point(4, 40);
		mtabLogging.Name = "m_tabLogging";
		mtabLogging.Padding = new Padding(3);
		mtabLogging.Size = new Size(592, 446);
		mtabLogging.TabIndex = 5;
		mtabLogging.Text = "Logging";
		mtabLogging.UseVisualStyleBackColor = true;
		mgbLogging.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		mgbLogging.Controls.Add(mlnkLogSuccessfulLoginAttemptsConfiguration);
		mgbLogging.Controls.Add(mchbLogSuccessfulLoginAttemptsHint);
		mgbLogging.Controls.Add(mchbLogSuccessfulLoginAttempts);
		mgbLogging.Controls.Add(mnumLogRemoveOldLogsDays);
		mgbLogging.Controls.Add(mlblLogRemoveOldHint);
		mgbLogging.Controls.Add(mchbLogRemoveOld);
		mgbLogging.Controls.Add(mlblLogVerbosityLevelHint);
		mgbLogging.Controls.Add(mcbLogVerbosityLevel);
		mgbLogging.Controls.Add(mlnkLogsView);
		mgbLogging.Controls.Add(mlblLogVerbosityLevel);
		mgbLogging.Controls.Add(mlblLogSaveToFileHint);
		mgbLogging.Controls.Add(mchbLogSaveToFile);
		mgbLogging.Location = new Point(6, 6);
		mgbLogging.Name = "m_gbLogging";
		mgbLogging.Size = new Size(580, 308);
		mgbLogging.TabIndex = 45;
		mgbLogging.TabStop = false;
		mgbLogging.Text = "Logging:";
		mlnkLogSuccessfulLoginAttemptsConfiguration.AutoSize = true;
		mlnkLogSuccessfulLoginAttemptsConfiguration.LinkBehavior = LinkBehavior.NeverUnderline;
		mlnkLogSuccessfulLoginAttemptsConfiguration.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkLogSuccessfulLoginAttemptsConfiguration.Location = new Point(303, 253);
		mlnkLogSuccessfulLoginAttemptsConfiguration.Margin = new Padding(0);
		mlnkLogSuccessfulLoginAttemptsConfiguration.Name = "m_lnkLogSuccessfulLoginAttemptsConfiguration";
		mlnkLogSuccessfulLoginAttemptsConfiguration.Size = new Size(68, 16);
		mlnkLogSuccessfulLoginAttemptsConfiguration.TabIndex = 53;
		mlnkLogSuccessfulLoginAttemptsConfiguration.TabStop = true;
		mlnkLogSuccessfulLoginAttemptsConfiguration.Text = "configure..";
		mlnkLogSuccessfulLoginAttemptsConfiguration.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		mchbLogSuccessfulLoginAttemptsHint.AutoSize = true;
		mchbLogSuccessfulLoginAttemptsHint.ForeColor = SystemColors.ControlDarkDark;
		mchbLogSuccessfulLoginAttemptsHint.Location = new Point(14, 275);
		mchbLogSuccessfulLoginAttemptsHint.Margin = new Padding(0);
		mchbLogSuccessfulLoginAttemptsHint.Name = "m_chbLogSuccessfulLoginAttemptsHint";
		mchbLogSuccessfulLoginAttemptsHint.Size = new Size(409, 16);
		mchbLogSuccessfulLoginAttemptsHint.TabIndex = 54;
		mchbLogSuccessfulLoginAttemptsHint.Text = "This option enables or disables logging of successful login attempts";
		mchbLogSuccessfulLoginAttemptsHint.Boolean_0 = false;
		mchbLogSuccessfulLoginAttempts.AutoSize = true;
		mchbLogSuccessfulLoginAttempts.Location = new Point(17, 252);
		mchbLogSuccessfulLoginAttempts.Name = "m_chbLogSuccessfulLoginAttempts";
		mchbLogSuccessfulLoginAttempts.Size = new Size(283, 20);
		mchbLogSuccessfulLoginAttempts.TabIndex = 52;
		mchbLogSuccessfulLoginAttempts.Text = "Enable logging of successful login attempts";
		mchbLogSuccessfulLoginAttempts.UseVisualStyleBackColor = true;
		mnumLogRemoveOldLogsDays.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		mnumLogRemoveOldLogsDays.Location = new Point(17, 109);
		mnumLogRemoveOldLogsDays.Maximum = new decimal(new int[4] { 365, 0, 0, 0 });
		mnumLogRemoveOldLogsDays.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		mnumLogRemoveOldLogsDays.Name = "m_numLogRemoveOldLogsDays";
		mnumLogRemoveOldLogsDays.Size = new Size(557, 22);
		mnumLogRemoveOldLogsDays.TabIndex = 11;
		mnumLogRemoveOldLogsDays.Value = new decimal(new int[4] { 30, 0, 0, 0 });
		mlblLogRemoveOldHint.AutoSize = true;
		mlblLogRemoveOldHint.ForeColor = SystemColors.ControlDarkDark;
		mlblLogRemoveOldHint.Location = new Point(14, 136);
		mlblLogRemoveOldHint.Name = "m_lblLogRemoveOldHint";
		mlblLogRemoveOldHint.Size = new Size(376, 16);
		mlblLogRemoveOldHint.TabIndex = 51;
		mlblLogRemoveOldHint.Text = "Specify the number of days after which old logs will be deleted.";
		mlblLogRemoveOldHint.Boolean_0 = false;
		mchbLogRemoveOld.AutoSize = true;
		mchbLogRemoveOld.Location = new Point(17, 83);
		mchbLogRemoveOld.Name = "m_chbLogRemoveOld";
		mchbLogRemoveOld.Size = new Size(233, 20);
		mchbLogRemoveOld.TabIndex = 10;
		mchbLogRemoveOld.Text = "Remove log files older than (days):";
		mchbLogRemoveOld.UseVisualStyleBackColor = true;
		mlblLogVerbosityLevelHint.AutoSize = true;
		mlblLogVerbosityLevelHint.ForeColor = SystemColors.ControlDarkDark;
		mlblLogVerbosityLevelHint.Location = new Point(14, 219);
		mlblLogVerbosityLevelHint.Name = "m_lblLogVerbosityLevelHint";
		mlblLogVerbosityLevelHint.Size = new Size(563, 16);
		mlblLogVerbosityLevelHint.TabIndex = 48;
		mlblLogVerbosityLevelHint.Text = "Choose the log detail level: verbose (detailed), brief (summarized), or errors and warnings only";
		mlblLogVerbosityLevelHint.Boolean_0 = false;
		mcbLogVerbosityLevel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		mcbLogVerbosityLevel.DropDownStyle = ComboBoxStyle.DropDownList;
		mcbLogVerbosityLevel.FormattingEnabled = true;
		mcbLogVerbosityLevel.Location = new Point(17, 190);
		mcbLogVerbosityLevel.Name = "m_cbLogVerbosityLevel";
		mcbLogVerbosityLevel.Size = new Size(557, 24);
		mcbLogVerbosityLevel.TabIndex = 20;
		mlnkLogsView.AutoSize = true;
		mlnkLogsView.LinkBehavior = LinkBehavior.NeverUnderline;
		mlnkLogsView.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkLogsView.Location = new Point(352, 50);
		mlnkLogsView.Margin = new Padding(0);
		mlnkLogsView.Name = "m_lnkLogsView";
		mlnkLogsView.Size = new Size(89, 16);
		mlnkLogsView.TabIndex = 1;
		mlnkLogsView.TabStop = true;
		mlnkLogsView.Text = "view log files..";
		mlnkLogsView.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		mlblLogVerbosityLevel.AutoSize = true;
		mlblLogVerbosityLevel.Location = new Point(14, 168);
		mlblLogVerbosityLevel.Name = "m_lblLogVerbosityLevel";
		mlblLogVerbosityLevel.Size = new Size(96, 16);
		mlblLogVerbosityLevel.TabIndex = 3;
		mlblLogVerbosityLevel.Text = "Verbosity level";
		mlblLogVerbosityLevel.Boolean_0 = false;
		mlblLogSaveToFileHint.AutoSize = true;
		mlblLogSaveToFileHint.ForeColor = SystemColors.ControlDarkDark;
		mlblLogSaveToFileHint.Location = new Point(14, 50);
		mlblLogSaveToFileHint.Margin = new Padding(0);
		mlblLogSaveToFileHint.Name = "m_lblLogSaveToFileHint";
		mlblLogSaveToFileHint.Size = new Size(338, 16);
		mlblLogSaveToFileHint.TabIndex = 46;
		mlblLogSaveToFileHint.Text = "If checked, all log messages will be saved to the log file,";
		mlblLogSaveToFileHint.Boolean_0 = false;
		mchbLogSaveToFile.AutoSize = true;
		mchbLogSaveToFile.Location = new Point(17, 27);
		mchbLogSaveToFile.Name = "m_chbLogSaveToFile";
		mchbLogSaveToFile.Size = new Size(150, 20);
		mchbLogSaveToFile.TabIndex = 0;
		mchbLogSaveToFile.Text = "Save event log to file";
		mchbLogSaveToFile.UseVisualStyleBackColor = true;
		mbtnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mbtnSave.Image = Resources.opts_16;
		mbtnSave.Location = new Point(403, 512);
		mbtnSave.Margin = new Padding(4);
		mbtnSave.Name = "m_btnSave";
		mbtnSave.Size = new Size(100, 36);
		mbtnSave.TabIndex = 99;
		mbtnSave.Text = "Save";
		mbtnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
		mbtnSave.UseVisualStyleBackColor = true;
		mbtnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mbtnCancel.Image = Resources.cancl_16;
		mbtnCancel.Location = new Point(511, 512);
		mbtnCancel.Margin = new Padding(4);
		mbtnCancel.Name = "m_btnCancel";
		mbtnCancel.Size = new Size(100, 36);
		mbtnCancel.TabIndex = 100;
		mbtnCancel.Text = "Cancel";
		mbtnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
		mbtnCancel.UseVisualStyleBackColor = true;
		label16.AutoSize = true;
		label16.Location = new Point(33, 54);
		label16.Name = "label16";
		label16.Size = new Size(48, 13);
		label16.TabIndex = 0;
		label16.Text = "Address:";
		label16.Boolean_0 = false;
		chbHideWhenMimimized.Location = new Point(0, 0);
		chbHideWhenMimimized.Name = "chbHideWhenMimimized";
		chbHideWhenMimimized.Size = new Size(104, 24);
		chbHideWhenMimimized.TabIndex = 0;
		mlblGeoIPWarning.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		mlblGeoIPWarning.AutoSize = true;
		mlblGeoIPWarning.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		mlblGeoIPWarning.ForeColor = Color.Red;
		mlblGeoIPWarning.Location = new Point(9, 507);
		mlblGeoIPWarning.Name = "m_lblGeoIPWarning";
		mlblGeoIPWarning.Size = new Size(336, 16);
		mlblGeoIPWarning.TabIndex = 101;
		mlblGeoIPWarning.Text = "Please keep the number of entries as short as possible,";
		mlblGeoIPWarning.Boolean_0 = true;
		mlblGeoIPWarning.Visible = false;
		mlnkGeoIPHelp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		mlnkGeoIPHelp.AutoSize = true;
		mlnkGeoIPHelp.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		mlnkGeoIPHelp.LinkBehavior = LinkBehavior.NeverUnderline;
		mlnkGeoIPHelp.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkGeoIPHelp.Location = new Point(9, 530);
		mlnkGeoIPHelp.Margin = new Padding(0);
		mlnkGeoIPHelp.Name = "m_lnkGeoIPHelp";
		mlnkGeoIPHelp.RightToLeft = RightToLeft.No;
		mlnkGeoIPHelp.Size = new Size(165, 16);
		mlnkGeoIPHelp.TabIndex = 102;
		mlnkGeoIPHelp.TabStop = true;
		mlnkGeoIPHelp.Text = "click here for more details..";
		mlnkGeoIPHelp.Visible = false;
		mlnkGeoIPHelp.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(624, 561);
		base.Controls.Add(mlnkGeoIPHelp);
		base.Controls.Add(mlblGeoIPWarning);
		base.Controls.Add(mbtnSave);
		base.Controls.Add(mbtnCancel);
		base.Controls.Add(tabControl1);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Name = "OptionsDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "RdpGuard Options";
		tabControl1.ResumeLayout(performLayout: false);
		mtabGeneral.ResumeLayout(performLayout: false);
		mtabGeneral.PerformLayout();
		((ISupportInitialize)mnumResetCountersAfter).EndInit();
		((ISupportInitialize)mnumAutoUnbanPeriod).EndInit();
		((ISupportInitialize)mnumMaxFailedLogonAttempts).EndInit();
		mtabCloud.ResumeLayout(performLayout: false);
		mtabCloud.PerformLayout();
		mtabGeoIP.ResumeLayout(performLayout: false);
		mtabGeoIP.PerformLayout();
		mgbGeoIPMode.ResumeLayout(performLayout: false);
		mgbGeoIPMode.PerformLayout();
		mtabInterface.ResumeLayout(performLayout: false);
		mtabInterface.PerformLayout();
		((ISupportInitialize)mnumIPPageSize).EndInit();
		mtabConnection.ResumeLayout(performLayout: false);
		mgbProxySettings.ResumeLayout(performLayout: false);
		mgbProxySettings.PerformLayout();
		((ISupportInitialize)mnumProxyPort).EndInit();
		mtabLogging.ResumeLayout(performLayout: false);
		mgbLogging.ResumeLayout(performLayout: false);
		mgbLogging.PerformLayout();
		((ISupportInitialize)mnumLogRemoveOldLogsDays).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void mlnkAdvancedBlockingSettings_Click(object sender, EventArgs e)
	{
		AdvancedBlockingSettingsDialog form = new AdvancedBlockingSettingsDialog(class164_0.Class169_0);
		using (form)
		{
			if (DialogResult.OK == form.ShowDialog())
			{
				class164_0.Class169_0 = form.Class169_0;
			}
		}
	}

	private void class0_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		SaveSettings();
	}

	private void mchbProxyAuthentication_Click(object sender, EventArgs e)
	{
		SaveSettings();
	}

	private void mchbLogRemoveOld_Click(object sender, EventArgs e)
	{
		ValidateInput();
	}

	private void mlnkLogSuccessfulLoginAttemptsConfiguration_Click(object sender, EventArgs e)
	{
		string_0 = OnButtonOk(string_0);
	}

	private void mchbEnableGeoIPEngine_CheckedChanged(object sender, EventArgs e)
	{
		bool enabled = mchbEnableGeoIPEngine.Checked;
		mgbGeoIPMode.Enabled = enabled;
		mlstGeoIPCountries.Enabled = enabled;
		OnTextChanged();
	}

	private void mrbGeoIPModeDeny_CheckedChanged(object sender, EventArgs e)
	{
		LoadSettings();
	}

	private void mrbGeoIPModeAllow_CheckedChanged(object sender, EventArgs e)
	{
		LoadSettings();
	}

	private void OnSelectedIndexChanged(object sender, EventArgs e)
	{
		OnTextChanged();
	}

	private void mlnkGeoIPHelp_Click(object sender, EventArgs e)
	{
		ShowOnlineHelp(Class148.Class156.String_1);
	}

	private void control14_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		OnTextChanged();
	}

	private void mbtnSave_Click(object sender, EventArgs e)
	{
		OnLoad();
		CloseDialog(DialogResult.OK);
	}

	private void mbtnCancel_Click(object sender, EventArgs e)
	{
		CloseDialog(DialogResult.Cancel);
	}
}
