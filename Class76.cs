using System;
using System.Threading;

internal static class Class76
{
	private static readonly string string_0 = "RdpGuardMutex";

	public static readonly int int_0 = Class181.RegisterWindowMessage("WM_SHOWFIRSTINSTANCE|RdpGuard");

	private static Mutex mutex_0 = null;

	public static bool smethod_0()
	{
		mutex_0 = new Mutex(initiallyOwned: true, string_0, out var createdNew);
		return createdNew;
	}

	public static void smethod_1()
	{
		Class181.PostMessage((IntPtr)65535, int_0, IntPtr.Zero, IntPtr.Zero);
	}

	public static void smethod_2()
	{
		mutex_0.ReleaseMutex();
	}
}
