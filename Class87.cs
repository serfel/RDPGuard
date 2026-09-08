using System.Diagnostics;
using System.IO;
using System.Reflection;

internal static class Class87
{
	public static void smethod_0()
	{
		smethod_4("/install-service");
	}

	public static void smethod_1(string string_0)
	{
		smethod_4("/start " + string_0);
	}

	public static void smethod_2(string string_0)
	{
		smethod_4("/stop " + string_0);
	}

	public static void smethod_3(string string_0)
	{
		smethod_4("/restart " + string_0);
	}

	private static void smethod_4(string string_0)
	{
		if (!smethod_5())
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = Assembly.GetExecutingAssembly().Location,
				Arguments = string_0,
				WindowStyle = ProcessWindowStyle.Hidden
			});
		}
	}

	private static bool smethod_5()
	{
		return Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().Location)).Length >= 2;
	}
}
