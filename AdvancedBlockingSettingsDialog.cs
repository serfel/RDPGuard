using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class AdvancedBlockingSettingsDialog : Form0
{
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

	private Class63 class63_1;

	private Class62 class62_2;

	private TextBox textBox_0;
    private IContainer components;
    private Class62 class62_3;

	public Class169 Class169_0
	{
		get
		{
			return new Class169
			{
				ushort_0 = Class168.smethod_1(textBox_0.Text),
				Boolean_0 = class61_0.Checked
			};
		}
		set
		{
			class61_0.CheckState = CheckState.Checked;
			class61_0.Checked = !value.Boolean_1;
			textBox_0.Text = Class168.smethod_0(value.ushort_0);
		}
	}

	protected override Button Button_0 => class66_0;

	public AdvancedBlockingSettingsDialog(Class169 class169_0)
		: base(new Size(500, 345))
	{
        InitializeComponent();
		vmethod_1();
        class62_3.Left = class62_2.Right;
        ReInitializeComponent();
		Class169_0 = class169_0;
	}

	private void ReInitializeComponent()
	{
		gclass3_0.Click += gclass3_0_Click;
		class61_0.CheckedChanged += class61_0_CheckedChanged;
		class66_0.Click += class66_0_Click;
		class66_1.Click += class66_1_Click;
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
            this.class63_1 = new Class63();
            this.class62_2 = new Class62();
            this.textBox_0 = new System.Windows.Forms.TextBox();
            this.class62_3 = new Class62();
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
            this.class66_0.Location = new System.Drawing.Point(263, 257);
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
            this.class66_1.Location = new System.Drawing.Point(371, 257);
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
            this.gcontrol0_0.Size = new System.Drawing.Size(456, 2);
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
            this.class62_0.Size = new System.Drawing.Size(198, 16);
            this.class62_0.TabIndex = 49;
            this.class62_0.Text = "Advanced blocking settings";
            // 
            // pictureBox_0
            // 
            this.pictureBox_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pictureBox_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pictureBox_0.Image = global::Properties.Resources.firewall_edit_48;
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
            this.class62_1.Size = new System.Drawing.Size(205, 16);
            this.class62_1.TabIndex = 48;
            this.class62_1.Text = "Advanced settings for IP blocking";
            // 
            // gclass3_0
            // 
            this.gclass3_0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gclass3_0.AutoSize = true;
            this.gclass3_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gclass3_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gclass3_0.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.gclass3_0.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(135)))), ((int)(((byte)(200)))));
            this.gclass3_0.Location = new System.Drawing.Point(399, 9);
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
            this.class61_0.Size = new System.Drawing.Size(350, 20);
            this.class61_0.TabIndex = 0;
            this.class61_0.Text = "Block access to all ports on the server (recommended)";
            this.class61_0.UseVisualStyleBackColor = false;
            // 
            // class63_0
            // 
            this.class63_0.AutoSize = true;
            this.class63_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class63_0.Boolean_0 = false;
            this.class63_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class63_0.Location = new System.Drawing.Point(13, 122);
            this.class63_0.Name = "class63_0";
            this.class63_0.Size = new System.Drawing.Size(296, 16);
            this.class63_0.TabIndex = 58;
            this.class63_0.Text = "Turn on to block access to all ports  on the server";
            // 
            // class63_1
            // 
            this.class63_1.AutoSize = true;
            this.class63_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class63_1.Boolean_0 = false;
            this.class63_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class63_1.Location = new System.Drawing.Point(20, 213);
            this.class63_1.Name = "class63_1";
            this.class63_1.Size = new System.Drawing.Size(421, 16);
            this.class63_1.TabIndex = 71;
            this.class63_1.Text = "You can also specify multiple comma-separated ports, i.e. 3389, 21, 25";
            // 
            // class62_2
            // 
            this.class62_2.AutoSize = true;
            this.class62_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class62_2.Boolean_0 = false;
            this.class62_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class62_2.Location = new System.Drawing.Point(13, 157);
            this.class62_2.Name = "class62_2";
            this.class62_2.Size = new System.Drawing.Size(91, 16);
            this.class62_2.TabIndex = 70;
            this.class62_2.Text = "Ports to block:";
            // 
            // textBox_0
            // 
            this.textBox_0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.textBox_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_0.Location = new System.Drawing.Point(23, 183);
            this.textBox_0.Name = "textBox_0";
            this.textBox_0.Size = new System.Drawing.Size(448, 22);
            this.textBox_0.TabIndex = 77;
            // 
            // class62_3
            // 
            this.class62_3.AutoSize = true;
            this.class62_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class62_3.Boolean_0 = true;
            this.class62_3.ForeColor = System.Drawing.Color.Red;
            this.class62_3.Location = new System.Drawing.Point(103, 157);
            this.class62_3.Name = "class62_3";
            this.class62_3.Size = new System.Drawing.Size(355, 16);
            this.class62_3.TabIndex = 78;
            this.class62_3.Text = "(network performance may be affected, please check help)";
            // 
            // AdvancedBlockingSettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.class62_3);
            this.Controls.Add(this.textBox_0);
            this.Controls.Add(this.class63_1);
            this.Controls.Add(this.class62_2);
            this.Controls.Add(this.class63_0);
            this.Controls.Add(this.class61_0);
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
            this.Name = "AdvancedBlockingSettingsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Blocking Settings";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

	}

	private void gclass3_0_Click(object sender, EventArgs e)
	{
		method_9(Class148.String_5);
	}

	private void class61_0_CheckedChanged(object sender, EventArgs e)
	{
		bool enabled = !class61_0.Checked;
		class62_2.Enabled = enabled;
		class62_3.Enabled = enabled;
		textBox_0.Enabled = enabled;
		class63_1.Enabled = enabled;
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
