using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Properties;

internal sealed class MsSqlSettingsDialog : Form0
{
	private string[] string_0 = new string[0];

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

	private Class62 class62_2;

	private Class61 class61_1;

	private GClass3 gclass3_1;

	private Class62 class62_3;

	private Class61 class61_2;

	private Class62 class62_4;

	private Class61 class61_3;

	public Class117 Class117_0
	{
		get
		{
			return new Class117
			{
				bool_0 = class61_0.Checked,
				int_1 = Int32_0,
				string_10 = string_0
			};
		}
		set
		{
			class61_0.Checked = value.bool_0;
			Int32_0 = value.int_1;
			string_0 = value.string_10;
		}
	}

	private int[] Int32_0
	{
		get
		{
			List<int> list = new List<int>();
			if (class61_1.Checked)
			{
				list.Add(18456);
			}
			if (class61_2.Checked)
			{
				list.Add(17832);
			}
			if (class61_3.Checked)
			{
				list.Add(17836);
			}
			return list.ToArray();
		}
		set
		{
			class61_1.Checked = value.Contains(18456);
			class61_2.Checked = value.Contains(17832);
			class61_3.Checked = value.Contains(17836);
		}
	}

	public MsSqlSettingsDialog(Class117 class117_0)
		: base(new Size(465, 415))
	{
		InitializeComponent();
		vmethod_1();
		method_11();
		Class117_0 = class117_0;
		class61_0.Focus();
	}

	private void method_11()
	{
		gclass3_0.Click += gclass3_0_Click;
		class61_0.CheckedChanged += class61_0_CheckedChanged;
		class61_1.CheckedChanged += class61_1_CheckedChanged;
		class61_2.CheckedChanged += class61_2_CheckedChanged;
		class61_3.CheckedChanged += class61_3_CheckedChanged;
		gclass3_1.Click += gclass3_1_Click;
		class66_0.Click += class66_0_Click;
		class66_1.Click += class66_1_Click;
	}

