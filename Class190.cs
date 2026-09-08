using System;
using System.Collections.Generic;

internal sealed class Class190 : id<GEnum5>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		internal Class190 method_0()
		{
			return new Class190();
		}
	}

	private static readonly Lazy<Class190> lazy_0 = new Lazy<Class190>(_003C_003Ec._003C_003E9.method_0);

	public static Class190 Class190_0 => lazy_0.Value;

	private Class190()
		: base(new Dictionary<GEnum5, string>
		{
			{
				GEnum5.const_0,
				"RawSockets"
			},
			{
				GEnum5.const_1,
				"WinPcap"
			}
		}, GEnum5.const_2, (string)null)
	{
	}
}
