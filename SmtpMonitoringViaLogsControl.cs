using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

internal sealed class SmtpMonitoringViaLogsControl : Control2
{
	private IContainer icontainer_0;

	private Class65 class65_0;

	private GClass2 gclass2_0;

	private Class54 class54_0;

	private Class62 class62_0;

	private Class63 class63_0;

	private Class0 class0_0;

	private Class62 class62_1;

	public override Size Size_0 => new Size(600, 240);

	public GEnum11 GEnum11_0
	{
		get
		{
			return Class195.Class195_0[class0_0.Text];
		}
		set
		{
			class0_0.Text = Class195.Class195_0[value];
		}
	}

	public string String_0
	{
		get
		{
			return class54_0.Text;
		}
		set
		{
			class54_0.Text = value;
		}
	}

	protected override void vmethod_0()
	{
		InitializeComponent();
		ComboBox.ObjectCollection items = class0_0.Items;
		object[] prop_ = Class195.Class195_0.Prop_1;
		object[] items2 = prop_;
		items.AddRange(items2);
	}

	protected override void vmethod_1()
	{
		class0_0.SelectedIndexChanged += class0_0_SelectedIndexChanged;
	}

	private void method_1()
	{
		switch (GEnum11_0)
		{
		default:
			class62_0.Text = "Файл или папка журнала:";
			gclass2_0"Specify the log file/directory location";
			break;
		case GEnum11.const_0:
			class62_0.Text = "Папка журналов:";
			class54_0.bool_0 = true;
			class54_0.String_1 = "C:\\Program Files (x86)\\Mail Enable\\Logging";
			gclass2_0"Specify SMTP log files directory, usually C:\\Program Files (x86)\\Mail Enable\\Logging\\SMTP";
			break;
		case GEnum11.const_1:
			class62_0.Text = "Файл журнала безопасности:";
			class54_0.bool_0 = false;
			class54_0.String_1 = "C:\\Program Files\\Kerio\\MailServer\\store\\logs";
			gclass2_0"Specify the Security log file location, usually C:\\Program Files\\Kerio\\MailServer\\store\\logs\\security.log";
			break;
		case GEnum11.const_2:
			class62_0.Text = "Папка журналов:";
			class54_0.bool_0 = true;
			class54_0.String_1 = "C:\\hMailServer\\Logs";
			gclass2_0"Specify hMailServer log files directory (for example C:\\hMailServer\\Logs)";
			break;
		case GEnum11.const_3:
			class62_0.Text = "Папка журналов:";
			class54_0.bool_0 = true;
			class54_0.String_1 = "C:\\Program Files\\Microsoft\\Exchange Server\\V15\\TransportRoles\\Logs\\FrontEnd\\ProtocolLog\\SmtpReceive";
			gclass2_0"Specify SmtpReceive log files directory location, usually C:\\Program Files\\Microsoft\\Exchange Server\\V15\\TransportRoles\\Logs\\FrontEnd\\ProtocolLog\\SmtpReceive";
			gclass2_0.Text += "\r\n\r\nLeave this field empty if you would like to use the Application event log instead (1035 event IDs)";
			break;
		case GEnum11.const_4:
			class62_0"Console log file location:";
			class54_0.bool_0 = false;
			class54_0.String_1 = "C:\\Program Files\\IBM\\Domino\\data\\IBM_TECHNICAL_SUPPORT";
			gclass2_0"Specify the Console log file location, usually C:\\Program Files\\IBM\\Domino\\data\\IBM_TECHNICAL_SUPPORT\\console.log";
			break;
		case GEnum11.const_5:
			class62_0.Text = "Файл журнала безопасности:";
			class54_0.bool_0 = false;
			class54_0.String_1 = "C:\\Program Files\\Axigen Mail Server\\log";
			gclass2_0"Specify the security log file location, usually C:\\Program Files\\Axigen Mail Server\\log\\security.txt";
			gclass2_0.Text += "\r\n\r\nTo enable security logging set 'enableSecurityLog = yes' in the following config file:\r\n";
			gclass2_0.Text += "C:\\Program Files\\Axigen Mail Server\\run\\axigen.cfg";
			break;
		case GEnum11.const_6:
			class62_0.Text = "Папка журналов:";
			class54_0.bool_0 = true;
			class54_0.String_1 = "C:\\MDaemon\\Logs";
			gclass2_0"Specify MDaemon log files directory (for example C:\\MDaemon\\Logs)";
			break;
		case GEnum11.const_7:
			class62_0.Text = "Папка журналов:";
			class54_0.bool_0 = true;
			class54_0.String_1 = "C:\\SmarterMail\\Logs";
			gclass2_0"Specify SmarterMail log files directory (for example C:\\SmarterMail\\Logs)";
			break;
		case GEnum11.const_8:
			class62_0.Text = "Папка журналов:";
			class54_0.bool_0 = true;
			class54_0.String_1 = "C:\\ProgramData\\E-MailRelay";
			gclass2_0"Specify the E-MailRelay log files directory (for example C:\\ProgramData\\E-MailRelay)";
			gclass2_0.Text += " or leave this field empty if you would like to use the Application event log instead.";
			gclass2_0.Text += "\r\n\r\nBe sure to use the --log-address or --log-format=address start parameters to include the network address of remote clients in the logging output.";
			break;
		}
		vmethod_2();
	}

