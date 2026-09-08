using System.Collections.Generic;

internal static class Class182
{
	public static GStruct1 smethod_0(this IEnumerable<GStruct1> ienumerable_0)
	{
		GStruct1 result = (byte)0;
		using IEnumerator<GStruct1> enumerator = ienumerable_0.GetEnumerator();
		while (true)
		{
			if (enumerator.MoveNext() ? true : false)
			{
				GStruct1 current = enumerator.Current;
				result += current;
				continue;
			}
			return result;
		}
	}
}
