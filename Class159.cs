using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

[JsonConverter(typeof(Class160))]
internal sealed class Class159
{
	private class Class160 : JsonConverter
	{
		public override void WriteJson(JsonWriter jsonWriter_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			Class159 @class = (Class159)object_0;
			jsonWriter_0.WriteStartObject();
			jsonWriter_0.WritePropertyName("t");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)(int)@class.genum13_0);
			jsonWriter_0.WritePropertyName("a");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)@class.string_0);
			jsonWriter_0.WritePropertyName("p");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)@class.int_0);
			jsonWriter_0.WritePropertyName("ra");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)@class.bool_0);
			jsonWriter_0.WritePropertyName("u");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)@class.string_1);
			jsonWriter_0.WritePropertyName("pw");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)@class.string_2);
			jsonWriter_0.WritePropertyName("d");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)@class.string_3);
			jsonWriter_0.WriteEndObject();
		}

		public override object ReadJson(JsonReader jsonReader_0, Type type_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			JObject val = JObject.Load(jsonReader_0);
			Class159 @class = new Class159();
			JToken val2 = default(JToken);
			if (val.TryGetValue("t", out val2))
			{
				@class.genum13_0 = (GEnum13)(int)val2;
			}
			JToken val3 = default(JToken);
			if (val.TryGetValue("a", out val3))
			{
				@class.string_0 = (string)val3;
			}
			JToken val4 = default(JToken);
			if (val.TryGetValue("p", out val4))
			{
				@class.int_0 = (int)val4;
			}
			JToken val5 = default(JToken);
			if (val.TryGetValue("ra", out val5))
			{
				@class.bool_0 = (bool)val5;
			}
			JToken val6 = default(JToken);
			if (val.TryGetValue("u", out val6))
			{
				@class.string_1 = (string)val6;
			}
			JToken val7 = default(JToken);
			if (val.TryGetValue("pw", out val7))
			{
				@class.string_2 = (string)val7;
			}
			JToken val8 = default(JToken);
			if (val.TryGetValue("d", out	 val8))
			{
				@class.string_3 = (string)val8;
			}
			return @class;
		}

		public override bool CanConvert(Type type_0)
		{
			return typeof(Class159).IsAssignableFrom(type_0);
		}
	}

	public const string Name = "ProxySettingsV2";

	public GEnum13 genum13_0;

	public string string_0;

	public int int_0 = 8080;

	public bool bool_0;

	public string string_1;

	public string string_2;

	public string string_3;

	public string method_0()
	{
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject((object)this)));
	}

	public static Class159 smethod_0(string string_4)
	{
		if (!string.IsNullOrEmpty(string_4))
		{
			return JsonConvert.DeserializeObject<Class159>(Encoding.UTF8.GetString(Convert.FromBase64String(string_4)));
		}
		return new Class159();
	}
}
