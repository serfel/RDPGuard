using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

[JsonConverter(typeof(Class83))]
internal sealed class Class82
{
	private class Class83 : JsonConverter
	{
		private static readonly string string_0 = "a";

		private static readonly string string_1 = "b";

		public override void WriteJson(JsonWriter jsonWriter_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			Class82 @class = (Class82)object_0;
			jsonWriter_0.WriteStartObject();
			jsonWriter_0.WritePropertyName(string_0);
			jsonSerializer_0.Serialize(jsonWriter_0, (object)@class.gclass24_0);
			jsonWriter_0.WritePropertyName(string_1);
			jsonSerializer_0.Serialize(jsonWriter_0, (object)@class.dateTime_0.ToBinary());
			jsonWriter_0.WriteEndObject();
		}

		public override object ReadJson(JsonReader jsonReader_0, Type type_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			JObject val = JObject.Load(jsonReader_0);
			return new Class82
			{
				gclass24_0 = val[string_0].ToObject<GClass24>(),
				dateTime_0 = DateTime.FromBinary((long)val[string_1])
			};
		}

		public override bool CanConvert(Type type_0)
		{
			return typeof(Class82).IsAssignableFrom(type_0);
		}
	}

	public GClass24 gclass24_0 = GClass24.GClass24_0;

	public DateTime dateTime_0 = DateTime.Now;
}
