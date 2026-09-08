using System;
using System.Drawing;
using System.Security.Permissions;
using System.Windows.Forms;

public class GControl0 : UserControl
{
	public GControl0()
	{
		base.ResizeRedraw = true;
		base.Height = 2;
		SetStyle(ControlStyles.Selectable, value: false);
		base.TabStop = false;
	}

	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	protected override void WndProc(ref Message message_0)
	{
		if (message_0.Msg == 33 && !base.DesignMode)
		{
			message_0.Result = (IntPtr)4;
		}
		else
		{
			base.WndProc(ref message_0);
		}
	}

	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		base.OnPaint(paintEventArgs_0);
		Color color = ((Class163.Class163_0.Boolean_0 ? true : false) ? Class70.color_14 : SystemColors.ControlLightLight);
		Color color2 = ((Class163.Class163_0.Boolean_0 ? true : false) ? Class70.color_13 : SystemColors.ControlDark);
		using Pen pen = new Pen(color);
		using Pen pen2 = new Pen(color2);
		paintEventArgs_0.Graphics.DrawLine(pen2, 0, 0, base.Width, 0);
		paintEventArgs_0.Graphics.DrawLine(pen, 0, base.Height - 1, base.Width, base.Height - 1);
	}
}
