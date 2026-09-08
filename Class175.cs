using System.Collections.Generic;
using System.Security;
using System.Text;
using System.Xml;

internal sealed class Class175 : GClass10
{
	public string string_2;

	public string string_3;

	public string string_4;

	public string string_5;

	public string string_6;

	internal override GEnum3 GEnum3_0 => GEnum3.const_0;

	protected override string SerializeTaskDetails()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "d4732b21e6fa", string_2);
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "edb5028375a2", SecurityElement.Escape(string_3));
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "f63c085f532b", SecurityElement.Escape(string_4));
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "a31762c1968f", SecurityElement.Escape(string_5));
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "b5016f6956ea", SecurityElement.Escape(string_6));
		return stringBuilder.ToString();
	}

	protected override GClass10 DeserializeTask(string string_7)
	{
		XmlElement documentElement = GClass12.smethod_2(string_7).DocumentElement;
		return new Class175
		{
			string_2 = documentElement["d4732b21e6fa"].InnerText,
			string_3 = documentElement["edb5028375a2"].InnerText,
			string_4 = documentElement["f63c085f532b"].InnerText,
			string_5 = documentElement["a31762c1968f"].InnerText,
			string_6 = documentElement["b5016f6956ea"].InnerText
		};
	}

	protected override void ToHRDictInternal(Dictionary<string, object> dictionary_0, bool bool_0 = true)
	{
		dictionary_0["ServerId"] = string_2;
		dictionary_0["From"] = string_3;
		dictionary_0["To"] = string_4;
		dictionary_0["Subject"] = string_5;
		dictionary_0["Body"] = string_6;
	}

	protected override void FromHRDictInternal(Dictionary<string, object> dictionary_0)
	{
		if (dictionary_0.TryGetValue("ServerId", out var value))
		{
			string_2 = value.ToString();
		}
		if (dictionary_0.TryGetValue("From", out var value2))
		{
			string_3 = value2.ToString();
		}
		if (dictionary_0.TryGetValue("To", out var value3))
		{
			string_4 = value3.ToString();
		}
		if (dictionary_0.TryGetValue("Subject", out var value4))
		{
			string_5 = value4.ToString();
		}
		if (dictionary_0.TryGetValue("Body", out var value5))
		{
			string_6 = value5.ToString();
		}
	}
}
