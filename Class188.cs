using System;
using System.Collections.Generic;

internal sealed class Class188 : id<int>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		internal Class188 method_0()
		{
			return new Class188();
		}
	}

	private static readonly Lazy<Class188> lazy_0 = new Lazy<Class188>(_003C_003Ec._003C_003E9.method_0);

	public static Class188 Class188_0 => lazy_0.Value;

	private Class188()
		: base(new Dictionary<int, string>
		{
			{ 0, "RdpSettings" },
			{ 1, "RdWebSettings" },
			{ 2, "MsSqlSettings" },
			{ 3, "FtpSettings" },
			{ 4, "HttpSettings" },
			{ 5, "SmtpSettings" },
			{ 6, "ImapSettings" },
			{ 7, "Pop3Settings" },
			{ 8, "MySqlSettings" },
			{ 9, "WebFormsSettings" },
			{ 10, "SipSettings" },
			{ 11, "OpenSshSettings" },
			{ 12, "MsVpnSettings" }
		}, -1, (string)null)
	{
	}
}
