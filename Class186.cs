using System;
using System.Collections.Generic;

internal sealed class Class186 : id<GEnum3>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		internal Class186 method_0()
		{
			return new Class186();
		}
	}

	private static readonly Lazy<Class186> lazy_0 = new Lazy<Class186>(_003C_003Ec._003C_003E9.method_0);

	internal static Class186 Class186_0 => lazy_0.Value;

	private Class186()
		: base(new Dictionary<GEnum3, string>
		{
			{
				GEnum3.const_0,
				"Send E-mail"
			},
			{
				GEnum3.const_1,
				"Send HTTP POST"
			},
			{
				GEnum3.const_2,
				"Execute program"
			},
			{
				GEnum3.const_3,
				"Report to AbuseIPDB"
			},
			{
				GEnum3.const_4,
				"Send Telegram message"
			}
		}, GEnum3.const_5, (string)null)
	{
	}
}
