using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Properties;
using rdpguard.lib;

internal sealed class Form27 : Form0
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<string, bool> _003C_003E9__14_0;

		public static Func<string, string> _003C_003E9__14_1;

		internal bool method_0(string string_0)
		{
			return !GClass24.smethod_1(string_0).Boolean_2;
		}

		internal string method_1(string string_0)
		{
			return string_0;
		}
	}

	public string string_0;

	public string string_1;

	private IContainer icontainer_0;

	private PictureBox pictureBox_0;

	private Class62 class62_0;

	private Class62 class62_1;

	private Class66 class66_0;

	private Class66 class66_1;

	private GControl0 gcontrol0_0;

	private TextBox textBox_0;

	private TextBox textBox_1;

	private Class62 class62_2;

	private Class63 class63_0;

	private Class62 class62_3;

	private Class63 class63_1;

	private GClass3 gclass3_0;

	public Image Image_0
	{
		set
		{
			pictureBox_0.Image = value;
		}
	}

	public IPListEntry[] IPListEntry_0
	{
		get
		{
			return textBox_0.Text.smethod_4().Select(method_15).ToArray();
		}
		set
		{
			textBox_0.Text = value.First().gclass24_0.method_5();
			textBox_1.Text = value.First().Comment;
		}
	}

	protected override Button Button_0 => class66_1;

	public Form27(IPListEntry iplistEntry_0)
		: base(new Size(590, 425))
	{
		method_14();
		vmethod_1();
		method_11(iplistEntry_0);
		method_12();
		vmethod_0();
	}

	private void method_11(IPListEntry iplistEntry_0)
	{
		if (null == iplistEntry_0)
		{
			Text = "Add New IP Addresses";
			class62_1.Text = "New IP Addresses";
			class62_0.Text = "Enter addresses and optional comment and click Add new addresses";
			class62_3.Text = "IP Addresses, Ranges or CIDRs:";
			class66_1.Text = "Add new addresses";
			MinimumSize = new Size(590, 425);
			textBox_0.Multiline = true;
			TextBox textBox = textBox_0;
			Class63 @class = class63_1;
			Class62 class2 = class62_2;
			TextBox textBox2 = textBox_1;
			class63_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			textBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			class2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			@class.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			textBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			textBox_0.Anchor |= AnchorStyles.Top;
			gclass3_0.Click += gclass3_0_Click;
		}
		else
		{
			IPListEntry_0 = new IPListEntry[1] { iplistEntry_0 };
			Text = "Edit IP Address";
			class62_1.Text = "Edit IP Address";
			class62_0.Text = "Edit IP Address and Comment and click Save changes";
			class62_3.Text = "IP Address, Range or CIDR:";
			class66_1.Text = "Save changes";
			MinimumSize = new Size(590, 370);
			base.Height = 370;
			textBox_0.Multiline = false;
			TextBox textBox3 = textBox_0;
			Class63 class3 = class63_1;
			Class62 class4 = class62_2;
			TextBox textBox4 = textBox_1;
			class63_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			class4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			class3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			gclass3_0.Click += gclass3_0_Click_1;
		}
		class63_1.Text = smethod_4(null != iplistEntry_0);
	}

	private static string smethod_4(bool bool_0)
	{
		return string.Format("{0}{1}xamples of valid entries are: 1.2.3.4 or 1.2.3.0-1.2.3.255 or 1.2.3.0/24", (bool_0 ? true : false) ? null : "One per line, ", (bool_0 ? true : false) ? "E" : "e");
	}

	private void method_12()
	{
		class66_1.Click += class66_1_Click;
		class66_0.Click += class66_0_Click;
	}

	protected override void vmethod_0()
	{
		Button_0.Enabled = !string.IsNullOrEmpty(textBox_0.Text);
	}

	private void method_13()
	{
		string[] source = textBox_0.Text.smethod_4();
		Func<string, bool> predicate = _003C_003Ec._003C_003E9.method_0;
		IEnumerable<string> source2 = source.Where(predicate);
		if (source2.Any())
		{
			IEnumerable<string> source3 = source2.Take(10);
			Func<string, string> selector = _003C_003Ec._003C_003E9.method_1;
			MessageBox.Show("Invalid IP Address, Range or CIDR:\r\n\r\n" + string.Join("\r\n", source3.Select(selector)), Class138.String_1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else
		{
			method_8(DialogResult.OK);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_14()
	{
		pictureBox_0 = new PictureBox();
		class62_0 = new Class62();
		class62_1 = new Class62();
		class66_0 = new Class66();
		class66_1 = new Class66();
		gcontrol0_0 = new GControl0();
		textBox_0 = new TextBox();
		textBox_1 = new TextBox();
		class62_2 = new Class62();
		class63_0 = new Class63();
		class62_3 = new Class62();
		class63_1 = new Class63();
		gclass3_0 = new GClass3();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		pictureBox_0.Location = new Point(16, 15);
		pictureBox_0.Margin = new Padding(4);
		pictureBox_0.Name = "m_imgTopIcon";
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
		class62_0.Text = "<description placeholder>";
		class62_1.AutoSize = true;
		class62_1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		class62_1.Location = new Point(79, 15);
		class62_1.Margin = new Padding(4, 0, 4, 0);
		class62_1.Name = "m_lblCaption";
		class62_1.Size = new Size(187, 16);
		class62_1.TabIndex = 14;
		class62_1.Text = "<subcaption placeholder>";
		class66_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_0.Image = Resources.cancel_16_pale;
		class66_0.Location = new Point(461, 337);
		class66_0.Margin = new Padding(4);
		class66_0.Name = "btnCancel";
		class66_0.Size = new Size(100, 36);
		class66_0.TabIndex = 3;
		class66_0.Text = "Cancel";
		class66_0.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_0.UseVisualStyleBackColor = true;
		class66_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		class66_1.Image = Resources.ok_16_pale;
		class66_1.Location = new Point(291, 337);
		class66_1.Margin = new Padding(4);
		class66_1.Name = "m_btnOK";
		class66_1.Size = new Size(162, 36);
		class66_1.TabIndex = 2;
		class66_1.Text = "<ok_button>";
		class66_1.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_1.UseVisualStyleBackColor = true;
		gcontrol0_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		gcontrol0_0.Location = new Point(16, 73);
		gcontrol0_0.Name = "separatorLine1";
		gcontrol0_0.Size = new Size(543, 10);
		gcontrol0_0.TabIndex = 35;
		gcontrol0_0.TabStop = false;
		textBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		textBox_0.Location = new Point(27, 122);
		textBox_0.Multiline = true;
		textBox_0.Name = "m_edIPAddress";
		textBox_0.Size = new Size(532, 76);
		textBox_0.TabIndex = 0;
		textBox_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		textBox_1.Location = new Point(27, 269);
		textBox_1.Name = "m_edComment";
		textBox_1.Size = new Size(532, 22);
		textBox_1.TabIndex = 1;
		class62_2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		class62_2.AutoSize = true;
		class62_2.Location = new Point(13, 244);
		class62_2.Name = "m_lblComment";
		class62_2.Size = new Size(127, 16);
		class62_2.TabIndex = 55;
		class62_2.Text = "Comment (optional):";
		class63_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		class63_0.AutoSize = true;
		class63_0.ForeColor = SystemColors.ControlDarkDark;
		class63_0.Location = new Point(24, 299);
		class63_0.Name = "m_lblCommentHint";
		class63_0.Size = new Size(417, 16);
		class63_0.TabIndex = 54;
		class63_0.Text = "You can specify optional comment about these addresses or ranges";
		class62_3.AutoSize = true;
		class62_3.Location = new Point(13, 97);
		class62_3.Name = "m_lblIPAddress";
		class62_3.Size = new Size(206, 16);
		class62_3.TabIndex = 53;
		class62_3.Text = "{IP_ADDRESS_CAPTION}";
		class63_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		class63_1.AutoSize = true;
		class63_1.ForeColor = SystemColors.ControlDarkDark;
		class63_1.Location = new Point(24, 206);
		class63_1.Name = "m_lblIPAddressHint";
		class63_1.Size = new Size(142, 16);
		class63_1.TabIndex = 52;
		class63_1.Text = "{IP_ADDRESS_HINT}";
		gclass3_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		gclass3_0.AutoSize = true;
		gclass3_0.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_0.Location = new Point(489, 9);
		gclass3_0.Name = "m_lnkOnlineHelp";
		gclass3_0.Size = new Size(73, 16);
		gclass3_0.TabIndex = 4;
		gclass3_0.TabStop = true;
		gclass3_0.Text = "online help";
		gclass3_0.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(574, 386);
		base.Controls.Add(gclass3_0);
		base.Controls.Add(textBox_0);
		base.Controls.Add(textBox_1);
		base.Controls.Add(class62_2);
		base.Controls.Add(class63_0);
		base.Controls.Add(class62_3);
		base.Controls.Add(class63_1);
		base.Controls.Add(gcontrol0_0);
		base.Controls.Add(class66_1);
		base.Controls.Add(class66_0);
		base.Controls.Add(class62_1);
		base.Controls.Add(class62_0);
		base.Controls.Add(pictureBox_0);
		Font = new Font("Microsoft Sans Serif", 9.75f);
		base.Margin = new Padding(4);
		base.Name = "IPListEntryAddEditDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "<caption placeholder>";
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private IPListEntry method_15(string string_2)
	{
		return new IPListEntry(string_2, textBox_1.Text);
	}

	private void gclass3_0_Click(object sender, EventArgs e)
	{
		string text = string_0;
		if (text == null)
		{
			text = Class148.Class152.String_1;
		}
		method_9(text);
	}

	private void gclass3_0_Click_1(object sender, EventArgs e)
	{
		string string_ = string_1;
		if (string_ == null)
		{
			string_ = Class148.Class152.String_2;
		}
		method_9(string_);
	}

	private void class66_1_Click(object sender, EventArgs e)
	{
		method_13();
	}

	private void class66_0_Click(object sender, EventArgs e)
	{
		method_8(DialogResult.Cancel);
	}
}
