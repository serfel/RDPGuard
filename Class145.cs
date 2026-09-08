using System;
using System.Diagnostics;

internal static class Class145
{
	public static readonly string string_0 = "RdpGuardLog";

	public static void smethod_0(Exception exception_0)
	{
		smethod_1(exception_0.ToString());
	}

	public static void smethod_1(string string_1)
	{
		try
		{
			if (!EventLog.SourceExists(string_0))
			{
				EventLog.CreateEventSource(string_0, string_0);
			}
			if (EventLog.SourceExists(string_0))
			{
				EventLog.WriteEntry(string_0, string_1, EventLogEntryType.Error, 0, 0);
			}
		}
		catch
		{
		}
	}
}
