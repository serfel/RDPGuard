using System.Collections.Generic;
using System.Security;
using System.Text;
using System.Xml;

internal sealed class Class176 : GClass10
{
	public string string_2;

	public Class110 class110_0;

	public string string_3;

	internal override GEnum3 GEnum3_0 => GEnum3.const_4;

	protected override string SerializeTaskDetails()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "bt", SecurityElement.Escape(string_2));
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "c", SecurityElement.Escape(class110_0.method_0()));
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "m", SecurityElement.Escape(string_3));
		return stringBuilder.ToString();
	}

	protected override GClass10 DeserializeTask(string string_4)
	{
		XmlElement documentElement = GClass12.smethod_2(string_4).DocumentElement;
		return new Class176
		{
			string_2 = documentElement["bt"].InnerText,
			class110_0 = Class110.smethod_0(documentElement["c"].InnerText),
			string_3 = documentElement["m"].InnerText
		};
	}

	protected override void ToHRDictInternal(Dictionary<string, object> dictionary_0, bool bool_0 = true)
	{
		dictionary_0["BotToken"] = ((bool_0 ? true : false) ? method_3(string_2) : string_2);
		dictionary_0["ChatId"] = class110_0.String_0;
		dictionary_0["Message"] = string_3;
	}

	protected override void FromHRDictInternal(Dictionary<string, object> dictionary_0)
	{
		if (dictionary_0.TryGetValue("BotToken", out var value))
		{
			string_2 = value.ToString();
		}
		if (dictionary_0.TryGetValue("ChatId", out var value2))
		{
			class110_0 = new Class110
			{
				String_0 = value2.ToString()
			};
		}
		if (dictionary_0.TryGetValue("Message", out var value3))
		{
			string_3 = value3.ToString();
		}
	}
}
