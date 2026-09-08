using System.Windows.Forms;

internal sealed class Class67 : ToolStrip
{
	public GEnum0 gEnum;

	public Class67()
	{
		if (Class163.Class163_0.Boolean_0)
		{
			base.RenderMode = ToolStripRenderMode.Professional;
			base.Renderer = new Class59();
		}
	}
}
