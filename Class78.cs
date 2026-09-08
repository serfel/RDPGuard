using System;
using System.Windows.Forms;

internal sealed class Class78 : Timer
{
	public EventHandler eventHandler_0;

	protected override void OnTick(EventArgs eventArgs_0)
	{
		eventHandler_0?.Invoke(this, eventArgs_0);
		base.OnTick(eventArgs_0);
	}
}
