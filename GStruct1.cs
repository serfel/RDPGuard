using System;
using System.Globalization;
using System.Linq;
using System.Numerics;

public struct GStruct1 : IFormattable, IComparable, IComparable<GStruct1>, IEquatable<GStruct1>
{
	private struct Struct3
	{
		public ulong ulong_0;

		public ulong ulong_1;

		public ulong ulong_2;

		public ulong ulong_3;

		public uint UInt32_0 => (uint)ulong_0;

		public uint UInt32_1 => (uint)(ulong_0 >> 32);

		public uint UInt32_2 => (uint)ulong_1;

		public uint UInt32_3 => (uint)(ulong_1 >> 32);

		public uint UInt32_4 => (uint)ulong_2;

		public uint UInt32_5 => (uint)(ulong_2 >> 32);

		public uint UInt32_6 => (uint)ulong_3;

		public uint UInt32_7 => (uint)(ulong_3 >> 32);

		public static implicit operator BigInteger(Struct3 struct3_0)
		{
			return ((BigInteger)struct3_0.ulong_3 << 192) | ((BigInteger)struct3_0.ulong_2 << 128) | ((BigInteger)struct3_0.ulong_1 << 64) | struct3_0.ulong_0;
		}

		public override string ToString()
		{
			return ((BigInteger)this/*cast due to .constrained prefix*/).ToString();
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		internal byte method_0(int int_0)
		{
			int num = 0;
			while ((int_0 != 0) ? true : false)
			{
				int_0 >>= 1;
				num++;
			}
			return (byte)num;
		}
	}

	private ulong ulong_0;

	private ulong ulong_1;

	private static readonly GStruct1 gstruct1_0 = ~(GStruct1)0;

	private static readonly GStruct1 gstruct1_1 = (GStruct1)0;

	private static readonly GStruct1 gstruct1_2 = (GStruct1)1;

	private static readonly GStruct1 gstruct1_3 = 4398046511104uL;

	private static readonly byte[] byte_0 = Enumerable.Range(0, 256).Select(_003C_003Ec._003C_003E9.method_0).ToArray();

	public static GStruct1 GStruct1_0 => gstruct1_1;

	public static GStruct1 GStruct1_1 => gstruct1_0;

	public static GStruct1 GStruct1_2 => gstruct1_1;

	public static GStruct1 GStruct1_3 => gstruct1_2;

	private uint UInt32_0 => (uint)ulong_0;

	private uint UInt32_1 => (uint)(ulong_0 >> 32);

	private uint UInt32_2 => (uint)ulong_1;

	private uint UInt32_3 => (uint)(ulong_1 >> 32);

	public ulong UInt64_0 => ulong_0;

	public ulong UInt64_1 => ulong_1;

	public bool Boolean_0 => (ulong_0 | ulong_1) == 0;

	public bool Boolean_1 => (ulong_1 ^ ulong_0) == 1;

	public bool Boolean_2 => (this & (this - 1uL)).Boolean_0;

	public bool Boolean_3 => (ulong_0 & 1) == 0;

	public int Int32_0 => (!Boolean_0) ? 1 : 0;

	public static GStruct1 smethod_0(string string_0)
	{
		if (!smethod_1(string_0, out var gstruct1_))
		{
			throw new FormatException();
		}
		return gstruct1_;
	}

	public static bool smethod_1(string string_0, out GStruct1 gstruct1_4)
	{
		return smethod_2(string_0, NumberStyles.Integer, NumberFormatInfo.CurrentInfo, out gstruct1_4);
	}

	public static bool smethod_2(string string_0, NumberStyles numberStyles_0, IFormatProvider iformatProvider_0, out GStruct1 gstruct1_4)
	{
		if (!BigInteger.TryParse(string_0, numberStyles_0, iformatProvider_0, out var result))
		{
			gstruct1_4 = GStruct1_2;
			return false;
		}
		smethod_8(out gstruct1_4, result);
		return true;
	}

	public GStruct1(long long_0)
	{
		smethod_5(out this, long_0);
	}

	public GStruct1(ulong ulong_2)
	{
		smethod_6(out this, ulong_2);
	}

	public GStruct1(decimal decimal_0)
	{
		smethod_7(out this, decimal_0);
	}

	public GStruct1(double double_0)
	{
		smethod_9(out this, double_0);
	}

	public GStruct1(BigInteger bigInteger_0)
	{
		smethod_8(out this, bigInteger_0);
	}

	public static void smethod_3(out GStruct1 gstruct1_4, uint uint_0, uint uint_1, uint uint_2, uint uint_3)
	{
		gstruct1_4.ulong_0 = ((ulong)uint_1 << 32) | uint_0;
		gstruct1_4.ulong_1 = ((ulong)uint_3 << 32) | uint_2;
	}

	public static void smethod_4(out GStruct1 gstruct1_4, ulong ulong_2, ulong ulong_3)
	{
		gstruct1_4.ulong_0 = ulong_2;
		gstruct1_4.ulong_1 = ulong_3;
	}

	public static void smethod_5(out GStruct1 gstruct1_4, long long_0)
	{
		gstruct1_4.ulong_0 = (ulong)long_0;
		gstruct1_4.ulong_1 = (ulong)((long_0 < 0) ? (-1) : 0);
	}

	public static void smethod_6(out GStruct1 gstruct1_4, ulong ulong_2)
	{
		gstruct1_4.ulong_0 = ulong_2;
		gstruct1_4.ulong_1 = 0uL;
	}

	public static void smethod_7(out GStruct1 gstruct1_4, decimal decimal_0)
	{
		int[] bits = decimal.GetBits(decimal.Truncate(decimal_0));
		smethod_3(out gstruct1_4, (uint)bits[0], (uint)bits[1], (uint)bits[2], 0u);
		if (decimal_0 < 0m)
		{
			smethod_96(ref gstruct1_4);
		}
	}

	public static void smethod_8(out GStruct1 gstruct1_4, BigInteger bigInteger_0)
	{
		int sign = bigInteger_0.Sign;
		if (sign == -1)
		{
			bigInteger_0 = -bigInteger_0;
		}
		gstruct1_4.ulong_0 = (ulong)(bigInteger_0 & ulong.MaxValue);
		gstruct1_4.ulong_1 = (ulong)(bigInteger_0 >> 64);
		if (sign == -1)
		{
			smethod_96(ref gstruct1_4);
		}
	}

	public static void smethod_9(out GStruct1 gstruct1_4, double double_0)
	{
		bool flag = false;
		if (double_0 < 0.0)
		{
			flag = true;
			double_0 = 0.0 - double_0;
		}
		if (double_0 <= 1.8446744073709552E+19)
		{
			gstruct1_4.ulong_0 = (ulong)double_0;
			gstruct1_4.ulong_1 = 0uL;
		}
		else
		{
			int num = Math.Max((int)Math.Ceiling(Math.Log(double_0, 2.0)) - 63, 0);
			gstruct1_4.ulong_0 = (ulong)(double_0 / Math.Pow(2.0, num));
			gstruct1_4.ulong_1 = 0uL;
			smethod_131(ref gstruct1_4, num);
		}
		if (flag)
		{
			smethod_96(ref gstruct1_4);
		}
	}

	public override string ToString()
	{
		return ((BigInteger)this/*cast due to .constrained prefix*/).ToString();
	}

	public string method_0(string string_0)
	{
		return ((BigInteger)this).ToString(string_0);
	}

	public string method_1(IFormatProvider iformatProvider_0)
	{
		return ToString(null, iformatProvider_0);
	}

	public string ToString(string format, IFormatProvider provider)
	{
		return ((BigInteger)this).ToString(format, provider);
	}

	public static explicit operator GStruct1(double double_0)
	{
		smethod_9(out var gstruct1_, double_0);
		return gstruct1_;
	}

	public static explicit operator GStruct1(sbyte sbyte_0)
	{
		smethod_5(out var gstruct1_, sbyte_0);
		return gstruct1_;
	}

	public static implicit operator GStruct1(byte byte_1)
	{
		smethod_5(out var gstruct1_, byte_1);
		return gstruct1_;
	}

	public static explicit operator GStruct1(short short_0)
	{
		smethod_5(out var gstruct1_, short_0);
		return gstruct1_;
	}

	public static implicit operator GStruct1(ushort ushort_0)
	{
		smethod_5(out var gstruct1_, ushort_0);
		return gstruct1_;
	}

	public static explicit operator GStruct1(int int_0)
	{
		smethod_5(out var gstruct1_, int_0);
		return gstruct1_;
	}

	public static implicit operator GStruct1(uint uint_0)
	{
		smethod_5(out var gstruct1_, uint_0);
		return gstruct1_;
	}

	public static explicit operator GStruct1(long long_0)
	{
		smethod_5(out var gstruct1_, long_0);
		return gstruct1_;
	}

	public static implicit operator GStruct1(ulong ulong_2)
	{
		smethod_6(out var gstruct1_, ulong_2);
		return gstruct1_;
	}

	public static explicit operator GStruct1(decimal decimal_0)
	{
		smethod_7(out var gstruct1_, decimal_0);
		return gstruct1_;
	}

	public static explicit operator GStruct1(BigInteger bigInteger_0)
	{
		smethod_8(out var gstruct1_, bigInteger_0);
		return gstruct1_;
	}

	public static explicit operator float(GStruct1 gstruct1_4)
	{
		return smethod_10(ref gstruct1_4);
	}

	public static explicit operator double(GStruct1 gstruct1_4)
	{
		return smethod_11(ref gstruct1_4);
	}

	public static float smethod_10(ref GStruct1 gstruct1_4)
	{
		if (gstruct1_4.ulong_1 == 0)
		{
			return gstruct1_4.ulong_0;
		}
		return (float)gstruct1_4.ulong_1 * 1.8446744E+19f + (float)gstruct1_4.ulong_0;
	}

	public static double smethod_11(ref GStruct1 gstruct1_4)
	{
		if (gstruct1_4.ulong_1 == 0)
		{
			return gstruct1_4.ulong_0;
		}
		return (double)gstruct1_4.ulong_1 * 1.8446744073709552E+19 + (double)gstruct1_4.ulong_0;
	}

	public static explicit operator sbyte(GStruct1 gstruct1_4)
	{
		return (sbyte)gstruct1_4.ulong_0;
	}

	public static explicit operator byte(GStruct1 gstruct1_4)
	{
		return (byte)gstruct1_4.ulong_0;
	}

	public static explicit operator short(GStruct1 gstruct1_4)
	{
		return (short)gstruct1_4.ulong_0;
	}

	public static explicit operator ushort(GStruct1 gstruct1_4)
	{
		return (ushort)gstruct1_4.ulong_0;
	}

	public static explicit operator int(GStruct1 gstruct1_4)
	{
		return (int)gstruct1_4.ulong_0;
	}

	public static explicit operator uint(GStruct1 gstruct1_4)
	{
		return (uint)gstruct1_4.ulong_0;
	}

	public static explicit operator long(GStruct1 gstruct1_4)
	{
		return (long)gstruct1_4.ulong_0;
	}

	public static explicit operator ulong(GStruct1 gstruct1_4)
	{
		return gstruct1_4.ulong_0;
	}

	public static explicit operator decimal(GStruct1 gstruct1_4)
	{
		if (gstruct1_4.ulong_1 == 0)
		{
			return gstruct1_4.ulong_0;
		}
		int num = Math.Max(0, 32 - smethod_138(gstruct1_4.ulong_1));
		smethod_89(out var _, ref gstruct1_4, num);
		return new decimal((int)gstruct1_4.UInt32_0, (int)gstruct1_4.UInt32_1, (int)gstruct1_4.UInt32_2, isNegative: false, (byte)num);
	}

	public static implicit operator BigInteger(GStruct1 gstruct1_4)
	{
		if (gstruct1_4.ulong_1 == 0)
		{
			return gstruct1_4.ulong_0;
		}
		return ((BigInteger)gstruct1_4.ulong_1 << 64) | gstruct1_4.ulong_0;
	}

	public static GStruct1 operator <<(GStruct1 gstruct1_4, int int_0)
	{
		smethod_87(out var gstruct1_5, ref gstruct1_4, int_0);
		return gstruct1_5;
	}

	public static GStruct1 operator >>(GStruct1 gstruct1_4, int int_0)
	{
		smethod_89(out var gstruct1_5, ref gstruct1_4, int_0);
		return gstruct1_5;
	}

