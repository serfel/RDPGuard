using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class ProtocolRulesDialog : Form0
{
	public string string_0 = string.Empty;

	private IContainer icontainer_0;

	private Class66 class66_0;

	private Class66 class66_1;

	private PictureBox pictureBox_0;

	private Class62 class62_0;

	private Class62 class62_1;

	private GControl0 gcontrol0_0;

	private GClass3 gclass3_0;

	private TextBox textBox_0;

	private Class62 class62_2;

	private Class63 class63_0;

	public string String_0
	{
		set
		{
			Text = value;
		}
	}

	public string String_1
	{
		set
		{
			class62_1.Text = value;
		}
	}

	public string String_2
	{
		set
		{
			class62_0.Text = value;
		}
	}

	public string String_3
	{
		set
		{
			class62_2.Text = value;
		}
	}

	public string String_4
	{
		get
		{
			return textBox_0.Text;
		}
		set
		{
			textBox_0.Text = value;
		}
	}

	public string String_5
	{
		set
		{
			class63_0.Text = value;
		}
	}

	public ProtocolRulesDialog()
		: base(new Size(580, 470))
	{
		OnButtonOk();
		vmethod_1();
		InitializeComponents();
	}

	private void InitializeComponents()
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

	private void OnButtonOk()
	{
		icontainer_0 = new Container();
		new ComponentResourceManager(typeof(ProtocolRulesDialog));
		class66_0 = new Class66();
		class66_1 = new Class66();
		pictureBox_0 = new PictureBox();
		class62_0 = new Class62();
		class62_1 = new Class62();
		gcontrol0_0 = new GControl0();
		gclass3_0 = new GClass3();
		textBox_0 = new TextBox();
		class62_2 = new Class62();
		class63_0 = new Class63();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		class66_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_0.Image = Resources.opts_16;
		class66_0.Location = new Point(295, 433);
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
		class66_1.Location = new Point(403, 433);
		class66_1.Margin = new Padding(4);
		class66_1.Name = "btnCancel";
		class66_1.Size = new Size(100, 36);
		class66_1.TabIndex = 8;
		class66_1.Text = "Cancel";
		class66_1.TextAlign = ContentAlignment.MiddleRight;
		class66_1.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_1.UseVisualStyleBackColor = true;
		pictureBox_0.Image = Resources.filter_48;
		pictureBox_0.Location = new Point(16, 15);
		pictureBox_0.Margin = new Padding(4);
		pictureBox_0.Name = "imgBigIcon";
		pictureBox_0.Size = new Size(48, 48);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 47;
		pictureBox_0.TabStop = false;
		class62_0.AutoSize = true;
		class62_0.Location = new Point(79, 47);
		class62_0.Margin = new Padding(4, 0, 4, 0);
		class62_0.Name = "m_lblSubCaption";
		class62_0.Size = new Size(104, 16);
		class62_0.TabIndex = 48;
		class62_0.Text = "{SUBCAPTION}";
		class62_1.AutoSize = true;
		class62_1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		class62_1.Location = new Point(79, 15);
		class62_1.Margin = new Padding(4, 0, 4, 0);
		class62_1.Name = "m_lblCaption";
		class62_1.Size = new Size(85, 16);
		class62_1.TabIndex = 49;
		class62_1.Text = "{CAPTION}";
		gcontrol0_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		gcontrol0_0.Location = new Point(16, 81);
		gcontrol0_0.Name = "separatorLine1";
		gcontrol0_0.Size = new Size(487, 2);
		gcontrol0_0.TabIndex = 50;
		gcontrol0_0.TabStop = false;
		gclass3_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		gclass3_0.AutoSize = true;
		gclass3_0.LinkBehavior = LinkBehavior.NeverUnderline;
		gclass3_0.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_0.Location = new Point(430, 9);
		gclass3_0.Name = "m_lnkOnlineHelp";
		gclass3_0.Size = new Size(72, 16);
		gclass3_0.TabIndex = 9;
		gclass3_0.TabStop = true;
		gclass3_0.Text = "online help";
		gclass3_0.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		textBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		textBox_0.Location = new Point(16, 126);
		textBox_0.Multiline = true;
		textBox_0.Name = "m_edRules";
		textBox_0.ScrollBars = ScrollBars.Both;
		textBox_0.Size = new Size(486, 261);
		textBox_0.TabIndex = 51;
		textBox_0.WordWrap = false;
		class62_2.AutoSize = true;
		class62_2.Location = new Point(13, 97);
		class62_2.Margin = new Padding(4, 0, 4, 0);
		class62_2.Name = "m_lblRules";
		class62_2.Size = new Size(128, 16);
		class62_2.TabIndex = 52;
		class62_2.Text = "{RULES_CAPTION}";
		class63_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		class63_0.AutoSize = true;
		class63_0.ForeColor = SystemColors.ControlDarkDark;
		class63_0.Location = new Point(13, 397);
		class63_0.Name = "m_lblRulesHint";
		class63_0.Size = new Size(101, 16);
		class63_0.TabIndex = 59;
		class63_0.Text = "{RULES_HINT}";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(515, 482);
		base.Controls.Add(class63_0);
		base.Controls.Add(class62_2);
		base.Controls.Add(textBox_0);
		base.Controls.Add(gclass3_0);
		base.Controls.Add(gcontrol0_0);
		base.Controls.Add(class62_1);
		base.Controls.Add(class62_0);
		base.Controls.Add(pictureBox_0);
		base.Controls.Add(class66_0);
		base.Controls.Add(class66_1);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(5, 4, 5, 4);
		base.Name = "ProtocolRulesDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "{WINDOW_TITLE}";
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void gclass3_0_Click(object sender, EventArgs e)
	{
		method_9(string_0);
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
