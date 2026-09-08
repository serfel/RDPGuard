using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

internal abstract class Class113
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<GClass24, bool> _003C_003E9__22_0;

		public static Func<GClass24, bool> _003C_003E9__23_0;

		internal bool method_0(GClass24 gclass24_0)
		{
			return gclass24_0.Boolean_2;
		}

		internal bool method_1(GClass24 gclass24_0)
		{
			return gclass24_0.Boolean_2;
		}
	}

	public bool bool_0;

	private GEnum4 genum4_0 = GEnum4.const_1;

	private readonly ushort[] ushort_0 = new ushort[0];

	private ushort[] ushort_1;

	public GEnum5 genum5_0;

	public bool bool_1 = true;

	private GClass24[] gclass24_0 = new GClass24[0];

	public Class127 class127_0 = Class127.class127_0;

	public bool bool_2 = true;

	private string[] string_0;

	private static readonly string string_1 = "ee";

	private static readonly string string_2 = "mm";

	private static readonly string string_3 = "p";

	private static readonly string string_4 = "tmm";

	private static readonly string string_5 = "maa";

	private static readonly string string_6 = "aa";

	private static readonly string string_7 = "sa";

	private static readonly string string_8 = "ald";

	private static readonly string string_9 = "l";

	public abstract int Int32_0 { get; }

	public string String_0 => Class189.Class189_0[Int32_0];

	public GEnum4 GEnum4_0
	{
		get
		{
			return genum4_0;
		}
		set
		{
			genum4_0 = value;
		}
	}

	public virtual ushort[] UInt16_1 => ushort_0;

	public ushort[] UInt16_0
	{
		get
		{
			if (!ushort_1.IsNullOrEmpty())
			{
				return ushort_1;
			}
			return UInt16_1;
		}
		set
		{
			ushort_1 = value;
		}
	}

	public GClass24[] GClass24_0
	{
		get
		{
			GClass24[] source = gclass24_0;
			Func<GClass24, bool> predicate = _003C_003Ec._003C_003E9.method_0;
			return source.Where(predicate).ToArray();
		}
		set
		{
			Func<GClass24, bool> predicate = _003C_003Ec._003C_003E9.method_1;
			gclass24_0 = value.Where(predicate).ToArray();
		}
	}

	public string[] String_1
	{
		get
		{
			if (!string_0.IsNullOrEmpty())
			{
				return string_0;
			}
			return new string[1] { string.Empty };
		}
		set
		{
			string_0 = value;
		}
	}

	public string method_0()
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		method_1(dictionary);
		OnFormClosing(dictionary);
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject((object)dictionary)));
	}

	private void method_1(Dictionary<string, object> dictionary_0)
	{
		dictionary_0.Add(string_1, bool_0);
		dictionary_0.Add(string_2, (int)GEnum4_0);
		dictionary_0.Add(string_3, UInt16_0);
		dictionary_0.Add(string_4, (int)genum5_0);
		dictionary_0.Add(string_5, bool_1);
		dictionary_0.Add(string_6, GClass24_0);
		dictionary_0.Add(string_7, class127_0);
		dictionary_0.Add(string_8, bool_2);
		dictionary_0.Add(string_9, String_1);
	}

	public abstract void OnFormClosing(Dictionary<string, object> dictionary_0);

	public static Class113 smethod_0(Type type_0, string string_10)
	{
		Class113 @class = (Class113)Activator.CreateInstance(type_0);
		if (string.IsNullOrEmpty(string_10))
		{
			return @class;
		}
		try
		{
			JObject val = JsonConvert.DeserializeObject<JObject>(Encoding.UTF8.GetString(Convert.FromBase64String(string_10)));
			@class.method_2(val);
			MethodInfo method = type_0.GetMethod("DeserializeEngineSpeificFields", BindingFlags.Instance | BindingFlags.NonPublic);
			object[] array = (object[])(object)new JObject[1] { val };
			object[] parameters = array;
			method.Invoke(@class, parameters);
		}
		catch (Exception arg)
		{
			Class208.smethod_0($"EngineSettings::Deserialize:{arg} for {string_10}");
		}
		return @class;
	}

	private void method_2(JObject jobject_0)
	{
		bool_0 = (bool)jobject_0[string_1];
		GEnum4_0 = (GEnum4)(int)jobject_0[string_2];
		UInt16_0 = jobject_0[string_3].ToObject<ushort[]>();
		genum5_0 = (GEnum5)(int)jobject_0[string_4];
		bool_1 = (bool)jobject_0[string_5];
		GClass24_0 = jobject_0[string_6].ToObject<GClass24[]>();
		class127_0 = jobject_0[string_7].ToObject<Class127>();
		bool_2 = (bool)jobject_0[string_8];
		String_1 = jobject_0[string_9].ToObject<string[]>();
	}

	protected abstract void DeserializeEngineSpeificFields(JObject _jo);

	protected virtual void InitializeFormPosition(StringBuilder stringBuilder_0)
	{
		stringBuilder_0.Append("TrafficMonitoringMethod: " + Class190.Class190_0[genum5_0] + "; ");
		if (genum5_0 == GEnum5.const_0)
		{
			stringBuilder_0.Append($"MonitorAllAddresses: {bool_1}; ");
			if (!bool_1)
			{
				object[] gClass24_ = GClass24_0;
				object[] values = gClass24_;
				stringBuilder_0.Append("AddressesToMonitor: " + string.Join(",", values) + "; ");
			}
		}
		if (GEnum5.const_1 == genum5_0)
		{
			stringBuilder_0.Append("Network Adapter:\r\n" + class127_0.method_0().smethod_19(6) + "; ");
		}
		stringBuilder_0.Append("Ports: " + Class168.smethod_0(UInt16_0) + "; ");
	}
}
