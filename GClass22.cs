using System;
using System.Collections.Generic;
using System.Linq;

public static class GClass22
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<char, bool> _003C_003E9__17_0;

		internal bool method_0(char char_0)
		{
			if (!char.IsLetterOrDigit(char_0) && '@' != char_0 && '-' != char_0 && '$' != char_0 && '<' != char_0 && '>' != char_0 && '/' != char_0 && '.' != char_0 && ':' != char_0 && ',' != char_0 && '=' != char_0 && '*' != char_0 && '(' != char_0 && ')' != char_0)
			{
				return ' ' == char_0;
			}
			return true;
		}
	}

	private sealed class Class197
	{
		public bool bool_0;

		internal string method_0(string string_0)
		{
			if (!bool_0)
			{
				return string_0;
			}
			return string_0.Trim();
		}
	}

	private sealed class Class198
	{
		public bool bool_0;

		internal string method_0(string string_0)
		{
			if (!bool_0)
			{
				return string_0;
			}
			return string_0.Trim();
		}
	}

	private sealed class Class199
	{
		public string string_0;

		internal bool method_0(string string_1)
		{
			return string_0.Contains(string_1);
		}
	}

	private sealed class Class200
	{
		public string string_0;

		internal bool method_0(string string_1)
		{
			return string_0.StartsWith(string_1);
		}
	}

	private sealed class Class201
	{
		public string string_0;

		internal bool method_0(string string_1)
		{
			return string_0.EndsWith(string_1);
		}
	}

	public static string smethod_0(this string string_0)
	{
		return char.ToUpper(string_0[0]) + string_0.Substring(1);
	}

	public static bool smethod_1(this string string_0, string[] string_1)
	{
		Class199 @class = new Class199();
		@class.string_0 = string_0;
		return string_1.Any(@class.method_0);
	}

	public static bool smethod_2(this string string_0, string[] string_1)
	{
		Class200 @class = new Class200();
		@class.string_0 = string_0;
		return string_1.Any(@class.method_0);
	}

	public static bool smethod_3(this string string_0, string[] string_1)
	{
		Class201 @class = new Class201();
		@class.string_0 = string_0;
		return string_1.Any(@class.method_0);
	}

	public static string[] smethod_4(this string string_0)
	{
		return string_0.smethod_12(new char[2] { '\r', '\n' });
	}

	public static string[] smethod_5(this string string_0)
	{
		return string_0.smethod_13(' ');
	}

	public static string[] smethod_6(this string string_0)
	{
		return string_0.smethod_12(new char[3] { '\r', '\n', ' ' });
	}

	public static string[] smethod_7(this string string_0)
	{
		return string_0.smethod_13(',');
	}

	public static string[] smethod_8(this string string_0)
	{
		return string_0.smethod_12(new char[2] { ',', ' ' });
	}

	public static string[] smethod_9(this string string_0)
	{
		return string_0.smethod_13(':');
	}

	public static string[] smethod_10(this string string_0)
	{
		return string_0.smethod_13(';');
	}

	public static string[] smethod_11(this string string_0)
	{
		return string_0.smethod_13('.');
	}

	public static string[] smethod_12(this string string_0, char[] char_0, bool bool_0 = true)
	{
		Class197 @class = new Class197();
		@class.bool_0 = bool_0;
		return string_0.Split(char_0, StringSplitOptions.RemoveEmptyEntries).Select(@class.method_0).ToArray();
	}

	public static string[] smethod_13(this string string_0, char char_0)
	{
		return string_0.smethod_12(new char[1] { char_0 });
	}

	public static string[] smethod_14(this string string_0, string[] string_1, bool bool_0 = true)
	{
		Class198 @class = new Class198();
		@class.bool_0 = bool_0;
		return string_0.Split(string_1, StringSplitOptions.RemoveEmptyEntries).Select(@class.method_0).ToArray();
	}

	public static string[] smethod_15(this string string_0, string string_1)
	{
		return string_0.smethod_14(new string[1] { string_1 });
	}

	public static bool smethod_16(this string string_0, string string_1, out KeyValuePair<string, string> keyValuePair_0)
	{
		string[] array = string_0.smethod_14(new string[1] { string_1 });
		if (array.Length != 2)
		{
			keyValuePair_0 = default(KeyValuePair<string, string>);
			return false;
		}
		keyValuePair_0 = new KeyValuePair<string, string>(array[0], array[1]);
		return true;
	}

	public static string smethod_17(this string string_0)
	{
		Func<char, bool> predicate = _003C_003Ec._003C_003E9.method_0;
		return new string(string_0.Where(predicate).ToArray());
	}

	public static string smethod_18(this string string_0)
	{
		return char.ToUpper(string_0[0]) + string_0.Substring(1);
	}

	public static bool smethod_19(this string string_0, string string_1)
	{
		return string.Equals(string_0, string_1, StringComparison.OrdinalIgnoreCase);
	}

	public static bool smethod_20(this string string_0, string string_1)
	{
		return string_0.StartsWith(string_1, StringComparison.OrdinalIgnoreCase);
	}
}
