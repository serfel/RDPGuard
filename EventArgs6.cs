using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

[JsonConverter(typeof(Class129))]
internal sealed class EventArgs6 : EventArgs
{
	private class Class129 : JsonConverter
	{
		public override void WriteJson(JsonWriter jsonWriter_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			EventArgs6 eventArgs = (EventArgs6)object_0;
			jsonWriter_0.WriteStartObject();
			jsonWriter_0.WritePropertyName(string_0);
			jsonSerializer_0.Serialize(jsonWriter_0, (object)eventArgs.class127_0);
			jsonWriter_0.WritePropertyName(string_1);
			jsonSerializer_0.Serialize(jsonWriter_0, (object)eventArgs.bool_0);
			jsonWriter_0.WriteEndObject();
		}

		public override object ReadJson(JsonReader jsonReader_0, Type type_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			JObject val = JObject.Load(jsonReader_0);
			return new EventArgs6
			{
				class127_0 = val[string_0].ToObject<Class127[]>(),
				bool_0 = (bool)val[string_1]
			};
		}

		public override bool CanConvert(Type type_0)
		{
			return typeof(EventArgs6).IsAssignableFrom(type_0);
		}
	}

	public bool bool_0 = true;

	public Class127[] class127_0 = new Class127[0];

	private static readonly string string_0 = "a";

	private static readonly string string_1 = "i";

	public static EventArgs6 smethod_0(string string_2)
	{
		return JsonConvert.DeserializeObject<EventArgs6>(string_2);
	}
}
