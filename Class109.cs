using System.Security;
using System.Text;
using System.Xml;

internal sealed class Class109
{
	private string string_0 = GClass13.GClass14.Get();

	public string string_1 = string.Empty;

	public ushort ushort_0 = 25;

	public bool bool_0;

	public string string_2 = string.Empty;

	public string string_3 = string.Empty;

	public string String_0
	{
		get
		{
			return string_0;
		}
		private set
		{
			string_0 = value;
		}
	}

	public string method_0()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("<a>");
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "b", String_0);
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "c", SecurityElement.Escape(string_1));
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "d", ushort_0);
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "e", bool_0);
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "f", SecurityElement.Escape(string_2));
		stringBuilder.AppendFormat("<{0}>{1}</{0}>", "g", SecurityElement.Escape(string_3));
		stringBuilder.Append("</a>");
		return stringBuilder.ToString();
	}

	public static Class109 smethod_0(string string_4)
	{
		XmlElement documentElement = GClass12.smethod_2(string_4).DocumentElement;
		return new Class109
		{
			String_0 = documentElement["b"].InnerText,
			string_1 = documentElement["c"].InnerText,
			ushort_0 = ushort.Parse(documentElement["d"].InnerText),
			bool_0 = bool.Parse(documentElement["e"].InnerText),
			string_2 = documentElement["f"].InnerText,
			string_3 = documentElement["g"].InnerText
		};
	}

	public override string ToString()
	{
		return string.Format("{0}:{1} ({2}:{3}){4}", string_1, ushort_0, string_2, (string.IsNullOrEmpty(string_3) ? true : false) ? string_3 : "*******", (bool_0 ? true : false) ? " (TLS)" : null);
	}
}
