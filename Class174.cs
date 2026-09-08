using System.Collections.Generic;
using System.Security;
using System.Text;
using System.Xml;

internal sealed class Class174 : GClass10
{
	public string string_2;

	public string string_3;

	internal override GEnum3 GEnum3_0 => GEnum3.const_2;

	protected override string SerializeTaskDetails()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "f8aa49337760", SecurityElement.Escape(string_2));
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "c3bf50795cc2", SecurityElement.Escape(string_3));
		return stringBuilder.ToString();
	}

	protected override GClass10 DeserializeTask(string string_4)
	{
		XmlElement xmlElement_ = GClass12.smethod_2(string_4).XmlElement_0;
		return new Class174
		{
			string_2 = xmlElement_["f8aa49337760"].InnerText,
			string_3 = xmlElement_["c3bf50795cc2"].InnerText
		};
	}

	protected override void ToHRDictInternal(Dictionary<string, object> dictionary_0, bool bool_0 = true)
	{
		dictionary_0["Path"] = string_2;
		dictionary_0["Arguments"] = string_3;
	}

	protected override void FromHRDictInternal(Dictionary<string, object> dictionary_0)
	{
		if (dictionary_0.TryGetValue("Path", out var value))
		{
			string_2 = value.ToString();
		}
		if (dictionary_0.TryGetValue("Arguments", out var value2))
		{
			string_3 = value2.ToString();
		}
	}
}
