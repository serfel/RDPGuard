using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

[JsonConverter(typeof(Class209))]
public class GClass30
{
	private class Class209 : JsonConverter
	{
		public override void WriteJson(JsonWriter jsonWriter_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			GClass30 gClass = (GClass30)object_0;
			jsonWriter_0.WriteStartObject();
			jsonWriter_0.WritePropertyName("_");
			jsonSerializer_0.Serialize(jsonWriter_0, (gClass.long_0 == gClass.long_1) ? ((object)gClass.long_0) : new long[2] { gClass.long_0, gClass.long_1 });
			jsonWriter_0.WriteEndObject();
		}

		public override object ReadJson(JsonReader jsonReader_0, Type type_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			JToken value = JObject.Load(jsonReader_0).Properties().First()
				.Value;
			if (!((IEnumerable<JToken>)value).Any())
			{
				return new GClass30
				{
					long_0 = (long)value
				};
			}
			return new GClass30
			{
				long_0 = (long)value[(object)0],
				long_1 = (long)value[(object)1]
			};
		}

		public override bool CanConvert(Type type_0)
		{
			return typeof(GClass30).IsAssignableFrom(type_0);
		}
	}

	public long long_0;

	public long long_1;
}
