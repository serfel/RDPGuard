using System.Drawing;
using System.Windows.Forms;

internal sealed class Class66 : Button
{
	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		if (Class163.Class163_0.Boolean_0 && !base.Enabled)
		{
			using (SolidBrush brush = new SolidBrush(Class70.color_1))
			{
				paintEventArgs_0.Graphics.FillRectangle(brush, paintEventArgs_0.ClipRectangle);
			}
			using (Pen pen = new Pen(Class70.color_14))
			{
				paintEventArgs_0.Graphics.DrawRectangle(pen, 0, 0, base.Width - 1, base.Height - 1);
			}
			int num = 0;
			if (base.Image != null)
			{
				Size size = TextRenderer.MeasureText(Text, Font);
				int num2 = (base.Width - base.Image.Width - size.Width) / 2 + 1;
				int num3 = (base.Height - base.Image.Height) / 2 + 1;
				num = num2 + base.Image.Width;
				ControlPaint.DrawImageDisabled(paintEventArgs_0.Graphics, base.Image, num2, num3, Class70.color_1);
			}
			num = ((base.Image == null) ? ((base.Width - TextRenderer.MeasureText(Text, Font).Width) / 2) : num);
			int num4 = (base.Height - Font.Height) / 2;
			using SolidBrush brush2 = new SolidBrush(Class70.color_2);
			paintEventArgs_0.Graphics.DrawString(Text, Font, brush2, num, num4);
			return;
		}
		base.OnPaint(paintEventArgs_0);
	}
}
