using System;
using System.Collections.Generic;

internal sealed class Class184 : id<int>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		internal Class184 method_0()
		{
			return new Class184();
		}
	}

	private static readonly Lazy<Class184> lazy_0 = new Lazy<Class184>(_003C_003Ec._003C_003E9.method_0);

	public static Class184 Class184_0 => lazy_0.Value;

	public Class184()
		: base(new Dictionary<int, string>
		{
			{ 0, "Light" },
			{ 1, "Dark" },
			{ 2, "System" }
		}, -1, (string)null)
	{
	}
}
