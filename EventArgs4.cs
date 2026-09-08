using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

internal sealed class EventArgs4 : EventArgs
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<Class109, string> _003C_003E9__3_0;

		public static Func<XmlNode, Class109> _003C_003E9__4_0;

		internal string method_0(Class109 class109_0)
		{
			return class109_0.method_0();
		}

		internal Class109 method_1(XmlNode xmlNode_0)
		{
			return Class109.smethod_0(xmlNode_0.OuterXml);
		}
	}

	public Class109[] class109_0;

	public EventArgs4()
	{
	}

	public EventArgs4(Class109[] class109_1)
	{
		class109_0 = class109_1;
	}

	public string method_0()
	{
		Class109[] source = class109_0;
		Func<Class109, string> selector = _003C_003Ec._003C_003E9.method_0;
		return "<S>" + string.Join(null, source.Select(selector)) + "</S>";
	}

	public static EventArgs4 smethod_0(string string_0)
	{
		IEnumerable<XmlNode> iEnumerable_ = GClass12.smethod_2(string_0).IEnumerable_0;
		Func<XmlNode, Class109> selector = _003C_003Ec._003C_003E9.method_1;
		return new EventArgs4(iEnumerable_.Select(selector).ToArray());
	}
}
