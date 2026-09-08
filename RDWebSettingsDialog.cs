using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Properties;

internal sealed class RDWebSettingsDialog : Form0
{
	private AdvancedHttpSettingsDialog form2_0 = new AdvancedHttpSettingsDialog(Class148.Class151.String_13);

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

	private Class54 class54_0;

	private Class62 class62_2;

	private Class63 class63_2;

	private GClass3 gclass3_1;

	public Class123 Class123_0
	{
		get
		{
			Class123 @class = new Class123();
			@class.bool_0 = class61_0.Checked;
			@class.bool_2 = class61_1.Checked;
			@class.String_1 = new string[1] { class54_0.Text };
			@class.bool_3 = form2_0.Boolean_0;
			@class.bool_4 = form2_0.Boolean_1;
			return @class;
		}
		set
		{
			class61_0.Checked = value.bool_0;
			class61_1.Checked = value.bool_2;
			class54_0.Text = value.String_1[0];
			form2_0.Boolean_0 = value.bool_3;
			form2_0.Boolean_1 = value.bool_4;
			method_14();
		}
	}

	public RDWebSettingsDialog(Class123 class123_0)
		: base(new Size(550, 390))
	{
		InitializeComponent();
		vmethod_1();
		method_11();
		WireUpEvents();
		Class123_0 = class123_0;
	}

	private void method_11()
	{
		class54_0.bool_0 = true;
		class54_0.String_0 = "Click to specify IIS log files location for RDWeb enabled website";
		if (string.IsNullOrEmpty(class54_0.Text))
		{
			string text = "C:\\inetpub\\logs\\LogFiles";
			if (Directory.Exists(text))
			{
				class54_0.String_1 = text;
			}
		}
		else
		{
			class54_0.String_1 = class54_0.Text;
		}
	}

	private void WireUpEvents()
	{
		gclass3_0.Click += gclass3_0_Click;
		class61_0.CheckedChanged += class61_0_CheckedChanged;
		class61_1.CheckedChanged += class61_1_CheckedChanged;
		class54_0.TextChanged += class54_0_TextChanged;
		class66_0.Click += class66_0_Click;
		class66_1.Click += class66_1_Click;
		gclass3_1.Click += gclass3_1_Click;
	}

	private void method_13()
	{
		bool flag = true;
		if (class61_0.Checked && !class61_1.Checked)
		{
			flag &= !string.IsNullOrEmpty(class54_0.Text);
		}
		class66_0.Enabled = flag;
	}

