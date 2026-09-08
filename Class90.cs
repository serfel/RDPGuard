using System;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

[JsonConverter(typeof(Class91))]
internal sealed class Class90
{
	private class Class91 : JsonConverter
	{
		public override void WriteJson(JsonWriter jsonWriter_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			Class90 @class = (Class90)object_0;
			jsonWriter_0.WriteStartObject();
			jsonWriter_0.WritePropertyName("bd");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)@class.dateTime_0.ToBinary());
			jsonWriter_0.WritePropertyName("ri");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)@class.string_0);
			jsonWriter_0.WritePropertyName("li");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)@class.gclass11_0);
			jsonWriter_0.WriteEndObject();
		}

		public override object ReadJson(JsonReader jsonReader_0, Type type_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			JObject val = JObject.Load(jsonReader_0);
			return new Class90
			{
				dateTime_0 = DateTime.FromBinary((long)val["bd"]),
				string_0 = (string)val["ri"],
				gclass11_0 = val["li"].ToObject<GClass11>()
			};
		}

		public override bool CanConvert(Type type_0)
		{
			return typeof(Class90).IsAssignableFrom(type_0);
		}
	}

	public GClass11 gclass11_0;

	public DateTime dateTime_0 = DateTime.Now;

	public string string_0 = string.Empty;

	public static int int_0 = 24;

	public DateTime DateTime_0 => dateTime_0.AddHours(int_0);

	public bool Boolean_0 => !GClass17.genum16_0.Contains(gclass11_0.genum16_0);

	public string method_0()
	{
		return JsonConvert.SerializeObject((object)this);
	}

	public static Class90 smethod_0(string string_1)
	{
		if (string.IsNullOrEmpty(string_1))
		{
			throw new ArgumentNullException("BlockedAttempt::Deserialize");
		}
		if ('{' == string_1[0])
		{
			return JsonConvert.DeserializeObject<Class90>(string_1);
		}
		if ('<' != string_1[0])
		{
			throw new NotSupportedException("BlockedAttempt::Deserialize " + string_1);
		}
		return DeserializeXml(string_1);
	}

	public string method_1()
	{
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(method_0()));
	}

	public static Class90 smethod_1(string string_1)
	{
		return smethod_0(Encoding.UTF8.GetString(Convert.FromBase64String(string_1)));
	}

	public static Class90 DeserializeXml(string _xml)
	{
		XmlElement xmlElement_ = GClass12.smethod_2(_xml).XmlElement_0;
		ushort num = 1;
		if (xmlElement_["v"] != null)
		{
			num = ushort.Parse(xmlElement_["v"].InnerText);
		}
		if (1 == num)
		{
			return smethod_3(_xml);
		}
		if (2 != num)
		{
			throw new Exception($"Unknown version: {num}");
		}
		return smethod_2(_xml);
	}

	private static Class90 smethod_2(string string_1)
	{
		XmlElement xmlElement_ = GClass12.smethod_2(string_1).XmlElement_0;
		Class90 @class = new Class90
		{
			gclass11_0 = GClass11.smethod_0(string_1),
			dateTime_0 = DateTime.FromBinary(long.Parse(xmlElement_["bd"].InnerText))
		};
		XmlElement xmlElement = xmlElement_["ri"];
		if (xmlElement != null)
		{
			@class.string_0 = xmlElement.InnerText;
		}
		return @class;
	}

	private static Class90 smethod_3(string string_1)
	{
		XmlElement xmlElement_ = GClass12.smethod_2(string_1).XmlElement_0;
		Class90 @class = new Class90
		{
			gclass11_0 = new GClass11
			{
				gclass24_0 = new GClass24(IPAddress.Parse(xmlElement_["ip"].InnerText))
			},
			dateTime_0 = DateTime.FromBinary(long.Parse(xmlElement_["block_date"].InnerText))
		};
		if (xmlElement_["c"] != null)
		{
			@class.gclass11_0.String_0 = xmlElement_["c"].InnerText;
		}
		if (xmlElement_["u"] != null)
		{
			@class.gclass11_0.String_1 = xmlElement_["u"].InnerText;
		}
		return @class;
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
		return method_3((Class90)obj);
	}

	public bool method_2(Class90 class90_0)
	{
		if ((object)class90_0 == null)
		{
			return false;
		}
		if ((object)this == class90_0)
		{
			return true;
		}
		return method_3(class90_0);
	}

	private bool method_3(Class90 class90_0)
	{
		if (gclass11_0 == class90_0.gclass11_0)
		{
			return DateTime.Equals(dateTime_0, class90_0.dateTime_0);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return ((0x50C5D1F ^ (((object)gclass11_0 != null) ? gclass11_0.GetHashCode() : 0)) * 16777619) ^ dateTime_0.GetHashCode();
	}

	public static bool operator ==(Class90 _set1, Class90 _set2)
	{
		return _set1?.method_2(_set2) ?? ((object)_set2 == null);
	}

	public static bool operator !=(Class90 _set1, Class90 _set2)
	{
		return !(_set1 == _set2);
	}
}
