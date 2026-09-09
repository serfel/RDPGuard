using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class formCrashReport : Form0
{
	private IContainer icontainer_0;

	private PictureBox pictureBox_0;

	private Class62 class62_0;

	private TextBox textBox_0;

	private Class66 class66_0;

	private Class66 class66_1;

	private Class62 class62_1;

	private Class62 class62_2;

	private Class62 class62_3;

	private Class62 class62_4;

	private GClass3 gclass3_0;

	public formCrashReport(string string_0)
	{
		InitializeComponent();
		vmethod_1();
		method_11(string_0);
        gclass3_0.LinkClicked += gclass3_0_LinkClicked;
        class66_1.Click += class66_1_Click;
        class66_0.Click += class66_0_Click;
    }

	private void method_11(string string_0)
	{
		textBox_0.Text = string_0;
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
            this.textBox_0 = new System.Windows.Forms.TextBox();
            this.class66_0 = new Class66();
            this.class66_1 = new Class66();
            this.class62_1 = new Class62();
            this.class62_2 = new Class62();
            this.class62_3 = new Class62();
            this.class62_4 = new Class62();
            this.gclass3_0 = new GClass3();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_0)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_0
            // 
            this.pictureBox_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pictureBox_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pictureBox_0.Image = global::Properties.Resources.debug_48;
            this.pictureBox_0.Location = new System.Drawing.Point(16, 16);
            this.pictureBox_0.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_0.Name = "pictureBox_0";
            this.pictureBox_0.Size = new System.Drawing.Size(48, 48);
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
            this.class62_0.Location = new System.Drawing.Point(79, 16);
            this.class62_0.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.class62_0.Name = "class62_0";
            this.class62_0.Size = new System.Drawing.Size(207, 16);
            this.class62_0.TabIndex = 16;
            this.class62_0.Text = "Извините, что-то пошло не так.";
            // 
            // textBox_0
            // 
            this.textBox_0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.textBox_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_0.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_0.Location = new System.Drawing.Point(16, 103);
            this.textBox_0.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_0.Multiline = true;
            this.textBox_0.Name = "textBox_0";
            this.textBox_0.ReadOnly = true;
            this.textBox_0.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_0.Size = new System.Drawing.Size(670, 393);
            this.textBox_0.TabIndex = 17;
            this.textBox_0.WordWrap = false;
            // 
            // class66_0
            // 
            this.class66_0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.class66_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class66_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.class66_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class66_0.Image = global::Properties.Resources.opts_16;
            this.class66_0.Location = new System.Drawing.Point(478, 513);
            this.class66_0.Margin = new System.Windows.Forms.Padding(4);
            this.class66_0.Name = "class66_0";
            this.class66_0.Size = new System.Drawing.Size(100, 36);
            this.class66_0.TabIndex = 18;
            this.class66_0.Text = "Отправить";
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
            this.class66_1.Location = new System.Drawing.Point(586, 513);
            this.class66_1.Margin = new System.Windows.Forms.Padding(4);
            this.class66_1.Name = "class66_1";
            this.class66_1.Size = new System.Drawing.Size(100, 36);
            this.class66_1.TabIndex = 19;
            this.class66_1.Text = "Отмена";
            this.class66_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.class66_1.UseVisualStyleBackColor = false;
            // 
            // class62_1
            // 
            this.class62_1.AutoSize = true;
            this.class62_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class62_1.Boolean_0 = false;
            this.class62_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class62_1.Location = new System.Drawing.Point(79, 48);
            this.class62_1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.class62_1.Name = "class62_1";
            this.class62_1.Size = new System.Drawing.Size(448, 16);
            this.class62_1.TabIndex = 15;
            this.class62_1.Text = "Подробный отчёт об ошибке создан и вставлен в текстовое поле ниже";
            // 
            // class62_2
            // 
            this.class62_2.AutoSize = true;
            this.class62_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class62_2.Boolean_0 = false;
            this.class62_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.class62_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class62_2.Location = new System.Drawing.Point(79, 74);
            this.class62_2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.class62_2.Name = "class62_2";
            this.class62_2.Size = new System.Drawing.Size(605, 16);
            this.class62_2.TabIndex = 23;
            this.class62_2"You can send it to help us improve RdpGuard. We will treat this report as confide" +
    "ntial and anonymous.";
            // 
            // class62_3
            // 
            this.class62_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.class62_3.AutoSize = true;
            this.class62_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class62_3.Boolean_0 = false;
            this.class62_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.class62_3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class62_3.Location = new System.Drawing.Point(13, 510);
            this.class62_3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.class62_3.Name = "class62_3";
            this.class62_3.Size = new System.Drawing.Size(196, 16);
            this.class62_3.TabIndex = 24;
            this.class62_3.Text = "Эта ошибка может быть уже исправлена.";
            // 
            // class62_4
            // 
            this.class62_4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.class62_4.AutoSize = true;
            this.class62_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class62_4.Boolean_0 = false;
            this.class62_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.class62_4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class62_4.Location = new System.Drawing.Point(79, 534);
            this.class62_4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.class62_4.Name = "class62_4";
            this.class62_4.Size = new System.Drawing.Size(318, 16);
            this.class62_4.TabIndex = 25;
            this.class62_4.Text = "чтобы проверить, доступна ли новая версия для загрузки.";
            // 
            // gclass3_0
            // 
            this.gclass3_0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gclass3_0.AutoSize = true;
            this.gclass3_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gclass3_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gclass3_0.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.gclass3_0.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(135)))), ((int)(((byte)(200)))));
            this.gclass3_0.Location = new System.Drawing.Point(13, 534);
            this.gclass3_0.Name = "gclass3_0";
            this.gclass3_0.Size = new System.Drawing.Size(66, 16);
            this.gclass3_0.TabIndex = 26;
            this.gclass3_0.TabStop = true;
            this.gclass3_0.Text = "Щёлкните здесь";
            this.gclass3_0.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(135)))), ((int)(((byte)(200)))));
            // 
            // formCrashReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.gclass3_0);
            this.Controls.Add(this.class62_4);
            this.Controls.Add(this.class62_3);
            this.Controls.Add(this.class62_2);
            this.Controls.Add(this.class66_0);
            this.Controls.Add(this.class66_1);
            this.Controls.Add(this.textBox_0);
            this.Controls.Add(this.class62_0);
            this.Controls.Add(this.class62_1);
            this.Controls.Add(this.pictureBox_0);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(710, 400);
            this.Name = "formCrashReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program Crashed";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

	}

	private void gclass3_0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		method_9(Class148.Class149.String_0);
	}

	private void class66_1_Click(object sender, EventArgs e)
	{
		method_8(DialogResult.Cancel);
	}

	private void class66_0_Click(object sender, EventArgs e)
	{
		method_8(DialogResult.OK);
	}
}
