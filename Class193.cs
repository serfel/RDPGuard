using System;
using System.Collections.Generic;

internal sealed class Class193 : id<GEnum9>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		internal Class193 method_0()
		{
			return new Class193();
		}
	}

	private static readonly Lazy<Class193> lazy_0 = new Lazy<Class193>(_003C_003Ec._003C_003E9.method_0);

	public static Class193 Class193_0 => lazy_0.Value;

	private Class193()
		: base(new Dictionary<GEnum9, string>
		{
			{
				GEnum9.const_0,
				"General"
			},
			{
				GEnum9.const_1,
				"Application"
			}
		}, GEnum9.const_2, (string)null)
	{
	}
}
