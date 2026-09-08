using System;
using System.Collections.Generic;

public class GClass18 : id<GEnum17>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		internal GClass18 method_0()
		{
			return new GClass18();
		}
	}

	private static readonly Lazy<GClass18> lazy_0 = new Lazy<GClass18>(_003C_003Ec._003C_003E9.method_0);

	public static GClass18 GClass18_0 => lazy_0.Value;

	private GClass18()
		: base(new Dictionary<GEnum17, string>
		{
			{
				GEnum17.const_0,
				"Verbose"
			},
			{
				GEnum17.const_1,
				"Brief"
			},
			{
				GEnum17.const_2,
				"Errors and warnings only"
			}
		}, GEnum17.const_3, (string)null)
	{
	}
}
