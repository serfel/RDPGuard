using System;
using System.Linq;
using System.Text;

internal class Class88
{
	protected static readonly string string_0 = "\\\\.\\pipe\\rdpguard_ipc";

	protected static readonly byte byte_0 = 0;

	protected static readonly byte byte_1 = 1;

	protected static readonly byte byte_2 = 2;

	protected static readonly byte byte_3 = 3;

	protected static readonly byte byte_4 = 4;

	protected static readonly byte byte_5 = 5;

	protected static readonly byte byte_6 = 6;

	protected static readonly byte byte_7 = 7;

	protected static readonly byte byte_8 = 8;

	protected static readonly byte byte_9 = 9;

	protected static readonly byte byte_10 = 10;

	protected static readonly byte byte_11 = 11;

	protected static readonly byte byte_12 = 12;

	protected static readonly byte byte_13 = 13;

	protected static readonly byte byte_14 = 14;

	protected static readonly byte byte_15 = 21;

	protected static readonly byte byte_16 = 22;

	protected static readonly byte byte_17 = 23;

	protected static readonly byte byte_18 = 24;

	protected static readonly byte byte_19 = 25;

	protected static readonly byte byte_20 = 26;

	protected static readonly byte byte_21 = 30;

	protected static readonly byte byte_22 = 31;

	protected static readonly byte byte_23 = 32;

	protected static readonly byte byte_24 = 33;

	protected static readonly byte byte_25 = 34;

	protected static readonly byte byte_26 = 40;

	protected static readonly byte byte_27 = 41;

	protected static readonly byte byte_28 = 42;

	protected static readonly byte byte_29 = 43;

	protected static readonly byte byte_30 = 44;

	protected static readonly byte byte_31 = 50;

	protected static readonly byte byte_32 = 51;

	protected static readonly byte byte_33 = 52;

	protected static readonly byte byte_34 = 53;

	protected static readonly byte byte_35 = 54;

	protected static readonly byte byte_36 = 55;

	protected static readonly byte byte_37 = 56;

	protected static readonly byte byte_38 = 57;

	protected static readonly byte byte_39 = 58;

	protected static readonly byte byte_40 = 59;

	protected static readonly byte byte_41 = 60;

	protected static readonly byte byte_42 = 61;

	protected static readonly byte byte_43 = 62;

	protected static readonly byte byte_44 = 63;

	protected static readonly byte byte_45 = 64;

	protected static readonly byte byte_46 = 65;

	protected static readonly byte byte_47 = 66;

	protected static readonly byte byte_48 = 70;

	protected static readonly byte byte_49 = 71;

	protected static readonly byte byte_50 = 85;

	protected static readonly byte byte_51 = 86;

	protected static readonly byte byte_52 = 87;

	protected static readonly byte byte_53 = 88;

	protected static readonly byte byte_54 = 93;

	protected static readonly byte byte_55 = 94;

	protected static readonly byte byte_56 = 95;

	protected static readonly byte byte_57 = 96;

	protected static readonly byte byte_58 = 97;

	protected static readonly byte byte_59 = 98;

	protected static readonly byte byte_60 = 102;

	protected static readonly byte byte_61 = 110;

	protected static readonly byte byte_62 = 111;

	protected static readonly byte byte_63 = 120;

	protected static readonly byte byte_64 = 121;

	protected static readonly byte byte_65 = 122;

	protected static readonly byte byte_66 = 140;

	protected static readonly byte byte_67 = 150;

	protected static readonly byte byte_68 = 160;

	protected static readonly byte byte_69 = 161;

	protected static byte[] smethod_0(byte byte_70, string string_1)
	{
		if (string.IsNullOrEmpty(string_1))
		{
			return new byte[1] { byte_70 };
		}
		byte[] bytes = new UTF8Encoding().GetBytes(string_1);
		byte[] array = new byte[bytes.Length + 1];
		array[0] = byte_70;
		Array.Copy(bytes, 0, array, 1, bytes.Length);
		return array;
	}

	protected static bool smethod_1(byte[] byte_70, out byte byte_71, out string string_1)
	{
		byte_71 = byte_0;
		string_1 = string.Empty;
		if (byte_70 != null && byte_70.Length >= 1)
		{
			byte_71 = byte_70[0];
			string_1 = new UTF8Encoding().GetString(byte_70.Skip(1).ToArray());
			return true;
		}
		return false;
	}
}
