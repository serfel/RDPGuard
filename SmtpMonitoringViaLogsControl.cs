using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

internal sealed class SmtpMonitoringViaLogsControl : Control2
{
	private IContainer icontainer_0;

	private Class65 mgbServerTypeAndLogLocation;

	private GClass2 mlblLogFilesLocationHint;

	private Class54 medLogFileOrDirectory;

	private Class62 mlblLogFilesLocation;

	private Class63 mlblServerTypeHint;

	private Class0 mcbServerType;

	private Class62 mlblServerType;

	public override Size Size_0 => new Size(600, 240);

	public GEnum11 GEnum11_0
	{
		get
		{
			return Class195.Class195_0[mcbServerType.Text];
		}
		set
		{
			mcbServerType.Text = Class195.Class195_0[value];
		}
	}

	public string String_0
	{
		get
		{
			return medLogFileOrDirectory.Text;
		}
		set
		{
			medLogFileOrDirectory.Text = value;
		}
	}

	protected override void OnFormClosing()
	{
		InitializeComponent();
		ComboBox.ObjectCollection items = mcbServerType.Items;
		object[] prop_ = Class195.Class195_0.Prop_1;
		object[] items2 = prop_;
		items.AddRange(items2);
	}

	protected override void InitializeFormPosition()
	{
		mcbServerType.SelectedIndexChanged += class0_0_SelectedIndexChanged;
	}

	private void AddTask()
	{
		switch (GEnum11_0)
		{
		default:
			mlblLogFilesLocation.Text = "Log file or directory:";
			mlblLogFilesLocationHint.Text = "Specify the log file/directory location";
			break;
		case GEnum11.const_0:
			mlblLogFilesLocation.Text = "Log files directory:";
			medLogFileOrDirectory.bool_0 = true;
			medLogFileOrDirectory.String_1 = "C:\\Program Files (x86)\\Mail Enable\\Logging";
			mlblLogFilesLocationHint.Text = "Specify SMTP log files directory, usually C:\\Program Files (x86)\\Mail Enable\\Logging\\SMTP";
			break;
		case GEnum11.const_1:
			mlblLogFilesLocation.Text = "Security log file:";
			medLogFileOrDirectory.bool_0 = false;
			medLogFileOrDirectory.String_1 = "C:\\Program Files\\Kerio\\MailServer\\store\\logs";
			mlblLogFilesLocationHint.Text = "Specify the Security log file location, usually C:\\Program Files\\Kerio\\MailServer\\store\\logs\\security.log";
			break;
		case GEnum11.const_2:
			mlblLogFilesLocation.Text = "Log files directory:";
			medLogFileOrDirectory.bool_0 = true;
			medLogFileOrDirectory.String_1 = "C:\\hMailServer\\Logs";
			mlblLogFilesLocationHint.Text = "Specify hMailServer log files directory (for example C:\\hMailServer\\Logs)";
			break;
		case GEnum11.const_3:
			mlblLogFilesLocation.Text = "Log files directory:";
			medLogFileOrDirectory.bool_0 = true;
			medLogFileOrDirectory.String_1 = "C:\\Program Files\\Microsoft\\Exchange Server\\V15\\TransportRoles\\Logs\\FrontEnd\\ProtocolLog\\SmtpReceive";
			mlblLogFilesLocationHint.Text = "Specify SmtpReceive log files directory location, usually C:\\Program Files\\Microsoft\\Exchange Server\\V15\\TransportRoles\\Logs\\FrontEnd\\ProtocolLog\\SmtpReceive";
			mlblLogFilesLocationHint.Text += "\r\n\r\nLeave this field empty if you would like to use the Application event log instead (1035 event IDs)";
			break;
		case GEnum11.const_4:
			mlblLogFilesLocation.Text = "Console log file location:";
			medLogFileOrDirectory.bool_0 = false;
			medLogFileOrDirectory.String_1 = "C:\\Program Files\\IBM\\Domino\\data\\IBM_TECHNICAL_SUPPORT";
			mlblLogFilesLocationHint.Text = "Specify the Console log file location, usually C:\\Program Files\\IBM\\Domino\\data\\IBM_TECHNICAL_SUPPORT\\console.log";
			break;
		case GEnum11.const_5:
			mlblLogFilesLocation.Text = "Security log file:";
			medLogFileOrDirectory.bool_0 = false;
			medLogFileOrDirectory.String_1 = "C:\\Program Files\\Axigen Mail Server\\log";
			mlblLogFilesLocationHint.Text = "Specify the security log file location, usually C:\\Program Files\\Axigen Mail Server\\log\\security.txt";
			mlblLogFilesLocationHint.Text += "\r\n\r\nTo enable security logging set 'enableSecurityLog = yes' in the following config file:\r\n";
			mlblLogFilesLocationHint.Text += "C:\\Program Files\\Axigen Mail Server\\run\\axigen.cfg";
			break;
		case GEnum11.const_6:
			mlblLogFilesLocation.Text = "Log files directory:";
			medLogFileOrDirectory.bool_0 = true;
			medLogFileOrDirectory.String_1 = "C:\\MDaemon\\Logs";
			mlblLogFilesLocationHint.Text = "Specify MDaemon log files directory (for example C:\\MDaemon\\Logs)";
			break;
		case GEnum11.const_7:
			mlblLogFilesLocation.Text = "Log files directory:";
			medLogFileOrDirectory.bool_0 = true;
			medLogFileOrDirectory.String_1 = "C:\\SmarterMail\\Logs";
			mlblLogFilesLocationHint.Text = "Specify SmarterMail log files directory (for example C:\\SmarterMail\\Logs)";
			break;
		case GEnum11.const_8:
			mlblLogFilesLocation.Text = "Log files directory:";
			medLogFileOrDirectory.bool_0 = true;
			medLogFileOrDirectory.String_1 = "C:\\ProgramData\\E-MailRelay";
			mlblLogFilesLocationHint.Text = "Specify the E-MailRelay log files directory (for example C:\\ProgramData\\E-MailRelay)";
			mlblLogFilesLocationHint.Text += " or leave this field empty if you would like to use the Application event log instead.";
			mlblLogFilesLocationHint.Text += "\r\n\r\nBe sure to use the --log-address or --log-format=address start parameters to include the network address of remote clients in the logging output.";
			break;
		}
		AdjustFormSize();
	}

