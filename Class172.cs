using System.Collections.Generic;
using System.Security;
using System.Text;
using System.Xml;

internal sealed class Class172 : GClass10
{
	public string string_2;

	internal override GEnum3 GEnum3_0 => GEnum3.const_3;

	protected override string SerializeTaskDetails()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "cc92655c6c0c", SecurityElement.Escape(string_2));
		return stringBuilder.ToString();
	}

	protected override GClass10 DeserializeTask(string string_3)
	{
		XmlElement documentElement = GClass12.smethod_2(string_3).DocumentElement;
		return new Class172
		{
			string_2 = documentElement["cc92655c6c0c"].InnerText
		};
	}

	protected override void ToHRDictInternal(Dictionary<string, object> dictionary_0, bool bool_0 = true)
	{
		dictionary_0["ApiKey"] = ((bool_0 ? true : false) ? method_3(string_2) : string_2);
	}

	protected override void FromHRDictInternal(Dictionary<string, object> dictionary_0)
	{
		if (dictionary_0.TryGetValue("ApiKey", out var value))
		{
			string_2 = value.ToString();
		}
	}
}
