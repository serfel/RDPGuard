using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Properties;
using rdpguard.lib;

internal sealed class IPListEntryAddEditDialog : Form0
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

	private PictureBox mimgTopIcon;

	private Class62 mlblSubCaption;

	private Class62 mlblCaption;

	private Class66 btnCancel;

	private Class66 mbtnOK;

	private GControl0 separatorLine1;

	private TextBox medIPAddress;

	private TextBox medComment;

	private Class62 mlblComment;

	private Class63 mlblCommentHint;

	private Class62 mlblIPAddress;

	private Class63 mlblIPAddressHint;

	private GClass3 mlnkOnlineHelp;

	public Image Image_0
	{
		set
		{
			mimgTopIcon.Image = value;
		}
	}

	public IPListEntry[] IPListEntry_0
	{
		get
		{
			return medIPAddress.Text.smethod_4().Select(ValidateInput).ToArray();
		}
		set
		{
			medIPAddress.Text = value.First().gclass24_0.method_5();
			medComment.Text = value.First().Comment;
		}
	}

	protected override Button Button_0 => mbtnOK;

	public IPListEntryAddEditDialog(IPListEntry iplistEntry_0)
		: base(new Size(590, 425))
	{
		OnLoad();
		InitializeFormPosition();
		InitializeComponent(iplistEntry_0);
		OnButtonOk();
		OnFormClosing();
	}

	private void InitializeComponent(IPListEntry iplistEntry_0)
	{
		if (null == iplistEntry_0)
		{
			Text = "Add New IP Addresses";
			mlblCaption.Text = "New IP Addresses";
			mlblSubCaption.Text = "Enter addresses and optional comment and click Add new addresses";
			mlblIPAddress.Text = "IP Addresses, Ranges or CIDRs:";
			mbtnOK.Text = "Add new addresses";
			MinimumSize = new Size(590, 425);
			medIPAddress.Multiline = true;
			TextBox textBox = medIPAddress;
			Class63 @class = mlblIPAddressHint;
			Class62 class2 = mlblComment;
			TextBox textBox2 = medComment;
			mlblCommentHint.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			textBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			class2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			@class.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			textBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			medIPAddress.Anchor |= AnchorStyles.Top;
			mlnkOnlineHelp.Click += mlnkOnlineHelp_Click;
		}
		else
		{
			IPListEntry_0 = new IPListEntry[1] { iplistEntry_0 };
			Text = "Edit IP Address";
			mlblCaption.Text = "Edit IP Address";
			mlblSubCaption.Text = "Edit IP Address and Comment and click Save changes";
			mlblIPAddress.Text = "IP Address, Range or CIDR:";
			mbtnOK.Text = "Save changes";
			MinimumSize = new Size(590, 370);
			base.Height = 370;
			medIPAddress.Multiline = false;
			TextBox textBox3 = medIPAddress;
			Class63 class3 = mlblIPAddressHint;
			Class62 class4 = mlblComment;
			TextBox textBox4 = medComment;
			mlblCommentHint.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			class4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			class3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			mlnkOnlineHelp.Click += gclass3_0_Click_1;
		}
		mlblIPAddressHint.Text = smethod_4(null != iplistEntry_0);
	}

	private static string smethod_4(bool bool_0)
	{
		return string.Format("{0}{1}xamples of valid entries are: 1.2.3.4 or 1.2.3.0-1.2.3.255 or 1.2.3.0/24", (bool_0 ? true : false) ? null : "One per line, ", (bool_0 ? true : false) ? "E" : "e");
	}

	private void OnButtonOk()
	{
		mbtnOK.Click += mbtnOK_Click;
		btnCancel.Click += btnCancel_Click;
	}

	protected override void OnFormClosing()
	{
		Button_0.Enabled = !string.IsNullOrEmpty(medIPAddress.Text);
	}

	private void OnButtonCancel()
	{
		string[] source = medIPAddress.Text.smethod_4();
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
			CloseDialog(DialogResult.OK);
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

	private void OnLoad()
	{
		mimgTopIcon = new PictureBox();
		mlblSubCaption = new Class62();
		mlblCaption = new Class62();
		btnCancel = new Class66();
		mbtnOK = new Class66();
		separatorLine1 = new GControl0();
		medIPAddress = new TextBox();
		medComment = new TextBox();
		mlblComment = new Class62();
		mlblCommentHint = new Class63();
		mlblIPAddress = new Class62();
		mlblIPAddressHint = new Class63();
		mlnkOnlineHelp = new GClass3();
		((ISupportInitialize)mimgTopIcon).BeginInit();
		SuspendLayout();
		mimgTopIcon.Location = new Point(16, 15);
		mimgTopIcon.Margin = new Padding(4);
		mimgTopIcon.Name = "m_imgTopIcon";
		mimgTopIcon.Size = new Size(48, 48);
		mimgTopIcon.SizeMode = PictureBoxSizeMode.AutoSize;
		mimgTopIcon.TabIndex = 0;
		mimgTopIcon.TabStop = false;
		mlblSubCaption.AutoSize = true;
		mlblSubCaption.Location = new Point(79, 47);
		mlblSubCaption.Margin = new Padding(4, 0, 4, 0);
		mlblSubCaption.Name = "m_lblSubCaption";
		mlblSubCaption.Size = new Size(163, 16);
		mlblSubCaption.TabIndex = 4;
		mlblSubCaption.Text = "<description placeholder>";
		mlblCaption.AutoSize = true;
		mlblCaption.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		mlblCaption.Location = new Point(79, 15);
		mlblCaption.Margin = new Padding(4, 0, 4, 0);
		mlblCaption.Name = "m_lblCaption";
		mlblCaption.Size = new Size(187, 16);
		mlblCaption.TabIndex = 14;
		mlblCaption.Text = "<subcaption placeholder>";
		btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		btnCancel.Image = Resources.cancel_16_pale;
		btnCancel.Location = new Point(461, 337);
		btnCancel.Margin = new Padding(4);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(100, 36);
		btnCancel.TabIndex = 3;
		btnCancel.Text = "Cancel";
		btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
		btnCancel.UseVisualStyleBackColor = true;
		mbtnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		mbtnOK.Image = Resources.ok_16_pale;
		mbtnOK.Location = new Point(291, 337);
		mbtnOK.Margin = new Padding(4);
		mbtnOK.Name = "m_btnOK";
		mbtnOK.Size = new Size(162, 36);
		mbtnOK.TabIndex = 2;
		mbtnOK.Text = "<ok_button>";
		mbtnOK.TextImageRelation = TextImageRelation.ImageBeforeText;
		mbtnOK.UseVisualStyleBackColor = true;
		separatorLine1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		separatorLine1.Location = new Point(16, 73);
		separatorLine1.Name = "separatorLine1";
		separatorLine1.Size = new Size(543, 10);
		separatorLine1.TabIndex = 35;
		separatorLine1.TabStop = false;
		medIPAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		medIPAddress.Location = new Point(27, 122);
		medIPAddress.Multiline = true;
		medIPAddress.Name = "m_edIPAddress";
		medIPAddress.Size = new Size(532, 76);
		medIPAddress.TabIndex = 0;
		medComment.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		medComment.Location = new Point(27, 269);
		medComment.Name = "m_edComment";
		medComment.Size = new Size(532, 22);
		medComment.TabIndex = 1;
		mlblComment.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		mlblComment.AutoSize = true;
		mlblComment.Location = new Point(13, 244);
		mlblComment.Name = "m_lblComment";
		mlblComment.Size = new Size(127, 16);
		mlblComment.TabIndex = 55;
		mlblComment.Text = "Comment (optional):";
		mlblCommentHint.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		mlblCommentHint.AutoSize = true;
		mlblCommentHint.ForeColor = SystemColors.ControlDarkDark;
		mlblCommentHint.Location = new Point(24, 299);
		mlblCommentHint.Name = "m_lblCommentHint";
		mlblCommentHint.Size = new Size(417, 16);
		mlblCommentHint.TabIndex = 54;
		mlblCommentHint.Text = "You can specify optional comment about these addresses or ranges";
		mlblIPAddress.AutoSize = true;
		mlblIPAddress.Location = new Point(13, 97);
		mlblIPAddress.Name = "m_lblIPAddress";
		mlblIPAddress.Size = new Size(206, 16);
		mlblIPAddress.TabIndex = 53;
		mlblIPAddress.Text = "{IP_ADDRESS_CAPTION}";
		mlblIPAddressHint.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		mlblIPAddressHint.AutoSize = true;
		mlblIPAddressHint.ForeColor = SystemColors.ControlDarkDark;
		mlblIPAddressHint.Location = new Point(24, 206);
		mlblIPAddressHint.Name = "m_lblIPAddressHint";
		mlblIPAddressHint.Size = new Size(142, 16);
		mlblIPAddressHint.TabIndex = 52;
		mlblIPAddressHint.Text = "{IP_ADDRESS_HINT}";
		mlnkOnlineHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		mlnkOnlineHelp.AutoSize = true;
		mlnkOnlineHelp.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkOnlineHelp.Location = new Point(489, 9);
		mlnkOnlineHelp.Name = "m_lnkOnlineHelp";
		mlnkOnlineHelp.Size = new Size(73, 16);
		mlnkOnlineHelp.TabIndex = 4;
		mlnkOnlineHelp.TabStop = true;
		mlnkOnlineHelp.Text = "online help";
		mlnkOnlineHelp.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(574, 386);
		base.Controls.Add(mlnkOnlineHelp);
		base.Controls.Add(medIPAddress);
		base.Controls.Add(medComment);
		base.Controls.Add(mlblComment);
		base.Controls.Add(mlblCommentHint);
		base.Controls.Add(mlblIPAddress);
		base.Controls.Add(mlblIPAddressHint);
		base.Controls.Add(separatorLine1);
		base.Controls.Add(mbtnOK);
		base.Controls.Add(btnCancel);
		base.Controls.Add(mlblCaption);
		base.Controls.Add(mlblSubCaption);
		base.Controls.Add(mimgTopIcon);
		Font = new Font("Microsoft Sans Serif", 9.75f);
		base.Margin = new Padding(4);
		base.Name = "IPListEntryAddEditDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "<caption placeholder>";
		((ISupportInitialize)mimgTopIcon).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private IPListEntry ValidateInput(string string_2)
	{
		return new IPListEntry(string_2, medComment.Text);
	}

	private void mlnkOnlineHelp_Click(object sender, EventArgs e)
	{
		string text = string_0;
		if (text == null)
		{
			text = Class148.Class152.String_1;
		}
		ShowOnlineHelp(text);
	}

	private void gclass3_0_Click_1(object sender, EventArgs e)
	{
		string string_ = string_1;
		if (string_ == null)
		{
			string_ = Class148.Class152.String_2;
		}
		ShowOnlineHelp(string_);
	}

	private void mbtnOK_Click(object sender, EventArgs e)
	{
		OnButtonCancel();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		CloseDialog(DialogResult.Cancel);
	}
}
