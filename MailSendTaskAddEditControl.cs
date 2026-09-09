using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class MailSendTaskAddEditControl : Control4
{
	private sealed class Class68
	{
		public MailSendTaskAddEditControl control9_0;

		public object object_0;

		public EventArgs4 eventArgs4_0;

		internal void method_0()
		{
			control9_0.method_1(object_0, eventArgs4_0);
		}
	}

	private readonly Dictionary<GEnum2, string[]> dictionary_0 = new Dictionary<GEnum2, string[]>
	{
		{
			GEnum2.const_0,
			new string[2] { "RdpGuard blocked %IP%", "IP: %IP%\r\nUser: %USER%\r\nBlock Date: %BLOCK_DATE%\r\nUnblock Date: %UNBLOCK_DATE%\r\nProtocol: %PROTOCOL%\r\nHost: %HOSTNAME%\r\nTotal IP addresses currently blocked: %TOTAL_IP_BLOCKED%" }
		},
		{
			GEnum2.const_1,
			new string[2] { "RdpGuard unblocked %IP%", "IP: %IP%\r\nUser: %USER%\r\nBlock Date: %BLOCK_DATE%\r\nUnblock Date: %UNBLOCK_DATE%\r\nProtocol: %PROTOCOL%\r\nHost: %HOSTNAME%\r\nTotal IP addresses currently blocked: %TOTAL_IP_BLOCKED%" }
		},
		{
			GEnum2.const_2,
			new string[2] { "%USER% logged in from %IP%", "IP: %IP%\r\nUser: %USER%\r\nHost: %HOSTNAME%" }
		},
		{
			GEnum2.const_3,
			new string[2] { "RdpGuard version %NEW_VERSION_NUMBER% available", "Download from %NEW_VERSION_LINK%" }
		},
		{
			GEnum2.const_4,
			new string[2] { "RdpGuard maintenance expiration", "Maintenance is about to expire in %MAINTENANCE_DAYS% days on host: %HOSTNAME%" }
		},
		{
			GEnum2.const_5,
			new string[2] { "RdpGuard maintenance expired", "RdpGuard maintenance expired on host: %HOSTNAME%" }
		}
	};

	private readonly Dictionary<int, string> dictionary_1 = new Dictionary<int, string>();

	private string string_0;

	private IContainer icontainer_0;

	private Class65 class65_0;

	private Class0 class0_0;

	private Class62 class62_0;

	private Class63 class63_0;

	private Class65 class65_1;

	private TextBox textBox_0;

	private Class62 class62_1;

	private Class63 class63_1;

	private TextBox textBox_1;

	private Class62 class62_2;

	private Class63 class63_2;

	private TextBox textBox_2;

	private Class62 class62_3;

	private Class63 class63_3;

	private GClass3 gclass3_1;

	private TextBox textBox_3;

	private Class62 class62_4;

	private Class63 class63_4;

	private PictureBox pictureBox_0;

	private Class62 class62_5;

	private Class62 class62_6;

	private Class66 class66_0;

	public override Size Size_0 => new Size(630, 540);

	public override GClass3 GClass3_0 => gclass3_1;

	public override GClass10 GClass10_0
	{
		get
		{
			return new Class175
			{
				string_2 = string_0,
				string_3 = textBox_1.Text,
				string_4 = string.Join(", ", textBox_0.Text.smethod_7()),
				string_5 = textBox_2.Text,
				string_6 = textBox_3.Text
			};
		}
		set
		{
			Class175 @class = value as Class175;
			string_0 = @class.string_2;
			method_2();
			textBox_1.Text = @class.string_3;
			textBox_0.Text = @class.string_4;
			textBox_2.Text = @class.string_5;
			textBox_3.Text = @class.string_6;
		}
	}

	public override void vmethod_3(GEnum2 genum2_0)
	{
		textBox_2.Text = dictionary_0[genum2_0][0];
		textBox_3.Text = dictionary_0[genum2_0][1];
	}

	public override bool vmethod_4()
	{
		bool flag = Class71.smethod_0(textBox_1.Text);
		bool flag2 = Class71.smethod_0(textBox_0.Text);
		class62_6.Visible = !flag;
		class62_5.Visible = !flag2;
		return flag && flag2;
	}

	private void method_1(object sender, EventArgs4 e)
	{
		Class68 @class = new Class68();
		@class.control9_0 = this;
		@class.object_0 = sender;
		@class.eventArgs4_0 = e;
		Class89.eventHandler_23 = (EventHandler<EventArgs4>)Delegate.Remove(Class89.eventHandler_23, new EventHandler<EventArgs4>(method_1));
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
			return;
		}
		class0_0.Items.Clear();
		dictionary_1.Clear();
		Class109[] class109_ = @class.eventArgs4_0.class109_0;
		Class109[] array = class109_;
		foreach (Class109 class2 in array)
		{
			int key = class0_0.Items.Add(class2.ToString());
			dictionary_1.Add(key, class2.String_0);
		}
		method_2();
		vmethod_2();
	}

	private void method_2()
	{
		class0_0.SelectedIndex = -1;
		using Dictionary<int, string>.KeyCollection.Enumerator enumerator = dictionary_1.Keys.GetEnumerator();
		while (enumerator.MoveNext() ? true : false)
		{
			int current = enumerator.Current;
			if (string_0 == dictionary_1[current])
			{
				class0_0.SelectedIndex = current;
				break;
			}
		}
	}

	private void method_3()
	{
		if (dictionary_1.Count > 0 && class0_0.SelectedIndex >= 0)
		{
			string_0 = dictionary_1[class0_0.SelectedIndex];
		}
	}

	protected override void vmethod_0()
	{
		method_4();
		Class89.eventHandler_23 = (EventHandler<EventArgs4>)Delegate.Combine(Class89.eventHandler_23, new EventHandler<EventArgs4>(method_1));
		Class89.smethod_32();
		new ToolTip().SetToolTip(class66_0, "Click to add/edit SMTP servers");
		pictureBox_0.Image = ((Class163.Class163_0.Boolean_0 ? true : false) ? Resources.wait_16_dark : Resources.wait_16);
	}

	protected override void vmethod_1()
	{
		class66_0.Click += class66_0_Click;
		class0_0.SelectedIndexChanged += class0_0_SelectedIndexChanged;
	}

	public override void vmethod_5(bool bool_1)
	{
		pictureBox_0.Visible = !bool_1;
		class62_0.Enabled = bool_1;
		class63_0.Enabled = bool_1;
		class0_0.Enabled = bool_1;
		class66_0.Enabled = bool_1;
		class62_2.Enabled = bool_1;
		class63_2.Enabled = bool_1;
		textBox_1.Enabled = bool_1;
		class62_1.Enabled = bool_1;
		class63_1.Enabled = bool_1;
		textBox_0.Enabled = bool_1;
		class62_3.Enabled = bool_1;
		class63_3.Enabled = bool_1;
		textBox_2.Enabled = bool_1;
		class62_4.Enabled = bool_1;
		class63_4.Enabled = bool_1;
		textBox_3.Enabled = bool_1;
		gclass3_1.Enabled = bool_1;
	}

	protected override void vmethod_2()
	{
		base.Boolean_0 = !string.IsNullOrEmpty(class0_0.Text) && !string.IsNullOrEmpty(textBox_1.Text) && !string.IsNullOrEmpty(textBox_0.Text) && !string.IsNullOrEmpty(textBox_2.Text) && !string.IsNullOrEmpty(textBox_3.Text) && vmethod_4();
		gclass3_1.Enabled = base.Boolean_0;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_4()
	{
		Class175 gClass10_ = new Class175();
		class65_0 = new Class65();
		class66_0 = new Class66();
		class0_0 = new Class0();
		class62_0 = new Class62();
		class63_0 = new Class63();
		class65_1 = new Class65();
		class62_5 = new Class62();
		class62_6 = new Class62();
		pictureBox_0 = new PictureBox();
		gclass3_1 = new GClass3();
		textBox_3 = new TextBox();
		class62_4 = new Class62();
		class63_4 = new Class63();
		textBox_2 = new TextBox();
		class62_3 = new Class62();
		class63_3 = new Class63();
		textBox_0 = new TextBox();
		class62_1 = new Class62();
		class63_1 = new Class63();
		textBox_1 = new TextBox();
		class62_2 = new Class62();
		class63_2 = new Class63();
		class65_0.SuspendLayout();
		class65_1.SuspendLayout();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		class65_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		class65_0.Controls.Add(class66_0);
		class65_0.Controls.Add(class0_0);
		class65_0.Controls.Add(class62_0);
		class65_0.Controls.Add(class63_0);
		class65_0.Location = new Point(4, 4);
		class65_0.Margin = new Padding(4);
		class65_0.Name = "m_grbServer";
		class65_0.Padding = new Padding(4);
		class65_0.Size = new Size(622, 93);
		class65_0.TabIndex = 38;
		class65_0.TabStop = false;
		class65_0.Text = "SMTP-сервер";
		class66_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		class66_0.Image = Resources.edit_16;
		class66_0.Location = new Point(588, 31);
		class66_0.Name = "m_btnSmtpServersAddEdit";
		class66_0.Size = new Size(25, 25);
		class66_0.TabIndex = 65;
		class66_0.UseVisualStyleBackColor = true;
		class0_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		class0_0.DropDownStyle = ComboBoxStyle.DropDownList;
		class0_0.FormattingEnabled = true;
		class0_0.Location = new Point(187, 31);
		class0_0.Name = "m_cbSmtpServers";
		class0_0.Size = new Size(395, 24);
		class0_0.TabIndex = 10;
		class62_0.AutoSize = true;
		class62_0.Location = new Point(21, 34);
		class62_0.Margin = new Padding(4, 0, 4, 0);
		class62_0.Name = "m_lblServer";
		class62_0.Size = new Size(50, 16);
		class62_0.TabIndex = 64;
		class62_0.Text = "Сервер:";
		class63_0.AutoSize = true;
		class63_0.ForeColor = SystemColors.ControlDarkDark;
		class63_0.Location = new Point(184, 61);
		class63_0.Margin = new Padding(4, 0, 4, 0);
		class63_0.Name = "m_lblServerHint";
		class63_0.Size = new Size(321, 16);
		class63_0.TabIndex = 63;
		class63_0.Text = " Select SMTP server from the list or add the new one. ";
		class65_1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		class65_1.Controls.Add(class62_5);
		class65_1.Controls.Add(class62_6);
		class65_1.Controls.Add(pictureBox_0);
		class65_1.Controls.Add(gclass3_1);
		class65_1.Controls.Add(textBox_3);
		class65_1.Controls.Add(class62_4);
		class65_1.Controls.Add(class63_4);
		class65_1.Controls.Add(textBox_2);
		class65_1.Controls.Add(class62_3);
		class65_1.Controls.Add(class63_3);
		class65_1.Controls.Add(textBox_0);
		class65_1.Controls.Add(class62_1);
		class65_1.Controls.Add(class63_1);
		class65_1.Controls.Add(textBox_1);
		class65_1.Controls.Add(class62_2);
		class65_1.Controls.Add(class63_2);
		class65_1.Location = new Point(4, 105);
		class65_1.Margin = new Padding(4);
		class65_1.Name = "m_grMessage";
		class65_1.Padding = new Padding(4);
		class65_1.Size = new Size(620, 430);
		class65_1.TabIndex = 39;
		class65_1.TabStop = false;
		class65_1.Text = "Сообщение";
		class62_5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		class62_5.AutoSize = true;
		class62_5.ForeColor = Color.Red;
		class62_5.Location = new Point(471, 131);
		class62_5.Margin = new Padding(4, 0, 4, 0);
		class62_5.Name = "m_lblInvalidEmailAddress2";
		class62_5.Size = new Size(139, 16);
		class62_5.TabIndex = 77;
		class62_5.Text = "Неверный адрес эл. почты";
		class62_5.Visible = false;
		class62_5.Boolean_0 = true;
		class62_6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		class62_6.AutoSize = true;
		class62_6.ForeColor = Color.Red;
		class62_6.Location = new Point(471, 61);
		class62_6.Margin = new Padding(4, 0, 4, 0);
		class62_6.Name = "m_lblInvalidEmailAddress1";
		class62_6.Size = new Size(139, 16);
		class62_6.TabIndex = 76;
		class62_6.Text = "Неверный адрес эл. почты";
		class62_6.Visible = false;
		class62_6.Boolean_0 = true;
		pictureBox_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		pictureBox_0.Location = new Point(483, 407);
		pictureBox_0.Name = "m_picLoading";
		pictureBox_0.Size = new Size(16, 16);
		pictureBox_0.TabIndex = 75;
		pictureBox_0.TabStop = false;
		pictureBox_0.Visible = false;
		gclass3_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		gclass3_1.AutoSize = true;
		gclass3_1.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_1.Location = new Point(505, 407);
		gclass3_1.Name = "m_lnkSendTestMessage";
		gclass3_1.RightToLeft = RightToLeft.No;
		gclass3_1.Size = new Size(101, 16);
		gclass3_1.TabIndex = 16;
		gclass3_1.TabStop = true;
		gclass3_1.Text = "отправить тестовое письмо";
		gclass3_1.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		textBox_3.AcceptsReturn = true;
		textBox_3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		textBox_3.Location = new Point(187, 242);
		textBox_3.Margin = new Padding(4);
		textBox_3.Multiline = true;
		textBox_3.Name = "m_edBody";
		textBox_3.Size = new Size(424, 158);
		textBox_3.TabIndex = 15;
		class62_4.AutoSize = true;
		class62_4.Location = new Point(21, 248);
		class62_4.Margin = new Padding(4, 0, 4, 0);
		class62_4.Name = "m_lblBody";
		class62_4.Size = new Size(42, 16);
		class62_4.TabIndex = 73;
		class62_4.Text = "Текст письма:";
		class63_4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		class63_4.AutoSize = true;
		class63_4.ForeColor = SystemColors.ControlDarkDark;
		class63_4.Location = new Point(184, 407);
		class63_4.Margin = new Padding(4, 0, 4, 0);
		class63_4.Name = "m_lblBodyHint";
		class63_4.Size = new Size(152, 16);
		class63_4.TabIndex = 72;
		class63_4.Text = " Specify message body ";
		textBox_2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		textBox_2.Location = new Point(187, 172);
		textBox_2.Margin = new Padding(4);
		textBox_2.Name = "m_edSubject";
		textBox_2.Size = new Size(424, 22);
		textBox_2.TabIndex = 14;
		class62_3.AutoSize = true;
		class62_3.Location = new Point(21, 178);
		class62_3.Margin = new Padding(4, 0, 4, 0);
		class62_3.Name = "m_lblSubject";
		class62_3.Size = new Size(55, 16);
		class62_3.TabIndex = 70;
		class62_3.Text = "Тема:";
		class63_3.AutoSize = true;
		class63_3.ForeColor = SystemColors.ControlDarkDark;
		class63_3.Location = new Point(184, 201);
		class63_3.Margin = new Padding(4, 0, 4, 0);
		class63_3.Name = "m_lblSubjectHint";
		class63_3.Size = new Size(161, 16);
		class63_3.TabIndex = 69;
		class63_3.Text = " Specify message subject";
		textBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		textBox_0.Location = new Point(187, 102);
		textBox_0.Margin = new Padding(4);
		textBox_0.Name = "m_edTo";
		textBox_0.Size = new Size(424, 22);
		textBox_0.TabIndex = 13;
		class62_1.AutoSize = true;
		class62_1.Location = new Point(21, 108);
		class62_1.Margin = new Padding(4, 0, 4, 0);
		class62_1.Name = "m_lblTo";
		class62_1.Size = new Size(27, 16);
		class62_1.TabIndex = 67;
		class62_1.Text = "Кому:";
		class63_1.AutoSize = true;
		class63_1.ForeColor = SystemColors.ControlDarkDark;
		class63_1.Location = new Point(184, 131);
		class63_1.Margin = new Padding(4, 0, 4, 0);
		class63_1.Name = "m_lblToHint";
		class63_1.Size = new Size(177, 16);
		class63_1.TabIndex = 66;
		class63_1.Text = " Specify message recepient ";
		textBox_1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		textBox_1.Location = new Point(187, 32);
		textBox_1.Margin = new Padding(4);
		textBox_1.Name = "m_edFrom";
		textBox_1.Size = new Size(424, 22);
		textBox_1.TabIndex = 12;
		class62_2.AutoSize = true;
		class62_2.Location = new Point(21, 38);
		class62_2.Margin = new Padding(4, 0, 4, 0);
		class62_2.Name = "m_lblFrom";
		class62_2.Size = new Size(41, 16);
		class62_2.TabIndex = 64;
		class62_2.Text = "От кого:";
		class63_2.AutoSize = true;
		class63_2.ForeColor = SystemColors.ControlDarkDark;
		class63_2.Location = new Point(184, 61);
		class63_2.Margin = new Padding(4, 0, 4, 0);
		class63_2.Name = "m_lblFromHint";
		class63_2.Size = new Size(184, 16);
		class63_2.TabIndex = 63;
		class63_2.Text = " Specify the message sender ";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.Controls.Add(class65_1);
		base.Controls.Add(class65_0);
		GClass10_0 = gClass10_;
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(4);
		base.Name = "MailSendTaskAddEditControl";
		base.Size = new Size(630, 540);
		class65_0.ResumeLayout(performLayout: false);
		class65_0.PerformLayout();
		class65_1.ResumeLayout(performLayout: false);
		class65_1.PerformLayout();
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
	}

	private void class66_0_Click(object sender, EventArgs e)
	{
		if (DialogResult.OK == new SmtpServersDialog().ShowDialog())
		{
			Class89.eventHandler_23 = (EventHandler<EventArgs4>)Delegate.Combine(Class89.eventHandler_23, new EventHandler<EventArgs4>(method_1));
			Class89.smethod_32();
		}
	}

	private void class0_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		vmethod_2();
		method_3();
	}
}
