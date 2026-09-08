using rdpguard.lib;

internal sealed class Class135 : IPListEntry
{
	private string string_0;

	private Class177 class177_0;

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

	public Class135(string string_1)
		: base(string_1, null)
	{
		String_0 = string_1;
		class177_0 = new Class177(string_1);
	}

	public override bool OnFormClosing(GClass24 gclass24_1)
	{
		if (!base.OnFormClosing(gclass24_1))
		{
			return class177_0.method_0(gclass24_1.method_6());
		}
		return true;
	}
}
