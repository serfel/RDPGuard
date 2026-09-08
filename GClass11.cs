using System;
using System.Security;
using System.Text;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

[JsonConverter(typeof(Class179))]
public class GClass11
{
	private class Class179 : JsonConverter
	{
		public override void WriteJson(JsonWriter jsonWriter_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			GClass11 gClass = (GClass11)object_0;
			jsonWriter_0.WriteStartObject();
			jsonWriter_0.WritePropertyName("i");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)gClass.gclass24_0);
			if (gClass.Boolean_1)
			{
				jsonWriter_0.WritePropertyName("u");
				jsonSerializer_0.Serialize(jsonWriter_0, (object)gClass.String_1);
			}
			if (!string.IsNullOrEmpty(gClass.string_3))
			{
				jsonWriter_0.WritePropertyName("d");
				jsonSerializer_0.Serialize(jsonWriter_0, (object)gClass.string_3);
			}
			if (!string.IsNullOrEmpty(gClass.string_4))
			{
				jsonWriter_0.WritePropertyName("t");
				jsonSerializer_0.Serialize(jsonWriter_0, (object)gClass.string_4);
			}
			if (!string.IsNullOrEmpty(gClass.string_1))
			{
				jsonWriter_0.WritePropertyName("p");
				jsonSerializer_0.Serialize(jsonWriter_0, (object)gClass.string_1);
			}
			if (GEnum16.const_5 != gClass.genum16_0)
			{
				jsonWriter_0.WritePropertyName("o");
				jsonSerializer_0.Serialize(jsonWriter_0, (object)(int)gClass.genum16_0);
			}
			jsonWriter_0.WriteEndObject();
		}

		public override object ReadJson(JsonReader jsonReader_0, Type type_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			JObject val = JObject.Load(jsonReader_0);
			GClass11 gClass = new GClass11();
			JToken val2 = default(JToken);
			if (val.TryGetValue("i", out val2))
			{
				gClass.gclass24_0 = val2.ToObject<GClass24>();
			}
			JToken val3 = default(JToken);
			if (val.TryGetValue("u", out val3))
			{
				gClass.String_1 = (string)val3;
			}
			JToken val4 = default(JToken);
			if (val.TryGetValue("d", out val4))
			{
				gClass.string_3 = (string)val4;
			}
			JToken val5 = default(JToken);
			if (val.TryGetValue("t", out val5))
			{
				gClass.string_4 = (string)val5;
			}
			JToken val6 = default(JToken);
			if (val.TryGetValue("p", out val6))
			{
				gClass.string_1 = (string)val6;
			}
			JToken val7 = default(JToken);
			if (val.TryGetValue("o", out val7))
			{
				gClass.genum16_0 = (GEnum16)(int)val7;
			}
			return gClass;
		}

		public override bool CanConvert(Type type_0)
		{
			return typeof(GClass11).IsAssignableFrom(type_0);
		}
	}

	public static string string_0 = "[Unknown]";

	public GClass24 gclass24_0 = GClass24.GClass24_0;

	private string string_1 = string.Empty;

	private string string_2;

	public string string_3 = string.Empty;

	public string string_4 = string.Empty;

	public GEnum16 genum16_0;

	public DateTime dateTime_0 = DateTime.Now;

	public string String_0
	{
		get
		{
			if (!string.IsNullOrEmpty(string_1))
			{
				return string_1;
			}
			return GClass17.GClass17_0[genum16_0];
		}
		set
		{
			string_1 = value;
		}
	}

	public string String_1
	{
		get
		{
			if (!string.IsNullOrEmpty(string_2))
			{
				return string_2;
			}
			return string_0;
		}
		set
		{
			string_2 = value;
		}
	}

	public bool Boolean_0 => genum16_0 == GEnum16.const_0;

	public bool Boolean_1 => string_0 != String_1;

	public override string ToString()
	{
		return $"IP: {gclass24_0}; User: {String_1}; Domain: {string_3}; Tag: {string_4}; " + $"Protocol: {String_0}; Origin: {genum16_0}; Detected: {dateTime_0}";
	}

	public string method_0()
	{
		return JsonConvert.SerializeObject((object)this);
	}

	public string method_1()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("<li>");
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "i", SecurityElement.Escape(gclass24_0.method_6()));
		if (Boolean_1)
		{
			stringBuilder.AppendFormat("<{0}>{1}</{0}>", "u", SecurityElement.Escape(String_1));
		}
		if (!string.IsNullOrEmpty(string_3))
		{
			stringBuilder.AppendFormat("<{0}>{1}</{0}>", "d", SecurityElement.Escape(string_3));
		}
		if (!string.IsNullOrEmpty(string_4))
		{
			stringBuilder.AppendFormat("<{0}>{1}</{0}>", "t", SecurityElement.Escape(string_4));
		}
		if (!string.IsNullOrEmpty(string_1))
		{
			stringBuilder.AppendFormat("<{0}>{1}</{0}>", "p", SecurityElement.Escape(string_1));
		}
		if (GEnum16.const_5 != genum16_0)
		{
			stringBuilder.AppendFormat("<{0}>{1}</{0}>", "o", (int)genum16_0);
		}
		stringBuilder.Append("</li>");
		return stringBuilder.ToString();
	}

	public static GClass11 smethod_0(string string_5)
	{
		if (string.IsNullOrEmpty(string_5))
		{
			throw new ArgumentNullException("LoginInfo::Deserialize");
		}
		if ('{' == string_5[0])
		{
			return JsonConvert.DeserializeObject<GClass11>(string_5);
		}
		if ('<' != string_5[0])
		{
			throw new NotSupportedException("LoginInfo::Deserialize " + string_5);
		}
		return DeserializeXml(string_5);
	}

	public static GClass11 DeserializeXml(string _xml)
	{
		GClass12 gClass = GClass12.smethod_2(_xml);
		XmlElement xmlElement = gClass.DocumentElement["li"];
		if (xmlElement == null)
		{
			xmlElement = gClass.DocumentElement;
		}
		GClass11 gClass2 = new GClass11();
		if (xmlElement["i"] != null)
		{
			gClass2.gclass24_0 = GClass24.smethod_1(xmlElement["i"].InnerText);
		}
		if (xmlElement["u"] != null)
		{
			gClass2.String_1 = xmlElement["u"].InnerText;
		}
		if (xmlElement["d"] != null)
		{
			gClass2.string_3 = xmlElement["d"].InnerText;
		}
		if (xmlElement["t"] != null)
		{
			gClass2.string_4 = xmlElement["t"].InnerText;
		}
		if (xmlElement["p"] != null)
		{
			gClass2.string_1 = xmlElement["p"].InnerText;
		}
		if (xmlElement["o"] != null)
		{
			gClass2.genum16_0 = (GEnum16)int.Parse(xmlElement["o"].InnerText);
		}
		return gClass2;
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
		return method_3((GClass11)obj);
	}

	public bool method_2(GClass11 gclass11_0)
	{
		if ((object)gclass11_0 == null)
		{
			return false;
		}
		if ((object)this == gclass11_0)
		{
			return true;
		}
		return method_3(gclass11_0);
	}

	private bool method_3(GClass11 gclass11_0)
	{
		if (gclass24_0 == gclass11_0.gclass24_0 && string.Equals(String_0, gclass11_0.String_0) && string.Equals(String_1, gclass11_0.String_1) && string.Equals(string_3, gclass11_0.string_3) && string.Equals(string_4, gclass11_0.string_4))
		{
			return genum16_0 == gclass11_0.genum16_0;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return ((((((((((0x50C5D1F ^ (((object)gclass24_0 != null) ? gclass24_0.GetHashCode() : 0)) * 16777619) ^ ((String_0 != null) ? String_0.GetHashCode() : 0)) * 16777619) ^ ((String_1 != null) ? String_1.GetHashCode() : 0)) * 16777619) ^ ((string_3 != null) ? string_3.GetHashCode() : 0)) * 16777619) ^ ((string_4 != null) ? string_4.GetHashCode() : 0)) * 16777619) ^ genum16_0.GetHashCode();
	}

	public static bool operator ==(GClass11 _set1, GClass11 _set2)
	{
		return _set1?.method_2(_set2) ?? ((object)_set2 == null);
	}

	public static bool operator !=(GClass11 _set1, GClass11 _set2)
	{
		return !(_set1 == _set2);
	}
}
