using System;
using System.Collections.Generic;

internal sealed class Class192 : id<GEnum8>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		internal Class192 method_0()
		{
			return new Class192();
		}
	}

	private static readonly Lazy<Class192> lazy_0 = new Lazy<Class192>(_003C_003Ec._003C_003E9.method_0);

	public static Class192 Class192_0 => lazy_0.Value;

	private Class192()
		: base(new Dictionary<GEnum8, string>
		{
			{
				GEnum8.const_0,
				"MailEnable"
			},
			{
				GEnum8.const_1,
				"Kerio Connect"
			},
			{
				GEnum8.const_2,
				"hMailServer"
			},
			{
				GEnum8.const_3,
				"MS Exchange"
			},
			{
				GEnum8.const_4,
				"Axigen Mail Server"
			},
			{
				GEnum8.const_5,
				"MDaemon Email Server"
			},
			{
				GEnum8.const_6,
				"SmarterMail"
			}
		}, GEnum8.const_7, (string)null)
	{
	}
}