	protected override void AdjustFormSize()
	{
		base.Boolean_0 = mcbServerType.smethod_0() && (GEnum11.const_3 == GEnum11_0 || GEnum11.const_8 == GEnum11_0 || medLogFileOrDirectory.smethod_0());
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
		mgbServerTypeAndLogLocation = new Class65();
		mlblLogFilesLocationHint = new GClass2();
		medLogFileOrDirectory = new Class54();
		mlblLogFilesLocation = new Class62();
		mlblServerTypeHint = new Class63();
		mcbServerType = new Class0();
		mlblServerType = new Class62();
		mgbServerTypeAndLogLocation.SuspendLayout();
		SuspendLayout();
		mgbServerTypeAndLogLocation.Controls.Add(mlblLogFilesLocationHint);
		mgbServerTypeAndLogLocation.Controls.Add(medLogFileOrDirectory);
		mgbServerTypeAndLogLocation.Controls.Add(mlblLogFilesLocation);
		mgbServerTypeAndLogLocation.Controls.Add(mlblServerTypeHint);
		mgbServerTypeAndLogLocation.Controls.Add(mcbServerType);
		mgbServerTypeAndLogLocation.Controls.Add(mlblServerType);
		mgbServerTypeAndLogLocation.Dock = DockStyle.Fill;
		mgbServerTypeAndLogLocation.Location = new Point(0, 0);
		mgbServerTypeAndLogLocation.Name = "m_gbServerTypeAndLogLocation";
		mgbServerTypeAndLogLocation.Size = new Size(600, 240);
		mgbServerTypeAndLogLocation.TabIndex = 0;
		mgbServerTypeAndLogLocation.TabStop = false;
		mgbServerTypeAndLogLocation.Text = "Server type and log location";
		mlblLogFilesLocationHint.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		mlblLogFilesLocationHint.BackColor = SystemColors.Control;
		mlblLogFilesLocationHint.BorderStyle = BorderStyle.None;
		mlblLogFilesLocationHint.Cursor = Cursors.Default;
		mlblLogFilesLocationHint.ForeColor = SystemColors.ControlDarkDark;
		mlblLogFilesLocationHint.Location = new Point(28, 165);
		mlblLogFilesLocationHint.Multiline = true;
		mlblLogFilesLocationHint.Name = "m_lblLogFilesLocationHint";
		mlblLogFilesLocationHint.ReadOnly = true;
		mlblLogFilesLocationHint.Size = new Size(566, 69);
		mlblLogFilesLocationHint.TabIndex = 142;
		mlblLogFilesLocationHint.TabStop = false;
		mlblLogFilesLocationHint.Text = "<LOG_FILES_LOCATION_HINT>";
		medLogFileOrDirectory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		medLogFileOrDirectory.String_1 = null;
		medLogFileOrDirectory.Location = new Point(28, 137);
		medLogFileOrDirectory.Name = "m_edLogFileOrDirectory";
		medLogFileOrDirectory.Size = new Size(566, 22);
		medLogFileOrDirectory.TabIndex = 147;
		mlblLogFilesLocation.AutoSize = true;
		mlblLogFilesLocation.Location = new Point(15, 115);
		mlblLogFilesLocation.Name = "m_lblLogFilesLocation";
		mlblLogFilesLocation.Size = new Size(165, 16);
		mlblLogFilesLocation.TabIndex = 146;
		mlblLogFilesLocation.Text = "<LOG_FILES_LOCATION>";
		mlblServerTypeHint.AutoSize = true;
		mlblServerTypeHint.ForeColor = SystemColors.ControlDarkDark;
		mlblServerTypeHint.Location = new Point(25, 84);
		mlblServerTypeHint.Name = "m_lblServerTypeHint";
		mlblServerTypeHint.Size = new Size(329, 16);
		mlblServerTypeHint.TabIndex = 145;
		mlblServerTypeHint.Text = "Select SMTP server software installed on the machine.";
		mcbServerType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		mcbServerType.DropDownStyle = ComboBoxStyle.DropDownList;
		mcbServerType.FormattingEnabled = true;
		mcbServerType.Location = new Point(28, 54);
		mcbServerType.Name = "m_cbServerType";
		mcbServerType.Size = new Size(566, 23);
		mcbServerType.TabIndex = 144;
		mlblServerType.AutoSize = true;
		mlblServerType.Location = new Point(15, 32);
		mlblServerType.Name = "m_lblServerType";
		mlblServerType.Size = new Size(118, 16);
		mlblServerType.TabIndex = 143;
		mlblServerType.Text = "Select server type:";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.Controls.Add(mgbServerTypeAndLogLocation);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(4);
		base.Name = "SmtpMonitoringViaLogsControl";
		base.Size = new Size(600, 240);
		mgbServerTypeAndLogLocation.ResumeLayout(performLayout: false);
		mgbServerTypeAndLogLocation.PerformLayout();
		ResumeLayout(performLayout: false);
	}

	private void class0_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		AddTask();
	}
}
