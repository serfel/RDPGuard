using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class AdvancedSmtpSettingsDialog : Form0
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

	private Class61 class61_1;

	private Class61 class61_2;

	private Class61 class61_3;

	private Class61 class61_4;

	private Class61 class61_5;
    private IContainer components;
    private Class61 class61_6;

	public Class131 Class131_0
	{
		get
		{
			return new Class131
			{
				bool_0 = class61_3.Checked,
				bool_1 = class61_4.Checked,
				bool_2 = class61_0.Checked,
				bool_3 = class61_1.Checked,
				bool_4 = class61_2.Checked,
				bool_5 = class61_5.Checked,
				bool_6 = class61_6.Checked
			};
		}
		set
		{
			class61_3.Checked = value.bool_0;
			class61_4.Checked = value.bool_1;
			class61_0.Checked = value.bool_2;
			class61_1.Checked = value.bool_3;
			class61_2.Checked = value.bool_4;
			class61_5.Checked = value.bool_5;
			class61_6.Checked = value.bool_6;
		}
	}

	public AdvancedSmtpSettingsDialog(Class131 class131_0)
		: base(new Size(640, 480))
	{
		InitializeComponent();
		vmethod_1();
		method_11();
		WireUpEvents();
		Class131_0 = class131_0;
	}

	private void method_11()
	{
	}

	private void WireUpEvents()
	{
		gclass3_0.Click += gclass3_0_Click;
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
            this.class61_1 = new Class61();
            this.class61_2 = new Class61();
            this.class61_3 = new Class61();
            this.class61_4 = new Class61();
            this.class61_5 = new Class61();
            this.class61_6 = new Class61();
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
            this.class66_0.Location = new System.Drawing.Point(403, 392);
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
            this.class66_1.Location = new System.Drawing.Point(511, 392);
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
            this.gcontrol0_0.Size = new System.Drawing.Size(596, 2);
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
            this.class62_0.Size = new System.Drawing.Size(109, 16);
            this.class62_0.TabIndex = 49;
            this.class62_0"SMTP Settings";
            // 
            // pictureBox_0
            // 
            this.pictureBox_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pictureBox_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pictureBox_0.Image = global::Properties.Resources.smtp_48;
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
            this.class62_1.Size = new System.Drawing.Size(221, 16);
            this.class62_1.TabIndex = 48;
            this.class62_1"Advanced SMTP protection settings";
            // 
            // gclass3_0
            // 
            this.gclass3_0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gclass3_0.AutoSize = true;
            this.gclass3_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gclass3_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gclass3_0.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.gclass3_0.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(135)))), ((int)(((byte)(200)))));
            this.gclass3_0.Location = new System.Drawing.Point(539, 9);
            this.gclass3_0.Name = "gclass3_0";
            this.gclass3_0.Size = new System.Drawing.Size(72, 16);
            this.gclass3_0.TabIndex = 9;
            this.gclass3_0.TabStop = true;
            this.gclass3_0.Text = "справка онлайн";
            this.gclass3_0.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(135)))), ((int)(((byte)(200)))));
            // 
            // class61_0
            // 
            this.class61_0.AutoSize = true;
            this.class61_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class61_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class61_0.Location = new System.Drawing.Point(16, 182);
            this.class61_0.Name = "class61_0";
            this.class61_0.Size = new System.Drawing.Size(257, 20);
            this.class61_0.TabIndex = 51;
            this.class61_0"Block  username enumeration attempts";
            this.class61_0.UseVisualStyleBackColor = false;
            // 
            // class61_1
            // 
            this.class61_1.AutoSize = true;
            this.class61_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class61_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class61_1.Location = new System.Drawing.Point(16, 222);
            this.class61_1.Name = "class61_1";
            this.class61_1.Size = new System.Drawing.Size(147, 20);
            this.class61_1.TabIndex = 52;
            this.class61_1"Block relay attempts";
            this.class61_1.UseVisualStyleBackColor = false;
            // 
            // class61_2
            // 
            this.class61_2.AutoSize = true;
            this.class61_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class61_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class61_2.Location = new System.Drawing.Point(16, 262);
            this.class61_2.Name = "class61_2";
            this.class61_2.Size = new System.Drawing.Size(143, 20);
            this.class61_2.TabIndex = 53;
            this.class61_2"Block spam attacks";
            this.class61_2.UseVisualStyleBackColor = false;
            // 
            // class61_3
            // 
            this.class61_3.AutoSize = true;
            this.class61_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class61_3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class61_3.Location = new System.Drawing.Point(16, 102);
            this.class61_3.Name = "class61_3";
            this.class61_3.Size = new System.Drawing.Size(203, 20);
            this.class61_3.TabIndex = 54;
            this.class61_3"Block failed web admin logins";
            this.class61_3.UseVisualStyleBackColor = false;
            // 
            // class61_4
            // 
            this.class61_4.AutoSize = true;
            this.class61_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class61_4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class61_4.Location = new System.Drawing.Point(16, 142);
            this.class61_4.Name = "class61_4";
            this.class61_4.Size = new System.Drawing.Size(191, 20);
            this.class61_4.TabIndex = 55;
            this.class61_4"Block failed web mail logins";
            this.class61_4.UseVisualStyleBackColor = false;
            // 
            // class61_5
            // 
            this.class61_5.AutoSize = true;
            this.class61_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class61_5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class61_5.Location = new System.Drawing.Point(16, 302);
            this.class61_5.Name = "class61_5";
            this.class61_5.Size = new System.Drawing.Size(243, 20);
            this.class61_5.TabIndex = 56;
            this.class61_5"Block DNS blacklisted IP addresses";
            this.class61_5.UseVisualStyleBackColor = false;
            // 
            // class61_6
            // 
            this.class61_6.AutoSize = true;
            this.class61_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class61_6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class61_6.Location = new System.Drawing.Point(16, 342);
            this.class61_6.Name = "class61_6";
            this.class61_6.Size = new System.Drawing.Size(267, 20);
            this.class61_6.TabIndex = 57;
            this.class61_6"Block IP addresses with no reverse DNS";
            this.class61_6.UseVisualStyleBackColor = false;
            // 
            // AdvancedSmtpSettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.class61_6);
            this.Controls.Add(this.class61_5);
            this.Controls.Add(this.class61_4);
            this.Controls.Add(this.class61_3);
            this.Controls.Add(this.class61_2);
            this.Controls.Add(this.class61_1);
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
            this.Name = "AdvancedSmtpSettingsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this"Advanced SMTP Settings";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

	}

	private void gclass3_0_Click(object sender, EventArgs e)
	{
		method_9(Class148.Class151.String_7);
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
