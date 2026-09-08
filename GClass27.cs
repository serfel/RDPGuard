using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class GClass27
{
	public enum GEnum18
	{
		const_0,
		const_1
	}

	public string string_0;

	public string string_1;

	public string string_2 = string.Empty;

	public bool bool_0;

	public ushort ushort_0;

	private static readonly Version version_0 = new Version(0, 0, 0);

	public Version version_1 = version_0;

	protected const string string_3 = "m";

	protected const string string_4 = "i";

	protected const string string_5 = "l";

	protected const string string_6 = "e";

	protected const string string_7 = "e125c7022328";

	protected const string string_8 = "a58ec81a1186";

	protected const string string_9 = "f3ac38e4afb5";

	public bool Boolean_0 => true;

	public bool Boolean_1
	{
		get
		{
			if (0 < ushort_0)
			{
				return ushort_0 <= 30;
			}
			return false;
		}
	}

	public string method_0(GEnum18 genum18_0)
	{
		if (GEnum18.const_1 == genum18_0)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			method_2(dictionary);
			SerializeJson(dictionary);
			return JsonConvert.SerializeObject((object)dictionary);
		}
		if ((genum18_0 != GEnum18.const_0) ? true : false)
		{
			throw new NotImplementedException("Unknown format");
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("<m>");
		method_1(stringBuilder);
		SerializeXml(stringBuilder);
		stringBuilder.Append("</m>");
		return stringBuilder.ToString();
	}

	protected virtual void SerializeXml(StringBuilder stringBuilder_0)
	{
	}

	protected virtual void SerializeJson(Dictionary<string, object> dictionary_0)
	{
	}

	private void method_1(StringBuilder stringBuilder_0)
	{
		if (!string.IsNullOrEmpty(string_0))
		{
			stringBuilder_0.AppendFormat("<{0}>{1}</{0}>", "i", string_0);
		}
		if (!string.IsNullOrEmpty(string_1))
		{
			stringBuilder_0.AppendFormat("<{0}>{1}</{0}>", "l", string_1);
		}
		if (!string.IsNullOrEmpty(string_2))
		{
			stringBuilder_0.AppendFormat("<{0}>{1}</{0}>", "e", string_2);
		}
		if (bool_0)
		{
			stringBuilder_0.AppendFormat("<{0}>{1}</{0}>", "e125c7022328", bool_0);
		}
		if (ushort_0 > 0)
		{
			stringBuilder_0.AppendFormat("<{0}>{1}</{0}>", "a58ec81a1186", ushort_0);
		}
		if (version_1 != version_0)
		{
			stringBuilder_0.AppendFormat("<{0}>{1}</{0}>", "f3ac38e4afb5", version_1.ToString(3));
		}
	}

	private void method_2(Dictionary<string, object> dictionary_0)
	{
		if (!string.IsNullOrEmpty(string_0))
		{
			dictionary_0.Add("i", string_0);
		}
		if (!string.IsNullOrEmpty(string_1))
		{
			dictionary_0.Add("l", string_1);
		}
		if (!string.IsNullOrEmpty(string_2))
		{
			dictionary_0.Add("e", string_2);
		}
		if (bool_0)
		{
			dictionary_0.Add("e125c7022328", bool_0);
		}
		if (ushort_0 > 0)
		{
			dictionary_0.Add("a58ec81a1186", ushort_0);
		}
		if (version_1 != version_0)
		{
			dictionary_0.Add("f3ac38e4afb5", version_1.ToString(3));
		}
	}

	public static GClass27 smethod_0(Type type_0, Stream stream_0)
	{
		return smethod_2(type_0, new StreamReader(stream_0).ReadToEnd());
	}

	public static GClass27 smethod_1(Stream stream_0)
	{
		return smethod_2(null, new StreamReader(stream_0).ReadToEnd());
	}

	public static GClass27 smethod_2(Type type_0, string string_10)
	{
		object obj = (((null == type_0) ? true : false) ? new GClass27() : Activator.CreateInstance(type_0));
		if (string.IsNullOrEmpty(string_10))
		{
			throw new ArgumentNullException("ClientServerMessage::Deserialize");
		}
		if ('{' == string_10[0])
		{
			JObject val = JsonConvert.DeserializeObject<JObject>(string_10);
			((GClass27)obj).method_4(val);
			if (null != type_0)
			{
				MethodInfo method = type_0.GetMethod("DeserializeJson", BindingFlags.Instance | BindingFlags.NonPublic);
				object[] array = (object[])(object)new JObject[1] { val };
				object[] parameters = array;
				method.Invoke(obj, parameters);
			}
			return (GClass27)obj;
		}
		if ('<' == string_10[0])
		{
			XmlElement xmlElement_ = GClass12.smethod_2(string_10.smethod_17()).XmlElement_0;
			((GClass27)obj).method_3(xmlElement_);
			if (null != type_0)
			{
				MethodInfo method2 = type_0.GetMethod("DeserializeXml", BindingFlags.Instance | BindingFlags.NonPublic);
				object[] array = new XmlElement[1] { xmlElement_ };
				object[] parameters2 = array;
				method2.Invoke(obj, parameters2);
			}
			return (GClass27)obj;
		}
		throw new NotSupportedException("ClientServerMessage::Deserialize " + string_10);
	}

	protected virtual void DeserializeXml(XmlElement xmlElement_0)
	{
	}

	protected virtual void DeserializeJson(JObject _jo)
	{
	}

	private void method_3(XmlElement xmlElement_0)
	{
		if (xmlElement_0["i"] != null)
		{
			string_0 = xmlElement_0["i"].InnerText;
		}
		if (xmlElement_0["l"] != null)
		{
			string_1 = xmlElement_0["l"].InnerText;
		}
		if (xmlElement_0["e"] != null)
		{
			string_2 = xmlElement_0["e"].InnerText;
		}
		if (xmlElement_0["e125c7022328"] != null)
		{
			bool_0 = bool.Parse(xmlElement_0["e125c7022328"].InnerText);
		}
		if (xmlElement_0["a58ec81a1186"] != null)
		{
			ushort_0 = ushort.Parse(xmlElement_0["a58ec81a1186"].InnerText);
		}
		if (xmlElement_0["f3ac38e4afb5"] != null)
		{
			version_1 = new Version(xmlElement_0["f3ac38e4afb5"].InnerText);
		}
	}

	private void method_4(JObject jobject_0)
	{
		JToken val = default(JToken);
		if (jobject_0.TryGetValue("i", out val))
		{
			string_0 = ((object)val).ToString();
		}
		JToken val2 = default(JToken);
		if (jobject_0.TryGetValue("l", out val2))
		{
			string_1 = ((object)val2).ToString();
		}
		JToken val3 = default(JToken);
		if (jobject_0.TryGetValue("e", out val3))
		{
			string_2 = ((object)val3).ToString();
		}
		JToken val4 = default(JToken);
		if (jobject_0.TryGetValue("e125c7022328", out val4))
		{
			bool_0 = bool.Parse(((object)val4).ToString());
		}
		JToken val5 = default(JToken);
		if (jobject_0.TryGetValue("a58ec81a1186", out val5))
		{
			ushort_0 = ushort.Parse(((object)val5).ToString());
		}
		JToken val6 = default(JToken);
		if (jobject_0.TryGetValue("f3ac38e4afb5", out val6))
		{
			version_1 = new Version(((object)val6).ToString());
		}
	}
}
