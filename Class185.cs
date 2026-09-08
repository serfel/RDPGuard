using System;
using System.Collections.Generic;

internal sealed class Class185 : id<GEnum2>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		internal Class185 method_0()
		{
			return new Class185();
		}
	}

	private static readonly Lazy<Class185> lazy_0 = new Lazy<Class185>(_003C_003Ec._003C_003E9.method_0);

	public static Class185 Class185_0 => lazy_0.Value;

	private Class185()
		: base(new Dictionary<GEnum2, string>
		{
			{
				GEnum2.const_0,
				"IP Blocked"
			},
			{
				GEnum2.const_1,
				"IP Unblocked"
			},
			{
				GEnum2.const_2,
				"User Logged In"
			},
			{
				GEnum2.const_3,
				"New Version Available"
			},
			{
				GEnum2.const_4,
				"Maintenance Is About To Expire"
			},
			{
				GEnum2.const_5,
				"Maintenance Expired"
			}
		}, GEnum2.const_6, (string)null)
	{
	}
}