	private void ReInitializeComponent()
	{
		class61_1.Enabled = class61_0.Checked;
		class62_2.Enabled = class61_0.Checked;
		gclass3_1.Enabled = class61_0.Checked && class61_1.Checked;
		class61_2.Enabled = class61_0.Checked;
		class62_3.Enabled = class61_0.Checked;
		class61_3.Enabled = class61_0.Checked;
		class62_4.Enabled = class61_0.Checked;
		class66_0.Enabled = !class61_0.Checked || class61_1.Checked || false || (class61_2.Checked ? true : false) || class61_3.Checked;
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
		new ComponentResourceManager(typeof(MsSqlSettingsDialog));
		class66_0 = new Class66();
		class66_1 = new Class66();
		gcontrol0_0 = new GControl0();
		class62_0 = new Class62();
		pictureBox_0 = new PictureBox();
		class62_1 = new Class62();
		gclass3_0 = new GClass3();
		class61_0 = new Class61();
		class63_0 = new Class63();
		class62_2 = new Class62();
		class61_1 = new Class61();
		gclass3_1 = new GClass3();
		class62_3 = new Class62();
		class61_2 = new Class61();
		class62_4 = new Class62();
		class61_3 = new Class61();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		class66_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_0.Image = Resources.opts_16;
		class66_0.Location = new Point(228, 328);
		class66_0.Margin = new Padding(4);
		class66_0.Name = "m_btnSave";
		class66_0.Size = new Size(100, 36);
		class66_0.TabIndex = 5;
		class66_0.Text = "Сохранить";
		class66_0.TextAlign = ContentAlignment.MiddleRight;
		class66_0.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_0.UseVisualStyleBackColor = true;
		class66_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_1.Image = Resources.cancl_16;
		class66_1.Location = new Point(336, 328);
		class66_1.Margin = new Padding(4);
		class66_1.Name = "btnCancel";
		class66_1.Size = new Size(100, 36);
		class66_1.TabIndex = 6;
		class66_1.Text = "Отмена";
		class66_1.TextAlign = ContentAlignment.MiddleRight;
		class66_1.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_1.UseVisualStyleBackColor = true;
		gcontrol0_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		gcontrol0_0.Location = new Point(16, 81);
		gcontrol0_0.Name = "separatorLine1";
		gcontrol0_0.Size = new Size(421, 2);
		gcontrol0_0.TabIndex = 50;
		gcontrol0_0.TabStop = false;
		class62_0.AutoSize = true;
		class62_0.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		class62_0.Location = new Point(79, 15);
		class62_0.Margin = new Padding(4, 0, 4, 0);
		class62_0.Name = "label2";
		class62_0.Size = new Size(124, 16);
		class62_0.TabIndex = 49;
		class62_0.Text = "MS-SQL Settings";
		pictureBox_0.Image = Resources.ms_sql_48;
		pictureBox_0.Location = new Point(16, 15);
		pictureBox_0.Margin = new Padding(4);
		pictureBox_0.Name = "imgBigIcon";
		pictureBox_0.Size = new Size(48, 48);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 47;
		pictureBox_0.TabStop = false;
		class62_1.AutoSize = true;
		class62_1.Location = new Point(79, 47);
		class62_1.Margin = new Padding(4, 0, 4, 0);
		class62_1.Name = "lblCaption";
		class62_1.Size = new Size(234, 16);
		class62_1.TabIndex = 48;
		class62_1.Text = "Advanced MS-SQL protection settings";
		gclass3_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		gclass3_0.AutoSize = true;
		gclass3_0.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_0.Location = new Point(364, 9);
		gclass3_0.Name = "m_lnkOnlineHelp";
		gclass3_0.Size = new Size(73, 16);
		gclass3_0.TabIndex = 7;
		gclass3_0.TabStop = true;
		gclass3_0.Text = "справка онлайн";
		gclass3_0.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		class61_0.AutoSize = true;
		class61_0.Location = new Point(16, 97);
		class61_0.Name = "m_chbEnableEngine";
		class61_0.Size = new Size(185, 20);
		class61_0.TabIndex = 0;
		class61_0.Text = "Enable MS-SQL protection";
		class61_0.UseVisualStyleBackColor = true;
		class63_0.AutoSize = true;
		class63_0.ForeColor = SystemColors.ControlDarkDark;
		class63_0.Location = new Point(13, 122);
		class63_0.Name = "m_lblEnableEngineHint";
		class63_0.Size = new Size(227, 16);
		class63_0.TabIndex = 58;
		class63_0.Text = "Turn on to enable MS-SQL protection";
		class62_2.AutoSize = true;
		class62_2.Enabled = false;
		class62_2.ForeColor = SystemColors.ControlDarkDark;
		class62_2.Location = new Point(13, 179);
		class62_2.Name = "m_lblEnable18456Hint";
		class62_2.Size = new Size(418, 16);
		class62_2.TabIndex = 74;
		class62_2.Text = "In most cases this event indicates brute-force attacks, keep it enabled";
		class61_1.AutoSize = true;
		class61_1.Checked = true;
		class61_1.CheckState = CheckState.Checked;
		class61_1.Enabled = false;
		class61_1.Location = new Point(16, 154);
		class61_1.Name = "m_chbEnable18456";
		class61_1.Size = new Size(162, 20);
		class61_1.TabIndex = 1;
		class61_1.Text = "Monitor Event ID 18456";
		class61_1.UseVisualStyleBackColor = true;
		gclass3_1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		gclass3_1.AutoSize = true;
		gclass3_1.Enabled = false;
		gclass3_1.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_1.Location = new Point(351, 155);
		gclass3_1.Name = "m_lnkEevent18456Exclusions";
		gclass3_1.Size = new Size(77, 16);
		gclass3_1.TabIndex = 2;
		gclass3_1.TabStop = true;
		gclass3_1.Text = "exclusions..";
		gclass3_1.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		class62_3.AutoSize = true;
		class62_3.Enabled = false;
		class62_3.ForeColor = SystemColors.ControlDarkDark;
		class62_3.Location = new Point(13, 236);
		class62_3.Name = "m_lblEnable17832Hint";
		class62_3.Size = new Size(367, 16);
		class62_3.TabIndex = 77;
		class62_3.Text = "This event may also be a part of an attack on MS-SQL server";
		class61_2.AutoSize = true;
		class61_2.Enabled = false;
		class61_2.Location = new Point(16, 211);
		class61_2.Name = "m_chbEnable17832";
		class61_2.Size = new Size(162, 20);
		class61_2.TabIndex = 3;
		class61_2.Text = "Monitor Event ID 17832";
		class61_2.UseVisualStyleBackColor = true;
		class62_4.AutoSize = true;
		class62_4.Enabled = false;
		class62_4.ForeColor = SystemColors.ControlDarkDark;
		class62_4.Location = new Point(13, 293);
		class62_4.Name = "m_lblEnable17836Hint";
		class62_4.Size = new Size(367, 16);
		class62_4.TabIndex = 79;
		class62_4.Text = "This event may also be a part of an attack on MS-SQL server";
		class61_3.AutoSize = true;
		class61_3.Enabled = false;
		class61_3.Location = new Point(16, 268);
		class61_3.Name = "m_chbEnable17836";
		class61_3.Size = new Size(162, 20);
		class61_3.TabIndex = 4;
		class61_3.Text = "Monitor Event ID 17836";
		class61_3.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(449, 377);
		base.Controls.Add(class62_4);
		base.Controls.Add(class61_3);
		base.Controls.Add(class62_3);
		base.Controls.Add(class61_2);
		base.Controls.Add(gclass3_1);
		base.Controls.Add(class62_2);
		base.Controls.Add(class61_1);
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
		base.Name = "MsSqlSettingsDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "MS-SQL Settings";
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void gclass3_0_Click(object sender, EventArgs e)
	{
		method_9(Class148.Class151.String_9);
	}

	private void class61_0_CheckedChanged(object sender, EventArgs e)
	{
		ReInitializeComponent();
	}

	private void class61_1_CheckedChanged(object sender, EventArgs e)
	{
		ReInitializeComponent();
	}

	private void class61_2_CheckedChanged(object sender, EventArgs e)
	{
		ReInitializeComponent();
	}

	private void class61_3_CheckedChanged(object sender, EventArgs e)
	{
		ReInitializeComponent();
	}

	private void gclass3_1_Click(object sender, EventArgs e)
	{
		MsSqlExclusionsDialog form = new MsSqlExclusionsDialog
		{
			String_0 = string_0
		};
		using (form)
		{
			if (DialogResult.OK == form.ShowDialog())
			{
				string_0 = form.String_0;
			}
		}
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