	public static GStruct1 operator &(GStruct1 gstruct1_4, GStruct1 gstruct1_5)
	{
		smethod_92(out var gstruct1_6, ref gstruct1_4, ref gstruct1_5);
		return gstruct1_6;
	}

	public static uint operator &(GStruct1 gstruct1_4, uint uint_0)
	{
		return (uint)(int)gstruct1_4.ulong_0 & uint_0;
	}

	public static uint operator &(uint uint_0, GStruct1 gstruct1_4)
	{
		return uint_0 & (uint)(int)gstruct1_4.ulong_0;
	}

	public static ulong operator &(GStruct1 gstruct1_4, ulong ulong_2)
	{
		return gstruct1_4.ulong_0 & ulong_2;
	}

	public static ulong operator &(ulong ulong_2, GStruct1 gstruct1_4)
	{
		return ulong_2 & gstruct1_4.ulong_0;
	}

	public static GStruct1 operator |(GStruct1 gstruct1_4, GStruct1 gstruct1_5)
	{
		smethod_93(out var gstruct1_6, ref gstruct1_4, ref gstruct1_5);
		return gstruct1_6;
	}

	public static GStruct1 operator ^(GStruct1 gstruct1_4, GStruct1 gstruct1_5)
	{
		smethod_94(out var gstruct1_6, ref gstruct1_4, ref gstruct1_5);
		return gstruct1_6;
	}

	public static GStruct1 operator ~(GStruct1 gstruct1_4)
	{
		smethod_95(out var gstruct1_5, ref gstruct1_4);
		return gstruct1_5;
	}

	public static GStruct1 operator +(GStruct1 gstruct1_4, GStruct1 gstruct1_5)
	{
		smethod_34(out var gstruct1_6, ref gstruct1_4, ref gstruct1_5);
		return gstruct1_6;
	}

	public static GStruct1 operator +(GStruct1 gstruct1_4, ulong ulong_2)
	{
		smethod_33(out var gstruct1_5, ref gstruct1_4, ulong_2);
		return gstruct1_5;
	}

	public static GStruct1 operator +(ulong ulong_2, GStruct1 gstruct1_4)
	{
		smethod_33(out var gstruct1_5, ref gstruct1_4, ulong_2);
		return gstruct1_5;
	}

	public static GStruct1 operator ++(GStruct1 gstruct1_4)
	{
		smethod_33(out var gstruct1_5, ref gstruct1_4, 1uL);
		return gstruct1_5;
	}

	public static GStruct1 operator -(GStruct1 gstruct1_4, GStruct1 gstruct1_5)
	{
		smethod_41(out var gstruct1_6, ref gstruct1_4, ref gstruct1_5);
		return gstruct1_6;
	}

	public static GStruct1 operator -(GStruct1 gstruct1_4, ulong ulong_2)
	{
		smethod_39(out var gstruct1_5, ref gstruct1_4, ulong_2);
		return gstruct1_5;
	}

	public static GStruct1 operator -(ulong ulong_2, GStruct1 gstruct1_4)
	{
		smethod_40(out var gstruct1_5, ulong_2, ref gstruct1_4);
		return gstruct1_5;
	}

	public static GStruct1 operator --(GStruct1 gstruct1_4)
	{
		smethod_39(out var gstruct1_5, ref gstruct1_4, 1uL);
		return gstruct1_5;
	}

	public static GStruct1 operator +(GStruct1 gstruct1_4)
	{
		return gstruct1_4;
	}

	public static GStruct1 operator *(GStruct1 gstruct1_4, uint uint_0)
	{
		smethod_19(out var gstruct1_5, ref gstruct1_4, uint_0);
		return gstruct1_5;
	}

	public static GStruct1 operator *(uint uint_0, GStruct1 gstruct1_4)
	{
		smethod_19(out var gstruct1_5, ref gstruct1_4, uint_0);
		return gstruct1_5;
	}

	public static GStruct1 operator *(GStruct1 gstruct1_4, ulong ulong_2)
	{
		smethod_20(out var gstruct1_5, ref gstruct1_4, ulong_2);
		return gstruct1_5;
	}

	public static GStruct1 operator *(ulong ulong_2, GStruct1 gstruct1_4)
	{
		smethod_20(out var gstruct1_5, ref gstruct1_4, ulong_2);
		return gstruct1_5;
	}

	public static GStruct1 operator *(GStruct1 gstruct1_4, GStruct1 gstruct1_5)
	{
		smethod_21(out var gstruct1_6, ref gstruct1_4, ref gstruct1_5);
		return gstruct1_6;
	}

	public static GStruct1 operator /(GStruct1 gstruct1_4, ulong ulong_2)
	{
		smethod_54(out var gstruct1_5, ref gstruct1_4, ulong_2);
		return gstruct1_5;
	}

	public static GStruct1 operator /(GStruct1 gstruct1_4, GStruct1 gstruct1_5)
	{
		smethod_55(out var gstruct1_6, ref gstruct1_4, ref gstruct1_5);
		return gstruct1_6;
	}

	public static ulong operator %(GStruct1 gstruct1_4, uint uint_0)
	{
		return smethod_56(ref gstruct1_4, uint_0);
	}

	public static ulong operator %(GStruct1 gstruct1_4, ulong ulong_2)
	{
		return smethod_57(ref gstruct1_4, ulong_2);
	}

	public static GStruct1 operator %(GStruct1 gstruct1_4, GStruct1 gstruct1_5)
	{
		smethod_58(out var gstruct1_6, ref gstruct1_4, ref gstruct1_5);
		return gstruct1_6;
	}

	public static bool operator <(GStruct1 gstruct1_4, GStruct1 gstruct1_5)
	{
		return smethod_16(ref gstruct1_4, ref gstruct1_5);
	}

	public static bool operator <(GStruct1 gstruct1_4, int int_0)
	{
		return smethod_12(ref gstruct1_4, int_0);
	}

	public static bool operator <(int int_0, GStruct1 gstruct1_4)
	{
		return smethod_13(int_0, ref gstruct1_4);
	}

	public static bool operator <(GStruct1 gstruct1_4, uint uint_0)
	{
		return smethod_12(ref gstruct1_4, uint_0);
	}

	public static bool operator <(uint uint_0, GStruct1 gstruct1_4)
	{
		return smethod_13(uint_0, ref gstruct1_4);
	}

	public static bool operator <(GStruct1 gstruct1_4, long long_0)
	{
		return smethod_12(ref gstruct1_4, long_0);
	}

	public static bool operator <(long long_0, GStruct1 gstruct1_4)
	{
		return smethod_13(long_0, ref gstruct1_4);
	}

	public static bool operator <(GStruct1 gstruct1_4, ulong ulong_2)
	{
		return smethod_14(ref gstruct1_4, ulong_2);
	}

	public static bool operator <(ulong ulong_2, GStruct1 gstruct1_4)
	{
		return smethod_15(ulong_2, ref gstruct1_4);
	}

	public static bool operator <=(GStruct1 gstruct1_4, GStruct1 gstruct1_5)
	{
		return !smethod_16(ref gstruct1_5, ref gstruct1_4);
	}

	public static bool operator <=(GStruct1 gstruct1_4, int int_0)
	{
		return !smethod_13(int_0, ref gstruct1_4);
	}

	public static bool operator <=(int int_0, GStruct1 gstruct1_4)
	{
		return !smethod_12(ref gstruct1_4, int_0);
	}

	public static bool operator <=(GStruct1 gstruct1_4, uint uint_0)
	{
		return !smethod_13(uint_0, ref gstruct1_4);
	}

	public static bool operator <=(uint uint_0, GStruct1 gstruct1_4)
	{
		return !smethod_12(ref gstruct1_4, uint_0);
	}

	public static bool operator <=(GStruct1 gstruct1_4, long long_0)
	{
		return !smethod_13(long_0, ref gstruct1_4);
	}

	public static bool operator <=(long long_0, GStruct1 gstruct1_4)
	{
		return !smethod_12(ref gstruct1_4, long_0);
	}

	public static bool operator <=(GStruct1 gstruct1_4, ulong ulong_2)
	{
		return !smethod_15(ulong_2, ref gstruct1_4);
	}

	public static bool operator <=(ulong ulong_2, GStruct1 gstruct1_4)
	{
		return !smethod_14(ref gstruct1_4, ulong_2);
	}

	public static bool operator >(GStruct1 gstruct1_4, GStruct1 gstruct1_5)
	{
		return smethod_16(ref gstruct1_5, ref gstruct1_4);
	}

	public static bool operator >(GStruct1 gstruct1_4, int int_0)
	{
		return smethod_13(int_0, ref gstruct1_4);
	}

	public static bool operator >(int int_0, GStruct1 gstruct1_4)
	{
		return smethod_12(ref gstruct1_4, int_0);
	}

	public static bool operator >(GStruct1 gstruct1_4, uint uint_0)
	{
		return smethod_13(uint_0, ref gstruct1_4);
	}

	public static bool operator >(uint uint_0, GStruct1 gstruct1_4)
	{
		return smethod_12(ref gstruct1_4, uint_0);
	}

	public static bool operator >(GStruct1 gstruct1_4, long long_0)
	{
		return smethod_13(long_0, ref gstruct1_4);
	}

	public static bool operator >(long long_0, GStruct1 gstruct1_4)
	{
		return smethod_12(ref gstruct1_4, long_0);
	}

	public static bool operator >(GStruct1 gstruct1_4, ulong ulong_2)
	{
		return smethod_15(ulong_2, ref gstruct1_4);
	}

	public static bool operator >(ulong ulong_2, GStruct1 gstruct1_4)
	{
		return smethod_14(ref gstruct1_4, ulong_2);
	}

	public static bool operator >=(GStruct1 gstruct1_4, GStruct1 gstruct1_5)
	{
		return !smethod_16(ref gstruct1_4, ref gstruct1_5);
	}

	public static bool operator >=(GStruct1 gstruct1_4, int int_0)
	{
		return !smethod_12(ref gstruct1_4, int_0);
	}

	public static bool operator >=(int int_0, GStruct1 gstruct1_4)
	{
		return !smethod_13(int_0, ref gstruct1_4);
	}

	public static bool operator >=(GStruct1 gstruct1_4, uint uint_0)
	{
		return !smethod_12(ref gstruct1_4, uint_0);
	}

	public static bool operator >=(uint uint_0, GStruct1 gstruct1_4)
	{
		return !smethod_13(uint_0, ref gstruct1_4);
	}

	public static bool operator >=(GStruct1 gstruct1_4, long long_0)
	{
		return !smethod_12(ref gstruct1_4, long_0);
	}

	public static bool operator >=(long long_0, GStruct1 gstruct1_4)
	{
		return !smethod_13(long_0, ref gstruct1_4);
	}

	public static bool operator >=(GStruct1 gstruct1_4, ulong ulong_2)
	{
		return !smethod_14(ref gstruct1_4, ulong_2);
	}

	public static bool operator >=(ulong ulong_2, GStruct1 gstruct1_4)
	{
		return !smethod_15(ulong_2, ref gstruct1_4);
	}

	public static bool operator ==(GStruct1 gstruct1_4, GStruct1 gstruct1_5)
	{
		return gstruct1_4.Equals(gstruct1_5);
	}

	public static bool operator ==(GStruct1 gstruct1_4, int int_0)
	{
		return gstruct1_4.method_6(int_0);
	}

	public static bool operator ==(int int_0, GStruct1 gstruct1_4)
	{
		return gstruct1_4.method_6(int_0);
	}

	public static bool operator ==(GStruct1 gstruct1_4, uint uint_0)
	{
		return gstruct1_4.InitializeComponent(uint_0);
	}

	public static bool operator ==(uint uint_0, GStruct1 gstruct1_4)
	{
		return gstruct1_4.InitializeComponent(uint_0);
	}

	public static bool operator ==(GStruct1 gstruct1_4, long long_0)
	{
		return gstruct1_4.CloseDialog(long_0);
	}

	public static bool operator ==(long long_0, GStruct1 gstruct1_4)
	{
		return gstruct1_4.CloseDialog(long_0);
	}

	public static bool operator ==(GStruct1 gstruct1_4, ulong ulong_2)
	{
		return gstruct1_4.ShowOnlineHelp(ulong_2);
	}

	public static bool operator ==(ulong ulong_2, GStruct1 gstruct1_4)
	{
		return gstruct1_4.ShowOnlineHelp(ulong_2);
	}

