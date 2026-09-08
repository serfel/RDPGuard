using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using System.Xml;

public abstract class GClass10 : GClass9
{
	public object object_0;

	internal abstract GEnum3 GEnum3_0 { get; }

	public static GClass10 smethod_0(GEnum3 genum3_0)
	{
		if (1 == 0)
		{
		}
		GClass10 result = genum3_0 switch
		{
			GEnum3.const_0 => new Class175(), 
			GEnum3.const_1 => new Class173(), 
			GEnum3.const_2 => new Class174(), 
			GEnum3.const_3 => new Class172(), 
			GEnum3.const_4 => new Class176(), 
			_ => throw new Exception("CustomActionTask::GetTask: unknown custom action type"), 
		};
		if (1 == 0)
		{
		}
		return result;
	}

	public string method_0()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat("<{0}>", "f8efe347b18c");
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "dc1a2f95a604", (int)GEnum3_0);
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "c5138901cdc2", (int)genum15_0);
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "d4f5d3c08ff4", SecurityElement.Escape(string_0));
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "a847bf5dfe0b", SecurityElement.Escape(string_1));
		stringBuilder.Append(SerializeTaskDetails());
		stringBuilder.AppendFormat("</{0}>", "f8efe347b18c");
		return stringBuilder.ToString();
	}

	public static GClass10 smethod_1(string string_2, object object_1 = null)
	{
		XmlElement documentElement = GClass12.smethod_2(string_2).DocumentElement;
		GClass10 gClass = smethod_0((GEnum3)int.Parse(documentElement["dc1a2f95a604"].InnerText)).DeserializeTask(string_2);
		if (documentElement["c5138901cdc2"] != null)
		{
			gClass.genum15_0 = (GEnum15)int.Parse(documentElement["c5138901cdc2"].InnerText);
		}
		if (documentElement["d4f5d3c08ff4"] != null)
		{
			gClass.string_0 = documentElement["d4f5d3c08ff4"].InnerText;
		}
		if (documentElement["a847bf5dfe0b"] != null)
		{
			gClass.string_1 = documentElement["a847bf5dfe0b"].InnerText;
		}
		gClass.object_0 = object_1;
		return gClass;
	}

	protected abstract string SerializeTaskDetails();

	protected abstract GClass10 DeserializeTask(string string_2);

	protected abstract void ToHRDictInternal(Dictionary<string, object> dictionary_0, bool bool_0 = true);

	protected abstract void FromHRDictInternal(Dictionary<string, object> dictionary_0);

	public Dictionary<string, object> method_1(bool bool_0 = false)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object> { ["Type"] = Class187.Class187_0[GEnum3_0] };
		ToHRDictInternal(dictionary, bool_0);
		return dictionary;
	}

	public static GClass10 smethod_2(Dictionary<string, object> dictionary_0)
	{
		if (!dictionary_0.TryGetValue("Type", out var value))
		{
			throw new Exception("CustomActionTask::FromHRDict: unknown task type");
		}
		GClass10 gClass = smethod_0(Class187.Class187_0[value as string]);
		gClass.FromHRDictInternal(dictionary_0);
		return gClass;
	}

	public string method_2(bool bool_0)
	{
		return method_1(bool_0).smethod_19();
	}

	protected string method_3(string string_2)
	{
		if (!string.IsNullOrEmpty(string_2))
		{
			return new string('*', string_2.Length);
		}
		return string.Empty;
	}
}
