using System;
using System.Linq;
using System.Windows.Forms;

internal sealed class bi<T> : Class47
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<ListViewItem, T> _003C_003E9__3_0;

		internal T method_0(ListViewItem listViewItem_0)
		{
			return (T)listViewItem_0.Tag;
		}
	}

	public T[] Prop_0
	{
		get
		{
			ListViewItem[] listViewItem_ = base.ListViewItem_1;
			Func<ListViewItem, T> selector = _003C_003Ec._003C_003E9.method_0;
			return listViewItem_.Select(selector).ToArray();
		}
	}
}