	public static bool operator !=(GStruct1 gstruct1_4, GStruct1 gstruct1_5)
	{
		return !gstruct1_4.Equals(gstruct1_5);
	}

	public static bool operator !=(GStruct1 gstruct1_4, int int_0)
	{
		return !gstruct1_4.method_6(int_0);
	}

	public static bool operator !=(int int_0, GStruct1 gstruct1_4)
	{
		return !gstruct1_4.method_6(int_0);
	}

	public static bool operator !=(GStruct1 gstruct1_4, uint uint_0)
	{
		return !gstruct1_4.InitializeComponent(uint_0);
	}

	public static bool operator !=(uint uint_0, GStruct1 gstruct1_4)
	{
		return !gstruct1_4.InitializeComponent(uint_0);
	}

	public static bool operator !=(GStruct1 gstruct1_4, long long_0)
	{
		return !gstruct1_4.CloseDialog(long_0);
	}

	public static bool operator !=(long long_0, GStruct1 gstruct1_4)
	{
		return !gstruct1_4.CloseDialog(long_0);
	}

	public static bool operator !=(GStruct1 gstruct1_4, ulong ulong_2)
	{
		return !gstruct1_4.ShowOnlineHelp(ulong_2);
	}

	public static bool operator !=(ulong ulong_2, GStruct1 gstruct1_4)
	{
		return !gstruct1_4.ShowOnlineHelp(ulong_2);
	}

	public int CompareTo(GStruct1 other)
	{
		if (ulong_1 != other.ulong_1)
		{
			return ulong_1.CompareTo(other.ulong_1);
		}
		return ulong_0.CompareTo(other.ulong_0);
	}

	public int method_2(int int_0)
	{
		if (ulong_1 == 0L && int_0 >= 0)
		{
			return ulong_0.CompareTo((ulong)int_0);
		}
		return 1;
	}

	public int method_3(uint uint_0)
	{
		if (ulong_1 != 0)
		{
			return 1;
		}
		return ulong_0.CompareTo(uint_0);
	}

	public int method_4(long long_0)
	{
		if (ulong_1 == 0L && long_0 >= 0)
		{
			return ulong_0.CompareTo((ulong)long_0);
		}
		return 1;
	}

	public int method_5(ulong ulong_2)
	{
		if (ulong_1 != 0)
		{
			return 1;
		}
		return ulong_0.CompareTo(ulong_2);
	}

	public int CompareTo(object target)
	{
		if (target == null)
		{
			return 1;
		}
		if (!(target is GStruct1))
		{
			throw new ArgumentException();
		}
		return CompareTo((GStruct1)target);
	}

	private static bool smethod_12(ref GStruct1 gstruct1_4, long long_0)
	{
		if (long_0 >= 0 && gstruct1_4.ulong_1 == 0)
		{
			return gstruct1_4.ulong_0 < (ulong)long_0;
		}
		return false;
	}

	private static bool smethod_13(long long_0, ref GStruct1 gstruct1_4)
	{
		if (long_0 >= 0 && gstruct1_4.ulong_1 == 0)
		{
			return (ulong)long_0 < gstruct1_4.ulong_0;
		}
		return true;
	}

	private static bool smethod_14(ref GStruct1 gstruct1_4, ulong ulong_2)
	{
		if (gstruct1_4.ulong_1 == 0)
		{
			return gstruct1_4.ulong_0 < ulong_2;
		}
		return false;
	}

	private static bool smethod_15(ulong ulong_2, ref GStruct1 gstruct1_4)
	{
		if (gstruct1_4.ulong_1 == 0)
		{
			return ulong_2 < gstruct1_4.ulong_0;
		}
		return true;
	}

	private static bool smethod_16(ref GStruct1 gstruct1_4, ref GStruct1 gstruct1_5)
	{
		if (gstruct1_4.ulong_1 != gstruct1_5.ulong_1)
		{
			return gstruct1_4.ulong_1 < gstruct1_5.ulong_1;
		}
		return gstruct1_4.ulong_0 < gstruct1_5.ulong_0;
	}

	public static bool smethod_17(ref GStruct1 gstruct1_4, ref GStruct1 gstruct1_5)
	{
		if (gstruct1_4.ulong_0 == gstruct1_5.ulong_0)
		{
			return gstruct1_4.ulong_1 == gstruct1_5.ulong_1;
		}
		return false;
	}

	public bool Equals(GStruct1 other)
	{
		if (ulong_0 == other.ulong_0)
		{
			return ulong_1 == other.ulong_1;
		}
		return false;
	}

	public bool method_6(int int_0)
	{
		if (int_0 >= 0 && ulong_0 == (uint)int_0)
		{
			return ulong_1 == 0;
		}
		return false;
	}

	public bool InitializeComponent(uint uint_0)
	{
		if (ulong_0 == uint_0)
		{
			return ulong_1 == 0;
		}
		return false;
	}

	public bool CloseDialog(long long_0)
	{
		if (long_0 >= 0 && ulong_0 == (ulong)long_0)
		{
			return ulong_1 == 0;
		}
		return false;
	}

	public bool ShowOnlineHelp(ulong ulong_2)
	{
		if (ulong_0 == ulong_2)
		{
			return ulong_1 == 0;
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is GStruct1))
		{
			return false;
		}
		return Equals((GStruct1)obj);
	}

	public override int GetHashCode()
	{
		return ulong_0.GetHashCode() ^ ulong_1.GetHashCode();
	}

	public static void smethod_18(out GStruct1 gstruct1_4, ulong ulong_2, ulong ulong_3)
	{
		smethod_47(out gstruct1_4, ulong_2, ulong_3);
	}

	public static void smethod_19(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, uint uint_0)
	{
		if (gstruct1_5.ulong_1 == 0)
		{
			smethod_46(out gstruct1_4, gstruct1_5.ulong_0, uint_0);
		}
		else
		{
			smethod_50(out gstruct1_4, ref gstruct1_5, uint_0);
		}
	}

	public static void smethod_20(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, ulong ulong_2)
	{
		if (gstruct1_5.ulong_1 == 0)
		{
			smethod_47(out gstruct1_4, gstruct1_5.ulong_0, ulong_2);
		}
		else
		{
			smethod_51(out gstruct1_4, ref gstruct1_5, ulong_2);
		}
	}

	public static void smethod_21(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, ref GStruct1 gstruct1_6)
	{
		if ((gstruct1_5.ulong_1 | gstruct1_6.ulong_1) == 0)
		{
			smethod_47(out gstruct1_4, gstruct1_5.ulong_0, gstruct1_6.ulong_0);
		}
		else if (gstruct1_5.ulong_1 == 0)
		{
			smethod_51(out gstruct1_4, ref gstruct1_6, gstruct1_5.ulong_0);
		}
		else if (gstruct1_6.ulong_1 == 0)
		{
			smethod_51(out gstruct1_4, ref gstruct1_5, gstruct1_6.ulong_0);
		}
		else
		{
			smethod_52(out gstruct1_4, ref gstruct1_5, ref gstruct1_6);
		}
	}

	private static void smethod_22(out Struct3 struct3_0, ref GStruct1 gstruct1_4, ref GStruct1 gstruct1_5)
	{
		smethod_47(out var gstruct1_6, gstruct1_4.ulong_0, gstruct1_5.ulong_0);
		smethod_47(out var gstruct1_7, gstruct1_4.ulong_0, gstruct1_5.ulong_1);
		smethod_47(out var gstruct1_8, gstruct1_4.ulong_1, gstruct1_5.ulong_0);
		smethod_47(out var gstruct1_9, gstruct1_4.ulong_1, gstruct1_5.ulong_1);
		uint uint_ = 0u;
		uint uint_2 = 0u;
		struct3_0.ulong_0 = gstruct1_6.UInt64_0;
		struct3_0.ulong_1 = smethod_35(smethod_35(gstruct1_6.ulong_1, gstruct1_7.ulong_0, ref uint_), gstruct1_8.ulong_0, ref uint_);
		struct3_0.ulong_2 = smethod_35(smethod_35(smethod_35(gstruct1_7.ulong_1, gstruct1_8.ulong_1, ref uint_2), gstruct1_9.ulong_0, ref uint_2), uint_, ref uint_2);
		struct3_0.ulong_3 = gstruct1_9.ulong_1 + uint_2;
	}

	public static GStruct1 smethod_23(GStruct1 gstruct1_4)
	{
		return gstruct1_4;
	}

	public static GStruct1 smethod_24(ulong ulong_2)
	{
		smethod_26(out var gstruct1_, ulong_2);
		return gstruct1_;
	}

	public static GStruct1 smethod_25(GStruct1 gstruct1_4)
	{
		smethod_27(out var gstruct1_5, ref gstruct1_4);
		return gstruct1_5;
	}

	public static void smethod_26(out GStruct1 gstruct1_4, ulong ulong_2)
	{
		smethod_45(out gstruct1_4, ulong_2);
	}

	public static void smethod_27(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5)
	{
		if (gstruct1_5.ulong_1 == 0)
		{
			smethod_45(out gstruct1_4, gstruct1_5.ulong_0);
		}
		else
		{
			smethod_52(out gstruct1_4, ref gstruct1_5, ref gstruct1_5);
		}
	}

	public static GStruct1 smethod_28(ulong ulong_2)
	{
		smethod_30(out var gstruct1_, ulong_2);
		return gstruct1_;
	}

	public static GStruct1 smethod_29(GStruct1 gstruct1_4)
	{
		smethod_31(out var gstruct1_5, ref gstruct1_4);
		return gstruct1_5;
	}

	public static void smethod_30(out GStruct1 gstruct1_4, ulong ulong_2)
	{
		smethod_26(out var gstruct1_5, ulong_2);
		smethod_20(out gstruct1_4, ref gstruct1_5, ulong_2);
	}

	public static void smethod_31(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5)
	{
		GStruct1 gstruct1_6;
		if (gstruct1_5.ulong_1 == 0)
		{
			smethod_45(out gstruct1_6, gstruct1_5.ulong_0);
			smethod_20(out gstruct1_4, ref gstruct1_6, gstruct1_5.ulong_0);
		}
		else
		{
			smethod_52(out gstruct1_6, ref gstruct1_5, ref gstruct1_5);
			smethod_52(out gstruct1_4, ref gstruct1_6, ref gstruct1_5);
		}
	}

	public static void smethod_32(out GStruct1 gstruct1_4, ulong ulong_2, ulong ulong_3)
	{
		gstruct1_4.ulong_0 = ulong_2 + ulong_3;
		gstruct1_4.ulong_1 = 0uL;
		if (gstruct1_4.ulong_0 < ulong_2 && gstruct1_4.ulong_0 < ulong_3)
		{
			gstruct1_4.ulong_1++;
		}
	}

	public static void smethod_33(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, ulong ulong_2)
	{
		gstruct1_4.ulong_0 = gstruct1_5.ulong_0 + ulong_2;
		gstruct1_4.ulong_1 = gstruct1_5.ulong_1;
		if (gstruct1_4.ulong_0 < gstruct1_5.ulong_0 && gstruct1_4.ulong_0 < ulong_2)
		{
			gstruct1_4.ulong_1++;
		}
	}

	public static void smethod_34(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, ref GStruct1 gstruct1_6)
	{
		gstruct1_4.ulong_0 = gstruct1_5.ulong_0 + gstruct1_6.ulong_0;
		gstruct1_4.ulong_1 = gstruct1_5.ulong_1 + gstruct1_6.ulong_1;
		if (gstruct1_4.ulong_0 < gstruct1_5.ulong_0 && gstruct1_4.ulong_0 < gstruct1_6.ulong_0)
		{
			gstruct1_4.ulong_1++;
		}
	}

	private static ulong smethod_35(ulong ulong_2, ulong ulong_3, ref uint uint_0)
	{
		ulong num = ulong_2 + ulong_3;
		if (num < ulong_2 && num < ulong_3)
		{
			uint_0++;
		}
		return num;
	}

	public static void smethod_36(ref GStruct1 gstruct1_4, ulong ulong_2)
	{
		ulong num = gstruct1_4.ulong_0 + ulong_2;
		if (num < gstruct1_4.ulong_0 && num < ulong_2)
		{
			gstruct1_4.ulong_1++;
		}
		gstruct1_4.ulong_0 = num;
	}

