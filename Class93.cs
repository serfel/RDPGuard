using System.Collections.Generic;

internal sealed class Class93 : IComparer<Class90>
{
	private readonly GEnum14 genum14_0 = GEnum14.const_2;

	public Class93(GEnum14 genum14_1)
	{
		genum14_0 = genum14_1;
	}

	public int Compare(Class90 class90_0, Class90 class90_1)
	{
		if (null == class90_0 && null == class90_1)
		{
			return 0;
		}
		if (null == class90_0 && null != class90_1)
		{
			return -1;
		}
		if (null != class90_0 && null == class90_1)
		{
			return 1;
		}
		if (class90_0.GetHashCode() == class90_1.GetHashCode())
		{
			return 0;
		}
		return smethod_0(class90_0, class90_1, genum14_0);
	}

	private static int smethod_0(Class90 class90_0, Class90 class90_1, GEnum14 genum14_1)
	{
		if (1 == 0)
		{
		}
		int result = genum14_1 switch
		{
			GEnum14.const_0 => smethod_1(class90_0, class90_1), 
			GEnum14.const_1 => -1 * smethod_1(class90_0, class90_1), 
			GEnum14.const_2 => smethod_2(class90_0, class90_1), 
			GEnum14.const_3 => -1 * smethod_2(class90_0, class90_1), 
			GEnum14.const_4 => smethod_3(class90_0, class90_1), 
			GEnum14.const_5 => -1 * smethod_3(class90_0, class90_1), 
			GEnum14.const_6 => smethod_4(class90_0, class90_1), 
			GEnum14.const_7 => -1 * smethod_4(class90_0, class90_1), 
			_ => 0, 
		};
		if (1 == 0)
		{
		}
		return result;
	}

	private static int smethod_1(Class90 class90_0, Class90 class90_1)
	{
		if (!(class90_0.gclass11_0.gclass24_0.GStruct1_0 > class90_1.gclass11_0.gclass24_0.GStruct1_0))
		{
			return -1;
		}
		return 1;
	}

	private static int smethod_2(Class90 class90_0, Class90 class90_1)
	{
		return class90_0.dateTime_0.CompareTo(class90_1.dateTime_0);
	}

	private static int smethod_3(Class90 class90_0, Class90 class90_1)
	{
		return class90_0.DateTime_0.CompareTo(class90_1.DateTime_0);
	}

	private static int smethod_4(Class90 class90_0, Class90 class90_1)
	{
		return string.Compare(class90_0.gclass11_0.String_0, class90_1.gclass11_0.String_0);
	}
}
