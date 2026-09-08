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
    private IContainer components;
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
		InitializeComponent();
		vmethod_1();
		method_11();
		WireUpEvents();
	}

	private void method_11()
	{
		MinimumSize = size_0;
		base.Size = size_0;
		class64_2.Enabled = !Class178.Boolean_0;
		pictureBox_0.Image = ((Class163.Class163_0.Boolean_0 ? true : false) ? Resources.location_pin_settings_48_dark : Resources.location_pin_settings_48);
	}

	private void WireUpEvents()
	{
		gclass3_0.Click += gclass3_0_Click;
		control14_0.SelectedIndexChanged += control14_0_SelectedIndexChanged;
		Class3 class3_ = Class3_0;
		class3_.eventHandler_0 = (EventHandler<EventArgs>)Delegate.Combine(class3_.eventHandler_0, new EventHandler<EventArgs>(method_15));
		Class3 class3_2 = Class3_1;
		class3_2.eventHandler_0 = (EventHandler<EventArgs>)Delegate.Combine(class3_2.eventHandler_0, new EventHandler<EventArgs>(method_16));
		Class3 class3_3 = Class3_2;
		class3_3.eventHandler_0 = (EventHandler<EventArgs>)Delegate.Combine(class3_3.eventHandler_0, new EventHandler<EventArgs>(method_17));
		class66_0.Click += class66_0_Click;
	}

	private void method_13()
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

	private void InitializeComponent()
	{
            this.components = new System.ComponentModel.Container();
            this.class66_0 = new Class66();
            this.gcontrol0_0 = new GControl0();
            this.class62_0 = new Class62();
            this.pictureBox_0 = new System.Windows.Forms.PictureBox();
            this.class62_1 = new Class62();
            this.gclass3_0 = new GClass3();
            this.control14_0 = new Control14();
            this.tabPage_0 = new System.Windows.Forms.TabPage();
            this.class65_1 = new Class65();
            this.textBox_0 = new System.Windows.Forms.TextBox();
            this.class63_6 = new Class63();
            this.class64_4 = new Class64();
            this.textBox_1 = new System.Windows.Forms.TextBox();
            this.class63_4 = new Class63();
            this.class63_5 = new Class63();
            this.class64_0 = new Class64();
            this.class64_1 = new Class64();
            this.tabPage_1 = new System.Windows.Forms.TabPage();
            this.class65_4 = new Class65();
            this.textBox_3 = new System.Windows.Forms.TextBox();
            this.class63_9 = new Class63();
            this.class63_10 = new Class63();
            this.class64_7 = new Class64();
            this.class64_8 = new Class64();
            this.class65_3 = new Class65();
            this.textBox_2 = new System.Windows.Forms.TextBox();
            this.class63_7 = new Class63();
            this.class63_8 = new Class63();
            this.class64_5 = new Class64();
            this.class64_6 = new Class64();
            this.class65_0 = new Class65();
            this.class63_0 = new Class63();
            this.class61_0 = new Class61();
            this.class63_1 = new Class63();
            this.class61_1 = new Class61();
            this.class63_2 = new Class63();
            this.class61_2 = new Class61();
            this.class63_3 = new Class63();
            this.class61_3 = new Class61();
            this.tabPage_2 = new System.Windows.Forms.TabPage();
            this.class65_2 = new Class65();
            this.class64_2 = new Class64();
            this.class64_3 = new Class64();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_0)).BeginInit();
            this.control14_0.SuspendLayout();
            this.tabPage_0.SuspendLayout();
            this.class65_1.SuspendLayout();
            this.tabPage_1.SuspendLayout();
            this.class65_4.SuspendLayout();
            this.class65_3.SuspendLayout();
            this.class65_0.SuspendLayout();
            this.tabPage_2.SuspendLayout();
            this.class65_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // class66_0
            // 
            this.class66_0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.class66_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class66_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.class66_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class66_0.Image = global::Properties.Resources.opts_16;
            this.class66_0.Location = new System.Drawing.Point(451, 722);
            this.class66_0.Margin = new System.Windows.Forms.Padding(4);
            this.class66_0.Name = "class66_0";
            this.class66_0.Size = new System.Drawing.Size(100, 36);
            this.class66_0.TabIndex = 7;
            this.class66_0.Text = "Close";
            this.class66_0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.class66_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.class66_0.UseVisualStyleBackColor = false;
            // 
            // gcontrol0_0
            // 
            this.gcontrol0_0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcontrol0_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gcontrol0_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gcontrol0_0.Location = new System.Drawing.Point(16, 81);
            this.gcontrol0_0.Name = "gcontrol0_0";
            this.gcontrol0_0.Size = new System.Drawing.Size(532, 2);
            this.gcontrol0_0.TabIndex = 50;
            this.gcontrol0_0.TabStop = false;
            // 
            // class62_0
            // 
            this.class62_0.AutoSize = true;
            this.class62_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class62_0.Boolean_0 = false;
            this.class62_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.class62_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class62_0.Location = new System.Drawing.Point(79, 15);
            this.class62_0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.class62_0.Name = "class62_0";
            this.class62_0.Size = new System.Drawing.Size(115, 16);
            this.class62_0.TabIndex = 49;
            this.class62_0.Text = "Geo-IP Settings";
            // 
            // pictureBox_0
            // 
            this.pictureBox_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pictureBox_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pictureBox_0.Location = new System.Drawing.Point(16, 15);
            this.pictureBox_0.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_0.Name = "pictureBox_0";
            this.pictureBox_0.Size = new System.Drawing.Size(48, 48);
            this.pictureBox_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_0.TabIndex = 47;
            this.pictureBox_0.TabStop = false;
            // 
            // class62_1
            // 
            this.class62_1.AutoSize = true;
            this.class62_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class62_1.Boolean_0 = false;
            this.class62_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class62_1.Location = new System.Drawing.Point(79, 47);
            this.class62_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.class62_1.Name = "class62_1";
            this.class62_1.Size = new System.Drawing.Size(163, 16);
            this.class62_1.TabIndex = 48;
            this.class62_1.Text = "Advanced Geo-IP settings";
            // 
            // gclass3_0
            // 
            this.gclass3_0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gclass3_0.AutoSize = true;
            this.gclass3_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gclass3_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gclass3_0.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.gclass3_0.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(135)))), ((int)(((byte)(200)))));
            this.gclass3_0.Location = new System.Drawing.Point(476, 9);
            this.gclass3_0.Name = "gclass3_0";
            this.gclass3_0.Size = new System.Drawing.Size(72, 16);
            this.gclass3_0.TabIndex = 9;
            this.gclass3_0.TabStop = true;
            this.gclass3_0.Text = "online help";
            this.gclass3_0.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(135)))), ((int)(((byte)(200)))));
            // 
            // control14_0
            // 
            this.control14_0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.control14_0.Controls.Add(this.tabPage_0);
            this.control14_0.Controls.Add(this.tabPage_1);
            this.control14_0.Controls.Add(this.tabPage_2);
            this.control14_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.control14_0.Location = new System.Drawing.Point(16, 97);
            this.control14_0.Name = "control14_0";
            this.control14_0.SelectedIndex = 0;
            this.control14_0.Size = new System.Drawing.Size(536, 618);
            this.control14_0.TabIndex = 57;
            // 
            // tabPage_0
            // 
            this.tabPage_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPage_0.Controls.Add(this.class65_1);
            this.tabPage_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tabPage_0.Location = new System.Drawing.Point(4, 25);
            this.tabPage_0.Name = "tabPage_0";
            this.tabPage_0.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_0.Size = new System.Drawing.Size(528, 589);
            this.tabPage_0.TabIndex = 0;
            this.tabPage_0.Text = "Deny Mode";
            // 
            // class65_1
            // 
            this.class65_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.class65_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class65_1.Controls.Add(this.textBox_0);
            this.class65_1.Controls.Add(this.class63_6);
            this.class65_1.Controls.Add(this.class64_4);
            this.class65_1.Controls.Add(this.textBox_1);
            this.class65_1.Controls.Add(this.class63_4);
            this.class65_1.Controls.Add(this.class63_5);
            this.class65_1.Controls.Add(this.class64_0);
            this.class65_1.Controls.Add(this.class64_1);
            this.class65_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class65_1.Location = new System.Drawing.Point(6, 6);
            this.class65_1.Name = "class65_1";
            this.class65_1.Size = new System.Drawing.Size(516, 247);
            this.class65_1.TabIndex = 53;
            this.class65_1.TabStop = false;
            this.class65_1.Text = "Blocking scope:";
            // 
            // textBox_0
            // 
            this.textBox_0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.textBox_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_0.Enabled = false;
            this.textBox_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_0.Location = new System.Drawing.Point(36, 209);
            this.textBox_0.Name = "textBox_0";
            this.textBox_0.Size = new System.Drawing.Size(474, 22);
            this.textBox_0.TabIndex = 63;
            // 
            // class63_6
            // 
            this.class63_6.AutoSize = true;
            this.class63_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class63_6.Boolean_0 = false;
            this.class63_6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class63_6.Location = new System.Drawing.Point(33, 186);
            this.class63_6.Name = "class63_6";
            this.class63_6.Size = new System.Drawing.Size(394, 16);
            this.class63_6.TabIndex = 62;
            this.class63_6.Text = "Deny access from blocked countries only to the ports listed below";
            // 
            // class64_4
            // 
            this.class64_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class64_4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class64_4.Location = new System.Drawing.Point(17, 163);
            this.class64_4.Name = "class64_4";
            this.class64_4.Size = new System.Drawing.Size(177, 20);
            this.class64_4.TabIndex = 61;
            this.class64_4.TabStop = true;
            this.class64_4.Text = "Block selected ports only";
            this.class64_4.UseVisualStyleBackColor = false;
            // 
            // textBox_1
            // 
            this.textBox_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.textBox_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_1.Enabled = false;
            this.textBox_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_1.Location = new System.Drawing.Point(36, 125);
            this.textBox_1.Name = "textBox_1";
            this.textBox_1.Size = new System.Drawing.Size(474, 22);
            this.textBox_1.TabIndex = 60;
            // 
            // class63_4
            // 
            this.class63_4.AutoSize = true;
            this.class63_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class63_4.Boolean_0 = false;
            this.class63_4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class63_4.Location = new System.Drawing.Point(33, 102);
            this.class63_4.Name = "class63_4";
            this.class63_4.Size = new System.Drawing.Size(441, 16);
            this.class63_4.TabIndex = 59;
            this.class63_4.Text = "Deny access from blocked countries to all ports except those listed below";
            // 
            // class63_5
            // 
            this.class63_5.AutoSize = true;
            this.class63_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class63_5.Boolean_0 = false;
            this.class63_5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class63_5.Location = new System.Drawing.Point(33, 47);
            this.class63_5.Name = "class63_5";
            this.class63_5.Size = new System.Drawing.Size(288, 16);
            this.class63_5.TabIndex = 58;
            this.class63_5.Text = "Deny access from blocked countries to all ports";
            // 
            // class64_0
            // 
            this.class64_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class64_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class64_0.Location = new System.Drawing.Point(17, 79);
            this.class64_0.Name = "class64_0";
            this.class64_0.Size = new System.Drawing.Size(209, 20);
            this.class64_0.TabIndex = 2;
            this.class64_0.TabStop = true;
            this.class64_0.Text = "Block all ports except selected";
            this.class64_0.UseVisualStyleBackColor = false;
            // 
            // class64_1
            // 
            this.class64_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class64_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class64_1.Location = new System.Drawing.Point(17, 24);
            this.class64_1.Name = "class64_1";
            this.class64_1.Size = new System.Drawing.Size(111, 20);
            this.class64_1.TabIndex = 1;
            this.class64_1.TabStop = true;
            this.class64_1.Text = "Block all ports";
            this.class64_1.UseVisualStyleBackColor = false;
            // 
            // tabPage_1
            // 
            this.tabPage_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPage_1.Controls.Add(this.class65_4);
            this.tabPage_1.Controls.Add(this.class65_3);
            this.tabPage_1.Controls.Add(this.class65_0);
            this.tabPage_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tabPage_1.Location = new System.Drawing.Point(4, 25);
            this.tabPage_1.Name = "tabPage_1";
            this.tabPage_1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_1.Size = new System.Drawing.Size(528, 589);
            this.tabPage_1.TabIndex = 1;
            this.tabPage_1.Text = "Allow Mode";
            // 
            // class65_4
            // 
            this.class65_4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.class65_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class65_4.Controls.Add(this.textBox_3);
            this.class65_4.Controls.Add(this.class63_9);
            this.class65_4.Controls.Add(this.class63_10);
            this.class65_4.Controls.Add(this.class64_7);
            this.class65_4.Controls.Add(this.class64_8);
            this.class65_4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class65_4.Location = new System.Drawing.Point(6, 175);
            this.class65_4.Name = "class65_4";
            this.class65_4.Size = new System.Drawing.Size(516, 163);
            this.class65_4.TabIndex = 59;
            this.class65_4.TabStop = false;
            this.class65_4.Text = "Other connections (from disallowed countries):";
            // 
            // textBox_3
            // 
            this.textBox_3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.textBox_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_3.Enabled = false;
            this.textBox_3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_3.Location = new System.Drawing.Point(36, 125);
            this.textBox_3.Name = "textBox_3";
            this.textBox_3.Size = new System.Drawing.Size(474, 22);
            this.textBox_3.TabIndex = 60;
            // 
            // class63_9
            // 
            this.class63_9.AutoSize = true;
            this.class63_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class63_9.Boolean_0 = false;
            this.class63_9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class63_9.Location = new System.Drawing.Point(33, 102);
            this.class63_9.Name = "class63_9";
            this.class63_9.Size = new System.Drawing.Size(457, 16);
            this.class63_9.TabIndex = 59;
            this.class63_9.Text = "Deny access from disallowed countries to all ports except those listed below";
            // 
            // class63_10
            // 
            this.class63_10.AutoSize = true;
            this.class63_10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class63_10.Boolean_0 = false;
            this.class63_10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class63_10.Location = new System.Drawing.Point(33, 47);
            this.class63_10.Name = "class63_10";
            this.class63_10.Size = new System.Drawing.Size(257, 16);
            this.class63_10.TabIndex = 58;
            this.class63_10.Text = "Deny all access from disallowed countries";
            // 
            // class64_7
            // 
            this.class64_7.AutoSize = true;
            this.class64_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class64_7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class64_7.Location = new System.Drawing.Point(17, 79);
            this.class64_7.Name = "class64_7";
            this.class64_7.Size = new System.Drawing.Size(207, 20);
            this.class64_7.TabIndex = 2;
            this.class64_7.TabStop = true;
            this.class64_7.Text = "Block all ports except selected";
            this.class64_7.UseVisualStyleBackColor = false;
            // 
            // class64_8
            // 
            this.class64_8.AutoSize = true;
            this.class64_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class64_8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class64_8.Location = new System.Drawing.Point(17, 24);
            this.class64_8.Name = "class64_8";
            this.class64_8.Size = new System.Drawing.Size(109, 20);
            this.class64_8.TabIndex = 1;
            this.class64_8.TabStop = true;
            this.class64_8.Text = "Block all ports";
            this.class64_8.UseVisualStyleBackColor = false;
            // 
            // class65_3
            // 
            this.class65_3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.class65_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class65_3.Controls.Add(this.textBox_2);
            this.class65_3.Controls.Add(this.class63_7);
            this.class65_3.Controls.Add(this.class63_8);
            this.class65_3.Controls.Add(this.class64_5);
            this.class65_3.Controls.Add(this.class64_6);
            this.class65_3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class65_3.Location = new System.Drawing.Point(6, 6);
            this.class65_3.Name = "class65_3";
            this.class65_3.Size = new System.Drawing.Size(516, 163);
            this.class65_3.TabIndex = 58;
            this.class65_3.TabStop = false;
            this.class65_3.Text = "Allow rules:";
            // 
            // textBox_2
            // 
            this.textBox_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.textBox_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_2.Enabled = false;
            this.textBox_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_2.Location = new System.Drawing.Point(36, 125);
            this.textBox_2.Name = "textBox_2";
            this.textBox_2.Size = new System.Drawing.Size(474, 22);
            this.textBox_2.TabIndex = 60;
            // 
            // class63_7
            // 
            this.class63_7.AutoSize = true;
            this.class63_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class63_7.Boolean_0 = false;
            this.class63_7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class63_7.Location = new System.Drawing.Point(33, 102);
            this.class63_7.Name = "class63_7";
            this.class63_7.Size = new System.Drawing.Size(392, 16);
            this.class63_7.TabIndex = 59;
            this.class63_7.Text = "Allow connections from allowed countries to the ports listed below";
            // 
            // class63_8
            // 
            this.class63_8.AutoSize = true;
            this.class63_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class63_8.Boolean_0 = false;
            this.class63_8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class63_8.Location = new System.Drawing.Point(33, 47);
            this.class63_8.Name = "class63_8";
            this.class63_8.Size = new System.Drawing.Size(314, 16);
            this.class63_8.TabIndex = 58;
            this.class63_8.Text = "Allow connections from allowed countries to all ports";
            // 
            // class64_5
            // 
            this.class64_5.AutoSize = true;
            this.class64_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class64_5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class64_5.Location = new System.Drawing.Point(17, 79);
            this.class64_5.Name = "class64_5";
            this.class64_5.Size = new System.Drawing.Size(234, 20);
            this.class64_5.TabIndex = 2;
            this.class64_5.TabStop = true;
            this.class64_5.Text = "Allow access to selected ports only";
            this.class64_5.UseVisualStyleBackColor = false;
            // 
            // class64_6
            // 
            this.class64_6.AutoSize = true;
            this.class64_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class64_6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class64_6.Location = new System.Drawing.Point(17, 24);
            this.class64_6.Name = "class64_6";
            this.class64_6.Size = new System.Drawing.Size(168, 20);
            this.class64_6.TabIndex = 1;
            this.class64_6.TabStop = true;
            this.class64_6.Text = "Allow access to all ports";
            this.class64_6.UseVisualStyleBackColor = false;
            // 
            // class65_0
            // 
            this.class65_0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.class65_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class65_0.Controls.Add(this.class63_0);
            this.class65_0.Controls.Add(this.class61_0);
            this.class65_0.Controls.Add(this.class63_1);
            this.class65_0.Controls.Add(this.class61_1);
            this.class65_0.Controls.Add(this.class63_2);
            this.class65_0.Controls.Add(this.class61_2);
            this.class65_0.Controls.Add(this.class63_3);
            this.class65_0.Controls.Add(this.class61_3);
            this.class65_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class65_0.Location = new System.Drawing.Point(6, 344);
            this.class65_0.Name = "class65_0";
            this.class65_0.Size = new System.Drawing.Size(516, 232);
            this.class65_0.TabIndex = 57;
            this.class65_0.TabStop = false;
            this.class65_0.Text = "Exceptions and special networks";
            // 
            // class63_0
            // 
            this.class63_0.AutoSize = true;
            this.class63_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class63_0.Boolean_0 = false;
            this.class63_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class63_0.Location = new System.Drawing.Point(33, 200);
            this.class63_0.Name = "class63_0";
            this.class63_0.Size = new System.Drawing.Size(344, 16);
            this.class63_0.TabIndex = 63;
            this.class63_0.Text = "Exclude known data center networks from the allowed IPs";
            // 
            // class61_0
            // 
            this.class61_0.AutoSize = true;
            this.class61_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class61_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class61_0.Location = new System.Drawing.Point(17, 177);
            this.class61_0.Name = "class61_0";
            this.class61_0.Size = new System.Drawing.Size(375, 20);
            this.class61_0.TabIndex = 62;
            this.class61_0.Text = "Exclude data center networks from the allowed connections";
            this.class61_0.UseVisualStyleBackColor = false;
            // 
            // class63_1
            // 
            this.class63_1.AutoSize = true;
            this.class63_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class63_1.Boolean_0 = false;
            this.class63_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class63_1.Location = new System.Drawing.Point(33, 150);
            this.class63_1.Name = "class63_1";
            this.class63_1.Size = new System.Drawing.Size(419, 16);
            this.class63_1.TabIndex = 61;
            this.class63_1.Text = "Exclude known VPN networks and Tor exit nodes from the allowed IPs";
            // 
            // class61_1
            // 
            this.class61_1.AutoSize = true;
            this.class61_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class61_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class61_1.Location = new System.Drawing.Point(17, 127);
            this.class61_1.Name = "class61_1";
            this.class61_1.Size = new System.Drawing.Size(450, 20);
            this.class61_1.TabIndex = 60;
            this.class61_1.Text = "Exclude VPN networks and Tor exit nodes from the allowed connections";
            this.class61_1.UseVisualStyleBackColor = false;
            // 
            // class63_2
            // 
            this.class63_2.AutoSize = true;
            this.class63_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class63_2.Boolean_0 = false;
            this.class63_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class63_2.Location = new System.Drawing.Point(33, 100);
            this.class63_2.Name = "class63_2";
            this.class63_2.Size = new System.Drawing.Size(425, 16);
            this.class63_2.TabIndex = 59;
            this.class63_2.Text = "Turn on if you want the machine to be accessible over the local network";
            // 
            // class61_2
            // 
            this.class61_2.AutoSize = true;
            this.class61_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class61_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class61_2.Location = new System.Drawing.Point(17, 77);
            this.class61_2.Name = "class61_2";
            this.class61_2.Size = new System.Drawing.Size(165, 20);
            this.class61_2.TabIndex = 58;
            this.class61_2.Text = "Allow local connections";
            this.class61_2.UseVisualStyleBackColor = false;
            // 
            // class63_3
            // 
            this.class63_3.AutoSize = true;
            this.class63_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class63_3.Boolean_0 = false;
            this.class63_3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class63_3.Location = new System.Drawing.Point(33, 50);
            this.class63_3.Name = "class63_3";
            this.class63_3.Size = new System.Drawing.Size(437, 16);
            this.class63_3.TabIndex = 57;
            this.class63_3.Text = "Blocking these connections could disrupt normal operation of many apps";
            // 
            // class61_3
            // 
            this.class61_3.AutoSize = true;
            this.class61_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class61_3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class61_3.Location = new System.Drawing.Point(17, 27);
            this.class61_3.Name = "class61_3";
            this.class61_3.Size = new System.Drawing.Size(292, 20);
            this.class61_3.TabIndex = 56;
            this.class61_3.Text = "Allow loopback connections (recommended)";
            this.class61_3.UseVisualStyleBackColor = false;
            // 
            // tabPage_2
            // 
            this.tabPage_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPage_2.Controls.Add(this.class65_2);
            this.tabPage_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tabPage_2.Location = new System.Drawing.Point(4, 25);
            this.tabPage_2.Name = "tabPage_2";
            this.tabPage_2.Size = new System.Drawing.Size(528, 589);
            this.tabPage_2.TabIndex = 2;
            this.tabPage_2.Text = "Miscellaneous";
            // 
            // class65_2
            // 
            this.class65_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.class65_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class65_2.Controls.Add(this.class64_2);
            this.class65_2.Controls.Add(this.class64_3);
            this.class65_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class65_2.Location = new System.Drawing.Point(6, 6);
            this.class65_2.Name = "class65_2";
            this.class65_2.Size = new System.Drawing.Size(516, 83);
            this.class65_2.TabIndex = 52;
            this.class65_2.TabStop = false;
            this.class65_2.Text = "Database version:";
            // 
            // class64_2
            // 
            this.class64_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class64_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class64_2.Location = new System.Drawing.Point(17, 50);
            this.class64_2.Name = "class64_2";
            this.class64_2.Size = new System.Drawing.Size(434, 20);
            this.class64_2.TabIndex = 2;
            this.class64_2.TabStop = true;
            this.class64_2.Text = "Max (more entries, higher impact on OS performance, more accurate)";
            this.class64_2.UseVisualStyleBackColor = false;
            // 
            // class64_3
            // 
            this.class64_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class64_3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class64_3.Location = new System.Drawing.Point(17, 24);
            this.class64_3.Name = "class64_3";
            this.class64_3.Size = new System.Drawing.Size(420, 20);
            this.class64_3.TabIndex = 1;
            this.class64_3.TabStop = true;
            this.class64_3.Text = "Lite (fewer entries, lower impact on OS performance, less accurate)";
            this.class64_3.UseVisualStyleBackColor = false;
            // 
            // AdvancedGeoIPSettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 771);
            this.Controls.Add(this.control14_0);
            this.Controls.Add(this.gclass3_0);
            this.Controls.Add(this.gcontrol0_0);
            this.Controls.Add(this.class62_0);
            this.Controls.Add(this.class62_1);
            this.Controls.Add(this.pictureBox_0);
            this.Controls.Add(this.class66_0);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AdvancedGeoIPSettingsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Advanced Geo-IP Settings";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_0)).EndInit();
            this.control14_0.ResumeLayout(false);
            this.tabPage_0.ResumeLayout(false);
            this.class65_1.ResumeLayout(false);
            this.class65_1.PerformLayout();
            this.tabPage_1.ResumeLayout(false);
            this.class65_4.ResumeLayout(false);
            this.class65_4.PerformLayout();
            this.class65_3.ResumeLayout(false);
            this.class65_3.PerformLayout();
            this.class65_0.ResumeLayout(false);
            this.class65_0.PerformLayout();
            this.tabPage_2.ResumeLayout(false);
            this.class65_2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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

	private void method_15(object sender, EventArgs e)
	{
		method_13();
	}

	private void method_16(object sender, EventArgs e)
	{
		method_13();
	}

	private void method_17(object sender, EventArgs e)
	{
		method_13();
	}

	private void class66_0_Click(object sender, EventArgs e)
	{
		method_8(DialogResult.OK);
	}
}
