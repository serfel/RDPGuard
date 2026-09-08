using System;
using System.Runtime.InteropServices;

internal static class Class11
{
	private struct Struct0(int int_2, int int_3)
	{
		public int int_0 = int_2;

		public int int_1 = int_3;
	}

	public static int smethod_0(int int_0, int int_1)
	{
		if (!smethod_1())
		{
			return -1;
		}
		IntPtr intPtr = MonitorFromPoint(new Struct0(int_0, int_1), 1u);
		if (IntPtr.Zero == intPtr)
		{
			return -1;
		}
		if (GetDpiForMonitor(intPtr, 0, out var uint_, out var _) == 0)
		{
			return (int)Math.Round((float)uint_ / 96f * 100f);
		}
		return -1;
	}

	private static bool smethod_1()
	{
		IntPtr intPtr = LoadLibrary("Shcore.dll");
		if (IntPtr.Zero == intPtr)
		{
			return false;
		}
		return IntPtr.Zero != GetProcAddress(intPtr, "GetDpiForMonitor");
	}

	[DllImport("Shcore.dll")]
	private static extern int GetDpiForMonitor(IntPtr intptr_0, int int_0, out uint uint_0, out uint uint_1);

	[DllImport("user32.dll")]
	private static extern IntPtr MonitorFromPoint(Struct0 struct0_0, uint uint_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern IntPtr LoadLibrary(string string_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);
}
