using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Properties;

internal sealed class TelegramSendTaskAddEditControl : Control4
{
	private sealed class Class1
	{
		public TelegramSendTaskAddEditControl control5_0;

		public object object_0;

		public EventArgs5 eventArgs5_0;

		internal void InitializeHandlers()
		{
			control5_0.AddTask(object_0, eventArgs5_0);
		}
	}

	private sealed class Class2
	{
		public string string_0;

		internal bool InitializeHandlers(KeyValuePair<int, Class110> keyValuePair_0)
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

	private Class65 mgrSettings;

	private TextBox medBotToken;

	private Class62 mlblBotToken;

	private Class63 mlblBotTokenHint;

	private GClass3 mlnkSendTestMessage;

	private TextBox medMessage;

	private Class62 mlblMessage;

	private Class63 mlblMessageHint;

	private PictureBox mpicLoading;

	private Class66 mbtnGetChats;

	private Class0 mcbChat;

	private Class62 mlblChat;

	private Class63 mlblChatHint;

	private Class62 mlblChatWarning;

	public override Size Size_0 => new Size(630, 360);

	public override GClass3 GClass3_0 => mlnkSendTestMessage;

	private string String_0 => medBotToken.Text.Trim('\r', '\n', '\t', ' ');

	public override GClass10 GClass10_0
	{
		get
		{
			return new Class176
			{
				class110_0 = ((dictionary_1.ContainsKey(mcbChat.SelectedIndex) ? true : false) ? dictionary_1[mcbChat.SelectedIndex] : null),
				string_2 = String_0,
				string_3 = medMessage.Text
			};
		}
		set
		{
			Class176 @class = (Class176)value;
			if (@class.class110_0 != null)
			{
				EditTask(new Class110[1] { @class.class110_0 });
			}
			medBotToken.Text = @class.string_2;
			medMessage.Text = @class.string_3;
		}
	}

	public override void UpdateTaskType(GEnum2 genum2_0)
	{
		medMessage.Text = dictionary_0[genum2_0][0] + "\r\n\r\n" + dictionary_0[genum2_0][1];
	}

