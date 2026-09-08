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
		method_12();
	}

	private void method_11(string string_0)
	{
		textBox_0.Text = string_0;
	}

	private void method_12()
	{
		gclass3_0.LinkClicked += gclass3_0_LinkClicked;
		class66_1.Click += class66_1_Click;
		class66_0.Click += class66_0_Click;
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
		((System.ComponentModel.ISupportInitialize)this.pictureBox_0).BeginInit();
		base.SuspendLayout();
		this.pictureBox_0.Image = Properties.Resources.debug_48;
		this.pictureBox_0.Location = new System.Drawing.Point(16, 16);
		this.pictureBox_0.Margin = new System.Windows.Forms.Padding(4);
		this.pictureBox_0.Name = "pictureBox1";
		this.pictureBox_0.Size = new System.Drawing.Size(48, 48);
		this.pictureBox_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.pictureBox_0.TabIndex = 0;
		this.pictureBox_0.TabStop = false;
		this.class62_0.AutoSize = true;
		this.class62_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.class62_0.Location = new System.Drawing.Point(79, 16);
		this.class62_0.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
		this.class62_0.Name = "m_lblSubCaption1";
		this.class62_0.Size = new System.Drawing.Size(208, 16);
		this.class62_0.TabIndex = 16;
		this.class62_0.Text = "Sorry, something went wrong.";
		this.textBox_0.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.textBox_0.Font = new System.Drawing.Font("Courier New", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.textBox_0.Location = new System.Drawing.Point(16, 103);
		this.textBox_0.Margin = new System.Windows.Forms.Padding(4);
		this.textBox_0.Multiline = true;
		this.textBox_0.Name = "m_txtCrashReport";
		this.textBox_0.ReadOnly = true;
		this.textBox_0.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.textBox_0.Size = new System.Drawing.Size(670, 393);
		this.textBox_0.TabIndex = 17;
		this.textBox_0.WordWrap = false;
		this.class66_0.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.class66_0.Image = Properties.Resources.opts_16;
		this.class66_0.Location = new System.Drawing.Point(478, 513);
		this.class66_0.Margin = new System.Windows.Forms.Padding(4);
		this.class66_0.Name = "m_btnSend";
		this.class66_0.Size = new System.Drawing.Size(100, 36);
		this.class66_0.TabIndex = 18;
		this.class66_0.Text = "Send";
		this.class66_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.class66_0.UseVisualStyleBackColor = true;
		this.class66_1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.class66_1.Image = Properties.Resources.cancl_16;
		this.class66_1.Location = new System.Drawing.Point(586, 513);
		this.class66_1.Margin = new System.Windows.Forms.Padding(4);
		this.class66_1.Name = "m_btnCancel";
		this.class66_1.Size = new System.Drawing.Size(100, 36);
		this.class66_1.TabIndex = 19;
		this.class66_1.Text = "Cancel";
		this.class66_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.class66_1.UseVisualStyleBackColor = true;
		this.class62_1.AutoSize = true;
		this.class62_1.Location = new System.Drawing.Point(79, 48);
		this.class62_1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
		this.class62_1.Name = "m_lblSubCaption2";
		this.class62_1.Size = new System.Drawing.Size(449, 16);
		this.class62_1.TabIndex = 15;
		this.class62_1.Text = "A detailed error report has been created and pasted into the text box below";
		this.class62_2.AutoSize = true;
		this.class62_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		this.class62_2.Location = new System.Drawing.Point(79, 74);
		this.class62_2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
		this.class62_2.Name = "m_lblSubCaption3";
		this.class62_2.Size = new System.Drawing.Size(611, 16);
		this.class62_2.TabIndex = 23;
		this.class62_2.Text = "You can send it to help us improve RdpGuard. We will treat this report as confidential and anonymous.";
		this.class62_3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.class62_3.AutoSize = true;
		this.class62_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		this.class62_3.Location = new System.Drawing.Point(13, 510);
		this.class62_3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
		this.class62_3.Name = "label1";
		this.class62_3.Size = new System.Drawing.Size(197, 16);
		this.class62_3.TabIndex = 24;
		this.class62_3.Text = "This bug might already be fixed.";
		this.class62_4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.class62_4.AutoSize = true;
		this.class62_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		this.class62_4.Location = new System.Drawing.Point(79, 534);
		this.class62_4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
		this.class62_4.Name = "label2";
		this.class62_4.Size = new System.Drawing.Size(319, 16);
		this.class62_4.TabIndex = 25;
		this.class62_4.Text = "to check if a newer version is available for download.";
		this.gclass3_0.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.gclass3_0.AutoSize = true;
		this.gclass3_0.LinkColor = System.Drawing.Color.FromArgb(38, 135, 200);
		this.gclass3_0.Location = new System.Drawing.Point(13, 534);
		this.gclass3_0.Name = "m_lnkVersionCheck";
		this.gclass3_0.Size = new System.Drawing.Size(67, 16);
		this.gclass3_0.TabIndex = 26;
		this.gclass3_0.TabStop = true;
		this.gclass3_0.Text = "Click here";
		this.gclass3_0.VisitedLinkColor = System.Drawing.Color.FromArgb(38, 135, 200);
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(703, 562);
		base.Controls.Add(this.gclass3_0);
		base.Controls.Add(this.class62_4);
		base.Controls.Add(this.class62_3);
		base.Controls.Add(this.class62_2);
		base.Controls.Add(this.class66_0);
		base.Controls.Add(this.class66_1);
		base.Controls.Add(this.textBox_0);
		base.Controls.Add(this.class62_0);
		base.Controls.Add(this.class62_1);
		base.Controls.Add(this.pictureBox_0);
		this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		base.Margin = new System.Windows.Forms.Padding(4);
		this.MinimumSize = new System.Drawing.Size(710, 400);
		base.Name = "formCrashReport";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Program Crashed";
		((System.ComponentModel.ISupportInitialize)this.pictureBox_0).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
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
