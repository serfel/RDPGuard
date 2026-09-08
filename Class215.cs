using System;
using System.Text;

internal static class Class215
{
	public static string smethod_0(string string_0, string string_1)
	{
		if (!string.IsNullOrEmpty(string_0) && !string.IsNullOrEmpty(string_1))
		{
			return Convert.ToBase64String(Class211.smethod_2(Encoding.UTF8.GetBytes(string_0), string_1));
		}
		return string.Empty;
	}

	public static string smethod_1(string string_0, string string_1)
	{
		if (!string.IsNullOrEmpty(string_0) && !string.IsNullOrEmpty(string_1))
		{
			byte[] array = Class211.smethod_3(Convert.FromBase64String(string_0), string_1);
			if (array != null)
			{
				return Encoding.UTF8.GetString(array);
			}
			return null;
		}
		return string.Empty;
	}
}
