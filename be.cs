using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal sealed class be<T>
{
	private sealed class Class43 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator
	{
		private int int_0;

		private T gparam_0;

		private int int_1;

		public be<T> be_0;

		private int int_2;

		private int int_3;

		T IEnumerator<T>.Current => gparam_0;

		object IEnumerator.Current => gparam_0;

		public Class43(int int_4)
		{
			int_0 = int_4;
			int_1 = Environment.CurrentManagedThreadId;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = int_0;
			be<T> be2 = be_0;
			switch (num)
			{
			default:
				return false;
			case 1:
				int_0 = -1;
				int_3++;
				break;
			case 0:
			{
				int_0 = -1;
				while (be2.int_0 * be2.Int32_0 >= be2.gparam_0.Length)
				{
					be2.int_0--;
				}
				if (be2.int_0 < 0)
				{
					be2.int_0 = 0;
				}
				int num2 = be2.int_0 * be2.Int32_0;
				int_2 = (be2.int_0 + 1) * be2.Int32_0;
				int_3 = num2;
				break;
			}
			}
			if (int_3 < be2.gparam_0.Length && int_3 < int_2)
			{
				gparam_0 = be2.gparam_0[int_3];
				int_0 = 1;
				return true;
			}
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			return MoveNext();
		}

		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			Class43 @class;
			if (int_0 == -2 && int_1 == Environment.CurrentManagedThreadId)
			{
				int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class43(0);
				@class.be_0 = be_0;
			}
			return @class;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<T>)this).GetEnumerator();
		}
	}

	private readonly Class79 class79_0;

	private int int_0;

	private int int_1;

	private T[] gparam_0 = new T[0];

	private int Int32_0 => Class163.Class163_0.class166_7.Int32_0;

	private int Int32_1
	{
		get
		{
			int num = gparam_0.Length / Int32_0;
			if (gparam_0.Length % Int32_0 > 0)
			{
				num++;
			}
			return num;
		}
	}

	public T[] Prop_0
	{
		set
		{
			gparam_0 = value;
			bool flag = gparam_0.Length > Int32_0;
			class79_0.method_2("pagination_bar", flag);
			if (flag)
			{
				method_2();
			}
		}
	}

	public int Int32_2
	{
		set
		{
			int_0 = value;
		}
	}

	public IEnumerable<T> IEnumerable_0
	{
		[IteratorStateMachine(typeof(be<>.Class43))]
		get
		{
			return new Class43(-2)
			{
				be_0 = this
			};
		}
	}

	public be(Class79 class79_1)
	{
		class79_0 = class79_1;
	}

	public void method_0()
	{
		int_1--;
		method_2();
	}

	public void method_1()
	{
		int_1++;
		method_2();
	}

	public void method_2()
	{
		while (int_1 * 5 >= Int32_1)
		{
			int_1--;
		}
		if (int_1 < 0)
		{
			int_1 = 0;
		}
		int num = int_1 * 5;
		int num2 = (int_1 + 1) * 5;
		if (num2 > Int32_1)
		{
			num2 = Int32_1;
		}
		if (num2 - num < 5 && Int32_1 > 5)
		{
			num = Int32_1 - 5;
			num2 = Int32_1;
		}
		class79_0.method_1("pagination_bar", "");
		string text = "switcher";
		string text2 = " active_switcher";
		HtmlElement htmlElement = class79_0.Document.CreateElement("a");
		htmlElement.SetAttribute("href", "#");
		htmlElement.SetAttribute("className", text);
		htmlElement.SetAttribute("id", (num > 0) ? "pagePrev" : null);
		htmlElement.InnerText = "<";
		class79_0.method_10("pagination_bar").AppendChild(htmlElement);
		for (int i = num; i < Int32_1 && i < num2; i++)
		{
			string value = ((i == int_0) ? text2 : text);
			HtmlElement htmlElement2 = class79_0.Document.CreateElement("a");
			htmlElement2.SetAttribute("href", "#");
			htmlElement2.SetAttribute("className", value);
			htmlElement2.SetAttribute("id", $"page{i}");
			htmlElement2.SetAttribute("title", $"Page {i + 1}");
			htmlElement2.InnerText = (i + 1).ToString("D2");
			class79_0.method_10("pagination_bar").AppendChild(htmlElement2);
		}
		HtmlElement htmlElement3 = class79_0.Document.CreateElement("a");
		htmlElement3.SetAttribute("href", "#");
		htmlElement3.SetAttribute("className", text);
		htmlElement3.SetAttribute("id", (num2 < Int32_1) ? "pageNext" : null);
		htmlElement3.InnerText = ">";
		class79_0.method_10("pagination_bar").AppendChild(htmlElement3);
	}
}
