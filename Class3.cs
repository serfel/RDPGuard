using System;
using System.Windows.Forms;
using rdpguard.lib;

internal sealed class Class3
{
	public EventHandler<EventArgs> eventHandler_0;

	private readonly RadioButton radioButton_0;

	private readonly RadioButton radioButton_1;

	private readonly RadioButton radioButton_2;

	private readonly TextBox textBox_0;

	private readonly TextBox textBox_1;

	public Class3(RadioButton radioButton_3, RadioButton radioButton_4, TextBox textBox_2, RadioButton radioButton_5, TextBox textBox_3)
	{
		radioButton_0 = radioButton_3;
		radioButton_1 = radioButton_4;
		radioButton_2 = radioButton_5;
		textBox_0 = textBox_2;
		textBox_1 = textBox_3;
		method_0();
	}

	private void method_0()
	{
		if (radioButton_0 != null)
		{
			radioButton_0.CheckedChanged += radioButton_0_CheckedChanged;
		}
		if (radioButton_1 != null)
		{
			radioButton_1.CheckedChanged += radioButton_1_CheckedChanged;
		}
		if (textBox_0 != null)
		{
			textBox_0.TextChanged += textBox_0_TextChanged;
		}
		if (radioButton_2 != null)
		{
			radioButton_2.CheckedChanged += radioButton_2_CheckedChanged;
		}
		if (textBox_1 != null)
		{
			textBox_1.TextChanged += textBox_1_TextChanged;
		}
	}

	public GClass7 method_1()
	{
		PortsMode portsMode = PortsMode.Unknown;
		if (radioButton_0 != null && radioButton_0.Checked)
		{
			portsMode = PortsMode.AllPorts;
		}
		if (radioButton_1 != null && radioButton_1.Checked)
		{
			portsMode = PortsMode.AllExceptSelected;
		}
		if (radioButton_2 != null && radioButton_2.Checked)
		{
			portsMode = PortsMode.SelectedOnly;
		}
		ushort[] ushort_ = Array.Empty<ushort>();
		if (PortsMode.AllExceptSelected == portsMode)
		{
			ushort_ = Class168.smethod_1(textBox_0?.Text);
		}
		if (PortsMode.SelectedOnly == portsMode)
		{
			ushort_ = Class168.smethod_1(textBox_1?.Text);
		}
		return new GClass7
		{
			portsMode_0 = portsMode,
			ushort_0 = ushort_
		};
	}

	public void method_2(GClass7 gclass7_0)
	{
		GClass7 gClass = gclass7_0;
		if ((object)gClass == null)
		{
			gClass = new GClass7();
		}
		GClass7 gClass2 = gClass;
		if (radioButton_0 != null)
		{
			radioButton_0.Checked = gClass2.portsMode_0 == PortsMode.AllPorts;
		}
		if (radioButton_1 != null)
		{
			radioButton_1.Checked = PortsMode.AllExceptSelected == gClass2.portsMode_0;
		}
		if (radioButton_2 != null)
		{
			radioButton_2.Checked = PortsMode.SelectedOnly == gClass2.portsMode_0;
		}
		method_3(textBox_1);
		method_3(textBox_0);
		if (PortsMode.AllExceptSelected == gClass2.portsMode_0)
		{
			method_3(textBox_0, Class168.smethod_0(gClass2.ushort_0));
		}
		if (PortsMode.SelectedOnly == gClass2.portsMode_0)
		{
			method_3(textBox_1, Class168.smethod_0(gClass2.ushort_0));
		}
	}

	private void method_3(TextBox textBox_2, string string_0 = "")
	{
		if (textBox_2 != null)
		{
			textBox_2.Text = string_0;
		}
	}

	private void method_4(TextBox textBox_2, bool bool_0)
	{
		if (textBox_2 != null)
		{
			textBox_2.Enabled = bool_0;
		}
	}

	private void radioButton_0_CheckedChanged(object sender, EventArgs e)
	{
		eventHandler_0?.Invoke(this, EventArgs.Empty);
	}

	private void radioButton_1_CheckedChanged(object sender, EventArgs e)
	{
		method_4(textBox_0, radioButton_1.Checked);
		eventHandler_0?.Invoke(this, EventArgs.Empty);
	}

	private void textBox_0_TextChanged(object sender, EventArgs e)
	{
		eventHandler_0?.Invoke(this, EventArgs.Empty);
	}

	private void radioButton_2_CheckedChanged(object sender, EventArgs e)
	{
		method_4(textBox_1, radioButton_2.Checked);
		eventHandler_0?.Invoke(this, EventArgs.Empty);
	}

	private void textBox_1_TextChanged(object sender, EventArgs e)
	{
		eventHandler_0?.Invoke(this, EventArgs.Empty);
	}
}
