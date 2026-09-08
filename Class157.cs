using System;
using System.Text;
using System.Xml;

internal sealed class Class157
{
	public GEnum12 genum12_0;

	private string string_0 = string.Empty;

	private DateTime dateTime_0 = DateTime.Now;

	public static Class157 class157_0 = new Class157();

	public Class157(GEnum12 genum12_1, string string_1)
	{
		genum12_0 = genum12_1;
		string_0 = string_1;
	}

	private Class157()
	{
	}

	public override string ToString()
	{
		return "[" + Class196.Class196_0[genum12_0] + "] " + $"[{dateTime_0.Year}-{dateTime_0.Month:d2}-{dateTime_0.Day:d2} {dateTime_0.Hour:d2}:{dateTime_0.Minute:d2}:{dateTime_0.Second:d2}] " + string_0;
	}

	public string method_0()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("<a>");
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "b", (int)genum12_0);
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "c", Convert.ToBase64String(Encoding.UTF8.GetBytes(string_0)));
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "d", dateTime_0.ToBinary());
		stringBuilder.Append("</a>");
		return stringBuilder.ToString();
	}

	public static Class157 smethod_0(string string_1)
	{
		XmlElement xmlElement_ = GClass12.smethod_2(string_1).XmlElement_0;
		return new Class157
		{
			genum12_0 = (GEnum12)int.Parse(xmlElement_["b"].InnerText),
			string_0 = Encoding.UTF8.GetString(Convert.FromBase64String(xmlElement_["c"].InnerText)),
			dateTime_0 = DateTime.FromBinary(long.Parse(xmlElement_["d"].InnerText))
		};
	}
}