	public static void smethod_37(ref GStruct1 gstruct1_4, ref GStruct1 gstruct1_5)
	{
		ulong num = gstruct1_4.ulong_0 + gstruct1_5.ulong_0;
		if (num < gstruct1_4.ulong_0 && num < gstruct1_5.ulong_0)
		{
			gstruct1_4.ulong_1++;
		}
		gstruct1_4.ulong_0 = num;
		gstruct1_4.ulong_1 += gstruct1_5.ulong_1;
	}

	public static void smethod_38(ref GStruct1 gstruct1_4, GStruct1 gstruct1_5)
	{
		smethod_37(ref gstruct1_4, ref gstruct1_5);
	}

	public static void smethod_39(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, ulong ulong_2)
	{
		gstruct1_4.ulong_0 = gstruct1_5.ulong_0 - ulong_2;
		gstruct1_4.ulong_1 = gstruct1_5.ulong_1;
		if (gstruct1_5.ulong_0 < ulong_2)
		{
			gstruct1_4.ulong_1--;
		}
	}

	public static void smethod_40(out GStruct1 gstruct1_4, ulong ulong_2, ref GStruct1 gstruct1_5)
	{
		gstruct1_4.ulong_0 = ulong_2 - gstruct1_5.ulong_0;
		gstruct1_4.ulong_1 = 0 - gstruct1_5.ulong_1;
		if (ulong_2 < gstruct1_5.ulong_0)
		{
			gstruct1_4.ulong_1--;
		}
	}

	public static void smethod_41(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, ref GStruct1 gstruct1_6)
	{
		gstruct1_4.ulong_0 = gstruct1_5.ulong_0 - gstruct1_6.ulong_0;
		gstruct1_4.ulong_1 = gstruct1_5.ulong_1 - gstruct1_6.ulong_1;
		if (gstruct1_5.ulong_0 < gstruct1_6.ulong_0)
		{
			gstruct1_4.ulong_1--;
		}
	}

	public static void smethod_42(ref GStruct1 gstruct1_4, ulong ulong_2)
	{
		if (gstruct1_4.ulong_0 < ulong_2)
		{
			gstruct1_4.ulong_1--;
		}
		gstruct1_4.ulong_0 -= ulong_2;
	}

	public static void smethod_43(ref GStruct1 gstruct1_4, ref GStruct1 gstruct1_5)
	{
		if (gstruct1_4.ulong_0 < gstruct1_5.ulong_0)
		{
			gstruct1_4.ulong_1--;
		}
		gstruct1_4.ulong_0 -= gstruct1_5.ulong_0;
		gstruct1_4.ulong_1 -= gstruct1_5.ulong_1;
	}

	public static void smethod_44(ref GStruct1 gstruct1_4, GStruct1 gstruct1_5)
	{
		smethod_43(ref gstruct1_4, ref gstruct1_5);
	}

	private static void smethod_45(out GStruct1 gstruct1_4, ulong ulong_2)
	{
		long num = (uint)ulong_2;
		ulong num2 = ulong_2 >> 32;
		ulong num3 = (ulong)(num * num);
		uint num4 = (uint)num3;
		ulong num5 = (ulong)num * num2;
		num3 = (num3 >> 32) + num5;
		ulong num6 = num3 >> 32;
		num3 = (uint)num3 + num5;
		gstruct1_4.ulong_0 = (num3 << 32) | num4;
		gstruct1_4.ulong_1 = (num3 >> 32) + num6 + num2 * num2;
	}

	private static void smethod_46(out GStruct1 gstruct1_4, ulong ulong_2, uint uint_0)
	{
		long num = (uint)ulong_2;
		ulong num2 = ulong_2 >> 32;
		ulong num3 = (ulong)(num * uint_0);
		uint num4 = (uint)num3;
		num3 = (num3 >> 32) + num2 * uint_0;
		gstruct1_4.ulong_0 = (num3 << 32) | num4;
		gstruct1_4.ulong_1 = num3 >> 32;
	}

	private static void smethod_47(out GStruct1 gstruct1_4, ulong ulong_2, ulong ulong_3)
	{
		ulong num = (uint)ulong_2;
		ulong num2 = ulong_2 >> 32;
		ulong num3 = (uint)ulong_3;
		ulong num4 = ulong_3 >> 32;
		ulong num5 = num * num3;
		uint num6 = (uint)num5;
		num5 = (num5 >> 32) + num * num4;
		ulong num7 = num5 >> 32;
		num5 = (uint)num5 + num2 * num3;
		gstruct1_4.ulong_0 = (num5 << 32) | num6;
		gstruct1_4.ulong_1 = (num5 >> 32) + num7 + num2 * num4;
	}

	private static void smethod_48(out GStruct1 gstruct1_4, ulong ulong_2, ulong ulong_3, ulong ulong_4)
	{
		ulong num = (uint)ulong_2;
		ulong num2 = ulong_2 >> 32;
		ulong num3 = (uint)ulong_3;
		ulong num4 = ulong_3 >> 32;
		ulong num5 = num * num3 + (uint)ulong_4;
		uint num6 = (uint)num5;
		num5 = (num5 >> 32) + num * num4 + (ulong_4 >> 32);
		ulong num7 = num5 >> 32;
		num5 = (uint)num5 + num2 * num3;
		gstruct1_4.ulong_0 = (num5 << 32) | num6;
		gstruct1_4.ulong_1 = (num5 >> 32) + num7 + num2 * num4;
	}

	private static ulong smethod_49(ulong ulong_2, ulong ulong_3, ulong ulong_4)
	{
		ulong num = (uint)ulong_2;
		ulong num2 = ulong_2 >> 32;
		ulong num3 = (uint)ulong_3;
		ulong num4 = ulong_3 >> 32;
		ulong num5 = (num * num3 + (uint)ulong_4 >> 32) + num * num4 + (ulong_4 >> 32);
		ulong num6 = num5 >> 32;
		return ((uint)num5 + num2 * num3 >> 32) + num6 + num2 * num4;
	}

	private static void smethod_50(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, uint uint_0)
	{
		smethod_46(out gstruct1_4, gstruct1_5.ulong_0, uint_0);
		gstruct1_4.ulong_1 += gstruct1_5.ulong_1 * uint_0;
	}

	private static void smethod_51(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, ulong ulong_2)
	{
		smethod_47(out gstruct1_4, gstruct1_5.ulong_0, ulong_2);
		gstruct1_4.ulong_1 += gstruct1_5.ulong_1 * ulong_2;
	}

	private static void smethod_52(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, ref GStruct1 gstruct1_6)
	{
		smethod_47(out gstruct1_4, gstruct1_5.ulong_0, gstruct1_6.ulong_0);
		gstruct1_4.ulong_1 += gstruct1_5.ulong_1 * gstruct1_6.ulong_0 + gstruct1_5.ulong_0 * gstruct1_6.ulong_1;
	}

	public static void smethod_53(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, uint uint_0)
	{
		if (gstruct1_5.ulong_1 == 0)
		{
			smethod_61(out gstruct1_4, gstruct1_5.ulong_0, uint_0);
		}
		else if (gstruct1_5.ulong_1 <= uint.MaxValue)
		{
			smethod_62(out gstruct1_4, ref gstruct1_5, uint_0);
		}
		else
		{
			smethod_63(out gstruct1_4, ref gstruct1_5, uint_0);
		}
	}

	public static void smethod_54(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, ulong ulong_2)
	{
		if (gstruct1_5.ulong_1 == 0)
		{
			smethod_61(out gstruct1_4, gstruct1_5.ulong_0, ulong_2);
			return;
		}
		uint num = (uint)ulong_2;
		if (ulong_2 == num)
		{
			if (gstruct1_5.ulong_1 <= uint.MaxValue)
			{
				smethod_62(out gstruct1_4, ref gstruct1_5, num);
			}
			else
			{
				smethod_63(out gstruct1_4, ref gstruct1_5, num);
			}
		}
		else if (gstruct1_5.ulong_1 <= uint.MaxValue)
		{
			smethod_64(out gstruct1_4, ref gstruct1_5, ulong_2);
		}
		else
		{
			smethod_65(out gstruct1_4, ref gstruct1_5, ulong_2);
		}
	}

	public static void smethod_55(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, ref GStruct1 gstruct1_6)
	{
		GStruct1 gstruct1_7;
		if (smethod_16(ref gstruct1_5, ref gstruct1_6))
		{
			gstruct1_4 = GStruct1_2;
		}
		else if (gstruct1_6.ulong_1 == 0)
		{
			smethod_54(out gstruct1_4, ref gstruct1_5, gstruct1_6.ulong_0);
		}
		else if (gstruct1_6.ulong_1 <= uint.MaxValue)
		{
			smethod_6(out gstruct1_4, smethod_70(out gstruct1_7, ref gstruct1_5, ref gstruct1_6));
		}
		else
		{
			smethod_5(out gstruct1_4, smethod_71(out gstruct1_7, ref gstruct1_5, ref gstruct1_6));
		}
	}

	public static uint smethod_56(ref GStruct1 gstruct1_4, uint uint_0)
	{
		if (gstruct1_4.ulong_1 == 0)
		{
			return (uint)(gstruct1_4.ulong_0 % uint_0);
		}
		if (gstruct1_4.ulong_1 <= uint.MaxValue)
		{
			return smethod_66(ref gstruct1_4, uint_0);
		}
		return smethod_67(ref gstruct1_4, uint_0);
	}

	public static ulong smethod_57(ref GStruct1 gstruct1_4, ulong ulong_2)
	{
		if (gstruct1_4.ulong_1 == 0)
		{
			return gstruct1_4.ulong_0 % ulong_2;
		}
		uint num = (uint)ulong_2;
		if (ulong_2 == num)
		{
			if (gstruct1_4.ulong_1 <= uint.MaxValue)
			{
				return smethod_66(ref gstruct1_4, num);
			}
			return smethod_67(ref gstruct1_4, num);
		}
		if (gstruct1_4.ulong_1 <= uint.MaxValue)
		{
			return smethod_68(ref gstruct1_4, ulong_2);
		}
		return smethod_69(ref gstruct1_4, ulong_2);
	}

	public static void smethod_58(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, ref GStruct1 gstruct1_6)
	{
		if (smethod_16(ref gstruct1_5, ref gstruct1_6))
		{
			gstruct1_4 = gstruct1_5;
		}
		else if (gstruct1_6.ulong_1 == 0)
		{
			smethod_6(out gstruct1_4, smethod_57(ref gstruct1_5, gstruct1_6.ulong_0));
		}
		else if (gstruct1_6.ulong_1 <= uint.MaxValue)
		{
			smethod_70(out gstruct1_4, ref gstruct1_5, ref gstruct1_6);
		}
		else
		{
			smethod_71(out gstruct1_4, ref gstruct1_5, ref gstruct1_6);
		}
	}

	public static void smethod_59(ref GStruct1 gstruct1_4, ref GStruct1 gstruct1_5)
	{
		GStruct1 gstruct1_6 = gstruct1_4;
		smethod_58(out gstruct1_4, ref gstruct1_6, ref gstruct1_5);
	}

	private static void smethod_60(out GStruct1 gstruct1_4, ref Struct3 struct3_0, ref GStruct1 gstruct1_5)
	{
		if (gstruct1_5.UInt32_3 == 0)
		{
			smethod_72(out gstruct1_4, ref struct3_0, ref gstruct1_5);
		}
		else
		{
			smethod_73(out gstruct1_4, ref struct3_0, ref gstruct1_5);
		}
	}

	private static void smethod_61(out GStruct1 gstruct1_4, ulong ulong_2, ulong ulong_3)
	{
		gstruct1_4.ulong_1 = 0uL;
		gstruct1_4.ulong_0 = ulong_2 / ulong_3;
	}

	private static void smethod_62(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, uint uint_0)
	{
		uint uInt32_ = gstruct1_5.UInt32_2;
		uint num = uInt32_ / uint_0;
		ulong num2 = ((ulong)(uInt32_ - num * uint_0) << 32) | gstruct1_5.UInt32_1;
		uint num3 = (uint)(num2 / uint_0);
		uint num4 = (uint)(((num2 - num3 * uint_0 << 32) | gstruct1_5.UInt32_0) / uint_0);
		gstruct1_4.ulong_1 = num;
		gstruct1_4.ulong_0 = ((ulong)num3 << 32) | num4;
	}

