using System;
using System.Collections.Generic;

internal sealed class Class189 : id<int>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		internal Class189 method_0()
		{
			return new Class189();
		}
	}

	private static readonly Lazy<Class189> lazy_0 = new Lazy<Class189>(_003C_003Ec._003C_003E9.method_0);

	public static Class189 Class189_0 => lazy_0.Value;

	private Class189()
		: base(new Dictionary<int, string>
		{
			{ 0, "RDP" },
			{ 1, "RD-WEB" },
			{ 2, "MS-SQL" },
			{ 3, "FTP" },
			{ 4, "HTTP" },
			{ 5, "SMTP" },
			{ 6, "IMAP" },
			{ 7, "POP3" },
			{ 8, "MySQL" },
			{ 9, "ASP.NET Web Forms" },
			{ 10, "SIP" },
			{ 11, "OpenSSH" },
			{ 12, "MS-VPN" }
		}, -1, (string)null)
	{
	}
}
