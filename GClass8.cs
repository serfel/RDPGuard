using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

[JsonConverter(typeof(Class158))]
public class GClass8
{
	private class Class158 : JsonConverter
	{
		public override void WriteJson(JsonWriter jsonWriter_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			GClass8 gClass = (GClass8)object_0;
			jsonWriter_0.WriteStartObject();
			jsonWriter_0.WritePropertyName("v");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)(int)gClass.genum17_0);
			jsonWriter_0.WritePropertyName("s2f");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)gClass.bool_0);
			jsonWriter_0.WritePropertyName("rol");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)gClass.bool_1);
			jsonWriter_0.WritePropertyName("mlad");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)gClass.int_0);
			jsonWriter_0.WritePropertyName("lsl");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)gClass.bool_2);
			jsonWriter_0.WritePropertyName("sle");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)gClass.string_0);
			jsonWriter_0.WriteEndObject();
		}

		public override object ReadJson(JsonReader jsonReader_0, Type type_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			JObject val = JObject.Load(jsonReader_0);
			GClass8 gClass = new GClass8();
			JToken val2 = default(JToken);
			if (val.TryGetValue("v", out val2))
			{
				gClass.genum17_0 = (GEnum17)(int)val2;
			}
			JToken val3 = default(JToken);
			if (val.TryGetValue("s2f", out val3))
			{
				gClass.bool_0 = (bool)val3;
			}
			JToken val4 = default(JToken);
			if (val.TryGetValue("rol", out val4))
			{
				gClass.bool_1 = (bool)val4;
			}
			JToken val5 = default(JToken);
			if (val.TryGetValue("mlad", out val5))
			{
				gClass.int_0 = (int)val5;
			}
			JToken val6 = default(JToken);
			if (val.TryGetValue("lsl", out val6))
			{
				gClass.bool_2 = (bool)val6;
			}
			JToken val7 = default(JToken);
			if (val.TryGetValue("sle", out val7))
			{
				gClass.string_0 = (string)val7;
			}
			return gClass;
		}

		public override bool CanConvert(Type type_0)
		{
			return typeof(GClass8).IsAssignableFrom(type_0);
		}
	}

	public const string Name = "Logging";

	public GEnum17 genum17_0 = GEnum17.const_1;

	public bool bool_0 = true;

	public bool bool_1 = true;

	public int int_0 = 30;

	public bool bool_2;

	public string string_0 = "LogonType!=10\r\nTargetUserName=ANONYMOUS LOGON\r\nIpAddress=-";

	public bool Boolean_0 => genum17_0 == GEnum17.const_0;

	public bool Boolean_1 => genum17_0 == GEnum17.const_1;

	public bool Boolean_2 => genum17_0 == GEnum17.const_2;

	public string method_0()
	{
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject((object)this)));
	}

	public static GClass8 smethod_0(string string_1)
	{
		if (!string.IsNullOrEmpty(string_1))
		{
			return JsonConvert.DeserializeObject<GClass8>(Encoding.UTF8.GetString(Convert.FromBase64String(string_1)));
		}
		return new GClass8();
	}

	public string method_1()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("Verbosity: " + GClass18.GClass18_0[genum17_0] + "; ");
		stringBuilder.Append($"SaveToFile: {bool_0}; ");
		stringBuilder.Append($"RemoveOldLogs: {bool_1}; ");
		stringBuilder.Append($"MaxLogAgeDays: {int_0}; ");
		stringBuilder.Append($"LogSuccessfulLogins: {bool_2}; ");
		stringBuilder.Append("SuccessfulLoginsExclusions: " + string_0.Replace("\r\n", " OR "));
		return stringBuilder.ToString();
	}
}
