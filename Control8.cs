using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class Control8 : Control4
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

	private Class65 class65_0;

	private Class65 class65_1;

	private GClass3 gclass3_1;

	private TextBox textBox_0;

	private Class63 class63_0;

	private PictureBox pictureBox_0;

	private TextBox textBox_1;

	private Class62 class62_0;

	private Class63 class63_1;

	private Class63 class63_2;

	private Class61 class61_0;

	private TextBox textBox_2;

	private Class62 class62_1;

	private Class63 class63_3;

	private TextBox textBox_3;

	private Class62 class62_2;

	private Class63 class63_4;

	private GClass3 gclass3_2;

	private GClass3 gclass3_3;

	public override Size Size_0 => new Size(640, 540);

	public override GClass3 GClass3_0 => gclass3_1;

	public override GClass10 GClass10_0
	{
		get
		{
			return new Class173
			{
				string_2 = textBox_1.Text,
				bool_0 = class61_0.Checked,
				string_3 = textBox_3.Text,
				string_4 = textBox_2.Text,
				string_5 = textBox_0.Text
			};
		}
		set
		{
			Class173 @class = value as Class173;
			textBox_1.Text = @class.string_2;
			class61_0.Checked = @class.bool_0;
			textBox_3.Text = @class.string_3;
			textBox_2.Text = @class.string_4;
			textBox_0.Text = @class.string_5;
		}
	}

	public override void vmethod_3(GEnum2 genum2_1)
	{
		genum2_0 = genum2_1;
		gclass3_3.method_0();
	}

	public override bool vmethod_4()
	{
		return true;
	}

	protected override void vmethod_0()
	{
		method_2();
		gclass3_3.Left = class63_0.Right;
		gclass3_2.Left = gclass3_3.Right;
		pictureBox_0.Image = ((Class163.Class163_0.Boolean_0 ? true : false) ? Resources.wait_16_dark : Resources.wait_16);
	}

	protected override void vmethod_1()
	{
		class61_0.CheckedChanged += class61_0_CheckedChanged;
		gclass3_3.Click += gclass3_3_Click;
		gclass3_2.Click += gclass3_2_Click;
	}

	private void method_1(bool bool_1)
	{
		bool flag = class61_0.Checked;
		class62_2.Enabled = bool_1 && flag;
		class63_4.Enabled = bool_1 && flag;
		textBox_3.Enabled = bool_1 && flag;
		class62_1.Enabled = bool_1 && flag;
		class63_3.Enabled = bool_1 && flag;
		textBox_2.Enabled = bool_1 && flag;
	}

	public override void vmethod_5(bool bool_1)
	{
		pictureBox_0.Visible = !bool_1;
		class62_0.Enabled = bool_1;
		textBox_1.Enabled = bool_1;
		class63_1.Enabled = bool_1;
		class61_0.Enabled = bool_1;
		class63_2.Enabled = bool_1;
		method_1(bool_1);
		textBox_0.Enabled = bool_1;
		class63_0.Enabled = bool_1;
		gclass3_3.Enabled = bool_1;
		gclass3_2.Enabled = bool_1;
		gclass3_1.Enabled = bool_1;
	}

	protected override void vmethod_2()
	{
		base.Boolean_0 = true;
		base.Boolean_0 &= !string.IsNullOrEmpty(textBox_1.Text);
		bool flag = !class61_0.Checked || (!string.IsNullOrEmpty(textBox_3.Text) && !string.IsNullOrEmpty(textBox_2.Text));
		base.Boolean_0 &= flag;
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

	private void method_2()
	{
		class65_0 = new Class65();
		textBox_2 = new TextBox();
		class62_1 = new Class62();
		class63_3 = new Class63();
		textBox_3 = new TextBox();
		class62_2 = new Class62();
		class63_4 = new Class63();
		class63_2 = new Class63();
		class61_0 = new Class61();
		textBox_1 = new TextBox();
		class62_0 = new Class62();
		class63_1 = new Class63();
		class65_1 = new Class65();
		gclass3_2 = new GClass3();
		gclass3_3 = new GClass3();
		pictureBox_0 = new PictureBox();
		gclass3_1 = new GClass3();
		textBox_0 = new TextBox();
		class63_0 = new Class63();
		class65_0.SuspendLayout();
		class65_1.SuspendLayout();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		class65_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		class65_0.Controls.Add(textBox_2);
		class65_0.Controls.Add(class62_1);
		class65_0.Controls.Add(class63_3);
		class65_0.Controls.Add(textBox_3);
		class65_0.Controls.Add(class62_2);
		class65_0.Controls.Add(class63_4);
		class65_0.Controls.Add(class63_2);
		class65_0.Controls.Add(class61_0);
		class65_0.Controls.Add(textBox_1);
		class65_0.Controls.Add(class62_0);
		class65_0.Controls.Add(class63_1);
		class65_0.Location = new Point(4, 4);
		class65_0.Margin = new Padding(4);
		class65_0.Name = "m_grbServer";
		class65_0.Padding = new Padding(4);
		class65_0.Size = new Size(632, 288);
		class65_0.TabIndex = 38;
		class65_0.TabStop = false;
		class65_0.Text = "Server";
		textBox_2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		textBox_2.Enabled = false;
		textBox_2.Location = new Point(187, 227);
		textBox_2.Name = "m_edBasicAuthPassword";
		textBox_2.Size = new Size(435, 22);
		textBox_2.TabIndex = 83;
		textBox_2.UseSystemPasswordChar = true;
		class62_1.AutoSize = true;
		class62_1.Enabled = false;
		class62_1.Location = new Point(16, 227);
		class62_1.Name = "m_lblBasicAuthPassword";
		class62_1.Size = new Size(71, 16);
		class62_1.TabIndex = 85;
		class62_1.Text = "Password:";
		class63_3.AutoSize = true;
		class63_3.Enabled = false;
		class63_3.ForeColor = SystemColors.ControlDarkDark;
		class63_3.Location = new Point(184, 255);
		class63_3.Name = "m_lblBasicAuthPasswordHint";
		class63_3.Size = new Size(249, 16);
		class63_3.TabIndex = 84;
		class63_3.Text = "Password for Basic HTTP Authentication";
		textBox_3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		textBox_3.Enabled = false;
		textBox_3.Location = new Point(187, 162);
		textBox_3.Name = "m_edBasicAuthUsername";
		textBox_3.Size = new Size(435, 22);
		textBox_3.TabIndex = 80;
		class62_2.AutoSize = true;
		class62_2.Enabled = false;
		class62_2.Location = new Point(16, 162);
		class62_2.Name = "m_lblBasicAuthUsername";
		class62_2.Size = new Size(74, 16);
		class62_2.TabIndex = 82;
		class62_2.Text = "Username:";
		class63_4.AutoSize = true;
		class63_4.Enabled = false;
		class63_4.ForeColor = SystemColors.ControlDarkDark;
		class63_4.Location = new Point(184, 190);
		class63_4.Name = "m_lblBasicAuthUsernameHint";
		class63_4.Size = new Size(255, 16);
		class63_4.TabIndex = 81;
		class63_4.Text = "User name for Basic HTTP Authentication";
		class63_2.AutoSize = true;
		class63_2.ForeColor = SystemColors.ControlDarkDark;
		class63_2.Location = new Point(16, 123);
		class63_2.Name = "m_lblEnableBasicAuthHint";
		class63_2.Size = new Size(509, 16);
		class63_2.TabIndex = 79;
		class63_2.Text = "Secure connection over SSL/TLS (HTTPS) is recommended if you enable this option";
		class61_0.AutoSize = true;
		class61_0.Location = new Point(19, 97);
		class61_0.Name = "m_chbEnableBasicAuth";
		class61_0.Size = new Size(233, 20);
		class61_0.TabIndex = 78;
		class61_0.Text = "Enable Basic HTTP Authentication";
		class61_0.UseVisualStyleBackColor = true;
		textBox_1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		textBox_1.Location = new Point(187, 32);
		textBox_1.Name = "m_edEndpoint";
		textBox_1.Size = new Size(435, 22);
		textBox_1.TabIndex = 70;
		class62_0.AutoSize = true;
		class62_0.Location = new Point(16, 32);
		class62_0.Name = "m_lblEndpoint";
		class62_0.Size = new Size(64, 16);
		class62_0.TabIndex = 74;
		class62_0.Text = "Endpoint:";
		class63_1.AutoSize = true;
		class63_1.ForeColor = SystemColors.ControlDarkDark;
		class63_1.Location = new Point(184, 60);
		class63_1.Name = "m_lblEndpointHint";
		class63_1.Size = new Size(269, 16);
		class63_1.TabIndex = 73;
		class63_1.Text = "Example https://server.com:8443/page.aspx";
		class65_1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		class65_1.Controls.Add(gclass3_2);
		class65_1.Controls.Add(gclass3_3);
		class65_1.Controls.Add(pictureBox_0);
		class65_1.Controls.Add(gclass3_1);
		class65_1.Controls.Add(textBox_0);
		class65_1.Controls.Add(class63_0);
		class65_1.Location = new Point(4, 300);
		class65_1.Margin = new Padding(4);
		class65_1.Name = "m_grBody";
		class65_1.Padding = new Padding(4);
		class65_1.Size = new Size(632, 336);
		class65_1.TabIndex = 39;
		class65_1.TabStop = false;
		class65_1.Text = "POST Body";
		gclass3_2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		gclass3_2.AutoSize = true;
		gclass3_2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 204);
		gclass3_2.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_2.Location = new Point(255, 313);
		gclass3_2.Name = "m_lnkXmlExample";
		gclass3_2.RightToLeft = RightToLeft.No;
		gclass3_2.Size = new Size(85, 15);
		gclass3_2.TabIndex = 77;
		gclass3_2.TabStop = true;
		gclass3_2.Text = "XML Example";
		gclass3_2.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		gclass3_3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		gclass3_3.AutoSize = true;
		gclass3_3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 204);
		gclass3_3.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_3.Location = new Point(148, 313);
		gclass3_3.Name = "m_lnkJsonExample";
		gclass3_3.RightToLeft = RightToLeft.No;
		gclass3_3.Size = new Size(91, 15);
		gclass3_3.TabIndex = 76;
		gclass3_3.TabStop = true;
		gclass3_3.Text = "JSON Example";
		gclass3_3.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		pictureBox_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		pictureBox_0.Location = new Point(491, 313);
		pictureBox_0.Name = "m_picLoading";
		pictureBox_0.Size = new Size(16, 16);
		pictureBox_0.TabIndex = 75;
		pictureBox_0.TabStop = false;
		pictureBox_0.Visible = false;
		gclass3_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		gclass3_1.AutoSize = true;
		gclass3_1.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_1.Location = new Point(513, 313);
		gclass3_1.Name = "m_lnkSendTestRequest";
		gclass3_1.RightToLeft = RightToLeft.No;
		gclass3_1.Size = new Size(112, 16);
		gclass3_1.TabIndex = 16;
		gclass3_1.TabStop = true;
		gclass3_1.Text = "send test request";
		gclass3_1.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		textBox_0.AcceptsReturn = true;
		textBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		textBox_0.Font = new Font("Courier New", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		textBox_0.Location = new Point(8, 23);
		textBox_0.Margin = new Padding(4);
		textBox_0.Multiline = true;
		textBox_0.Name = "m_edBody";
		textBox_0.ScrollBars = ScrollBars.Vertical;
		textBox_0.Size = new Size(615, 283);
		textBox_0.TabIndex = 15;
		class63_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		class63_0.AutoSize = true;
		class63_0.ForeColor = SystemColors.ControlDarkDark;
		class63_0.Location = new Point(8, 313);
		class63_0.Margin = new Padding(4, 0, 4, 0);
		class63_0.Name = "m_lblBodyHint";
		class63_0.Size = new Size(130, 16);
		class63_0.TabIndex = 72;
		class63_0.Text = " Specify POST body";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.Controls.Add(class65_1);
		base.Controls.Add(class65_0);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(4);
		base.Name = "HttpPostTaskAddEditControl";
		base.Size = new Size(640, 640);
		class65_0.ResumeLayout(performLayout: false);
		class65_0.PerformLayout();
		class65_1.ResumeLayout(performLayout: false);
		class65_1.PerformLayout();
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
	}

	private void class61_0_CheckedChanged(object sender, EventArgs e)
	{
		method_1(bool_1: true);
		vmethod_2();
	}

	private void gclass3_3_Click(object sender, EventArgs e)
	{
		textBox_0.Text = string.Format(dictionary_0[genum2_0][1], Class185.Class185_0[genum2_0].Replace(" ", ""), "{", "}");
	}

	private void gclass3_2_Click(object sender, EventArgs e)
	{
		textBox_0.Text = string.Format(dictionary_0[genum2_0][0], Class185.Class185_0[genum2_0].Replace(" ", ""));
	}
}
