using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

internal sealed class Class105 : Class102
{
	public string string_0 = "LogonType!=10\r\nTargetUserName=ANONYMOUS LOGON\r\nIpAddress=-";

	public override bool Boolean_0 => true;

	public override string OnFormClosing()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat("<f827def9d38e>");
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "bb27094a64d5", Convert.ToBase64String(Encoding.UTF8.GetBytes(string_0)));
		stringBuilder.AppendFormat("</f827def9d38e>");
		return stringBuilder.ToString();
	}

	public static Class105 smethod_0(string string_1)
	{
		if (string.IsNullOrEmpty(string_1))
		{
			return new Class105();
		}
		XmlElement xmlElement_ = GClass12.smethod_2(string_1).XmlElement_0;
		return new Class105
		{
			string_0 = Encoding.UTF8.GetString(Convert.FromBase64String(xmlElement_["bb27094a64d5"].InnerText))
		};
	}

	public override Dictionary<string, object> InitializeFormPosition()
	{
		return new Dictionary<string, object> { ["Exclusions"] = string_0.Replace("\r\n", "**OR**") };
	}
}
