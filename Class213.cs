using System;
using System.Security.Cryptography;

internal sealed class Class213 : HashAlgorithm
{
	private class Class214
	{
		public readonly uint[] uint_0;

		public readonly uint[] uint_1;

		public readonly byte[] byte_0;

		public Class214()
		{
			uint_0 = new uint[4];
			uint_1 = new uint[2];
			byte_0 = new byte[64];
		}

		public void method_0()
		{
			Array.Clear(uint_0, 0, uint_0.Length);
			Array.Clear(uint_1, 0, uint_1.Length);
			Array.Clear(byte_0, 0, byte_0.Length);
		}
	}

	private readonly Class214 class214_0 = new Class214();

	private readonly byte[] byte_0 = new byte[16];

	private bool bool_0;

	private bool bool_1;

	private static readonly byte[] byte_1;

	public override byte[] Hash
	{
		get
		{
			if (!bool_0)
			{
				throw new NullReferenceException();
			}
			if (!bool_1)
			{
				throw new CryptographicException("Hash must be finalized before the hash value is retrieved.");
			}
			return byte_0;
		}
	}

	public override int HashSize => byte_0.Length * 8;

	public Class213()
	{
		method_0();
	}

	public override void Initialize()
	{
		method_0();
	}

	private void method_0()
	{
		smethod_9(class214_0);
		bool_0 = false;
		bool_1 = false;
	}