	private static void smethod_63(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, uint uint_0)
	{
		uint uInt32_ = gstruct1_5.UInt32_3;
		uint num = uInt32_ / uint_0;
		ulong num2 = ((ulong)(uInt32_ - num * uint_0) << 32) | gstruct1_5.UInt32_2;
		uint num3 = (uint)(num2 / uint_0);
		ulong num4 = (num2 - num3 * uint_0 << 32) | gstruct1_5.UInt32_1;
		uint num5 = (uint)(num4 / uint_0);
		uint num6 = (uint)(((num4 - num5 * uint_0 << 32) | gstruct1_5.UInt32_0) / uint_0);
		gstruct1_4.ulong_1 = ((ulong)num << 32) | num3;
		gstruct1_4.ulong_0 = ((ulong)num5 << 32) | num6;
	}

	private static void smethod_64(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, ulong ulong_2)
	{
		gstruct1_4.ulong_1 = 0uL;
		gstruct1_4.ulong_0 = 0uL;
		int num = smethod_137((uint)(ulong_2 >> 32));
		int num2 = 32 - num;
		ulong num3 = ulong_2 << num2;
		uint uint_ = (uint)(num3 >> 32);
		uint uint_2 = (uint)num3;
		uint uint_3 = gstruct1_5.UInt32_0;
		uint uint_4 = gstruct1_5.UInt32_1;
		uint uint_5 = gstruct1_5.UInt32_2;
		uint uint_6 = 0u;
		if (num2 != 0)
		{
			uint_6 = uint_5 >> num;
			uint_5 = (uint_5 << num2) | (uint_4 >> num);
			uint_4 = (uint_4 << num2) | (uint_3 >> num);
			uint_3 <<= num2;
		}
		uint num4 = smethod_75(uint_6, ref uint_5, ref uint_4, uint_, uint_2);
		uint num5 = smethod_75(uint_5, ref uint_4, ref uint_3, uint_, uint_2);
		gstruct1_4.ulong_0 = ((ulong)num4 << 32) | num5;
		gstruct1_4.ulong_1 = 0uL;
	}

	private static void smethod_65(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, ulong ulong_2)
	{
		gstruct1_4.ulong_1 = 0uL;
		gstruct1_4.ulong_0 = 0uL;
		int num = smethod_137((uint)(ulong_2 >> 32));
		int num2 = 32 - num;
		ulong num3 = ulong_2 << num2;
		uint uint_ = (uint)(num3 >> 32);
		uint uint_2 = (uint)num3;
		uint uint_3 = gstruct1_5.UInt32_0;
		uint uint_4 = gstruct1_5.UInt32_1;
		uint uint_5 = gstruct1_5.UInt32_2;
		uint uint_6 = gstruct1_5.UInt32_3;
		uint uint_7 = 0u;
		if (num2 != 0)
		{
			uint_7 = uint_6 >> num;
			uint_6 = (uint_6 << num2) | (uint_5 >> num);
			uint_5 = (uint_5 << num2) | (uint_4 >> num);
			uint_4 = (uint_4 << num2) | (uint_3 >> num);
			uint_3 <<= num2;
		}
		gstruct1_4.ulong_1 = smethod_75(uint_7, ref uint_6, ref uint_5, uint_, uint_2);
		uint num4 = smethod_75(uint_6, ref uint_5, ref uint_4, uint_, uint_2);
		uint num5 = smethod_75(uint_5, ref uint_4, ref uint_3, uint_, uint_2);
		gstruct1_4.ulong_0 = ((ulong)num4 << 32) | num5;
	}

	private static uint smethod_66(ref GStruct1 gstruct1_4, uint uint_0)
	{
		return (uint)((((((ulong)(gstruct1_4.UInt32_2 % uint_0) << 32) | gstruct1_4.UInt32_1) % uint_0 << 32) | gstruct1_4.UInt32_0) % uint_0);
	}

	private static uint smethod_67(ref GStruct1 gstruct1_4, uint uint_0)
	{
		return (uint)((((((((ulong)(gstruct1_4.UInt32_3 % uint_0) << 32) | gstruct1_4.UInt32_2) % uint_0 << 32) | gstruct1_4.UInt32_1) % uint_0 << 32) | gstruct1_4.UInt32_0) % uint_0);
	}

	private static ulong smethod_68(ref GStruct1 gstruct1_4, ulong ulong_2)
	{
		int num = smethod_137((uint)(ulong_2 >> 32));
		int num2 = 32 - num;
		ulong num3 = ulong_2 << num2;
		uint uint_ = (uint)(num3 >> 32);
		uint uint_2 = (uint)num3;
		uint uint_3 = gstruct1_4.UInt32_0;
		uint uint_4 = gstruct1_4.UInt32_1;
		uint uint_5 = gstruct1_4.UInt32_2;
		uint uint_6 = 0u;
		if (num2 != 0)
		{
			uint_6 = uint_5 >> num;
			uint_5 = (uint_5 << num2) | (uint_4 >> num);
			uint_4 = (uint_4 << num2) | (uint_3 >> num);
			uint_3 <<= num2;
		}
		smethod_75(uint_6, ref uint_5, ref uint_4, uint_, uint_2);
		smethod_75(uint_5, ref uint_4, ref uint_3, uint_, uint_2);
		return (((ulong)uint_4 << 32) | uint_3) >> num2;
	}

	private static ulong smethod_69(ref GStruct1 gstruct1_4, ulong ulong_2)
	{
		int num = smethod_137((uint)(ulong_2 >> 32));
		int num2 = 32 - num;
		ulong num3 = ulong_2 << num2;
		uint uint_ = (uint)(num3 >> 32);
		uint uint_2 = (uint)num3;
		uint uint_3 = gstruct1_4.UInt32_0;
		uint uint_4 = gstruct1_4.UInt32_1;
		uint uint_5 = gstruct1_4.UInt32_2;
		uint uint_6 = gstruct1_4.UInt32_3;
		uint uint_7 = 0u;
		if (num2 != 0)
		{
			uint_7 = uint_6 >> num;
			uint_6 = (uint_6 << num2) | (uint_5 >> num);
			uint_5 = (uint_5 << num2) | (uint_4 >> num);
			uint_4 = (uint_4 << num2) | (uint_3 >> num);
			uint_3 <<= num2;
		}
		smethod_75(uint_7, ref uint_6, ref uint_5, uint_, uint_2);
		smethod_75(uint_6, ref uint_5, ref uint_4, uint_, uint_2);
		smethod_75(uint_5, ref uint_4, ref uint_3, uint_, uint_2);
		return (((ulong)uint_4 << 32) | uint_3) >> num2;
	}

	private static ulong smethod_70(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, ref GStruct1 gstruct1_6)
	{
		int int_ = 32 - smethod_137(gstruct1_6.UInt32_2);
		smethod_85(out var gstruct1_7, ref gstruct1_6, int_);
		int uint_ = (int)smethod_85(out gstruct1_4, ref gstruct1_5, int_);
		uint uInt32_ = gstruct1_7.UInt32_2;
		uint uInt32_2 = gstruct1_7.UInt32_1;
		uint uInt32_3 = gstruct1_7.UInt32_0;
		uint uint_2 = gstruct1_4.UInt32_3;
		uint uint_3 = gstruct1_4.UInt32_2;
		uint uint_4 = gstruct1_4.UInt32_1;
		uint uint_5 = gstruct1_4.UInt32_0;
		uint num = smethod_76((uint)uint_, ref uint_2, ref uint_3, ref uint_4, uInt32_, uInt32_2, uInt32_3);
		uint num2 = smethod_76(uint_2, ref uint_3, ref uint_4, ref uint_5, uInt32_, uInt32_2, uInt32_3);
		smethod_3(out gstruct1_4, uint_5, uint_4, uint_3, 0u);
		ulong result = ((ulong)num << 32) | num2;
		smethod_122(ref gstruct1_4, int_);
		return result;
	}

	private static uint smethod_71(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, ref GStruct1 gstruct1_6)
	{
		int int_ = 32 - smethod_137(gstruct1_6.UInt32_3);
		smethod_85(out var gstruct1_7, ref gstruct1_6, int_);
		int uint_ = (int)smethod_85(out gstruct1_4, ref gstruct1_5, int_);
		uint uint_2 = gstruct1_4.UInt32_3;
		uint uint_3 = gstruct1_4.UInt32_2;
		uint uint_4 = gstruct1_4.UInt32_1;
		uint uint_5 = gstruct1_4.UInt32_0;
		uint result = smethod_77((uint)uint_, ref uint_2, ref uint_3, ref uint_4, ref uint_5, gstruct1_7.UInt32_3, gstruct1_7.UInt32_2, gstruct1_7.UInt32_1, gstruct1_7.UInt32_0);
		smethod_3(out gstruct1_4, uint_5, uint_4, uint_3, uint_2);
		smethod_122(ref gstruct1_4, int_);
		return result;
	}

	private static void smethod_72(out GStruct1 gstruct1_4, ref Struct3 struct3_0, ref GStruct1 gstruct1_5)
	{
		int int_ = 32 - smethod_137(gstruct1_5.UInt32_2);
		smethod_85(out var gstruct1_6, ref gstruct1_5, int_);
		uint uInt32_ = gstruct1_6.UInt32_2;
		uint uInt32_2 = gstruct1_6.UInt32_1;
		uint uInt32_3 = gstruct1_6.UInt32_0;
		smethod_86(out var struct3_1, ref struct3_0, int_);
		uint uInt32_4 = struct3_1.UInt32_6;
		uint uint_ = struct3_1.UInt32_5;
		uint uint_2 = struct3_1.UInt32_4;
		uint uint_3 = struct3_1.UInt32_3;
		uint uint_4 = struct3_1.UInt32_2;
		uint uint_5 = struct3_1.UInt32_1;
		uint uint_6 = struct3_1.UInt32_0;
		smethod_76(uInt32_4, ref uint_, ref uint_2, ref uint_3, uInt32_, uInt32_2, uInt32_3);
		smethod_76(uint_, ref uint_2, ref uint_3, ref uint_4, uInt32_, uInt32_2, uInt32_3);
		smethod_76(uint_2, ref uint_3, ref uint_4, ref uint_5, uInt32_, uInt32_2, uInt32_3);
		smethod_76(uint_3, ref uint_4, ref uint_5, ref uint_6, uInt32_, uInt32_2, uInt32_3);
		smethod_3(out gstruct1_4, uint_6, uint_5, uint_4, 0u);
		smethod_122(ref gstruct1_4, int_);
	}

	private static void smethod_73(out GStruct1 gstruct1_4, ref Struct3 struct3_0, ref GStruct1 gstruct1_5)
	{
		int int_ = 32 - smethod_137(gstruct1_5.UInt32_3);
		smethod_85(out var gstruct1_6, ref gstruct1_5, int_);
		uint uInt32_ = gstruct1_6.UInt32_3;
		uint uInt32_2 = gstruct1_6.UInt32_2;
		uint uInt32_3 = gstruct1_6.UInt32_1;
		uint uInt32_4 = gstruct1_6.UInt32_0;
		Struct3 struct3_1;
		int uint_ = (int)smethod_86(out struct3_1, ref struct3_0, int_);
		uint uint_2 = struct3_1.UInt32_7;
		uint uint_3 = struct3_1.UInt32_6;
		uint uint_4 = struct3_1.UInt32_5;
		uint uint_5 = struct3_1.UInt32_4;
		uint uint_6 = struct3_1.UInt32_3;
		uint uint_7 = struct3_1.UInt32_2;
		uint uint_8 = struct3_1.UInt32_1;
		uint uint_9 = struct3_1.UInt32_0;
		smethod_77((uint)uint_, ref uint_2, ref uint_3, ref uint_4, ref uint_5, uInt32_, uInt32_2, uInt32_3, uInt32_4);
		smethod_77(uint_2, ref uint_3, ref uint_4, ref uint_5, ref uint_6, uInt32_, uInt32_2, uInt32_3, uInt32_4);
		smethod_77(uint_3, ref uint_4, ref uint_5, ref uint_6, ref uint_7, uInt32_, uInt32_2, uInt32_3, uInt32_4);
		smethod_77(uint_4, ref uint_5, ref uint_6, ref uint_7, ref uint_8, uInt32_, uInt32_2, uInt32_3, uInt32_4);
		smethod_77(uint_5, ref uint_6, ref uint_7, ref uint_8, ref uint_9, uInt32_, uInt32_2, uInt32_3, uInt32_4);
		smethod_3(out gstruct1_4, uint_9, uint_8, uint_7, uint_6);
		smethod_122(ref gstruct1_4, int_);
	}

