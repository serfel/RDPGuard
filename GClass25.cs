using System;
using System.Linq;
using System.Net;

public static class GClass25
{
	public static GStruct1 smethod_0(IPAddress ipaddress_0)
	{
		return smethod_1(ipaddress_0.GetAddressBytes().Reverse().ToArray());
	}

	public static GStruct1 smethod_1(byte[] byte_0)
	{
		uint uint_ = 0u;
		uint uint_2 = 0u;
		uint uint_3 = 0u;
		uint uint_4 = BitConverter.ToUInt32(byte_0, 0);
		if (byte_0.Length > 4)
		{
			uint_ = BitConverter.ToUInt32(byte_0, 4);
			uint_2 = BitConverter.ToUInt32(byte_0, 8);
			uint_3 = BitConverter.ToUInt32(byte_0, 12);
		}
		GStruct1.smethod_3(out var gstruct1_, uint_4, uint_, uint_2, uint_3);
		return gstruct1_;
	}

	public static uint smethod_2(IPAddress ipaddress_0)
	{
		return BitConverter.ToUInt32(ipaddress_0.GetAddressBytes().Reverse().ToArray(), 0);
	}

	public static IPAddress smethod_3(GStruct1 gstruct1_0, bool? nullable_0 = null)
	{
		bool flag = nullable_0.HasValue && nullable_0.Value;
		byte[] array;
		if (gstruct1_0.UInt64_1 == 0L && gstruct1_0.UInt64_0 <= uint.MaxValue && !flag)
		{
			array = new byte[4];
			Array.Copy(BitConverter.GetBytes((uint)gstruct1_0.UInt64_0), 0, array, 0, 4);
		}
		else
		{
			array = new byte[16];
			Array.Copy(BitConverter.GetBytes(gstruct1_0.UInt64_0), 0, array, 0, 8);
			Array.Copy(BitConverter.GetBytes(gstruct1_0.UInt64_1), 0, array, 8, 8);
		}
		if (BitConverter.IsLittleEndian)
		{
			Array.Reverse(array);
		}
		return new IPAddress(array);
	}

	public static IPAddress smethod_4(uint uint_0)
	{
		return new IPAddress(BitConverter.GetBytes(uint_0).Reverse().ToArray());
	}

	public static string smethod_5(GStruct1 gstruct1_0)
	{
		return smethod_3(gstruct1_0).ToString();
	}

	public static string smethod_6(uint uint_0)
	{
		return smethod_4(uint_0).ToString();
	}
}
