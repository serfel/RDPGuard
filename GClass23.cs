using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

public static class GClass23
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<NetworkInterface, UnicastIPAddressInformationCollection> _003C_003E9__10_0;

		public static Func<UnicastIPAddressInformationCollection, IEnumerable<UnicastIPAddressInformation>> _003C_003E9__10_1;

		public static Func<UnicastIPAddressInformation, bool> _003C_003E9__10_2;

		public static Func<UnicastIPAddressInformation, IPAddress> _003C_003E9__10_3;

		public static Func<IPAddress, GClass24> _003C_003E9__10_4;

		public static Func<NetworkInterface, bool> _003C_003E9__14_0;

		public static Func<NetworkInterface, UnicastIPAddressInformationCollection> _003C_003E9__14_1;

		public static Func<UnicastIPAddressInformationCollection, IEnumerable<UnicastIPAddressInformation>> _003C_003E9__14_2;

		public static Func<UnicastIPAddressInformation, bool> _003C_003E9__14_3;

		public static Func<UnicastIPAddressInformation, GClass24> _003C_003E9__14_4;

		internal UnicastIPAddressInformationCollection method_0(NetworkInterface networkInterface_0)
		{
			return networkInterface_0.GetIPProperties().UnicastAddresses;
		}

		internal IEnumerable<UnicastIPAddressInformation> method_1(UnicastIPAddressInformationCollection unicastIPAddressInformationCollection_0)
		{
			return unicastIPAddressInformationCollection_0;
		}

		internal bool method_2(UnicastIPAddressInformation unicastIPAddressInformation_0)
		{
			if (AddressFamily.InterNetwork != unicastIPAddressInformation_0.Address.AddressFamily)
			{
				return AddressFamily.InterNetworkV6 == unicastIPAddressInformation_0.Address.AddressFamily;
			}
			return true;
		}

		internal IPAddress method_3(UnicastIPAddressInformation unicastIPAddressInformation_0)
		{
			if (AddressFamily.InterNetwork != unicastIPAddressInformation_0.Address.AddressFamily)
			{
				return new IPAddress(unicastIPAddressInformation_0.Address.GetAddressBytes());
			}
			return unicastIPAddressInformation_0.Address;
		}

		internal GClass24 method_4(IPAddress ipaddress_0)
		{
			return new GClass24(ipaddress_0);
		}

		internal bool method_5(NetworkInterface networkInterface_0)
		{
			if (NetworkInterfaceType.Loopback != networkInterface_0.NetworkInterfaceType)
			{
				return OperationalStatus.Up == networkInterface_0.OperationalStatus;
			}
			return false;
		}

		internal UnicastIPAddressInformationCollection method_6(NetworkInterface networkInterface_0)
		{
			return networkInterface_0.GetIPProperties().UnicastAddresses;
		}

		internal IEnumerable<UnicastIPAddressInformation> InitializeComponent(UnicastIPAddressInformationCollection unicastIPAddressInformationCollection_0)
		{
			return unicastIPAddressInformationCollection_0;
		}

		internal bool method_8(UnicastIPAddressInformation unicastIPAddressInformation_0)
		{
			return AddressFamily.InterNetwork == unicastIPAddressInformation_0.Address.AddressFamily;
		}

		internal GClass24 method_9(UnicastIPAddressInformation unicastIPAddressInformation_0)
		{
			return new GClass24(unicastIPAddressInformation_0.Address);
		}

		internal GClass24 method_10(string string_0)
		{
			return GClass24.smethod_1(string_0);
		}

		internal GClass24 method_11(string string_0)
		{
			return GClass24.smethod_1(string_0);
		}
	}

	private sealed class Class205
	{
		public GClass24 gclass24_0;

		internal bool method_0(GClass24 gclass24_1)
		{
			return gclass24_1.method_1(gclass24_0);
		}
	}

	private sealed class Class206
	{
		public GClass24 gclass24_0;

		internal bool method_0(GClass24 gclass24_1)
		{
			return gclass24_1.method_1(gclass24_0);
		}
	}

	public static readonly GClass24[] gclass24_0 = new string[11]
	{
		"::ffff:0:0/96", "::ffff:0:0:0/96", "64:ff9b::/96", "100::/64", "2001::/32", "2001:20::/28", "2001:db8::/32", "2002::/16", "fc00::/7", "fe80::/10",
		"ff00::/8"
	}.Select(_003C_003Ec._003C_003E9.method_10).ToArray();

	public static readonly GClass24[] gclass24_1 = new string[16]
	{
		"0.0.0.0/8", "10.0.0.0/8", "100.64.0.0/10", "127.0.0.0/8", "169.254.0.0/16", "172.16.0.0/12", "192.0.0.0/24", "192.0.2.0/24", "192.88.99.0/24", "192.168.0.0/16",
		"198.18.0.0/15", "198.51.100.0/24", "203.0.113.0/24", "224.0.0.0/4", "240.0.0.0/4", "255.255.255.255/32"
	}.Select(_003C_003Ec._003C_003E9.method_11).ToArray();

	private static readonly object object_0 = new object();

	private static GClass24[] gclass24_2 = null;

	private static readonly object object_1 = new object();

	private static GClass24[] gclass24_3 = null;

	public static GClass24[] GClass24_0 => gclass24_1.Concat(gclass24_0).ToArray();

	public static GClass24[] GClass24_1
	{
		get
		{
			lock (object_1)
			{
				if (gclass24_3 == null)
				{
					NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
					Func<NetworkInterface, bool> predicate = _003C_003Ec._003C_003E9.method_5;
					IEnumerable<NetworkInterface> source = allNetworkInterfaces.Where(predicate);
					Func<NetworkInterface, UnicastIPAddressInformationCollection> selector = _003C_003Ec._003C_003E9.method_6;
					IEnumerable<UnicastIPAddressInformationCollection> source2 = source.Select(selector);
					Func<UnicastIPAddressInformationCollection, IEnumerable<UnicastIPAddressInformation>> selector2 = _003C_003Ec._003C_003E9.InitializeComponent;
					IEnumerable<UnicastIPAddressInformation> source3 = source2.SelectMany(selector2);
					Func<UnicastIPAddressInformation, bool> predicate2 = _003C_003Ec._003C_003E9.method_8;
					IEnumerable<UnicastIPAddressInformation> source4 = source3.Where(predicate2);
					Func<UnicastIPAddressInformation, GClass24> selector3 = _003C_003Ec._003C_003E9.method_9;
					gclass24_3 = source4.Select(selector3).ToArray();
				}
			}
			return gclass24_3;
		}
	}

	public static IPAddress IPAddress_0
	{
		get
		{
			IPAddress ipaddress_ = IPAddress.Parse("127.0.0.1");
			IPAddress ipaddress_2 = IPAddress.Parse("127.255.255.254");
			uint minValue = GClass25.smethod_2(ipaddress_);
			uint num = GClass25.smethod_2(ipaddress_2);
			return GClass25.smethod_4((uint)new Random().Next((int)minValue, (int)(num + 1)));
		}
	}

	public static bool smethod_0(GClass24 gclass24_4)
	{
		if (gclass24_4.Boolean_2)
		{
			return !smethod_1(gclass24_4);
		}
		return false;
	}

	public static bool smethod_1(GClass24 gclass24_4)
	{
		if (!gclass24_4.Boolean_0)
		{
			return smethod_3(gclass24_4);
		}
		return smethod_2(gclass24_4);
	}

	private static bool smethod_2(GClass24 gclass24_4)
	{
		Class205 @class = new Class205();
		@class.gclass24_0 = gclass24_4;
		return gclass24_0.Any(@class.method_0);
	}

	private static bool smethod_3(GClass24 gclass24_4)
	{
		Class206 @class = new Class206();
		@class.gclass24_0 = gclass24_4;
		return gclass24_1.Any(@class.method_0);
	}

	public static bool smethod_4(GClass24 gclass24_4)
	{
		lock (object_0)
		{
			if (gclass24_2 == null)
			{
				IPAddress[] first = new IPAddress[7]
				{
					IPAddress.Any,
					IPAddress.Broadcast,
					IPAddress.Loopback,
					IPAddress.None,
					IPAddress.IPv6Any,
					IPAddress.IPv6Loopback,
					IPAddress.IPv6None
				};
				NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
				Func<NetworkInterface, UnicastIPAddressInformationCollection> selector = _003C_003Ec._003C_003E9.method_0;
				IEnumerable<UnicastIPAddressInformationCollection> source = allNetworkInterfaces.Select(selector);
				Func<UnicastIPAddressInformationCollection, IEnumerable<UnicastIPAddressInformation>> selector2 = _003C_003Ec._003C_003E9.method_1;
				IEnumerable<UnicastIPAddressInformation> source2 = source.SelectMany(selector2);
				Func<UnicastIPAddressInformation, bool> predicate = _003C_003Ec._003C_003E9.method_2;
				IEnumerable<UnicastIPAddressInformation> source3 = source2.Where(predicate);
				Func<UnicastIPAddressInformation, IPAddress> selector3 = _003C_003Ec._003C_003E9.method_3;
				IEnumerable<IPAddress> source4 = first.Concat(source3.Select(selector3));
				Func<IPAddress, GClass24> selector4 = _003C_003Ec._003C_003E9.method_4;
				gclass24_2 = source4.Select(selector4).ToArray();
			}
			return gclass24_2.Contains(gclass24_4);
		}
	}
}
