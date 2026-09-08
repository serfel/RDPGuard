using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

internal static class Class181
{
	public struct Struct1
	{
		public int int_0;

		public int int_1;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string string_0;

		public IntPtr intptr_0;

		public int int_2;

		public int int_3;

		public IntPtr intptr_1;

		public int int_4;

		public int int_5;

		public uint uint_0;

		public IntPtr intptr_2;

		public uint uint_1;
	}

	internal struct Struct2
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;
	}

	[DllImport("user32")]
	public static extern int RegisterWindowMessage(string string_0);

	[DllImport("user32")]
	public static extern bool PostMessage(IntPtr intptr_0, int int_0, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("user32.dll")]
	public static extern bool SetForegroundWindow(IntPtr intptr_0);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern int GetWindowLong(IntPtr intptr_0, int int_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr SendMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SendMessage", SetLastError = true)]
	public static extern IntPtr SendMessage_1(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, ref Struct1 struct1_0);

	[DllImport("user32.dll", SetLastError = true)]
	internal static extern bool GetWindowRect(IntPtr intptr_0, out Struct2 struct2_0);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr GetOpenClipboardWindow();

	[DllImport("user32.dll", SetLastError = true)]
	private static extern int GetWindowThreadProcessId(IntPtr intptr_0, out int int_0);

	public static Process smethod_0()
	{
		GetWindowThreadProcessId(GetOpenClipboardWindow(), out var int_);
		return Process.GetProcessById(int_);
	}

	[DllImport("uxtheme.dll", EntryPoint = "#138", SetLastError = true)]
	public static extern bool uxtheme_138();

	[DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
	public static extern int SetWindowTheme(IntPtr intptr_0, string string_0, string string_1);

	[DllImport("dwmapi")]
	public static extern int DwmSetWindowAttribute(IntPtr intptr_0, int int_0, int[] int_1, int int_2);
}