	private static ulong smethod_74(uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4)
	{
		ulong num = ((ulong)uint_0 << 32) | uint_1;
		ulong num2 = ((uint_0 == uint_3) ? uint.MaxValue : (num / uint_3));
		ulong num3 = num - num2 * uint_3;
		if (num3 == (uint)num3 && uint_4 * num2 > ((num3 << 32) | uint_2))
		{
			num2--;
			num3 += uint_3;
			if (num3 == (uint)num3 && uint_4 * num2 > ((num3 << 32) | uint_2))
			{
				num2--;
				num3 += uint_3;
			}
		}
		return num2;
	}

	private static uint smethod_75(uint uint_0, ref uint uint_1, ref uint uint_2, uint uint_3, uint uint_4)
	{
		ulong num = smethod_74(uint_0, uint_1, uint_2, uint_3, uint_4);
		ulong num2 = num * uint_4;
		long num3 = (long)uint_2 - (long)(uint)num2;
		num2 >>= 32;
		uint_2 = (uint)num3;
		num3 >>= 32;
		num2 += num * uint_3;
		num3 += (long)uint_1 - (long)(uint)num2;
		num2 >>= 32;
		uint_1 = (uint)num3;
		num3 >>= 32;
		num3 += (long)uint_0 - (long)(uint)num2;
		if (num3 != 0)
		{
			num--;
			num2 = (ulong)uint_2 + (ulong)uint_4;
			uint_2 = (uint)num2;
			num2 >>= 32;
			num2 += (ulong)((long)uint_1 + (long)uint_3);
			uint_1 = (uint)num2;
		}
		return (uint)num;
	}

	private static uint smethod_76(uint uint_0, ref uint uint_1, ref uint uint_2, ref uint uint_3, uint uint_4, uint uint_5, uint uint_6)
	{
		ulong num = smethod_74(uint_0, uint_1, uint_2, uint_4, uint_5);
		ulong num2 = num * uint_6;
		long num3 = (long)uint_3 - (long)(uint)num2;
		num2 >>= 32;
		uint_3 = (uint)num3;
		num3 >>= 32;
		num2 += num * uint_5;
		num3 += (long)uint_2 - (long)(uint)num2;
		num2 >>= 32;
		uint_2 = (uint)num3;
		num3 >>= 32;
		num2 += num * uint_4;
		num3 += (long)uint_1 - (long)(uint)num2;
		num2 >>= 32;
		uint_1 = (uint)num3;
		num3 >>= 32;
		num3 += (long)uint_0 - (long)(uint)num2;
		if (num3 != 0)
		{
			num--;
			num2 = (ulong)uint_3 + (ulong)uint_6;
			uint_3 = (uint)num2;
			num2 >>= 32;
			num2 += (ulong)((long)uint_2 + (long)uint_5);
			uint_2 = (uint)num2;
			num2 >>= 32;
			num2 += (ulong)((long)uint_1 + (long)uint_4);
			uint_1 = (uint)num2;
		}
		return (uint)num;
	}

	private static uint smethod_77(uint uint_0, ref uint uint_1, ref uint uint_2, ref uint uint_3, ref uint uint_4, uint uint_5, uint uint_6, uint uint_7, uint uint_8)
	{
		ulong num = smethod_74(uint_0, uint_1, uint_2, uint_5, uint_6);
		ulong num2 = num * uint_8;
		long num3 = (long)uint_4 - (long)(uint)num2;
		num2 >>= 32;
		uint_4 = (uint)num3;
		num3 >>= 32;
		num2 += num * uint_7;
		num3 += (long)uint_3 - (long)(uint)num2;
		num2 >>= 32;
		uint_3 = (uint)num3;
		num3 >>= 32;
		num2 += num * uint_6;
		num3 += (long)uint_2 - (long)(uint)num2;
		num2 >>= 32;
		uint_2 = (uint)num3;
		num3 >>= 32;
		num2 += num * uint_5;
		num3 += (long)uint_1 - (long)(uint)num2;
		num2 >>= 32;
		uint_1 = (uint)num3;
		num3 >>= 32;
		num3 += (long)uint_0 - (long)(uint)num2;
		if (num3 != 0)
		{
			num--;
			num2 = (ulong)uint_4 + (ulong)uint_8;
			uint_4 = (uint)num2;
			num2 >>= 32;
			num2 += (ulong)((long)uint_3 + (long)uint_7);
			uint_3 = (uint)num2;
			num2 >>= 32;
			num2 += (ulong)((long)uint_2 + (long)uint_6);
			uint_2 = (uint)num2;
			num2 >>= 32;
			num2 += (ulong)((long)uint_1 + (long)uint_5);
			uint_1 = (uint)num2;
		}
		return (uint)num;
	}

	public static void smethod_78(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, ref GStruct1 gstruct1_6, ref GStruct1 gstruct1_7)
	{
		smethod_34(out gstruct1_4, ref gstruct1_5, ref gstruct1_6);
		if (!smethod_16(ref gstruct1_4, ref gstruct1_7) || (smethod_16(ref gstruct1_4, ref gstruct1_5) && smethod_16(ref gstruct1_4, ref gstruct1_6)))
		{
			smethod_43(ref gstruct1_4, ref gstruct1_7);
		}
	}

	public static void smethod_79(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, ref GStruct1 gstruct1_6, ref GStruct1 gstruct1_7)
	{
		smethod_41(out gstruct1_4, ref gstruct1_5, ref gstruct1_6);
		if (smethod_16(ref gstruct1_5, ref gstruct1_6))
		{
			smethod_37(ref gstruct1_4, ref gstruct1_7);
		}
	}

	public static void smethod_80(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, ref GStruct1 gstruct1_6, ref GStruct1 gstruct1_7)
	{
		if (gstruct1_7.ulong_1 == 0)
		{
			smethod_47(out var gstruct1_8, gstruct1_5.ulong_0, gstruct1_6.ulong_0);
			smethod_6(out gstruct1_4, smethod_57(ref gstruct1_8, gstruct1_7.ulong_0));
		}
		else
		{
			smethod_22(out var struct3_, ref gstruct1_5, ref gstruct1_6);
			smethod_60(out gstruct1_4, ref struct3_, ref gstruct1_7);
		}
	}

	public static void smethod_81(ref GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, ref GStruct1 gstruct1_6)
	{
		if (gstruct1_6.ulong_1 == 0)
		{
			smethod_47(out var gstruct1_7, gstruct1_4.ulong_0, gstruct1_5.ulong_0);
			smethod_6(out gstruct1_4, smethod_57(ref gstruct1_7, gstruct1_6.ulong_0));
		}
		else
		{
			smethod_22(out var struct3_, ref gstruct1_4, ref gstruct1_5);
			smethod_60(out gstruct1_4, ref struct3_, ref gstruct1_6);
		}
	}

	public static void smethod_82(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, ref GStruct1 gstruct1_6, ref GStruct1 gstruct1_7)
	{
		gstruct1_4 = gstruct1_2;
		GStruct1 gstruct1_8 = gstruct1_5;
		ulong num = gstruct1_6.ulong_0;
		if (gstruct1_6.ulong_1 != 0)
		{
			for (int i = 0; i < 64; i++)
			{
				if ((num & 1) != 0)
				{
					smethod_81(ref gstruct1_4, ref gstruct1_8, ref gstruct1_7);
				}
				smethod_81(ref gstruct1_8, ref gstruct1_8, ref gstruct1_7);
				num >>= 1;
			}
			num = gstruct1_6.ulong_1;
		}
		while (num != 0)
		{
			if ((num & 1) != 0)
			{
				smethod_81(ref gstruct1_4, ref gstruct1_8, ref gstruct1_7);
			}
			if (num != 1)
			{
				smethod_81(ref gstruct1_8, ref gstruct1_8, ref gstruct1_7);
			}
			num >>= 1;
		}
	}

	public static void smethod_83(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, int int_0)
	{
		if (int_0 < 0)
		{
			smethod_89(out gstruct1_4, ref gstruct1_5, -int_0);
		}
		else
		{
			smethod_87(out gstruct1_4, ref gstruct1_5, int_0);
		}
	}

	public static void smethod_84(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, int int_0)
	{
		if (int_0 < 0)
		{
			smethod_91(out gstruct1_4, ref gstruct1_5, -int_0);
		}
		else
		{
			smethod_87(out gstruct1_4, ref gstruct1_5, int_0);
		}
	}

	public static ulong smethod_85(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, int int_0)
	{
		if (int_0 == 0)
		{
			gstruct1_4 = gstruct1_5;
			return 0uL;
		}
		int num = 64 - int_0;
		gstruct1_4.ulong_1 = (gstruct1_5.ulong_1 << int_0) | (gstruct1_5.ulong_0 >> num);
		gstruct1_4.ulong_0 = gstruct1_5.ulong_0 << int_0;
		return gstruct1_5.ulong_1 >> num;
	}

	private static ulong smethod_86(out Struct3 struct3_0, ref Struct3 struct3_1, int int_0)
	{
		if (int_0 == 0)
		{
			struct3_0 = struct3_1;
			return 0uL;
		}
		int num = 64 - int_0;
		struct3_0.ulong_3 = (struct3_1.ulong_3 << int_0) | (struct3_1.ulong_2 >> num);
		struct3_0.ulong_2 = (struct3_1.ulong_2 << int_0) | (struct3_1.ulong_1 >> num);
		struct3_0.ulong_1 = (struct3_1.ulong_1 << int_0) | (struct3_1.ulong_0 >> num);
		struct3_0.ulong_0 = struct3_1.ulong_0 << int_0;
		return struct3_1.ulong_3 >> num;
	}

	public static void smethod_87(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, int int_0)
	{
		if (int_0 < 64)
		{
			smethod_85(out gstruct1_4, ref gstruct1_5, int_0);
		}
		else if (int_0 == 64)
		{
			gstruct1_4.ulong_0 = 0uL;
			gstruct1_4.ulong_1 = gstruct1_5.ulong_0;
		}
		else
		{
			gstruct1_4.ulong_0 = 0uL;
			gstruct1_4.ulong_1 = gstruct1_5.ulong_0 << int_0 - 64;
		}
	}

	public static void smethod_88(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, int int_0)
	{
		if (int_0 == 0)
		{
			gstruct1_4 = gstruct1_5;
			return;
		}
		gstruct1_4.ulong_0 = (gstruct1_5.ulong_0 >> int_0) | (gstruct1_5.ulong_1 << 64 - int_0);
		gstruct1_4.ulong_1 = gstruct1_5.ulong_1 >> int_0;
	}

	public static void smethod_89(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, int int_0)
	{
		if (int_0 < 64)
		{
			smethod_88(out gstruct1_4, ref gstruct1_5, int_0);
		}
		else if (int_0 == 64)
		{
			gstruct1_4.ulong_0 = gstruct1_5.ulong_1;
			gstruct1_4.ulong_1 = 0uL;
		}
		else
		{
			gstruct1_4.ulong_0 = gstruct1_5.ulong_1 >> int_0 - 64;
			gstruct1_4.ulong_1 = 0uL;
		}
	}

	public static void smethod_90(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, int int_0)
	{
		if (int_0 == 0)
		{
			gstruct1_4 = gstruct1_5;
			return;
		}
		gstruct1_4.ulong_0 = (gstruct1_5.ulong_0 >> int_0) | (gstruct1_5.ulong_1 << 64 - int_0);
		gstruct1_4.ulong_1 = (ulong)((long)gstruct1_5.ulong_1 >> int_0);
	}

	public static void smethod_91(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, int int_0)
	{
		if (int_0 < 64)
		{
			smethod_90(out gstruct1_4, ref gstruct1_5, int_0);
		}
		else if (int_0 == 64)
		{
			gstruct1_4.ulong_0 = gstruct1_5.ulong_1;
			gstruct1_4.ulong_1 = (ulong)((long)gstruct1_5.ulong_1 >> 63);
		}
		else
		{
			gstruct1_4.ulong_0 = gstruct1_5.ulong_1 >> int_0 - 64;
			gstruct1_4.ulong_1 = (ulong)((long)gstruct1_5.ulong_1 >> 63);
		}
	}

