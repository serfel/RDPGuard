using System;
using System.Drawing;
using System.Windows.Forms;

public class GClass3 : LinkLabel
{
	private readonly Color color_0 = Color.FromArgb(38, 135, 200);

	private readonly Color color_1 = Color.FromArgb(240, 144, 0);

	public EventHandler eventHandler_0;

	public GClass3()
	{
		base.LinkBehavior = LinkBehavior.NeverUnderline;
		base.LinkColor = color_0;
		base.VisitedLinkColor = color_0;
	}

	protected override void OnMouseEnter(EventArgs eventArgs_0)
	{
		base.OnMouseEnter(eventArgs_0);
		base.LinkColor = color_1;
	}

	protected override void OnMouseLeave(EventArgs eventArgs_0)
	{
		base.OnMouseLeave(eventArgs_0);
		base.LinkColor = color_0;
	}

	public void method_0()
	{
		base.OnClick(new EventArgs());
	}

	protected override void OnClick(EventArgs eventArgs_0)
	{
		eventHandler_0?.Invoke(this, eventArgs_0);
		base.OnClick(eventArgs_0);
	}
}
