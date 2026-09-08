using System.Collections.Generic;
using System.Linq;

public class ic<T, U>
{
	protected readonly Dictionary<T, U> dictionary_0;

	protected readonly T gparam_0;

	protected readonly U gparam_1;

	public T[] Prop_0 => dictionary_0.Keys.ToArray();

	public U[] Prop_1 => dictionary_0.Values.ToArray();

	public U this[T _type] => ToT(_type);

	public T this[U gparam_2] => FromT(gparam_2);

	public ic(Dictionary<T, U> dictionary_1, T gparam_2, U gparam_3)
	{
		dictionary_0 = dictionary_1;
		gparam_0 = gparam_2;
		gparam_1 = gparam_3;
	}

	public virtual U ToT(T gparam_2)
	{
		if (!dictionary_0.ContainsKey(gparam_2))
		{
			return gparam_1;
		}
		return dictionary_0[gparam_2];
	}

	public virtual T FromT(U gparam_2)
	{
		using (Dictionary<T, U>.Enumerator enumerator = dictionary_0.GetEnumerator())
		{
			while (enumerator.MoveNext() ? true : false)
			{
				KeyValuePair<T, U> current = enumerator.Current;
				if (current.Value.Equals(gparam_2))
				{
					return current.Key;
				}
			}
		}
		return gparam_0;
	}
}
