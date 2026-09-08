using System.Security;
using System.Text;
using System.Xml;

internal sealed class Class141
{
	public string Name = string.Empty;

	public string string_0 = string.Empty;

	public string string_1 = string.Empty;

	public string string_2 = string.Empty;

	public string method_0()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("<d>");
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "n", SecurityElement.Escape(Name));
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "e", SecurityElement.Escape(string_0));
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "c", SecurityElement.Escape(string_1));
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "r", SecurityElement.Escape(string_2));
		stringBuilder.Append("</d>");
		return stringBuilder.ToString();
	}

	public static Class141 smethod_0(string string_3)
	{
		XmlElement xmlElement_ = GClass12.smethod_2(string_3).XmlElement_0;
		return new Class141
		{
			Name = xmlElement_["n"].InnerText,
			string_0 = xmlElement_["e"].InnerText,
			string_1 = xmlElement_["c"].InnerText,
			string_2 = xmlElement_["r"].InnerText
		};
	}
}
