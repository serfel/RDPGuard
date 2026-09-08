using System;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class Class0 : ComboBox
{
	private bool bool_0;

	public Class0()
	{
		if (Class163.Class163_0.Boolean_0)
		{
			SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, value: true);
		}
	}

	private Color method_0(bool bool_1)
	{
		if (!base.Enabled)
		{
			return Class70.color_14;
		}
		if (!bool_1)
		{
			return Class70.color_13;
		}
		return Class70.color_12;
	}

	private Image method_1(bool bool_1)
	{
		if (!base.Enabled)
		{
			return Resources.cb_arrow_disabled;
		}
		if (!bool_1)
		{
			return Resources.cb_arrow_enabled;
		}
		return Resources.cb_arrow_hot;
	}

	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		using (SolidBrush brush = new SolidBrush(Class70.color_8))
		{
			paintEventArgs_0.Graphics.FillRectangle(brush, paintEventArgs_0.ClipRectangle);
		}
		using (SolidBrush brush2 = new SolidBrush((base.Enabled ? true : false) ? Class70.color_2 : Class70.color_10))
		{
			paintEventArgs_0.Graphics.DrawString(Text, Font, brush2, 3f, 3f);
		}
		using (Pen pen = new Pen(method_0((bool_0 ? true : false) || Focused)))
		{
			paintEventArgs_0.Graphics.DrawRectangle(pen, 0, 0, base.Width - 1, base.Height - 1);
		}
		Rectangle rect = new Rectangle(base.Width - 12, 0, 7, 22);
		paintEventArgs_0.Graphics.DrawImage(method_1(bool_0), rect);
	}

	protected override void OnDrawItem(DrawItemEventArgs drawItemEventArgs_0)
	{
		if (drawItemEventArgs_0.Index < 0)
		{
			return;
		}
		using (SolidBrush brush = new SolidBrush((drawItemEventArgs_0.State.HasFlag(DrawItemState.Selected) ? true : false) ? Class70.color_5 : Class70.color_1))
		{
			drawItemEventArgs_0.Graphics.FillRectangle(brush, drawItemEventArgs_0.Bounds);
		}
		using SolidBrush brush2 = new SolidBrush((base.Enabled ? true : false) ? Class70.color_2 : Class70.color_10);
		drawItemEventArgs_0.Graphics.DrawString(base.Items[drawItemEventArgs_0.Index].ToString(), drawItemEventArgs_0.Font, brush2, drawItemEventArgs_0.Bounds);
	}

	protected override void OnMouseEnter(EventArgs eventArgs_0)
	{
		base.OnMouseEnter(eventArgs_0);
		bool_0 = true;
		Invalidate();
	}

	protected override void OnMouseLeave(EventArgs eventArgs_0)
	{
		base.OnMouseLeave(eventArgs_0);
		bool_0 = false;
		Invalidate();
	}

	protected override void OnMouseMove(MouseEventArgs mevent)
	{
		base.OnMouseMove(mevent);
		Point pt = PointToClient(Control.MousePosition);
		if (base.ClientRectangle.Contains(pt) && !bool_0)
		{
			bool_0 = true;
			Invalidate();
		}
	}

	protected override void OnDropDownClosed(EventArgs eventArgs_0)
	{
		base.OnDropDownClosed(eventArgs_0);
		Point pt = PointToClient(Control.MousePosition);
		if (!base.ClientRectangle.Contains(pt))
		{
			bool_0 = false;
			Invalidate();
		}
	}

	protected override void OnGotFocus(EventArgs eventArgs_0)
	{
		base.OnGotFocus(eventArgs_0);
		Invalidate();
	}

	protected override void OnLostFocus(EventArgs eventArgs_0)
	{
		base.OnLostFocus(eventArgs_0);
		Invalidate();
	}
}
