using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class HttpPostTaskAddEditControl : Control4
{
	private readonly Dictionary<GEnum2, string[]> dictionary_0 = new Dictionary<GEnum2, string[]>
	{
		{
			GEnum2.const_0,
			new string[2] { "<{0}>\r\n  <IP>%IP%</IP>\r\n  <User>%USER%</User>\r\n  <BlockDate>%BLOCK_DATE%</BlockDate>\r\n  <UnblockDate>%UNBLOCK_DATE%</UnblockDate>\r\n  <Protocol>%PROTOCOL%</Protocol>\r\n  <Hostname>%HOSTNAME%</Hostname>\r\n  <TotalIPBlocked>%TOTAL_IP_BLOCKED%</TotalIPBlocked>\r\n</{0}>", "{1}\r\n  \"{0}\": {1}\r\n    \"IP\": \"%IP%\",\r\n    \"User\": \"%USER%\",\r\n    \"BlockDate\": \"%BLOCK_DATE%\",\r\n    \"UnblockDate\": \"%UNBLOCK_DATE%\",\r\n    \"Protocol\": \"%PROTOCOL%\",\r\n    \"Hostname\": \"%HOSTNAME%\",\r\n    \"TotalIPBlocked\": \"%TOTAL_IP_BLOCKED%\"\r\n  {2}\r\n{2}" }
		},
		{
			GEnum2.const_1,
			new string[2] { "<{0}>\r\n  <IP>%IP%</IP>\r\n  <User>%USER%</User>\r\n  <BlockDate>%BLOCK_DATE%</BlockDate>\r\n  <UnblockDate>%UNBLOCK_DATE%</UnblockDate>\r\n  <Protocol>%PROTOCOL%</Protocol>\r\n  <Hostname>%HOSTNAME%</Hostname>\r\n  <TotalIPBlocked>%TOTAL_IP_BLOCKED%</TotalIPBlocked>\r\n</{0}>", "{1}\r\n  \"{0}\": {1}\r\n    \"IP\": \"%IP%\",\r\n    \"User\": \"%USER%\",\r\n    \"BlockDate\": \"%BLOCK_DATE%\",\r\n    \"UnblockDate\": \"%UNBLOCK_DATE%\",\r\n    \"Protocol\": \"%PROTOCOL%\",\r\n    \"Hostname\": \"%HOSTNAME%\",\r\n    \"TotalIPBlocked\": \"%TOTAL_IP_BLOCKED%\"\r\n  {2}\r\n{2}" }
		},
		{
			GEnum2.const_2,
			new string[2] { "<{0}>\r\n  <IP>%IP%</IP>\r\n  <User>%USER%</User>\r\n  <Hostname>%HOSTNAME%</Hostname>\r\n</{0}>", "{1}\r\n  \"{0}\": {1}\r\n    \"IP\": \"%IP%\",\r\n    \"User\": \"%USER%\",\r\n    \"Hostname\": \"%HOSTNAME%\"\r\n  {2}\r\n{2}" }
		},
		{
			GEnum2.const_3,
			new string[2] { "<{0}>\r\n  <Version>%NEW_VERSION_NUMBER%</Version>\r\n  <Link>%NEW_VERSION_LINK%</Link>\r\n</{0}>", "{1}\r\n  \"{0}\": {1}\r\n    \"Version\": \"%NEW_VERSION_NUMBER%\",\r\n    \"Link\": \"%NEW_VERSION_LINK%\"\r\n  {2}\r\n{2}" }
		},
		{
			GEnum2.const_4,
			new string[2] { "<{0}>\r\n  <DaysRemaining>%MAINTENANCE_DAYS%</DaysRemaining>\r\n  <Hostname>%HOSTNAME%</Hostname>\r\n</{0}>", "{1}\r\n  \"{0}\": {1}\r\n    \"DaysRemaining\": \"%MAINTENANCE_DAYS%\",\r\n    \"Hostname\": \"%HOSTNAME%\"\r\n  {2}\r\n{2}" }
		},
		{
			GEnum2.const_5,
			new string[2] { "<{0}>\r\n  <Hostname>%HOSTNAME%</Hostname>\r\n</{0}>", "{1}\r\n  \"{0}\": {1}\r\n    \"Hostname\": \"%HOSTNAME%\"\r\n  {2}\r\n{2}" }
		}
	};

	private GEnum2 genum2_0;

	private IContainer icontainer_0;

	private Class65 mgrbServer;

	private Class65 mgrBody;

	private GClass3 mlnkSendTestRequest;

	private TextBox medBody;

	private Class63 mlblBodyHint;

	private PictureBox mpicLoading;

	private TextBox medEndpoint;

	private Class62 mlblEndpoint;

	private Class63 mlblEndpointHint;

	private Class63 mlblEnableBasicAuthHint;

	private Class61 mchbEnableBasicAuth;

	private TextBox medBasicAuthPassword;

	private Class62 mlblBasicAuthPassword;

	private Class63 mlblBasicAuthPasswordHint;

	private TextBox medBasicAuthUsername;

	private Class62 mlblBasicAuthUsername;

	private Class63 mlblBasicAuthUsernameHint;

	private GClass3 mlnkXmlExample;

	private GClass3 mlnkJsonExample;

	public override Size Size_0 => new Size(640, 540);

	public override GClass3 GClass3_0 => mlnkSendTestRequest;

	public override GClass10 GClass10_0
	{
		get
		{
			return new Class173
			{
				string_2 = medEndpoint.Text,
				bool_0 = mchbEnableBasicAuth.Checked,
				string_3 = medBasicAuthUsername.Text,
				string_4 = medBasicAuthPassword.Text,
				string_5 = medBody.Text
			};
		}
		set
		{
			Class173 @class = value as Class173;
			medEndpoint.Text = @class.string_2;
			mchbEnableBasicAuth.Checked = @class.bool_0;
			medBasicAuthUsername.Text = @class.string_3;
			medBasicAuthPassword.Text = @class.string_4;
			medBody.Text = @class.string_5;
		}
	}

	public override void UpdateTaskType(GEnum2 genum2_1)
	{
		genum2_0 = genum2_1;
		mlnkJsonExample.InitializeHandlers();
	}

	public override bool ValidateInput()
	{
		return true;
	}

	protected override void OnFormClosing()
	{
		InitializeComponent();
		mlnkJsonExample.Left = mlblBodyHint.Right;
		mlnkXmlExample.Left = mlnkJsonExample.Right;
		mpicLoading.Image = ((Class163.Class163_0.Boolean_0 ? true : false) ? Resources.wait_16_dark : Resources.wait_16);
	}

	protected override void InitializeFormPosition()
	{
		mchbEnableBasicAuth.CheckedChanged += mchbEnableBasicAuth_CheckedChanged;
		mlnkJsonExample.Click += mlnkJsonExample_Click;
		mlnkXmlExample.Click += mlnkXmlExample_Click;
	}

	private void AddTask(bool bool_1)
	{
		bool flag = mchbEnableBasicAuth.Checked;
		mlblBasicAuthUsername.Enabled = bool_1 && flag;
		mlblBasicAuthUsernameHint.Enabled = bool_1 && flag;
		medBasicAuthUsername.Enabled = bool_1 && flag;
		mlblBasicAuthPassword.Enabled = bool_1 && flag;
		mlblBasicAuthPasswordHint.Enabled = bool_1 && flag;
		medBasicAuthPassword.Enabled = bool_1 && flag;
	}

	public override void SetEditMode(bool bool_1)
	{
		mpicLoading.Visible = !bool_1;
		mlblEndpoint.Enabled = bool_1;
		medEndpoint.Enabled = bool_1;
		mlblEndpointHint.Enabled = bool_1;
		mchbEnableBasicAuth.Enabled = bool_1;
		mlblEnableBasicAuthHint.Enabled = bool_1;
		AddTask(bool_1);
		medBody.Enabled = bool_1;
		mlblBodyHint.Enabled = bool_1;
		mlnkJsonExample.Enabled = bool_1;
		mlnkXmlExample.Enabled = bool_1;
		mlnkSendTestRequest.Enabled = bool_1;
	}

	protected override void AdjustFormSize()
	{
		base.Boolean_0 = true;
		base.Boolean_0 &= !string.IsNullOrEmpty(medEndpoint.Text);
		bool flag = !mchbEnableBasicAuth.Checked || (!string.IsNullOrEmpty(medBasicAuthUsername.Text) && !string.IsNullOrEmpty(medBasicAuthPassword.Text));
		base.Boolean_0 &= flag;
		mlnkSendTestRequest.Enabled = base.Boolean_0;
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
		mgrbServer = new Class65();
		medBasicAuthPassword = new TextBox();
		mlblBasicAuthPassword = new Class62();
		mlblBasicAuthPasswordHint = new Class63();
		medBasicAuthUsername = new TextBox();
		mlblBasicAuthUsername = new Class62();
		mlblBasicAuthUsernameHint = new Class63();
		mlblEnableBasicAuthHint = new Class63();
		mchbEnableBasicAuth = new Class61();
		medEndpoint = new TextBox();
		mlblEndpoint = new Class62();
		mlblEndpointHint = new Class63();
		mgrBody = new Class65();
		mlnkXmlExample = new GClass3();
		mlnkJsonExample = new GClass3();
		mpicLoading = new PictureBox();
		mlnkSendTestRequest = new GClass3();
		medBody = new TextBox();
		mlblBodyHint = new Class63();
		mgrbServer.SuspendLayout();
		mgrBody.SuspendLayout();
		((ISupportInitialize)mpicLoading).BeginInit();
		SuspendLayout();
		mgrbServer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		mgrbServer.Controls.Add(medBasicAuthPassword);
		mgrbServer.Controls.Add(mlblBasicAuthPassword);
		mgrbServer.Controls.Add(mlblBasicAuthPasswordHint);
		mgrbServer.Controls.Add(medBasicAuthUsername);
		mgrbServer.Controls.Add(mlblBasicAuthUsername);
		mgrbServer.Controls.Add(mlblBasicAuthUsernameHint);
		mgrbServer.Controls.Add(mlblEnableBasicAuthHint);
		mgrbServer.Controls.Add(mchbEnableBasicAuth);
		mgrbServer.Controls.Add(medEndpoint);
		mgrbServer.Controls.Add(mlblEndpoint);
		mgrbServer.Controls.Add(mlblEndpointHint);
		mgrbServer.Location = new Point(4, 4);
		mgrbServer.Margin = new Padding(4);
		mgrbServer.Name = "m_grbServer";
		mgrbServer.Padding = new Padding(4);
		mgrbServer.Size = new Size(632, 288);
		mgrbServer.TabIndex = 38;
		mgrbServer.TabStop = false;
		mgrbServer.Text = "Server";
		medBasicAuthPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		medBasicAuthPassword.Enabled = false;
		medBasicAuthPassword.Location = new Point(187, 227);
		medBasicAuthPassword.Name = "m_edBasicAuthPassword";
		medBasicAuthPassword.Size = new Size(435, 22);
		medBasicAuthPassword.TabIndex = 83;
		medBasicAuthPassword.UseSystemPasswordChar = true;
		mlblBasicAuthPassword.AutoSize = true;
		mlblBasicAuthPassword.Enabled = false;
		mlblBasicAuthPassword.Location = new Point(16, 227);
		mlblBasicAuthPassword.Name = "m_lblBasicAuthPassword";
		mlblBasicAuthPassword.Size = new Size(71, 16);
		mlblBasicAuthPassword.TabIndex = 85;
		mlblBasicAuthPassword.Text = "Password:";
		mlblBasicAuthPasswordHint.AutoSize = true;
		mlblBasicAuthPasswordHint.Enabled = false;
		mlblBasicAuthPasswordHint.ForeColor = SystemColors.ControlDarkDark;
		mlblBasicAuthPasswordHint.Location = new Point(184, 255);
		mlblBasicAuthPasswordHint.Name = "m_lblBasicAuthPasswordHint";
		mlblBasicAuthPasswordHint.Size = new Size(249, 16);
		mlblBasicAuthPasswordHint.TabIndex = 84;
		mlblBasicAuthPasswordHint.Text = "Password for Basic HTTP Authentication";
		medBasicAuthUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		medBasicAuthUsername.Enabled = false;
		medBasicAuthUsername.Location = new Point(187, 162);
		medBasicAuthUsername.Name = "m_edBasicAuthUsername";
		medBasicAuthUsername.Size = new Size(435, 22);
		medBasicAuthUsername.TabIndex = 80;
		mlblBasicAuthUsername.AutoSize = true;
		mlblBasicAuthUsername.Enabled = false;
		mlblBasicAuthUsername.Location = new Point(16, 162);
		mlblBasicAuthUsername.Name = "m_lblBasicAuthUsername";
		mlblBasicAuthUsername.Size = new Size(74, 16);
		mlblBasicAuthUsername.TabIndex = 82;
		mlblBasicAuthUsername.Text = "Username:";
		mlblBasicAuthUsernameHint.AutoSize = true;
		mlblBasicAuthUsernameHint.Enabled = false;
		mlblBasicAuthUsernameHint.ForeColor = SystemColors.ControlDarkDark;
		mlblBasicAuthUsernameHint.Location = new Point(184, 190);
		mlblBasicAuthUsernameHint.Name = "m_lblBasicAuthUsernameHint";
		mlblBasicAuthUsernameHint.Size = new Size(255, 16);
		mlblBasicAuthUsernameHint.TabIndex = 81;
		mlblBasicAuthUsernameHint.Text = "User name for Basic HTTP Authentication";
		mlblEnableBasicAuthHint.AutoSize = true;
		mlblEnableBasicAuthHint.ForeColor = SystemColors.ControlDarkDark;
		mlblEnableBasicAuthHint.Location = new Point(16, 123);
		mlblEnableBasicAuthHint.Name = "m_lblEnableBasicAuthHint";
		mlblEnableBasicAuthHint.Size = new Size(509, 16);
		mlblEnableBasicAuthHint.TabIndex = 79;
		mlblEnableBasicAuthHint.Text = "Secure connection over SSL/TLS (HTTPS) is recommended if you enable this option";
		mchbEnableBasicAuth.AutoSize = true;
		mchbEnableBasicAuth.Location = new Point(19, 97);
		mchbEnableBasicAuth.Name = "m_chbEnableBasicAuth";
		mchbEnableBasicAuth.Size = new Size(233, 20);
		mchbEnableBasicAuth.TabIndex = 78;
		mchbEnableBasicAuth.Text = "Enable Basic HTTP Authentication";
		mchbEnableBasicAuth.UseVisualStyleBackColor = true;
		medEndpoint.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		medEndpoint.Location = new Point(187, 32);
		medEndpoint.Name = "m_edEndpoint";
		medEndpoint.Size = new Size(435, 22);
		medEndpoint.TabIndex = 70;
		mlblEndpoint.AutoSize = true;
		mlblEndpoint.Location = new Point(16, 32);
		mlblEndpoint.Name = "m_lblEndpoint";
		mlblEndpoint.Size = new Size(64, 16);
		mlblEndpoint.TabIndex = 74;
		mlblEndpoint.Text = "Endpoint:";
		mlblEndpointHint.AutoSize = true;
		mlblEndpointHint.ForeColor = SystemColors.ControlDarkDark;
		mlblEndpointHint.Location = new Point(184, 60);
		mlblEndpointHint.Name = "m_lblEndpointHint";
		mlblEndpointHint.Size = new Size(269, 16);
		mlblEndpointHint.TabIndex = 73;
		mlblEndpointHint.Text = "Example https://server.com:8443/page.aspx";
		mgrBody.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		mgrBody.Controls.Add(mlnkXmlExample);
		mgrBody.Controls.Add(mlnkJsonExample);
		mgrBody.Controls.Add(mpicLoading);
		mgrBody.Controls.Add(mlnkSendTestRequest);
		mgrBody.Controls.Add(medBody);
		mgrBody.Controls.Add(mlblBodyHint);
		mgrBody.Location = new Point(4, 300);
		mgrBody.Margin = new Padding(4);
		mgrBody.Name = "m_grBody";
		mgrBody.Padding = new Padding(4);
		mgrBody.Size = new Size(632, 336);
		mgrBody.TabIndex = 39;
		mgrBody.TabStop = false;
		mgrBody.Text = "POST Body";
		mlnkXmlExample.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		mlnkXmlExample.AutoSize = true;
		mlnkXmlExample.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 204);
		mlnkXmlExample.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkXmlExample.Location = new Point(255, 313);
		mlnkXmlExample.Name = "m_lnkXmlExample";
		mlnkXmlExample.RightToLeft = RightToLeft.No;
		mlnkXmlExample.Size = new Size(85, 15);
		mlnkXmlExample.TabIndex = 77;
		mlnkXmlExample.TabStop = true;
		mlnkXmlExample.Text = "XML Example";
		mlnkXmlExample.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		mlnkJsonExample.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		mlnkJsonExample.AutoSize = true;
		mlnkJsonExample.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 204);
		mlnkJsonExample.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkJsonExample.Location = new Point(148, 313);
		mlnkJsonExample.Name = "m_lnkJsonExample";
		mlnkJsonExample.RightToLeft = RightToLeft.No;
		mlnkJsonExample.Size = new Size(91, 15);
		mlnkJsonExample.TabIndex = 76;
		mlnkJsonExample.TabStop = true;
		mlnkJsonExample.Text = "JSON Example";
		mlnkJsonExample.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		mpicLoading.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mpicLoading.Location = new Point(491, 313);
		mpicLoading.Name = "m_picLoading";
		mpicLoading.Size = new Size(16, 16);
		mpicLoading.TabIndex = 75;
		mpicLoading.TabStop = false;
		mpicLoading.Visible = false;
		mlnkSendTestRequest.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mlnkSendTestRequest.AutoSize = true;
		mlnkSendTestRequest.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkSendTestRequest.Location = new Point(513, 313);
		mlnkSendTestRequest.Name = "m_lnkSendTestRequest";
		mlnkSendTestRequest.RightToLeft = RightToLeft.No;
		mlnkSendTestRequest.Size = new Size(112, 16);
		mlnkSendTestRequest.TabIndex = 16;
		mlnkSendTestRequest.TabStop = true;
		mlnkSendTestRequest.Text = "send test request";
		mlnkSendTestRequest.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		medBody.AcceptsReturn = true;
		medBody.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		medBody.Font = new Font("Courier New", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		medBody.Location = new Point(8, 23);
		medBody.Margin = new Padding(4);
		medBody.Multiline = true;
		medBody.Name = "m_edBody";
		medBody.ScrollBars = ScrollBars.Vertical;
		medBody.Size = new Size(615, 283);
		medBody.TabIndex = 15;
		mlblBodyHint.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		mlblBodyHint.AutoSize = true;
		mlblBodyHint.ForeColor = SystemColors.ControlDarkDark;
		mlblBodyHint.Location = new Point(8, 313);
		mlblBodyHint.Margin = new Padding(4, 0, 4, 0);
		mlblBodyHint.Name = "m_lblBodyHint";
		mlblBodyHint.Size = new Size(130, 16);
		mlblBodyHint.TabIndex = 72;
		mlblBodyHint.Text = " Specify POST body";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.Controls.Add(mgrBody);
		base.Controls.Add(mgrbServer);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(4);
		base.Name = "HttpPostTaskAddEditControl";
		base.Size = new Size(640, 640);
		mgrbServer.ResumeLayout(performLayout: false);
		mgrbServer.PerformLayout();
		mgrBody.ResumeLayout(performLayout: false);
		mgrBody.PerformLayout();
		((ISupportInitialize)mpicLoading).EndInit();
		ResumeLayout(performLayout: false);
	}

	private void mchbEnableBasicAuth_CheckedChanged(object sender, EventArgs e)
	{
		AddTask(bool_1: true);
		AdjustFormSize();
	}

	private void mlnkJsonExample_Click(object sender, EventArgs e)
	{
		medBody.Text = string.Format(dictionary_0[genum2_0][1], Class185.Class185_0[genum2_0].Replace(" ", ""), "{", "}");
	}

	private void mlnkXmlExample_Click(object sender, EventArgs e)
	{
		medBody.Text = string.Format(dictionary_0[genum2_0][0], Class185.Class185_0[genum2_0].Replace(" ", ""));
	}
}
