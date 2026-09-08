using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class AboutDialog : Form0
{
	private IContainer icontainer_0;

	private PictureBox pictureBox1;

	private Class62 lblCaption;

	private Class66 btnOK;

	private Class62 mlblSubCaption;

	private GClass3 lnkHomePage;

	private GClass3 lnkBuyProVersion;

	private GClass3 lnkContactUs;

	public AboutDialog(string string_0)
		: base(new Size(600, 235))
	{
		OnButtonCancel();
		InitializeFormPosition();
		InitializeComponent(string_0);
		OnButtonOk();
	}

	private void InitializeComponent(string string_0)
	{
		lblCaption.Text = string_0;
		mlblSubCaption.Text = "Copyright © 2012-2026 Netsdk Software. All rights reserved.";
	}

	private void OnButtonOk()
	{
		btnOK.Click += btnOK_Click;
		lnkHomePage.LinkClicked += lnkHomePage_LinkClicked;
		lnkBuyProVersion.LinkClicked += lnkBuyProVersion_LinkClicked;
		lnkContactUs.LinkClicked += lnkContactUs_LinkClicked;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void OnButtonCancel()
	{
		pictureBox1 = new PictureBox();
		lblCaption = new Class62();
		btnOK = new Class66();
		mlblSubCaption = new Class62();
		lnkHomePage = new GClass3();
		lnkBuyProVersion = new GClass3();
		lnkContactUs = new GClass3();
		((ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		pictureBox1.Image = Resources.rdpguard_logo_128;
		pictureBox1.Location = new Point(16, 15);
		pictureBox1.Margin = new Padding(4);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(128, 128);
		pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox1.TabIndex = 0;
		pictureBox1.TabStop = false;
		lblCaption.AutoSize = true;
		lblCaption.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		lblCaption.Location = new Point(176, 15);
		lblCaption.Margin = new Padding(4, 0, 4, 0);
		lblCaption.Name = "lblCaption";
		lblCaption.Size = new Size(61, 16);
		lblCaption.TabIndex = 1;
		lblCaption.Text = "Caption";
		btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		btnOK.Image = Resources.opts_16;
		btnOK.Location = new Point(471, 143);
		btnOK.Margin = new Padding(4);
		btnOK.Name = "btnOK";
		btnOK.Size = new Size(100, 36);
		btnOK.TabIndex = 3;
		btnOK.Text = "OK";
		btnOK.TextImageRelation = TextImageRelation.ImageBeforeText;
		btnOK.UseVisualStyleBackColor = true;
		mlblSubCaption.AutoSize = true;
		mlblSubCaption.Location = new Point(176, 47);
		mlblSubCaption.Margin = new Padding(4, 0, 4, 0);
		mlblSubCaption.Name = "m_lblSubCaption";
		mlblSubCaption.Size = new Size(397, 16);
		mlblSubCaption.TabIndex = 4;
		lnkHomePage.AutoSize = true;
		lnkHomePage.LinkColor = Color.FromArgb(38, 135, 200);
		lnkHomePage.Location = new Point(176, 92);
		lnkHomePage.Name = "lnkHomePage";
		lnkHomePage.RightToLeft = RightToLeft.No;
		lnkHomePage.Size = new Size(147, 16);
		lnkHomePage.TabIndex = 11;
		lnkHomePage.TabStop = true;
		lnkHomePage.Text = "RdpGuard Home Page";
		lnkHomePage.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		lnkBuyProVersion.AutoSize = true;
		lnkBuyProVersion.LinkColor = Color.FromArgb(38, 135, 200);
		lnkBuyProVersion.Location = new Point(176, 123);
		lnkBuyProVersion.Name = "lnkBuyProVersion";
		lnkBuyProVersion.RightToLeft = RightToLeft.No;
		lnkBuyProVersion.Size = new Size(105, 16);
		lnkBuyProVersion.TabIndex = 12;
		lnkBuyProVersion.TabStop = true;
		lnkBuyProVersion.Text = "Get License Key";
		lnkBuyProVersion.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		lnkContactUs.AutoSize = true;
		lnkContactUs.LinkColor = Color.FromArgb(38, 135, 200);
		lnkContactUs.Location = new Point(176, 156);
		lnkContactUs.Name = "lnkContactUs";
		lnkContactUs.RightToLeft = RightToLeft.No;
		lnkContactUs.Size = new Size(70, 16);
		lnkContactUs.TabIndex = 13;
		lnkContactUs.TabStop = true;
		lnkContactUs.Text = "Contact us";
		lnkContactUs.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(584, 192);
		base.Controls.Add(lnkContactUs);
		base.Controls.Add(lnkBuyProVersion);
		base.Controls.Add(lnkHomePage);
		base.Controls.Add(mlblSubCaption);
		base.Controls.Add(btnOK);
		base.Controls.Add(lblCaption);
		base.Controls.Add(pictureBox1);
		Font = new Font("Microsoft Sans Serif", 9.75f);
		base.Margin = new Padding(4);
		base.Name = "AboutDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "About RdpGuard";
		((ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void btnOK_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void lnkHomePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		ShowOnlineHelp(Class148.String_2);
	}

	private void lnkBuyProVersion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		ShowOnlineHelp(Class148.Class150.smethod_0("about"));
	}

	private void lnkContactUs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		ShowOnlineHelp(Class148.String_1);
	}
}
