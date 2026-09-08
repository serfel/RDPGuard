using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Properties;

internal sealed class Control5 : Control4
{
	private sealed class Class1
	{
		public Control5 control5_0;

		public object object_0;

		public EventArgs5 eventArgs5_0;

		internal void method_0()
		{
			control5_0.method_1(object_0, eventArgs5_0);
		}
	}

	private sealed class Class2
	{
		public string string_0;

		internal bool method_0(KeyValuePair<int, Class110> keyValuePair_0)
		{
			return keyValuePair_0.Value.String_0 == string_0;
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

	private readonly Dictionary<int, Class110> dictionary_1 = new Dictionary<int, Class110>();

	private IContainer icontainer_0;

	private Class65 class65_0;

	private TextBox textBox_0;

	private Class62 class62_0;

	private Class63 class63_0;

	private GClass3 gclass3_1;

	private TextBox textBox_1;

	private Class62 class62_1;

	private Class63 class63_1;

	private PictureBox pictureBox_0;

	private Class66 class66_0;

	private Class0 class0_0;

	private Class62 class62_2;

	private Class63 class63_2;

	private Class62 class62_3;

	public override Size Size_0 => new Size(630, 360);

	public override GClass3 GClass3_0 => gclass3_1;

	private string String_0 => textBox_0.Text.Trim('\r', '\n', '\t', ' ');

	public override GClass10 GClass10_0
	{
		get
		{
			return new Class176
			{
				class110_0 = ((dictionary_1.ContainsKey(class0_0.SelectedIndex) ? true : false) ? dictionary_1[class0_0.SelectedIndex] : null),
				string_2 = String_0,
				string_3 = textBox_1.Text
			};
		}
		set
		{
			Class176 @class = (Class176)value;
			if (@class.class110_0 != null)
			{
				method_2(new Class110[1] { @class.class110_0 });
			}
			textBox_0.Text = @class.string_2;
			textBox_1.Text = @class.string_3;
		}
	}

	public override void vmethod_3(GEnum2 genum2_0)
	{
		textBox_1.Text = dictionary_0[genum2_0][0] + "\r\n\r\n" + dictionary_0[genum2_0][1];
	}

	private void method_1(object sender, EventArgs5 e)
	{
		Class1 @class = new Class1();
		@class.control5_0 = this;
		@class.object_0 = sender;
		@class.eventArgs5_0 = e;
		Class89.eventHandler_30 = (EventHandler<EventArgs5>)Delegate.Remove(Class89.eventHandler_30, new EventHandler<EventArgs5>(method_1));
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
			return;
		}
		vmethod_5(bool_1: true);
		class62_3.Text = @class.eventArgs5_0.String_0;
		class62_3.Visible = !@class.eventArgs5_0.Boolean_0;
		method_2(@class.eventArgs5_0.Class110_0);
	}

	private void method_2(Class110[] class110_0)
	{
		Class2 @class = new Class2();
		if (class110_0.IsNullOrEmpty())
		{
			return;
		}
		@class.string_0 = ((class0_0.SelectedIndex >= 0) ? dictionary_1[class0_0.SelectedIndex].String_0 : "");
		class0_0.Items.Clear();
		dictionary_1.Clear();
		foreach (Class110 class2 in class110_0)
		{
			int key = class0_0.Items.Add(class2.String_1 + " (" + class2.String_0 + ")");
			dictionary_1.Add(key, class2);
		}
		if (!string.IsNullOrEmpty(@class.string_0))
		{
			int key2 = dictionary_1.FirstOrDefault(@class.method_0).Key;
			if (key2 >= 0)
			{
				class0_0.SelectedIndex = key2;
			}
		}
		if (class0_0.SelectedIndex < 0 && class0_0.Items.Count > 0)
		{
			class0_0.SelectedIndex = 0;
		}
	}

	protected override void vmethod_0()
	{
		method_3();
		new ToolTip().SetToolTip(class66_0, "Click to get available chats from Telegram");
		pictureBox_0.Image = ((Class163.Class163_0.Boolean_0 ? true : false) ? Resources.wait_16_dark : Resources.wait_16);
	}

