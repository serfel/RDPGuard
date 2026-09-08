using System;
using System.Collections.Generic;

public class GClass17 : id<GEnum16>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		internal GClass17 method_0()
		{
			return new GClass17();
		}
	}

	private static readonly Lazy<GClass17> lazy_0 = new Lazy<GClass17>(_003C_003Ec._003C_003E9.method_0);

	public static GEnum16[] genum16_0 = new GEnum16[2]
	{
		GEnum16.const_4,
		GEnum16.const_2
	};

	public static GClass17 GClass17_0 => lazy_0.Value;

	private GClass17()
		: base(new Dictionary<GEnum16, string>
		{
			{
				GEnum16.const_0,
				"Local"
			},
			{
				GEnum16.const_1,
				"Cloud"
			},
			{
				GEnum16.const_2,
				"GeoIP"
			},
			{
				GEnum16.const_3,
				"All"
			},
			{
				GEnum16.const_4,
				"Blacklist"
			}
		}, GEnum16.const_5, (string)null)
	{
	}
}
