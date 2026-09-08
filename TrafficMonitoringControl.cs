using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

internal sealed class TrafficMonitoringControl : Control2
{
	public ushort[] ushort_0;

	public bool bool_1 = true;

	public GClass24[] gclass24_0 = new GClass24[0];

	public Class127 class127_0 = Class127.class127_0;

	private IContainer icontainer_0;

	private Class65 mgbSelectMonitoringMethodForTraffic;

	private Class63 mlblMonitoringViaWinPcapHint;

	private Class63 mlblMonitoringViaRawSocketsHint;

	private Class64 mrbMonitoringViaWinPcap;

	private Class64 mrbMonitoringViaRawSockets;

	private Class65 mgbPort;

	private TextBox medPorts;

	private Class63 mlblPortHint;

	private GClass3 mlnkWinPcapConfiguration;

	private GClass3 mlnkRawSocketsConfiguration;

	private Class62 mlblWinPcapNote;

	private Class62 mlblRawSocketsWarning;

	public override Size Size_0 => new Size(480, 525);

	public string String_0
	{
		set
		{
			mgbSelectMonitoringMethodForTraffic.Text = value;
		}
	}

	public string String_1
	{
		set
		{
			mgbPort.Text = value;
		}
	}

	public string String_2
	{
		set
		{
			mlblPortHint.Text = value;
		}
	}

	public ushort[] UInt16_0
	{
		get
		{
			return Class168.smethod_1(medPorts.Text, ushort_0);
		}
		set
		{
			medPorts.Text = Class168.smethod_0(value);
		}
	}

	public GEnum5 GEnum5_0
	{
		get
		{
			if (mrbMonitoringViaRawSockets.Checked)
			{
				return GEnum5.const_0;
			}
			if (!mrbMonitoringViaWinPcap.Checked)
			{
				throw new NotImplementedException("TrafficMonitoringControl::MonitoringMethod::get: unknown_monitoring_method");
			}
			return GEnum5.const_1;
		}
		set
		{
			switch (value)
			{
			default:
				throw new NotImplementedException("TrafficMonitoringControl::MonitoringMethod::set: unknown_monitoring_method");
			case GEnum5.const_1:
				mrbMonitoringViaRawSockets.Checked = false;
				mrbMonitoringViaWinPcap.Checked = true;
				break;
			case GEnum5.const_0:
				mrbMonitoringViaRawSockets.Checked = true;
				mrbMonitoringViaWinPcap.Checked = false;
				break;
			}
		}
	}

	public TrafficMonitoringControl(ushort[] ushort_1)
	{
			InitializeComponent();
		ushort_0 = ushort_1;
	}

	protected override void OnFormClosing()
	{
		InitializeComponent();
		mlblRawSocketsWarning.Left = mrbMonitoringViaRawSockets.Right;
		mlnkRawSocketsConfiguration.Left = mlblRawSocketsWarning.Right + 5;
		mlblWinPcapNote.Left = mrbMonitoringViaWinPcap.Right;
		mlnkWinPcapConfiguration.Left = mlblWinPcapNote.Right + 5;
	}

	protected override void InitializeFormPosition()
	{
		base.EnabledChanged += Control12_EnabledChanged;
		mrbMonitoringViaRawSockets.CheckedChanged += mrbMonitoringViaRawSockets_CheckedChanged;
		mrbMonitoringViaWinPcap.CheckedChanged += mrbMonitoringViaWinPcap_CheckedChanged;
		mlnkRawSocketsConfiguration.Click += mlnkRawSocketsConfiguration_Click;
		mlnkWinPcapConfiguration.Click += mlnkWinPcapConfiguration_Click;
		mlblRawSocketsWarning.Click += mlblRawSocketsWarning_Click;
		mlblWinPcapNote.Click += mlblWinPcapNote_Click;
	}

	protected override void AdjustFormSize()
	{
		base.Boolean_0 = (mrbMonitoringViaRawSockets.Checked ? true : false) || (mrbMonitoringViaWinPcap.Checked && !class127_0.Boolean_0);
	}

	private void AddTask()
	{
		mlnkRawSocketsConfiguration.Enabled = base.Enabled && mrbMonitoringViaRawSockets.Checked;
		EditTask(mlnkRawSocketsConfiguration);
		mlnkWinPcapConfiguration.Enabled = base.Enabled && mrbMonitoringViaWinPcap.Checked;
		EditTask(mlnkWinPcapConfiguration);
		AdjustFormSize();
	}

