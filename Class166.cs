using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Xml;

internal sealed class Class166
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<Class166, string> _003C_003E9__28_0;

		internal string method_0(Class166 class166_0)
		{
			return class166_0.method_2();
		}
	}

	private sealed class Class167
	{
		public string string_0;

		internal bool method_0(Class166 class166_0)
		{
			return class166_0.Name == string_0;
		}
	}

	private EventHandler eventHandler_0;

	public string Name;

	private string string_0;

	public string string_1;

	private readonly List<Class166> list_0 = new List<Class166>();

	public string String_0
	{
		get
		{
			if (!string.IsNullOrEmpty(string_0))
			{
				return string_0;
			}
			return string_1;
		}
		set
		{
			string_0 = value;
			eventHandler_0?.Invoke(this, EventArgs.Empty);
		}
	}

	public string String_1
	{
		get
		{
			return String_0;
		}
		set
		{
			String_0 = value;
		}
	}

	public int Int32_0
	{
		get
		{
			return int.Parse(String_0);
		}
		set
		{
			String_0 = value.ToString();
		}
	}

	public bool Boolean_0
	{
		get
		{
			return bool.Parse(String_0);
		}
		set
		{
			String_0 = value.ToString();
		}
	}

	private Class166()
	{
	}

	public Class166(string string_2, string string_3 = null)
	{
		Name = string_2;
		string_1 = string_3;
	}

	public Class166(string string_2, bool bool_0)
	{
		Name = string_2;
		string_1 = bool_0.ToString();
	}

	public Class166(string string_2, int int_0)
	{
		Name = string_2;
		string_1 = int_0.ToString();
	}

	public void method_0(Class166 class166_0)
	{
		if (string.IsNullOrEmpty(class166_0.Name))
		{
			return;
		}
		using (List<Class166>.Enumerator enumerator = list_0.GetEnumerator())
		{
			while (enumerator.MoveNext() ? true : false)
			{
				Class166 current = enumerator.Current;
				if (current.Name == class166_0.Name)
				{
					list_0.Remove(current);
					break;
				}
			}
		}
		list_0.Add(class166_0);
	}

	public Class166 method_1(string string_2)
	{
		Class167 @class = new Class167();
		@class.string_0 = string_2;
		return list_0.Where(@class.method_0).FirstOrDefault();
	}

	public string method_2()
	{
		if (!string.IsNullOrEmpty(String_0))
		{
			return "<" + Name + " v=\"" + SecurityElement.Escape(String_0) + "\" />";
		}
		if (list_0.Count > 0)
		{
			string[] array = new string[7] { "<", Name, ">", null, null, null, null };
			List<Class166> source = list_0;
			Func<Class166, string> selector = _003C_003Ec._003C_003E9.method_0;
			array[3] = string.Join(null, source.Select(selector));
			array[4] = "</";
			array[5] = Name;
			array[6] = ">";
			return string.Concat(array);
		}
		return null;
	}

	public void method_3(XmlNode xmlNode_0)
	{
		if (xmlNode_0 == null)
		{
			String_0 = null;
			return;
		}
		if (xmlNode_0.Attributes != null && xmlNode_0.Attributes.Count > 0)
		{
			String_0 = xmlNode_0.Attributes[0].InnerText;
			return;
		}
		IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
		try
		{
			while (enumerator.MoveNext() ? true : false)
			{
				XmlNode xmlNode = (XmlNode)enumerator.Current;
				Class166 @class = new Class166(xmlNode.Name);
				@class.method_3(xmlNode);
				method_0(@class);
			}
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}
	}
}
