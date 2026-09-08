using System;
using System.Windows.Forms;

internal class Class47 : GClass0
{
	private DateTime dateTime_0 = DateTime.MinValue;

	protected override void WndProc(ref Message message_0)
	{
		if (4139 != message_0.Msg || !((DateTime.Now - dateTime_0).TotalSeconds < 1.0))
		{
			if (message_0.Msg == 515)
			{
				OnMouseDoubleClick(null);
			}
			else
			{
				base.WndProc(ref message_0);
			}
		}
	}

	protected override void OnMouseCaptureChanged(EventArgs eventArgs_0)
	{
		dateTime_0 = DateTime.Now;
		base.OnMouseCaptureChanged(eventArgs_0);
	}
}
