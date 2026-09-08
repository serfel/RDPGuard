using System;

internal static class Class168
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static hh<ushort>.Delegate1 _003C_003E9__3_0;

		public static hh<ushort>.Delegate2 _003C_003E9__3_1;

		internal bool method_0(string string_0, out ushort ushort_0)
		{
			return ushort.TryParse(string_0, out ushort_0);
		}

		internal bool method_1(ushort ushort_0)
		{
			return ushort_0 != 0;
		}
	}

	private static readonly hh<ushort> hh_0 = new hh<ushort>();

	public static string smethod_0(ushort[] ushort_0)
	{
		return hh_0.method_0(ushort_0);
	}

	public static ushort[] smethod_1(string string_0, ushort[] ushort_0 = null)
	{
		hh<ushort> hh2 = hh_0;
		hh<ushort>.Delegate1 delegate1_ = _003C_003Ec._003C_003E9.method_0;
		hh<ushort>.Delegate2 delegate2_ = _003C_003Ec._003C_003E9.method_1;
		return hh2.method_1(string_0, ushort_0, delegate1_, delegate2_);
	}
}