	protected override void vmethod_1()
	{
		class66_0.Click += class66_0_Click;
		textBox_0.TextChanged += textBox_0_TextChanged;
	}

	public override void vmethod_5(bool bool_1)
	{
		pictureBox_0.Visible = !bool_1;
		class62_2.Enabled = bool_1;
		class63_2.Enabled = bool_1;
		class0_0.Enabled = bool_1;
		class66_0.Enabled = bool_1;
		class62_0.Enabled = bool_1;
		class63_0.Enabled = bool_1;
		textBox_0.Enabled = bool_1;
		class62_1.Enabled = bool_1;
		class63_1.Enabled = bool_1;
		textBox_1.Enabled = bool_1;
		gclass3_1.Enabled = bool_1;
	}

	protected override void vmethod_2()
	{
		class66_0.Enabled = !string.IsNullOrEmpty(String_0);
		base.Boolean_0 = !string.IsNullOrEmpty(class0_0.Text) && !string.IsNullOrEmpty(String_0) && !string.IsNullOrEmpty(textBox_1.Text) && vmethod_4();
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

	private void method_3()
	{
		Class176 gClass10_ = new Class176();
		class65_0 = new Class65();
		class62_3 = new Class62();
		class66_0 = new Class66();
		class0_0 = new Class0();
		class62_2 = new Class62();
		class63_2 = new Class63();
		pictureBox_0 = new PictureBox();
		gclass3_1 = new GClass3();
		textBox_1 = new TextBox();
		class62_1 = new Class62();
		class63_1 = new Class63();
		textBox_0 = new TextBox();
		class62_0 = new Class62();
		class63_0 = new Class63();
		class65_0.SuspendLayout();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		class65_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		class65_0.Controls.Add(class62_3);
		class65_0.Controls.Add(class66_0);
		class65_0.Controls.Add(class0_0);
		class65_0.Controls.Add(class62_2);
		class65_0.Controls.Add(class63_2);
		class65_0.Controls.Add(pictureBox_0);
		class65_0.Controls.Add(gclass3_1);
		class65_0.Controls.Add(textBox_1);
		class65_0.Controls.Add(class62_1);
		class65_0.Controls.Add(class63_1);
		class65_0.Controls.Add(textBox_0);
		class65_0.Controls.Add(class62_0);
		class65_0.Controls.Add(class63_0);
		class65_0.Location = new Point(4, 4);
		class65_0.Margin = new Padding(4);
		class65_0.Name = "m_grSettings";
		class65_0.Padding = new Padding(4);
		class65_0.Size = new Size(605, 427);
		class65_0.TabIndex = 39;
		class65_0.TabStop = false;
		class65_0.Text = "Settings";
		class62_3.AutoSize = true;
		class62_3.ForeColor = Color.Red;
		class62_3.Location = new Point(184, 86);
		class62_3.Margin = new Padding(4, 0, 4, 0);
		class62_3.Name = "m_lblChatWarning";
		class62_3.Size = new Size(92, 16);
		class62_3.TabIndex = 82;
		class62_3.Text = "{chat-warning}";
		class62_3.Boolean_0 = true;
		class62_3.Visible = false;
		class66_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		class66_0.Image = Resources.ref_16;
		class66_0.Location = new Point(571, 105);
		class66_0.Name = "m_btnGetChats";
		class66_0.Size = new Size(25, 25);
		class66_0.TabIndex = 81;
		class66_0.UseVisualStyleBackColor = true;
		class0_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		class0_0.DropDownStyle = ComboBoxStyle.DropDownList;
		class0_0.FormattingEnabled = true;
		class0_0.Location = new Point(187, 105);
		class0_0.Name = "m_cbChat";
		class0_0.Size = new Size(378, 24);
		class0_0.TabIndex = 78;
		class62_2.AutoSize = true;
		class62_2.Location = new Point(21, 108);
		class62_2.Margin = new Padding(4, 0, 4, 0);
		class62_2.Name = "m_lblChat";
		class62_2.Size = new Size(37, 16);
		class62_2.TabIndex = 80;
		class62_2.Text = "Chat:";
		class63_2.AutoSize = true;
		class63_2.ForeColor = SystemColors.ControlDarkDark;
		class63_2.Location = new Point(184, 135);
		class63_2.Margin = new Padding(4, 0, 4, 0);
		class63_2.Name = "m_lblChatHint";
		class63_2.Size = new Size(324, 16);
		class63_2.TabIndex = 79;
		class63_2.Text = "The chat where you want the bot to send messages to";
		pictureBox_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		pictureBox_0.Location = new Point(452, 407);
		pictureBox_0.Name = "m_picLoading";
		pictureBox_0.Size = new Size(16, 16);
		pictureBox_0.TabIndex = 75;
		pictureBox_0.TabStop = false;
		pictureBox_0.Visible = false;
		gclass3_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		gclass3_1.AutoSize = true;
		gclass3_1.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_1.Location = new Point(474, 407);
		gclass3_1.Name = "m_lnkSendTestMessage";
		gclass3_1.RightToLeft = RightToLeft.No;
		gclass3_1.Size = new Size(121, 16);
		gclass3_1.TabIndex = 16;
		gclass3_1.TabStop = true;
		gclass3_1.Text = "send test message";
		gclass3_1.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		textBox_1.AcceptsReturn = true;
		textBox_1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		textBox_1.Location = new Point(187, 178);
		textBox_1.Margin = new Padding(4);
		textBox_1.Multiline = true;
		textBox_1.Name = "m_edMessage";
		textBox_1.Size = new Size(409, 225);
		textBox_1.TabIndex = 15;
		class62_1.AutoSize = true;
		class62_1.Location = new Point(21, 178);
		class62_1.Margin = new Padding(4, 0, 4, 0);
		class62_1.Name = "m_lblMessage";
		class62_1.Size = new Size(42, 16);
		class62_1.TabIndex = 73;
		class62_1.Text = "Body:";
		class63_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		class63_1.AutoSize = true;
		class63_1.ForeColor = SystemColors.ControlDarkDark;
		class63_1.Location = new Point(184, 407);
		class63_1.Margin = new Padding(4, 0, 4, 0);
		class63_1.Name = "m_lblMessageHint";
		class63_1.Size = new Size(152, 16);
		class63_1.TabIndex = 72;
		class63_1.Text = " Specify message body ";
		textBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		textBox_0.Location = new Point(187, 32);
		textBox_0.Margin = new Padding(4);
		textBox_0.Name = "m_edBotToken";
		textBox_0.Size = new Size(409, 22);
		textBox_0.TabIndex = 12;
		class62_0.AutoSize = true;
		class62_0.Location = new Point(21, 38);
		class62_0.Margin = new Padding(4, 0, 4, 0);
		class62_0.Name = "m_lblBotToken";
		class62_0.Size = new Size(66, 16);
		class62_0.TabIndex = 64;
		class62_0.Text = "Bot token:";
		class63_0.AutoSize = true;
		class63_0.ForeColor = SystemColors.ControlDarkDark;
		class63_0.Location = new Point(184, 61);
		class63_0.Margin = new Padding(4, 0, 4, 0);
		class63_0.Name = "m_lblBotTokenHint";
		class63_0.Size = new Size(413, 16);
		class63_0.TabIndex = 63;
		class63_0.Text = "Unique identifier for your bot, provided by @BotFather after bot creation";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.Controls.Add(class65_0);
		GClass10_0 = gClass10_;
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(4);
		base.Name = "TelegramSendTaskAddEditControl";
		base.Size = new Size(613, 435);
		class65_0.ResumeLayout(performLayout: false);
		class65_0.PerformLayout();
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
	}

	private void class66_0_Click(object sender, EventArgs e)
	{
		vmethod_5(bool_1: false);
		Class89.eventHandler_30 = (EventHandler<EventArgs5>)Delegate.Combine(Class89.eventHandler_30, new EventHandler<EventArgs5>(method_1));
		Class89.smethod_42(String_0);
	}

	private void textBox_0_TextChanged(object sender, EventArgs e)
	{
		vmethod_2();
	}
}
