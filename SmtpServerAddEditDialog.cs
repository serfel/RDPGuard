using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class SmtpServerAddEditDialog : Form0
{
	private Class109 class109_0;

	private IContainer icontainer_0;

	private PictureBox pictureBox_0;

	private Class62 class62_0;

	private Class62 class62_1;

	private Class66 class66_0;

	private Class66 class66_1;

	private GControl0 gcontrol0_0;

	private GClass3 gclass3_0;

	private Class65 class65_0;

	private TextBox textBox_0;

	private Class62 class62_2;

	private Class63 class63_0;

	private Class62 class62_3;

	private Class63 class63_1;

	private NumericUpDown numericUpDown_0;

	private Class65 class65_1;

	private TextBox textBox_1;

	private Class62 class62_4;

	private Class63 class63_2;

	private TextBox textBox_2;

	private Class62 class62_5;

	private Class63 class63_3;

	private Class63 class63_4;

	private Class61 class61_0;

	public Class109 Class109_0
	{
		get
		{
			class109_0.string_1 = textBox_0.Text;
			class109_0.ushort_0 = (ushort)numericUpDown_0.Value;
			class109_0.bool_0 = class61_0.Checked;
			class109_0.string_2 = textBox_2.Text;
			class109_0.string_3 = textBox_1.Text;
			return class109_0;
		}
		set
		{
			class109_0 = value;
			textBox_0.Text = class109_0.string_1;
			numericUpDown_0.Value = class109_0.ushort_0;
			class61_0.Checked = class109_0.bool_0;
			textBox_2.Text = class109_0.string_2;
			textBox_1.Text = class109_0.string_3;
		}
	}

	protected override Button Button_0 => class66_1;

	public SmtpServerAddEditDialog(Class109 class109_1)
		: base(new Size(560, 580))
	{
		InitializeComponent();
		vmethod_1();
		if (class109_1 == null)
		{
			Class109_0 = new Class109();
			Text = "Add New SMTP Server";
			class62_1.Text = "Новый SMTP-сервер";
			class62_0.Text = "Задайте параметры SMTP и нажмите «Добавить»";
			class66_1.Text = "Добавить сервер";
			pictureBox_0.Image = Resources.mail_server_add_48;
			gclass3_0.Click += gclass3_0_Click;
		}
		else
		{
			Class109_0 = class109_1;
			Text = "Edit SMTP Server";
			class62_1.Text = "Изменить SMTP-сервер";
			class62_0.Text = "Измените параметры SMTP и нажмите «Сохранить»";
			class66_1.Text = "Сохранить изменения";
			pictureBox_0.Image = Resources.mail_server_edit_48;
			gclass3_0.Click += gclass3_0_Click_1;
		}
		method_11();
		vmethod_0();
	}

	private void method_11()
	{
		base.Shown += Form26_Shown;
		class66_1.Click += class66_1_Click;
		class66_0.Click += class66_0_Click;
	}

	protected override void vmethod_0()
	{
		Button_0.Enabled = !string.IsNullOrEmpty(textBox_0.Text);
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
		class66_0 = new Class66();
		class66_1 = new Class66();
		gcontrol0_0 = new GControl0();
		gclass3_0 = new GClass3();
		class65_0 = new Class65();
		class63_4 = new Class63();
		class61_0 = new Class61();
		numericUpDown_0 = new NumericUpDown();
		class62_3 = new Class62();
		class63_1 = new Class63();
		textBox_0 = new TextBox();
		class62_2 = new Class62();
		class63_0 = new Class63();
		class65_1 = new Class65();
		textBox_1 = new TextBox();
		class62_4 = new Class62();
		class63_2 = new Class63();
		textBox_2 = new TextBox();
		class62_5 = new Class62();
		class63_3 = new Class63();
		((ISupportInitialize)pictureBox_0).BeginInit();
		class65_0.SuspendLayout();
		((ISupportInitialize)numericUpDown_0).BeginInit();
		class65_1.SuspendLayout();
		SuspendLayout();
		pictureBox_0.Location = new Point(16, 15);
		pictureBox_0.Margin = new Padding(4);
		pictureBox_0.Name = "m_imgBigIcon";
		pictureBox_0.Size = new Size(48, 48);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 0;
		pictureBox_0.TabStop = false;
		class62_0.AutoSize = true;
		class62_0.Location = new Point(79, 47);
		class62_0.Margin = new Padding(4, 0, 4, 0);
		class62_0.Name = "m_lblSubCaption";
		class62_0.Size = new Size(163, 16);
		class62_0.TabIndex = 4;
		class62_0"<description placeholder>";
		class62_1.AutoSize = true;
		class62_1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		class62_1.Location = new Point(79, 15);
		class62_1.Margin = new Padding(4, 0, 4, 0);
		class62_1.Name = "m_lblCaption";
		class62_1.Size = new Size(187, 16);
		class62_1.TabIndex = 14;
		class62_1"<subcaption placeholder>";
		class66_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_0.Image = Resources.cancl_16;
		class66_0.Location = new Point(431, 493);
		class66_0.Margin = new Padding(4);
		class66_0.Name = "m_btnCancel";
		class66_0.Size = new Size(100, 36);
		class66_0.TabIndex = 6;
		class66_0.Text = "Отмена";
		class66_0.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_0.UseVisualStyleBackColor = true;
		class66_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		class66_1.Enabled = false;
		class66_1.Image = Resources.opts_16;
		class66_1.Location = new Point(271, 493);
		class66_1.Margin = new Padding(4);
		class66_1.Name = "m_btnOK";
		class66_1.Size = new Size(152, 36);
		class66_1.TabIndex = 5;
		class66_1"<ok_button>";
		class66_1.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_1.UseVisualStyleBackColor = true;
		gcontrol0_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		gcontrol0_0.Location = new Point(16, 73);
		gcontrol0_0.Name = "separatorLine1";
		gcontrol0_0.Size = new Size(513, 10);
		gcontrol0_0.TabIndex = 35;
		gcontrol0_0.TabStop = false;
		gclass3_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		gclass3_0.AutoSize = true;
		gclass3_0.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_0.Location = new Point(459, 9);
		gclass3_0.Name = "m_lnkOnlineHelp";
		gclass3_0.Size = new Size(73, 16);
		gclass3_0.TabIndex = 7;
		gclass3_0.TabStop = true;
		gclass3_0.Text = "справка онлайн";
		gclass3_0.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		class65_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		class65_0.Controls.Add(class63_4);
		class65_0.Controls.Add(class61_0);
		class65_0.Controls.Add(numericUpDown_0);
		class65_0.Controls.Add(class62_3);
		class65_0.Controls.Add(class63_1);
		class65_0.Controls.Add(textBox_0);
		class65_0.Controls.Add(class62_2);
		class65_0.Controls.Add(class63_0);
		class65_0.Location = new Point(16, 89);
		class65_0.Name = "m_grbTransport";
		class65_0.Size = new Size(516, 224);
		class65_0.TabIndex = 36;
		class65_0.TabStop = false;
		class65_0"Transport";
		class63_4.AutoSize = true;
		class63_4.ForeColor = SystemColors.ControlDarkDark;
		class63_4.Location = new Point(16, 188);
		class63_4.Name = "m_lblSSLHint";
		class63_4.Size = new Size(356, 16);
		class63_4.TabIndex = 69;
		class63_4" Turn on if your server supports secure SMTP connections. ";
		class61_0.AutoSize = true;
		class61_0.Location = new Point(19, 162);
		class61_0.Name = "m_chbSSL";
		class61_0.Size = new Size(127, 20);
		class61_0.TabIndex = 2;
		class61_0.Text = "Включить SSL/TLS";
		class61_0.UseVisualStyleBackColor = true;
		numericUpDown_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		numericUpDown_0.Location = new Point(140, 96);
		numericUpDown_0.Maximum = new decimal(new int[4] { 65535, 0, 0, 0 });
		numericUpDown_0.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		numericUpDown_0.Name = "m_numPort";
		numericUpDown_0.Size = new Size(372, 22);
		numericUpDown_0.TabIndex = 1;
		numericUpDown_0.Value = new decimal(new int[4] { 25, 0, 0, 0 });
		class62_3.AutoSize = true;
		class62_3.Location = new Point(16, 102);
		class62_3.Name = "m_lblPort";
		class62_3.Size = new Size(35, 16);
		class62_3.TabIndex = 67;
		class62_3.Text = "Порт:";
		class63_1.AutoSize = true;
		class63_1.ForeColor = SystemColors.ControlDarkDark;
		class63_1.Location = new Point(137, 124);
		class63_1.Name = "m_lblPortHint";
		class63_1.Size = new Size(348, 16);
		class63_1.TabIndex = 66;
		class63_1.Text = "Обычные порты SMTP: 25 (простой) и 587 (защищённый)";
		textBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		textBox_0.Location = new Point(140, 26);
		textBox_0.Name = "m_edHost";
		textBox_0.Size = new Size(370, 22);
		textBox_0.TabIndex = 0;
		class62_2.AutoSize = true;
		class62_2.Location = new Point(16, 32);
		class62_2.Name = "m_lblHost";
		class62_2.Size = new Size(39, 16);
		class62_2.TabIndex = 64;
		class62_2.Text = "Хост:";
		class63_0.AutoSize = true;
		class63_0.ForeColor = SystemColors.ControlDarkDark;
		class63_0.Location = new Point(137, 54);
		class63_0.Name = "m_lblHostHint";
		class63_0.Size = new Size(289, 16);
		class63_0.TabIndex = 63;
		class63_0" Specify SMTP server to use for sending emails";
		class65_1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		class65_1.Controls.Add(textBox_1);
		class65_1.Controls.Add(class62_4);
		class65_1.Controls.Add(class63_2);
		class65_1.Controls.Add(textBox_2);
		class65_1.Controls.Add(class62_5);
		class65_1.Controls.Add(class63_3);
		class65_1.Location = new Point(16, 319);
		class65_1.Name = "m_grbAuthentication";
		class65_1.Size = new Size(516, 160);
		class65_1.TabIndex = 37;
		class65_1.TabStop = false;
		class65_1"Authentication";
		textBox_1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		textBox_1.Location = new Point(140, 95);
		textBox_1.Name = "m_edPassword";
		textBox_1.Size = new Size(370, 22);
		textBox_1.TabIndex = 4;
		textBox_1.UseSystemPasswordChar = true;
		class62_4.AutoSize = true;
		class62_4.Location = new Point(16, 101);
		class62_4.Name = "m_lblPassword";
		class62_4.Size = new Size(71, 16);
		class62_4.TabIndex = 67;
		class62_4.Text = "Пароль:";
		class63_2.AutoSize = true;
		class63_2.ForeColor = SystemColors.ControlDarkDark;
		class63_2.Location = new Point(137, 123);
		class63_2.Name = "m_lblPasswordHint";
		class63_2.Size = new Size(265, 16);
		class63_2.TabIndex = 66;
		class63_2" Specify password for SMTP authentication ";
		textBox_2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		textBox_2.Location = new Point(140, 26);
		textBox_2.Name = "m_edUsername";
		textBox_2.Size = new Size(370, 22);
		textBox_2.TabIndex = 3;
		class62_5.AutoSize = true;
		class62_5.Location = new Point(16, 32);
		class62_5.Name = "m_lblUsername";
		class62_5.Size = new Size(77, 16);
		class62_5.TabIndex = 64;
		class62_5.Text = "Имя пользователя:";
		class63_3.AutoSize = true;
		class63_3.ForeColor = SystemColors.ControlDark;
		class63_3.Location = new Point(137, 54);
		class63_3.Name = "m_lblUsernameHint";
		class63_3.Size = new Size(269, 16);
		class63_3.TabIndex = 63;
		class63_3" Specify user name for SMTP authentication ";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(544, 542);
		base.Controls.Add(class65_1);
		base.Controls.Add(class65_0);
		base.Controls.Add(gclass3_0);
		base.Controls.Add(gcontrol0_0);
		base.Controls.Add(class66_1);
		base.Controls.Add(class66_0);
		base.Controls.Add(class62_1);
		base.Controls.Add(class62_0);
		base.Controls.Add(pictureBox_0);
		Font = new Font("Microsoft Sans Serif", 9.75f);
		base.Margin = new Padding(4);
		base.Name = "SmtpServerAddEditDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "<caption placeholder>";
		((ISupportInitialize)pictureBox_0).EndInit();
		class65_0.ResumeLayout(performLayout: false);
		class65_0.PerformLayout();
		((ISupportInitialize)numericUpDown_0).EndInit();
		class65_1.ResumeLayout(performLayout: false);
		class65_1.PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void gclass3_0_Click(object sender, EventArgs e)
	{
		method_9(Class148.Class154.String_1);
	}

	private void gclass3_0_Click_1(object sender, EventArgs e)
	{
		method_9(Class148.Class154.String_2);
	}

	private void Form26_Shown(object sender, EventArgs e)
	{
		class65_1.Focus();
		textBox_0.Focus();
	}

	private void class66_1_Click(object sender, EventArgs e)
	{
		method_8(DialogResult.OK);
	}

	private void class66_0_Click(object sender, EventArgs e)
	{
		method_8(DialogResult.Cancel);
	}
}
