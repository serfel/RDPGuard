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
		method_13();
		vmethod_1();
		method_11(string_0);
		method_12();
	}

	private void method_11(string string_0)
	{
		class62_0.Text = string_0;
		class62_1.Text = "Copyright © 2012-2026 Netsdk Software. All rights reserved.";
	}

	private void method_12()
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

	private void method_13()
	{
		pictureBox_0 = new PictureBox();
		class62_0 = new Class62();
		class66_0 = new Class66();
		class62_1 = new Class62();
		gclass3_0 = new GClass3();
		gclass3_1 = new GClass3();
		gclass3_2 = new GClass3();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		pictureBox_0.Image = Resources.rdpguard_logo_128;
		pictureBox_0.Location = new Point(16, 15);
		pictureBox_0.Margin = new Padding(4);
		pictureBox_0.Name = "pictureBox1";
		pictureBox_0.Size = new Size(128, 128);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 0;
		pictureBox_0.TabStop = false;
		class62_0.AutoSize = true;
		class62_0.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		class62_0.Location = new Point(176, 15);
		class62_0.Margin = new Padding(4, 0, 4, 0);
		class62_0.Name = "lblCaption";
		class62_0.Size = new Size(61, 16);
		class62_0.TabIndex = 1;
		class62_0.Text = "Caption";
		class66_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_0.Image = Resources.opts_16;
		class66_0.Location = new Point(471, 143);
		class66_0.Margin = new Padding(4);
		class66_0.Name = "btnOK";
		class66_0.Size = new Size(100, 36);
		class66_0.TabIndex = 3;
		class66_0.Text = "OK";
		class66_0.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_0.UseVisualStyleBackColor = true;
		class62_1.AutoSize = true;
		class62_1.Location = new Point(176, 47);
		class62_1.Margin = new Padding(4, 0, 4, 0);
		class62_1.Name = "m_lblSubCaption";
		class62_1.Size = new Size(397, 16);
		class62_1.TabIndex = 4;
		gclass3_0.AutoSize = true;
		gclass3_0.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_0.Location = new Point(176, 92);
		gclass3_0.Name = "lnkHomePage";
		gclass3_0.RightToLeft = RightToLeft.No;
		gclass3_0.Size = new Size(147, 16);
		gclass3_0.TabIndex = 11;
		gclass3_0.TabStop = true;
		gclass3_0.Text = "RdpGuard Home Page";
		gclass3_0.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		gclass3_1.AutoSize = true;
		gclass3_1.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_1.Location = new Point(176, 123);
		gclass3_1.Name = "lnkBuyProVersion";
		gclass3_1.RightToLeft = RightToLeft.No;
		gclass3_1.Size = new Size(105, 16);
		gclass3_1.TabIndex = 12;
		gclass3_1.TabStop = true;
		gclass3_1.Text = "Get License Key";
		gclass3_1.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		gclass3_2.AutoSize = true;
		gclass3_2.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_2.Location = new Point(176, 156);
		gclass3_2.Name = "lnkContactUs";
		gclass3_2.RightToLeft = RightToLeft.No;
		gclass3_2.Size = new Size(70, 16);
		gclass3_2.TabIndex = 13;
		gclass3_2.TabStop = true;
		gclass3_2.Text = "Contact us";
		gclass3_2.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(584, 192);
		base.Controls.Add(gclass3_2);
		base.Controls.Add(gclass3_1);
		base.Controls.Add(gclass3_0);
		base.Controls.Add(class62_1);
		base.Controls.Add(class66_0);
		base.Controls.Add(class62_0);
		base.Controls.Add(pictureBox_0);
		Font = new Font("Microsoft Sans Serif", 9.75f);
		base.Margin = new Padding(4);
		base.Name = "AboutDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "About RdpGuard";
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
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
