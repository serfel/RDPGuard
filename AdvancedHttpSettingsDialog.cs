using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class AdvancedHttpSettingsDialog : Form0
{
	private readonly string string_0 = string.Empty;

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

	private GClass3 gclass3_1;

	private Class61 class61_1;
    private IContainer components;
    private Class63 class63_1;

	public bool Boolean_0
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

	public bool Boolean_1
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

	public AdvancedHttpSettingsDialog(string string_1)
		: base(new Size(470, 330))
	{
		string_0 = string_1;
        InitializeComponent();
		vmethod_1();
		ReInitializeComponent();
        method_13();
    }

	private void ReInitializeComponent()
	{
		gclass3_0.Click += gclass3_0_Click;
		class61_0.CheckedChanged += class61_0_CheckedChanged;
		gclass3_1.Click += gclass3_1_Click;
		class66_0.Click += class66_0_Click;
		class66_1.Click += class66_1_Click;
	}

	private void method_13()
	{
		bool enabled = class61_0.Checked;
		class61_1.Enabled = enabled;
		class63_1.Enabled = enabled;
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
            this.class66_1 = new Class66();
            this.gcontrol0_0 = new GControl0();
            this.class62_0 = new Class62();
            this.pictureBox_0 = new System.Windows.Forms.PictureBox();
            this.class62_1 = new Class62();
            this.gclass3_0 = new GClass3();
            this.class61_0 = new Class61();
            this.class63_0 = new Class63();
            this.gclass3_1 = new GClass3();
            this.class61_1 = new Class61();
            this.class63_1 = new Class63();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_0)).BeginInit();
            this.SuspendLayout();
            // 
            // class66_0
            // 
            this.class66_0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.class66_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class66_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.class66_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class66_0.Image = global::Properties.Resources.opts_16;
            this.class66_0.Location = new System.Drawing.Point(210, 242);
            this.class66_0.Margin = new System.Windows.Forms.Padding(4);
            this.class66_0.Name = "class66_0";
            this.class66_0.Size = new System.Drawing.Size(100, 36);
            this.class66_0.TabIndex = 7;
            this.class66_0.Text = "Save";
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
            this.class66_1.Location = new System.Drawing.Point(318, 242);
            this.class66_1.Margin = new System.Windows.Forms.Padding(4);
            this.class66_1.Name = "class66_1";
            this.class66_1.Size = new System.Drawing.Size(100, 36);
            this.class66_1.TabIndex = 8;
            this.class66_1.Text = "Cancel";
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
            this.gcontrol0_0.Size = new System.Drawing.Size(406, 2);
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
            this.class62_0.Size = new System.Drawing.Size(108, 16);
            this.class62_0.TabIndex = 49;
            this.class62_0.Text = "HTTP Settings";
            // 
            // pictureBox_0
            // 
            this.pictureBox_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pictureBox_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pictureBox_0.Image = global::Properties.Resources.http_48;
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
            this.class62_1.Size = new System.Drawing.Size(220, 16);
            this.class62_1.TabIndex = 48;
            this.class62_1.Text = "Advanced HTTP protection settings";
            // 
            // gclass3_0
            // 
            this.gclass3_0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gclass3_0.AutoSize = true;
            this.gclass3_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gclass3_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gclass3_0.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.gclass3_0.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(135)))), ((int)(((byte)(200)))));
            this.gclass3_0.Location = new System.Drawing.Point(349, 9);
            this.gclass3_0.Name = "gclass3_0";
            this.gclass3_0.Size = new System.Drawing.Size(72, 16);
            this.gclass3_0.TabIndex = 9;
            this.gclass3_0.TabStop = true;
            this.gclass3_0.Text = "online help";
            this.gclass3_0.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(135)))), ((int)(((byte)(200)))));
            // 
            // class61_0
            // 
            this.class61_0.AutoSize = true;
            this.class61_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class61_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class61_0.Location = new System.Drawing.Point(16, 97);
            this.class61_0.Name = "class61_0";
            this.class61_0.Size = new System.Drawing.Size(351, 20);
            this.class61_0.TabIndex = 65;
            this.class61_0.Text = "Use the X-Forwarded-For field to read client IP address";
            this.class61_0.UseVisualStyleBackColor = false;
            // 
            // class63_0
            // 
            this.class63_0.AutoSize = true;
            this.class63_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class63_0.Boolean_0 = true;
            this.class63_0.ForeColor = System.Drawing.Color.Red;
            this.class63_0.Location = new System.Drawing.Point(13, 122);
            this.class63_0.Name = "class63_0";
            this.class63_0.Size = new System.Drawing.Size(391, 16);
            this.class63_0.TabIndex = 67;
            this.class63_0.Text = "Do not enable unless you are hosting the website behind a proxy.";
            // 
            // gclass3_1
            // 
            this.gclass3_1.AutoSize = true;
            this.gclass3_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gclass3_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gclass3_1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.gclass3_1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(135)))), ((int)(((byte)(200)))));
            this.gclass3_1.Location = new System.Drawing.Point(13, 145);
            this.gclass3_1.Name = "gclass3_1";
            this.gclass3_1.Size = new System.Drawing.Size(405, 16);
            this.gclass3_1.TabIndex = 68;
            this.gclass3_1.TabStop = true;
            this.gclass3_1.Text = "Additional configuration required for the proxy and the HTTP server.";
            this.gclass3_1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(135)))), ((int)(((byte)(200)))));
            // 
            // class61_1
            // 
            this.class61_1.AutoSize = true;
            this.class61_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class61_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class61_1.Location = new System.Drawing.Point(16, 180);
            this.class61_1.Name = "class61_1";
            this.class61_1.Size = new System.Drawing.Size(356, 20);
            this.class61_1.TabIndex = 69;
            this.class61_1.Text = "Fall back to the client IP address if the header is missing";
            this.class61_1.UseVisualStyleBackColor = false;
            // 
            // class63_1
            // 
            this.class63_1.AutoSize = true;
            this.class63_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class63_1.Boolean_0 = false;
            this.class63_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class63_1.Location = new System.Drawing.Point(13, 205);
            this.class63_1.Name = "class63_1";
            this.class63_1.Size = new System.Drawing.Size(414, 16);
            this.class63_1.TabIndex = 70;
            this.class63_1.Text = "Allows using the client IP when the X-Forwarded-For header is not set.";
            // 
            // AdvancedHttpSettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gclass3_1);
            this.Controls.Add(this.class63_0);
            this.Controls.Add(this.class61_0);
            this.Controls.Add(this.class61_1);
            this.Controls.Add(this.class63_1);
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
            this.Name = "AdvancedHttpSettingsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Advanced HTTP Settings";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

	}

	private void gclass3_0_Click(object sender, EventArgs e)
	{
		method_9(string_0);
	}

	private void class61_0_CheckedChanged(object sender, EventArgs e)
	{
		method_13();
	}

	private void gclass3_1_Click(object sender, EventArgs e)
	{
		method_9(Class148.String_7);
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
