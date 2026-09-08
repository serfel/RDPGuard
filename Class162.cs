using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;

[DefaultMember("Item")]
internal abstract class Class162
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<Class166, string> _003C_003E9__17_0;

		public static Func<object, bool> _003C_003E9__24_1;

		internal string method_0(Class166 class166_0)
		{
			return class166_0.method_2();
		}

		internal bool method_1(object object_0)
		{
			return object_0 is Class166;
		}
	}

	private sealed class Class165
	{
		public XmlElement xmlElement_0;

		internal void method_0(Class166 class166_0)
		{
			class166_0.method_3(xmlElement_0[class166_0.Name]);
		}
	}

	private static readonly string string_0 = "{C8A2D20A-6E2D-4B21-A1ED-136598AC708C}";

	private string string_1;

	private string string_2;

	private static readonly object object_0 = new object();

	public string String_0
	{
		get
		{
			return string_1;
		}
		private set
		{
			string_1 = value;
		}
	}

	private string String_1
	{
		get
		{
			return string_2;
		}
		set
		{
			string_2 = value;
		}
	}

	private string String_2 => String_1 + ".tmp";

	protected Class166[] Class166_0
	{
		get
		{
			IEnumerable<object> source = GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).Select(method_5);
			Func<object, bool> predicate = _003C_003Ec._003C_003E9.method_1;
			return source.Where(predicate).Cast<Class166>().ToArray();
		}
	}

	private static string smethod_0(int int_0)
	{
		string text = string.Empty;
		if (int_0 == 0)
		{
			text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "RdpGuard".Replace(" ", ""));
		}
		if (1 == int_0)
		{
			text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "RdpGuard".Replace(" ", ""));
		}
		if (string.IsNullOrEmpty(text))
		{
			throw new NotSupportedException("Unknown settings location");
		}
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		return text;
	}

	protected Class162(int int_0, string string_3)
	{
		method_0(int_0, string_3);
	}

	protected void method_0(int int_0, string string_3)
	{
		try
		{
			String_0 = smethod_0(int_0);
			String_1 = Path.Combine(String_0, string_3 + ".settings.v4");
			if (!method_4(String_1, 4))
			{
				string string_4 = Path.Combine(String_0, string_3 + ".settings-v3");
				method_4(string_4, 3);
			}
		}
		catch (Exception exception_)
		{
			Class145.smethod_0(exception_);
		}
	}

	public void method_1(string string_3)
	{
		Class165 @class = new Class165();
		@class.xmlElement_0 = GClass12.smethod_2(string_3).XmlElement_0;
		Class166_0.smethod_0(@class.method_0);
	}

	public string method_2()
	{
		Class166[] class166_ = Class166_0;
		Func<Class166, string> selector = _003C_003Ec._003C_003E9.method_0;
		return "<S>" + string.Join(null, class166_.Select(selector)) + "</S>";
	}

	public void method_3()
	{
		lock (object_0)
		{
			File.WriteAllText(String_2, GClass33.smethod_0(method_2(), string_0, 4));
			File.Copy(String_2, String_1, overwrite: true);
		}
	}

	private bool method_4(string string_3, int int_0)
	{
		lock (object_0)
		{
			if (File.Exists(string_3))
			{
				method_1(GClass33.smethod_1(File.ReadAllText(string_3), string_0, int_0));
			}
		}
		return File.Exists(string_3);
	}

	private object method_5(FieldInfo fieldInfo_0)
	{
		return fieldInfo_0.GetValue(this);
	}
}
