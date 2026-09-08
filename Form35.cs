using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Properties;
using rdpguard.lib;

internal sealed class Form35 : Form0
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

	private Control14 control14_0;

	private TabPage tabPage_0;

	private TabPage tabPage_1;

	private Class66 class66_0;

	private Class66 class66_1;

	private Class61 class61_0;

	private Class62 class62_0;

	private Class62 class62_1;

	private Class62 class62_2;

	private Class61 class61_1;

	private Class61 class61_2;

	private TabPage tabPage_2;

	private Class63 class63_0;

	private NumericUpDown numericUpDown_0;

	private Class62 class62_3;

	private Class62 class62_4;

	private NumericUpDown numericUpDown_1;

	private Class63 class63_1;

	private NumericUpDown numericUpDown_2;

	private Class62 class62_5;

	private Class63 class63_2;

	private Class62 class62_6;

	private Class61 class61_3;

	private TabPage tabPage_3;

	private Class65 class65_0;

	private Class0 class0_0;

	private NumericUpDown numericUpDown_3;

	private TextBox textBox_0;

	private Class62 class62_7;

	private Class61 class61_4;

	private TextBox textBox_1;

	private Class62 class62_8;

	private TextBox textBox_2;

	private Class62 class62_9;

	private Class62 class62_10;

	private TextBox textBox_3;

	private Class62 class62_11;

	private GClass3 gclass3_0;

	private Class62 class62_12;

	private Class61 class61_5;

	private NumericUpDown numericUpDown_4;

	private Class62 class62_13;

	private Class63 class63_3;

	private TabPage tabPage_4;

	private TabPage tabPage_5;

	private Class63 class63_4;

	private Class61 class61_6;

	private Class61 class61_7;

	private Control0 control0_0;

	private Class65 class65_1;

	private Class64 class64_0;

	private Class64 class64_1;

	private GClass2 gclass2_0;

	private Class62 class62_14;

	private Class63 class63_5;

	private Class0 class0_1;

	private Class62 class62_15;

	private GClass3 gclass3_1;

	private Class65 class65_2;

	private Class61 class61_8;

	private Class63 class63_6;

	private GClass3 gclass3_2;

	private Class61 class61_9;

	private NumericUpDown numericUpDown_5;

	private Class63 class63_7;

	private Class62 class62_16;

	private Class0 class0_2;

	private Class63 class63_8;

	private GClass3 gclass3_3;

	private Class63 class63_9;

	private Class61 class61_10;

	private GClass8 GClass8_0
	{
		get
		{
			return new GClass8
			{
				genum17_0 = GClass18.GClass18_0[class0_2.Text],
				bool_0 = class61_8.Checked,
				bool_1 = class61_9.Checked,
				int_0 = (int)numericUpDown_5.Value,
				bool_2 = class61_10.Checked,
				string_0 = string_0
			};
		}
		set
		{
			class0_2.Text = GClass18.GClass18_0[value.genum17_0];
			class61_8.Checked = value.bool_0;
			class61_9.Checked = value.bool_1;
			numericUpDown_5.Value = value.int_0;
			class61_10.Checked = value.bool_2;
			string_0 = value.string_0;
		}
	}

	private Class159 Class159_0
	{
		get
		{
			return new Class159
			{
				genum13_0 = (GEnum13)class0_0.SelectedIndex,
				string_0 = textBox_3.Text,
				int_0 = (int)numericUpDown_3.Value,
				bool_0 = class61_4.Checked,
				string_1 = textBox_2.Text,
				string_2 = textBox_1.Text,
				string_3 = textBox_0.Text
			};
		}
		set
		{
			class0_0.SelectedIndex = (int)value.genum13_0;
			textBox_3.Text = value.string_0;
			numericUpDown_3.Value = value.int_0;
			class61_4.Checked = value.bool_0;
			textBox_2.Text = value.string_1;
			textBox_1.Text = value.string_2;
			textBox_0.Text = value.string_3;
		}
	}

	private GeoIPMode GeoIPMode_0
	{
		get
		{
			if (class64_1.Checked)
			{
				return GeoIPMode.Deny;
			}
			if (class64_0.Checked)
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
				class64_1.Checked = true;
			}
			else if (GeoIPMode.Allow == value)
			{
				class64_0.Checked = true;
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
				bool_0 = class61_6.Checked,
				geoIPMode_0 = GeoIPMode_0,
				geoIPDBVersion_0 = control0_0.geoIPDBVersion_0,
				bool_1 = control0_0.Boolean_0,
				bool_2 = false,
				gclass5_0 = control0_0.GClass5_0,
				iplistEntry_0 = control0_0.IPListEntry_0,
				gclass7_0 = control0_0.gclass7_0,
				gclass7_1 = control0_0.gclass7_1,
				gclass7_2 = control0_0.gclass7_2,
				bool_3 = control0_0.bool_0,
				bool_4 = control0_0.bool_1,
				bool_5 = control0_0.bool_2,
				bool_6 = control0_0.bool_3
			};
		}
		set
		{
			class61_6.Checked = value.bool_0;
			control0_0.geoIPDBVersion_0 = value.geoIPDBVersion_0;
			GeoIPMode_0 = value.geoIPMode_0;
			control0_0.Boolean_0 = value.bool_1;
			control0_0.GClass5_0 = value.gclass5_0;
			control0_0.IPListEntry_0 = value.iplistEntry_0;
			control0_0.gclass7_0 = value.gclass7_0;
			control0_0.gclass7_1 = value.gclass7_1;
			control0_0.gclass7_2 = value.gclass7_2;
			control0_0.bool_0 = value.bool_3;
			control0_0.bool_1 = value.bool_4;
			control0_0.bool_2 = value.bool_5;
			control0_0.bool_3 = value.bool_6;
		}
	}

	protected override Button Button_0 => class66_0;

	public Form35(Class164 class164_1)
		: base(new Size(640, 600))
	{
		method_19();
		vmethod_1();
		method_11();
		method_12();
		class164_0 = class164_1;
		method_13();
	}

	private void method_11()
	{
		control14_0.ImageList = new ImageList
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
		gclass2_0.BackColor = tabPage_5.BackColor;
		ComboBox.ObjectCollection items = class0_2.Items;
		object[] prop_ = GClass18.GClass18_0.Prop_1;
		object[] items2 = prop_;
		items.AddRange(items2);
		gclass3_2.Left = class63_6.Right;
		gclass3_3.Left = class61_10.Right;
	}

	private void method_12()
	{
		gclass3_0.Click += gclass3_0_Click;
		class0_0.SelectedIndexChanged += class0_0_SelectedIndexChanged;
		class61_4.Click += class61_4_Click;
		GClass3 gClass = gclass3_2;
		EventHandler value = _003C_003Ec._003C_003E9.method_0;
		gClass.Click += value;
		class61_9.Click += class61_9_Click;
		gclass3_3.Click += gclass3_3_Click;
		class61_6.CheckedChanged += class61_6_CheckedChanged;
		class64_1.CheckedChanged += class64_1_CheckedChanged;
		class64_0.CheckedChanged += class64_0_CheckedChanged;
		control0_0.Event_0 += method_20;
		gclass3_1.Click += gclass3_1_Click;
		control14_0.SelectedIndexChanged += control14_0_SelectedIndexChanged;
		class66_0.Click += class66_0_Click;
		class66_1.Click += class66_1_Click;
	}

	private void method_13()
	{
		class61_0.Checked = class164_0.class166_1.Boolean_0;
		numericUpDown_0.Value = class164_0.class166_2.Int32_0;
		numericUpDown_2.Value = class164_0.class166_4.Int32_0;
		numericUpDown_1.Value = class164_0.class166_3.Int32_0;
		Class159_0 = class164_0.Class159_0;
		method_16();
		GClass8_0 = class164_0.GClass8_0;
		method_15();
		class61_7.Checked = class164_0.class166_19.Boolean_0;
		Class132_0 = class164_0.Class132_0;
		class61_1.Checked = Class163.Class163_0.class166_2.Boolean_0;
		class61_2.Checked = Class163.Class163_0.class166_3.Boolean_0;
		class61_5.Checked = Class163.Class163_0.class166_4.Boolean_0;
		numericUpDown_4.Value = Class163.Class163_0.class166_7.Int32_0;
		ComboBox.ObjectCollection items = class0_1.Items;
		object[] prop_ = Class184.Class184_0.Prop_1;
		object[] items2 = prop_;
		items.AddRange(items2);
		class0_1.Text = Class184.Class184_0[Class163.Class163_0.Int32_0];
	}

	private void method_14()
	{
		class164_0.class166_1.Boolean_0 = class61_0.Checked;
		class164_0.class166_2.Int32_0 = (int)numericUpDown_0.Value;
		class164_0.class166_4.Int32_0 = (int)numericUpDown_2.Value;
		class164_0.Class159_0 = Class159_0;
		class164_0.class166_3.Int32_0 = (int)numericUpDown_1.Value;
		class164_0.GClass8_0 = GClass8_0;
		class164_0.class166_19.Boolean_0 = class61_7.Checked;
		class164_0.Class132_0 = Class132_0;
		Class163.Class163_0.class166_2.Boolean_0 = class61_1.Checked;
		Class163.Class163_0.class166_3.Boolean_0 = class61_2.Checked;
		Class163.Class163_0.class166_4.Boolean_0 = class61_5.Checked;
		Class163.Class163_0.class166_7.Int32_0 = (int)numericUpDown_4.Value;
		Class163.Class163_0.Int32_0 = Class184.Class184_0[class0_1.Text];
		Class163.Class163_0.method_3();
	}

	private void method_15()
	{
		numericUpDown_5.Enabled = class61_9.Checked;
		class63_7.Enabled = class61_9.Checked;
	}

	private void method_16()
	{
		bool flag = 2 == class0_0.SelectedIndex;
		class62_11.Enabled = flag;
		textBox_3.Enabled = flag;
		class62_10.Enabled = flag;
		numericUpDown_3.Enabled = flag;
		class61_4.Enabled = flag;
		bool enabled = class61_4.Checked && flag;
		class62_9.Enabled = enabled;
		textBox_2.Enabled = enabled;
		class62_8.Enabled = enabled;
		textBox_1.Enabled = enabled;
		class62_7.Enabled = enabled;
		textBox_0.Enabled = enabled;
	}

	private void method_17()
	{
		if (class64_0.Checked)
		{
			gclass5_0 = control0_0.GClass5_0;
		}
		else
		{
			gclass5_1 = control0_0.GClass5_0;
		}
		control0_0.GClass5_0 = ((class64_0.Checked ? true : false) ? gclass5_1 : gclass5_0);
		control0_0.GeoIPMode_0 = GeoIPMode_0;
		method_18();
	}

	private void method_18()
	{
		GClass5[] gClass5_ = control0_0.GClass5_0;
		Func<GClass5, long> selector = _003C_003Ec._003C_003E9.method_1;
		bool visible = gClass5_.Select(selector).Sum() > 10000 && control14_0.SelectedTab == tabPage_4 && class61_6.Checked;
		class62_15.Visible = visible;
		gclass3_1.Visible = visible;
	}

	private static string smethod_4(string string_1)
	{
		Form5 form = new Form5
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

	private void method_19()
	{
		control14_0 = new Control14();
		tabPage_0 = new TabPage();
		numericUpDown_2 = new NumericUpDown();
		class62_5 = new Class62();
		class63_2 = new Class63();
		class62_4 = new Class62();
		numericUpDown_1 = new NumericUpDown();
		class63_1 = new Class63();
		numericUpDown_0 = new NumericUpDown();
		class62_3 = new Class62();
		class63_0 = new Class63();
		class62_0 = new Class62();
		class61_0 = new Class61();
		gclass3_0 = new GClass3();
		tabPage_5 = new TabPage();
		gclass2_0 = new GClass2();
		class61_7 = new Class61();
		tabPage_4 = new TabPage();
		class65_1 = new Class65();
		class64_0 = new Class64();
		class64_1 = new Class64();
		control0_0 = new Control0();
		class63_4 = new Class63();
		class61_6 = new Class61();
		tabPage_1 = new TabPage();
		class63_5 = new Class63();
		class0_1 = new Class0();
		class62_14 = new Class62();
		numericUpDown_4 = new NumericUpDown();
		class62_13 = new Class62();
		class63_3 = new Class63();
		class62_12 = new Class62();
		class61_5 = new Class61();
		class62_1 = new Class62();
		class62_2 = new Class62();
		class61_1 = new Class61();
		class61_2 = new Class61();
		tabPage_3 = new TabPage();
		class65_0 = new Class65();
		textBox_0 = new TextBox();
		class62_7 = new Class62();
		class0_0 = new Class0();
		numericUpDown_3 = new NumericUpDown();
		class61_4 = new Class61();
		textBox_1 = new TextBox();
		class62_8 = new Class62();
		textBox_2 = new TextBox();
		class62_9 = new Class62();
		class62_10 = new Class62();
		textBox_3 = new TextBox();
		class62_11 = new Class62();
		tabPage_2 = new TabPage();
		class65_2 = new Class65();
		gclass3_3 = new GClass3();
		class63_9 = new Class63();
		class61_10 = new Class61();
		numericUpDown_5 = new NumericUpDown();
		class63_7 = new Class63();
		class61_9 = new Class61();
		class63_8 = new Class63();
		class0_2 = new Class0();
		gclass3_2 = new GClass3();
		class62_16 = new Class62();
		class63_6 = new Class63();
		class61_8 = new Class61();
		class66_0 = new Class66();
		class66_1 = new Class66();
		class62_6 = new Class62();
		class61_3 = new Class61();
		class62_15 = new Class62();
		gclass3_1 = new GClass3();
		control14_0.SuspendLayout();
		tabPage_0.SuspendLayout();
		((ISupportInitialize)numericUpDown_2).BeginInit();
		((ISupportInitialize)numericUpDown_1).BeginInit();
		((ISupportInitialize)numericUpDown_0).BeginInit();
		tabPage_5.SuspendLayout();
		tabPage_4.SuspendLayout();
		class65_1.SuspendLayout();
		tabPage_1.SuspendLayout();
		((ISupportInitialize)numericUpDown_4).BeginInit();
		tabPage_3.SuspendLayout();
		class65_0.SuspendLayout();
		((ISupportInitialize)numericUpDown_3).BeginInit();
		tabPage_2.SuspendLayout();
		class65_2.SuspendLayout();
		((ISupportInitialize)numericUpDown_5).BeginInit();
		SuspendLayout();
		control14_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		control14_0.Controls.Add(tabPage_0);
		control14_0.Controls.Add(tabPage_5);
		control14_0.Controls.Add(tabPage_4);
		control14_0.Controls.Add(tabPage_1);
		control14_0.Controls.Add(tabPage_3);
		control14_0.Controls.Add(tabPage_2);
		control14_0.ImeMode = ImeMode.Disable;
		control14_0.ItemSize = new Size(96, 36);
		control14_0.Location = new Point(12, 12);
		control14_0.Multiline = true;
		control14_0.Name = "tabControl1";
		control14_0.Padding = new Point(6, 6);
		control14_0.SelectedIndex = 0;
		control14_0.Size = new Size(600, 490);
		control14_0.SizeMode = TabSizeMode.FillToRight;
		control14_0.TabIndex = 0;
		tabPage_0.Controls.Add(numericUpDown_2);
		tabPage_0.Controls.Add(class62_5);
		tabPage_0.Controls.Add(class63_2);
		tabPage_0.Controls.Add(class62_4);
		tabPage_0.Controls.Add(numericUpDown_1);
		tabPage_0.Controls.Add(class63_1);
		tabPage_0.Controls.Add(numericUpDown_0);
		tabPage_0.Controls.Add(class62_3);
		tabPage_0.Controls.Add(class63_0);
		tabPage_0.Controls.Add(class62_0);
		tabPage_0.Controls.Add(class61_0);
		tabPage_0.Controls.Add(gclass3_0);
		tabPage_0.ImageIndex = 0;
		tabPage_0.Location = new Point(4, 40);
		tabPage_0.Name = "m_tabGeneral";
		tabPage_0.Padding = new Padding(3);
		tabPage_0.Size = new Size(592, 446);
		tabPage_0.TabIndex = 0;
		tabPage_0.Text = "General";
		tabPage_0.UseVisualStyleBackColor = true;
		numericUpDown_2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		numericUpDown_2.Location = new Point(34, 184);
		numericUpDown_2.Maximum = new decimal(new int[4] { 999, 0, 0, 0 });
		numericUpDown_2.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		numericUpDown_2.Name = "m_numResetCountersAfter";
		numericUpDown_2.Size = new Size(552, 22);
		numericUpDown_2.TabIndex = 2;
		numericUpDown_2.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		class62_5.AutoSize = true;
		class62_5.Location = new Point(20, 163);
		class62_5.Name = "m_lblResetCountersAfter";
		class62_5.Size = new Size(314, 16);
		class62_5.TabIndex = 31;
		class62_5.Text = "Reset counters of failed logon attempts after (hours):";
		class62_5.Boolean_0 = false;
		class63_2.AutoSize = true;
		class63_2.ForeColor = SystemColors.ControlDarkDark;
		class63_2.Location = new Point(31, 209);
		class63_2.Name = "m_lblResetCountersAfterHint";
		class63_2.Size = new Size(508, 16);
		class63_2.TabIndex = 30;
		class63_2.Text = "Set the interval (in hours) after which the counters of failed logon attempts will be reset.";
		class63_2.Boolean_0 = false;
		class62_4.AutoSize = true;
		class62_4.Location = new Point(20, 246);
		class62_4.Name = "m_lblAutoUnban";
		class62_4.Size = new Size(288, 16);
		class62_4.TabIndex = 29;
		class62_4.Text = "Unban IP addresses automatically after (hours):";
		class62_4.Boolean_0 = false;
		numericUpDown_1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		numericUpDown_1.Location = new Point(34, 267);
		numericUpDown_1.Maximum = new decimal(new int[4] { 8760, 0, 0, 0 });
		numericUpDown_1.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		numericUpDown_1.Name = "m_numAutoUnbanPeriod";
		numericUpDown_1.Size = new Size(552, 22);
		numericUpDown_1.TabIndex = 3;
		numericUpDown_1.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		class63_1.AutoSize = true;
		class63_1.ForeColor = SystemColors.ControlDarkDark;
		class63_1.Location = new Point(31, 292);
		class63_1.Name = "m_lblAutoUnbanHint";
		class63_1.Size = new Size(354, 16);
		class63_1.TabIndex = 26;
		class63_1.Text = "Specify how long should attacker's IP address be blocked.";
		class63_1.Boolean_0 = false;
		numericUpDown_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		numericUpDown_0.Location = new Point(34, 101);
		numericUpDown_0.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		numericUpDown_0.Name = "m_numMaxFailedLogonAttempts";
		numericUpDown_0.Size = new Size(552, 22);
		numericUpDown_0.TabIndex = 1;
		numericUpDown_0.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		class62_3.AutoSize = true;
		class62_3.Location = new Point(20, 80);
		class62_3.Name = "m_lblMaxFailedLogonAttempts";
		class62_3.Size = new Size(341, 16);
		class62_3.TabIndex = 24;
		class62_3.Text = "Maximum failed logon attempts from a single IP address:";
		class62_3.Boolean_0 = false;
		class63_0.AutoSize = true;
		class63_0.ForeColor = SystemColors.ControlDarkDark;
		class63_0.Location = new Point(31, 126);
		class63_0.Name = "m_lblMaxFailedLogonAttemptsHint";
		class63_0.Size = new Size(479, 16);
		class63_0.TabIndex = 23;
		class63_0.Text = "How many failed logon attempts should be received before banning IP address.";
		class63_0.Boolean_0 = false;
		class62_0.AutoSize = true;
		class62_0.ForeColor = SystemColors.ControlDarkDark;
		class62_0.Location = new Point(20, 43);
		class62_0.Name = "m_chbCheckForSoftwareUpdatesHint";
		class62_0.Size = new Size(452, 16);
		class62_0.TabIndex = 21;
		class62_0.Text = "RdpGuard will check for updates and notify you when new version available";
		class62_0.Boolean_0 = false;
		class61_0.AutoSize = true;
		class61_0.Location = new Point(23, 20);
		class61_0.Name = "m_chbCheckForSoftwareUpdates";
		class61_0.Size = new Size(274, 20);
		class61_0.TabIndex = 0;
		class61_0.Text = "Automatically check for software updates  ";
		class61_0.UseVisualStyleBackColor = true;
		gclass3_0.AutoSize = true;
		gclass3_0.LinkBehavior = LinkBehavior.NeverUnderline;
		gclass3_0.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_0.Location = new Point(20, 326);
		gclass3_0.Name = "m_lnkAdvancedBlockingSettings";
		gclass3_0.Size = new Size(177, 16);
		gclass3_0.TabIndex = 7;
		gclass3_0.TabStop = true;
		gclass3_0.Text = "advanced blocking settings..";
		gclass3_0.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		tabPage_5.Controls.Add(gclass2_0);
		tabPage_5.Controls.Add(class61_7);
		tabPage_5.ImageIndex = 1;
		tabPage_5.Location = new Point(4, 40);
		tabPage_5.Name = "m_tabCloud";
		tabPage_5.Padding = new Padding(3);
		tabPage_5.Size = new Size(592, 446);
		tabPage_5.TabIndex = 8;
		tabPage_5.Text = "IP Cloud";
		tabPage_5.UseVisualStyleBackColor = true;
		gclass2_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		gclass2_0.BackColor = SystemColors.Control;
		gclass2_0.BorderStyle = BorderStyle.None;
		gclass2_0.Cursor = Cursors.Default;
		gclass2_0.ForeColor = SystemColors.ControlDarkDark;
		gclass2_0.Location = new Point(23, 46);
		gclass2_0.Multiline = true;
		gclass2_0.Name = "m_edEnableIPCloudHint";
		gclass2_0.ReadOnly = true;
		gclass2_0.Size = new Size(563, 52);
		gclass2_0.TabIndex = 25;
		gclass2_0.TabStop = false;
		gclass2_0.Text = "Enable this option for preemptive blocking of IP addresses detected by other participants. Any attacks detected on your PC will also be reported to the cloud.";
		gclass2_0.Boolean_0 = false;
		class61_7.AutoSize = true;
		class61_7.Location = new Point(23, 20);
		class61_7.Name = "m_chbEnableIPCloud";
		class61_7.Size = new Size(188, 20);
		class61_7.TabIndex = 24;
		class61_7.Text = "Enable RdpGuard IP Cloud";
		class61_7.UseVisualStyleBackColor = true;
		tabPage_4.Controls.Add(class65_1);
		tabPage_4.Controls.Add(control0_0);
		tabPage_4.Controls.Add(class63_4);
		tabPage_4.Controls.Add(class61_6);
		tabPage_4.ImageIndex = 2;
		tabPage_4.Location = new Point(4, 40);
		tabPage_4.Name = "m_tabGeoIP";
		tabPage_4.Padding = new Padding(3);
		tabPage_4.Size = new Size(592, 446);
		tabPage_4.TabIndex = 7;
		tabPage_4.Text = "GeoIP";
		tabPage_4.UseVisualStyleBackColor = true;
		class65_1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		class65_1.Controls.Add(class64_0);
		class65_1.Controls.Add(class64_1);
		class65_1.Enabled = false;
		class65_1.Location = new Point(9, 75);
		class65_1.Name = "m_gbGeoIPMode";
		class65_1.Size = new Size(576, 83);
		class65_1.TabIndex = 28;
		class65_1.TabStop = false;
		class65_1.Text = "Geo-IP mode:";
		class64_0.AutoSize = true;
		class64_0.Location = new Point(17, 50);
		class64_0.Name = "m_rbGeoIPModeAllow";
		class64_0.Size = new Size(363, 20);
		class64_0.TabIndex = 2;
		class64_0.TabStop = true;
		class64_0.Text = "Allow specific countries (all other countries will be denied)";
		class64_0.UseVisualStyleBackColor = true;
		class64_1.AutoSize = true;
		class64_1.Location = new Point(17, 24);
		class64_1.Name = "m_rbGeoIPModeDeny";
		class64_1.Size = new Size(379, 20);
		class64_1.TabIndex = 1;
		class64_1.TabStop = true;
		class64_1.Text = "Deny specific countries (all other countries will have access)";
		class64_1.UseVisualStyleBackColor = true;
		control0_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		control0_0.GClass5_0 = new GClass5[0];
		control0_0.IPListEntry_0 = new IPListEntry[0];
		control0_0.Boolean_0 = false;
		control0_0.Enabled = false;
		control0_0.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		control0_0.Location = new Point(9, 165);
		control0_0.Margin = new Padding(4);
		control0_0.Name = "m_lstGeoIPCountries";
		control0_0.Size = new Size(576, 274);
		control0_0.TabIndex = 25;
		class63_4.AutoSize = true;
		class63_4.ForeColor = SystemColors.ControlDarkDark;
		class63_4.Location = new Point(20, 43);
		class63_4.Name = "m_lblEnableGeoIPEngineHint";
		class63_4.Size = new Size(359, 16);
		class63_4.TabIndex = 23;
		class63_4.Text = "Block or allow access to your server from specific countries.";
		class63_4.Boolean_0 = false;
		class61_6.AutoSize = true;
		class61_6.Location = new Point(23, 20);
		class61_6.Name = "m_chbEnableGeoIPEngine";
		class61_6.Size = new Size(114, 20);
		class61_6.TabIndex = 22;
		class61_6.Text = "Enable Geo-IP";
		class61_6.UseVisualStyleBackColor = true;
		tabPage_1.Controls.Add(class63_5);
		tabPage_1.Controls.Add(class0_1);
		tabPage_1.Controls.Add(class62_14);
		tabPage_1.Controls.Add(numericUpDown_4);
		tabPage_1.Controls.Add(class62_13);
		tabPage_1.Controls.Add(class63_3);
		tabPage_1.Controls.Add(class62_12);
		tabPage_1.Controls.Add(class61_5);
		tabPage_1.Controls.Add(class62_1);
		tabPage_1.Controls.Add(class62_2);
		tabPage_1.Controls.Add(class61_1);
		tabPage_1.Controls.Add(class61_2);
		tabPage_1.ImageIndex = 3;
		tabPage_1.Location = new Point(4, 40);
		tabPage_1.Name = "m_tabInterface";
		tabPage_1.Padding = new Padding(3);
		tabPage_1.Size = new Size(592, 446);
		tabPage_1.TabIndex = 2;
		tabPage_1.Text = "Interface";
		tabPage_1.UseVisualStyleBackColor = true;
		class63_5.AutoSize = true;
		class63_5.ForeColor = SystemColors.ControlDarkDark;
		class63_5.Location = new Point(29, 311);
		class63_5.Name = "m_lblColorThemeHint";
		class63_5.Size = new Size(385, 16);
		class63_5.TabIndex = 33;
		class63_5.Text = "Changing the theme requires an application restart to take effect.";
		class63_5.Boolean_0 = false;
		class0_1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		class0_1.DropDownStyle = ComboBoxStyle.DropDownList;
		class0_1.FormattingEnabled = true;
		class0_1.Location = new Point(32, 284);
		class0_1.Name = "m_cbColorTheme";
		class0_1.Size = new Size(554, 24);
		class0_1.TabIndex = 32;
		class62_14.AutoSize = true;
		class62_14.Location = new Point(20, 265);
		class62_14.Name = "m_lblColorTheme";
		class62_14.Size = new Size(82, 16);
		class62_14.TabIndex = 31;
		class62_14.Text = "Color theme:";
		class62_14.Boolean_0 = false;
		numericUpDown_4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		numericUpDown_4.Location = new Point(32, 207);
		numericUpDown_4.Maximum = new decimal(new int[4] { 5000, 0, 0, 0 });
		numericUpDown_4.Minimum = new decimal(new int[4] { 10, 0, 0, 0 });
		numericUpDown_4.Name = "m_numIPPageSize";
		numericUpDown_4.Size = new Size(554, 22);
		numericUpDown_4.TabIndex = 28;
		numericUpDown_4.Value = new decimal(new int[4] { 100, 0, 0, 0 });
		class62_13.AutoSize = true;
		class62_13.Location = new Point(20, 188);
		class62_13.Name = "m_lblIPPageSize";
		class62_13.Size = new Size(270, 16);
		class62_13.TabIndex = 30;
		class62_13.Text = "Maximum number of IP addresses per page:";
		class62_13.Boolean_0 = false;
		class63_3.AutoSize = true;
		class63_3.ForeColor = SystemColors.ControlDarkDark;
		class63_3.Location = new Point(29, 232);
		class63_3.Name = "m_lblIPPageSizeHint";
		class63_3.Size = new Size(531, 16);
		class63_3.TabIndex = 29;
		class63_3.Text = "The number of IP addresses to show on a single page in the Blocked IP Addresses table";
		class63_3.Boolean_0 = false;
		class62_12.AutoSize = true;
		class62_12.ForeColor = SystemColors.ControlDarkDark;
		class62_12.Location = new Point(20, 155);
		class62_12.Name = "m_chbCloseToSystemTrayTip";
		class62_12.Size = new Size(265, 16);
		class62_12.TabIndex = 27;
		class62_12.Text = "Hide RdpGuard to system tray when closed";
		class62_12.Boolean_0 = false;
		class61_5.AutoSize = true;
		class61_5.Location = new Point(23, 132);
		class61_5.Name = "m_chbCloseToSystemTray";
		class61_5.Size = new Size(146, 20);
		class61_5.TabIndex = 2;
		class61_5.Text = "Close to system tray";
		class61_5.UseVisualStyleBackColor = true;
		class62_1.AutoSize = true;
		class62_1.ForeColor = SystemColors.ControlDarkDark;
		class62_1.Location = new Point(20, 99);
		class62_1.Name = "m_chbMinimizeToSystemTrayTip";
		class62_1.Size = new Size(284, 16);
		class62_1.TabIndex = 25;
		class62_1.Text = "Hide RdpGuard to system tray when minimized";
		class62_1.Boolean_0 = false;
		class62_2.AutoSize = true;
		class62_2.ForeColor = SystemColors.ControlDarkDark;
		class62_2.Location = new Point(20, 43);
		class62_2.Name = "m_lblShowSystrayIconTip";
		class62_2.Size = new Size(390, 16);
		class62_2.TabIndex = 24;
		class62_2.Text = "This check toggles whether RdpGuard has an icon in system tray";
		class62_2.Boolean_0 = false;
		class61_1.AutoSize = true;
		class61_1.Location = new Point(23, 20);
		class61_1.Name = "m_chbAllwaysShowSystemTrayIcon";
		class61_1.Size = new Size(281, 20);
		class61_1.TabIndex = 0;
		class61_1.Text = "Always show RdpGuard icon in system tray";
		class61_1.UseVisualStyleBackColor = true;
		class61_2.AutoSize = true;
		class61_2.Location = new Point(23, 76);
		class61_2.Name = "m_chbMinimizeToSystemTray";
		class61_2.Size = new Size(163, 20);
		class61_2.TabIndex = 1;
		class61_2.Text = "Minimize to system tray";
		class61_2.UseVisualStyleBackColor = true;
		tabPage_3.Controls.Add(class65_0);
		tabPage_3.ImageIndex = 4;
		tabPage_3.Location = new Point(4, 40);
		tabPage_3.Name = "m_tabConnection";
		tabPage_3.Padding = new Padding(3);
		tabPage_3.Size = new Size(592, 446);
		tabPage_3.TabIndex = 6;
		tabPage_3.Text = "Connection";
		tabPage_3.UseVisualStyleBackColor = true;
		class65_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		class65_0.Controls.Add(textBox_0);
		class65_0.Controls.Add(class62_7);
		class65_0.Controls.Add(class0_0);
		class65_0.Controls.Add(numericUpDown_3);
		class65_0.Controls.Add(class61_4);
		class65_0.Controls.Add(textBox_1);
		class65_0.Controls.Add(class62_8);
		class65_0.Controls.Add(textBox_2);
		class65_0.Controls.Add(class62_9);
		class65_0.Controls.Add(class62_10);
		class65_0.Controls.Add(textBox_3);
		class65_0.Controls.Add(class62_11);
		class65_0.Location = new Point(6, 6);
		class65_0.Name = "m_gbProxySettings";
		class65_0.Size = new Size(580, 414);
		class65_0.TabIndex = 47;
		class65_0.TabStop = false;
		class65_0.Text = "Proxy";
		textBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		textBox_0.Location = new Point(29, 375);
		textBox_0.Name = "m_edProxyDomain";
		textBox_0.Size = new Size(545, 22);
		textBox_0.TabIndex = 6;
		class62_7.AutoSize = true;
		class62_7.Location = new Point(15, 350);
		class62_7.Name = "m_lblProxyDomain";
		class62_7.Size = new Size(57, 16);
		class62_7.TabIndex = 10;
		class62_7.Text = "Domain:";
		class62_7.Boolean_0 = false;
		class0_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		class0_0.DropDownStyle = ComboBoxStyle.DropDownList;
		class0_0.FormattingEnabled = true;
		class0_0.Items.AddRange(new object[3] { "Do not use proxy (direct connection)", "Autodetect proxy settings", "Use proxy settings below" });
		class0_0.Location = new Point(17, 30);
		class0_0.Name = "m_cbProxyMode";
		class0_0.Size = new Size(557, 24);
		class0_0.TabIndex = 0;
		numericUpDown_3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		numericUpDown_3.Location = new Point(17, 150);
		numericUpDown_3.Maximum = new decimal(new int[4] { 65535, 0, 0, 0 });
		numericUpDown_3.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		numericUpDown_3.Name = "m_numProxyPort";
		numericUpDown_3.Size = new Size(557, 22);
		numericUpDown_3.TabIndex = 2;
		numericUpDown_3.Value = new decimal(new int[4] { 8080, 0, 0, 0 });
		class61_4.AutoSize = true;
		class61_4.Location = new Point(9, 195);
		class61_4.Name = "m_chbProxyAuthentication";
		class61_4.Size = new Size(258, 20);
		class61_4.TabIndex = 3;
		class61_4.Text = "My proxy server requires authentication";
		class61_4.UseVisualStyleBackColor = true;
		textBox_1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		textBox_1.Location = new Point(29, 315);
		textBox_1.Name = "m_edProxyPassword";
		textBox_1.Size = new Size(545, 22);
		textBox_1.TabIndex = 5;
		textBox_1.UseSystemPasswordChar = true;
		class62_8.AutoSize = true;
		class62_8.Location = new Point(15, 290);
		class62_8.Name = "m_lblProxyPassword";
		class62_8.Size = new Size(70, 16);
		class62_8.TabIndex = 7;
		class62_8.Text = "Password:";
		class62_8.Boolean_0 = false;
		textBox_2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		textBox_2.Location = new Point(29, 255);
		textBox_2.Name = "m_edProxyUsername";
		textBox_2.Size = new Size(545, 22);
		textBox_2.TabIndex = 4;
		class62_9.AutoSize = true;
		class62_9.Location = new Point(15, 230);
		class62_9.Name = "m_lblProxyUserName";
		class62_9.Size = new Size(73, 16);
		class62_9.TabIndex = 5;
		class62_9.Text = "Username:";
		class62_9.Boolean_0 = false;
		class62_10.AutoSize = true;
		class62_10.Location = new Point(6, 125);
		class62_10.Name = "m_lblProxyPort";
		class62_10.Size = new Size(34, 16);
		class62_10.TabIndex = 3;
		class62_10.Text = "Port:";
		class62_10.Boolean_0 = false;
		textBox_3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		textBox_3.Location = new Point(17, 90);
		textBox_3.Name = "m_edProxyAddress";
		textBox_3.Size = new Size(557, 22);
		textBox_3.TabIndex = 1;
		class62_11.AutoSize = true;
		class62_11.Location = new Point(6, 65);
		class62_11.Name = "m_lblProxyAddress";
		class62_11.Size = new Size(61, 16);
		class62_11.TabIndex = 0;
		class62_11.Text = "Address:";
		class62_11.Boolean_0 = false;
		tabPage_2.Controls.Add(class65_2);
		tabPage_2.ImageIndex = 5;
		tabPage_2.Location = new Point(4, 40);
		tabPage_2.Name = "m_tabLogging";
		tabPage_2.Padding = new Padding(3);
		tabPage_2.Size = new Size(592, 446);
		tabPage_2.TabIndex = 5;
		tabPage_2.Text = "Logging";
		tabPage_2.UseVisualStyleBackColor = true;
		class65_2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		class65_2.Controls.Add(gclass3_3);
		class65_2.Controls.Add(class63_9);
		class65_2.Controls.Add(class61_10);
		class65_2.Controls.Add(numericUpDown_5);
		class65_2.Controls.Add(class63_7);
		class65_2.Controls.Add(class61_9);
		class65_2.Controls.Add(class63_8);
		class65_2.Controls.Add(class0_2);
		class65_2.Controls.Add(gclass3_2);
		class65_2.Controls.Add(class62_16);
		class65_2.Controls.Add(class63_6);
		class65_2.Controls.Add(class61_8);
		class65_2.Location = new Point(6, 6);
		class65_2.Name = "m_gbLogging";
		class65_2.Size = new Size(580, 308);
		class65_2.TabIndex = 45;
		class65_2.TabStop = false;
		class65_2.Text = "Logging:";
		gclass3_3.AutoSize = true;
		gclass3_3.LinkBehavior = LinkBehavior.NeverUnderline;
		gclass3_3.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_3.Location = new Point(303, 253);
		gclass3_3.Margin = new Padding(0);
		gclass3_3.Name = "m_lnkLogSuccessfulLoginAttemptsConfiguration";
		gclass3_3.Size = new Size(68, 16);
		gclass3_3.TabIndex = 53;
		gclass3_3.TabStop = true;
		gclass3_3.Text = "configure..";
		gclass3_3.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		class63_9.AutoSize = true;
		class63_9.ForeColor = SystemColors.ControlDarkDark;
		class63_9.Location = new Point(14, 275);
		class63_9.Margin = new Padding(0);
		class63_9.Name = "m_chbLogSuccessfulLoginAttemptsHint";
		class63_9.Size = new Size(409, 16);
		class63_9.TabIndex = 54;
		class63_9.Text = "This option enables or disables logging of successful login attempts";
		class63_9.Boolean_0 = false;
		class61_10.AutoSize = true;
		class61_10.Location = new Point(17, 252);
		class61_10.Name = "m_chbLogSuccessfulLoginAttempts";
		class61_10.Size = new Size(283, 20);
		class61_10.TabIndex = 52;
		class61_10.Text = "Enable logging of successful login attempts";
		class61_10.UseVisualStyleBackColor = true;
		numericUpDown_5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		numericUpDown_5.Location = new Point(17, 109);
		numericUpDown_5.Maximum = new decimal(new int[4] { 365, 0, 0, 0 });
		numericUpDown_5.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		numericUpDown_5.Name = "m_numLogRemoveOldLogsDays";
		numericUpDown_5.Size = new Size(557, 22);
		numericUpDown_5.TabIndex = 11;
		numericUpDown_5.Value = new decimal(new int[4] { 30, 0, 0, 0 });
		class63_7.AutoSize = true;
		class63_7.ForeColor = SystemColors.ControlDarkDark;
		class63_7.Location = new Point(14, 136);
		class63_7.Name = "m_lblLogRemoveOldHint";
		class63_7.Size = new Size(376, 16);
		class63_7.TabIndex = 51;
		class63_7.Text = "Specify the number of days after which old logs will be deleted.";
		class63_7.Boolean_0 = false;
		class61_9.AutoSize = true;
		class61_9.Location = new Point(17, 83);
		class61_9.Name = "m_chbLogRemoveOld";
		class61_9.Size = new Size(233, 20);
		class61_9.TabIndex = 10;
		class61_9.Text = "Remove log files older than (days):";
		class61_9.UseVisualStyleBackColor = true;
		class63_8.AutoSize = true;
		class63_8.ForeColor = SystemColors.ControlDarkDark;
		class63_8.Location = new Point(14, 219);
		class63_8.Name = "m_lblLogVerbosityLevelHint";
		class63_8.Size = new Size(563, 16);
		class63_8.TabIndex = 48;
		class63_8.Text = "Choose the log detail level: verbose (detailed), brief (summarized), or errors and warnings only";
		class63_8.Boolean_0 = false;
		class0_2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		class0_2.DropDownStyle = ComboBoxStyle.DropDownList;
		class0_2.FormattingEnabled = true;
		class0_2.Location = new Point(17, 190);
		class0_2.Name = "m_cbLogVerbosityLevel";
		class0_2.Size = new Size(557, 24);
		class0_2.TabIndex = 20;
		gclass3_2.AutoSize = true;
		gclass3_2.LinkBehavior = LinkBehavior.NeverUnderline;
		gclass3_2.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_2.Location = new Point(352, 50);
		gclass3_2.Margin = new Padding(0);
		gclass3_2.Name = "m_lnkLogsView";
		gclass3_2.Size = new Size(89, 16);
		gclass3_2.TabIndex = 1;
		gclass3_2.TabStop = true;
		gclass3_2.Text = "view log files..";
		gclass3_2.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		class62_16.AutoSize = true;
		class62_16.Location = new Point(14, 168);
		class62_16.Name = "m_lblLogVerbosityLevel";
		class62_16.Size = new Size(96, 16);
		class62_16.TabIndex = 3;
		class62_16.Text = "Verbosity level";
		class62_16.Boolean_0 = false;
		class63_6.AutoSize = true;
		class63_6.ForeColor = SystemColors.ControlDarkDark;
		class63_6.Location = new Point(14, 50);
		class63_6.Margin = new Padding(0);
		class63_6.Name = "m_lblLogSaveToFileHint";
		class63_6.Size = new Size(338, 16);
		class63_6.TabIndex = 46;
		class63_6.Text = "If checked, all log messages will be saved to the log file,";
		class63_6.Boolean_0 = false;
		class61_8.AutoSize = true;
		class61_8.Location = new Point(17, 27);
		class61_8.Name = "m_chbLogSaveToFile";
		class61_8.Size = new Size(150, 20);
		class61_8.TabIndex = 0;
		class61_8.Text = "Save event log to file";
		class61_8.UseVisualStyleBackColor = true;
		class66_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_0.Image = Resources.opts_16;
		class66_0.Location = new Point(403, 512);
		class66_0.Margin = new Padding(4);
		class66_0.Name = "m_btnSave";
		class66_0.Size = new Size(100, 36);
		class66_0.TabIndex = 99;
		class66_0.Text = "Save";
		class66_0.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_0.UseVisualStyleBackColor = true;
		class66_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_1.Image = Resources.cancl_16;
		class66_1.Location = new Point(511, 512);
		class66_1.Margin = new Padding(4);
		class66_1.Name = "m_btnCancel";
		class66_1.Size = new Size(100, 36);
		class66_1.TabIndex = 100;
		class66_1.Text = "Cancel";
		class66_1.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_1.UseVisualStyleBackColor = true;
		class62_6.AutoSize = true;
		class62_6.Location = new Point(33, 54);
		class62_6.Name = "label16";
		class62_6.Size = new Size(48, 13);
		class62_6.TabIndex = 0;
		class62_6.Text = "Address:";
		class62_6.Boolean_0 = false;
		class61_3.Location = new Point(0, 0);
		class61_3.Name = "chbHideWhenMimimized";
		class61_3.Size = new Size(104, 24);
		class61_3.TabIndex = 0;
		class62_15.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		class62_15.AutoSize = true;
		class62_15.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		class62_15.ForeColor = Color.Red;
		class62_15.Location = new Point(9, 507);
		class62_15.Name = "m_lblGeoIPWarning";
		class62_15.Size = new Size(336, 16);
		class62_15.TabIndex = 101;
		class62_15.Text = "Please keep the number of entries as short as possible,";
		class62_15.Boolean_0 = true;
		class62_15.Visible = false;
		gclass3_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		gclass3_1.AutoSize = true;
		gclass3_1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		gclass3_1.LinkBehavior = LinkBehavior.NeverUnderline;
		gclass3_1.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_1.Location = new Point(9, 530);
		gclass3_1.Margin = new Padding(0);
		gclass3_1.Name = "m_lnkGeoIPHelp";
		gclass3_1.RightToLeft = RightToLeft.No;
		gclass3_1.Size = new Size(165, 16);
		gclass3_1.TabIndex = 102;
		gclass3_1.TabStop = true;
		gclass3_1.Text = "click here for more details..";
		gclass3_1.Visible = false;
		gclass3_1.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(624, 561);
		base.Controls.Add(gclass3_1);
		base.Controls.Add(class62_15);
		base.Controls.Add(class66_0);
		base.Controls.Add(class66_1);
		base.Controls.Add(control14_0);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Name = "OptionsDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "RdpGuard Options";
		control14_0.ResumeLayout(performLayout: false);
		tabPage_0.ResumeLayout(performLayout: false);
		tabPage_0.PerformLayout();
		((ISupportInitialize)numericUpDown_2).EndInit();
		((ISupportInitialize)numericUpDown_1).EndInit();
		((ISupportInitialize)numericUpDown_0).EndInit();
		tabPage_5.ResumeLayout(performLayout: false);
		tabPage_5.PerformLayout();
		tabPage_4.ResumeLayout(performLayout: false);
		tabPage_4.PerformLayout();
		class65_1.ResumeLayout(performLayout: false);
		class65_1.PerformLayout();
		tabPage_1.ResumeLayout(performLayout: false);
		tabPage_1.PerformLayout();
		((ISupportInitialize)numericUpDown_4).EndInit();
		tabPage_3.ResumeLayout(performLayout: false);
		class65_0.ResumeLayout(performLayout: false);
		class65_0.PerformLayout();
		((ISupportInitialize)numericUpDown_3).EndInit();
		tabPage_2.ResumeLayout(performLayout: false);
		class65_2.ResumeLayout(performLayout: false);
		class65_2.PerformLayout();
		((ISupportInitialize)numericUpDown_5).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void gclass3_0_Click(object sender, EventArgs e)
	{
		Form22 form = new Form22(class164_0.Class169_0);
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
		method_16();
	}

	private void class61_4_Click(object sender, EventArgs e)
	{
		method_16();
	}

	private void class61_9_Click(object sender, EventArgs e)
	{
		method_15();
	}

	private void gclass3_3_Click(object sender, EventArgs e)
	{
		string_0 = smethod_4(string_0);
	}

	private void class61_6_CheckedChanged(object sender, EventArgs e)
	{
		bool enabled = class61_6.Checked;
		class65_1.Enabled = enabled;
		control0_0.Enabled = enabled;
		method_18();
	}

	private void class64_1_CheckedChanged(object sender, EventArgs e)
	{
		method_17();
	}

	private void class64_0_CheckedChanged(object sender, EventArgs e)
	{
		method_17();
	}

	private void method_20(object sender, EventArgs e)
	{
		method_18();
	}

	private void gclass3_1_Click(object sender, EventArgs e)
	{
		method_9(Class148.Class156.String_1);
	}

	private void control14_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		method_18();
	}

	private void class66_0_Click(object sender, EventArgs e)
	{
		method_14();
		method_8(DialogResult.OK);
	}

	private void class66_1_Click(object sender, EventArgs e)
	{
		method_8(DialogResult.Cancel);
	}
}
