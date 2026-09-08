using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

internal sealed class EventArgs2 : EventArgs
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<Class94, string> _003C_003E9__3_0;

		public static Func<XmlNode, Class94> _003C_003E9__4_0;

		internal string method_0(Class94 class94_0)
		{
			return class94_0.method_0();
		}

		internal Class94 method_1(XmlNode xmlNode_0)
		{
			return Class94.smethod_0(xmlNode_0.OuterXml);
		}
	}

	public Class94[] class94_0;

	public EventArgs2()
	{
	}

	public EventArgs2(Class94[] class94_1)
	{
		class94_0 = class94_1;
	}

	public string method_0()
	{
		Class94[] source = class94_0;
		Func<Class94, string> selector = _003C_003Ec._003C_003E9.method_0;
		return "<A>" + string.Join(null, source.Select(selector)) + "</A>";
	}

	public static EventArgs2 smethod_0(string string_0)
	{
		IEnumerable<XmlNode> iEnumerable_ = GClass12.smethod_2(string_0).IEnumerable_0;
		Func<XmlNode, Class94> selector = _003C_003Ec._003C_003E9.method_1;
		return new EventArgs2(iEnumerable_.Select(selector).ToArray());
	}
}
