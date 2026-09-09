using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class MsSqlExclusionsDialog : Form0
{
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

	private GClass2 gclass2_0;

	public string[] String_0
	{
		get
		{
			return textBox_0.Lines;
		}
		set
		{
			textBox_0.Lines = value;
		}
	}

	public MsSqlExclusionsDialog()
		: base(new Size(465, 415))
	{
		InitializeComponent();
		vmethod_1();
		ReInitializeComponent();
	}

	private void ReInitializeComponent()
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

	private void InitializeComponent()
	{
		icontainer_0 = new Container();
		new ComponentResourceManager(typeof(MsSqlExclusionsDialog));
		class66_0 = new Class66();
		class66_1 = new Class66();
		pictureBox_0 = new PictureBox();
		class62_0 = new Class62();
		class62_1 = new Class62();
		gcontrol0_0 = new GControl0();
		gclass3_0 = new GClass3();
		textBox_0 = new TextBox();
		class62_2 = new Class62();
		gclass2_0 = new GClass2();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		class66_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_0.Image = Resources.opts_16;
		class66_0.Location = new Point(294, 416);
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
		class66_1.Location = new Point(402, 416);
		class66_1.Margin = new Padding(4);
		class66_1.Name = "btnCancel";
		class66_1.Size = new Size(100, 36);
		class66_1.TabIndex = 8;
		class66_1.Text = "Отмена";
		class66_1.TextAlign = ContentAlignment.MiddleRight;
		class66_1.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_1.UseVisualStyleBackColor = true;
		pictureBox_0.Image = Resources.ms_sql_filter_48;
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
		class62_0.Name = "lblCaption";
		class62_0.Size = new Size(180, 16);
		class62_0.TabIndex = 48;
		class62_0.Text = "Исключения для события с кодом 18456";
		class62_1.AutoSize = true;
		class62_1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		class62_1.Location = new Point(79, 15);
		class62_1.Margin = new Padding(4, 0, 4, 0);
		class62_1.Name = "label2";
		class62_1.Size = new Size(141, 16);
		class62_1.TabIndex = 49;
		class62_1.Text = "Исключения MS-SQL";
		gcontrol0_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		gcontrol0_0.Location = new Point(16, 81);
		gcontrol0_0.Name = "separatorLine1";
		gcontrol0_0.Size = new Size(487, 2);
		gcontrol0_0.TabIndex = 50;
		gcontrol0_0.TabStop = false;
		gclass3_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		gclass3_0.AutoSize = true;
		gclass3_0.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_0.Location = new Point(430, 9);
		gclass3_0.Name = "m_lnkOnlineHelp";
		gclass3_0.Size = new Size(72, 16);
		gclass3_0.TabIndex = 9;
		gclass3_0.TabStop = true;
		gclass3_0.Text = "справка онлайн";
		gclass3_0.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		textBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		textBox_0.Location = new Point(16, 126);
		textBox_0.Multiline = true;
		textBox_0.Name = "m_edExclusions";
		textBox_0.Size = new Size(486, 231);
		textBox_0.TabIndex = 51;
		class62_2.AutoSize = true;
		class62_2.Location = new Point(13, 97);
		class62_2.Margin = new Padding(4, 0, 4, 0);
		class62_2.Name = "label1";
		class62_2.Size = new Size(236, 16);
		class62_2.TabIndex = 52;
		class62_2.Text = "Exclusion patterns for the Reason field:";
		gclass2_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gclass2_0.Location = new Point(16, 363);
		gclass2_0.Name = "m_lblExlucionsHint";
		gclass2_0.Size = new Size(486, 46);
		gclass2_0.TabIndex = 53;
		gclass2_0.Text = "You can specify one exclusion pattern per line. Event ID 18456 is skipped if the Reason field contains any of the exclusion patterns.";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(515, 465);
		base.Controls.Add(gclass2_0);
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
		base.Name = "MsSqlExclusionsDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "MS-SQL Exclusions";
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void gclass3_0_Click(object sender, EventArgs e)
	{
		method_9(Class148.Class151.String_10);
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