	protected override void HashCore(byte[] array, int ibStart, int cbSize)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (bool_1)
		{
			throw new CryptographicException("Hash not valid for use in specified state.");
		}
		bool_0 = true;
		smethod_10(class214_0, array, (uint)ibStart, (uint)cbSize);
	}

	protected override byte[] HashFinal()
	{
		bool_1 = true;
		smethod_11(byte_0, class214_0);
		return Hash;
	}

	static Class213()
	{
		byte_1 = new byte[64];
		byte_1[0] = 128;
	}

	private static uint smethod_0(uint uint_0, uint uint_1, uint uint_2)
	{
		return (uint_0 & uint_1) | (~uint_0 & uint_2);
	}

	private static uint smethod_1(uint uint_0, uint uint_1, uint uint_2)
	{
		return (uint_0 & uint_2) | (uint_1 & ~uint_2);
	}

	private static uint smethod_2(uint uint_0, uint uint_1, uint uint_2)
	{
		return uint_0 ^ uint_1 ^ uint_2;
	}

	private static uint smethod_3(uint uint_0, uint uint_1, uint uint_2)
	{
		return uint_1 ^ (uint_0 | ~uint_2);
	}

	private static uint smethod_4(uint uint_0, int int_0)
	{
		return (uint_0 << int_0) | (uint_0 >> 32 - int_0);
	}

	private static void smethod_5(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, int int_0, uint uint_5)
	{
		uint_0 += smethod_0(uint_1, uint_2, uint_3) + uint_4 + uint_5;
		uint_0 = smethod_4(uint_0, int_0);
		uint_0 += uint_1;
	}

	private static void smethod_6(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, int int_0, uint uint_5)
	{
		uint_0 += smethod_1(uint_1, uint_2, uint_3) + uint_4 + uint_5;
		uint_0 = smethod_4(uint_0, int_0);
		uint_0 += uint_1;
	}

	private static void smethod_7(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, int int_0, uint uint_5)
	{
		uint_0 += smethod_2(uint_1, uint_2, uint_3) + uint_4 + uint_5;
		uint_0 = smethod_4(uint_0, int_0);
		uint_0 += uint_1;
	}

	private static void smethod_8(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, int int_0, uint uint_5)
	{
		uint_0 += smethod_3(uint_1, uint_2, uint_3) + uint_4 + uint_5;
		uint_0 = smethod_4(uint_0, int_0);
		uint_0 += uint_1;
	}

	private static void smethod_9(Class214 class214_1)
	{
		uint[] uint_ = class214_1.uint_1;
		class214_1.uint_1[1] = 0u;
		uint_[0] = 0u;
		class214_1.uint_0[0] = 1732584193u;
		class214_1.uint_0[1] = 4023233417u;
		class214_1.uint_0[2] = 2562383102u;
		class214_1.uint_0[3] = 271733878u;
	}

	private static void smethod_10(Class214 class214_1, byte[] byte_2, uint uint_0, uint uint_1)
	{
		uint num = (class214_1.uint_1[0] >> 3) & 0x3F;
		if ((class214_1.uint_1[0] += uint_1 << 3) < uint_1 << 3)
		{
			class214_1.uint_1[1]++;
		}
		class214_1.uint_1[1] += uint_1 >> 29;
		uint num2 = 64 - num;
		uint num3 = 0u;
		if (uint_1 >= num2)
		{
			Buffer.BlockCopy(byte_2, (int)uint_0, class214_1.byte_0, (int)num, (int)num2);
			smethod_12(class214_1.uint_0, class214_1.byte_0, 0u);
			for (num3 = num2; num3 + 63 < uint_1; num3 += 64)
			{
				smethod_12(class214_1.uint_0, byte_2, uint_0 + num3);
			}
			num = 0u;
		}
		Buffer.BlockCopy(byte_2, (int)(uint_0 + num3), class214_1.byte_0, (int)num, (int)(uint_1 - num3));
	}

	private static void smethod_11(byte[] byte_2, Class214 class214_1)
	{
		byte[] byte_3 = new byte[8];
		smethod_13(byte_3, class214_1.uint_1, 8u);
		uint num = (class214_1.uint_1[0] >> 3) & 0x3F;
		uint uint_ = ((num < 56) ? (56 - num) : (120 - num));
		smethod_10(class214_1, byte_1, 0u, uint_);
		smethod_10(class214_1, byte_3, 0u, 8u);
		smethod_13(byte_2, class214_1.uint_0, 16u);
		class214_1.method_0();
	}

	private static void smethod_12(uint[] uint_0, byte[] byte_2, uint uint_1)
	{
		uint uint_2 = uint_0[0];
		uint uint_3 = uint_0[1];
		uint uint_4 = uint_0[2];
		uint uint_5 = uint_0[3];
		uint[] array = new uint[16];
		smethod_14(array, byte_2, uint_1, 64u);
		smethod_5(ref uint_2, uint_3, uint_4, uint_5, array[0], 7, 3614090360u);
		smethod_5(ref uint_5, uint_2, uint_3, uint_4, array[1], 12, 3905402710u);
		smethod_5(ref uint_4, uint_5, uint_2, uint_3, array[2], 17, 606105819u);
		smethod_5(ref uint_3, uint_4, uint_5, uint_2, array[3], 22, 3250441966u);
		smethod_5(ref uint_2, uint_3, uint_4, uint_5, array[4], 7, 4118548399u);
		smethod_5(ref uint_5, uint_2, uint_3, uint_4, array[5], 12, 1200080426u);
		smethod_5(ref uint_4, uint_5, uint_2, uint_3, array[6], 17, 2821735955u);
		smethod_5(ref uint_3, uint_4, uint_5, uint_2, array[7], 22, 4249261313u);
		smethod_5(ref uint_2, uint_3, uint_4, uint_5, array[8], 7, 1770035416u);
		smethod_5(ref uint_5, uint_2, uint_3, uint_4, array[9], 12, 2336552879u);
		smethod_5(ref uint_4, uint_5, uint_2, uint_3, array[10], 17, 4294925233u);
		smethod_5(ref uint_3, uint_4, uint_5, uint_2, array[11], 22, 2304563134u);
		smethod_5(ref uint_2, uint_3, uint_4, uint_5, array[12], 7, 1804603682u);
		smethod_5(ref uint_5, uint_2, uint_3, uint_4, array[13], 12, 4254626195u);
		smethod_5(ref uint_4, uint_5, uint_2, uint_3, array[14], 17, 2792965006u);
		smethod_5(ref uint_3, uint_4, uint_5, uint_2, array[15], 22, 1236535329u);
		smethod_6(ref uint_2, uint_3, uint_4, uint_5, array[1], 5, 4129170786u);
		smethod_6(ref uint_5, uint_2, uint_3, uint_4, array[6], 9, 3225465664u);
		smethod_6(ref uint_4, uint_5, uint_2, uint_3, array[11], 14, 643717713u);
		smethod_6(ref uint_3, uint_4, uint_5, uint_2, array[0], 20, 3921069994u);
		smethod_6(ref uint_2, uint_3, uint_4, uint_5, array[5], 5, 3593408605u);
		smethod_6(ref uint_5, uint_2, uint_3, uint_4, array[10], 9, 38016083u);
		smethod_6(ref uint_4, uint_5, uint_2, uint_3, array[15], 14, 3634488961u);
		smethod_6(ref uint_3, uint_4, uint_5, uint_2, array[4], 20, 3889429448u);
		smethod_6(ref uint_2, uint_3, uint_4, uint_5, array[9], 5, 568446438u);
		smethod_6(ref uint_5, uint_2, uint_3, uint_4, array[14], 9, 3275163606u);
		smethod_6(ref uint_4, uint_5, uint_2, uint_3, array[3], 14, 4107603335u);
		smethod_6(ref uint_3, uint_4, uint_5, uint_2, array[8], 20, 1163531501u);
		smethod_6(ref uint_2, uint_3, uint_4, uint_5, array[13], 5, 2850285829u);
		smethod_6(ref uint_5, uint_2, uint_3, uint_4, array[2], 9, 4243563512u);
		smethod_6(ref uint_4, uint_5, uint_2, uint_3, array[7], 14, 1735328473u);
		smethod_6(ref uint_3, uint_4, uint_5, uint_2, array[12], 20, 2368359562u);
		smethod_7(ref uint_2, uint_3, uint_4, uint_5, array[5], 4, 4294588738u);
		smethod_7(ref uint_5, uint_2, uint_3, uint_4, array[8], 11, 2272392833u);
		smethod_7(ref uint_4, uint_5, uint_2, uint_3, array[11], 16, 1839030562u);
		smethod_7(ref uint_3, uint_4, uint_5, uint_2, array[14], 23, 4259657740u);
		smethod_7(ref uint_2, uint_3, uint_4, uint_5, array[1], 4, 2763975236u);
		smethod_7(ref uint_5, uint_2, uint_3, uint_4, array[4], 11, 1272893353u);
		smethod_7(ref uint_4, uint_5, uint_2, uint_3, array[7], 16, 4139469664u);
		smethod_7(ref uint_3, uint_4, uint_5, uint_2, array[10], 23, 3200236656u);
		smethod_7(ref uint_2, uint_3, uint_4, uint_5, array[13], 4, 681279174u);
		smethod_7(ref uint_5, uint_2, uint_3, uint_4, array[0], 11, 3936430074u);
		smethod_7(ref uint_4, uint_5, uint_2, uint_3, array[3], 16, 3572445317u);
		smethod_7(ref uint_3, uint_4, uint_5, uint_2, array[6], 23, 76029189u);
		smethod_7(ref uint_2, uint_3, uint_4, uint_5, array[9], 4, 3654602809u);
		smethod_7(ref uint_5, uint_2, uint_3, uint_4, array[12], 11, 3873151461u);
		smethod_7(ref uint_4, uint_5, uint_2, uint_3, array[15], 16, 530742520u);
		smethod_7(ref uint_3, uint_4, uint_5, uint_2, array[2], 23, 3299628645u);
		smethod_8(ref uint_2, uint_3, uint_4, uint_5, array[0], 6, 4096336452u);
		smethod_8(ref uint_5, uint_2, uint_3, uint_4, array[7], 10, 1126891415u);
		smethod_8(ref uint_4, uint_5, uint_2, uint_3, array[14], 15, 2878612391u);
		smethod_8(ref uint_3, uint_4, uint_5, uint_2, array[5], 21, 4237533241u);
		smethod_8(ref uint_2, uint_3, uint_4, uint_5, array[12], 6, 1700485571u);
		smethod_8(ref uint_5, uint_2, uint_3, uint_4, array[3], 10, 2399980690u);
		smethod_8(ref uint_4, uint_5, uint_2, uint_3, array[10], 15, 4293915773u);
		smethod_8(ref uint_3, uint_4, uint_5, uint_2, array[1], 21, 2240044497u);
		smethod_8(ref uint_2, uint_3, uint_4, uint_5, array[8], 6, 1873313359u);
		smethod_8(ref uint_5, uint_2, uint_3, uint_4, array[15], 10, 4264355552u);
		smethod_8(ref uint_4, uint_5, uint_2, uint_3, array[6], 15, 2734768916u);
		smethod_8(ref uint_3, uint_4, uint_5, uint_2, array[13], 21, 1309151649u);
		smethod_8(ref uint_2, uint_3, uint_4, uint_5, array[4], 6, 4149444226u);
		smethod_8(ref uint_5, uint_2, uint_3, uint_4, array[11], 10, 3174756917u);
		smethod_8(ref uint_4, uint_5, uint_2, uint_3, array[2], 15, 718787259u);
		smethod_8(ref uint_3, uint_4, uint_5, uint_2, array[9], 21, 3951481745u);
		uint_0[0] += uint_2;
		uint_0[1] += uint_3;
		uint_0[2] += uint_4;
		uint_0[3] += uint_5;
		Array.Clear(array, 0, array.Length);
	}

	private static void smethod_13(byte[] byte_2, uint[] uint_0, uint uint_1)
	{
		uint num = 0u;
		for (uint num2 = 0u; num2 < uint_1; num2 += 4)
		{
			byte_2[num2] = (byte)(uint_0[num] & 0xFF);
			byte_2[num2 + 1] = (byte)((uint_0[num] >> 8) & 0xFF);
			byte_2[num2 + 2] = (byte)((uint_0[num] >> 16) & 0xFF);
			byte_2[num2 + 3] = (byte)((uint_0[num] >> 24) & 0xFF);
			num++;
		}
	}

	private static void smethod_14(uint[] uint_0, byte[] byte_2, uint uint_1, uint uint_2)
	{
		uint num = 0u;
		for (uint num2 = 0u; num2 < uint_2; num2 += 4)
		{
			uint_0[num] = (uint)(byte_2[uint_1 + num2] | (byte_2[uint_1 + num2 + 1] << 8) | (byte_2[uint_1 + num2 + 2] << 16) | (byte_2[uint_1 + num2 + 3] << 24));
			num++;
		}
	}
}
