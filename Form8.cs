using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class WebFormsSettingsDialog : Form0
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

	private Class63 class63_0;

	private Class63 class63_1;

	private TextBox textBox_0;

	private Class62 class62_2;

	private Class63 class63_2;

	public Class126 Class126_0
	{
		get
		{
			return new Class126
			{
				bool_0 = class61_0.Checked,
				bool_3 = class61_1.Checked,
				string_11 = textBox_0.Text
			};
		}
		set
		{
			class61_0.Checked = value.bool_0;
			class61_1.Checked = value.bool_3;
			textBox_0.Text = value.String_2;
			method_14();
		}
	}

	public WebFormsSettingsDialog(Class126 class126_0)
		: base(new Size(500, 560))
	{
		method_15();
		vmethod_1();
		method_11();
		method_12();
		Class126_0 = class126_0;
	}

	private void method_11()
	{
	}

	private void method_12()
	{
		gclass3_0.Click += gclass3_0_Click;
		class61_0.CheckedChanged += class61_0_CheckedChanged;
		class61_1.CheckedChanged += class61_1_CheckedChanged;
		textBox_0.TextChanged += textBox_0_TextChanged;
		class66_0.Click += class66_0_Click;
		class66_1.Click += class66_1_Click;
	}

	private void method_13()
	{
		bool flag = true;
		if (class61_0.Checked && class61_1.Checked)
		{
			flag &= !string.IsNullOrEmpty(textBox_0.Text);
		}
		class66_0.Enabled = flag;
	}

	private void method_14()
	{
		bool flag = class61_0.Checked;
		class61_1.Enabled = flag;
		class63_1.Enabled = flag;
		bool flag2 = class61_1.Checked;
		class62_2.Enabled = flag && flag2;
		textBox_0.Enabled = flag && flag2;
		class63_2.Enabled = flag && flag2;
		method_13();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_15()
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
		class63_0 = new Class63();
		class63_1 = new Class63();
		textBox_0 = new TextBox();
		class62_2 = new Class62();
		class63_2 = new Class63();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		class66_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_0.Image = Resources.opts_16;
		class66_0.Location = new Point(263, 472);
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
		class66_1.Location = new Point(371, 472);
		class66_1.Margin = new Padding(4);
		class66_1.Name = "btnCancel";
		class66_1.Size = new Size(100, 36);
		class66_1.TabIndex = 8;
		class66_1.Text = "Cancel";
		class66_1.TextAlign = ContentAlignment.MiddleRight;
		class66_1.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_1.UseVisualStyleBackColor = true;
		gcontrol0_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		gcontrol0_0.Location = new Point(16, 81);
		gcontrol0_0.Name = "separatorLine1";
		gcontrol0_0.Size = new Size(456, 2);
		gcontrol0_0.TabIndex = 50;
		gcontrol0_0.TabStop = false;
		class62_0.AutoSize = true;
		class62_0.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		class62_0.Location = new Point(79, 15);
		class62_0.Margin = new Padding(4, 0, 4, 0);
		class62_0.Name = "m_lblCaption";
		class62_0.Size = new Size(230, 16);
		class62_0.TabIndex = 49;
		class62_0.Text = "ASP.NET Web Forms Protection";
		pictureBox_0.Image = Resources.aspdotnet_48;
		pictureBox_0.Location = new Point(16, 15);
		pictureBox_0.Margin = new Padding(4);
		pictureBox_0.Name = "m_imgIcon";
		pictureBox_0.Size = new Size(48, 48);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 47;
		pictureBox_0.TabStop = false;
		class62_1.AutoSize = true;
		class62_1.Location = new Point(79, 47);
		class62_1.Margin = new Padding(4, 0, 4, 0);
		class62_1.Name = "m_lblSubCaption";
		class62_1.Size = new Size(241, 16);
		class62_1.TabIndex = 48;
		class62_1.Text = "ASP.NET web forms protection settings";
		gclass3_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		gclass3_0.AutoSize = true;
		gclass3_0.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_0.Location = new Point(399, 9);
		gclass3_0.Name = "m_lnkOnlineHelp";
		gclass3_0.Size = new Size(73, 16);
		gclass3_0.TabIndex = 9;
		gclass3_0.TabStop = true;
		gclass3_0.Text = "online help";
		gclass3_0.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		class61_0.AutoSize = true;
		class61_0.Location = new Point(16, 97);
		class61_0.Name = "m_chbEnableProtection";
		class61_0.Size = new Size(257, 20);
		class61_0.TabIndex = 0;
		class61_0.Text = "Enable ASP.NET web forms protection";
		class61_0.UseVisualStyleBackColor = true;
		class61_1.AutoSize = true;
		class61_1.Location = new Point(16, 157);
		class61_1.Name = "m_chbUseCustomRules";
		class61_1.Size = new Size(225, 20);
		class61_1.TabIndex = 1;
		class61_1.Text = "Override standard detection rules";
		class61_1.UseVisualStyleBackColor = true;
		class63_0.AutoSize = true;
		class63_0.ForeColor = SystemColors.ControlDarkDark;
		class63_0.Location = new Point(13, 122);
		class63_0.Name = "m_lblEnableProtectionHint";
		class63_0.Size = new Size(299, 16);
		class63_0.TabIndex = 58;
		class63_0.Text = "Turn on to enable ASP.NET web forms protection";
		class63_1.AutoSize = true;
		class63_1.ForeColor = SystemColors.ControlDarkDark;
		class63_1.Location = new Point(13, 182);
		class63_1.Name = "m_lblUseCustomRulesHint";
		class63_1.Size = new Size(425, 16);
		class63_1.TabIndex = 59;
		class63_1.Text = "Do not enable this feature if you are not sure. Please check online help.";
		textBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		textBox_0.Enabled = false;
		textBox_0.Location = new Point(23, 243);
		textBox_0.Multiline = true;
		textBox_0.Name = "m_edCustomRules";
		textBox_0.ScrollBars = ScrollBars.Both;
		textBox_0.Size = new Size(448, 185);
		textBox_0.TabIndex = 2;
		textBox_0.WordWrap = false;
		class62_2.AutoSize = true;
		class62_2.Enabled = false;
		class62_2.Location = new Point(13, 217);
		class62_2.Name = "m_lblLogFilesLocation";
		class62_2.Size = new Size(146, 16);
		class62_2.TabIndex = 61;
		class62_2.Text = "Custom detection rules:";
		class63_2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		class63_2.AutoSize = true;
		class63_2.Enabled = false;
		class63_2.ForeColor = SystemColors.ControlDarkDark;
		class63_2.Location = new Point(20, 435);
		class63_2.Name = "m_lblCustomRulesHint";
		class63_2.Size = new Size(393, 16);
		class63_2.TabIndex = 62;
		class63_2.Text = "Enter custom detection rules. Please check online help for syntax.";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(484, 521);
		base.Controls.Add(class63_2);
		base.Controls.Add(class62_2);
		base.Controls.Add(textBox_0);
		base.Controls.Add(class63_1);
		base.Controls.Add(class63_0);
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
		base.Name = "WebFormsSettingsDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "ASP.NET Web Forms Protection Settings";
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void gclass3_0_Click(object sender, EventArgs e)
	{
		method_9(Class148.Class151.String_14);
	}

	private void class61_0_CheckedChanged(object sender, EventArgs e)
	{
		method_14();
	}

	private void class61_1_CheckedChanged(object sender, EventArgs e)
	{
		method_14();
		method_13();
	}

	private void textBox_0_TextChanged(object sender, EventArgs e)
	{
		method_13();
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
