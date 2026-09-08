using System;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

[JsonConverter(typeof(Class207))]
public class GClass24
{
	private class Class207 : JsonConverter
	{
		public override void WriteJson(JsonWriter jsonWriter_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			GClass24 gClass = (GClass24)object_0;
			jsonWriter_0.WriteStartObject();
			jsonWriter_0.WritePropertyName("_");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)new ulong[4]
			{
				gClass.GStruct1_0.UInt64_0,
				gClass.GStruct1_0.UInt64_1,
				gClass.GStruct1_1.UInt64_0,
				gClass.GStruct1_1.UInt64_1
			});
			jsonWriter_0.WriteEndObject();
		}

		public override object ReadJson(JsonReader jsonReader_0, Type type_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			JToken value = JObject.Load(jsonReader_0).Properties().First()
				.Value;
			GStruct1.smethod_4(out var gstruct1_, (ulong)value[(object)0], (ulong)value[(object)1]);
			GStruct1.smethod_4(out var gstruct1_2, (ulong)value[(object)2], (ulong)value[(object)3]);
			return new GClass24(gstruct1_, gstruct1_2);
		}

		public override bool CanConvert(Type type_0)
		{
			return typeof(GClass24).IsAssignableFrom(type_0);
		}
	}

	private GStruct1 gstruct1_0;

	private GStruct1 gstruct1_1;

	private byte byte_0;

	public static GClass24 GClass24_0 => new GClass24();

	public GStruct1 GStruct1_0
	{
		get
		{
			return gstruct1_0;
		}
		private set
		{
			gstruct1_0 = value;
		}
	}

	public GStruct1 GStruct1_1
	{
		get
		{
			return gstruct1_1;
		}
		private set
		{
			gstruct1_1 = value;
		}
	}

	public bool Boolean_0
	{
		get
		{
			if (GStruct1_0.UInt64_0 <= uint.MaxValue && GStruct1_0.UInt64_1 == 0 && GStruct1_1.UInt64_0 <= uint.MaxValue)
			{
				return GStruct1_1.UInt64_1 != 0;
			}
			return true;
		}
	}

	public bool Boolean_1 => GStruct1_1 > 0;

	public bool Boolean_2
	{
		get
		{
			if (GStruct1_0 > 0)
			{
				if (!(0 == GStruct1_1))
				{
					return GStruct1_1 > GStruct1_0;
				}
				return true;
			}
			return false;
		}
	}

	public GStruct1 GStruct1_2
	{
		get
		{
			if (!Boolean_1)
			{
				return (byte)1;
			}
			return GStruct1_1 - GStruct1_0 + 1uL;
		}
	}

	public byte Byte_0
	{
		get
		{
			return byte_0;
		}
		private set
		{
			byte_0 = value;
		}
	}

	private GClass24()
	{
	}

	public GClass24(IPAddress ipaddress_0)
	{
		method_0(GClass25.smethod_0(ipaddress_0), (byte)0);
	}

	public GClass24(GClass30 gclass30_0)
	{
		method_0((uint)gclass30_0.long_0, (uint)gclass30_0.long_1);
	}

	public GClass24(uint uint_0)
	{
		method_0(new GStruct1(uint_0), (byte)0);
	}

	public GClass24(uint uint_0, uint uint_1)
	{
		method_0(new GStruct1(uint_0), new GStruct1(uint_1));
	}

	public GClass24(IPAddress ipaddress_0, IPAddress ipaddress_1)
	{
		method_0(GClass25.smethod_0(ipaddress_0), GClass25.smethod_0(ipaddress_1));
	}

	public GClass24(GStruct1 gstruct1_2, GStruct1 gstruct1_3)
	{
		method_0(gstruct1_2, gstruct1_3);
	}

	private void method_0(GStruct1 gstruct1_2, GStruct1 gstruct1_3)
	{
		GStruct1_0 = gstruct1_2;
		GStruct1_1 = (((gstruct1_2 == gstruct1_3) ? true : false) ? ((GStruct1)(byte)0) : gstruct1_3);
		if (Boolean_1)
		{
			if (GStruct1_1 <= GStruct1_0)
			{
				Byte_0 = 0;
			}
			else
			{
				Byte_0 = (byte)(Class202.smethod_5(GClass25.smethod_3(GStruct1_0, Boolean_0), GClass25.smethod_3(GStruct1_1, Boolean_0)).FirstOrDefault()?.UInt32_0 ?? 0);
			}
		}
	}

	public bool method_1(GClass24 gclass24_0)
	{
		if (gclass24_0.GStruct1_0 >= GStruct1_0)
		{
			return gclass24_0.GStruct1_0 <= GStruct1_1;
		}
		return false;
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
		return method_3((GClass24)obj);
	}

	public bool method_2(GClass24 gclass24_0)
	{
		if ((object)gclass24_0 == null)
		{
			return false;
		}
		if ((object)this == gclass24_0)
		{
			return true;
		}
		return method_3(gclass24_0);
	}

	private bool method_3(GClass24 gclass24_0)
	{
		if (GStruct1_0 == gclass24_0.GStruct1_0)
		{
			return GStruct1_1 == gclass24_0.GStruct1_1;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return ((0x50C5D1F ^ GStruct1_0.GetHashCode()) * 16777619) ^ GStruct1_1.GetHashCode();
	}

	public static bool operator ==(GClass24 _set1, GClass24 _set2)
	{
		return _set1?.method_2(_set2) ?? ((object)_set2 == null);
	}

	public static bool operator !=(GClass24 _set1, GClass24 _set2)
	{
		return !(_set1 == _set2);
	}

	public string method_4()
	{
		return JsonConvert.SerializeObject((object)this);
	}

	public static GClass24 smethod_0(string string_0)
	{
		return JsonConvert.DeserializeObject<GClass24>(string_0);
	}

	public override string ToString()
	{
		return method_6();
	}

	public string method_5()
	{
		IPAddress arg = GClass25.smethod_3(GStruct1_0, Boolean_0);
		IPAddress arg2 = GClass25.smethod_3(GStruct1_1, Boolean_0);
		if (!Boolean_1)
		{
			return $"{arg}";
		}
		return $"{arg}-{arg2}";
	}

	public string method_6()
	{
		IPAddress arg = GClass25.smethod_3(GStruct1_0, Boolean_0);
		if (!Boolean_1)
		{
			return $"{arg}";
		}
		return $"{arg}/{Byte_0}";
	}

	public static GClass24 smethod_1(string string_0)
	{
		if (string.IsNullOrWhiteSpace(string_0))
		{
			return GClass24_0;
		}
		string text = string_0.Trim();
		if (smethod_2(text, out var ipaddress_, out var ipaddress_2))
		{
			return new GClass24(ipaddress_, ipaddress_2);
		}
		if (smethod_3(text, out ipaddress_, out ipaddress_2))
		{
			return new GClass24(ipaddress_, ipaddress_2);
		}
		if (IPAddress.TryParse(text, out var address))
		{
			return new GClass24(address);
		}
		return GClass24_0;
	}

	private static bool smethod_2(string string_0, out IPAddress ipaddress_0, out IPAddress ipaddress_1)
	{
		ipaddress_0 = (ipaddress_1 = null);
		if (string.IsNullOrWhiteSpace(string_0))
		{
			return false;
		}
		string[] array = string_0.Trim().Split('/');
		if (array.Length != 2)
		{
			return false;
		}
		string ipString = array[0].Trim();
		string s = array[1].Trim();
		if (IPAddress.TryParse(ipString, out ipaddress_0) && (int.TryParse(s, out var result) ? true : false))
		{
			byte[] addressBytes = ipaddress_0.GetAddressBytes();
			int num = ((addressBytes.Length == 4) ? 32 : 128);
			if (result >= 0 && result <= num)
			{
				byte[] array2 = new byte[addressBytes.Length];
				int num2 = result / 8;
				int num3 = result % 8;
				for (int i = 0; i < num2; i++)
				{
					array2[i] = byte.MaxValue;
				}
				if (num3 > 0)
				{
					array2[num2] = (byte)(255 << 8 - num3);
				}
				byte[] array3 = new byte[addressBytes.Length];
				byte[] array4 = new byte[addressBytes.Length];
				for (int j = 0; j < addressBytes.Length; j++)
				{
					array3[j] = (byte)(addressBytes[j] & array2[j]);
					array4[j] = (byte)(addressBytes[j] | ~array2[j]);
				}
				ipaddress_0 = new IPAddress(array3);
				ipaddress_1 = new IPAddress(array4);
				return true;
			}
			return false;
		}
		return false;
	}

	private static bool smethod_3(string string_0, out IPAddress ipaddress_0, out IPAddress ipaddress_1)
	{
		ipaddress_0 = (ipaddress_1 = null);
		if (string.IsNullOrWhiteSpace(string_0))
		{
			return false;
		}
		string[] array = string_0.Trim().Split('-');
		if (array.Length != 2)
		{
			return false;
		}
		string ipString = array[0].Trim();
		string ipString2 = array[1].Trim();
		if (!IPAddress.TryParse(ipString, out ipaddress_0))
		{
			return false;
		}
		if (!IPAddress.TryParse(ipString2, out ipaddress_1))
		{
			return false;
		}
		if (ipaddress_0.AddressFamily != ipaddress_1.AddressFamily)
		{
			return false;
		}
		GStruct1 gStruct = GClass25.smethod_0(ipaddress_0);
		return GClass25.smethod_0(ipaddress_1) >= gStruct;
	}

	public static GClass24 smethod_4(string string_0)
	{
		if (Uri.TryCreate("http://" + string_0, UriKind.Absolute, out var result) && IPAddress.TryParse(result.Host, out var address))
		{
			return new GClass24(address);
		}
		return smethod_1(string_0);
	}
}
