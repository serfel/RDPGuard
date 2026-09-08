using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class IPFilterDialog : Form0
{
	private Class135 class135_0;

	private IContainer icontainer_0;

	private PictureBox pictureBox_0;

	private Class62 class62_0;

	private Class62 class62_1;

	private Class62 class62_2;

	private TextBox textBox_0;

	private Class66 class66_0;

	private Class66 class66_1;

	private GControl0 gcontrol0_0;

	private GClass3 gclass3_0;

	private Class62 class62_3;

	public Class135 Class135_0
	{
		get
		{
			return class135_0;
		}
		private set
		{
			class135_0 = value;
		}
	}

	public bool Boolean_0 => !string.IsNullOrEmpty(Class135_0?.String_0);

	protected override Button Button_0 => class66_0;

	public void method_11()
	{
		textBox_0.Text = string.Empty;
		Class135_0 = null;
	}

	public IPFilterDialog()
		: base(new Size(520, 265))
	{
		InitializeComponent();
		vmethod_1();
		WireUpEvents();
		ReInitializeComponent();
	}

	private void WireUpEvents()
	{
		textBox_0.Focus();
	}

	private void ReInitializeComponent()
	{
		class66_0.Click += class66_0_Click;
		class66_1.Click += class66_1_Click;
		gclass3_0.Click += gclass3_0_Click;
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
		pictureBox_0 = new PictureBox();
		class62_0 = new Class62();
		class62_1 = new Class62();
		class62_2 = new Class62();
		textBox_0 = new TextBox();
		class66_0 = new Class66();
		class66_1 = new Class66();
		gcontrol0_0 = new GControl0();
		gclass3_0 = new GClass3();
		class62_3 = new Class62();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		pictureBox_0.Image = Resources.filter_48;
		pictureBox_0.Location = new Point(16, 15);
		pictureBox_0.Margin = new Padding(4);
		pictureBox_0.Name = "pictureBox1";
		pictureBox_0.Size = new Size(48, 48);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 0;
		pictureBox_0.TabStop = false;
		class62_0.AutoSize = true;
		class62_0.Location = new Point(79, 47);
		class62_0.Margin = new Padding(4, 0, 4, 0);
		class62_0.Name = "m_lblSubCaption";
		class62_0.Size = new Size(329, 16);
		class62_0.TabIndex = 4;
		class62_0"Filter allows you to display only a certain IP addresses";
		class62_1.AutoSize = true;
		class62_1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		class62_1.Location = new Point(79, 15);
		class62_1.Margin = new Padding(4, 0, 4, 0);
		class62_1.Name = "lblCaption";
		class62_1.Size = new Size(89, 16);
		class62_1.TabIndex = 14;
		class62_1"IP List Filter";
		class62_2.AutoSize = true;
		class62_2.Location = new Point(13, 97);
		class62_2.Name = "m_lblFilter";
		class62_2.Size = new Size(174, 16);
		class62_2.TabIndex = 20;
		class62_2"IP Address, Range or CIDR:";
		textBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		textBox_0.Location = new Point(34, 123);
		textBox_0.Name = "m_edFilter";
		textBox_0.Size = new Size(459, 22);
		textBox_0.TabIndex = 0;
		class66_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_0.Image = Resources.opts_16;
		class66_0.ImageAlign = ContentAlignment.MiddleRight;
		class66_0.Location = new Point(258, 178);
		class66_0.Margin = new Padding(4);
		class66_0.Name = "m_btnSetFilter";
		class66_0.Size = new Size(125, 36);
		class66_0.TabIndex = 1;
		class66_0"Set filter";
		class66_0.TextAlign = ContentAlignment.MiddleLeft;
		class66_0.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_0.UseVisualStyleBackColor = true;
		class66_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_1.DialogResult = DialogResult.Cancel;
		class66_1.Image = Resources.cancl_16;
		class66_1.Location = new Point(391, 178);
		class66_1.Margin = new Padding(4);
		class66_1.Name = "m_btnCancel";
		class66_1.Size = new Size(100, 36);
		class66_1.TabIndex = 2;
		class66_1.Text = "Отмена";
		class66_1.TextAlign = ContentAlignment.MiddleRight;
		class66_1.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_1.UseVisualStyleBackColor = true;
		gcontrol0_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		gcontrol0_0.Location = new Point(16, 81);
		gcontrol0_0.Name = "separatorLine1";
		gcontrol0_0.Size = new Size(477, 2);
		gcontrol0_0.TabIndex = 42;
		gcontrol0_0.TabStop = false;
		gclass3_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		gclass3_0.AutoSize = true;
		gclass3_0.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_0.Location = new Point(418, 9);
		gclass3_0.Name = "m_lnkOnlineHelp";
		gclass3_0.RightToLeft = RightToLeft.No;
		gclass3_0.Size = new Size(73, 16);
		gclass3_0.TabIndex = 43;
		gclass3_0.TabStop = true;
		gclass3_0.Text = "справка онлайн";
		gclass3_0.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		class62_3.AutoSize = true;
		class62_3.ForeColor = SystemColors.ControlDarkDark;
		class62_3.Location = new Point(31, 148);
		class62_3.Name = "label4";
		class62_3.Size = new Size(449, 16);
		class62_3.TabIndex = 44;
		class62_3"Example 1.2.3.4 or 192.168.2.1-192.168.2.255 or 192.168.0.* or 192.168.0.0/24";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(504, 227);
		base.Controls.Add(class62_3);
		base.Controls.Add(gclass3_0);
		base.Controls.Add(gcontrol0_0);
		base.Controls.Add(class66_0);
		base.Controls.Add(class66_1);
		base.Controls.Add(textBox_0);
		base.Controls.Add(class62_2);
		base.Controls.Add(class62_1);
		base.Controls.Add(class62_0);
		base.Controls.Add(pictureBox_0);
		Font = new Font("Microsoft Sans Serif", 9.75f);
		base.Margin = new Padding(4);
		base.Name = "IPFilterDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "IP Filter";
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void class66_0_Click(object sender, EventArgs e)
	{
		Class135_0 = new Class135(textBox_0.Text);
		method_8(DialogResult.OK);
	}

	private void class66_1_Click(object sender, EventArgs e)
	{
		method_8(DialogResult.Cancel);
	}

	private void gclass3_0_Click(object sender, EventArgs e)
	{
		method_9(Class148.String_4);
	}
}
