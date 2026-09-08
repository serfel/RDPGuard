using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using rdpguard.lib;

[JsonConverter(typeof(Class137))]
internal sealed class EventArgs7 : EventArgs
{
	private class Class137 : JsonConverter
	{
		public override void WriteJson(JsonWriter jsonWriter_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			jsonWriter_0.WriteStartObject();
			jsonWriter_0.WritePropertyName("_");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)((EventArgs7)object_0).iplistEntry_0);
			jsonWriter_0.WriteEndObject();
		}

		public override object ReadJson(JsonReader jsonReader_0, Type type_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			return new EventArgs7(JObject.Load(jsonReader_0).Properties().First()
				.Value.ToObject<IPListEntry[]>());
		}

		public override bool CanConvert(Type type_0)
		{
			return typeof(EventArgs7).IsAssignableFrom(type_0);
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<XmlNode, IPListEntry> _003C_003E9__4_0;

		public static Func<IPListEntry, bool> _003C_003E9__4_1;

		internal IPListEntry method_0(XmlNode xmlNode_0)
		{
			return IPListEntry.DeserializeXml(xmlNode_0.OuterXml);
		}

		internal bool method_1(IPListEntry iplistEntry_0)
		{
			return null != iplistEntry_0;
		}
	}

	public IPListEntry[] iplistEntry_0;

	public EventArgs7()
	{
	}

	public EventArgs7(IPListEntry[] iplistEntry_1)
	{
		iplistEntry_0 = iplistEntry_1;
	}

	public string method_0()
	{
		return JsonConvert.SerializeObject((object)this);
	}

	public static EventArgs7 smethod_0(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			throw new ArgumentNullException("IPListEventArgs::Deserialize");
		}
		if ('{' == string_0[0])
		{
			return JsonConvert.DeserializeObject<EventArgs7>(string_0);
		}
		if ('<' == string_0[0])
		{
			IEnumerable<XmlNode> iEnumerable_ = GClass12.smethod_2(string_0).IEnumerable_0;
			Func<XmlNode, IPListEntry> selector = _003C_003Ec._003C_003E9.method_0;
			IEnumerable<IPListEntry> source = iEnumerable_.Select(selector);
			Func<IPListEntry, bool> predicate = _003C_003Ec._003C_003E9.method_1;
			return new EventArgs7(source.Where(predicate).ToArray());
		}
		throw new NotSupportedException("IPListEventArgs::Deserialize " + string_0);
	}
}
