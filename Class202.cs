using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Numerics;
using System.Runtime.CompilerServices;

internal sealed class Class202
{
	private sealed class Class203 : IEnumerable<Tuple<BigInteger, uint>>, IEnumerable, IEnumerator<Tuple<BigInteger, uint>>, IDisposable, IEnumerator
	{
		private int int_0;

		private Tuple<BigInteger, uint> tuple_0;

		private int int_1;

		private BigInteger bigInteger_0;

		public BigInteger bigInteger_1;

		private BigInteger bigInteger_2;

		public BigInteger bigInteger_3;

		private BigInteger bigInteger_4;

		private uint uint_0;

		Tuple<BigInteger, uint> IEnumerator<Tuple<BigInteger, uint>>.Current => tuple_0;

		object IEnumerator.Current => tuple_0;

		public Class203(int int_2)
		{
			int_0 = int_2;
			int_1 = Environment.CurrentManagedThreadId;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			uint num;
			switch (int_0)
			{
			default:
				return false;
			case 0:
				int_0 = -1;
				if (bigInteger_0 > bigInteger_2)
				{
					return false;
				}
				if (bigInteger_0 < 0L)
				{
					throw new ArgumentException();
				}
				bigInteger_2 += (BigInteger)1;
				bigInteger_4 = 1;
				uint_0 = 0u;
				goto IL_00d8;
			case 1:
				int_0 = -1;
				bigInteger_0 += bigInteger_4;
				goto IL_0147;
			case 2:
				{
					int_0 = -1;
					bigInteger_0 += bigInteger_4;
					break;
				}
				IL_00d8:
				if (!(bigInteger_0 + bigInteger_4 <= bigInteger_2))
				{
					break;
				}
				if ((bigInteger_0 & bigInteger_4) != 0L)
				{
					tuple_0 = new Tuple<BigInteger, uint>(bigInteger_0, uint_0);
					int_0 = 1;
					return true;
				}
				goto IL_0147;
				IL_0147:
				bigInteger_4 <<= 1;
				num = uint_0 + 1;
				uint_0 = num;
				goto IL_00d8;
			}
			do
			{
				if ((bigInteger_0 < bigInteger_2) ? true : false)
				{
					bigInteger_4 >>= 1;
					num = uint_0 - 1;
					uint_0 = num;
					continue;
				}
				return false;
			}
			while (!((bigInteger_2 & bigInteger_4) != 0L));
			tuple_0 = new Tuple<BigInteger, uint>(bigInteger_0, uint_0);
			int_0 = 2;
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			return MoveNext();
		}

		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		IEnumerator<Tuple<BigInteger, uint>> IEnumerable<Tuple<BigInteger, uint>>.GetEnumerator()
		{
			Class203 @class;
			if (int_0 == -2 && int_1 == Environment.CurrentManagedThreadId)
			{
				int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class203(0);
			}
			@class.bigInteger_0 = bigInteger_1;
			@class.bigInteger_2 = bigInteger_3;
			return @class;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<Tuple<BigInteger, uint>>)this).GetEnumerator();
		}
	}

	private sealed class Class204 : IEnumerable<Class202>, IEnumerable, IEnumerator<Class202>, IDisposable, IEnumerator
	{
		private int int_0;

		private Class202 class202_0;

		private int int_1;

		private IPAddress ipaddress_0;

		public IPAddress ipaddress_1;

		private IPAddress ipaddress_2;

		public IPAddress ipaddress_3;

		private AddressFamily addressFamily_0;

		private uint uint_0;

		private IEnumerator<Tuple<BigInteger, uint>> ienumerator_0;

		Class202 IEnumerator<Class202>.Current => class202_0;

		object IEnumerator.Current => class202_0;

		public Class204(int int_2)
		{
			int_0 = int_2;
			int_1 = Environment.CurrentManagedThreadId;
		}

		void IDisposable.Dispose()
		{
			int num = int_0;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					method_0();
				}
			}
		}

		private bool MoveNext()
		{
			try
			{
				switch (int_0)
				{
				default:
					return false;
				case 1:
					int_0 = -3;
					break;
				case 0:
					int_0 = -1;
					if (ipaddress_0.AddressFamily != ipaddress_2.AddressFamily)
					{
						throw new ArgumentException("AddressFamilies don't match");
					}
					addressFamily_0 = ipaddress_0.AddressFamily;
					uint_0 = smethod_0(addressFamily_0);
					ienumerator_0 = smethod_4(smethod_1(ipaddress_0), smethod_1(ipaddress_2)).GetEnumerator();
					int_0 = -3;
					break;
				}
				if (!ienumerator_0.MoveNext())
				{
					method_0();
					ienumerator_0 = null;
					return false;
				}
				Tuple<BigInteger, uint> current = ienumerator_0.Current;
				class202_0 = new Class202(smethod_3(current.Item1, addressFamily_0), uint_0 - current.Item2);
				int_0 = 1;
				return true;
			}
			catch
			{
				((IDisposable)this).Dispose();
				throw;
			}
		}

		bool IEnumerator.MoveNext()
		{
			return MoveNext();
		}

		private void method_0()
		{
			int_0 = -1;
			if (ienumerator_0 != null)
			{
				ienumerator_0.Dispose();
			}
		}

		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		IEnumerator<Class202> IEnumerable<Class202>.GetEnumerator()
		{
			Class204 @class;
			if (int_0 == -2 && int_1 == Environment.CurrentManagedThreadId)
			{
				int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class204(0);
			}
			@class.ipaddress_0 = ipaddress_1;
			@class.ipaddress_2 = ipaddress_3;
			return @class;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<Class202>)this).GetEnumerator();
		}
	}

	private IPAddress ipaddress_0;

	private uint uint_0;

	private uint uint_1;

	public IPAddress IPAddress_0
	{
		get
		{
			return ipaddress_0;
		}
		private set
		{
			ipaddress_0 = value;
		}
	}

	public uint UInt32_0
	{
		get
		{
			return uint_0;
		}
		private set
		{
			uint_0 = value;
		}
	}

	public uint UInt32_1
	{
		get
		{
			return uint_1;
		}
		private set
		{
			uint_1 = value;
		}
	}

	public override string ToString()
	{
		return $"{IPAddress_0}/{UInt32_0}";
	}

	public Class202(IPAddress ipaddress_1, uint uint_2)
	{
		IPAddress_0 = ipaddress_1;
		UInt32_0 = uint_2;
		UInt32_1 = smethod_0(ipaddress_1.AddressFamily);
		if (uint_2 > UInt32_1)
		{
			throw new ArgumentException($"Invalid network length {uint_2} for {ipaddress_1.AddressFamily}");
		}
	}

	private static uint smethod_0(AddressFamily addressFamily_0)
	{
		if (AddressFamily.InterNetwork == addressFamily_0)
		{
			return 32u;
		}
		if (AddressFamily.InterNetworkV6 != addressFamily_0)
		{
			throw new ArgumentException($"Invalid address family {addressFamily_0}");
		}
		return 128u;
	}

	private static BigInteger smethod_1(IPAddress ipaddress_1)
	{
		byte[] addressBytes = ipaddress_1.GetAddressBytes();
		byte[] array = new byte[addressBytes.Length + 1];
		for (int i = 0; i < addressBytes.Length; i++)
		{
			array[i] = addressBytes[addressBytes.Length - 1 - i];
		}
		array[addressBytes.Length] = 0;
		return new BigInteger(array);
	}

	private static byte[] smethod_2(BigInteger bigInteger_0, uint uint_2)
	{
		if (bigInteger_0.Sign < 0)
		{
			throw new ArgumentException("argument must be >= 0");
		}
		byte[] array = bigInteger_0.ToByteArray();
		byte[] array2 = new byte[uint_2];
		for (int i = 0; i < uint_2 && i < array.Length; i++)
		{
			array2[uint_2 - 1 - i] = array[i];
		}
		for (uint num = uint_2; num < array.Length; num++)
		{
			if (array[num] != 0)
			{
				throw new ArgumentException("argument doesn't fit in requested number of bytes");
			}
		}
		return array2;
	}

	private static IPAddress smethod_3(BigInteger bigInteger_0, AddressFamily addressFamily_0)
	{
		if (AddressFamily.InterNetwork == addressFamily_0)
		{
			return new IPAddress(smethod_2(bigInteger_0, 4u));
		}
		if (AddressFamily.InterNetworkV6 != addressFamily_0)
		{
			throw new ArgumentException($"Invalid address family {addressFamily_0}");
		}
		return new IPAddress(smethod_2(bigInteger_0, 16u));
	}

	[IteratorStateMachine(typeof(Class203))]
	private static IEnumerable<Tuple<BigInteger, uint>> smethod_4(BigInteger bigInteger_0, BigInteger bigInteger_1)
	{
		return new Class203(-2)
		{
			bigInteger_1 = bigInteger_0,
			bigInteger_3 = bigInteger_1
		};
	}

	[IteratorStateMachine(typeof(Class204))]
	public static IEnumerable<Class202> smethod_5(IPAddress ipaddress_1, IPAddress ipaddress_2)
	{
		return new Class204(-2)
		{
			ipaddress_1 = ipaddress_1,
			ipaddress_3 = ipaddress_2
		};
	}
}
