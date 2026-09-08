using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

internal static class Program
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static EventHandler _003C_003E9__0_0;

		internal void method_0(object sender, EventArgs e)
		{
			Class76.smethod_2();
		}
	}

	[STAThread]
	private static void Main(string[] args)
	{
		try
		{
			Class144.Class144_0.vmethod_0();
			if (smethod_0(args))
			{
				return;
			}
			if (!Class76.smethod_0())
			{
				Class76.smethod_1();
				return;
			}
			EventHandler _003C_003E9__0_ = _003C_003Ec._003C_003E9__0_0;
			if (_003C_003E9__0_ == null)
			{
				_003C_003E9__0_ = (_003C_003Ec._003C_003E9__0_0 = _003C_003Ec._003C_003E9.method_0);
			}
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(defaultValue: false);
			Application.Run(new DashboardDialog());
		}
		catch (Exception exception_)
		{
			Class144.Class144_0.method_0(exception_);
		}
	}

	private static bool smethod_0(string[] string_0)
	{
		if (string_0.Length < 1)
		{
			return false;
		}
		bool createdNew;
		using (Mutex mutex = new Mutex(initiallyOwned: true, "f45ffea6-a40b-4a3e-b197-767d45dc5a1a", out createdNew))
		{
			if (!createdNew)
			{
				return true;
			}
			if (!Class161.Boolean_0)
			{
				Class161.smethod_0(string_0);
				return true;
			}
			if ("/start" == string_0[0])
			{
				new Class84(string_0[1]).method_1();
			}
			if ("/stop" == string_0[0])
			{
				new Class84(string_0[1]).method_2();
			}
			if ("/restart" == string_0[0])
			{
				new Class84(string_0[1]).method_3();
			}
			if ("/install-service" == string_0[0])
			{
				Process.Start("rdpguard-svc.exe", "/install").WaitForExit();
			}
			mutex.ReleaseMutex();
		}
		return true;
	}
}
