using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using Newtonsoft.Json.Linq;

public class GClass29 : GClass28
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<GClass5, string> _003C_003E9__17_0;

		public static Func<GClass5, Dictionary<string, object>> _003C_003E9__18_0;

		public static Func<XmlNode, GClass5> _003C_003E9__19_0;

		public static Func<JToken, GClass5> _003C_003E9__20_0;

		public static Func<JToken, string> _003C_003E9__20_1;

		internal string method_0(GClass5 gclass5_0)
		{
			return gclass5_0.method_2();
		}

		internal Dictionary<string, object> method_1(GClass5 gclass5_0)
		{
			return gclass5_0.method_0();
		}

		internal GClass5 method_2(XmlNode xmlNode_0)
		{
			return GClass5.smethod_1(xmlNode_0.OuterXml);
		}

		internal GClass5 method_3(JToken jtoken_0)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Expected O, but got Unknown
			return GClass5.smethod_0((JObject)jtoken_0);
		}

		internal string method_4(JToken jtoken_0)
		{
			return ((object)jtoken_0).ToString();
		}
	}

	public GClass5[] gclass5_0 = new GClass5[0];

	public string[] string_10 = new string[0];

	public GEnum1 genum1_0 = GEnum1.const_2;

	public bool bool_1;

	public GClass30[] gclass30_0 = new GClass30[0];

	public GClass30[] gclass30_1 = new GClass30[0];

	public bool bool_2;

	public GClass30[] gclass30_2 = new GClass30[0];

	public static GClass29 gclass29_0 = new GClass29();

	protected override void SerializeXml(StringBuilder stringBuilder_0)
	{
		if (!gclass5_0.IsNullOrEmpty())
		{
			GClass5[] source = gclass5_0;
			Func<GClass5, string> selector = _003C_003Ec._003C_003E9.method_0;
			stringBuilder_0.AppendFormat("<{0}>{1}</{0}>", "c", string.Join(null, source.Select(selector)));
		}
		if (!string_10.IsNullOrEmpty())
		{
			stringBuilder_0.AppendFormat("<{0}>{1}</{0}>", "cc", string.Join(",", string_10));
		}
		if (GEnum1.const_2 != genum1_0)
		{
			stringBuilder_0.AppendFormat("<{0}>{1}</{0}>", "t", (int)genum1_0);
		}
	}

	protected override void SerializeJson(Dictionary<string, object> dictionary_0)
	{
		if (!gclass5_0.IsNullOrEmpty())
		{
			GClass5[] source = gclass5_0;
			Func<GClass5, Dictionary<string, object>> selector = _003C_003Ec._003C_003E9.method_1;
			dictionary_0.Add("c", source.Select(selector));
		}
		if (!string_10.IsNullOrEmpty())
		{
			dictionary_0.Add("cc", string_10);
		}
		if (GEnum1.const_2 != genum1_0)
		{
			dictionary_0.Add("t", (int)genum1_0);
		}
		if (bool_1)
		{
			dictionary_0.Add("vt", true);
		}
		if (gclass30_0.Any())
		{
			dictionary_0.Add("v", gclass30_0);
		}
		if (gclass30_1.Any())
		{
			dictionary_0.Add("r", gclass30_1);
		}
		if (bool_2)
		{
			dictionary_0.Add("id", true);
		}
		if (gclass30_2.Any())
		{
			dictionary_0.Add("dc", gclass30_2);
		}
	}

	protected override void DeserializeXml(XmlElement xmlElement_0)
	{
		if (xmlElement_0["c"] != null)
		{
			IEnumerable<XmlNode> source = xmlElement_0["c"].ChildNodes.Cast<XmlNode>();
			Func<XmlNode, GClass5> selector = _003C_003Ec._003C_003E9.method_2;
			gclass5_0 = source.Select(selector).ToArray();
		}
		if (xmlElement_0["cc"] != null)
		{
			string_10 = xmlElement_0["cc"].InnerText.smethod_7();
		}
		if (xmlElement_0["t"] != null)
		{
			genum1_0 = (GEnum1)int.Parse(xmlElement_0["t"].InnerText);
		}
	}

	protected override void DeserializeJson(JObject _jo)
	{
		JToken val = default(JToken);
		if (_jo.TryGetValue("c", out val))
		{
			JToken source = val;
			Func<JToken, GClass5> selector = _003C_003Ec._003C_003E9.method_3;
			gclass5_0 = ((IEnumerable<JToken>)source).Select(selector).ToArray();
		}
		JToken val2 = default(JToken);
		if (_jo.TryGetValue("cc", out val2))
		{
			JToken source2 = val2;
			Func<JToken, string> selector2 = _003C_003Ec._003C_003E9.method_4;
			string_10 = ((IEnumerable<JToken>)source2).Select(selector2).ToArray();
		}
		JToken val3 = default(JToken);
		if (_jo.TryGetValue("t", out val3))
		{
			genum1_0 = (GEnum1)(int)val3;
		}
		JToken val4 = default(JToken);
		if (_jo.TryGetValue("vt", out val4))
		{
			bool_1 = (bool)val4;
		}
		JToken val5 = default(JToken);
		if (_jo.TryGetValue("v", out val5))
		{
			gclass30_0 = val5.ToObject<GClass30[]>();
		}
		JToken val6 = default(JToken);
		if (_jo.TryGetValue("r", out val6))
		{
			gclass30_1 = val6.ToObject<GClass30[]>();
		}
		JToken val7 = default(JToken);
		if (_jo.TryGetValue("id", out val7))
		{
			bool_2 = (bool)val7;
		}
		JToken val8 = default(JToken);
		if (_jo.TryGetValue("dc", out val8))
		{
			gclass30_2 = val8.ToObject<GClass30[]>();
		}
	}

	public static GClass29 smethod_3(string string_11)
	{
		return (GClass29)GClass27.smethod_2(typeof(GClass29), string_11);
	}

	public static GClass29 smethod_4(Stream stream_0)
	{
		return (GClass29)GClass27.smethod_0(typeof(GClass29), stream_0);
	}
}
