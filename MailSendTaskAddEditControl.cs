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

		internal void InitializeHandlers()
		{
			control9_0.AddTask(object_0, eventArgs4_0);
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

	private Class65 mgrbServer;

	private Class0 mcbSmtpServers;

	private Class62 mlblServer;

	private Class63 mlblServerHint;

	private Class65 mgrMessage;

	private TextBox medTo;

	private Class62 mlblTo;

	private Class63 mlblToHint;

	private TextBox medFrom;

	private Class62 mlblFrom;

	private Class63 mlblFromHint;

	private TextBox medSubject;

	private Class62 mlblSubject;

	private Class63 mlblSubjectHint;

	private GClass3 mlnkSendTestMessage;

	private TextBox medBody;

	private Class62 mlblBody;

	private Class63 mlblBodyHint;

	private PictureBox mpicLoading;

	private Class62 mlblInvalidEmailAddress2;

	private Class62 mlblInvalidEmailAddress1;

	private Class66 mbtnSmtpServersAddEdit;

	public override Size Size_0 => new Size(630, 540);

	public override GClass3 GClass3_0 => mlnkSendTestMessage;

	public override GClass10 GClass10_0
	{
		get
		{
			return new Class175
			{
				string_2 = string_0,
				string_3 = medFrom.Text,
				string_4 = string.Join(", ", medTo.Text.smethod_7()),
				string_5 = medSubject.Text,
				string_6 = medBody.Text
			};
		}
		set
		{
			Class175 @class = value as Class175;
			string_0 = @class.string_2;
			EditTask();
			medFrom.Text = @class.string_3;
			medTo.Text = @class.string_4;
			medSubject.Text = @class.string_5;
			medBody.Text = @class.string_6;
		}
	}

	public override void UpdateTaskType(GEnum2 genum2_0)
	{
		medSubject.Text = dictionary_0[genum2_0][0];
		medBody.Text = dictionary_0[genum2_0][1];
	}

	public override bool vInitializeComponent()
	{
		bool flag = Class71.smethod_0(medFrom.Text);
		bool flag2 = Class71.smethod_0(medTo.Text);
		mlblInvalidEmailAddress1.Visible = !flag;
		mlblInvalidEmailAddress2.Visible = !flag2;
		return flag && flag2;
	}

	private void AddTask(object sender, EventArgs4 e)
	{
		Class68 @class = new Class68();
		@class.control9_0 = this;
		@class.object_0 = sender;
		@class.eventArgs4_0 = e;
		Class89.eventHandler_23 = (EventHandler<EventArgs4>)Delegate.Remove(Class89.eventHandler_23, new EventHandler<EventArgs4>(AddTask));
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.InitializeHandlers));
			return;
		}
		mcbSmtpServers.Items.Clear();
		dictionary_1.Clear();
		Class109[] class109_ = @class.eventArgs4_0.class109_0;
		Class109[] array = class109_;
		foreach (Class109 class2 in array)
		{
			int key = mcbSmtpServers.Items.Add(class2.ToString());
			dictionary_1.Add(key, class2.String_0);
		}
		EditTask();
		AdjustFormSize();
	}

	private void EditTask()
	{
		mcbSmtpServers.SelectedIndex = -1;
		using Dictionary<int, string>.KeyCollection.Enumerator enumerator = dictionary_1.Keys.GetEnumerator();
		while (enumerator.MoveNext() ? true : false)
		{
			int current = enumerator.Current;
			if (string_0 == dictionary_1[current])
			{
				mcbSmtpServers.SelectedIndex = current;
				break;
			}
		}
	}

	private void RemoveTask()
	{
		if (dictionary_1.Count > 0 && mcbSmtpServers.SelectedIndex >= 0)
		{
			string_0 = dictionary_1[mcbSmtpServers.SelectedIndex];
		}
	}

	protected override void OnFormClosing()
	{
		InitializeComponent();
		Class89.eventHandler_23 = (EventHandler<EventArgs4>)Delegate.Combine(Class89.eventHandler_23, new EventHandler<EventArgs4>(AddTask));
		Class89.smethod_32();
		new ToolTip().SetToolTip(mbtnSmtpServersAddEdit, "Click to add/edit SMTP servers");
		mpicLoading.Image = ((Class163.Class163_0.Boolean_0 ? true : false) ? Resources.wait_16_dark : Resources.wait_16);
	}

	protected override void InitializeFormPosition()
	{
		mbtnSmtpServersAddEdit.Click += mbtnSmtpServersAddEdit_Click;
		mcbSmtpServers.SelectedIndexChanged += class0_0_SelectedIndexChanged;
	}

	public override void SetEditMode(bool bool_1)
	{
		mpicLoading.Visible = !bool_1;
		mlblServer.Enabled = bool_1;
		mlblServerHint.Enabled = bool_1;
		mcbSmtpServers.Enabled = bool_1;
		mbtnSmtpServersAddEdit.Enabled = bool_1;
		mlblFrom.Enabled = bool_1;
		mlblFromHint.Enabled = bool_1;
		medFrom.Enabled = bool_1;
		mlblTo.Enabled = bool_1;
		mlblToHint.Enabled = bool_1;
		medTo.Enabled = bool_1;
		mlblSubject.Enabled = bool_1;
		mlblSubjectHint.Enabled = bool_1;
		medSubject.Enabled = bool_1;
		mlblBody.Enabled = bool_1;
		mlblBodyHint.Enabled = bool_1;
		medBody.Enabled = bool_1;
		mlnkSendTestMessage.Enabled = bool_1;
	}

	protected override void AdjustFormSize()
	{
		base.Boolean_0 = !string.IsNullOrEmpty(mcbSmtpServers.Text) && !string.IsNullOrEmpty(medFrom.Text) && !string.IsNullOrEmpty(medTo.Text) && !string.IsNullOrEmpty(medSubject.Text) && !string.IsNullOrEmpty(medBody.Text) && vInitializeComponent();
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
		Class175 gClass10_ = new Class175();
		mgrbServer = new Class65();
		mbtnSmtpServersAddEdit = new Class66();
		mcbSmtpServers = new Class0();
		mlblServer = new Class62();
		mlblServerHint = new Class63();
		mgrMessage = new Class65();
		mlblInvalidEmailAddress2 = new Class62();
		mlblInvalidEmailAddress1 = new Class62();
		mpicLoading = new PictureBox();
		mlnkSendTestMessage = new GClass3();
		medBody = new TextBox();
		mlblBody = new Class62();
		mlblBodyHint = new Class63();
		medSubject = new TextBox();
		mlblSubject = new Class62();
		mlblSubjectHint = new Class63();
		medTo = new TextBox();
		mlblTo = new Class62();
		mlblToHint = new Class63();
		medFrom = new TextBox();
		mlblFrom = new Class62();
		mlblFromHint = new Class63();
		mgrbServer.SuspendLayout();
		mgrMessage.SuspendLayout();
		((ISupportInitialize)mpicLoading).BeginInit();
		SuspendLayout();
		mgrbServer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		mgrbServer.Controls.Add(mbtnSmtpServersAddEdit);
		mgrbServer.Controls.Add(mcbSmtpServers);
		mgrbServer.Controls.Add(mlblServer);
		mgrbServer.Controls.Add(mlblServerHint);
		mgrbServer.Location = new Point(4, 4);
		mgrbServer.Margin = new Padding(4);
		mgrbServer.Name = "m_grbServer";
		mgrbServer.Padding = new Padding(4);
		mgrbServer.Size = new Size(622, 93);
		mgrbServer.TabIndex = 38;
		mgrbServer.TabStop = false;
		mgrbServer.Text = "SMTP Server";
		mbtnSmtpServersAddEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		mbtnSmtpServersAddEdit.Image = Resources.edit_16;
		mbtnSmtpServersAddEdit.Location = new Point(588, 31);
		mbtnSmtpServersAddEdit.Name = "m_btnSmtpServersAddEdit";
		mbtnSmtpServersAddEdit.Size = new Size(25, 25);
		mbtnSmtpServersAddEdit.TabIndex = 65;
		mbtnSmtpServersAddEdit.UseVisualStyleBackColor = true;
		mcbSmtpServers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		mcbSmtpServers.DropDownStyle = ComboBoxStyle.DropDownList;
		mcbSmtpServers.FormattingEnabled = true;
		mcbSmtpServers.Location = new Point(187, 31);
		mcbSmtpServers.Name = "m_cbSmtpServers";
		mcbSmtpServers.Size = new Size(395, 24);
		mcbSmtpServers.TabIndex = 10;
		mlblServer.AutoSize = true;
		mlblServer.Location = new Point(21, 34);
		mlblServer.Margin = new Padding(4, 0, 4, 0);
		mlblServer.Name = "m_lblServer";
		mlblServer.Size = new Size(50, 16);
		mlblServer.TabIndex = 64;
		mlblServer.Text = "Server:";
		mlblServerHint.AutoSize = true;
		mlblServerHint.ForeColor = SystemColors.ControlDarkDark;
		mlblServerHint.Location = new Point(184, 61);
		mlblServerHint.Margin = new Padding(4, 0, 4, 0);
		mlblServerHint.Name = "m_lblServerHint";
		mlblServerHint.Size = new Size(321, 16);
		mlblServerHint.TabIndex = 63;
		mlblServerHint.Text = " Select SMTP server from the list or add the new one. ";
		mgrMessage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		mgrMessage.Controls.Add(mlblInvalidEmailAddress2);
		mgrMessage.Controls.Add(mlblInvalidEmailAddress1);
		mgrMessage.Controls.Add(mpicLoading);
		mgrMessage.Controls.Add(mlnkSendTestMessage);
		mgrMessage.Controls.Add(medBody);
		mgrMessage.Controls.Add(mlblBody);
		mgrMessage.Controls.Add(mlblBodyHint);
		mgrMessage.Controls.Add(medSubject);
		mgrMessage.Controls.Add(mlblSubject);
		mgrMessage.Controls.Add(mlblSubjectHint);
		mgrMessage.Controls.Add(medTo);
		mgrMessage.Controls.Add(mlblTo);
		mgrMessage.Controls.Add(mlblToHint);
		mgrMessage.Controls.Add(medFrom);
		mgrMessage.Controls.Add(mlblFrom);
		mgrMessage.Controls.Add(mlblFromHint);
		mgrMessage.Location = new Point(4, 105);
		mgrMessage.Margin = new Padding(4);
		mgrMessage.Name = "m_grMessage";
		mgrMessage.Padding = new Padding(4);
		mgrMessage.Size = new Size(620, 430);
		mgrMessage.TabIndex = 39;
		mgrMessage.TabStop = false;
		mgrMessage.Text = "Message";
		mlblInvalidEmailAddress2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		mlblInvalidEmailAddress2.AutoSize = true;
		mlblInvalidEmailAddress2.ForeColor = Color.Red;
		mlblInvalidEmailAddress2.Location = new Point(471, 131);
		mlblInvalidEmailAddress2.Margin = new Padding(4, 0, 4, 0);
		mlblInvalidEmailAddress2.Name = "m_lblInvalidEmailAddress2";
		mlblInvalidEmailAddress2.Size = new Size(139, 16);
		mlblInvalidEmailAddress2.TabIndex = 77;
		mlblInvalidEmailAddress2.Text = "Invalid e-mail address";
		mlblInvalidEmailAddress2.Visible = false;
		mlblInvalidEmailAddress2.Boolean_0 = true;
		mlblInvalidEmailAddress1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		mlblInvalidEmailAddress1.AutoSize = true;
		mlblInvalidEmailAddress1.ForeColor = Color.Red;
		mlblInvalidEmailAddress1.Location = new Point(471, 61);
		mlblInvalidEmailAddress1.Margin = new Padding(4, 0, 4, 0);
		mlblInvalidEmailAddress1.Name = "m_lblInvalidEmailAddress1";
		mlblInvalidEmailAddress1.Size = new Size(139, 16);
		mlblInvalidEmailAddress1.TabIndex = 76;
		mlblInvalidEmailAddress1.Text = "Invalid e-mail address";
		mlblInvalidEmailAddress1.Visible = false;
		mlblInvalidEmailAddress1.Boolean_0 = true;
		mpicLoading.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mpicLoading.Location = new Point(483, 407);
		mpicLoading.Name = "m_picLoading";
		mpicLoading.Size = new Size(16, 16);
		mpicLoading.TabIndex = 75;
		mpicLoading.TabStop = false;
		mpicLoading.Visible = false;
		mlnkSendTestMessage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mlnkSendTestMessage.AutoSize = true;
		mlnkSendTestMessage.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkSendTestMessage.Location = new Point(505, 407);
		mlnkSendTestMessage.Name = "m_lnkSendTestMessage";
		mlnkSendTestMessage.RightToLeft = RightToLeft.No;
		mlnkSendTestMessage.Size = new Size(101, 16);
		mlnkSendTestMessage.TabIndex = 16;
		mlnkSendTestMessage.TabStop = true;
		mlnkSendTestMessage.Text = "send test e-mail";
		mlnkSendTestMessage.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		medBody.AcceptsReturn = true;
		medBody.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		medBody.Location = new Point(187, 242);
		medBody.Margin = new Padding(4);
		medBody.Multiline = true;
		medBody.Name = "m_edBody";
		medBody.Size = new Size(424, 158);
		medBody.TabIndex = 15;
		mlblBody.AutoSize = true;
		mlblBody.Location = new Point(21, 248);
		mlblBody.Margin = new Padding(4, 0, 4, 0);
		mlblBody.Name = "m_lblBody";
		mlblBody.Size = new Size(42, 16);
		mlblBody.TabIndex = 73;
		mlblBody.Text = "Body:";
		mlblBodyHint.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		mlblBodyHint.AutoSize = true;
		mlblBodyHint.ForeColor = SystemColors.ControlDarkDark;
		mlblBodyHint.Location = new Point(184, 407);
		mlblBodyHint.Margin = new Padding(4, 0, 4, 0);
		mlblBodyHint.Name = "m_lblBodyHint";
		mlblBodyHint.Size = new Size(152, 16);
		mlblBodyHint.TabIndex = 72;
		mlblBodyHint.Text = " Specify message body ";
		medSubject.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		medSubject.Location = new Point(187, 172);
		medSubject.Margin = new Padding(4);
		medSubject.Name = "m_edSubject";
		medSubject.Size = new Size(424, 22);
		medSubject.TabIndex = 14;
		mlblSubject.AutoSize = true;
		mlblSubject.Location = new Point(21, 178);
		mlblSubject.Margin = new Padding(4, 0, 4, 0);
		mlblSubject.Name = "m_lblSubject";
		mlblSubject.Size = new Size(55, 16);
		mlblSubject.TabIndex = 70;
		mlblSubject.Text = "Subject:";
		mlblSubjectHint.AutoSize = true;
		mlblSubjectHint.ForeColor = SystemColors.ControlDarkDark;
		mlblSubjectHint.Location = new Point(184, 201);
		mlblSubjectHint.Margin = new Padding(4, 0, 4, 0);
		mlblSubjectHint.Name = "m_lblSubjectHint";
		mlblSubjectHint.Size = new Size(161, 16);
		mlblSubjectHint.TabIndex = 69;
		mlblSubjectHint.Text = " Specify message subject";
		medTo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		medTo.Location = new Point(187, 102);
		medTo.Margin = new Padding(4);
		medTo.Name = "m_edTo";
		medTo.Size = new Size(424, 22);
		medTo.TabIndex = 13;
		mlblTo.AutoSize = true;
		mlblTo.Location = new Point(21, 108);
		mlblTo.Margin = new Padding(4, 0, 4, 0);
		mlblTo.Name = "m_lblTo";
		mlblTo.Size = new Size(27, 16);
		mlblTo.TabIndex = 67;
		mlblTo.Text = "To:";
		mlblToHint.AutoSize = true;
		mlblToHint.ForeColor = SystemColors.ControlDarkDark;
		mlblToHint.Location = new Point(184, 131);
		mlblToHint.Margin = new Padding(4, 0, 4, 0);
		mlblToHint.Name = "m_lblToHint";
		mlblToHint.Size = new Size(177, 16);
		mlblToHint.TabIndex = 66;
		mlblToHint.Text = " Specify message recepient ";
		medFrom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		medFrom.Location = new Point(187, 32);
		medFrom.Margin = new Padding(4);
		medFrom.Name = "m_edFrom";
		medFrom.Size = new Size(424, 22);
		medFrom.TabIndex = 12;
		mlblFrom.AutoSize = true;
		mlblFrom.Location = new Point(21, 38);
		mlblFrom.Margin = new Padding(4, 0, 4, 0);
		mlblFrom.Name = "m_lblFrom";
		mlblFrom.Size = new Size(41, 16);
		mlblFrom.TabIndex = 64;
		mlblFrom.Text = "From:";
		mlblFromHint.AutoSize = true;
		mlblFromHint.ForeColor = SystemColors.ControlDarkDark;
		mlblFromHint.Location = new Point(184, 61);
		mlblFromHint.Margin = new Padding(4, 0, 4, 0);
		mlblFromHint.Name = "m_lblFromHint";
		mlblFromHint.Size = new Size(184, 16);
		mlblFromHint.TabIndex = 63;
		mlblFromHint.Text = " Specify the message sender ";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.Controls.Add(mgrMessage);
		base.Controls.Add(mgrbServer);
		GClass10_0 = gClass10_;
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(4);
		base.Name = "MailSendTaskAddEditControl";
		base.Size = new Size(630, 540);
		mgrbServer.ResumeLayout(performLayout: false);
		mgrbServer.PerformLayout();
		mgrMessage.ResumeLayout(performLayout: false);
		mgrMessage.PerformLayout();
		((ISupportInitialize)mpicLoading).EndInit();
		ResumeLayout(performLayout: false);
	}

	private void mbtnSmtpServersAddEdit_Click(object sender, EventArgs e)
	{
		if (DialogResult.OK == new SmtpServersDialog().ShowDialog())
		{
			Class89.eventHandler_23 = (EventHandler<EventArgs4>)Delegate.Combine(Class89.eventHandler_23, new EventHandler<EventArgs4>(AddTask));
			Class89.smethod_32();
		}
	}

	private void class0_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		AdjustFormSize();
		RemoveTask();
	}
}
