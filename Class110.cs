using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

[JsonConverter(typeof(Class111))]
internal sealed class Class110
{
	private class Class111 : JsonConverter
	{
		public override void WriteJson(JsonWriter jsonWriter_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			Class110 @class = (Class110)object_0;
			jsonWriter_0.WriteStartObject();
			jsonWriter_0.WritePropertyName("i");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)@class.String_0);
			jsonWriter_0.WritePropertyName("t");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)@class.String_1);
			jsonWriter_0.WritePropertyName("y");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)@class.String_2);
			jsonWriter_0.WriteEndObject();
		}

		public override object ReadJson(JsonReader jsonReader_0, Type type_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			JObject val = JObject.Load(jsonReader_0);
			Class110 @class = new Class110();
			JToken val2 = default(JToken);
			if (val.TryGetValue("i", out val2))
			{
				@class.String_0 = (string)val2;
			}
			JToken val3 = default(JToken);
			if (val.TryGetValue("t", out val3))
			{
				@class.String_1 = (string)val3;
			}
			JToken val4 = default(JToken);
			if (val.TryGetValue("y", out val4))
			{
				@class.String_2 = (string)val4;
			}
			return @class;
		}

		public override bool CanConvert(Type type_0)
		{
			return typeof(Class110).IsAssignableFrom(type_0);
		}
	}

	private string string_0;

	private string string_1;

	private string string_2;

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

	public string String_1
	{
		get
		{
			return string_1;
		}
		set
		{
			string_1 = value;
		}
	}

	public string String_2
	{
		get
		{
			return string_2;
		}
		set
		{
			string_2 = value;
		}
	}

	public string method_0()
	{
		return JsonConvert.SerializeObject((object)this);
	}

	public static Class110 smethod_0(string string_3)
	{
		if (!string.IsNullOrEmpty(string_3))
		{
			return JsonConvert.DeserializeObject<Class110>(string_3);
		}
		return new Class110();
	}
}
