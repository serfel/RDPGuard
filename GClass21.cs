using System.Collections.Generic;
using System.Linq;

public static class GClass21
{
	public static string smethod_0(long long_0)
	{
		if (long_0 <= 1)
		{
			return "";
		}
		return "s";
	}

	public static string smethod_1(int int_0)
	{
		return smethod_0(int_0);
	}

	public static string smethod_2(uint uint_0)
	{
		return smethod_0(uint_0);
	}

	public static string smethod_3(IEnumerable<object> ienumerable_0)
	{
		return smethod_1(ienumerable_0.Count());
	}

	public static string smethod_4(int int_0)
	{
		if (int_0 <= 1)
		{
			return "is";
		}
		return "are";
	}

	public static string smethod_5(uint uint_0)
	{
		return smethod_4((int)uint_0);
	}

	public static string smethod_6(IEnumerable<object> ienumerable_0)
	{
		return smethod_4(ienumerable_0.Count());
	}
}
