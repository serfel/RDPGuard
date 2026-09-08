using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class Class64 : RadioButton
{
	public Class64()
	{
		if (Class163.Class163_0.Boolean_0)
		{
			base.ImageList = new ImageList
			{
				Images = 
				{
					(Image)Resources.radio_dark_enabled_checked,
					(Image)Resources.radio_dark_enabled_unchecked,
					(Image)Resources.radio_dark_disabled_checked,
					(Image)Resources.radio_dark_disabled_unchecked
				}
			};
		}
	}

	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		if (Class163.Class163_0.Boolean_0)
		{
			AutoSize = false;
			base.Width = TextRenderer.MeasureText(Text, Font).Width + 20;
			using (SolidBrush brush = new SolidBrush(Class70.color_1))
			{
				paintEventArgs_0.Graphics.FillRectangle(brush, 0, 0, base.Width, base.Height);
			}
			int index = ((!base.Enabled && 0 == 0) ? ((base.Checked ? true : false) ? 2 : 3) : ((!base.Checked) ? 1 : 0));
			base.ImageList.Draw(paintEventArgs_0.Graphics, 0, 0, index);
			using (SolidBrush brush2 = new SolidBrush((base.Enabled ? true : false) ? Class70.color_2 : Class70.color_10))
			{
				paintEventArgs_0.Graphics.DrawString(Text, Font, brush2, 20f, 0f);
			}
			if (Focused && base.Enabled)
			{
				ControlPaint.DrawFocusRectangle(paintEventArgs_0.Graphics, new Rectangle(19, 0, base.Width - 20, base.Height - 2), Color.Empty, Class70.color_6);
			}
		}
		else
		{
			base.OnPaint(paintEventArgs_0);
		}
	}
}
