internal sealed class Class146
{
	public GEnum19 genum19_0 = GEnum19.Registered;

	public uint uint_0;

	public uint uint_1;

	public bool bool_0;

	public string string_0 = string.Empty;

	public string string_1 = string.Empty;

	public bool Boolean_0 => genum19_0 == GEnum19.Registered;

	public bool Boolean_1 => GEnum19.const_7 == genum19_0;

	public static Class146 smethod_0(string string_2)
	{
		return smethod_1(GClass12.smethod_2(string_2));
	}

	private static Class146 smethod_1(GClass12 gclass12_0)
	{
		return new Class146
		{
			genum19_0 = GEnum19.Registered,
			uint_0 = uint.Parse(gclass12_0.XmlElement_0["c"].InnerText),
			uint_1 = uint.Parse(gclass12_0.XmlElement_0["d"].InnerText),
			bool_0 = true,
			string_0 = gclass12_0.XmlElement_0["f"].InnerText,
			string_1 = gclass12_0.XmlElement_0["g"]?.InnerText
		};
	}
}
