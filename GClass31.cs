using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Xml;

public class GClass31
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<XmlNode, string> _003C_003E9__18_0;

		internal string method_0(XmlNode xmlNode_0)
		{
			return xmlNode_0.InnerText;
		}
	}

	private sealed class Class210
	{
		public StringBuilder stringBuilder_0;

		internal void method_0(string string_0)
		{
			stringBuilder_0.AppendFormat("<{0}>{1}</{0}>", string_10, SecurityElement.Escape(string_0));
		}
	}

	private static readonly string string_0 = "502F77DB-B251-45C7-ABFF-A0693EE6DFA8";

	public string string_1 = string.Empty;

	public string string_2 = string.Empty;

	public string[] string_3 = new string[0];

	public string string_4 = string.Empty;

	public string string_5 = string.Empty;

	public long long_0;

	private static readonly string string_6 = "a";

	private static readonly string string_7 = "b";

	private static readonly string string_8 = "c";

	private static readonly string string_9 = "d";

	private static readonly string string_10 = "e";

	private static readonly string string_11 = "f";

	private static readonly string string_12 = "g";

	private static readonly string string_13 = "h";

	private GClass31()
	{
	}

	public GClass31(string string_14, string string_15, string[] string_16, string string_17, string string_18, long long_1)
	{
		string_1 = string_14;
		string_2 = string_15;
		string[] array = string_16;
		if (array == null)
		{
			array = new string[0];
		}
		string_3 = array;
		string_4 = string_17;
		string_5 = string_18;
		long_0 = long_1;
	}

	public virtual string Serialize(int int_0)
	{
		Class210 @class = new Class210();
		@class.stringBuilder_0 = new StringBuilder();
		@class.stringBuilder_0.Append("<" + string_6 + ">");
		@class.stringBuilder_0.AppendFormat("<{0}>{1}</{0}>", string_7, SecurityElement.Escape(string_1));
		if (!string.IsNullOrEmpty(string_2))
		{
			@class.stringBuilder_0.AppendFormat("<{0}>{1}</{0}>", string_8, SecurityElement.Escape(string_2));
		}
		@class.stringBuilder_0.Append("<" + string_9 + ">");
		string_3.smethod_0(@class.method_0);
		@class.stringBuilder_0.Append("</" + string_9 + ">");
		if (!string.IsNullOrEmpty(string_4))
		{
			@class.stringBuilder_0.AppendFormat("<{0}>{1}</{0}>", string_11, SecurityElement.Escape(string_4));
		}
		@class.stringBuilder_0.AppendFormat("<{0}>{1}</{0}>", string_12, SecurityElement.Escape(string_5));
		if (long_0 != 0)
		{
			@class.stringBuilder_0.AppendFormat("<{0}>{1}</{0}>", string_13, long_0);
		}
		@class.stringBuilder_0.Append("</" + string_6 + ">");
		string text = Convert.ToBase64String(new ASCIIEncoding().GetBytes(GClass33.smethod_0(@class.stringBuilder_0.ToString(), string_0, int_0)));
		string text2 = null;
		int num = 0;
		string text3 = text;
		for (int i = 0; i < text3.Length; i++)
		{
			text2 += text3[i];
			if (num++ == 39)
			{
				text2 += "\r\n";
				num = 0;
			}
		}
		return text2;
	}

	public static GClass31 smethod_0(string string_14, int int_0)
	{
		XmlElement xmlElement_ = GClass12.smethod_2(GClass33.smethod_1(new ASCIIEncoding().GetString(Convert.FromBase64String(string_14)), string_0, int_0)).XmlElement_0;
		GClass31 gClass = new GClass31
		{
			string_1 = xmlElement_[string_7].InnerText
		};
		IEnumerable<XmlNode> source = xmlElement_[string_9].ChildNodes.Cast<XmlNode>();
		Func<XmlNode, string> selector = _003C_003Ec._003C_003E9.method_0;
		gClass.string_3 = source.Select(selector).ToArray();
		GClass31 gClass2 = gClass;
		if (xmlElement_[string_8] != null)
		{
			gClass2.string_2 = xmlElement_[string_8].InnerText;
		}
		if (xmlElement_[string_11] != null)
		{
			gClass2.string_4 = xmlElement_[string_11].InnerText;
		}
		if (xmlElement_[string_12] != null)
		{
			gClass2.string_5 = xmlElement_[string_12].InnerText;
		}
		if (xmlElement_[string_13] != null)
		{
			gClass2.long_0 = long.Parse(xmlElement_[string_13].InnerText);
		}
		return gClass2;
	}
}
