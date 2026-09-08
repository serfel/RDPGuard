using System;
using System.Security.Cryptography;

public static class GClass33
{
	public static string smethod_0(string string_0, string string_1, int int_0)
	{
		if (1 == int_0)
		{
			return Class218.smethod_0(string_0, string_1);
		}
		if (2 == int_0)
		{
			return Class217.smethod_0(string_0, string_1);
		}
		if (3 == int_0)
		{
			return Class216.smethod_0(string_0, string_1);
		}
		return Class215.smethod_0(string_0, string_1);
	}

	public static string smethod_1(string string_0, string string_1, int int_0)
	{
		try
		{
			if (1 == int_0)
			{
				return Class218.smethod_1(string_0, string_1);
			}
			if (2 == int_0)
			{
				return Class217.smethod_1(string_0, string_1);
			}
			if (3 == int_0)
			{
				return Class216.smethod_1(string_0, string_1);
			}
			return Class215.smethod_1(string_0, string_1);
		}
		catch (CryptographicException)
		{
			return null;
		}
		catch (Exception)
		{
			throw;
		}
	}
}