	private void method_14()
	{
		bool flag = class61_0.Checked;
		class61_1.Enabled = flag;
		class63_1.Enabled = flag;
		bool flag2 = class61_1.Checked;
		class62_2.Enabled = flag && !flag2;
		class54_0.Enabled = flag && !flag2;
		class63_2.Enabled = flag && !flag2;
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

	private void InitializeComponent()
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
		class54_0 = new Class54();
		class62_2 = new Class62();
		class63_2 = new Class63();
		gclass3_1 = new GClass3();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		class66_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_0.Image = Resources.opts_16;
		class66_0.Location = new Point(313, 302);
		class66_0.Margin = new Padding(4);
		class66_0.Name = "m_btnSave";
		class66_0.Size = new Size(100, 36);
		class66_0.TabIndex = 7;
		class66_0.Text = "Сохранить";
		class66_0.TextAlign = ContentAlignment.MiddleRight;
		class66_0.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_0.UseVisualStyleBackColor = true;
		class66_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_1.Image = Resources.cancl_16;
		class66_1.Location = new Point(421, 302);
		class66_1.Margin = new Padding(4);
		class66_1.Name = "m_btnCancel";
		class66_1.Size = new Size(100, 36);
		class66_1.TabIndex = 8;
		class66_1.Text = "Отмена";
		class66_1.TextAlign = ContentAlignment.MiddleRight;
		class66_1.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_1.UseVisualStyleBackColor = true;
		gcontrol0_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		gcontrol0_0.Location = new Point(16, 81);
		gcontrol0_0.Name = "separatorLine1";
		gcontrol0_0.Size = new Size(506, 2);
		gcontrol0_0.TabIndex = 50;
		gcontrol0_0.TabStop = false;
		class62_0.AutoSize = true;
		class62_0.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		class62_0.Location = new Point(79, 15);
		class62_0.Margin = new Padding(4, 0, 4, 0);
		class62_0.Name = "m_lblCaption";
		class62_0.Size = new Size(121, 16);
		class62_0.TabIndex = 49;
		class62_0"RD Web Settings";
		pictureBox_0.Image = Resources.rdweb_48;
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
		class62_1.Size = new Size(230, 16);
		class62_1.TabIndex = 48;
		class62_1"Advanced RD Web protection settings";
		gclass3_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		gclass3_0.AutoSize = true;
		gclass3_0.LinkBehavior = LinkBehavior.NeverUnderline;
		gclass3_0.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_0.Location = new Point(449, 9);
		gclass3_0.Name = "m_lnkOnlineHelp";
		gclass3_0.Size = new Size(72, 16);
		gclass3_0.TabIndex = 9;
		gclass3_0.TabStop = true;
		gclass3_0.Text = "справка онлайн";
		gclass3_0.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		class61_0.AutoSize = true;
		class61_0.Location = new Point(16, 97);
		class61_0.Name = "m_chbEnableRDWebEngine";
		class61_0.Size = new Size(183, 20);
		class61_0.TabIndex = 0;
		class61_0"Enable RD Web protection";
		class61_0.UseVisualStyleBackColor = true;
		class61_1.AutoSize = true;
		class61_1.Location = new Point(16, 157);
		class61_1.Name = "m_chbAutodetectLogsLocation";
		class61_1.Size = new Size(245, 20);
		class61_1.TabIndex = 1;
		class61_1"Automatically detect log files location";
		class61_1.UseVisualStyleBackColor = true;
		class63_0.AutoSize = true;
		class63_0.ForeColor = SystemColors.ControlDarkDark;
		class63_0.Location = new Point(13, 122);
		class63_0.Name = "m_lblEnableRDWebProtectionHint";
		class63_0.Size = new Size(225, 16);
		class63_0.TabIndex = 58;
		class63_0"Turn on to enable RD Web protection";
		class63_1.AutoSize = true;
		class63_1.ForeColor = SystemColors.ControlDarkDark;
		class63_1.Location = new Point(13, 182);
		class63_1.Name = "m_lblAutomaticConfigLocationHint";
		class63_1.Size = new Size(481, 16);
		class63_1.TabIndex = 59;
		class63_1"RdpGuard will attempt to detect IIS log files location for RD Web enabled website";
		class54_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		class54_0.Enabled = false;
		class54_0.String_1 = null;
		class54_0.Location = new Point(23, 243);
		class54_0.Name = "m_edLogFilesDirectory";
		class54_0.Size = new Size(498, 22);
		class54_0.TabIndex = 2;
		class62_2.AutoSize = true;
		class62_2.Enabled = false;
		class62_2.Location = new Point(13, 217);
		class62_2.Name = "m_lblLogFilesLocation";
		class62_2.Size = new Size(124, 16);
		class62_2.TabIndex = 61;
		class62_2"IIS log files location:";
		class63_2.AutoSize = true;
		class63_2.Enabled = false;
		class63_2.ForeColor = SystemColors.ControlDarkDark;
		class63_2.Location = new Point(20, 268);
		class63_2.Name = "m_lblLogFilesLocationHint";
		class63_2.Size = new Size(341, 16);
		class63_2.TabIndex = 62;
		class63_2"Specify IIS log files location for RD Web enabled website";
		gclass3_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		gclass3_1.AutoSize = true;
		gclass3_1.LinkBehavior = LinkBehavior.NeverUnderline;
		gclass3_1.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_1.Location = new Point(13, 322);
		gclass3_1.Name = "m_lnkAdvancedSettings";
		gclass3_1.Size = new Size(123, 16);
		gclass3_1.TabIndex = 70;
		gclass3_1.TabStop = true;
		gclass3_1"advanced settings..";
		gclass3_1.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(534, 351);
		base.Controls.Add(gclass3_1);
		base.Controls.Add(class63_2);
		base.Controls.Add(class62_2);
		base.Controls.Add(class54_0);
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
		base.Name = "RDWebSettingsDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "RD Web Protection Settings";
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void gclass3_0_Click(object sender, EventArgs e)
	{
		method_9(Class148.Class151.String_12);
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

	private void class54_0_TextChanged(object sender, EventArgs e)
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
