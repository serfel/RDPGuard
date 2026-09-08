using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using rdpguard.lib;

[JsonConverter(typeof(Class134))]
public class GClass7
{
	private class Class134 : JsonConverter
	{
		public override void WriteJson(JsonWriter jsonWriter_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			GClass7 gClass = (GClass7)object_0;
			jsonWriter_0.WriteStartObject();
			jsonWriter_0.WritePropertyName("m");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)(int)gClass.portsMode_0);
			jsonWriter_0.WritePropertyName("p");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)gClass.ushort_0);
			jsonWriter_0.WriteEndObject();
		}

		public override object ReadJson(JsonReader jsonReader_0, Type type_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			JObject val = JObject.Load(jsonReader_0);
			GClass7 gClass = new GClass7();
			JToken val2 = default(JToken);
			if (val.TryGetValue("m", out val2))
			{
				gClass.portsMode_0 = (PortsMode)(int)val2;
			}
			JToken val3 = default(JToken);
			if (val.TryGetValue("p", out val3))
			{
				gClass.ushort_0 = val3.ToObject<ushort[]>();
			}
			return gClass;
		}

		public override bool CanConvert(Type type_0)
		{
			return typeof(GClass7).IsAssignableFrom(type_0);
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<ushort, ushort> _003C_003E9__6_0;

		public static Func<ushort, ushort> _003C_003E9__6_1;

		public static Func<ushort, int> _003C_003E9__7_0;

		internal ushort method_0(ushort ushort_0)
		{
			return ushort_0;
		}

		internal ushort method_1(ushort ushort_0)
		{
			return ushort_0;
		}

		internal int method_2(ushort ushort_0)
		{
			return ushort_0.GetHashCode();
		}
	}

	public PortsMode portsMode_0;

	public ushort[] ushort_0 = new ushort[0];

	public bool Boolean_0
	{
		get
		{
			if (portsMode_0 != PortsMode.AllPorts)
			{
				return !ushort_0.IsNullOrEmpty();
			}
			return true;
		}
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
		return method_1((GClass7)obj);
	}

	public bool method_0(GClass7 gclass7_0)
	{
		if ((object)gclass7_0 == null)
		{
			return false;
		}
		if ((object)this == gclass7_0)
		{
			return true;
		}
		return method_1(gclass7_0);
	}

	private bool method_1(GClass7 gclass7_0)
	{
		if (portsMode_0 == gclass7_0.portsMode_0)
		{
			ushort[] array = ushort_0;
			if (array == null)
			{
				array = new ushort[0];
			}
			Func<ushort, ushort> keySelector = _003C_003Ec._003C_003E9.method_0;
			IOrderedEnumerable<ushort> first = array.OrderBy(keySelector);
			ushort[] array2 = gclass7_0.ushort_0;
			if (array2 == null)
			{
				array2 = new ushort[0];
			}
			Func<ushort, ushort> keySelector2 = _003C_003Ec._003C_003E9.method_1;
			return first.SequenceEqual(array2.OrderBy(keySelector2));
		}
		return false;
	}

	public override int GetHashCode()
	{
		int num = (0x50C5D1F ^ portsMode_0.GetHashCode()) * 16777619;
		int num2;
		if (ushort_0 != null)
		{
			ushort[] source = ushort_0;
			Func<ushort, int> selector = _003C_003Ec._003C_003E9.method_2;
			num2 = source.Sum(selector);
		}
		else
		{
			num2 = 0;
		}
		return num ^ num2;
	}

	public static bool operator ==(GClass7 _set1, GClass7 _set2)
	{
		return _set1?.method_0(_set2) ?? ((object)_set2 == null);
	}

	public static bool operator !=(GClass7 _set1, GClass7 _set2)
	{
		return !(_set1 == _set2);
	}
}
