using System;
using System.Runtime.InteropServices;

internal sealed class Class140
{
	[DllImport("kernel32.dll")]
	public static extern IntPtr GetCurrentProcess();

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr GetModuleHandle(string string_0);

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPStr)] string string_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool IsWow64Process(IntPtr intptr_0, out bool bool_0);

	private static bool smethod_0(string string_0, string string_1)
	{
		IntPtr moduleHandle = GetModuleHandle(string_0);
		if (moduleHandle == IntPtr.Zero)
		{
			return false;
		}
		return GetProcAddress(moduleHandle, string_1) != IntPtr.Zero;
	}

	public static bool smethod_1()
	{
		if (IntPtr.Size == 8)
		{
			return true;
		}
		bool bool_ = false;
		return smethod_0("kernel32.dll", "IsWow64Process") && IsWow64Process(GetCurrentProcess(), out bool_) && bool_;
	}
}
