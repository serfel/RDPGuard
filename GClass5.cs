using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class GClass5
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<JToken, string> _003C_003E9__19_0;

		internal string method_0(JToken jtoken_0)
		{
			return ((object)jtoken_0).ToString();
		}
	}

	public static readonly string string_0 = "geoip-";

	public string string_1 = string.Empty;

	public string Name = string.Empty;

	public string[] string_2 = new string[0];

	public GClass30[] gclass30_0 = new GClass30[0];

	public long long_0;

	public long long_1;

	public DateTime dateTime_0 = DateTime.MinValue;

	public string String_0 => string_0 + string_1;

	public Dictionary<string, object> method_0()
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		if (!string.IsNullOrEmpty(string_1))
		{
			dictionary.Add("cc", string_1);
		}
		if (!string.IsNullOrEmpty(Name))
		{
			dictionary.Add("nm", Name);
		}
		if (!string_2.IsNullOrEmpty())
		{
			dictionary.Add("en", string_2);
		}
		if (!gclass30_0.IsNullOrEmpty())
		{
			dictionary.Add("en2", gclass30_0);
		}
		if (long_0 > 0)
		{
			dictionary.Add("ac", long_0);
		}
		if (long_1 > 0)
		{
			dictionary.Add("ec", long_1);
		}
		if (dateTime_0 != DateTime.MinValue)
		{
			dictionary.Add("upd", dateTime_0.ToBinary());
		}
		return dictionary;
	}

	public static GClass5 smethod_0(JObject jobject_0)
	{
		GClass5 gClass = new GClass5();
		JToken val = default(JToken);
		if (jobject_0.TryGetValue("cc", out val))
		{
			gClass.string_1 = ((object)val).ToString();
		}
		JToken val2 = default(JToken);
		if (jobject_0.TryGetValue("nm", out val2))
		{
			gClass.Name = ((object)val2).ToString();
		}
		JToken val3 = default(JToken);
		if (jobject_0.TryGetValue("en", out val3))
		{
			JToken source = val3;
			Func<JToken, string> selector = _003C_003Ec._003C_003E9.method_0;
			gClass.string_2 = ((IEnumerable<JToken>)source).Select(selector).ToArray();
		}
		JToken val4 = default(JToken);
		if (jobject_0.TryGetValue("en2", out val4))
		{
			gClass.gclass30_0 = val4.ToObject<GClass30[]>();
		}
		JToken val5 = default(JToken);
		if (jobject_0.TryGetValue("ac", out val5))
		{
			gClass.long_0 = (long)val5;
		}
		JToken val6 = default(JToken);
		if (jobject_0.TryGetValue("ec", out val6))
		{
			gClass.long_1 = (long)val6;
		}
		JToken val7 = default(JToken);
		if (jobject_0.TryGetValue("upd", out val7))
		{
			gClass.dateTime_0 = DateTime.FromBinary((long)val7);
		}
		return gClass;
	}

	public string method_1()
	{
		return JsonConvert.SerializeObject((object)method_0());
	}

	public string method_2()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("<bc>");
		if (!string.IsNullOrEmpty(string_1))
		{
			stringBuilder.AppendFormat("<{0}>{1}</{0}>", "cc", string_1);
		}
		if (!string.IsNullOrEmpty(Name))
		{
			stringBuilder.AppendFormat("<{0}>{1}</{0}>", "nm", Name);
		}
		if (!string_2.IsNullOrEmpty())
		{
			stringBuilder.AppendFormat("<{0}>{1}</{0}>", "en", string.Join(",", string_2));
		}
		if (long_0 > 0)
		{
			stringBuilder.AppendFormat("<{0}>{1}</{0}>", "ac", long_0);
		}
		if (long_1 > 0)
		{
			stringBuilder.AppendFormat("<{0}>{1}</{0}>", "ec", long_1);
		}
		if (dateTime_0 != DateTime.MinValue)
		{
			stringBuilder.AppendFormat("<{0}>{1}</{0}>", "upd", dateTime_0.ToBinary());
		}
		stringBuilder.Append("</bc>");
		return stringBuilder.ToString();
	}

	public static GClass5 smethod_1(string string_3)
	{
		if (string.IsNullOrEmpty(string_3))
		{
			throw new ArgumentNullException("GeoIPCountry::Deserialize");
		}
		if ('{' == string_3[0])
		{
			return smethod_0(JsonConvert.DeserializeObject<JObject>(string_3));
		}
		if ('<' != string_3[0])
		{
			throw new NotSupportedException("GeoIPCountry::Deserialize " + string_3);
		}
		return DeserializeXml(string_3);
	}

	public static GClass5 DeserializeXml(string _xml)
	{
		GClass5 gClass = new GClass5();
		try
		{
			XmlElement xmlElement_ = GClass12.smethod_2(_xml).XmlElement_0;
			XmlElement xmlElement = xmlElement_["cc"];
			if (xmlElement != null)
			{
				gClass.string_1 = xmlElement.InnerText;
			}
			XmlElement xmlElement2 = xmlElement_["nm"];
			if (xmlElement2 != null)
			{
				gClass.Name = xmlElement2.InnerText;
			}
			XmlElement xmlElement3 = xmlElement_["en"];
			if (xmlElement3 != null)
			{
				gClass.string_2 = xmlElement3.InnerText.smethod_7();
			}
			XmlElement xmlElement4 = xmlElement_["ac"];
			if (xmlElement4 != null)
			{
				gClass.long_0 = int.Parse(xmlElement4.InnerText);
			}
			XmlElement xmlElement5 = xmlElement_["ec"];
			if (xmlElement5 != null)
			{
				gClass.long_1 = int.Parse(xmlElement5.InnerText);
			}
			XmlElement xmlElement6 = xmlElement_["upd"];
			if (xmlElement6 != null)
			{
				gClass.dateTime_0 = DateTime.FromBinary(long.Parse(xmlElement6.InnerText));
			}
		}
		catch (Exception arg)
		{
			Class208.smethod_0($"GeoIPCountry::Deserialize::{arg}::{_xml}");
		}
		return gClass;
	}

	public override bool Equals(object obj)
	{
		if (obj != null && !(obj.GetType() != GetType()))
		{
			if (this == obj)
			{
				return true;
			}
			return method_4((GClass5)obj);
		}
		return false;
	}

	public bool method_3(GClass5 gclass5_0)
	{
		if ((object)gclass5_0 == null)
		{
			return false;
		}
		if ((object)this == gclass5_0)
		{
			return true;
		}
		return method_4(gclass5_0);
	}

	private bool method_4(GClass5 gclass5_0)
	{
		if (string.Equals(string_1, gclass5_0.string_1) && string.Equals(Name, gclass5_0.Name) && long_0 == gclass5_0.long_0 && long_1 == gclass5_0.long_1)
		{
			return DateTime.Equals(dateTime_0, gclass5_0.dateTime_0);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return ((((((((0x50C5D1F ^ ((string_1 != null) ? string_1.GetHashCode() : 0)) * 16777619) ^ ((Name != null) ? Name.GetHashCode() : 0)) * 16777619) ^ (((object)long_0 != null) ? long_0.GetHashCode() : 0)) * 16777619) ^ (((object)long_1 != null) ? long_1.GetHashCode() : 0)) * 16777619) ^ (((object)dateTime_0 != null) ? dateTime_0.GetHashCode() : 0);
	}

	public static bool operator ==(GClass5 _set1, GClass5 _set2)
	{
		return _set1?.method_3(_set2) ?? ((object)_set2 == null);
	}

	public static bool operator !=(GClass5 _set1, GClass5 _set2)
	{
		return !(_set1 == _set2);
	}
}
