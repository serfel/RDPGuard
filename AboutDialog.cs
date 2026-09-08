using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class AboutDialog : Form0
{
	private IContainer icontainer_0;

	private PictureBox pictureBox_0;

	private Class62 class62_0;

	private Class66 class66_0;

	private Class62 class62_1;

	private GClass3 gclass3_0;

	private GClass3 gclass3_1;

	private GClass3 gclass3_2;

	public AboutDialog(string string_0)
		: base(new Size(600, 235))
	{
		InitializeComponent();
		vmethod_1();
		method_11(string_0);
		ReInitializeComponent();
	}

	private void method_11(string string_0)
	{
		class62_0.Text = string_0;
		class62_1.Text = "© 2012-2026 Netsdk Software. Все права защищены.";
	}

	private void ReInitializeComponent()
	{
		class66_0.Click += class66_0_Click;
		gclass3_0.LinkClicked += gclass3_0_LinkClicked;
		gclass3_1.LinkClicked += gclass3_1_LinkClicked;
		gclass3_2.LinkClicked += gclass3_2_LinkClicked;
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
            this.pictureBox_0 = new System.Windows.Forms.PictureBox();
            this.class62_0 = new Class62();
            this.class66_0 = new Class66();
            this.class62_1 = new Class62();
            this.gclass3_0 = new GClass3();
            this.gclass3_1 = new GClass3();
            this.gclass3_2 = new GClass3();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_0)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_0
            // 
            this.pictureBox_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pictureBox_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pictureBox_0.Image = global::Properties.Resources.rdpguard_logo_128;
            this.pictureBox_0.Location = new System.Drawing.Point(16, 15);
            this.pictureBox_0.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_0.Name = "pictureBox_0";
            this.pictureBox_0.Size = new System.Drawing.Size(128, 128);
            this.pictureBox_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_0.TabIndex = 0;
            this.pictureBox_0.TabStop = false;
            // 
            // class62_0
            // 
            this.class62_0.AutoSize = true;
            this.class62_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class62_0.Boolean_0 = false;
            this.class62_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.class62_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class62_0.Location = new System.Drawing.Point(176, 15);
            this.class62_0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.class62_0.Name = "class62_0";
            this.class62_0.Size = new System.Drawing.Size(60, 16);
            this.class62_0.TabIndex = 1;
            this.class62_0.Text = "Заголовок";
            // 
            // class66_0
            // 
            this.class66_0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.class66_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class66_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.class66_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class66_0.Image = global::Properties.Resources.opts_16;
            this.class66_0.Location = new System.Drawing.Point(471, 143);
            this.class66_0.Margin = new System.Windows.Forms.Padding(4);
            this.class66_0.Name = "class66_0";
            this.class66_0.Size = new System.Drawing.Size(100, 36);
            this.class66_0.TabIndex = 3;
            this.class66_0"OK";
            this.class66_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.class66_0.UseVisualStyleBackColor = false;
            // 
            // class62_1
            // 
            this.class62_1.AutoSize = true;
            this.class62_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class62_1.Boolean_0 = false;
            this.class62_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class62_1.Location = new System.Drawing.Point(176, 47);
            this.class62_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.class62_1.Name = "class62_1";
            this.class62_1.Size = new System.Drawing.Size(0, 16);
            this.class62_1.TabIndex = 4;
            // 
            // gclass3_0
            // 
            this.gclass3_0.AutoSize = true;
            this.gclass3_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gclass3_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gclass3_0.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.gclass3_0.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(135)))), ((int)(((byte)(200)))));
            this.gclass3_0.Location = new System.Drawing.Point(176, 92);
            this.gclass3_0.Name = "gclass3_0";
            this.gclass3_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gclass3_0.Size = new System.Drawing.Size(146, 16);
            this.gclass3_0.TabIndex = 11;
            this.gclass3_0.TabStop = true;
            this.gclass3_0"RdpGuard Home Page";
            this.gclass3_0.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(135)))), ((int)(((byte)(200)))));
            // 
            // gclass3_1
            // 
            this.gclass3_1.AutoSize = true;
            this.gclass3_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gclass3_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gclass3_1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.gclass3_1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(135)))), ((int)(((byte)(200)))));
            this.gclass3_1.Location = new System.Drawing.Point(176, 123);
            this.gclass3_1.Name = "gclass3_1";
            this.gclass3_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gclass3_1.Size = new System.Drawing.Size(104, 16);
            this.gclass3_1.TabIndex = 12;
            this.gclass3_1.TabStop = true;
            this.gclass3_1"Get License Key";
            this.gclass3_1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(135)))), ((int)(((byte)(200)))));
            // 
            // gclass3_2
            // 
            this.gclass3_2.AutoSize = true;
            this.gclass3_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gclass3_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gclass3_2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.gclass3_2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(135)))), ((int)(((byte)(200)))));
            this.gclass3_2.Location = new System.Drawing.Point(176, 156);
            this.gclass3_2.Name = "gclass3_2";
            this.gclass3_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gclass3_2.Size = new System.Drawing.Size(69, 16);
            this.gclass3_2.TabIndex = 13;
            this.gclass3_2.TabStop = true;
            this.gclass3_2"Contact us";
            this.gclass3_2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(135)))), ((int)(((byte)(200)))));
            // 
            // AboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gclass3_2);
            this.Controls.Add(this.gclass3_1);
            this.Controls.Add(this.gclass3_0);
            this.Controls.Add(this.class62_1);
            this.Controls.Add(this.class66_0);
            this.Controls.Add(this.class62_0);
            this.Controls.Add(this.pictureBox_0);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AboutDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this"About RdpGuard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

	}

	private void class66_0_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void gclass3_0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		method_9(Class148.String_2);
	}

	private void gclass3_1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		method_9(Class148.Class150.smethod_0("about"));
	}

	private void gclass3_2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		method_9(Class148.String_1);
	}
}
