using System;
using System.Text;
using System.Xml;

internal abstract class Class95
{
	public Class102 class102_0;

	public abstract GEnum2 GEnum2_0 { get; }

	public string method_0()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat("<a2ccb09edc2e>");
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "e53efeb5a341", (int)GEnum2_0);
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "a8671c8bc3b2", class102_0.vmethod_0());
		stringBuilder.AppendFormat("</a2ccb09edc2e>");
		return stringBuilder.ToString();
	}

	public static Class95 smethod_0(string string_0)
	{
		try
		{
			XmlElement xmlElement_ = GClass12.smethod_2(string_0).XmlElement_0;
			return smethod_1((GEnum2)int.Parse(xmlElement_["e53efeb5a341"].InnerText), xmlElement_["a8671c8bc3b2"].InnerXml);
		}
		catch (Exception arg)
		{
			Class208.smethod_0($"CustomActionEvent::Deserialize::{arg}");
		}
		return new Class96();
	}

	public static Class95 smethod_1(GEnum2 genum2_0, string string_0 = null)
	{
		switch (genum2_0)
		{
		default:
			Class208.smethod_0("CustomActionEvent::FromEventType::unknown_custom_action_event_type");
			return new Class96();
		case GEnum2.const_0:
			return new Class96
			{
				class102_0 = Class103.smethod_0()
			};
		case GEnum2.const_1:
			return new Class97
			{
				class102_0 = Class104.smethod_0()
			};
		case GEnum2.const_2:
			return new Class98
			{
				class102_0 = Class105.smethod_0(string_0)
			};
		case GEnum2.const_3:
			return new Class99
			{
				class102_0 = Class106.smethod_0()
			};
		case GEnum2.const_4:
			return new Class100
			{
				class102_0 = Class107.smethod_0()
			};
		case GEnum2.const_5:
			return new Class101
			{
				class102_0 = Class108.smethod_0()
			};
		}
	}
}
