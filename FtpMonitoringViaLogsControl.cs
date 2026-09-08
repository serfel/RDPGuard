using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

internal sealed class FtpMonitoringViaLogsControl : Control2
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<string, bool> _003C_003E9__16_0;

		internal bool InitializeHandlers(string string_0)
		{
			return !string.IsNullOrEmpty(string_0);
		}
	}

	private Size size_1 = new Size(490, 190);

	private Size size_2 = new Size(490, 260);

	public EventHandler<EventArgs> eventHandler_2;

	private IContainer icontainer_0;

	private Class65 mgbServerTypeAndLogLocation;

	private GClass2 mlblLogFilesLocationHint;

	private Class62 mlblServerType;

	private Class54 medLogFileOrDirectory;

	private DirectoriesTable mlstLogs;

	private Class62 mlblLogFilesLocation;

	private Class0 mcbServerType;

	private Class63 mlblServerTypeHint;

	public override Size Size_0
	{
		get
		{
			if (!Boolean_1)
			{
				return size_1;
			}
			return size_2;
		}
	}

	public GEnum7 GEnum7_0
	{
		get
		{
			return Class191.Class191_0[mcbServerType.Text];
		}
		set
		{
			mcbServerType.Text = Class191.Class191_0[value];
		}
	}

	public bool Boolean_1 => GEnum7_0 == GEnum7.const_0;

	public string[] String_0
	{
		get
		{
			if (!Boolean_1)
			{
				return new string[1] { medLogFileOrDirectory.Text };
			}
			return mlstLogs.String_0;
		}
		set
		{
			if (Boolean_1)
			{
				mlstLogs.String_0 = value;
			}
			else
			{
				medLogFileOrDirectory.Text = ((value.Length != 0) ? value[0] : string.Empty);
			}
			AdjustFormSize();
		}
	}

	protected override void OnFormClosing()
	{
		InitializeComponent();
		ComboBox.ObjectCollection items = mcbServerType.Items;
		object[] prop_ = Class191.Class191_0.Prop_1;
		object[] items2 = prop_;
		items.AddRange(items2);
	}

	protected override void InitializeFormPosition()
	{
		mcbServerType.SelectedIndexChanged += class0_0_SelectedIndexChanged;
		DirectoriesTable control = mlstLogs;
		control.eventHandler_0 = (EventHandler)Delegate.Combine(control.eventHandler_0, new EventHandler(RemoveTask));
	}

	private void AddTask()
	{
		if (Boolean_1)
		{
			medLogFileOrDirectory.Visible = false;
			mlstLogs.Visible = true;
			mlblLogFilesLocationHint.Top = mlstLogs.Bottom + 10;
			mlblLogFilesLocationHint.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		}
		else
		{
			medLogFileOrDirectory.Visible = true;
			mlstLogs.Visible = false;
			mlblLogFilesLocationHint.Top = medLogFileOrDirectory.Bottom + 6;
			mlblLogFilesLocationHint.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		}
		int num = base.Height - mlblLogFilesLocationHint.Top - 10;
		mlblLogFilesLocationHint.Height = num;
		eventHandler_2?.Invoke(this, EventArgs.Empty);
		switch (GEnum7_0)
		{
		default:
			mlblLogFilesLocation.Text = "Log file or directory:";
			mlblLogFilesLocationHint.Text = "Specify the log file/directory location";
			break;
		case GEnum7.const_0:
			mlblLogFilesLocation.Text = "Log files directory:";
			medLogFileOrDirectory.bool_0 = true;
			medLogFileOrDirectory.String_1 = "C:\\inetpub\\logs\\LogFiles";
			mlblLogFilesLocationHint.Text = "Specify one or multiple IIS FTP log file directories, for example C:\\inetpub\\logs\\LogFiles\\FTPSVC1";
			break;
		case GEnum7.const_1:
			mlblLogFilesLocation.Text = "Log files directory:";
			medLogFileOrDirectory.bool_0 = true;
			medLogFileOrDirectory.String_1 = "C:\\Program Files (x86)\\FileZilla Server\\Logs";
			mlblLogFilesLocationHint.Text = "Specify log files directory, usually C:\\Program Files (x86)\\FileZilla Server\\Logs";
			break;
		case GEnum7.const_2:
			mlblLogFilesLocation.Text = "Security log file:";
			medLogFileOrDirectory.bool_0 = false;
			medLogFileOrDirectory.String_1 = "C:\\Program Files\\Axigen Mail Server\\log";
			mlblLogFilesLocationHint.Text = "Specify the security log file location, usually C:\\Program Files\\Axigen Mail Server\\log\\security.txt";
			mlblLogFilesLocationHint.Text += "\r\n\r\nTo enable security logging set 'enableSecurityLog = yes' in the following config file:\r\n";
			mlblLogFilesLocationHint.Text += "C:\\Program Files\\Axigen Mail Server\\run\\axigen.cfg";
			break;
		case GEnum7.const_3:
			mlblLogFilesLocation.Text = "Log files directory:";
			medLogFileOrDirectory.bool_0 = true;
			medLogFileOrDirectory.String_1 = "C:\\ProgramData\\SolarWinds";
			mlblLogFilesLocationHint.Text = "Specify log files directory, usually C:\\ProgramData\\SolarWinds";
			break;
		case GEnum7.const_4:
			mlblLogFilesLocation.Text = "Log files directory:";
			medLogFileOrDirectory.bool_0 = true;
			medLogFileOrDirectory.String_1 = "C:\\Serv-U\\Logs";
			mlblLogFilesLocationHint.Text = "Specify dedicated log files directory, for example C:\\Serv-U\\Logs";
			mlblLogFilesLocationHint.Text += "\r\n\r\nTo enable logging to a dedicated directory open the Serv-U Management Console, Domain, Domain Activity, Settings and enable logging to file and specify the log file directory. The logging to file must be enabled for Security messages, FTP replies, SSH replies, HTTP replies";
			break;
		}
		AdjustFormSize();
	}

	protected override void AdjustFormSize()
	{
		int num;
		if (!String_0.IsNullOrEmpty())
		{
			string[] string_ = String_0;
			Func<string, bool> predicate = _003C_003Ec._003C_003E9.InitializeHandlers;
			num = (string_.All(predicate) ? 1 : 0);
		}
		else
		{
			num = 0;
		}
		base.Boolean_0 = (byte)num != 0;
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
		mlblServerType = new Class62();
		medLogFileOrDirectory = new Class54();
		mlstLogs = new DirectoriesTable();
		mlblLogFilesLocation = new Class62();
		mcbServerType = new Class0();
		mlblServerTypeHint = new Class63();
		mgbServerTypeAndLogLocation.SuspendLayout();
		SuspendLayout();
		mgbServerTypeAndLogLocation.Controls.Add(mlblLogFilesLocationHint);
		mgbServerTypeAndLogLocation.Controls.Add(mlblServerType);
		mgbServerTypeAndLogLocation.Controls.Add(medLogFileOrDirectory);
		mgbServerTypeAndLogLocation.Controls.Add(mlstLogs);
		mgbServerTypeAndLogLocation.Controls.Add(mlblLogFilesLocation);
		mgbServerTypeAndLogLocation.Controls.Add(mcbServerType);
		mgbServerTypeAndLogLocation.Controls.Add(mlblServerTypeHint);
		mgbServerTypeAndLogLocation.Dock = DockStyle.Fill;
		mgbServerTypeAndLogLocation.Location = new Point(0, 0);
		mgbServerTypeAndLogLocation.Name = "m_gbServerTypeAndLogLocation";
		mgbServerTypeAndLogLocation.Size = new Size(509, 266);
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
		mlblLogFilesLocationHint.Size = new Size(474, 64);
		mlblLogFilesLocationHint.TabIndex = 149;
		mlblLogFilesLocationHint.TabStop = false;
		mlblLogFilesLocationHint.Text = "<LOG_FILES_LOCATION_HINT>";
		mlblServerType.AutoSize = true;
		mlblServerType.Location = new Point(15, 32);
		mlblServerType.Name = "m_lblServerType";
		mlblServerType.Size = new Size(77, 16);
		mlblServerType.TabIndex = 144;
		mlblServerType.Text = "FTP server:";
		medLogFileOrDirectory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		medLogFileOrDirectory.String_1 = null;
		medLogFileOrDirectory.Location = new Point(28, 137);
		medLogFileOrDirectory.Name = "m_edLogFileOrDirectory";
		medLogFileOrDirectory.Size = new Size(475, 22);
		medLogFileOrDirectory.TabIndex = 148;
		mlstLogs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		mlstLogs.String_0 = new string[0];
		mlstLogs.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		mlstLogs.Location = new Point(28, 137);
		mlstLogs.Margin = new Padding(4);
		mlstLogs.Name = "m_lstLogs";
		mlstLogs.Size = new Size(474, 58);
		mlstLogs.TabIndex = 150;
		mlblLogFilesLocation.AutoSize = true;
		mlblLogFilesLocation.Location = new Point(15, 115);
		mlblLogFilesLocation.Name = "m_lblLogFilesLocation";
		mlblLogFilesLocation.Size = new Size(165, 16);
		mlblLogFilesLocation.TabIndex = 147;
		mlblLogFilesLocation.Text = "<LOG_FILES_LOCATION>";
		mcbServerType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		mcbServerType.DropDownStyle = ComboBoxStyle.DropDownList;
		mcbServerType.FormattingEnabled = true;
		mcbServerType.Location = new Point(28, 54);
		mcbServerType.Name = "m_cbServerType";
		mcbServerType.Size = new Size(475, 23);
		mcbServerType.TabIndex = 145;
		mlblServerTypeHint.AutoSize = true;
		mlblServerTypeHint.ForeColor = SystemColors.ControlDarkDark;
		mlblServerTypeHint.Location = new Point(25, 84);
		mlblServerTypeHint.Name = "m_lblServerTypeHint";
		mlblServerTypeHint.Size = new Size(317, 16);
		mlblServerTypeHint.TabIndex = 146;
		mlblServerTypeHint.Text = "Select FTP server software installed on the machine.";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.Controls.Add(mgbServerTypeAndLogLocation);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(4);
		base.Name = "FtpMonitoringViaLogsControl";
		base.Size = new Size(509, 266);
		mgbServerTypeAndLogLocation.ResumeLayout(performLayout: false);
		mgbServerTypeAndLogLocation.PerformLayout();
		ResumeLayout(performLayout: false);
	}

	private void class0_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		AddTask();
	}

	private void RemoveTask(object sender, EventArgs e)
	{
		AdjustFormSize();
	}
}
