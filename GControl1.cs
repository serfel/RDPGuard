using System;
using System.Windows.Forms;
using System.Windows.Forms.Design;

[ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.ToolStrip | ToolStripItemDesignerAvailability.StatusStrip)]
public class GControl1 : ToolStripControlHost
{
	public EventHandler eventHandler_0;

	public bool Boolean_0
	{
		get
		{
			return ((CheckBox)base.Control).Checked;
		}
		set
		{
			((CheckBox)base.Control).Checked = value;
		}
	}

	public GControl1()
		: base(new Class61())
	{
		((CheckBox)base.Control).CheckedChanged += InitializeHandlers;
	}

	protected override void OnMouseLeave(EventArgs eventArgs_0)
	{
		base.OnMouseLeave(eventArgs_0);
		base.Parent.Focus();
	}

	private void InitializeHandlers(object sender, EventArgs e)
	{
		eventHandler_0?.Invoke(sender, e);
	}
}
