using System.Collections.Generic;
using System.Linq;

internal sealed class hh<T>
{
	public delegate bool Delegate1(string string_0, out T gparam_0);

	public delegate bool Delegate2(T gparam_0);

	public string method_0(T[] gparam_0)
	{
		return string.Join(", ", gparam_0);
	}

	public T[] method_1(string string_0, T[] gparam_0, Delegate1 delegate1_0, Delegate2 delegate2_0)
	{
		List<T> list = new List<T>();
		string[] array = ((string.IsNullOrEmpty(string_0) ? true : false) ? new string[0] : string_0.smethod_8());
		string[] array2 = array;
		foreach (string string_1 in array2)
		{
			if (delegate1_0(string_1, out var gparam_1) && delegate2_0(gparam_1) && !list.Contains(gparam_1))
			{
				list.Add(gparam_1);
			}
		}
		T[] array3;
		if (!list.Any())
		{
			array3 = gparam_0;
			if (array3 == null)
			{
				return new T[0];
			}
		}
		else
		{
			array3 = list.ToArray();
		}
		return array3;
	}
}
