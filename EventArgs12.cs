using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

internal sealed class EventArgs12 : EventArgs
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<Class157, string> _003C_003E9__3_0;

		public static Func<XmlNode, Class157> _003C_003E9__4_0;

		internal string method_0(Class157 class157_0)
		{
			return class157_0.method_0();
		}

		internal Class157 method_1(XmlNode xmlNode_0)
		{
			return Class157.smethod_0(xmlNode_0.OuterXml);
		}
	}

	public Class157[] class157_0;

	public EventArgs12(Class157[] class157_1)
	{
		class157_0 = class157_1;
	}

	public EventArgs12(Class157 class157_1)
	{
		class157_0 = new Class157[1] { class157_1 };
	}

	public string method_0()
	{
		Class157[] source = class157_0;
		Func<Class157, string> selector = _003C_003Ec._003C_003E9.method_0;
		return "<L>" + string.Join(null, source.Select(selector)) + "</L>";
	}

	public static EventArgs12 smethod_0(string string_0)
	{
		IEnumerable<XmlNode> iEnumerable_ = GClass12.smethod_2(string_0).IEnumerable_0;
		Func<XmlNode, Class157> selector = _003C_003Ec._003C_003E9.method_1;
		return new EventArgs12(iEnumerable_.Select(selector).ToArray());
	}
}