	public static void smethod_92(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, ref GStruct1 gstruct1_6)
	{
		gstruct1_4.ulong_0 = gstruct1_5.ulong_0 & gstruct1_6.ulong_0;
		gstruct1_4.ulong_1 = gstruct1_5.ulong_1 & gstruct1_6.ulong_1;
	}

	public static void smethod_93(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, ref GStruct1 gstruct1_6)
	{
		gstruct1_4.ulong_0 = gstruct1_5.ulong_0 | gstruct1_6.ulong_0;
		gstruct1_4.ulong_1 = gstruct1_5.ulong_1 | gstruct1_6.ulong_1;
	}

	public static void smethod_94(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, ref GStruct1 gstruct1_6)
	{
		gstruct1_4.ulong_0 = gstruct1_5.ulong_0 ^ gstruct1_6.ulong_0;
		gstruct1_4.ulong_1 = gstruct1_5.ulong_1 ^ gstruct1_6.ulong_1;
	}

	public static void smethod_95(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5)
	{
		gstruct1_4.ulong_0 = ~gstruct1_5.ulong_0;
		gstruct1_4.ulong_1 = ~gstruct1_5.ulong_1;
	}

	public static void smethod_96(ref GStruct1 gstruct1_4)
	{
		ulong num = gstruct1_4.ulong_0;
		gstruct1_4.ulong_0 = 0 - num;
		gstruct1_4.ulong_1 = 0 - gstruct1_4.ulong_1;
		if (num != 0)
		{
			gstruct1_4.ulong_1--;
		}
	}

	public static void smethod_97(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5)
	{
		gstruct1_4.ulong_0 = 0 - gstruct1_5.ulong_0;
		gstruct1_4.ulong_1 = 0 - gstruct1_5.ulong_1;
		if (gstruct1_5.ulong_0 != 0)
		{
			gstruct1_4.ulong_1--;
		}
	}

	public static void smethod_98(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, uint uint_0)
	{
		gstruct1_4 = gstruct1_2;
		while ((uint_0 != 0) ? true : false)
		{
			if ((uint_0 & 1) != 0)
			{
				GStruct1 gstruct1_6 = gstruct1_4;
				smethod_21(out gstruct1_4, ref gstruct1_6, ref gstruct1_5);
			}
			if (uint_0 != 1)
			{
				GStruct1 gstruct1_7 = gstruct1_5;
				smethod_27(out gstruct1_5, ref gstruct1_7);
			}
			uint_0 >>= 1;
		}
	}

	public static GStruct1 smethod_99(GStruct1 gstruct1_4, uint uint_0)
	{
		smethod_98(out var gstruct1_5, ref gstruct1_4, uint_0);
		return gstruct1_5;
	}

	public static ulong smethod_100(GStruct1 gstruct1_4)
	{
		if (gstruct1_4.ulong_1 == 0L && gstruct1_4.ulong_0 <= 9007199254740992L)
		{
			return (ulong)Math.Sqrt(gstruct1_4.ulong_0);
		}
		ulong num = (ulong)Math.Sqrt(smethod_11(ref gstruct1_4));
		if (gstruct1_4.ulong_1 < gstruct1_3)
		{
			smethod_26(out var gstruct1_5, num);
			ulong num2 = gstruct1_4.ulong_0 - gstruct1_5.ulong_0;
			if (num2 > long.MaxValue)
			{
				num--;
			}
			else if (num2 - (num << 1) <= long.MaxValue)
			{
				num++;
			}
			return num;
		}
		return smethod_102(ref gstruct1_4, num);
	}

	public static ulong smethod_101(GStruct1 gstruct1_4)
	{
		if (gstruct1_4.ulong_1 == 0L && gstruct1_4.ulong_0 <= 9007199254740992L)
		{
			return (ulong)Math.Ceiling(Math.Sqrt(gstruct1_4.ulong_0));
		}
		ulong num = (ulong)Math.Ceiling(Math.Sqrt(smethod_11(ref gstruct1_4)));
		if (gstruct1_4.ulong_1 < gstruct1_3)
		{
			smethod_26(out var gstruct1_5, num);
			ulong num2 = gstruct1_5.ulong_0 - gstruct1_4.ulong_0;
			if (num2 > long.MaxValue)
			{
				num++;
			}
			else if (num2 - (num << 1) <= long.MaxValue)
			{
				num--;
			}
			return num;
		}
		num = smethod_102(ref gstruct1_4, num);
		smethod_26(out var gstruct1_6, num);
		if (gstruct1_6.UInt64_0 != gstruct1_4.UInt64_0 || gstruct1_6.UInt64_1 != gstruct1_4.UInt64_1)
		{
			num++;
		}
		return num;
	}

	private static ulong smethod_102(ref GStruct1 gstruct1_4, ulong ulong_2)
	{
		ulong num = 0uL;
		ulong num2;
		while (true)
		{
			smethod_54(out var gstruct1_5, ref gstruct1_4, ulong_2);
			smethod_33(out var gstruct1_6, ref gstruct1_5, ulong_2);
			num2 = gstruct1_6.UInt64_0 >> 1;
			if (gstruct1_6.UInt64_1 != 0)
			{
				num2 |= 0x8000000000000000uL;
			}
			if (num2 == num)
			{
				break;
			}
			num = ulong_2;
			ulong_2 = num2;
		}
		if (num2 < ulong_2)
		{
			ulong_2 = num2;
		}
		return ulong_2;
	}

	public static ulong smethod_103(GStruct1 gstruct1_4)
	{
		ulong num = (ulong)Math.Pow(smethod_11(ref gstruct1_4), 1.0 / 3.0);
		smethod_30(out var gstruct1_5, num);
		if (gstruct1_4 < gstruct1_5)
		{
			num--;
		}
		else
		{
			smethod_18(out var gstruct1_6, 3 * num, num + 1);
			smethod_41(out var gstruct1_7, ref gstruct1_4, ref gstruct1_5);
			if (smethod_16(ref gstruct1_6, ref gstruct1_7))
			{
				num++;
			}
		}
		return num;
	}

	public static ulong smethod_104(GStruct1 gstruct1_4)
	{
		ulong num = (ulong)Math.Ceiling(Math.Pow(smethod_11(ref gstruct1_4), 1.0 / 3.0));
		smethod_30(out var gstruct1_5, num);
		if (gstruct1_5 < gstruct1_4)
		{
			num++;
		}
		else
		{
			smethod_18(out var gstruct1_6, 3 * num, num + 1);
			smethod_41(out var gstruct1_7, ref gstruct1_5, ref gstruct1_4);
			if (smethod_16(ref gstruct1_6, ref gstruct1_7))
			{
				num--;
			}
		}
		return num;
	}

	public static GStruct1 smethod_105(GStruct1 gstruct1_4, GStruct1 gstruct1_5)
	{
		if (smethod_16(ref gstruct1_4, ref gstruct1_5))
		{
			return gstruct1_4;
		}
		return gstruct1_5;
	}

	public static GStruct1 smethod_106(GStruct1 gstruct1_4, GStruct1 gstruct1_5)
	{
		if (smethod_16(ref gstruct1_5, ref gstruct1_4))
		{
			return gstruct1_4;
		}
		return gstruct1_5;
	}

	public static double smethod_107(GStruct1 gstruct1_4)
	{
		return smethod_109(gstruct1_4, Math.E);
	}

	public static double smethod_108(GStruct1 gstruct1_4)
	{
		return smethod_109(gstruct1_4, 10.0);
	}

	public static double smethod_109(GStruct1 gstruct1_4, double double_0)
	{
		return Math.Log(smethod_11(ref gstruct1_4), double_0);
	}

	public static GStruct1 smethod_110(GStruct1 gstruct1_4, GStruct1 gstruct1_5)
	{
		smethod_34(out var gstruct1_6, ref gstruct1_4, ref gstruct1_5);
		return gstruct1_6;
	}

	public static GStruct1 smethod_111(GStruct1 gstruct1_4, GStruct1 gstruct1_5)
	{
		smethod_41(out var gstruct1_6, ref gstruct1_4, ref gstruct1_5);
		return gstruct1_6;
	}

	public static GStruct1 smethod_112(GStruct1 gstruct1_4, GStruct1 gstruct1_5)
	{
		smethod_21(out var gstruct1_6, ref gstruct1_4, ref gstruct1_5);
		return gstruct1_6;
	}

	public static GStruct1 smethod_113(GStruct1 gstruct1_4, GStruct1 gstruct1_5)
	{
		smethod_55(out var gstruct1_6, ref gstruct1_4, ref gstruct1_5);
		return gstruct1_6;
	}

	public static GStruct1 smethod_114(GStruct1 gstruct1_4, GStruct1 gstruct1_5)
	{
		smethod_58(out var gstruct1_6, ref gstruct1_4, ref gstruct1_5);
		return gstruct1_6;
	}

	public static GStruct1 smethod_115(GStruct1 gstruct1_4, GStruct1 gstruct1_5, out GStruct1 gstruct1_6)
	{
		smethod_55(out var gstruct1_7, ref gstruct1_4, ref gstruct1_5);
		smethod_58(out gstruct1_6, ref gstruct1_4, ref gstruct1_5);
		return gstruct1_7;
	}

	public static GStruct1 smethod_116(GStruct1 gstruct1_4, GStruct1 gstruct1_5, GStruct1 gstruct1_6)
	{
		smethod_78(out var gstruct1_7, ref gstruct1_4, ref gstruct1_5, ref gstruct1_6);
		return gstruct1_7;
	}

	public static GStruct1 smethod_117(GStruct1 gstruct1_4, GStruct1 gstruct1_5, GStruct1 gstruct1_6)
	{
		smethod_79(out var gstruct1_7, ref gstruct1_4, ref gstruct1_5, ref gstruct1_6);
		return gstruct1_7;
	}

	public static GStruct1 smethod_118(GStruct1 gstruct1_4, GStruct1 gstruct1_5, GStruct1 gstruct1_6)
	{
		smethod_80(out var gstruct1_7, ref gstruct1_4, ref gstruct1_5, ref gstruct1_6);
		return gstruct1_7;
	}

	public static GStruct1 smethod_119(GStruct1 gstruct1_4, GStruct1 gstruct1_5, GStruct1 gstruct1_6)
	{
		smethod_82(out var gstruct1_7, ref gstruct1_4, ref gstruct1_5, ref gstruct1_6);
		return gstruct1_7;
	}

	public static GStruct1 smethod_120(GStruct1 gstruct1_4)
	{
		smethod_97(out var gstruct1_5, ref gstruct1_4);
		return gstruct1_5;
	}

	public static GStruct1 smethod_121(GStruct1 gstruct1_4, GStruct1 gstruct1_5)
	{
		smethod_134(out var gstruct1_6, ref gstruct1_4, ref gstruct1_5);
		return gstruct1_6;
	}

	private static void smethod_122(ref GStruct1 gstruct1_4, int int_0)
	{
		if ((int_0 != 0) ? true : false)
		{
			gstruct1_4.ulong_0 = (gstruct1_4.ulong_1 << 64 - int_0) | (gstruct1_4.ulong_0 >> int_0);
			gstruct1_4.ulong_1 >>= int_0;
		}
	}

	public static void smethod_123(ref GStruct1 gstruct1_4, int int_0)
	{
		if (int_0 < 64)
		{
			smethod_122(ref gstruct1_4, int_0);
			return;
		}
		gstruct1_4.ulong_0 = gstruct1_4.ulong_1 >> int_0 - 64;
		gstruct1_4.ulong_1 = 0uL;
	}

	public static void smethod_124(ref GStruct1 gstruct1_4, int int_0)
	{
		if (int_0 < 0)
		{
			smethod_123(ref gstruct1_4, -int_0);
		}
		else
		{
			smethod_131(ref gstruct1_4, int_0);
		}
	}

	public static void smethod_125(ref GStruct1 gstruct1_4, int int_0)
	{
		if (int_0 < 0)
		{
			smethod_128(ref gstruct1_4, -int_0);
		}
		else
		{
			smethod_131(ref gstruct1_4, int_0);
		}
	}

	public static void smethod_126(ref GStruct1 gstruct1_4)
	{
		gstruct1_4.ulong_0 = (gstruct1_4.ulong_1 << 63) | (gstruct1_4.ulong_0 >> 1);
		gstruct1_4.ulong_1 >>= 1;
	}