	protected override void vmethod_2()
	{
		base.Boolean_0 = class0_0.smethod_0() && (GEnum11.const_3 == GEnum11_0 || GEnum11.const_8 == GEnum11_0 || class54_0.smethod_0());
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
		class65_0 = new Class65();
		gclass2_0 = new GClass2();
		class54_0 = new Class54();
		class62_0 = new Class62();
		class63_0 = new Class63();
		class0_0 = new Class0();
		class62_1 = new Class62();
		class65_0.SuspendLayout();
		SuspendLayout();
		class65_0.Controls.Add(gclass2_0);
		class65_0.Controls.Add(class54_0);
		class65_0.Controls.Add(class62_0);
		class65_0.Controls.Add(class63_0);
		class65_0.Controls.Add(class0_0);
		class65_0.Controls.Add(class62_1);
		class65_0.Dock = DockStyle.Fill;
		class65_0.Location = new Point(0, 0);
		class65_0.Name = "m_gbServerTypeAndLogLocation";
		class65_0.Size = new Size(600, 240);
		class65_0.TabIndex = 0;
		class65_0.TabStop = false;
		class65_0.Text = "Тип сервера и путь к журналу";
		gclass2_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gclass2_0.BackColor = SystemColors.Control;
		gclass2_0.BorderStyle = BorderStyle.None;
		gclass2_0.Cursor = Cursors.Default;
		gclass2_0.ForeColor = SystemColors.ControlDarkDark;
		gclass2_0.Location = new Point(28, 165);
		gclass2_0.Multiline = true;
		gclass2_0.Name = "m_lblLogFilesLocationHint";
		gclass2_0.ReadOnly = true;
		gclass2_0.Size = new Size(566, 69);
		gclass2_0.TabIndex = 142;
		gclass2_0.TabStop = false;
		gclass2_0"<LOG_FILES_LOCATION_HINT>";
		class54_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		class54_0.String_1 = null;
		class54_0.Location = new Point(28, 137);
		class54_0.Name = "m_edLogFileOrDirectory";
		class54_0.Size = new Size(566, 22);
		class54_0.TabIndex = 147;
		class62_0.AutoSize = true;
		class62_0.Location = new Point(15, 115);
		class62_0.Name = "m_lblLogFilesLocation";
		class62_0.Size = new Size(165, 16);
		class62_0.TabIndex = 146;
		class62_0"<LOG_FILES_LOCATION>";
		class63_0.AutoSize = true;
		class63_0.ForeColor = SystemColors.ControlDarkDark;
		class63_0.Location = new Point(25, 84);
		class63_0.Name = "m_lblServerTypeHint";
		class63_0.Size = new Size(329, 16);
		class63_0.TabIndex = 145;
		class63_0"Select SMTP server software installed on the machine.";
		class0_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		class0_0.DropDownStyle = ComboBoxStyle.DropDownList;
		class0_0.FormattingEnabled = true;
		class0_0.Location = new Point(28, 54);
		class0_0.Name = "m_cbServerType";
		class0_0.Size = new Size(566, 23);
		class0_0.TabIndex = 144;
		class62_1.AutoSize = true;
		class62_1.Location = new Point(15, 32);
		class62_1.Name = "m_lblServerType";
		class62_1.Size = new Size(118, 16);
		class62_1.TabIndex = 143;
		class62_1"Select server type:";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.Controls.Add(class65_0);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(4);
		base.Name = "SmtpMonitoringViaLogsControl";
		base.Size = new Size(600, 240);
		class65_0.ResumeLayout(performLayout: false);
		class65_0.PerformLayout();
		ResumeLayout(performLayout: false);
	}

	private void class0_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		method_1();
	}
}
