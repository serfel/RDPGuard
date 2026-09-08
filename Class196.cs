using System;
using System.Collections.Generic;

internal sealed class Class196 : id<GEnum12>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		internal Class196 method_0()
		{
			return new Class196();
		}
	}

	private static readonly Lazy<Class196> lazy_0 = new Lazy<Class196>(_003C_003Ec._003C_003E9.method_0);

	public static Class196 Class196_0 => lazy_0.Value;

	private Class196()
		: base(new Dictionary<GEnum12, string>
		{
			{
				GEnum12.const_0,
				"I"
			},
			{
				GEnum12.const_1,
				"V"
			},
			{
				GEnum12.const_2,
				"W"
			},
			{
				GEnum12.const_3,
				"E"
			}
		}, GEnum12.const_4, (string)null)
	{
	}
}
