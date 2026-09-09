using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class FtpSettingsDialog : Form0
{
	private TrafficMonitoringControl control12_0;

	private FtpMonitoringViaLogsControl control3_0;

	private IContainer component;

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
    private IContainer components;
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
			Class208.smethod_0("FtpSettingsDialog::MonitoringMethod::get unknown_method");
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
			Class208.smethod_0("FtpSettingsDialog::MonitoringMethod::set unknown_method " + num);
		}
	}

	public Class114 Class114_0
	{
		get
		{
			return new Class114
			{
				bool_0 = class61_0.Checked,
				GEnum4_0 = GEnum4_0,
				UInt16_0 = control12_0.UInt16_0,
				genum5_0 = control12_0.GEnum5_0,
				bool_1 = control12_0.bool_1,
				GClass24_0 = control12_0.gclass24_0,
				class127_0 = control12_0.class127_0,
				genum7_0 = control3_0.GEnum7_0,
				String_1 = control3_0.String_0
			};
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
			control3_0.GEnum7_0 = value.genum7_0;
			control3_0.String_0 = value.String_1;
		}
	}

	public FtpSettingsDialog(Class114 class114_0)
		: base(new Size(570, 670))
	{
		InitializeComponent();
		vmethod_1();
		InitializeControls();
		WireUpEvents();
		Class114_0 = class114_0;
        ReInitializeComponent();
	}

	private void InitializeControls()
	{
		control12_0 = new TrafficMonitoringControl(new Class114().UInt16_1)
		{
			String_0 = "Select monitoring method for FTP traffic:",
			String_1 = "Specify FTP port:",
			String_2 = "You can specify multiple comma-separated ports, i.e. 21, 2121",
			Dock = DockStyle.Fill
		};
		panel_0.Controls.Add(control12_0);
		control3_0 = new FtpMonitoringViaLogsControl
		{
			Dock = DockStyle.Fill,
			eventHandler_2 = method_15
		};
		panel_0.Controls.Add(control3_0);
	}

	private void WireUpEvents()
	{
		gclass3_0.Click += gclass3_0_Click;
		class61_0.CheckedChanged += class61_0_CheckedChanged;
		class64_1.CheckedChanged += class64_1_CheckedChanged;
		class64_0.CheckedChanged += class64_0_CheckedChanged;
		control12_0.Event_1 += method_16;
		control12_0.Event_0 += method_17;
		control3_0.Event_1 += method_18;
		control3_0.Event_0 += method_19;
		class66_0.Click += class66_0_Click;
		class66_1.Click += class66_1_Click;
	}

	private void ReInitializeComponent()
	{
		bool flag = class61_0.Checked;
		class65_0.Enabled = flag;
		control12_0.Enabled = flag && class64_1.Checked;
		control12_0.Visible = class64_1.Checked;
		control3_0.Enabled = flag && class64_0.Checked;
		control3_0.Visible = class64_0.Checked;
		if (class64_1.Checked)
		{
			class66_0.Enabled = !flag || control12_0.Boolean_0;
		}
		if (class64_0.Checked)
		{
			class66_0.Enabled = !flag || control3_0.Boolean_0;
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && component != null)
		{
			component.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
            this.components = new System.ComponentModel.Container();
            this.class66_0 = new Class66();
            this.class66_1 = new Class66();
            this.gcontrol0_0 = new GControl0();
            this.class62_0 = new Class62();
            this.pictureBox_0 = new System.Windows.Forms.PictureBox();
            this.class62_1 = new Class62();
            this.gclass3_0 = new GClass3();
            this.panel_0 = new System.Windows.Forms.Panel();
            this.panel_1 = new System.Windows.Forms.Panel();
            this.class65_0 = new Class65();
            this.class63_0 = new Class63();
            this.class63_1 = new Class63();
            this.class64_0 = new Class64();
            this.class64_1 = new Class64();
            this.class63_2 = new Class63();
            this.class61_0 = new Class61();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_0)).BeginInit();
            this.panel_1.SuspendLayout();
            this.class65_0.SuspendLayout();
            this.SuspendLayout();
            // 
            // class66_0
            // 
            this.class66_0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.class66_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class66_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.class66_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class66_0.Image = global::Properties.Resources.opts_16;
            this.class66_0.Location = new System.Drawing.Point(333, 582);
            this.class66_0.Margin = new System.Windows.Forms.Padding(4);
            this.class66_0.Name = "class66_0";
            this.class66_0.Size = new System.Drawing.Size(100, 36);
            this.class66_0.TabIndex = 7;
            this.class66_0.Text = "Сохранить";
            this.class66_0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.class66_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.class66_0.UseVisualStyleBackColor = false;
            // 
            // class66_1
            // 
            this.class66_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.class66_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class66_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.class66_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class66_1.Image = global::Properties.Resources.cancl_16;
            this.class66_1.Location = new System.Drawing.Point(441, 582);
            this.class66_1.Margin = new System.Windows.Forms.Padding(4);
            this.class66_1.Name = "class66_1";
            this.class66_1.Size = new System.Drawing.Size(100, 36);
            this.class66_1.TabIndex = 8;
            this.class66_1.Text = "Отмена";
            this.class66_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.class66_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.class66_1.UseVisualStyleBackColor = false;
            // 
            // gcontrol0_0
            // 
            this.gcontrol0_0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcontrol0_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gcontrol0_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gcontrol0_0.Location = new System.Drawing.Point(16, 81);
            this.gcontrol0_0.Name = "gcontrol0_0";
            this.gcontrol0_0.Size = new System.Drawing.Size(526, 2);
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
            this.class62_0.Size = new System.Drawing.Size(96, 16);
            this.class62_0.TabIndex = 49;
            this.class62_0.Text = "Параметры FTP";
            // 
            // pictureBox_0
            // 
            this.pictureBox_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pictureBox_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pictureBox_0.Image = global::Properties.Resources.ftp_48;
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
            this.class62_1.Size = new System.Drawing.Size(207, 16);
            this.class62_1.TabIndex = 48;
            this.class62_1.Text = "Настройте параметры защиты FTP.";
            // 
            // gclass3_0
            // 
            this.gclass3_0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gclass3_0.AutoSize = true;
            this.gclass3_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gclass3_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gclass3_0.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.gclass3_0.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(135)))), ((int)(((byte)(200)))));
            this.gclass3_0.Location = new System.Drawing.Point(469, 9);
            this.gclass3_0.Name = "gclass3_0";
            this.gclass3_0.Size = new System.Drawing.Size(72, 16);
            this.gclass3_0.TabIndex = 9;
            this.gclass3_0.TabStop = true;
            this.gclass3_0.Text = "справка онлайн";
            this.gclass3_0.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(135)))), ((int)(((byte)(200)))));
            // 
            // panel_0
            // 
            this.panel_0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.panel_0.Location = new System.Drawing.Point(12, 304);
            this.panel_0.Name = "panel_0";
            this.panel_0.Size = new System.Drawing.Size(530, 271);
            this.panel_0.TabIndex = 111;
            // 
            // panel_1
            // 
            this.panel_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel_1.Controls.Add(this.class65_0);
            this.panel_1.Controls.Add(this.class63_2);
            this.panel_1.Controls.Add(this.class61_0);
            this.panel_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.panel_1.Location = new System.Drawing.Point(12, 89);
            this.panel_1.Name = "panel_1";
            this.panel_1.Size = new System.Drawing.Size(530, 209);
            this.panel_1.TabIndex = 112;
            // 
            // class65_0
            // 
            this.class65_0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.class65_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class65_0.Controls.Add(this.class63_0);
            this.class65_0.Controls.Add(this.class63_1);
            this.class65_0.Controls.Add(this.class64_0);
            this.class65_0.Controls.Add(this.class64_1);
            this.class65_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class65_0.Location = new System.Drawing.Point(0, 61);
            this.class65_0.Name = "class65_0";
            this.class65_0.Size = new System.Drawing.Size(530, 145);
            this.class65_0.TabIndex = 113;
            this.class65_0.TabStop = false;
            this.class65_0.Text = "Способ мониторинга протокола FTP:";
            // 
            // class63_0
            // 
            this.class63_0.AutoSize = true;
            this.class63_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class63_0.Boolean_0 = false;
            this.class63_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class63_0.Location = new System.Drawing.Point(12, 55);
            this.class63_0.Name = "class63_0";
            this.class63_0.Size = new System.Drawing.Size(453, 16);
            this.class63_0.TabIndex = 113;
            this.class63_0.Text = "Работает с журналами FTP-сервера, поддерживаются соединения SSL/TLS.";
            // 
            // class63_1
            // 
            this.class63_1.AutoSize = true;
            this.class63_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class63_1.Boolean_0 = false;
            this.class63_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class63_1.Location = new System.Drawing.Point(12, 108);
            this.class63_1.Name = "class63_1";
            this.class63_1.Size = new System.Drawing.Size(414, 16);
            this.class63_1.TabIndex = 112;
            this.class63_1.Text = "Работает с любым FTP-сервером. Соединения SSL/TLS не поддерживаются.";
            // 
            // class64_0
            // 
            this.class64_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class64_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class64_0.Location = new System.Drawing.Point(15, 32);
            this.class64_0.Name = "class64_0";
            this.class64_0.Size = new System.Drawing.Size(57, 20);
            this.class64_0.TabIndex = 111;
            this.class64_0.TabStop = true;
            this.class64_0.Text = "Журналы";
            this.class64_0.UseVisualStyleBackColor = false;
            // 
            // class64_1
            // 
            this.class64_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class64_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class64_1.Location = new System.Drawing.Point(15, 85);
            this.class64_1.Name = "class64_1";
            this.class64_1.Size = new System.Drawing.Size(64, 20);
            this.class64_1.TabIndex = 110;
            this.class64_1.TabStop = true;
            this.class64_1.Text = "Трафик";
            this.class64_1.UseVisualStyleBackColor = false;
            // 
            // class63_2
            // 
            this.class63_2.AutoSize = true;
            this.class63_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class63_2.Boolean_0 = false;
            this.class63_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class63_2.Location = new System.Drawing.Point(3, 26);
            this.class63_2.Name = "class63_2";
            this.class63_2.Size = new System.Drawing.Size(202, 16);
            this.class63_2.TabIndex = 112;
            this.class63_2.Text = "Включите для защиты FTP";
            // 
            // class61_0
            // 
            this.class61_0.AutoSize = true;
            this.class61_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class61_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class61_0.Location = new System.Drawing.Point(4, 3);
            this.class61_0.Name = "class61_0";
            this.class61_0.Size = new System.Drawing.Size(160, 20);
            this.class61_0.TabIndex = 111;
            this.class61_0.Text = "Включить защиту FTP";
            this.class61_0.UseVisualStyleBackColor = false;
            // 
            // FtpSettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 631);
            this.Controls.Add(this.panel_1);
            this.Controls.Add(this.panel_0);
            this.Controls.Add(this.gclass3_0);
            this.Controls.Add(this.gcontrol0_0);
            this.Controls.Add(this.class62_0);
            this.Controls.Add(this.class62_1);
            this.Controls.Add(this.pictureBox_0);
            this.Controls.Add(this.class66_0);
            this.Controls.Add(this.class66_1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FtpSettingsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Параметры FTP";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_0)).EndInit();
            this.panel_1.ResumeLayout(false);
            this.panel_1.PerformLayout();
            this.class65_0.ResumeLayout(false);
            this.class65_0.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

	}

	private void method_15(object sender, EventArgs e)
	{
		base.Height += control3_0.Size_0.Height - panel_0.Height;
	}

	private void gclass3_0_Click(object sender, EventArgs e)
	{
		method_9(Class148.Class151.String_2);
	}

	private void class61_0_CheckedChanged(object sender, EventArgs e)
	{
        ReInitializeComponent();
	}

	private void class64_1_CheckedChanged(object sender, EventArgs e)
	{
        ReInitializeComponent();
	}

	private void class64_0_CheckedChanged(object sender, EventArgs e)
	{
        ReInitializeComponent();
	}

	private void method_16(object sender, EventArgs e)
	{
		class66_0.Enabled = control12_0.Boolean_0;
	}

	private void method_17(object sender, EventArgs e)
	{
		class66_0.PerformClick();
	}

	private void method_18(object sender, EventArgs e)
	{
		class66_0.Enabled = control3_0.Boolean_0;
	}

	private void method_19(object sender, EventArgs e)
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
