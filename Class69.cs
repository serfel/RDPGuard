using System;

internal static class Class69
{
	public static bool Boolean_0
	{
		get
		{
			if (Environment.OSVersion.Version.Major < 6)
			{
				return false;
			}
			if (Environment.OSVersion.Version.Major == 6 && Environment.OSVersion.Version.Minor < 2)
			{
				return false;
			}
			return Class181.uxtheme_138();
		}
	}
}
