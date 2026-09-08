using System;

internal static class Class178
{
	public static bool Boolean_0
	{
		get
		{
			if (Int32_0 == 6)
			{
				return Int32_1 <= 1;
			}
			return false;
		}
	}

	public static bool Boolean_1 => Int32_0 >= 6;

	public static bool Boolean_2
	{
		get
		{
			if (Int32_0 >= 6)
			{
				return Int32_1 >= 2;
			}
			return false;
		}
	}

	private static int Int32_0 => Environment.OSVersion.Version.Major;

	private static int Int32_1 => Environment.OSVersion.Version.Minor;
}
