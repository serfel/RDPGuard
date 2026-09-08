using System;
using System.IO;

internal sealed class Class229
{
	public sealed class Class230
	{
		private Class232 class232_0 = new Class232(32769);

		private Class231 class231_0;

		private Class228 class228_0;

		private int int_0 = -1;

		private int int_1 = -1;

		private bool bool_0;

		private int int_2;

		private long long_0;

		private long long_1;

		private bool bool_1;

		private int int_3;

		private bool bool_2;

		public Class230(Stream stream_0)
		{
			class231_0 = new Class231(stream_0);
		}

		public int method_0(byte[] byte_0, int int_4, int int_5)
		{
			if (int_5 != 0 && !bool_1)
			{
				int num = 0;
				while (num < int_5)
				{
					while (int_0 < 0 && !bool_1)
					{
						bool_1 = !method_1();
					}
					if (bool_1 ? true : false)
					{
						break;
					}
					int num2 = method_2(byte_0, int_4 + num, int_5 - num);
					if (num2 > 0)
					{
						num += num2;
					}
					else
					{
						int_0 = -1;
					}
				}
				return num;
			}
			return 0;
		}

		private bool method_1()
		{
			if (bool_0)
			{
				return false;
			}
			long_0 = class231_0.long_0;
			bool_0 = class231_0.method_0(1) > 0;
			int_0 = class231_0.method_0(3);
			if (int_0 == 2)
			{
				class231_0.method_1();
				int num = class231_0.method_0(16) ^ 0xFED4;
				int_2 = num;
				class228_0 = null;
				bool_2 = true;
			}
			else if (int_0 == 5)
			{
				Struct7[] struct7_ = Class224.struct7_0;
				Struct7[] struct7_2 = Class224.struct7_1;
				int_2 = 0;
				class228_0 = Class224.class228_0;
				bool_2 = false;
			}
			else if (int_0 == 6)
			{
				method_6(class231_0, out var struct7_3, out var struct7_4);
				int_2 = 0;
				class228_0 = Class224.smethod_4(struct7_3, struct7_4);
				bool_2 = false;
			}
			long_1 = class231_0.long_0;
			return true;
		}

		private int method_2(byte[] byte_0, int int_4, int int_5)
		{
			int num = int_4;
			if (int_0 == 2)
			{
				if (int_2 > 0)
				{
					int num2 = Math.Min(int_5, int_2);
					class231_0.method_2(byte_0, int_4, num2);
					class232_0.method_1(byte_0, int_4, num2);
					int_2 -= num2;
					int_5 -= num2;
					int_4 += num2;
				}
			}
			else if (!bool_2)
			{
				if (int_3 > 0)
				{
					method_3(byte_0, ref int_4, ref int_5);
				}
				if (int_5 > 0)
				{
					do
					{
						int num3 = smethod_0(class231_0, class228_0.class227_0);
						bool_2 = num3 == 256;
						if (bool_2 ? true : false)
						{
							break;
						}
						if (num3 < 256)
						{
							byte_0[int_4++] = (byte)num3;
							class232_0.method_0((byte)num3);
							int_5--;
						}
						else if (num3 <= 285)
						{
							int num4 = smethod_1(class231_0, num3);
							int num5 = smethod_2(class231_0, class228_0.class227_1);
							int_1 = num5;
							int_3 = num4;
							method_3(byte_0, ref int_4, ref int_5);
						}
					}
					while (int_5 > 0);
				}
			}
			long_1 = class231_0.long_0;
			return int_4 - num;
		}

		private void method_3(byte[] byte_0, ref int int_4, ref int int_5)
		{
			int num = Math.Min(int_3, int_5);
			byte[] array = class232_0.method_2(int_1, Math.Min(num, int_1));
			int_5 -= num;
			int_3 -= num;
			while (num > array.Length)
			{
				Array.Copy(array, 0, byte_0, int_4, array.Length);
				int_4 += array.Length;
				num -= array.Length;
				class232_0.method_1(array, 0, array.Length);
			}
			Array.Copy(array, 0, byte_0, int_4, num);
			int_4 += num;
			class232_0.method_1(array, 0, num);
		}

		public bool method_4(int int_4)
		{
			byte[] byte_ = new byte[1024];
			int num;
			while (int_4 > 0 && (num = method_0(byte_, 0, Math.Min(1024, int_4))) > 0)
			{
				int_4 -= num;
			}
			return int_4 <= 0;
		}

		public void method_5()
		{
			byte[] byte_ = new byte[1024];
			while (method_0(byte_, 0, 1024) > 0)
			{
			}
		}

		private static int smethod_0(Class231 class231_1, Class227 class227_0)
		{
			while (class227_0 != null && !class227_0.bool_0)
			{
				class227_0 = ((class231_1.method_0(1) > 0) ? class227_0.class227_1 : class227_0.class227_0);
			}
			return class227_0.ushort_0;
		}

		private static int smethod_1(Class231 class231_1, int int_4)
		{
			Class224.smethod_7(int_4, out var int_5, out var int_6);
			if (int_6 > 0)
			{
				return int_5 + class231_1.method_0(int_6);
			}
			return int_5;
		}

		private static int smethod_2(Class231 class231_1, Class227 class227_0)
		{
			int num = smethod_0(class231_1, class227_0);
			int num2 = Class224.int_3[num];
			int num3 = Class224.int_4[num];
			if (num3 > 0)
			{
				int num4 = class231_1.method_0(num3);
				return num2 + num4;
			}
			return num2;
		}

