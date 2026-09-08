using System;
using System.Collections.Generic;
using System.Linq;

public class id<T> : ic<T, string>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<string, string> _003C_003E9__5_0;

		internal string method_0(string string_0)
		{
			return string_0.ToLower();
		}
	}

	public const string string_0 = "Unknown";

	public bool bool_0;

	public bool bool_1 = true;

	public string String_0
	{
		get
		{
			Dictionary<T, string>.ValueCollection values = dictionary_0.Values;
			Func<string, string> selector = _003C_003Ec._003C_003E9.method_0;
			return string.Join(", ", values.Select(selector));
		}
	}

	private static string objc(string string_1)
	{
		object obj = string_1;
		if (obj == null)
		{
			obj = "Unknown";
		}
		return (string)obj;
	}

	public id(Dictionary<T, string> dictionary_1, T gparam_2, string string_1 = null)
		: base(dictionary_1, gparam_2, objc(string_1))
	{
	}

	public override string ToT(T gparam_2)
	{
		if (!dictionary_0.ContainsKey(gparam_2) && bool_0)
		{
			throw new Exception($"EnumToStringConverter::ToT::unknown_value: {gparam_2}");
		}
		return base.ToT(gparam_2);
	}

	public override T FromT(string string_1)
	{
		if (!bool_1)
		{
			return base.FromT(string_1);
		}
		using (Dictionary<T, string>.Enumerator enumerator = dictionary_0.GetEnumerator())
		{
			while (enumerator.MoveNext() ? true : false)
			{
				KeyValuePair<T, string> current = enumerator.Current;
				if (current.Value.Equals(string_1, StringComparison.InvariantCultureIgnoreCase))
				{
					return current.Key;
				}
			}
		}
		if (bool_0)
		{
			throw new Exception("EnumToStringConverter::FromT::unknown_value: " + string_1);
		}
		return gparam_0;
	}
}
