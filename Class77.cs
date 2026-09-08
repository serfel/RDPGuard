using System.Diagnostics;
using System.Windows.Forms;

internal static class Class77
{
	public static void smethod_0(string string_0)
	{
		try
		{
			Clipboard.SetText(string_0);
		}
		catch
		{
			Process process = Class181.smethod_0();
			string text = ((process == null) ? "unknown process" : process.ProcessName);
			MessageBox.Show("Unable to set clipboard text. The clipboard is blocked by the following process:\r\n" + text);
		}
	}

	public static string smethod_1()
	{
		try
		{
			return Clipboard.GetText();
		}
		catch
		{
			Process process = Class181.smethod_0();
			string text = ((process == null) ? "unknown process" : process.ProcessName);
			MessageBox.Show("Unable to get clipboard text. The clipboard is blocked by the following process:\r\n" + text);
			return string.Empty;
		}
	}
}
