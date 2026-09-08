using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Properties;

internal sealed class Class61 : CheckBox
{
	public bool bool_0 = true;

	public Class61()
	{
		if (Class163.Class163_0.Boolean_0)
		{
			base.ImageList = new ImageList
			{
				Images = 
				{
					(Image)Resources.checkbox_dark_enabled_checked,
					(Image)Resources.checkbox_dark_enabled_unchecked,
					(Image)Resources.checkbox_dark_disabled_checked,
					(Image)Resources.checkbox_dark_disabled_unchecked
				}
			};
		}
	}

	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		if (Class163.Class163_0.Boolean_0)
		{
			using (SolidBrush brush = new SolidBrush(Class70.color_1))
			{
				paintEventArgs_0.Graphics.FillRectangle(brush, paintEventArgs_0.ClipRectangle);
			}
			int index = ((!base.Enabled && 0 == 0) ? ((base.Checked ? true : false) ? 2 : 3) : ((!base.Checked) ? 1 : 0));
			paintEventArgs_0.Graphics.InterpolationMode = InterpolationMode.Bicubic;
			paintEventArgs_0.Graphics.DrawImage(base.ImageList.Images[index], 2, 2, 13, 13);
			using (SolidBrush brush2 = new SolidBrush((base.Enabled ? true : false) ? Class70.color_2 : Class70.color_10))
			{
				paintEventArgs_0.Graphics.DrawString(Text, Font, brush2, 20f, 0f);
			}
			if (Focused && base.Enabled && bool_0)
			{
				ControlPaint.DrawFocusRectangle(paintEventArgs_0.Graphics, new Rectangle(19, 0, base.Width - 25, base.Height - 2), Color.Empty, Class70.color_6);
			}
		}
		else
		{
			base.OnPaint(paintEventArgs_0);
		}
	}
}