		private void method_6(Class231 class231_1, out Struct7[] struct7_0, out Struct7[] struct7_1)
		{
			int num = class231_1.method_0(5) + 257;
			int num2 = class231_1.method_0(5) + 1;
			int num3 = class231_1.method_0(4) + 4;
			int[] array = Class224.int_0;
			int[] array2 = new int[19];
			for (int i = 0; i < num3; i++)
			{
				array2[array[i]] = class231_1.method_0(3);
			}
			Class227 class227_ = Class224.smethod_5(Class224.smethod_2(array2));
			int[] array3 = smethod_3(class231_1, class227_, num + num2);
			struct7_0 = new Struct7[num];
			for (int j = 0; j < num; j++)
			{
				struct7_0[j].int_1 = array3[j];
			}
			Class224.smethod_3(struct7_0);
			struct7_1 = new Struct7[num2];
			for (int k = 0; k < num2; k++)
			{
				struct7_1[k].int_1 = array3[k + num];
			}
			Class224.smethod_3(struct7_1);
		}

		private static int[] smethod_3(Class231 class231_1, Class227 class227_0, int int_4)
		{
			int[] array = new int[int_4];
			for (int i = 0; i < int_4; i++)
			{
				int num = smethod_0(class231_1, class227_0);
				if (num < 16)
				{
					array[i] = num;
					continue;
				}
				switch (num)
				{
				case 16:
				{
					int num4 = class231_1.method_0(2) + 3;
					for (int j = 0; j < num4; j++)
					{
						array[i + j] = array[i - 1];
					}
					i += num4 - 1;
					break;
				}
				case 17:
				{
					int num3 = class231_1.method_0(3) + 3;
					i += num3 - 1;
					break;
				}
				case 18:
				{
					int num2 = class231_1.method_0(7) + 11;
					i += num2 - 1;
					break;
				}
				}
			}
			return array;
		}
	}

	private sealed class Class231
	{
		private uint uint_0;

		private int int_0;

		private int int_1;

		private Stream stream_0;

		internal long long_0;

		internal Class231(Stream stream_1)
		{
			stream_0 = stream_1;
		}

		internal int method_0(int int_2)
		{
			long_0 += int_2;
			for (int num = int_2 - (int_1 - int_0); num > 0; num -= 8)
			{
				uint_0 |= checked((uint)stream_0.ReadByte()) << int_1;
				int_1 += 8;
			}
			int result = (int)(uint_0 >> int_0) & ((1 << int_2) - 1);
			int_0 += int_2;
			if (int_1 == int_0)
			{
				int_0 = 0;
				int_1 = 0;
				uint_0 = 0u;
				return result;
			}
			if (int_0 >= 8)
			{
				uint_0 >>= int_0;
				int_1 -= int_0;
				int_0 = 0;
			}
			return result;
		}

		internal void method_1()
		{
			if (int_1 != int_0)
			{
				long_0 += int_1 - int_0;
			}
			int_0 = 0;
			int_1 = 0;
			uint_0 = 0u;
		}

		internal void method_2(byte[] byte_0, int int_2, int int_3)
		{
			int num = stream_0.Read(byte_0, int_2, int_3);
			long_0 += num << 3;
		}
	}

	private sealed class Class232
	{
		private byte[] byte_0;

		private int int_0;

		internal int int_1;

		internal long long_0;

		internal Class232(int int_2)
		{
			int_1 = int_2;
			byte_0 = new byte[int_2];
		}

		internal void method_0(byte byte_1)
		{
			byte_0[int_0++] = byte_1;
			if (int_0 >= int_1)
			{
				int_0 = 0;
			}
			long_0++;
		}

		internal void method_1(byte[] byte_1, int int_2, int int_3)
		{
			long_0 += int_3;
			if (int_3 >= int_1)
			{
				Array.Copy(byte_1, int_2, byte_0, 0, int_1);
				int_0 = 0;
			}
			else if (int_0 + int_3 > int_1)
			{
				int num = int_1 - int_0;
				int length = int_0 + int_3 - int_1;
				Array.Copy(byte_1, int_2, byte_0, int_0, num);
				Array.Copy(byte_1, int_2 + num, byte_0, 0, length);
				int_0 = length;
			}
			else
			{
				Array.Copy(byte_1, int_2, byte_0, int_0, int_3);
				int_0 += int_3;
				if (int_0 == int_1)
				{
					int_0 = 0;
				}
			}
		}

		internal byte[] method_2(int int_2, int int_3)
		{
			byte[] array = new byte[int_3];
			if (int_0 >= int_2)
			{
				Array.Copy(byte_0, int_0 - int_2, array, 0, int_3);
			}
			else
			{
				int num = int_2 - int_0;
				if (num < int_3)
				{
					Array.Copy(byte_0, int_1 - num, array, 0, num);
					Array.Copy(byte_0, 0, array, num, int_3 - num);
				}
				else
				{
					Array.Copy(byte_0, int_1 - num, array, 0, int_3);
				}
			}
			return array;
		}
	}

	public static void smethod_0(Stream stream_0, Stream stream_1)
	{
		byte[] array = new byte[81920];
		Class230 @class = new Class230(stream_0);
		while (true)
		{
			int num = @class.method_0(array, 0, array.Length);
			if (num > 0)
			{
				stream_1.Write(array, 0, num);
				continue;
			}
			break;
		}
	}
}
