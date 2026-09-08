using System;
using System.Windows.Forms;

internal sealed class Class56 : ToolStripMenuItem
{
	public EventHandler eventHandler_0;

	public EventHandler eventHandler_1;

	public ToolStripItem[] ToolStripItem_0
	{
		set
		{
			base.DropDownItems.Clear();
			base.DropDownItems.AddRange(value);
		}
	}

	protected override void OnClick(EventArgs eventArgs_0)
	{
		eventHandler_0?.Invoke(this, eventArgs_0);
		base.OnClick(eventArgs_0);
	}

	protected override void OnDropDownOpened(EventArgs eventArgs_0)
	{
		eventHandler_1?.Invoke(this, eventArgs_0);
		base.OnDropDownOpened(eventArgs_0);
	}
}
