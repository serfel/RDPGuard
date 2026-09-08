using System;
using System.Threading;
using System.Windows.Forms;

internal sealed class Class144 : Class143
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		internal Class144 method_0()
		{
			return new Class144();
		}
	}

	private static readonly Lazy<Class144> lazy_0 = new Lazy<Class144>(_003C_003Ec._003C_003E9.method_0);

	public static Class144 Class144_0 => lazy_0.Value;

	public override void vmethod_0()
	{
		base.vmethod_0();
		Application.ThreadException += method_2;
	}

	protected override void vmethod_1(string string_0)
	{
		try
		{
			Class89.smethod_20(string_0);
		}
		catch
		{
		}
		DialogResult dialogResult = DialogResult.Cancel;
		try
		{
			Form33 form = new Form33(string_0);
			using (form)
			{
				dialogResult = form.ShowDialog();
			}
		}
		catch
		{
			Class77.smethod_0(string_0);
			dialogResult = MessageBox.Show(string.Concat("Sorry, something went wrong.A detailed error report has been created and pasted into the clipboard" + "\r\n", "You can send it to help us improve RdpGuard. We will treat this report as confidential and anonymous."), "Program Crashed", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
		}
		if (DialogResult.OK == dialogResult)
		{
			Class142.smethod_0(string_0);
		}
	}

	private void method_2(object sender, ThreadExceptionEventArgs e)
	{
		method_0(e.Exception);
	}
}
