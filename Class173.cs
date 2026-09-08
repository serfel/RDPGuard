using System.Collections.Generic;
using System.Security;
using System.Text;
using System.Xml;

internal sealed class Class173 : GClass10
{
	public string string_2;

	public bool bool_0;

	public string string_3;

	public string string_4;

	public string string_5;

	internal override GEnum3 GEnum3_0 => GEnum3.const_1;

	protected override string SerializeTaskDetails()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "b907d2c5c2b6", SecurityElement.Escape(string_2));
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "a17111337dbd", bool_0.ToString());
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "d25b12b0c797", SecurityElement.Escape(string_3));
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "a39c07784044", SecurityElement.Escape(string_4));
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "b762adf51c8f", SecurityElement.Escape(string_5));
		return stringBuilder.ToString();
	}

	protected override GClass10 DeserializeTask(string string_6)
	{
		XmlElement documentElement = GClass12.smethod_2(string_6).DocumentElement;
		return new Class173
		{
			string_2 = documentElement["b907d2c5c2b6"].InnerText,
			bool_0 = bool.Parse(documentElement["a17111337dbd"].InnerText),
			string_3 = documentElement["d25b12b0c797"].InnerText,
			string_4 = documentElement["a39c07784044"].InnerText,
			string_5 = documentElement["b762adf51c8f"].InnerText
		};
	}

	protected override void ToHRDictInternal(Dictionary<string, object> dictionary_0, bool bool_1 = true)
	{
		dictionary_0["Endpoint"] = string_2;
		dictionary_0["BasicAuth"] = bool_0.ToString();
		dictionary_0["Username"] = string_3;
		dictionary_0["Password"] = ((bool_1 ? true : false) ? method_3(string_4) : string_4);
		dictionary_0["Body"] = string_5;
	}

	protected override void FromHRDictInternal(Dictionary<string, object> dictionary_0)
	{
		if (dictionary_0.TryGetValue("Endpoint", out var value))
		{
			string_2 = value.ToString();
		}
		if (dictionary_0.TryGetValue("BasicAuth", out var value2))
		{
			bool_0 = bool.Parse(value2.ToString());
		}
		if (dictionary_0.TryGetValue("Username", out var value3))
		{
			string_3 = value3.ToString();
		}
		if (dictionary_0.TryGetValue("Password", out var value4))
		{
			string_4 = value4.ToString();
		}
		if (dictionary_0.TryGetValue("Body", out var value5))
		{
			string_5 = value5.ToString();
		}
	}
}
