using System;

internal static class Class138
{
	public static Version version_0 = Version.Parse("10.2.1");

	public const string Name = "RdpGuard";

	public static string String_0
	{
		get
		{
			if (!Class140.smethod_1())
			{
				return "x86";
			}
			return "x64";
		}
	}

	public static string String_1 => string.Format("{0} {1}", "RdpGuard", version_0);
}
