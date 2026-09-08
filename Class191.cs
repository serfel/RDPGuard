using System;
using System.Collections.Generic;

internal sealed class Class191 : id<GEnum7>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		internal Class191 method_0()
		{
			return new Class191();
		}
	}

	private static readonly Lazy<Class191> lazy_0 = new Lazy<Class191>(_003C_003Ec._003C_003E9.method_0);

	public static Class191 Class191_0 => lazy_0.Value;

	private Class191()
		: base(new Dictionary<GEnum7, string>
		{
			{
				GEnum7.const_0,
				"Microsoft IIS"
			},
			{
				GEnum7.const_1,
				"FileZilla"
			},
			{
				GEnum7.const_2,
				"Axigen Mail Server (FTP-BACKUP)"
			},
			{
				GEnum7.const_3,
				"SolarWinds SFTP/SCP"
			},
			{
				GEnum7.const_4,
				"Serv-U"
			}
		}, GEnum7.const_5, (string)null)
	{
	}
}
