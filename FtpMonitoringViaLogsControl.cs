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

		internal bool method_0(string string_0)
		{
			return !string.IsNullOrEmpty(string_0);
		}
	}

	private Size size_1 = new Size(490, 190);

	private Size size_2 = new Size(490, 260);

	public EventHandler<EventArgs> eventHandler_2;

	private IContainer icontainer_0;

	private Class65 class65_0;

	private GClass2 gclass2_0;

	private Class62 class62_0;

	private Class54 class54_0;

	private DirectoriesTable control15_0;

	private Class62 class62_1;

	private Class0 class0_0;

	private Class63 class63_0;

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
			return Class191.Class191_0[class0_0.Text];
		}
		set
		{
			class0_0.Text = Class191.Class191_0[value];
		}
	}

	public bool Boolean_1 => GEnum7_0 == GEnum7.const_0;

	public string[] String_0
	{
		get
		{
			if (!Boolean_1)
			{
				return new string[1] { class54_0.Text };
			}
			return control15_0.String_0;
		}
		set
		{
			if (Boolean_1)
			{
				control15_0.String_0 = value;
			}
			else
			{
				class54_0.Text = ((value.Length != 0) ? value[0] : string.Empty);
			}
			vmethod_2();
		}
	}

	protected override void vmethod_0()
	{
		InitializeComponent();
		ComboBox.ObjectCollection items = class0_0.Items;
		object[] prop_ = Class191.Class191_0.Prop_1;
		object[] items2 = prop_;
		items.AddRange(items2);
	}

	protected override void vmethod_1()
	{
		class0_0.SelectedIndexChanged += class0_0_SelectedIndexChanged;
		DirectoriesTable control = control15_0;
		control.eventHandler_0 = (EventHandler)Delegate.Combine(control.eventHandler_0, new EventHandler(method_3));
	}

	private void method_1()
	{
		if (Boolean_1)
		{
			class54_0.Visible = false;
			control15_0.Visible = true;
			gclass2_0.Top = control15_0.Bottom + 10;
			gclass2_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		}
		else
		{
			class54_0.Visible = true;
			control15_0.Visible = false;
			gclass2_0.Top = class54_0.Bottom + 6;
			gclass2_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		}
		int num = base.Height - gclass2_0.Top - 10;
		gclass2_0.Height = num;
		eventHandler_2?.Invoke(this, EventArgs.Empty);
		switch (GEnum7_0)
		{
		default:
			class62_1.Text = "Log file or directory:";
			gclass2_0.Text = "Specify the log file/directory location";
			break;
		case GEnum7.const_0:
			class62_1.Text = "Log files directory:";
			class54_0.bool_0 = true;
			class54_0.String_1 = "C:\\inetpub\\logs\\LogFiles";
			gclass2_0.Text = "Specify one or multiple IIS FTP log file directories, for example C:\\inetpub\\logs\\LogFiles\\FTPSVC1";
			break;
		case GEnum7.const_1:
			class62_1.Text = "Log files directory:";
			class54_0.bool_0 = true;
			class54_0.String_1 = "C:\\Program Files (x86)\\FileZilla Server\\Logs";
			gclass2_0.Text = "Specify log files directory, usually C:\\Program Files (x86)\\FileZilla Server\\Logs";
			break;
		case GEnum7.const_2:
			class62_1.Text = "Security log file:";
			class54_0.bool_0 = false;
			class54_0.String_1 = "C:\\Program Files\\Axigen Mail Server\\log";
			gclass2_0.Text = "Specify the security log file location, usually C:\\Program Files\\Axigen Mail Server\\log\\security.txt";
			gclass2_0.Text += "\r\n\r\nTo enable security logging set 'enableSecurityLog = yes' in the following config file:\r\n";
			gclass2_0.Text += "C:\\Program Files\\Axigen Mail Server\\run\\axigen.cfg";
			break;
		case GEnum7.const_3:
			class62_1.Text = "Log files directory:";
			class54_0.bool_0 = true;
			class54_0.String_1 = "C:\\ProgramData\\SolarWinds";
			gclass2_0.Text = "Specify log files directory, usually C:\\ProgramData\\SolarWinds";
			break;
		case GEnum7.const_4:
			class62_1.Text = "Log files directory:";
			class54_0.bool_0 = true;
			class54_0.String_1 = "C:\\Serv-U\\Logs";
			gclass2_0.Text = "Specify dedicated log files directory, for example C:\\Serv-U\\Logs";
			gclass2_0.Text += "\r\n\r\nTo enable logging to a dedicated directory open the Serv-U Management Console, Domain, Domain Activity, Settings and enable logging to file and specify the log file directory. The logging to file must be enabled for Security messages, FTP replies, SSH replies, HTTP replies";
			break;
		}
		vmethod_2();
	}

	protected override void vmethod_2()
	{
		int num;
		if (!String_0.IsNullOrEmpty())
		{
			string[] string_ = String_0;
			Func<string, bool> predicate = _003C_003Ec._003C_003E9.method_0;
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
		class65_0 = new Class65();
		gclass2_0 = new GClass2();
		class62_0 = new Class62();
		class54_0 = new Class54();
		control15_0 = new DirectoriesTable();
		class62_1 = new Class62();
		class0_0 = new Class0();
		class63_0 = new Class63();
		class65_0.SuspendLayout();
		SuspendLayout();
		class65_0.Controls.Add(gclass2_0);
		class65_0.Controls.Add(class62_0);
		class65_0.Controls.Add(class54_0);
		class65_0.Controls.Add(control15_0);
		class65_0.Controls.Add(class62_1);
		class65_0.Controls.Add(class0_0);
		class65_0.Controls.Add(class63_0);
		class65_0.Dock = DockStyle.Fill;
		class65_0.Location = new Point(0, 0);
		class65_0.Name = "m_gbServerTypeAndLogLocation";
		class65_0.Size = new Size(509, 266);
		class65_0.TabIndex = 0;
		class65_0.TabStop = false;
		class65_0.Text = "Server type and log location";
		gclass2_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gclass2_0.BackColor = SystemColors.Control;
		gclass2_0.BorderStyle = BorderStyle.None;
		gclass2_0.Cursor = Cursors.Default;
		gclass2_0.ForeColor = SystemColors.ControlDarkDark;
		gclass2_0.Location = new Point(28, 165);
		gclass2_0.Multiline = true;
		gclass2_0.Name = "m_lblLogFilesLocationHint";
		gclass2_0.ReadOnly = true;
		gclass2_0.Size = new Size(474, 64);
		gclass2_0.TabIndex = 149;
		gclass2_0.TabStop = false;
		gclass2_0.Text = "<LOG_FILES_LOCATION_HINT>";
		class62_0.AutoSize = true;
		class62_0.Location = new Point(15, 32);
		class62_0.Name = "m_lblServerType";
		class62_0.Size = new Size(77, 16);
		class62_0.TabIndex = 144;
		class62_0.Text = "FTP server:";
		class54_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		class54_0.String_1 = null;
		class54_0.Location = new Point(28, 137);
		class54_0.Name = "m_edLogFileOrDirectory";
		class54_0.Size = new Size(475, 22);
		class54_0.TabIndex = 148;
		control15_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		control15_0.String_0 = new string[0];
		control15_0.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		control15_0.Location = new Point(28, 137);
		control15_0.Margin = new Padding(4);
		control15_0.Name = "m_lstLogs";
		control15_0.Size = new Size(474, 58);
		control15_0.TabIndex = 150;
		class62_1.AutoSize = true;
		class62_1.Location = new Point(15, 115);
		class62_1.Name = "m_lblLogFilesLocation";
		class62_1.Size = new Size(165, 16);
		class62_1.TabIndex = 147;
		class62_1.Text = "<LOG_FILES_LOCATION>";
		class0_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		class0_0.DropDownStyle = ComboBoxStyle.DropDownList;
		class0_0.FormattingEnabled = true;
		class0_0.Location = new Point(28, 54);
		class0_0.Name = "m_cbServerType";
		class0_0.Size = new Size(475, 23);
		class0_0.TabIndex = 145;
		class63_0.AutoSize = true;
		class63_0.ForeColor = SystemColors.ControlDarkDark;
		class63_0.Location = new Point(25, 84);
		class63_0.Name = "m_lblServerTypeHint";
		class63_0.Size = new Size(317, 16);
		class63_0.TabIndex = 146;
		class63_0.Text = "Select FTP server software installed on the machine.";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.Controls.Add(class65_0);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(4);
		base.Name = "FtpMonitoringViaLogsControl";
		base.Size = new Size(509, 266);
		class65_0.ResumeLayout(performLayout: false);
		class65_0.PerformLayout();
		ResumeLayout(performLayout: false);
	}

	private void class0_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		method_1();
	}

	private void method_3(object sender, EventArgs e)
	{
		vmethod_2();
	}
}
