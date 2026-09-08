using Microsoft.Win32;

internal static class Class130
{
	private static readonly string string_0 = "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Terminal Server\\WinStations\\RDP-Tcp";

	private static readonly string string_1 = "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Terminal Server\\WinStations\\Session";

	private static ushort ushort_0 = 0;

	public static ushort UInt16_0
	{
		get
		{
			try
			{
				if (ushort_0 == 0)
				{
					object value = Registry.GetValue(string_0, "PortNumber", (ushort)3389);
					if (value == null)
					{
						value = Registry.GetValue(string_1, "PortNumber", (ushort)3389);
					}
					ushort_0 = ushort.Parse(value.ToString());
				}
				return ushort_0;
			}
			catch
			{
			}
			return 3389;
		}
	}
}
