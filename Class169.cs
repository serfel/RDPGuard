using System;
using System.Linq;
using System.Text;
using System.Xml;

internal sealed class Class169
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<ushort, ushort> _003C_003E9__10_0;

		public static Func<ushort, ushort> _003C_003E9__10_1;

		public static Func<ushort, int> _003C_003E9__11_0;

		internal ushort method_0(ushort ushort_0)
		{
			return ushort_0;
		}

		internal ushort method_1(ushort ushort_0)
		{
			return ushort_0;
		}

		internal int method_2(ushort ushort_0)
		{
			return ushort_0.GetHashCode();
		}
	}

	public const string Name = "AdvancedBlockingSettings";

	private bool bool_0 = true;

	public ushort[] ushort_0 = new ushort[0];

	private static readonly string string_0 = "a";

	private static readonly string string_1 = "b";

	private static readonly string string_2 = "cc";

	public bool Boolean_0
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	public bool Boolean_1
	{
		get
		{
			if (!Boolean_0)
			{
				return ushort_0.Length != 0;
			}
			return false;
		}
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (this == obj)
		{
			return true;
		}
		if (obj.GetType() != GetType())
		{
			return false;
		}
		return method_1((Class169)obj);
	}

	public bool method_0(Class169 class169_0)
	{
		if ((object)class169_0 == null)
		{
			return false;
		}
		if ((object)this == class169_0)
		{
			return true;
		}
		return method_1(class169_0);
	}

	private bool method_1(Class169 class169_0)
	{
		if (Boolean_0 == class169_0.Boolean_0)
		{
			ushort[] source = ushort_0;
			Func<ushort, ushort> keySelector = _003C_003Ec._003C_003E9.method_0;
			IOrderedEnumerable<ushort> first = source.OrderBy(keySelector);
			ushort[] source2 = class169_0.ushort_0;
			Func<ushort, ushort> keySelector2 = _003C_003Ec._003C_003E9.method_1;
			return first.SequenceEqual(source2.OrderBy(keySelector2));
		}
		return false;
	}

	public override int GetHashCode()
	{
		int num = (0x50C5D1F ^ Boolean_0.GetHashCode()) * 16777619;
		int num2;
		if (ushort_0 != null)
		{
			ushort[] source = ushort_0;
			Func<ushort, int> selector = _003C_003Ec._003C_003E9.method_2;
			num2 = source.Sum(selector);
		}
		else
		{
			num2 = 0;
		}
		return num ^ num2;
	}

	public static bool operator ==(Class169 _set1, Class169 _set2)
	{
		return _set1?.method_0(_set2) ?? ((object)_set2 == null);
	}

	public static bool operator !=(Class169 _set1, Class169 _set2)
	{
		return !(_set1 == _set2);
	}

	public string method_2()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("<" + string_0 + ">");
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", string_1, Boolean_0);
		if (ushort_0.Length != 0)
		{
			stringBuilder.AppendFormat("<{0}>{1}</{0}>", string_2, Class168.smethod_0(ushort_0));
		}
		stringBuilder.Append("</" + string_0 + ">");
		return Convert.ToBase64String(new UTF8Encoding().GetBytes(stringBuilder.ToString()));
	}

	public static Class169 smethod_0(string string_3)
	{
		Class169 @class = new Class169();
		if (string.IsNullOrEmpty(string_3))
		{
			return @class;
		}
		try
		{
			XmlElement documentElement = GClass12.smethod_2(new UTF8Encoding().GetString(Convert.FromBase64String(string_3))).DocumentElement;
			@class.Boolean_0 = bool.Parse(documentElement[string_1].InnerText);
			if (documentElement[string_2] != null)
			{
				@class.ushort_0 = Class168.smethod_1(documentElement[string_2].InnerText);
			}
		}
		catch (Exception arg)
		{
			Class208.smethod_0($"AdvancedBlockingSettingsDeserialize::failed for {string_3} {arg}");
		}
		return @class;
	}
}
