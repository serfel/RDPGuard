using System.Drawing;
using System.Windows.Forms;

internal sealed class Class65 : GroupBox
{
	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		if (Class163.Class163_0.Boolean_0)
		{
			using (Pen pen = new Pen((base.Enabled ? true : false) ? Class70.color_13 : Class70.color_14))
			{
				paintEventArgs_0.Graphics.DrawRectangle(pen, 0, 7, base.Width - 1, base.Height - 9);
			}
			Size size = TextRenderer.MeasureText(Text, Font);
			using (SolidBrush brush = new SolidBrush(Class70.color_1))
			{
				paintEventArgs_0.Graphics.FillRectangle(brush, 7, 0, size.Width, size.Height);
			}
			using SolidBrush brush2 = new SolidBrush((base.Enabled ? true : false) ? Class70.color_2 : Class70.color_10);
			paintEventArgs_0.Graphics.DrawString(Text, Font, brush2, 12f, 0f);
			return;
		}
		base.OnPaint(paintEventArgs_0);
	}
}
