using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class GClass2 : TextBox
{
	private bool bool_0;

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

	public GClass2()
	{
		base.BorderStyle = BorderStyle.None;
		ForeColor = SystemColors.ControlDarkDark;
		Multiline = true;
		base.ReadOnly = true;
		SetStyle(ControlStyles.SupportsTransparentBackColor, value: true);
		BackColor = Color.Transparent;
		base.GotFocus += GClass2_GotFocus;
		base.LostFocus += GClass2_LostFocus;
	}

	protected override void WndProc(ref Message message_0)
	{
		if (message_0.Msg == 7)
		{
			BeginInvoke(new Action(method_0));
		}
		if (message_0.Msg == 8)
		{
			HideCaret(base.Handle);
		}
		base.WndProc(ref message_0);
	}

	[DllImport("user32.dll")]
	private static extern bool HideCaret(IntPtr intptr_0);

	private void GClass2_GotFocus(object sender, EventArgs e)
	{
		Cursor = Cursors.Default;
	}

	private void GClass2_LostFocus(object sender, EventArgs e)
	{
		Cursor = Cursors.Default;
	}

	private void method_0()
	{
		HideCaret(base.Handle);
	}
}
