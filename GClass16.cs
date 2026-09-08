using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

public static class GClass16
{
	private sealed class a<T> : IEnumerable<IEnumerable<T>>, IEnumerable, IEnumerator<IEnumerable<T>>, IDisposable, IEnumerator
	{
		private int int_0;

		private IEnumerable<T> ienumerable_0;

		private int int_1;

		private IEnumerable<T> ienumerable_1;

		public IEnumerable<T> ienumerable_2;

		private int int_2;

		public int int_3;

		private int int_4;

		private int int_5;

		IEnumerable<T> IEnumerator<IEnumerable<T>>.Current => ienumerable_0;

		object IEnumerator.Current => ienumerable_0;

		public a(int int_6)
		{
			int_0 = int_6;
			int_1 = Environment.CurrentManagedThreadId;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			switch (int_0)
			{
			default:
				return false;
			case 1:
				int_0 = -1;
				int_5++;
				break;
			case 0:
				int_0 = -1;
				int_4 = ienumerable_1.Count() / int_2;
				if (ienumerable_1.Count() % int_2 > 0)
				{
					int_4++;
				}
				int_5 = 0;
				break;
			}
			if (int_5 >= int_4)
			{
				return false;
			}
			ienumerable_0 = ienumerable_1.Skip(int_5 * int_2).Take(int_2);
			int_0 = 1;
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			return MoveNext();
		}

		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		IEnumerator<IEnumerable<T>> IEnumerable<IEnumerable<T>>.GetEnumerator()
		{
			a<T> a2;
			if (int_0 == -2 && int_1 == Environment.CurrentManagedThreadId)
			{
				int_0 = 0;
				a2 = this;
			}
			else
			{
				a2 = new a<T>(0);
			}
			a2.ienumerable_1 = ienumerable_2;
			a2.int_2 = int_3;
			return a2;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<IEnumerable<T>>)this).GetEnumerator();
		}
	}

	public static void smethod_0<T>(this IEnumerable<T> ienumerable_0, Action<T> action_0)
	{
		using IEnumerator<T> enumerator = ienumerable_0.GetEnumerator();
		while (enumerator.MoveNext() ? true : false)
		{
			T current = enumerator.Current;
			action_0(current);
		}
	}

	[IteratorStateMachine(typeof(a<>))]
	public static IEnumerable<IEnumerable<T>> smethod_1<T>(this IEnumerable<T> ienumerable_0, int int_0)
	{
		return new a<T>(-2)
		{
			ienumerable_2 = ienumerable_0,
			int_3 = int_0
		};
	}

	public static bool IsNullOrEmpty(this Array _arr)
	{
		if (_arr != null)
		{
			return _arr.Length == 0;
		}
		return true;
	}

	public static string smethod_2(this Uri uri_0)
	{
		if (!uri_0.IsDefaultPort)
		{
			return uri_0.Host + ":" + uri_0.Port;
		}
		return uri_0.Host;
	}
}
