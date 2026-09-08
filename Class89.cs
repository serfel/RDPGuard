using System;
using System.Threading;
using rdpguard.lib;

internal sealed class Class89 : Class88
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static ThreadStart _003C_003E9__37_0;

		internal void method_0()
		{
			while (true)
			{
				smethod_3();
				Thread.Sleep(100);
			}
		}
	}

	public static EventHandler<EventArgs> eventHandler_0 = null;

	public static EventHandler<EventArgs12> eventHandler_1 = null;

	public static EventHandler<EventArgs14> eventHandler_2 = null;

	public static EventHandler<EventArgs8> eventHandler_3 = null;

	public static EventHandler<EventArgs9> eventHandler_4 = null;

	public static EventHandler<EventArgs10> eventHandler_5 = null;

	public static EventHandler<EventArgs11> eventHandler_6 = null;

	public static EventHandler<EventArgs11> eventHandler_7 = null;

	public static EventHandler<EventArgs11> eventHandler_8 = null;

	public static EventHandler<EventArgs11> eventHandler_9 = null;

	public static EventHandler<EventArgs11> eventHandler_10 = null;

	public static EventHandler<EventArgs11> eventHandler_11 = null;

	public static EventHandler<EventArgs13> eventHandler_12 = null;

	public static EventHandler<EventArgs13> eventHandler_13 = null;

	public static EventHandler<EventArgs1> eventHandler_14 = null;

	public static EventHandler<EventArgs1> eventHandler_15 = null;

	public static EventHandler<EventArgs1> eventHandler_16 = null;

	public static EventHandler eventHandler_17 = null;

	public static EventHandler<EventArgs7> eventHandler_18 = null;

	public static EventHandler<EventArgs7> eventHandler_19 = null;

	public static EventHandler<EventArgs7> eventHandler_20 = null;

	public static EventHandler<EventArgs7> eventHandler_21 = null;

	public static EventHandler<EventArgs6> eventHandler_22 = null;

	public static EventHandler<EventArgs4> eventHandler_23 = null;

	public static EventHandler<EventArgs4> eventHandler_24 = null;

	public static EventHandler<EventArgs2> eventHandler_25 = null;

	public static EventHandler<EventArgs2> eventHandler_26 = null;

	public static EventHandler<EventArgs3> eventHandler_27 = null;

	public static EventHandler<EventArgs0> eventHandler_28 = null;

	public static EventHandler<EventArgs> eventHandler_29 = null;

	public static EventHandler<EventArgs5> eventHandler_30 = null;

	private static Class180 class180_0 = null;

	public static bool bool_0 = false;

	private static bool bool_1 = false;

	private static readonly object object_0 = new object();

	public static bool Boolean_0
	{
		get
		{
			if (class180_0 != null)
			{
				return class180_0.Boolean_0;
			}
			return false;
		}
	}

	public static void smethod_2()
	{
		lock (object_0)
		{
			if (!bool_1)
			{
				ThreadStart start = _003C_003Ec._003C_003E9.method_0;
				Thread thread = new Thread(start);
				thread.IsBackground = true;
				thread.Start();
				bool_1 = true;
			}
		}
	}

	private static void smethod_3()
	{
		try
		{
			if (class180_0 == null)
			{
				class180_0 = new Class180();
				class180_0.Event_0 += smethod_4;
			}
			if (!class180_0.Boolean_0)
			{
				class180_0.method_0(Class88.string_0);
				if (class180_0.Boolean_0)
				{
					eventHandler_0?.Invoke(null, EventArgs.Empty);
				}
			}
		}
		catch (Exception arg)
		{
			smethod_5($"IPCClient::CheckConnection::{arg}");
			if (bool_0)
			{
				throw;
			}
		}
	}

	private static void smethod_4(byte[] byte_70)
	{
		try
		{
			if (!Class88.smethod_1(byte_70, out var byte_71, out var string_))
			{
				smethod_5("IPCClient::MessageReceived::empty");
			}
			else if (byte_71 == Class88.byte_2)
			{
				eventHandler_6?.Invoke(null, new EventArgs11(string_));
			}
			else if (byte_71 == Class88.byte_4)
			{
				eventHandler_11?.Invoke(null, new EventArgs11(string_));
			}
			else if (byte_71 == Class88.byte_6)
			{
				eventHandler_7?.Invoke(null, new EventArgs11(string_));
			}
			else if (byte_71 == Class88.byte_8)
			{
				eventHandler_8?.Invoke(null, new EventArgs11(string_));
			}
			else if (byte_71 == Class88.byte_10)
			{
				eventHandler_9?.Invoke(null, new EventArgs11(string_));
			}
			else if (Class88.byte_13 == byte_71)
			{
				eventHandler_10?.Invoke(null, new EventArgs11(string_));
			}
			else if (byte_71 == Class88.byte_16)
			{
				eventHandler_2?.Invoke(null, EventArgs14.smethod_0(string_));
			}
			else if (byte_71 == Class88.byte_28)
			{
				eventHandler_12?.Invoke(null, new EventArgs13(string_));
			}
			else if (byte_71 == Class88.byte_29)
			{
				eventHandler_13?.Invoke(null, new EventArgs13());
			}
			else if (byte_71 == Class88.byte_34)
			{
				eventHandler_18?.Invoke(null, EventArgs7.smethod_0(string_));
			}
			else if (byte_71 == Class88.byte_33)
			{
				eventHandler_19?.Invoke(null, new EventArgs7());
			}
			else if (byte_71 == Class88.byte_39)
			{
				eventHandler_20?.Invoke(null, EventArgs7.smethod_0(string_));
			}
			else if (byte_71 == Class88.byte_38)
			{
				eventHandler_21?.Invoke(null, new EventArgs7());
			}
			else if (byte_71 == Class88.byte_18)
			{
				eventHandler_14?.Invoke(null, EventArgs1.smethod_0(string_));
			}
			else if (byte_71 == Class88.byte_44)
			{
				eventHandler_15?.Invoke(null, EventArgs1.smethod_0(string_));
			}
			else if (byte_71 == Class88.byte_45)
			{
				eventHandler_16?.Invoke(null, EventArgs1.smethod_0(string_));
			}
			else if (byte_71 == Class88.byte_25)
			{
				eventHandler_3?.Invoke(null, new EventArgs8(string_));
			}
			else if (byte_71 == Class88.byte_23)
			{
				eventHandler_4?.Invoke(null, new EventArgs9(string_));
			}
			else if (byte_71 == Class88.byte_24)
			{
				eventHandler_5?.Invoke(null, new EventArgs10(string_));
			}
			else if (byte_71 == Class88.byte_19)
			{
				eventHandler_1?.Invoke(null, EventArgs12.smethod_0(string_));
			}
			else if (byte_71 == Class88.byte_49)
			{
				eventHandler_22?.Invoke(null, EventArgs6.smethod_0(string_));
			}
			else if (byte_71 == Class88.byte_51)
			{
				eventHandler_23?.Invoke(null, EventArgs4.smethod_0(string_));
			}
			else if (byte_71 == Class88.byte_53)
			{
				eventHandler_24?.Invoke(null, new EventArgs4());
			}
			else if (byte_71 == Class88.byte_57)
			{
				eventHandler_25?.Invoke(null, EventArgs2.smethod_0(string_));
			}
			else if (byte_71 == Class88.byte_56)
			{
				eventHandler_26?.Invoke(null, new EventArgs2());
			}
			else if (byte_71 == Class88.byte_59)
			{
				eventHandler_27?.Invoke(null, new EventArgs3(string_));
			}
			else if (byte_71 == Class88.byte_64)
			{
				eventHandler_28?.Invoke(null, new EventArgs0(string_));
			}
			else if (byte_71 == Class88.byte_47)
			{
				eventHandler_17?.Invoke(null, EventArgs.Empty);
			}
			else if (byte_71 == Class88.byte_30)
			{
				eventHandler_29?.Invoke(null, EventArgs.Empty);
			}
			else if (byte_71 == Class88.byte_69)
			{
				eventHandler_30?.Invoke(null, EventArgs5.smethod_0(string_));
			}
			else
			{
				smethod_5("IPCClient::MessageReceived::unk_msg_type::" + byte_71 + string_);
			}
		}
		catch (Exception arg)
		{
			smethod_5($"IPCClient::MessageReceived::{arg}");
			if (bool_0)
			{
				throw;
			}
		}
	}

	private static void smethod_5(string string_1)
	{
		eventHandler_1?.Invoke(null, new EventArgs12(new Class157(GEnum12.const_2, string_1)));
	}

	private static void smethod_6(byte byte_70)
	{
		smethod_7(byte_70, null);
	}

	private static void smethod_7(byte byte_70, string string_1)
	{
		try
		{
			if (!bool_1)
			{
				smethod_2();
			}
			if (!Boolean_0)
			{
				smethod_3();
			}
			class180_0.method_2(Class88.smethod_0(byte_70, string_1));
		}
		catch (Exception arg)
		{
			smethod_5($"IPCClient::SendMessage::{arg}");
			if (bool_0)
			{
				throw;
			}
		}
	}

	public static void smethod_8()
	{
		smethod_6(Class88.byte_1);
	}

	public static void smethod_9()
	{
		smethod_6(Class88.byte_17);
	}

	public static void smethod_10()
	{
		smethod_6(Class88.byte_3);
	}

	public static void smethod_11(string string_1)
	{
		smethod_7(Class88.byte_5, string_1);
	}

	public static void smethod_12(GClass31 gclass31_0)
	{
		smethod_7(Class88.byte_7, gclass31_0.Serialize(int.MaxValue));
	}

	public static void smethod_13()
	{
		smethod_6(Class88.byte_9);
	}

	public static void smethod_14()
	{
		smethod_6(Class88.byte_12);
	}

	public static void smethod_15()
	{
		smethod_6(Class88.byte_14);
	}

	public static void smethod_16()
	{
		smethod_6(Class88.byte_15);
	}

	public static void smethod_17()
	{
		smethod_6(Class88.byte_26);
	}

	public static void smethod_18(Class164 class164_0)
	{
		smethod_7(Class88.byte_27, class164_0.method_2());
	}

	public static void smethod_19(string string_1)
	{
		smethod_7(Class88.byte_19, new EventArgs12(new Class157(GEnum12.const_2, string_1)).method_0());
	}

	public static void smethod_20(string string_1)
	{
		smethod_7(Class88.byte_19, new EventArgs12(new Class157(GEnum12.const_3, string_1)).method_0());
	}

	public static void smethod_21()
	{
		smethod_6(Class88.byte_21);
	}

	public static void smethod_22(Class141 class141_0)
	{
		smethod_7(Class88.byte_22, class141_0.method_0());
	}

	public static void smethod_23()
	{
		smethod_6(Class88.byte_31);
	}

	public static void smethod_24(IPListEntry[] iplistEntry_0)
	{
		smethod_7(Class88.byte_32, new EventArgs7(iplistEntry_0).method_0());
	}

	public static void smethod_25(GClass24 gclass24_0)
	{
		smethod_7(Class88.byte_35, gclass24_0.method_4());
	}

	public static void smethod_26()
	{
		smethod_6(Class88.byte_36);
	}

	public static void smethod_27(IPListEntry[] iplistEntry_0)
	{
		smethod_7(Class88.byte_37, new EventArgs7(iplistEntry_0).method_0());
	}

	public static void smethod_28(GClass24 gclass24_0)
	{
		smethod_7(Class88.byte_40, gclass24_0.method_4());
	}

	public static void smethod_29(Class90[] class90_0)
	{
		smethod_7(Class88.byte_42, new EventArgs1(class90_0).method_0());
	}

	public static void smethod_30(GEnum16 genum16_0)
	{
		smethod_7(Class88.byte_43, new EventArgs15(genum16_0).method_0());
	}

	public static void smethod_31()
	{
		smethod_6(Class88.byte_48);
	}

	public static void smethod_32()
	{
		smethod_6(Class88.byte_50);
	}

	public static void smethod_33(Class109[] class109_0)
	{
		smethod_7(Class88.byte_52, new EventArgs4(class109_0).method_0());
	}

	public static void smethod_34()
	{
		smethod_6(Class88.byte_54);
	}

	public static void smethod_35(Class94[] class94_0)
	{
		smethod_7(Class88.byte_55, new EventArgs2(class94_0).method_0());
	}

	public static void smethod_36(Class94 class94_0)
	{
		smethod_7(Class88.byte_58, class94_0.method_0());
	}

	public static void smethod_37()
	{
		smethod_6(Class88.byte_60);
	}

	public static void smethod_38()
	{
		smethod_6(Class88.byte_20);
	}

	public static void smethod_39(GeoIPDBVersion geoIPDBVersion_0)
	{
		smethod_7(Class88.byte_63, new GClass29
		{
			genum1_0 = GEnum1.const_0,
			version_1 = Class183.Class183_0[geoIPDBVersion_0]
		}.method_5());
	}

	public static void smethod_40()
	{
		smethod_6(Class88.byte_66);
	}

	public static void smethod_41()
	{
		smethod_6(Class88.byte_67);
	}

	public static void smethod_42(string string_1)
	{
		smethod_7(Class88.byte_68, string_1);
	}
}
