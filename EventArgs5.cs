using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

[JsonConverter(typeof(Class112))]
internal sealed class EventArgs5 : EventArgs
{
	private class Class112 : JsonConverter
	{
		public override void WriteJson(JsonWriter jsonWriter_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			EventArgs5 eventArgs = (EventArgs5)object_0;
			jsonWriter_0.WriteStartObject();
			jsonWriter_0.WritePropertyName("c");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)eventArgs.Class110_0);
			jsonWriter_0.WritePropertyName("e");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)eventArgs.String_0);
			jsonWriter_0.WriteEndObject();
		}

		public override object ReadJson(JsonReader jsonReader_0, Type type_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			JObject val = JObject.Load(jsonReader_0);
			EventArgs5 eventArgs = new EventArgs5();
			JToken val2 = default(JToken);
			if (val.TryGetValue("c", out val2))
			{
				eventArgs.Class110_0 = val2.ToObject<Class110[]>();
			}
			JToken val3 = default(JToken);
			if (val.TryGetValue("e", out val3))
			{
				eventArgs.String_0 = (string)val3;
			}
			return eventArgs;
		}

		public override bool CanConvert(Type type_0)
		{
			return typeof(EventArgs5).IsAssignableFrom(type_0);
		}
	}

	private string string_0;

	private Class110[] class110_0;

	public string String_0
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	public bool Boolean_0 => string.IsNullOrEmpty(String_0);

	public Class110[] Class110_0
	{
		get
		{
			return class110_0;
		}
		set
		{
			class110_0 = value;
		}
	}

	public static EventArgs5 smethod_0(string string_1)
	{
		if (!string.IsNullOrEmpty(string_1))
		{
			return JsonConvert.DeserializeObject<EventArgs5>(string_1);
		}
		return new EventArgs5();
	}
}