	private void EditTask(Control control_0)
	{
		control_0.Font = new Font(control_0.Font, (control_0.Enabled ? true : false) ? FontStyle.Bold : FontStyle.Regular);
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
		mgbSelectMonitoringMethodForTraffic = new Class65();
		mlblWinPcapNote = new Class62();
		mlblRawSocketsWarning = new Class62();
		mlnkWinPcapConfiguration = new GClass3();
		mlnkRawSocketsConfiguration = new GClass3();
		mlblMonitoringViaWinPcapHint = new Class63();
		mlblMonitoringViaRawSocketsHint = new Class63();
		mrbMonitoringViaWinPcap = new Class64();
		mrbMonitoringViaRawSockets = new Class64();
		mgbPort = new Class65();
		medPorts = new TextBox();
		mlblPortHint = new Class63();
		mgbSelectMonitoringMethodForTraffic.SuspendLayout();
		mgbPort.SuspendLayout();
		SuspendLayout();
		mgbSelectMonitoringMethodForTraffic.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		mgbSelectMonitoringMethodForTraffic.Controls.Add(mlblWinPcapNote);
		mgbSelectMonitoringMethodForTraffic.Controls.Add(mlblRawSocketsWarning);
		mgbSelectMonitoringMethodForTraffic.Controls.Add(mlnkWinPcapConfiguration);
		mgbSelectMonitoringMethodForTraffic.Controls.Add(mlnkRawSocketsConfiguration);
		mgbSelectMonitoringMethodForTraffic.Controls.Add(mlblMonitoringViaWinPcapHint);
		mgbSelectMonitoringMethodForTraffic.Controls.Add(mlblMonitoringViaRawSocketsHint);
		mgbSelectMonitoringMethodForTraffic.Controls.Add(mrbMonitoringViaWinPcap);
		mgbSelectMonitoringMethodForTraffic.Controls.Add(mrbMonitoringViaRawSockets);
		mgbSelectMonitoringMethodForTraffic.Location = new Point(0, 0);
		mgbSelectMonitoringMethodForTraffic.Name = "m_gbSelectMonitoringMethodForTraffic";
		mgbSelectMonitoringMethodForTraffic.Size = new Size(585, 142);
		mgbSelectMonitoringMethodForTraffic.TabIndex = 134;
		mgbSelectMonitoringMethodForTraffic.TabStop = false;
		mgbSelectMonitoringMethodForTraffic.Text = "{MONITORING_METHOD_CAPTION}";
		mlblWinPcapNote.AutoSize = true;
		mlblWinPcapNote.ForeColor = Color.Green;
		mlblWinPcapNote.Location = new Point(286, 34);
		mlblWinPcapNote.Name = "m_lblWinPcapNote";
		mlblWinPcapNote.Size = new Size(103, 16);
		mlblWinPcapNote.TabIndex = 140;
		mlblWinPcapNote.Text = "(recommended)";
		mlblWinPcapNote.Boolean_0 = true;
		mlblRawSocketsWarning.AutoSize = true;
		mlblRawSocketsWarning.ForeColor = Color.Red;
		mlblRawSocketsWarning.Location = new Point(286, 87);
		mlblRawSocketsWarning.Name = "m_lblRawSocketsWarning";
		mlblRawSocketsWarning.Size = new Size(204, 16);
		mlblRawSocketsWarning.TabIndex = 139;
		mlblRawSocketsWarning.Text = "(may affect network performance)";
		mlblRawSocketsWarning.Boolean_0 = true;
		mlnkWinPcapConfiguration.AutoSize = true;
		mlnkWinPcapConfiguration.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		mlnkWinPcapConfiguration.LinkBehavior = LinkBehavior.NeverUnderline;
		mlnkWinPcapConfiguration.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkWinPcapConfiguration.Location = new Point(497, 34);
		mlnkWinPcapConfiguration.Name = "m_lnkWinPcapConfiguration";
		mlnkWinPcapConfiguration.Size = new Size(79, 16);
		mlnkWinPcapConfiguration.TabIndex = 138;
		mlnkWinPcapConfiguration.TabStop = true;
		mlnkWinPcapConfiguration.Text = "configure..";
		mlnkWinPcapConfiguration.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		mlnkRawSocketsConfiguration.AutoSize = true;
		mlnkRawSocketsConfiguration.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		mlnkRawSocketsConfiguration.LinkBehavior = LinkBehavior.NeverUnderline;
		mlnkRawSocketsConfiguration.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkRawSocketsConfiguration.Location = new Point(497, 87);
		mlnkRawSocketsConfiguration.Name = "m_lnkRawSocketsConfiguration";
		mlnkRawSocketsConfiguration.Size = new Size(79, 16);
		mlnkRawSocketsConfiguration.TabIndex = 137;
		mlnkRawSocketsConfiguration.TabStop = true;
		mlnkRawSocketsConfiguration.Text = "configure..";
		mlnkRawSocketsConfiguration.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		mlblMonitoringViaWinPcapHint.AutoSize = true;
		mlblMonitoringViaWinPcapHint.ForeColor = SystemColors.ControlDarkDark;
		mlblMonitoringViaWinPcapHint.Location = new Point(12, 55);
		mlblMonitoringViaWinPcapHint.Name = "m_lblMonitoringViaWinPcapHint";
		mlblMonitoringViaWinPcapHint.Size = new Size(401, 16);
		mlblMonitoringViaWinPcapHint.TabIndex = 136;
		mlblMonitoringViaWinPcapHint.Text = "Works on all Windows editions. WinPcap/Npcap must be installed.";
		mlblMonitoringViaRawSocketsHint.AutoSize = true;
		mlblMonitoringViaRawSocketsHint.ForeColor = SystemColors.ControlDarkDark;
		mlblMonitoringViaRawSocketsHint.Location = new Point(12, 108);
		mlblMonitoringViaRawSocketsHint.Name = "m_lblMonitoringViaRawSocketsHint";
		mlblMonitoringViaRawSocketsHint.Size = new Size(505, 16);
		mlblMonitoringViaRawSocketsHint.TabIndex = 135;
		mlblMonitoringViaRawSocketsHint.Text = "May work slow. May not work on some Windows Editions. May not work with firewalls.";
		mrbMonitoringViaWinPcap.AutoSize = true;
		mrbMonitoringViaWinPcap.Location = new Point(15, 32);
		mrbMonitoringViaWinPcap.Name = "m_rbMonitoringViaWinPcap";
		mrbMonitoringViaWinPcap.Size = new Size(125, 20);
		mrbMonitoringViaWinPcap.TabIndex = 134;
		mrbMonitoringViaWinPcap.TabStop = true;
		mrbMonitoringViaWinPcap.Text = "WinPcap/Npcap";
		mrbMonitoringViaWinPcap.UseVisualStyleBackColor = true;
		mrbMonitoringViaRawSockets.AutoSize = true;
		mrbMonitoringViaRawSockets.Location = new Point(15, 85);
		mrbMonitoringViaRawSockets.Name = "m_rbMonitoringViaRawSockets";
		mrbMonitoringViaRawSockets.Size = new Size(104, 20);
		mrbMonitoringViaRawSockets.TabIndex = 133;
		mrbMonitoringViaRawSockets.TabStop = true;
		mrbMonitoringViaRawSockets.Text = "Raw Sockets";
		mrbMonitoringViaRawSockets.UseVisualStyleBackColor = true;
		mgbPort.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		mgbPort.Controls.Add(medPorts);
		mgbPort.Controls.Add(mlblPortHint);
		mgbPort.Location = new Point(0, 148);
		mgbPort.Name = "m_gbPort";
		mgbPort.Size = new Size(585, 88);
		mgbPort.TabIndex = 135;
		mgbPort.TabStop = false;
		mgbPort.Text = "{PORT_CAPTION}";
		medPorts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		medPorts.Location = new Point(15, 32);
		medPorts.Name = "m_edPorts";
		medPorts.Size = new Size(564, 22);
		medPorts.TabIndex = 130;
		mlblPortHint.AutoSize = true;
		mlblPortHint.ForeColor = SystemColors.ControlDarkDark;
		mlblPortHint.Location = new Point(12, 60);
		mlblPortHint.Name = "m_lblPortHint";
		mlblPortHint.Size = new Size(94, 16);
		mlblPortHint.TabIndex = 129;
		mlblPortHint.Text = "{PORT_HINT}";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.Controls.Add(mgbPort);
		base.Controls.Add(mgbSelectMonitoringMethodForTraffic);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Name = "TrafficMonitoringControl";
		base.Size = new Size(585, 241);
		mgbSelectMonitoringMethodForTraffic.ResumeLayout(performLayout: false);
		mgbSelectMonitoringMethodForTraffic.PerformLayout();
		mgbPort.ResumeLayout(performLayout: false);
		mgbPort.PerformLayout();
		ResumeLayout(performLayout: false);
	}

