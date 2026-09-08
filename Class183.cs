using System;
using System.Collections.Generic;
using rdpguard.lib;

internal sealed class Class183 : ic<GeoIPDBVersion, Version>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		internal Class183 method_0()
		{
			return new Class183();
		}
	}

	private static readonly Lazy<Class183> lazy_0 = new Lazy<Class183>(_003C_003Ec._003C_003E9.method_0);

	public static Class183 Class183_0 => lazy_0.Value;

	private Class183()
		: base(new Dictionary<GeoIPDBVersion, Version>
		{
			{
				GeoIPDBVersion.Lite,
				new Version(1, 0, 0)
			},
			{
				GeoIPDBVersion.Max,
				new Version(10, 0, 0)
			}
		}, GeoIPDBVersion.Unknown, new Version(0, 0, 0))
	{
	}
}
