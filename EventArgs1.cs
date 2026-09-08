using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

[JsonConverter(typeof(Class92))]
internal sealed class EventArgs1 : EventArgs
{
	private class Class92 : JsonConverter
	{
		public override void WriteJson(JsonWriter jsonWriter_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			EventArgs1 eventArgs = (EventArgs1)object_0;
			jsonWriter_0.WriteStartObject();
			jsonWriter_0.WritePropertyName("_");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)eventArgs.class90_0);
			jsonWriter_0.WriteEndObject();
		}

		public override object ReadJson(JsonReader jsonReader_0, Type type_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			return new EventArgs1(JObject.Load(jsonReader_0).Properties().First()
				.Value.ToObject<Class90[]>());
		}

		public override bool CanConvert(Type type_0)
		{
			return typeof(EventArgs1).IsAssignableFrom(type_0);
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<XmlNode, Class90> _003C_003E9__4_0;

		internal Class90 method_0(XmlNode xmlNode_0)
		{
			return Class90.smethod_0(xmlNode_0.OuterXml);
		}
	}

	public Class90[] class90_0;

	public EventArgs1(Class90[] class90_1)
	{
		class90_0 = class90_1;
	}

	public string method_0()
	{
		return JsonConvert.SerializeObject((object)this);
	}

	public static EventArgs1 smethod_0(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			throw new ArgumentNullException("BlockedAttempts::Deserialize");
		}
		if ('{' == string_0[0])
		{
			return JsonConvert.DeserializeObject<EventArgs1>(string_0);
		}
		if ('<' != string_0[0])
		{
			throw new NotSupportedException("BlockedAttempts::Deserialize " + string_0);
		}
		return DeserializeXml(string_0);
	}

	private static EventArgs1 DeserializeXml(string _str)
	{
		IEnumerable<XmlNode> iEnumerable_ = GClass12.smethod_2(_str).IEnumerable_0;
		Func<XmlNode, Class90> selector = _003C_003Ec._003C_003E9.method_0;
		return new EventArgs1(iEnumerable_.Select(selector).ToArray());
	}
}
