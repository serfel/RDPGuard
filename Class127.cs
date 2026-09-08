using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

[JsonConverter(typeof(Class128))]
internal sealed class Class127
{
	private class Class128 : JsonConverter
	{
		public override void WriteJson(JsonWriter jsonWriter_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			Class127 @class = (Class127)object_0;
			jsonWriter_0.WriteStartObject();
			jsonWriter_0.WritePropertyName("i");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)@class.string_0);
			jsonWriter_0.WritePropertyName("n");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)@class.Name);
			jsonWriter_0.WritePropertyName("a");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)@class.genum6_0);
			jsonWriter_0.WriteEndObject();
		}

		public override object ReadJson(JsonReader jsonReader_0, Type type_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			JObject val = JObject.Load(jsonReader_0);
			return new Class127
			{
				string_0 = (string)val["i"],
				Name = (string)val["n"],
				genum6_0 = (GEnum6)(int)val["a"]
			};
		}

		public override bool CanConvert(Type type_0)
		{
			return typeof(Class127).IsAssignableFrom(type_0);
		}
	}

	public string string_0 = string.Empty;

	public string Name = string.Empty;

	public GEnum6 genum6_0;

	public static Class127 class127_0 = new Class127();

	public bool Boolean_0
	{
		get
		{
			if (!string.IsNullOrEmpty(string_0))
			{
				return string.IsNullOrEmpty(Name);
			}
			return true;
		}
	}

	public bool Boolean_1 => !genum6_0.HasFlag(GEnum6.flag_3);

	public bool Boolean_2
	{
		get
		{
			if (Boolean_1 && genum6_0.HasFlag(GEnum6.flag_1) && genum6_0.HasFlag(GEnum6.flag_2) && genum6_0.HasFlag(GEnum6.flag_6) && !genum6_0.HasFlag(GEnum6.flag_0))
			{
				return !Name.ToUpperInvariant().smethod_1(new string[2] { "WAN MINIPORT", "VIRTUALBOX" });
			}
			return false;
		}
	}

	public Dictionary<string, object> method_0()
	{
		return new Dictionary<string, object>
		{
			["Id"] = string_0,
			["Name"] = Name,
			["Attributes"] = genum6_0.smethod_0()
		};
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (this == obj)
		{
			return true;
		}
		if (obj.GetType() != GetType())
		{
			return false;
		}
		return method_1((Class127)obj);
	}

	private bool method_1(Class127 class127_1)
	{
		if (string.Equals(string_0, class127_1.string_0))
		{
			return string.Equals(Name, class127_1.Name);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return ((0x50C5D1F ^ ((string_0 != null) ? string_0.GetHashCode() : 0)) * 16777619) ^ ((Name != null) ? Name.GetHashCode() : 0);
	}
}
