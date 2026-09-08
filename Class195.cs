using System;
using System.Collections.Generic;

internal sealed class Class195 : id<GEnum11>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		internal Class195 method_0()
		{
			return new Class195();
		}
	}

	private static readonly Lazy<Class195> lazy_0 = new Lazy<Class195>(_003C_003Ec._003C_003E9.method_0);

	public static Class195 Class195_0 => lazy_0.Value;

	private Class195()
		: base(new Dictionary<GEnum11, string>
		{
			{
				GEnum11.const_0,
				"MailEnable"
			},
			{
				GEnum11.const_1,
				"Kerio Connect"
			},
			{
				GEnum11.const_2,
				"hMailServer"
			},
			{
				GEnum11.const_3,
				"MS Exchange"
			},
			{
				GEnum11.const_4,
				"IBM Domino"
			},
			{
				GEnum11.const_5,
				"Axigen Mail Server"
			},
			{
				GEnum11.const_6,
				"MDaemon Email Server"
			},
			{
				GEnum11.const_7,
				"SmarterMail"
			},
			{
				GEnum11.const_8,
				"E-MailRelay"
			}
		}, GEnum11.const_9, (string)null)
	{
	}
}
