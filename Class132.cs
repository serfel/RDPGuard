using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using rdpguard.lib;

[JsonConverter(typeof(Class133))]
internal sealed class Class132
{
	private class Class133 : JsonConverter
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

			public static Func<GClass5, Dictionary<string, object>> _003C_003E9__0_0;

			public static Func<JObject, GClass5> _003C_003E9__1_0;

			internal Dictionary<string, object> method_0(GClass5 gclass5_0)
			{
				return gclass5_0.method_0();
			}

			internal GClass5 method_1(JObject jobject_0)
			{
				return GClass5.smethod_0(jobject_0);
			}
		}

		public override void WriteJson(JsonWriter jsonWriter_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			Class132 @class = (Class132)object_0;
			jsonWriter_0.WriteStartObject();
			jsonWriter_0.WritePropertyName("e");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)@class.bool_0);
			jsonWriter_0.WritePropertyName("m");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)(int)@class.geoIPMode_0);
			jsonWriter_0.WritePropertyName("dv");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)(int)@class.geoIPDBVersion_0);
			jsonWriter_0.WritePropertyName("dr");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)@class.bool_1);
			jsonWriter_0.WritePropertyName("drra");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)@class.bool_2);
			jsonWriter_0.WritePropertyName("c");
			GClass5[] gclass5_ = @class.gclass5_0;
			Func<GClass5, Dictionary<string, object>> selector = _003C_003Ec._003C_003E9.method_0;
			jsonSerializer_0.Serialize(jsonWriter_0, (object)gclass5_.Select(selector));
			jsonWriter_0.WritePropertyName("al");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)@class.iplistEntry_0);
			jsonWriter_0.WritePropertyName("dps");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)@class.gclass7_0);
			jsonWriter_0.WritePropertyName("aps");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)@class.gclass7_1);
			jsonWriter_0.WritePropertyName("adps");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)@class.gclass7_2);
			jsonWriter_0.WritePropertyName("alc");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)@class.bool_3);
			jsonWriter_0.WritePropertyName("allc");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)@class.bool_4);
			jsonWriter_0.WritePropertyName("evat");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)@class.bool_5);
			jsonWriter_0.WritePropertyName("edc");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)@class.bool_6);
			jsonWriter_0.WriteEndObject();
		}

		public override object ReadJson(JsonReader jsonReader_0, Type type_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			JObject val = JObject.Load(jsonReader_0);
			Class132 @class = new Class132();
			JToken val2 = default(JToken);
			if (val.TryGetValue("e", out val2))
			{
				@class.bool_0 = (bool)val2;
			}
			JToken val3 = default(JToken);
			if (val.TryGetValue("m", out val3))
			{
				@class.geoIPMode_0 = (GeoIPMode)(int)val3;
			}
			JToken val4 = default(JToken);
			if (val.TryGetValue("dv", out val4))
			{
				@class.geoIPDBVersion_0 = (GeoIPDBVersion)(int)val4;
			}
			JToken val5 = default(JToken);
			if (val.TryGetValue("dr", out val5))
			{
				@class.bool_1 = (bool)val5;
			}
			JToken val6 = default(JToken);
			if (val.TryGetValue("drra", out val6))
			{
				@class.bool_2 = (bool)val6;
			}
			JToken val7 = default(JToken);
			if (val.TryGetValue("c", out val7))
			{
				JObject[] source = val7.ToObject<JObject[]>();
				Func<JObject, GClass5> selector = _003C_003Ec._003C_003E9.method_1;
				@class.gclass5_0 = source.Select(selector).ToArray();
			}
			JToken val8 = default(JToken);
			if (val.TryGetValue("al", out val8))
			{
				@class.iplistEntry_0 = val8.ToObject<IPListEntry[]>();
			}
			JToken val9 = default(JToken);
			if (val.TryGetValue("dps", out val9))
			{
				@class.gclass7_0 = val9.ToObject<GClass7>();
			}
			JToken val10 = default(JToken);
			if (val.TryGetValue("aps", out val10))
			{
				@class.gclass7_1 = val10.ToObject<GClass7>();
			}
			JToken val11 = default(JToken);
			if (val.TryGetValue("adps", out val11))
			{
				@class.gclass7_2 = val11.ToObject<GClass7>();
			}
			JToken val12 = default(JToken);
			if (val.TryGetValue("alc", out val12))
			{
				@class.bool_3 = (bool)val12;
			}
			JToken val13 = default(JToken);
			if (val.TryGetValue("allc", out val13))
			{
				@class.bool_4 = (bool)val13;
			}
			JToken val14 = default(JToken);
			if (val.TryGetValue("evat", out val14))
			{
				@class.bool_5 = (bool)val14;
			}
			JToken val15 = default(JToken);
			if (val.TryGetValue("edc", out val15))
			{
				@class.bool_6 = (bool)val15;
			}
			return @class;
		}

		public override bool CanConvert(Type type_0)
		{
			return typeof(Class132).IsAssignableFrom(type_0);
		}
	}

	public const string Name = "GeoIPSettings";

	public bool bool_0;

	public GeoIPMode geoIPMode_0;

	public GeoIPDBVersion geoIPDBVersion_0;

	public bool bool_1 = true;

	public bool bool_2;

	public GClass5[] gclass5_0 = new GClass5[0];

	public IPListEntry[] iplistEntry_0 = new IPListEntry[0];

	public GClass7 gclass7_0 = new GClass7();

	public GClass7 gclass7_1 = new GClass7();

	public GClass7 gclass7_2 = new GClass7();

	public bool bool_3 = true;

	public bool bool_4 = true;

	public bool bool_5;

	public bool bool_6;

	public string method_0()
	{
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject((object)this)));
	}

	public static Class132 smethod_0(string string_0)
	{
		if (!string.IsNullOrEmpty(string_0))
		{
			return JsonConvert.DeserializeObject<Class132>(Encoding.UTF8.GetString(Convert.FromBase64String(string_0)));
		}
		return new Class132();
	}
}
