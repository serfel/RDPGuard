using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class Form6 : Form0
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

	public Form6(Class131 class131_0)
		: base(new Size(640, 480))
	{
		method_13();
		vmethod_1();
		method_11();
		method_12();
		Class131_0 = class131_0;
	}

	private void method_11()
	{
	}

	private void method_12()
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

	private void method_13()
	{
		class66_0 = new Class66();
		class66_1 = new Class66();
		gcontrol0_0 = new GControl0();
		class62_0 = new Class62();
		pictureBox_0 = new PictureBox();
		class62_1 = new Class62();
		gclass3_0 = new GClass3();
		class61_0 = new Class61();
		class61_1 = new Class61();
		class61_2 = new Class61();
		class61_3 = new Class61();
		class61_4 = new Class61();
		class61_5 = new Class61();
		class61_6 = new Class61();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		class66_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_0.Image = Resources.opts_16;
		class66_0.Location = new Point(403, 392);
		class66_0.Margin = new Padding(4);
		class66_0.Name = "m_btnSave";
		class66_0.Size = new Size(100, 36);
		class66_0.TabIndex = 7;
		class66_0.Text = "Save";
		class66_0.TextAlign = ContentAlignment.MiddleRight;
		class66_0.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_0.UseVisualStyleBackColor = true;
		class66_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_1.Image = Resources.cancl_16;
		class66_1.Location = new Point(511, 392);
		class66_1.Margin = new Padding(4);
		class66_1.Name = "m_btnCancel";
		class66_1.Size = new Size(100, 36);
		class66_1.TabIndex = 8;
		class66_1.Text = "Cancel";
		class66_1.TextAlign = ContentAlignment.MiddleRight;
		class66_1.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_1.UseVisualStyleBackColor = true;
		gcontrol0_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		gcontrol0_0.Location = new Point(16, 81);
		gcontrol0_0.Name = "separatorLine1";
		gcontrol0_0.Size = new Size(596, 2);
		gcontrol0_0.TabIndex = 50;
		gcontrol0_0.TabStop = false;
		class62_0.AutoSize = true;
		class62_0.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		class62_0.Location = new Point(79, 15);
		class62_0.Margin = new Padding(4, 0, 4, 0);
		class62_0.Name = "m_lblCaption";
		class62_0.Size = new Size(110, 16);
		class62_0.TabIndex = 49;
		class62_0.Text = "SMTP Settings";
		pictureBox_0.Image = Resources.smtp_48;
		pictureBox_0.Location = new Point(16, 15);
		pictureBox_0.Margin = new Padding(4);
		pictureBox_0.Name = "m_imgBigIcon";
		pictureBox_0.Size = new Size(48, 48);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 47;
		pictureBox_0.TabStop = false;
		class62_1.AutoSize = true;
		class62_1.Location = new Point(79, 47);
		class62_1.Margin = new Padding(4, 0, 4, 0);
		class62_1.Name = "m_lblSubCaption";
		class62_1.Size = new Size(222, 16);
		class62_1.TabIndex = 48;
		class62_1.Text = "Advanced SMTP protection settings";
		gclass3_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		gclass3_0.AutoSize = true;
		gclass3_0.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_0.Location = new Point(539, 9);
		gclass3_0.Name = "m_lnkOnlineHelp";
		gclass3_0.Size = new Size(73, 16);
		gclass3_0.TabIndex = 9;
		gclass3_0.TabStop = true;
		gclass3_0.Text = "online help";
		gclass3_0.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		class61_0.AutoSize = true;
		class61_0.Location = new Point(16, 182);
		class61_0.Name = "m_chbBlockUsernameEnumerationAttempts";
		class61_0.Size = new Size(258, 20);
		class61_0.TabIndex = 51;
		class61_0.Text = "Block  username enumeration attempts";
		class61_0.UseVisualStyleBackColor = true;
		class61_1.AutoSize = true;
		class61_1.Location = new Point(16, 222);
		class61_1.Name = "m_chbBlockRelayAttempts";
		class61_1.Size = new Size(148, 20);
		class61_1.TabIndex = 52;
		class61_1.Text = "Block relay attempts";
		class61_1.UseVisualStyleBackColor = true;
		class61_2.AutoSize = true;
		class61_2.Location = new Point(16, 262);
		class61_2.Name = "m_chbBlockSpamAttacks";
		class61_2.Size = new Size(144, 20);
		class61_2.TabIndex = 53;
		class61_2.Text = "Block spam attacks";
		class61_2.UseVisualStyleBackColor = true;
		class61_3.AutoSize = true;
		class61_3.Location = new Point(16, 102);
		class61_3.Name = "m_chbBlockFailedWebAdminLogins";
		class61_3.Size = new Size(204, 20);
		class61_3.TabIndex = 54;
		class61_3.Text = "Block failed web admin logins";
		class61_3.UseVisualStyleBackColor = true;
		class61_4.AutoSize = true;
		class61_4.Location = new Point(16, 142);
		class61_4.Name = "m_chbBlockFailedWebMailLogins";
		class61_4.Size = new Size(192, 20);
		class61_4.TabIndex = 55;
		class61_4.Text = "Block failed web mail logins";
		class61_4.UseVisualStyleBackColor = true;
		class61_5.AutoSize = true;
		class61_5.Location = new Point(16, 302);
		class61_5.Name = "m_chbBlockDnsBlacklistedAddresses";
		class61_5.Size = new Size(244, 20);
		class61_5.TabIndex = 56;
		class61_5.Text = "Block DNS blacklisted IP addresses";
		class61_5.UseVisualStyleBackColor = true;
		class61_6.AutoSize = true;
		class61_6.Location = new Point(16, 342);
		class61_6.Name = "m_chbBlockNoReverseDnsAddresses";
		class61_6.Size = new Size(268, 20);
		class61_6.TabIndex = 57;
		class61_6.Text = "Block IP addresses with no reverse DNS";
		class61_6.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(624, 441);
		base.Controls.Add(class61_6);
		base.Controls.Add(class61_5);
		base.Controls.Add(class61_4);
		base.Controls.Add(class61_3);
		base.Controls.Add(class61_2);
		base.Controls.Add(class61_1);
		base.Controls.Add(class61_0);
		base.Controls.Add(gclass3_0);
		base.Controls.Add(gcontrol0_0);
		base.Controls.Add(class62_0);
		base.Controls.Add(class62_1);
		base.Controls.Add(pictureBox_0);
		base.Controls.Add(class66_0);
		base.Controls.Add(class66_1);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(5, 4, 5, 4);
		base.Name = "AdvancedSmtpSettingsDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "Advanced SMTP Settings";
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
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
