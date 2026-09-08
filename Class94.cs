using System.Text;
using System.Xml;

internal sealed class Class94
{
	private string string_0 = GClass13.GClass14.Get();

	public bool bool_0 = true;

	public Class95 class95_0;

	public GClass10 gclass10_0;

	public string String_0
	{
		get
		{
			return string_0;
		}
		private set
		{
			string_0 = value;
		}
	}

	public string method_0()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat("<ba96d6059676>");
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "dc98cbc6c112", String_0);
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "baa60a1b1c75", bool_0);
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "f0f4d4ec9fd4", class95_0.method_0());
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "c7a15f888341", gclass10_0.method_0());
		stringBuilder.AppendFormat("</ba96d6059676>");
		return stringBuilder.ToString();
	}

	public static Class94 smethod_0(string string_1)
	{
		XmlElement xmlElement_ = GClass12.smethod_2(string_1).XmlElement_0;
		Class94 @class = new Class94
		{
			bool_0 = bool.Parse(xmlElement_["baa60a1b1c75"].InnerText),
			gclass10_0 = GClass10.smethod_1(xmlElement_["c7a15f888341"].InnerXml)
		};
		if (xmlElement_["dc98cbc6c112"] != null)
		{
			@class.String_0 = xmlElement_["dc98cbc6c112"].InnerText;
		}
		if (xmlElement_["f0f4d4ec9fd4"] == null)
		{
			@class.class95_0 = Class95.smethod_1((GEnum2)int.Parse(xmlElement_["abd9966a7015"].InnerText), string.Empty);
		}
		if (xmlElement_["f0f4d4ec9fd4"] != null)
		{
			@class.class95_0 = Class95.smethod_0(xmlElement_["f0f4d4ec9fd4"].InnerXml);
		}
		return @class;
	}
}
