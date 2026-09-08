using System;
using System.Collections.Generic;
using System.Linq;
using rdpguard.lib;

public struct GStruct0 : IEquatable<GStruct0>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<ushort, bool> _003C_003E9__6_0;

		public static Func<ushort, ushort> _003C_003E9__6_1;

		public static Func<ushort, GStruct0> _003C_003E9__6_2;

		public static Func<ushort, bool> _003C_003E9__8_0;

		public static Func<ushort, ushort> _003C_003E9__8_1;

		internal bool method_0(ushort ushort_0)
		{
			return ushort_0 != 0;
		}

		internal ushort method_1(ushort ushort_0)
		{
			return ushort_0;
		}

		internal GStruct0 method_2(ushort ushort_0)
		{
			return new GStruct0(ushort_0);
		}

		internal bool method_3(ushort ushort_0)
		{
			return ushort_0 != 0;
		}

		internal ushort method_4(ushort ushort_0)
		{
			return ushort_0;
		}
	}

	public ushort ushort_0;

	public ushort ushort_1;

	public bool Boolean_0 => ushort_0 == ushort_1;

	public GStruct0(ushort ushort_2)
	{
		ushort_0 = ushort_2;
		ushort_1 = ushort_2;
	}

	public GStruct0(ushort ushort_2, ushort ushort_3)
	{
		if (ushort_2 == 0 || ushort_3 == 0 || ushort_2 > ushort_3)
		{
			throw new ArgumentOutOfRangeException();
		}
		ushort_0 = ushort_2;
		ushort_1 = ushort_3;
	}

	public static GStruct0[] smethod_0(ushort[] ushort_2)
	{
		if (ushort_2.IsNullOrEmpty())
		{
			return new GStruct0[0];
		}
		Func<ushort, bool> predicate = _003C_003Ec._003C_003E9.method_0;
		IEnumerable<ushort> source = ushort_2.Where(predicate).Distinct();
		Func<ushort, ushort> keySelector = _003C_003Ec._003C_003E9.method_1;
		IOrderedEnumerable<ushort> source2 = source.OrderBy(keySelector);
		Func<ushort, GStruct0> selector = _003C_003Ec._003C_003E9.method_2;
		return source2.Select(selector).ToArray();
	}

	public static GStruct0[] smethod_1(GClass7 gclass7_0)
	{
		GClass7 gClass = gclass7_0;
		if ((object)gClass == null)
		{
			gClass = new GClass7();
		}
		GClass7 gClass2 = gClass;
		if (gClass2.portsMode_0 == PortsMode.AllPorts)
		{
			return null;
		}
		if (PortsMode.SelectedOnly == gClass2.portsMode_0)
		{
			return smethod_0(gClass2.ushort_0);
		}
		if (PortsMode.AllExceptSelected == gClass2.portsMode_0)
		{
			return smethod_2(gClass2.ushort_0);
		}
		return null;
	}

	private static GStruct0[] smethod_2(ushort[] ushort_2)
	{
		ushort[] array = ushort_2;
		if (array == null)
		{
			array = new ushort[0];
		}
		Func<ushort, bool> predicate = _003C_003Ec._003C_003E9.method_3;
		IEnumerable<ushort> source = array.Where(predicate).Distinct();
		Func<ushort, ushort> keySelector = _003C_003Ec._003C_003E9.method_4;
		ushort[] array2 = source.OrderBy(keySelector).ToArray();
		if (!array2.Any())
		{
			return null;
		}
		List<GStruct0> list = new List<GStruct0>();
		int num = 1;
		ushort[] array3 = array2;
		ushort[] array4 = array3;
		foreach (ushort num2 in array4)
		{
			if (num < num2)
			{
				list.Add(new GStruct0((ushort)num, (ushort)(num2 - 1)));
			}
			num = num2 + 1;
		}
		if (num <= 65535)
		{
			list.Add(new GStruct0((ushort)num, ushort.MaxValue));
		}
		return list.ToArray();
	}

	public bool Equals(GStruct0 other)
	{
		if (ushort_0 == other.ushort_0)
		{
			return ushort_1 == other.ushort_1;
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		if (obj is GStruct0 other)
		{
			return Equals(other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (ushort_0 << 16) ^ ushort_1;
	}

	public static bool operator ==(GStruct0 _v1, GStruct0 _v2)
	{
		return _v1.Equals(_v2);
	}

	public static bool operator !=(GStruct0 _v1, GStruct0 _v2)
	{
		return !_v1.Equals(_v2);
	}
}
