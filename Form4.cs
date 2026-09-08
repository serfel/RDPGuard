using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Properties;

internal sealed class HttpSettingsDialog : Form0
{
	private readonly AdvancedHttpSettingsDialog form2_0 = new AdvancedHttpSettingsDialog(Class148.Class151.String_4);

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

	private TextBox textBox_0;

	private Class63 class63_1;

	private Class62 class62_2;

	private DirectoriesTable control15_0;

	private Class61 class61_1;

	private Class63 class63_2;

	private Class63 class63_3;

	private GClass3 gclass3_1;

	public Class115 Class115_0
	{
		get
		{
			return new Class115
			{
				bool_0 = class61_0.Checked,
				String_1 = control15_0.String_0,
				bool_3 = class61_1.Checked,
				string_11 = textBox_0.Text,
				bool_4 = form2_0.Boolean_0,
				bool_5 = form2_0.Boolean_1
			};
		}
		set
		{
			class61_0.Checked = value.bool_0;
			control15_0.String_0 = value.String_1;
			class61_1.Checked = value.bool_3;
			textBox_0.Text = value.String_2;
			form2_0.Boolean_0 = value.bool_4;
			form2_0.Boolean_1 = value.bool_5;
			method_14();
		}
	}

	public HttpSettingsDialog(Class115 class115_0)
		: base(new Size(505, 675))
	{
		method_15();
		vmethod_1();
		method_11();
		method_12();
		Class115_0 = class115_0;
	}

	private void method_11()
	{
	}

	private void method_12()
	{
		gclass3_0.Click += gclass3_0_Click;
		class61_0.CheckedChanged += class61_0_CheckedChanged;
		DirectoriesTable control = control15_0;
		control.eventHandler_0 = (EventHandler)Delegate.Combine(control.eventHandler_0, new EventHandler(method_16));
		class61_1.CheckedChanged += class61_1_CheckedChanged;
		textBox_0.TextChanged += textBox_0_TextChanged;
		class66_0.Click += class66_0_Click;
		class66_1.Click += class66_1_Click;
		gclass3_1.Click += gclass3_1_Click;
	}

	private void method_13()
	{
		bool flag = !class61_0.Checked || control15_0.String_0.Any();
		if (class61_0.Checked && class61_1.Checked)
		{
			flag &= !string.IsNullOrEmpty(textBox_0.Text);
		}
		class66_0.Enabled = flag;
	}

