using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Security.Principal;

internal static class Class161
{
	public static bool Boolean_0
	{
		get
		{
			using WindowsIdentity ntIdentity = WindowsIdentity.GetCurrent();
			return new WindowsPrincipal(ntIdentity).IsInRole(WindowsBuiltInRole.Administrator);
		}
	}

	public static bool smethod_0(string[] string_0)
	{
		if (!Boolean_0)
		{
			try
			{
				Process.Start(new ProcessStartInfo
				{
					FileName = Assembly.GetExecutingAssembly().Location,
					Verb = "runas",
					Arguments = string.Join(" ", string_0)
				});
			}
			catch (Win32Exception)
			{
				return false;
			}
		}
		return true;
	}
}
