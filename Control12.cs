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

	private Class65 class65_0;

	private Class63 class63_0;

	private Class63 class63_1;

	private Class64 class64_0;

	private Class64 class64_1;

	private Class65 class65_1;

	private TextBox textBox_0;

	private Class63 class63_2;

	private GClass3 gclass3_0;

	private GClass3 gclass3_1;

	private Class62 class62_0;

	private Class62 class62_1;

	public override Size Size_0 => new Size(480, 525);

	public string String_0
	{
		set
		{
			class65_0.Text = value;
		}
	}

	public string String_1
	{
		set
		{
			class65_1.Text = value;
		}
	}

	public string String_2
	{
		set
		{
			class63_2.Text = value;
		}
	}

	public ushort[] UInt16_0
	{
		get
		{
			return Class168.smethod_1(textBox_0.Text, ushort_0);
		}
		set
		{
			textBox_0.Text = Class168.smethod_0(value);
		}
	}

	public GEnum5 GEnum5_0
	{
		get
		{
			if (class64_1.Checked)
			{
				return GEnum5.const_0;
			}
			if (!class64_0.Checked)
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
				class64_1.Checked = false;
				class64_0.Checked = true;
				break;
			case GEnum5.const_0:
				class64_1.Checked = true;
				class64_0.Checked = false;
				break;
			}
		}
	}

	public TrafficMonitoringControl(ushort[] ushort_1)
	{
		ushort_0 = ushort_1;
	}

	protected override void vmethod_0()
	{
		method_3();
		class62_1.Left = class64_1.Right;
		gclass3_1.Left = class62_1.Right + 5;
		class62_0.Left = class64_0.Right;
		gclass3_0.Left = class62_0.Right + 5;
	}

	protected override void vmethod_1()
	{
		base.EnabledChanged += Control12_EnabledChanged;
		class64_1.CheckedChanged += class64_1_CheckedChanged;
		class64_0.CheckedChanged += class64_0_CheckedChanged;
		gclass3_1.Click += gclass3_1_Click;
		gclass3_0.Click += gclass3_0_Click;
		class62_1.Click += class62_1_Click;
		class62_0.Click += class62_0_Click;
	}

	protected override void vmethod_2()
	{
		base.Boolean_0 = (class64_1.Checked ? true : false) || (class64_0.Checked && !class127_0.Boolean_0);
	}

	private void method_1()
	{
		gclass3_1.Enabled = base.Enabled && class64_1.Checked;
		method_2(gclass3_1);
		gclass3_0.Enabled = base.Enabled && class64_0.Checked;
		method_2(gclass3_0);
		vmethod_2();
	}

	private void method_2(Control control_0)
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

	private void method_3()
	{
		class65_0 = new Class65();
		class62_0 = new Class62();
		class62_1 = new Class62();
		gclass3_0 = new GClass3();
		gclass3_1 = new GClass3();
		class63_0 = new Class63();
		class63_1 = new Class63();
		class64_0 = new Class64();
		class64_1 = new Class64();
		class65_1 = new Class65();
		textBox_0 = new TextBox();
		class63_2 = new Class63();
		class65_0.SuspendLayout();
		class65_1.SuspendLayout();
		SuspendLayout();
		class65_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		class65_0.Controls.Add(class62_0);
		class65_0.Controls.Add(class62_1);
		class65_0.Controls.Add(gclass3_0);
		class65_0.Controls.Add(gclass3_1);
		class65_0.Controls.Add(class63_0);
		class65_0.Controls.Add(class63_1);
		class65_0.Controls.Add(class64_0);
		class65_0.Controls.Add(class64_1);
		class65_0.Location = new Point(0, 0);
		class65_0.Name = "m_gbSelectMonitoringMethodForTraffic";
		class65_0.Size = new Size(585, 142);
		class65_0.TabIndex = 134;
		class65_0.TabStop = false;
		class65_0.Text = "{MONITORING_METHOD_CAPTION}";
		class62_0.AutoSize = true;
		class62_0.ForeColor = Color.Green;
		class62_0.Location = new Point(286, 34);
		class62_0.Name = "m_lblWinPcapNote";
		class62_0.Size = new Size(103, 16);
		class62_0.TabIndex = 140;
		class62_0.Text = "(recommended)";
		class62_0.Boolean_0 = true;
		class62_1.AutoSize = true;
		class62_1.ForeColor = Color.Red;
		class62_1.Location = new Point(286, 87);
		class62_1.Name = "m_lblRawSocketsWarning";
		class62_1.Size = new Size(204, 16);
		class62_1.TabIndex = 139;
		class62_1.Text = "(may affect network performance)";
		class62_1.Boolean_0 = true;
		gclass3_0.AutoSize = true;
		gclass3_0.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		gclass3_0.LinkBehavior = LinkBehavior.NeverUnderline;
		gclass3_0.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_0.Location = new Point(497, 34);
		gclass3_0.Name = "m_lnkWinPcapConfiguration";
		gclass3_0.Size = new Size(79, 16);
		gclass3_0.TabIndex = 138;
		gclass3_0.TabStop = true;
		gclass3_0.Text = "configure..";
		gclass3_0.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		gclass3_1.AutoSize = true;
		gclass3_1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		gclass3_1.LinkBehavior = LinkBehavior.NeverUnderline;
		gclass3_1.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_1.Location = new Point(497, 87);
		gclass3_1.Name = "m_lnkRawSocketsConfiguration";
		gclass3_1.Size = new Size(79, 16);
		gclass3_1.TabIndex = 137;
		gclass3_1.TabStop = true;
		gclass3_1.Text = "configure..";
		gclass3_1.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		class63_0.AutoSize = true;
		class63_0.ForeColor = SystemColors.ControlDarkDark;
		class63_0.Location = new Point(12, 55);
		class63_0.Name = "m_lblMonitoringViaWinPcapHint";
		class63_0.Size = new Size(401, 16);
		class63_0.TabIndex = 136;
		class63_0.Text = "Works on all Windows editions. WinPcap/Npcap must be installed.";
		class63_1.AutoSize = true;
		class63_1.ForeColor = SystemColors.ControlDarkDark;
		class63_1.Location = new Point(12, 108);
		class63_1.Name = "m_lblMonitoringViaRawSocketsHint";
		class63_1.Size = new Size(505, 16);
		class63_1.TabIndex = 135;
		class63_1.Text = "May work slow. May not work on some Windows Editions. May not work with firewalls.";
		class64_0.AutoSize = true;
		class64_0.Location = new Point(15, 32);
		class64_0.Name = "m_rbMonitoringViaWinPcap";
		class64_0.Size = new Size(125, 20);
		class64_0.TabIndex = 134;
		class64_0.TabStop = true;
		class64_0.Text = "WinPcap/Npcap";
		class64_0.UseVisualStyleBackColor = true;
		class64_1.AutoSize = true;
		class64_1.Location = new Point(15, 85);
		class64_1.Name = "m_rbMonitoringViaRawSockets";
		class64_1.Size = new Size(104, 20);
		class64_1.TabIndex = 133;
		class64_1.TabStop = true;
		class64_1.Text = "Raw Sockets";
		class64_1.UseVisualStyleBackColor = true;
		class65_1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		class65_1.Controls.Add(textBox_0);
		class65_1.Controls.Add(class63_2);
		class65_1.Location = new Point(0, 148);
		class65_1.Name = "m_gbPort";
		class65_1.Size = new Size(585, 88);
		class65_1.TabIndex = 135;
		class65_1.TabStop = false;
		class65_1.Text = "{PORT_CAPTION}";
		textBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		textBox_0.Location = new Point(15, 32);
		textBox_0.Name = "m_edPorts";
		textBox_0.Size = new Size(564, 22);
		textBox_0.TabIndex = 130;
		class63_2.AutoSize = true;
		class63_2.ForeColor = SystemColors.ControlDarkDark;
		class63_2.Location = new Point(12, 60);
		class63_2.Name = "m_lblPortHint";
		class63_2.Size = new Size(94, 16);
		class63_2.TabIndex = 129;
		class63_2.Text = "{PORT_HINT}";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.Controls.Add(class65_1);
		base.Controls.Add(class65_0);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Name = "TrafficMonitoringControl";
		base.Size = new Size(585, 241);
		class65_0.ResumeLayout(performLayout: false);
		class65_0.PerformLayout();
		class65_1.ResumeLayout(performLayout: false);
		class65_1.PerformLayout();
		ResumeLayout(performLayout: false);
	}

	private void Control12_EnabledChanged(object sender, EventArgs e)
	{
		method_1();
	}

	private void class64_1_CheckedChanged(object sender, EventArgs e)
	{
		method_1();
	}

	private void class64_0_CheckedChanged(object sender, EventArgs e)
	{
		method_1();
	}

	private void gclass3_1_Click(object sender, EventArgs e)
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

	private void gclass3_0_Click(object sender, EventArgs e)
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
			vmethod_2();
		}
	}

	private void class62_1_Click(object sender, EventArgs e)
	{
		class64_1.Checked = true;
	}

	private void class62_0_Click(object sender, EventArgs e)
	{
		class64_0.Checked = true;
	}
}
