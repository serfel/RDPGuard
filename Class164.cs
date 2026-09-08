using System.Linq;
using System.Reflection;

internal sealed class Class164 : Class162
{
	public delegate void Delegate3(Class132 class132_0);

	private sealed class Class170
	{
		public Class164 class164_0;

		public int int_0;

		internal object method_0(PropertyInfo propertyInfo_0)
		{
			return propertyInfo_0.GetValue(class164_0);
		}

		internal bool method_1(object object_0)
		{
			if (object_0 is Class113 @class)
			{
				return @class.Int32_0 == int_0;
			}
			return false;
		}
	}

	private sealed class Class171
	{
		public Class113 class113_0;

		internal bool method_0(Class166 class166_0)
		{
			return class166_0.Name == Class188.Class188_0[class113_0.Int32_0];
		}
	}

	public Class166 class166_0 = new Class166("Logging");

	public Class166 class166_1 = new Class166("CheckForSoftwareUpdates", bool_0: true);

	public Class166 class166_2 = new Class166("MaxAllowedLoginAttempts", 3);

	public Class166 class166_3 = new Class166("AutoUnbanPeriod", 24);

	public Class166 class166_4 = new Class166("AutoResetCountersPeriod", 24);

	public Class166 class166_5 = new Class166("AdvancedBlockingSettings");

	public Class166 class166_6 = new Class166(Class188.Class188_0[0], new Class122
	{
		bool_0 = true
	}.method_0());

	public Class166 class166_7 = new Class166(Class188.Class188_0[1]);

	public Class166 class166_8 = new Class166(Class188.Class188_0[2]);

	public Class166 class166_9 = new Class166(Class188.Class188_0[3]);

	public Class166 class166_10 = new Class166(Class188.Class188_0[4]);

	public Class166 class166_11 = new Class166(Class188.Class188_0[5]);

	public Class166 class166_12 = new Class166(Class188.Class188_0[6]);

	public Class166 class166_13 = new Class166(Class188.Class188_0[7]);

	public Class166 class166_14 = new Class166(Class188.Class188_0[8]);

	public Class166 class166_15 = new Class166(Class188.Class188_0[11]);

	public Class166 class166_16 = new Class166(Class188.Class188_0[12]);

	public Class166 class166_17 = new Class166(Class188.Class188_0[9]);

	public Class166 class166_18 = new Class166(Class188.Class188_0[10]);

	public Class166 class166_19 = new Class166("EnableIpCloud", bool_0: true);

	public Class166 class166_20 = new Class166("IpCloudDbTimestamp");

	public Class166 class166_21 = new Class166("GeoIPSettings");

	public Class166 class166_22 = new Class166("ProxySettingsV2");

	public GClass8 GClass8_0
	{
		get
		{
			return GClass8.smethod_0(class166_0.String_1);
		}
		set
		{
			class166_0.String_1 = value.method_0();
		}
	}

	public Class169 Class169_0
	{
		get
		{
			return Class169.smethod_0(class166_5.String_1);
		}
		set
		{
			class166_5.String_1 = value.method_2();
		}
	}

	public Class122 Class122_0
	{
		get
		{
			return (Class122)Class113.smethod_0(typeof(Class122), class166_6.String_1);
		}
		set
		{
			class166_6.String_1 = value.method_0();
		}
	}

	public Class123 Class123_0
	{
		get
		{
			return (Class123)Class113.smethod_0(typeof(Class123), class166_7.String_1);
		}
		set
		{
			class166_7.String_1 = value.method_0();
		}
	}

	public Class117 Class117_0
	{
		get
		{
			return (Class117)Class113.smethod_0(typeof(Class117), class166_8.String_1);
		}
		set
		{
			class166_8.String_1 = value.method_0();
		}
	}

	public Class114 Class114_0
	{
		get
		{
			return (Class114)Class113.smethod_0(typeof(Class114), class166_9.String_1);
		}
		set
		{
			class166_9.String_1 = value.method_0();
		}
	}

	public Class115 Class115_0
	{
		get
		{
			return (Class115)Class113.smethod_0(typeof(Class115), class166_10.String_1);
		}
		set
		{
			class166_10.String_1 = value.method_0();
		}
	}

	public Class125 Class125_0
	{
		get
		{
			return (Class125)Class113.smethod_0(typeof(Class125), class166_11.String_1);
		}
		set
		{
			class166_11.String_1 = value.method_0();
		}
	}

	public Class116 Class116_0
	{
		get
		{
			return (Class116)Class113.smethod_0(typeof(Class116), class166_12.String_1);
		}
		set
		{
			class166_12.String_1 = value.method_0();
		}
	}

	public Class121 Class121_0
	{
		get
		{
			return (Class121)Class113.smethod_0(typeof(Class121), class166_13.String_1);
		}
		set
		{
			class166_13.String_1 = value.method_0();
		}
	}

	public Class119 Class119_0
	{
		get
		{
			return (Class119)Class113.smethod_0(typeof(Class119), class166_14.String_1);
		}
		set
		{
			class166_14.String_1 = value.method_0();
		}
	}

	public Class120 Class120_0
	{
		get
		{
			return (Class120)Class113.smethod_0(typeof(Class120), class166_15.String_1);
		}
		set
		{
			class166_15.String_1 = value.method_0();
		}
	}

	public Class118 Class118_0
	{
		get
		{
			return (Class118)Class113.smethod_0(typeof(Class118), class166_16.String_1);
		}
		set
		{
			class166_16.String_1 = value.method_0();
		}
	}

	public Class126 Class126_0
	{
		get
		{
			return (Class126)Class113.smethod_0(typeof(Class126), class166_17.String_1);
		}
		set
		{
			class166_17.String_1 = value.method_0();
		}
	}

	public Class124 Class124_0
	{
		get
		{
			return (Class124)Class113.smethod_0(typeof(Class124), class166_18.String_1);
		}
		set
		{
			class166_18.String_1 = value.method_0();
		}
	}

	public Class132 Class132_0
	{
		get
		{
			return Class132.smethod_0(class166_21.String_1);
		}
		set
		{
			class166_21.String_1 = value.method_0();
		}
	}

	public Class159 Class159_0
	{
		get
		{
			return Class159.smethod_0(class166_22.String_1);
		}
		set
		{
			class166_22.String_1 = value.method_0();
		}
	}

	private Class164()
		: base(1, "RdpGuard".ToLowerInvariant() + "-svc")
	{
		Class90.int_0 = class166_3.Int32_0;
	}

	public static Class164 smethod_1(string string_3)
	{
		Class164 @class = new Class164();
		@class.method_1(string_3);
		Class90.int_0 = @class.class166_3.Int32_0;
		return @class;
	}

	public Class113 method_6(int int_0)
	{
		Class170 @class = new Class170();
		@class.class164_0 = this;
		@class.int_0 = int_0;
		return (Class113)GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public).Select(@class.method_0).FirstOrDefault(@class.method_1);
	}

	public void InitializeComponent(Class113 class113_0)
	{
		Class171 @class = new Class171();
		@class.class113_0 = class113_0;
		base.Class166_0.FirstOrDefault(@class.method_0).String_1 = @class.class113_0.method_0();
	}

	public void CloseDialog(Delegate3 delegate3_0)
	{
		Class132 class132_ = Class132_0;
		delegate3_0(class132_);
		Class132_0 = class132_;
		method_3();
	}
}
