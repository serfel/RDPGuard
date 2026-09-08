using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class GClass26
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<object, string> _003C_003E9__13_0;

		internal string method_0(object object_0)
		{
			return object_0.ToString();
		}
	}

	[Serializable]
	private sealed class _003C_003Ec__19<T>
	{
		public static readonly _003C_003Ec__19<T> _003C_003E9 = new _003C_003Ec__19<T>();

		public static Func<string, int> _003C_003E9__19_0;

		internal int method_0(string string_0)
		{
			return string_0.Length;
		}
	}

	private sealed class a<T, U>
	{
		public T gparam_0;

		internal bool method_0(T gparam_1)
		{
			return gparam_1.ToString().ToLowerInvariant() == gparam_0.ToString().ToLowerInvariant();
		}
	}

	private sealed class b<T, U>
	{
		public T gparam_0;

		internal bool method_0(T gparam_1)
		{
			return gparam_1.ToString().ToLowerInvariant() == gparam_0.ToString().ToLowerInvariant();
		}
	}

	private sealed class c<T, U>
	{
		public T gparam_0;

		internal bool method_0(T gparam_1)
		{
			return gparam_1.ToString().ToLowerInvariant() == gparam_0.ToString().ToLowerInvariant();
		}
	}

	private sealed class d<T, U>
	{
		public T gparam_0;

		internal bool method_0(T gparam_1)
		{
			return gparam_1.ToString().ToLowerInvariant() == gparam_0.ToString().ToLowerInvariant();
		}
	}

	private sealed class e<T, U>
	{
		public T gparam_0;

		internal bool method_0(T gparam_1)
		{
			return gparam_1.ToString().ToLowerInvariant() == gparam_0.ToString().ToLowerInvariant();
		}
	}

	public static string smethod_0<T, U>(this Dictionary<T, U> dictionary_0, T gparam_0, string string_0)
	{
		if (dictionary_0.ContainsKey(gparam_0) && dictionary_0[gparam_0] != null)
		{
			return dictionary_0[gparam_0].ToString();
		}
		return string_0;
	}

	public static string smethod_1<T, U>(this Dictionary<T, U> dictionary_0, T gparam_0)
	{
		return dictionary_0.smethod_0(gparam_0, string.Empty);
	}

	public static bool smethod_2(this Dictionary<string, object> dictionary_0, string string_0, bool bool_0)
	{
		if (dictionary_0.ContainsKey(string_0) && dictionary_0[string_0] != null)
		{
			return bool.Parse(dictionary_0[string_0].ToString());
		}
		return bool_0;
	}

	public static bool smethod_3(this Dictionary<string, object> dictionary_0, string string_0)
	{
		return dictionary_0.smethod_2(string_0, bool_0: false);
	}

	public static bool smethod_4(this Dictionary<string, object> dictionary_0, string string_0)
	{
		return dictionary_0.smethod_2(string_0, bool_0: true);
	}

	public static long smethod_5(this Dictionary<string, object> dictionary_0, string string_0, long long_0)
	{
		if (dictionary_0.ContainsKey(string_0) && dictionary_0[string_0] != null)
		{
			return long.Parse(dictionary_0[string_0].ToString());
		}
		return long_0;
	}

	public static long smethod_6(this Dictionary<string, object> dictionary_0, string string_0)
	{
		return dictionary_0.smethod_5(string_0, 0L);
	}

	public static int smethod_7(this Dictionary<string, object> dictionary_0, string string_0, int int_0)
	{
		if (dictionary_0.ContainsKey(string_0) && dictionary_0[string_0] != null)
		{
			return int.Parse(dictionary_0[string_0].ToString());
		}
		return int_0;
	}

	public static int smethod_8(this Dictionary<string, object> dictionary_0, string string_0)
	{
		return dictionary_0.smethod_7(string_0, 0);
	}

	public static decimal smethod_9(this Dictionary<string, object> dictionary_0, string string_0, decimal decimal_0)
	{
		if (dictionary_0.ContainsKey(string_0) && dictionary_0[string_0] != null)
		{
			return decimal.Parse(dictionary_0[string_0].ToString());
		}
		return decimal_0;
	}

	public static decimal smethod_10(this Dictionary<string, object> dictionary_0, string string_0)
	{
		return dictionary_0.smethod_9(string_0, 0m);
	}

	public static Dictionary<string, object> smethod_11(this Dictionary<string, object> dictionary_0, string string_0)
	{
		if (dictionary_0.ContainsKey(string_0) && dictionary_0[string_0] != null)
		{
			return (Dictionary<string, object>)dictionary_0[string_0];
		}
		return new Dictionary<string, object>();
	}

	public static Dictionary<string, object>[] smethod_12(this Dictionary<string, object> dictionary_0, string string_0)
	{
		if (dictionary_0.ContainsKey(string_0) && dictionary_0[string_0] is object[])
		{
			return (dictionary_0[string_0] as object[]).Cast<Dictionary<string, object>>().ToArray();
		}
		return new Dictionary<string, object>[0];
	}

	public static string[] smethod_13(this Dictionary<string, object> dictionary_0, string string_0)
	{
		if (dictionary_0.ContainsKey(string_0) && dictionary_0[string_0] is object[])
		{
			object[] source = dictionary_0[string_0] as object[];
			Func<object, string> selector = _003C_003Ec._003C_003E9.method_0;
			return source.Select(selector).ToArray();
		}
		return new string[0];
	}

	public static void smethod_14<T, U>(this IDictionary<T, U> idictionary_0, T gparam_0, U gparam_1)
	{
		a<T, U> a2 = new a<T, U>();
		a2.gparam_0 = gparam_0;
		T val = idictionary_0.Keys.FirstOrDefault(a2.method_0);
		if (!EqualityComparer<T>.Default.Equals(val, default(T)))
		{
			idictionary_0[val] = gparam_1;
		}
		else
		{
			idictionary_0.Add(a2.gparam_0, gparam_1);
		}
	}

	public static bool smethod_15<T, U>(this IDictionary<T, U> idictionary_0, T gparam_0)
	{
		b<T, U> b2 = new b<T, U>();
		b2.gparam_0 = gparam_0;
		T x = idictionary_0.Keys.FirstOrDefault(b2.method_0);
		return !EqualityComparer<T>.Default.Equals(x, default(T));
	}

	public static U smethod_16<T, U>(this IDictionary<T, U> idictionary_0, T gparam_0)
	{
		c<T, U> c2 = new c<T, U>();
		c2.gparam_0 = gparam_0;
		T val = idictionary_0.Keys.FirstOrDefault(c2.method_0);
		if (EqualityComparer<T>.Default.Equals(val, default(T)) ? true : false)
		{
			throw new KeyNotFoundException($"Key '{c2.gparam_0}' was not found in the dictionary.");
		}
		return idictionary_0[val];
	}

	public static bool smethod_17<T, U>(this IDictionary<T, U> idictionary_0, T gparam_0, out U gparam_1)
	{
		d<T, U> d2 = new d<T, U>();
		d2.gparam_0 = gparam_0;
		T val = idictionary_0.Keys.FirstOrDefault(d2.method_0);
		if (!EqualityComparer<T>.Default.Equals(val, default(T)))
		{
			gparam_1 = idictionary_0[val];
			return true;
		}
		gparam_1 = default(U);
		return false;
	}

	public static bool smethod_18<T, U>(this IDictionary<T, U> idictionary_0, T gparam_0)
	{
		e<T, U> e2 = new e<T, U>();
		e2.gparam_0 = gparam_0;
		T val = idictionary_0.Keys.FirstOrDefault(e2.method_0);
		if (!EqualityComparer<T>.Default.Equals(val, default(T)))
		{
			return idictionary_0.Remove(val);
		}
		return false;
	}

	public static string smethod_19<T>(this IDictionary<string, T> idictionary_0, int int_0 = 0, bool bool_0 = false, string string_0 = ":", string string_1 = null, bool bool_1 = false)
	{
		if (idictionary_0 != null && ((idictionary_0.Count != 0) ? true : false))
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (int_0 == 0)
			{
				stringBuilder.AppendLine();
			}
			ICollection<string> keys = idictionary_0.Keys;
			Func<string, int> selector = _003C_003Ec__19<T>._003C_003E9.method_0;
			int totalWidth = keys.Max(selector);
			string text = ((string.IsNullOrEmpty(string_1) ? true : false) ? string.Empty : ("[color:" + string_1 + "]"));
			string text2 = ((string.IsNullOrEmpty(string_1) ? true : false) ? string.Empty : "[/color]");
			using (IEnumerator<string> enumerator = idictionary_0.Keys.GetEnumerator())
			{
				while (enumerator.MoveNext() ? true : false)
				{
					string current = enumerator.Current;
					stringBuilder.Append(text + new string(' ', int_0) + ((bool_0 ? true : false) ? current.PadRight(totalWidth) : current) + text2 + string_0 + " ");
					if (idictionary_0[current] is IDictionary<string, object> idictionary_1)
					{
						stringBuilder.Append("\r\n" + idictionary_1.smethod_19(int_0 + 2) + "\r\n");
					}
					else if (idictionary_0[current] is IDictionary<string, string> idictionary_2)
					{
						stringBuilder.Append("\r\n" + idictionary_2.smethod_19(int_0 + 2) + "\r\n");
					}
					else if (idictionary_0[current] is IEnumerable<T> values)
					{
						stringBuilder.AppendLine(string.Join(", ", values));
					}
					else
					{
						stringBuilder.AppendLine(idictionary_0[current]?.ToString());
					}
					if (bool_1)
					{
						stringBuilder.AppendLine();
					}
				}
			}
			return stringBuilder.ToString().TrimEnd('\r', '\n');
		}
		return string.Empty;
	}
}
