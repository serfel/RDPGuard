using System.ComponentModel;
using System.Windows.Forms;

internal sealed class Class57 : ContextMenuStrip
{
	public CancelEventHandler cancelEventHandler_0;

	public ToolStripItem[] ToolStripItem_0
	{
		set
		{
			Items.Clear();
			Items.AddRange(value);
		}
	}

	protected override void OnOpening(CancelEventArgs cancelEventArgs_0)
	{
		if (Class163.Class163_0.Boolean_0)
		{
			base.BackColor = Class70.color_1;
			base.ForeColor = Class70.color_2;
		}
		cancelEventHandler_0?.Invoke(this, cancelEventArgs_0);
		base.OnOpening(cancelEventArgs_0);
	}

	public Class57()
	{
		if (Class163.Class163_0.Boolean_0)
		{
			base.RenderMode = ToolStripRenderMode.Professional;
			base.Renderer = new Class59();
		}
	}
}
