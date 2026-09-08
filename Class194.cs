using System;
using System.Collections.Generic;

internal sealed class Class194 : id<GEnum10>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		internal Class194 method_0()
		{
			return new Class194();
		}
	}

	private static readonly Lazy<Class194> lazy_0 = new Lazy<Class194>(_003C_003Ec._003C_003E9.method_0);

	public static Class194 Class194_0 => lazy_0.Value;

	private Class194()
		: base(new Dictionary<GEnum10, string>
		{
			{
				GEnum10.const_0,
				"MailEnable"
			},
			{
				GEnum10.const_1,
				"Kerio Connect"
			},
			{
				GEnum10.const_2,
				"hMailServer"
			},
			{
				GEnum10.const_3,
				"MS Exchange"
			},
			{
				GEnum10.const_4,
				"Axigen Mail Server"
			},
			{
				GEnum10.const_5,
				"MDaemon Email Server"
			},
			{
				GEnum10.const_6,
				"SmarterMail"
			}
		}, GEnum10.const_7, (string)null)
	{
	}
}
