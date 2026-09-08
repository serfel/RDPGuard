using System;

internal sealed class Class163 : Class162
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		internal Class163 method_0()
		{
			return new Class163();
		}
	}

	private static readonly Lazy<Class163> lazy_0 = new Lazy<Class163>(_003C_003Ec._003C_003E9.method_0);

	private static readonly string string_3 = "RdpGuard".ToLowerInvariant() + "-ui";

	public Class166 class166_0 = new Class166("ShowEventLog", bool_0: false);

	public Class166 class166_1 = new Class166("ShowStatusbar", bool_0: true);

	public Class166 class166_2 = new Class166("AllwaysShowSystemTrayIcon", bool_0: true);

	public Class166 class166_3 = new Class166("HideWhenMimimized", bool_0: false);

	public Class166 class166_4 = new Class166("CloseToSystemTray", bool_0: false);

	public Class166 class166_5 = new Class166("Forms");

	public Class166 class166_6 = new Class166("IPSortingType", 2);

	public Class166 class166_7 = new Class166("IPPageSize", 100);

	public Class166 class166_8 = new Class166("Theme", 0);

	public Class166 class166_9 = new Class166("TestNode", 666);

	public Class166 class166_10 = new Class166("TestNode2", bool_0: true);

	public static Class163 Class163_0 => lazy_0.Value;

	public GEnum14 GEnum14_0
	{
		get
		{
			return (GEnum14)class166_6.Int32_0;
		}
		set
		{
			class166_6.Int32_0 = (int)value;
		}
	}

	public int Int32_0
	{
		get
		{
			return class166_8.Int32_0;
		}
		set
		{
			class166_8.Int32_0 = value;
		}
	}

	public bool Boolean_0
	{
		get
		{
			if (1 != Int32_0)
			{
				if (2 == Int32_0)
				{
					return Class69.Boolean_0;
				}
				return false;
			}
			return true;
		}
	}

	private Class163()
		: base(0, string_3)
	{
	}

	public void method_6()
	{
		method_0(0, string_3);
	}
}