	private static void smethod_127(ref GStruct1 gstruct1_4, int int_0)
	{
		if ((int_0 != 0) ? true : false)
		{
			gstruct1_4.ulong_0 = (gstruct1_4.ulong_1 << 64 - int_0) | (gstruct1_4.ulong_0 >> int_0);
			gstruct1_4.ulong_1 = (ulong)((long)gstruct1_4.ulong_1 >> int_0);
		}
	}

	public static void smethod_128(ref GStruct1 gstruct1_4, int int_0)
	{
		if (int_0 < 64)
		{
			smethod_127(ref gstruct1_4, int_0);
			return;
		}
		gstruct1_4.ulong_0 = (ulong)((long)gstruct1_4.ulong_1 >> int_0 - 64);
		gstruct1_4.ulong_1 = 0uL;
	}

	public static void smethod_129(ref GStruct1 gstruct1_4)
	{
		gstruct1_4.ulong_0 = (gstruct1_4.ulong_1 << 63) | (gstruct1_4.ulong_0 >> 1);
		gstruct1_4.ulong_1 = (ulong)((long)gstruct1_4.ulong_1 >> 1);
	}

	private static ulong smethod_130(ref GStruct1 gstruct1_4, int int_0)
	{
		if (int_0 == 0)
		{
			return 0uL;
		}
		int num = 64 - int_0;
		ulong result = gstruct1_4.ulong_1 >> num;
		gstruct1_4.ulong_1 = (gstruct1_4.ulong_1 << int_0) | (gstruct1_4.ulong_0 >> num);
		gstruct1_4.ulong_0 <<= int_0;
		return result;
	}

	public static void smethod_131(ref GStruct1 gstruct1_4, int int_0)
	{
		if (int_0 < 64)
		{
			smethod_130(ref gstruct1_4, int_0);
			return;
		}
		gstruct1_4.ulong_1 = gstruct1_4.ulong_0 << int_0 - 64;
		gstruct1_4.ulong_0 = 0uL;
	}

	public static void smethod_132(ref GStruct1 gstruct1_4)
	{
		gstruct1_4.ulong_1 = (gstruct1_4.ulong_1 << 1) | (gstruct1_4.ulong_0 >> 63);
		gstruct1_4.ulong_0 <<= 1;
	}

	public static void smethod_133(ref GStruct1 gstruct1_4, ref GStruct1 gstruct1_5)
	{
		ulong num = gstruct1_4.ulong_0;
		ulong num2 = gstruct1_4.ulong_1;
		gstruct1_4.ulong_0 = gstruct1_5.ulong_0;
		gstruct1_4.ulong_1 = gstruct1_5.ulong_1;
		gstruct1_5.ulong_0 = num;
		gstruct1_5.ulong_1 = num2;
	}

	public static void smethod_134(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, ref GStruct1 gstruct1_6)
	{
		GStruct1 gstruct1_7;
		GStruct1 gstruct1_8;
		if (gstruct1_5.ulong_1 == 0 != (gstruct1_6.ulong_1 == 0) && !gstruct1_5.Boolean_0 && !gstruct1_6.Boolean_0)
		{
			if (smethod_16(ref gstruct1_5, ref gstruct1_6))
			{
				gstruct1_7 = gstruct1_5;
				smethod_58(out gstruct1_8, ref gstruct1_6, ref gstruct1_5);
			}
			else
			{
				gstruct1_8 = gstruct1_6;
				smethod_58(out gstruct1_7, ref gstruct1_5, ref gstruct1_6);
			}
		}
		else
		{
			gstruct1_7 = gstruct1_5;
			gstruct1_8 = gstruct1_6;
		}
		if (gstruct1_7.Boolean_0)
		{
			gstruct1_4 = gstruct1_8;
			return;
		}
		if (gstruct1_8.Boolean_0)
		{
			gstruct1_4 = gstruct1_7;
			return;
		}
		if (smethod_16(ref gstruct1_7, ref gstruct1_8))
		{
			smethod_133(ref gstruct1_7, ref gstruct1_8);
		}
		while (gstruct1_7.ulong_1 != 0L && !gstruct1_6.Boolean_0)
		{
			int int_ = 63 - smethod_138(gstruct1_7.ulong_1);
			smethod_83(out var gstruct1_9, ref gstruct1_7, int_);
			smethod_83(out var gstruct1_10, ref gstruct1_8, int_);
			long num = (long)gstruct1_9.ulong_1;
			long num2 = (long)gstruct1_10.ulong_1;
			if (num2 == 0)
			{
				smethod_58(out var gstruct1_11, ref gstruct1_7, ref gstruct1_8);
				gstruct1_7 = gstruct1_8;
				gstruct1_8 = gstruct1_11;
				continue;
			}
			long num3 = 1L;
			long num4 = 0L;
			long num5 = 0L;
			long num6 = 1L;
			bool flag = true;
			while (true)
			{
				long num7 = num / num2;
				long num8 = num3 - num7 * num5;
				long num9 = num4 - num7 * num6;
				long num10 = num;
				num = num2;
				num2 = num10 - num7 * num2;
				if (flag = !flag)
				{
					if (num2 < -num8 || num - num2 < num9 - num6)
					{
						break;
					}
				}
				else if (num2 < -num9 || num - num2 < num8 - num5)
				{
					break;
				}
				num3 = num5;
				num4 = num6;
				num5 = num8;
				num6 = num9;
			}
			if (num3 == 1 && num4 == 0)
			{
				smethod_58(out var gstruct1_12, ref gstruct1_7, ref gstruct1_8);
				gstruct1_7 = gstruct1_8;
				gstruct1_8 = gstruct1_12;
				continue;
			}
			GStruct1 gstruct1_13;
			GStruct1 gstruct1_14;
			if (flag)
			{
				smethod_135(out gstruct1_13, num4, ref gstruct1_8, num3, ref gstruct1_7);
				smethod_135(out gstruct1_14, num5, ref gstruct1_7, num6, ref gstruct1_8);
			}
			else
			{
				smethod_135(out gstruct1_13, num3, ref gstruct1_7, num4, ref gstruct1_8);
				smethod_135(out gstruct1_14, num6, ref gstruct1_8, num5, ref gstruct1_7);
			}
			gstruct1_7 = gstruct1_13;
			gstruct1_8 = gstruct1_14;
		}
		if (!gstruct1_8.Boolean_0)
		{
			ulong num11 = gstruct1_7.ulong_0;
			ulong num12 = gstruct1_8.ulong_0;
			while (num11 > uint.MaxValue && num12 != 0)
			{
				ulong num13 = num11 % num12;
				num11 = num12;
				num12 = num13;
			}
			if (num12 != 0)
			{
				uint num14 = (uint)num11;
				uint num15 = (uint)num12;
				while ((num15 != 0) ? true : false)
				{
					uint num16 = num14 % num15;
					num14 = num15;
					num15 = num16;
				}
				smethod_5(out gstruct1_4, num14);
			}
			else
			{
				smethod_6(out gstruct1_4, num11);
			}
		}
		else
		{
			gstruct1_4 = gstruct1_7;
		}
	}

	private static void smethod_135(out GStruct1 gstruct1_4, long long_0, ref GStruct1 gstruct1_5, long long_1, ref GStruct1 gstruct1_6)
	{
		smethod_20(out var gstruct1_7, ref gstruct1_5, (ulong)long_0);
		smethod_20(out var gstruct1_8, ref gstruct1_6, (ulong)(-long_1));
		smethod_41(out gstruct1_4, ref gstruct1_7, ref gstruct1_8);
	}

	public static int smethod_136(GStruct1 gstruct1_4, GStruct1 gstruct1_5)
	{
		return gstruct1_4.CompareTo(gstruct1_5);
	}

	private static int smethod_137(uint uint_0)
	{
		uint num = uint_0 >> 16;
		if (num != 0)
		{
			uint num2 = num >> 8;
			if (num2 != 0)
			{
				return byte_0[num2] + 24;
			}
			return byte_0[num] + 16;
		}
		uint num3 = uint_0 >> 8;
		if (num3 != 0)
		{
			return byte_0[num3] + 8;
		}
		return byte_0[uint_0];
	}

	private static int smethod_138(ulong ulong_2)
	{
		ulong num = ulong_2 >> 32;
		if (num != 0)
		{
			return smethod_137((uint)num) + 32;
		}
		return smethod_137((uint)ulong_2);
	}

	public static void smethod_139(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, ref GStruct1 gstruct1_6, ref GStruct1 gstruct1_7, ulong ulong_2)
	{
		smethod_47(out var gstruct1_8, gstruct1_5.ulong_0, gstruct1_6.ulong_0);
		ulong num = gstruct1_8.ulong_0;
		smethod_48(out gstruct1_8, gstruct1_5.ulong_1, gstruct1_6.ulong_0, gstruct1_8.ulong_1);
		ulong ulong_3 = gstruct1_8.ulong_0;
		ulong ulong_4 = gstruct1_8.ulong_1;
		ulong ulong_5 = num * ulong_2;
		smethod_48(out gstruct1_8, ulong_5, gstruct1_7.ulong_1, smethod_49(ulong_5, gstruct1_7.ulong_0, num));
		smethod_36(ref gstruct1_8, ulong_3);
		num = gstruct1_8.ulong_0;
		smethod_32(out gstruct1_8, gstruct1_8.ulong_1, ulong_4);
		ulong_3 = gstruct1_8.ulong_0;
		ulong_4 = gstruct1_8.ulong_1;
		smethod_48(out gstruct1_8, gstruct1_5.ulong_0, gstruct1_6.ulong_1, num);
		num = gstruct1_8.ulong_0;
		smethod_48(out gstruct1_8, gstruct1_5.ulong_1, gstruct1_6.ulong_1, gstruct1_8.ulong_1);
		smethod_36(ref gstruct1_8, ulong_3);
		ulong_3 = gstruct1_8.ulong_0;
		smethod_32(out gstruct1_8, gstruct1_8.ulong_1, ulong_4);
		ulong_4 = gstruct1_8.ulong_0;
		ulong num2 = gstruct1_8.ulong_1;
		ulong_5 = num * ulong_2;
		smethod_48(out gstruct1_8, ulong_5, gstruct1_7.ulong_1, smethod_49(ulong_5, gstruct1_7.ulong_0, num));
		smethod_36(ref gstruct1_8, ulong_3);
		num = gstruct1_8.ulong_0;
		smethod_32(out gstruct1_8, gstruct1_8.ulong_1, ulong_4);
		ulong_3 = gstruct1_8.ulong_0;
		ulong_4 = num2 + gstruct1_8.ulong_1;
		smethod_4(out gstruct1_4, num, ulong_3);
		if (ulong_4 != 0L || !smethod_16(ref gstruct1_4, ref gstruct1_7))
		{
			smethod_43(ref gstruct1_4, ref gstruct1_7);
		}
	}

	public static void smethod_140(out GStruct1 gstruct1_4, ref GStruct1 gstruct1_5, ref GStruct1 gstruct1_6, ulong ulong_2)
	{
		ulong num = gstruct1_5.ulong_0;
		ulong num2 = gstruct1_5.ulong_1;
		ulong num3 = 0uL;
		for (int i = 0; i < 2; i++)
		{
			ulong ulong_3 = num * ulong_2;
			smethod_48(out var gstruct1_7, ulong_3, gstruct1_6.ulong_1, smethod_49(ulong_3, gstruct1_6.ulong_0, num));
			smethod_36(ref gstruct1_7, num2);
			num = gstruct1_7.ulong_0;
			smethod_32(out gstruct1_7, gstruct1_7.ulong_1, num3);
			num2 = gstruct1_7.ulong_0;
			num3 = gstruct1_7.ulong_1;
		}
		smethod_4(out gstruct1_4, num, num2);
		if (num3 != 0L || !smethod_16(ref gstruct1_4, ref gstruct1_6))
		{
			smethod_43(ref gstruct1_4, ref gstruct1_6);
		}
	}

	public static GStruct1 smethod_141(GStruct1 gstruct1_4, GStruct1 gstruct1_5, GStruct1 gstruct1_6, ulong ulong_2)
	{
		smethod_139(out var gstruct1_7, ref gstruct1_4, ref gstruct1_5, ref gstruct1_6, ulong_2);
		return gstruct1_7;
	}

	public static GStruct1 smethod_142(GStruct1 gstruct1_4, GStruct1 gstruct1_5, ulong ulong_2)
	{
		smethod_140(out var gstruct1_6, ref gstruct1_4, ref gstruct1_5, ulong_2);
		return gstruct1_6;
	}
}
