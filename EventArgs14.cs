using System;

internal sealed class EventArgs14 : EventArgs
{
	public Version version_0;

	public static EventArgs14 smethod_0(string string_0)
	{
		return new EventArgs14
		{
			version_0 = Version.Parse(string_0)
		};
	}
}
