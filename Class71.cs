using System;
using System.Linq;
using System.Net.Mail;

internal static class Class71
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<string, bool> _003C_003E9__0_0;

		internal bool method_0(string string_0)
		{
			return string_0 == new MailAddress(string_0).Address;
		}
	}

	public static bool smethod_0(string string_0)
	{
		try
		{
			string[] source = string_0.smethod_7();
			Func<string, bool> predicate = _003C_003Ec._003C_003E9.method_0;
			return source.All(predicate);
		}
		catch
		{
			return false;
		}
	}
}