	private void Control12_EnabledChanged(object sender, EventArgs e)
	{
		AddTask();
	}

	private void mrbMonitoringViaRawSockets_CheckedChanged(object sender, EventArgs e)
	{
		AddTask();
	}

	private void mrbMonitoringViaWinPcap_CheckedChanged(object sender, EventArgs e)
	{
		AddTask();
	}

	private void mlnkRawSocketsConfiguration_Click(object sender, EventArgs e)
	{
		RawSocketsDialog form = new RawSocketsDialog
		{
			Boolean_0 = bool_1,
			GClass24_0 = gclass24_0
		};
		using (form)
		{
			if (DialogResult.OK == form.ShowDialog())
			{
				bool_1 = form.Boolean_0;
				gclass24_0 = form.GClass24_0;
			}
		}
	}

	private void mlnkWinPcapConfiguration_Click(object sender, EventArgs e)
	{
		using WinPcapDialog form = new WinPcapDialog(class127_0);
		if (DialogResult.OK == form.ShowDialog())
		{
			Class127 @class = form.Class127_0;
			if (@class == null)
			{
				@class = Class127.class127_0;
			}
			class127_0 = @class;
			AdjustFormSize();
		}
	}

	private void mlblRawSocketsWarning_Click(object sender, EventArgs e)
	{
		mrbMonitoringViaRawSockets.Checked = true;
	}

	private void mlblWinPcapNote_Click(object sender, EventArgs e)
	{
		mrbMonitoringViaWinPcap.Checked = true;
	}
}
