using System.Drawing;
using System.Linq;
using System.Windows.Forms;

internal sealed class Control14 : TabControl
{
	public Control14()
	{
		if (Class163.Class163_0.Boolean_0 && !base.DesignMode)
		{
			SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
			UpdateStyles();
		}
	}

	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		if (Class163.Class163_0.Boolean_0 && !base.DesignMode)
		{
			using (SolidBrush brush = new SolidBrush(Class70.color_1))
			{
				paintEventArgs_0.Graphics.FillRectangle(brush, paintEventArgs_0.ClipRectangle);
			}
			TabPage page = base.TabPages.Cast<TabPage>().OrderByDescending(InitializeHandlers).First();
			Rectangle tabRect = GetTabRect(base.TabPages.IndexOf(page));
			using (Pen pen = new Pen(Class70.color_13))
			{
				paintEventArgs_0.Graphics.DrawRectangle(pen, tabRect.X, tabRect.Y + tabRect.Height, base.Width - tabRect.X - 2, base.Height - tabRect.Height - tabRect.Y - 2);
			}
			for (int i = 0; i < base.TabCount; i++)
			{
				Rectangle tabRect2 = GetTabRect(i);
				using (SolidBrush brush2 = new SolidBrush((base.SelectedIndex == i) ? Class70.color_1 : Class70.color_19))
				{
					paintEventArgs_0.Graphics.FillRectangle(brush2, tabRect2);
				}
				using (Pen pen2 = new Pen(Class70.color_13))
				{
					paintEventArgs_0.Graphics.DrawRectangle(pen2, tabRect2.X, (i == base.SelectedIndex) ? (tabRect2.Y - 1) : tabRect2.Y, tabRect2.Width, (i == base.SelectedIndex) ? (tabRect2.Height + 1) : tabRect2.Height);
				}
				if (base.SelectedIndex < i && i - base.SelectedIndex == 1)
				{
					using Pen pen3 = new Pen(Class70.color_13);
					paintEventArgs_0.Graphics.DrawLine(pen3, tabRect2.X, tabRect2.Y, tabRect2.X, tabRect2.Y);
				}
				if (base.SelectedIndex == i)
				{
					using Pen pen4 = new Pen(Class70.color_1);
					paintEventArgs_0.Graphics.DrawLine(pen4, tabRect2.X + 1, tabRect2.Y + tabRect2.Height, tabRect2.X + tabRect2.Width, tabRect2.Y + tabRect2.Height);
				}
				Image image = ((base.ImageList == null || base.ImageList.Images.Count <= 0 || base.TabPages[i].ImageIndex < 0 || base.TabPages[i].ImageIndex >= base.ImageList.Images.Count) ? null : base.ImageList.Images[base.TabPages[i].ImageIndex]);
				Size size = TextRenderer.MeasureText(base.TabPages[i].Text, Font);
				int num = ((image != null) ? (tabRect2.X + (tabRect2.Width - image.Width - size.Width) / 2) : 0);
				int num2 = ((image != null) ? (tabRect2.Y + (tabRect2.Height - image.Height) / 2) : 0);
				if (image != null)
				{
					paintEventArgs_0.Graphics.DrawImage(image, num, num2);
				}
				Color color = ((base.SelectedIndex == i) ? Class70.color_2 : Class70.color_7);
				int num3 = ((image == null) ? (tabRect2.X + (tabRect2.Width - size.Width) / 2) : (num + 4 + image.Width));
				int num4 = tabRect2.Y + (tabRect2.Height - size.Height) / 2;
				using SolidBrush brush3 = new SolidBrush(color);
				paintEventArgs_0.Graphics.DrawString(base.TabPages[i].Text, Font, brush3, num3, num4);
			}
		}
		else
		{
			base.OnPaint(paintEventArgs_0);
		}
	}

	private int InitializeHandlers(TabPage tabPage_0)
	{
		return GetTabRect(base.TabPages.IndexOf(tabPage_0)).Y;
	}
}
