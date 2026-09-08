using System;
using System.Text.RegularExpressions;

internal static class Class212
{
	private static readonly Regex regex_0 = new Regex("^[0-9a-fA-F]+$", RegexOptions.Compiled);

	public static string Get(byte[] byte_0)
	{
		return BitConverter.ToString(byte_0).Replace("-", string.Empty).ToLowerInvariant();
	}

	public static bool smethod_0(string string_0)
	{
		if (!string.IsNullOrEmpty(string_0))
		{
			return regex_0.IsMatch(string_0);
		}
		return false;
	}

	public static bool smethod_1(string string_0, int int_0)
	{
		if (smethod_0(string_0))
		{
			return string_0.Length == int_0;
		}
		return false;
	}
}
