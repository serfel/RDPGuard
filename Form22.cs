using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class Form22 : Form0
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

	private Class63 class63_0;

	private Class63 class63_1;

	private Class62 class62_2;

	private TextBox textBox_0;

	private Class62 class62_3;

	public Class169 Class169_0
	{
		get
		{
			return new Class169
			{
				ushort_0 = Class168.smethod_1(textBox_0.Text),
				Boolean_0 = class61_0.Checked
			};
		}
		set
		{
			class61_0.CheckState = CheckState.Checked;
			class61_0.Checked = !value.Boolean_1;
			textBox_0.Text = Class168.smethod_0(value.ushort_0);
		}
	}

	protected override Button Button_0 => class66_0;

	public Form22(Class169 class169_0)
		: base(new Size(500, 345))
	{
		method_13();
		vmethod_1();
		method_11();
		method_12();
		Class169_0 = class169_0;
	}

	private void method_11()
	{
		class62_3.Left = class62_2.Right;
	}

	private void method_12()
	{
		gclass3_0.Click += gclass3_0_Click;
		class61_0.CheckedChanged += class61_0_CheckedChanged;
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
		icontainer_0 = new Container();
		new ComponentResourceManager(typeof(Form22));
		class66_0 = new Class66();
		class66_1 = new Class66();
		gcontrol0_0 = new GControl0();
		class62_0 = new Class62();
		pictureBox_0 = new PictureBox();
		class62_1 = new Class62();
		gclass3_0 = new GClass3();
		class61_0 = new Class61();
		class63_0 = new Class63();
		class63_1 = new Class63();
		class62_2 = new Class62();
		textBox_0 = new TextBox();
		class62_3 = new Class62();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		class66_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_0.Image = Resources.opts_16;
		class66_0.Location = new Point(263, 257);
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
		class66_1.Location = new Point(371, 257);
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
		class62_0.Name = "label2";
		class62_0.Size = new Size(199, 16);
		class62_0.TabIndex = 49;
		class62_0.Text = "Advanced blocking settings";
		pictureBox_0.Image = Resources.firewall_edit_48;
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
		class62_1.Size = new Size(206, 16);
		class62_1.TabIndex = 48;
		class62_1.Text = "Advanced settings for IP blocking";
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
		class61_0.Name = "m_chbBlockAllPorts";
		class61_0.Size = new Size(351, 20);
		class61_0.TabIndex = 0;
		class61_0.Text = "Block access to all ports on the server (recommended)";
		class61_0.UseVisualStyleBackColor = true;
		class63_0.AutoSize = true;
		class63_0.ForeColor = SystemColors.ControlDarkDark;
		class63_0.Location = new Point(13, 122);
		class63_0.Name = "m_lblBlockAllPortsHint";
		class63_0.Size = new Size(297, 16);
		class63_0.TabIndex = 58;
		class63_0.Text = "Turn on to block access to all ports  on the server";
		class63_1.AutoSize = true;
		class63_1.ForeColor = SystemColors.ControlDarkDark;
		class63_1.Location = new Point(20, 213);
		class63_1.Name = "m_lblPortsHint";
		class63_1.Size = new Size(426, 16);
		class63_1.TabIndex = 71;
		class63_1.Text = "You can also specify multiple comma-separated ports, i.e. 3389, 21, 25";
		class62_2.AutoSize = true;
		class62_2.Location = new Point(13, 157);
		class62_2.Name = "m_lblPorts";
		class62_2.Size = new Size(92, 16);
		class62_2.TabIndex = 70;
		class62_2.Text = "Ports to block:";
		textBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		textBox_0.Location = new Point(23, 183);
		textBox_0.Name = "m_edPorts";
		textBox_0.Size = new Size(448, 22);
		textBox_0.TabIndex = 77;
		class62_3.AutoSize = true;
		class62_3.ForeColor = Color.Red;
		class62_3.Location = new Point(103, 157);
		class62_3.Name = "m_lblPerformanceWarning";
		class62_3.Size = new Size(356, 16);
		class62_3.TabIndex = 78;
		class62_3.Text = "(network performance may be affected, please check help)";
		class62_3.Boolean_0 = true;
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(484, 306);
		base.Controls.Add(class62_3);
		base.Controls.Add(textBox_0);
		base.Controls.Add(class63_1);
		base.Controls.Add(class62_2);
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
		base.Name = "AdvancedBlockingSettingsDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "Blocking Settings";
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void gclass3_0_Click(object sender, EventArgs e)
	{
		method_9(Class148.String_5);
	}

	private void class61_0_CheckedChanged(object sender, EventArgs e)
	{
		bool enabled = !class61_0.Checked;
		class62_2.Enabled = enabled;
		class62_3.Enabled = enabled;
		textBox_0.Enabled = enabled;
		class63_1.Enabled = enabled;
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