	private void AddTask(object sender, EventArgs5 e)
	{
		Class1 @class = new Class1();
		@class.control5_0 = this;
		@class.object_0 = sender;
		@class.eventArgs5_0 = e;
		Class89.eventHandler_30 = (EventHandler<EventArgs5>)Delegate.Remove(Class89.eventHandler_30, new EventHandler<EventArgs5>(AddTask));
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.InitializeHandlers));
			return;
		}
		SetEditMode(bool_1: true);
		mlblChatWarning.Text = @class.eventArgs5_0.String_0;
		mlblChatWarning.Visible = !@class.eventArgs5_0.Boolean_0;
		EditTask(@class.eventArgs5_0.Class110_0);
	}

	private void EditTask(Class110[] class110_0)
	{
		Class2 @class = new Class2();
		if (class110_0.IsNullOrEmpty())
		{
			return;
		}
		@class.string_0 = ((mcbChat.SelectedIndex >= 0) ? dictionary_1[mcbChat.SelectedIndex].String_0 : "");
		mcbChat.Items.Clear();
		dictionary_1.Clear();
		foreach (Class110 class2 in class110_0)
		{
			int key = mcbChat.Items.Add(class2.String_1 + " (" + class2.String_0 + ")");
			dictionary_1.Add(key, class2);
		}
		if (!string.IsNullOrEmpty(@class.string_0))
		{
			int key2 = dictionary_1.FirstOrDefault(@class.InitializeHandlers).Key;
			if (key2 >= 0)
			{
				mcbChat.SelectedIndex = key2;
			}
		}
		if (mcbChat.SelectedIndex < 0 && mcbChat.Items.Count > 0)
		{
			mcbChat.SelectedIndex = 0;
		}
	}

	protected override void OnFormClosing()
	{
		InitializeComponent();
		new ToolTip().SetToolTip(mbtnGetChats, "Click to get available chats from Telegram");
		mpicLoading.Image = ((Class163.Class163_0.Boolean_0 ? true : false) ? Resources.wait_16_dark : Resources.wait_16);
	}

	protected override void InitializeFormPosition()
	{
		mbtnGetChats.Click += mbtnGetChats_Click;
		medBotToken.TextChanged += medBotToken_TextChanged;
	}

	public override void SetEditMode(bool bool_1)
	{
		mpicLoading.Visible = !bool_1;
		mlblChat.Enabled = bool_1;
		mlblChatHint.Enabled = bool_1;
		mcbChat.Enabled = bool_1;
		mbtnGetChats.Enabled = bool_1;
		mlblBotToken.Enabled = bool_1;
		mlblBotTokenHint.Enabled = bool_1;
		medBotToken.Enabled = bool_1;
		mlblMessage.Enabled = bool_1;
		mlblMessageHint.Enabled = bool_1;
		medMessage.Enabled = bool_1;
		mlnkSendTestMessage.Enabled = bool_1;
	}

	protected override void AdjustFormSize()
	{
		mbtnGetChats.Enabled = !string.IsNullOrEmpty(String_0);
		base.Boolean_0 = !string.IsNullOrEmpty(mcbChat.Text) && !string.IsNullOrEmpty(String_0) && !string.IsNullOrEmpty(medMessage.Text) && ValidateInput();
		mlnkSendTestMessage.Enabled = base.Boolean_0;
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
		Class176 gClass10_ = new Class176();
		mgrSettings = new Class65();
		mlblChatWarning = new Class62();
		mbtnGetChats = new Class66();
		mcbChat = new Class0();
		mlblChat = new Class62();
		mlblChatHint = new Class63();
		mpicLoading = new PictureBox();
		mlnkSendTestMessage = new GClass3();
		medMessage = new TextBox();
		mlblMessage = new Class62();
		mlblMessageHint = new Class63();
		medBotToken = new TextBox();
		mlblBotToken = new Class62();
		mlblBotTokenHint = new Class63();
		mgrSettings.SuspendLayout();
		((ISupportInitialize)mpicLoading).BeginInit();
		SuspendLayout();
		mgrSettings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		mgrSettings.Controls.Add(mlblChatWarning);
		mgrSettings.Controls.Add(mbtnGetChats);
		mgrSettings.Controls.Add(mcbChat);
		mgrSettings.Controls.Add(mlblChat);
		mgrSettings.Controls.Add(mlblChatHint);
		mgrSettings.Controls.Add(mpicLoading);
		mgrSettings.Controls.Add(mlnkSendTestMessage);
		mgrSettings.Controls.Add(medMessage);
		mgrSettings.Controls.Add(mlblMessage);
		mgrSettings.Controls.Add(mlblMessageHint);
		mgrSettings.Controls.Add(medBotToken);
		mgrSettings.Controls.Add(mlblBotToken);
		mgrSettings.Controls.Add(mlblBotTokenHint);
		mgrSettings.Location = new Point(4, 4);
		mgrSettings.Margin = new Padding(4);
		mgrSettings.Name = "m_grSettings";
		mgrSettings.Padding = new Padding(4);
		mgrSettings.Size = new Size(605, 427);
		mgrSettings.TabIndex = 39;
		mgrSettings.TabStop = false;
		mgrSettings.Text = "Settings";
		mlblChatWarning.AutoSize = true;
		mlblChatWarning.ForeColor = Color.Red;
		mlblChatWarning.Location = new Point(184, 86);
		mlblChatWarning.Margin = new Padding(4, 0, 4, 0);
		mlblChatWarning.Name = "m_lblChatWarning";
		mlblChatWarning.Size = new Size(92, 16);
		mlblChatWarning.TabIndex = 82;
		mlblChatWarning.Text = "{chat-warning}";
		mlblChatWarning.Boolean_0 = true;
		mlblChatWarning.Visible = false;
		mbtnGetChats.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		mbtnGetChats.Image = Resources.ref_16;
		mbtnGetChats.Location = new Point(571, 105);
		mbtnGetChats.Name = "m_btnGetChats";
		mbtnGetChats.Size = new Size(25, 25);
		mbtnGetChats.TabIndex = 81;
		mbtnGetChats.UseVisualStyleBackColor = true;
		mcbChat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		mcbChat.DropDownStyle = ComboBoxStyle.DropDownList;
		mcbChat.FormattingEnabled = true;
		mcbChat.Location = new Point(187, 105);
		mcbChat.Name = "m_cbChat";
		mcbChat.Size = new Size(378, 24);
		mcbChat.TabIndex = 78;
		mlblChat.AutoSize = true;
		mlblChat.Location = new Point(21, 108);
		mlblChat.Margin = new Padding(4, 0, 4, 0);
		mlblChat.Name = "m_lblChat";
		mlblChat.Size = new Size(37, 16);
		mlblChat.TabIndex = 80;
		mlblChat.Text = "Chat:";
		mlblChatHint.AutoSize = true;
		mlblChatHint.ForeColor = SystemColors.ControlDarkDark;
		mlblChatHint.Location = new Point(184, 135);
		mlblChatHint.Margin = new Padding(4, 0, 4, 0);
		mlblChatHint.Name = "m_lblChatHint";
		mlblChatHint.Size = new Size(324, 16);
		mlblChatHint.TabIndex = 79;
		mlblChatHint.Text = "The chat where you want the bot to send messages to";
		mpicLoading.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mpicLoading.Location = new Point(452, 407);
		mpicLoading.Name = "m_picLoading";
		mpicLoading.Size = new Size(16, 16);
		mpicLoading.TabIndex = 75;
		mpicLoading.TabStop = false;
		mpicLoading.Visible = false;
		mlnkSendTestMessage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mlnkSendTestMessage.AutoSize = true;
		mlnkSendTestMessage.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkSendTestMessage.Location = new Point(474, 407);
		mlnkSendTestMessage.Name = "m_lnkSendTestMessage";
		mlnkSendTestMessage.RightToLeft = RightToLeft.No;
		mlnkSendTestMessage.Size = new Size(121, 16);
		mlnkSendTestMessage.TabIndex = 16;
		mlnkSendTestMessage.TabStop = true;
		mlnkSendTestMessage.Text = "send test message";
		mlnkSendTestMessage.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		medMessage.AcceptsReturn = true;
		medMessage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		medMessage.Location = new Point(187, 178);
		medMessage.Margin = new Padding(4);
		medMessage.Multiline = true;
		medMessage.Name = "m_edMessage";
		medMessage.Size = new Size(409, 225);
		medMessage.TabIndex = 15;
		mlblMessage.AutoSize = true;
		mlblMessage.Location = new Point(21, 178);
		mlblMessage.Margin = new Padding(4, 0, 4, 0);
		mlblMessage.Name = "m_lblMessage";
		mlblMessage.Size = new Size(42, 16);
		mlblMessage.TabIndex = 73;
		mlblMessage.Text = "Body:";
		mlblMessageHint.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		mlblMessageHint.AutoSize = true;
		mlblMessageHint.ForeColor = SystemColors.ControlDarkDark;
		mlblMessageHint.Location = new Point(184, 407);
		mlblMessageHint.Margin = new Padding(4, 0, 4, 0);
		mlblMessageHint.Name = "m_lblMessageHint";
		mlblMessageHint.Size = new Size(152, 16);
		mlblMessageHint.TabIndex = 72;
		mlblMessageHint.Text = " Specify message body ";
		medBotToken.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		medBotToken.Location = new Point(187, 32);
		medBotToken.Margin = new Padding(4);
		medBotToken.Name = "m_edBotToken";
		medBotToken.Size = new Size(409, 22);
		medBotToken.TabIndex = 12;
		mlblBotToken.AutoSize = true;
		mlblBotToken.Location = new Point(21, 38);
		mlblBotToken.Margin = new Padding(4, 0, 4, 0);
		mlblBotToken.Name = "m_lblBotToken";
		mlblBotToken.Size = new Size(66, 16);
		mlblBotToken.TabIndex = 64;
		mlblBotToken.Text = "Bot token:";
		mlblBotTokenHint.AutoSize = true;
		mlblBotTokenHint.ForeColor = SystemColors.ControlDarkDark;
		mlblBotTokenHint.Location = new Point(184, 61);
		mlblBotTokenHint.Margin = new Padding(4, 0, 4, 0);
		mlblBotTokenHint.Name = "m_lblBotTokenHint";
		mlblBotTokenHint.Size = new Size(413, 16);
		mlblBotTokenHint.TabIndex = 63;
		mlblBotTokenHint.Text = "Unique identifier for your bot, provided by @BotFather after bot creation";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.Controls.Add(mgrSettings);
		GClass10_0 = gClass10_;
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(4);
		base.Name = "TelegramSendTaskAddEditControl";
		base.Size = new Size(613, 435);
		mgrSettings.ResumeLayout(performLayout: false);
		mgrSettings.PerformLayout();
		((ISupportInitialize)mpicLoading).EndInit();
		ResumeLayout(performLayout: false);
	}

	private void mbtnGetChats_Click(object sender, EventArgs e)
	{
		SetEditMode(bool_1: false);
		Class89.eventHandler_30 = (EventHandler<EventArgs5>)Delegate.Combine(Class89.eventHandler_30, new EventHandler<EventArgs5>(AddTask));
		Class89.smethod_42(String_0);
	}

	private void medBotToken_TextChanged(object sender, EventArgs e)
	{
		AdjustFormSize();
	}
}