	private void method_14()
	{
		bool flag = class61_0.Checked;
		class62_2.Enabled = flag;
		control15_0.Enabled = flag;
		class63_3.Enabled = flag;
		class61_1.Enabled = flag;
		class63_2.Enabled = flag;
		bool flag2 = class61_1.Checked;
		textBox_0.Enabled = flag && flag2;
		class63_1.Enabled = flag && flag2;
		gclass3_1.Enabled = flag;
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
		class63_0 = new Class63();
		textBox_0 = new TextBox();
		class63_1 = new Class63();
		class62_2 = new Class62();
		control15_0 = new DirectoriesTable();
		class61_1 = new Class61();
		class63_2 = new Class63();
		class63_3 = new Class63();
		gclass3_1 = new GClass3();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		class66_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_0.Image = Resources.opts_16;
		class66_0.Location = new Point(268, 587);
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
		class66_1.Location = new Point(376, 587);
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
		gcontrol0_0.Name = "m_spLine";
		gcontrol0_0.Size = new Size(461, 2);
		gcontrol0_0.TabIndex = 50;
		gcontrol0_0.TabStop = false;
		class62_0.AutoSize = true;
		class62_0.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		class62_0.Location = new Point(79, 15);
		class62_0.Margin = new Padding(4, 0, 4, 0);
		class62_0.Name = "m_lblCaption";
		class62_0.Size = new Size(122, 16);
		class62_0.TabIndex = 49;
		class62_0.Text = "HTTP Protection";
		pictureBox_0.Image = Resources.http_48;
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
		class62_1.Size = new Size(155, 16);
		class62_1.TabIndex = 48;
		class62_1.Text = "HTTP protection settings";
		gclass3_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		gclass3_0.AutoSize = true;
		gclass3_0.LinkBehavior = LinkBehavior.NeverUnderline;
		gclass3_0.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_0.Location = new Point(404, 9);
		gclass3_0.Name = "m_lnkOnlineHelp";
		gclass3_0.Size = new Size(72, 16);
		gclass3_0.TabIndex = 9;
		gclass3_0.TabStop = true;
		gclass3_0.Text = "online help";
		gclass3_0.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		class61_0.AutoSize = true;
		class61_0.Location = new Point(16, 97);
		class61_0.Name = "m_chbEnableProtection";
		class61_0.Size = new Size(171, 20);
		class61_0.TabIndex = 0;
		class61_0.Text = "Enable HTTP protection";
		class61_0.UseVisualStyleBackColor = true;
		class63_0.AutoSize = true;
		class63_0.ForeColor = SystemColors.ControlDarkDark;
		class63_0.Location = new Point(13, 122);
		class63_0.Name = "m_lblEnableProtectionHint";
		class63_0.Size = new Size(213, 16);
		class63_0.TabIndex = 58;
		class63_0.Text = "Turn on to enable HTTP protection";
		textBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		textBox_0.Enabled = false;
		textBox_0.Location = new Point(16, 387);
		textBox_0.Multiline = true;
		textBox_0.Name = "m_edRules";
		textBox_0.ScrollBars = ScrollBars.Both;
		textBox_0.Size = new Size(460, 159);
		textBox_0.TabIndex = 2;
		textBox_0.WordWrap = false;
		class63_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		class63_1.AutoSize = true;
		class63_1.Enabled = false;
		class63_1.ForeColor = SystemColors.ControlDarkDark;
		class63_1.Location = new Point(20, 550);
		class63_1.Name = "m_lblCustomRulesHint";
		class63_1.Size = new Size(0, 16);
		class63_1.TabIndex = 62;
		class62_2.AutoSize = true;
		class62_2.Enabled = false;
		class62_2.Location = new Point(13, 153);
		class62_2.Name = "m_lblLogDirectories";
		class62_2.Size = new Size(113, 16);
		class62_2.TabIndex = 63;
		class62_2.Text = "IIS log directories:";
		control15_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		control15_0.String_0 = new string[0];
		control15_0.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		control15_0.Location = new Point(16, 175);
		control15_0.Margin = new Padding(4);
		control15_0.Name = "m_lstLogDirectories";
		control15_0.Size = new Size(460, 147);
		control15_0.TabIndex = 64;
		class61_1.AutoSize = true;
		class61_1.Location = new Point(16, 361);
		class61_1.Name = "m_chbOverrideStandardRules";
		class61_1.Size = new Size(224, 20);
		class61_1.TabIndex = 65;
		class61_1.Text = "Override standard detection rules";
		class61_1.UseVisualStyleBackColor = true;
		class63_2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		class63_2.AutoSize = true;
		class63_2.ForeColor = SystemColors.ControlDarkDark;
		class63_2.Location = new Point(13, 554);
		class63_2.Name = "m_chbOverrideStandardRulesHint";
		class63_2.Size = new Size(472, 16);
		class63_2.TabIndex = 67;
		class63_2.Text = "Please check online help for rules syntax. Please do not edit if you are not sure.";
		class63_3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		class63_3.AutoSize = true;
		class63_3.ForeColor = SystemColors.ControlDarkDark;
		class63_3.Location = new Point(12, 328);
		class63_3.Name = "m_lblLogDirectoriesHint";
		class63_3.Size = new Size(352, 16);
		class63_3.TabIndex = 68;
		class63_3.Text = "Select IIS log directories to monitor for dangerous patterns.";
		gclass3_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		gclass3_1.AutoSize = true;
		gclass3_1.LinkBehavior = LinkBehavior.NeverUnderline;
		gclass3_1.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_1.Location = new Point(12, 607);
		gclass3_1.Name = "m_lnkAdvancedSettings";
		gclass3_1.Size = new Size(123, 16);
		gclass3_1.TabIndex = 69;
		gclass3_1.TabStop = true;
		gclass3_1.Text = "advanced settings..";
		gclass3_1.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(489, 636);
		base.Controls.Add(gclass3_1);
		base.Controls.Add(class63_3);
		base.Controls.Add(class63_2);
		base.Controls.Add(class61_1);
		base.Controls.Add(control15_0);
		base.Controls.Add(class62_2);
		base.Controls.Add(class63_1);
		base.Controls.Add(textBox_0);
		base.Controls.Add(class63_0);
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
		base.Name = "HttpSettingsDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "HTTP Protection Settings";
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void gclass3_0_Click(object sender, EventArgs e)
	{
		method_9(Class148.Class151.String_3);
	}

	private void class61_0_CheckedChanged(object sender, EventArgs e)
	{
		method_14();
	}

	private void method_16(object sender, EventArgs e)
	{
		method_13();
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

	private void gclass3_1_Click(object sender, EventArgs e)
	{
		form2_0.ShowDialog();
	}
}
