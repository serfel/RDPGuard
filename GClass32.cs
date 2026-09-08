using System;
using System.Linq;
using System.Text;

public static class GClass32
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<string, string> _003C_003E9__3_0;

		internal string method_0(string string_0)
		{
			return Get(string_0);
		}
	}

	public static string String_0 => Get(Guid.NewGuid().ToString());

	public static byte[] smethod_0(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return new byte[0];
		}
		using Class213 @class = new Class213();
		return @class.ComputeHash(Encoding.ASCII.GetBytes(string_0));
	}

	public static byte[] smethod_1(byte[] byte_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			using (Class213 @class = new Class213())
			{
				return @class.ComputeHash(byte_0);
			}
		}
		return new byte[0];
	}

	public static string Get(string _input)
	{
		return Class212.Get(smethod_0(_input));
	}

	public static string[] Get(string[] _input)
	{
		Func<string, string> selector = _003C_003Ec._003C_003E9.method_0;
		return _input.Select(selector).ToArray();
	}

	public static string smethod_2(string string_0)
	{
		return Get(string_0).Substring(0, 8);
	}

	public static bool smethod_3(string string_0)
	{
		return Class212.smethod_1(string_0, 32);
	}
}
