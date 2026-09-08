using System.Drawing;
using System.Windows.Forms;

internal class Class62 : Label
{
	private bool bool_0;

	public Color color_0 = Class70.color_2;

	public Color color_1 = Class70.color_10;

	public bool Boolean_0
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		if (Class163.Class163_0.Boolean_0)
		{
			if (base.Enabled && Boolean_0)
			{
				color_0 = ForeColor;
			}
			using (SolidBrush brush = new SolidBrush(Class70.color_1))
			{
				paintEventArgs_0.Graphics.FillRectangle(brush, paintEventArgs_0.ClipRectangle);
			}
			using SolidBrush brush2 = new SolidBrush((base.Enabled ? true : false) ? color_0 : color_1);
			paintEventArgs_0.Graphics.DrawString(Text, Font, brush2, 0f, 0f);
			return;
		}
		base.OnPaint(paintEventArgs_0);
	}
}
