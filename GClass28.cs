using System;

public class GClass28 : GClass27
{
	private static readonly Version version_2 = new Version(8, 4, 0);

	public bool Boolean_2 => version_1 >= version_2;

	public string method_5()
	{
		return method_6(version_1);
	}

	public string method_6(Version version_3)
	{
		return method_0(((version_3 >= version_2) ? true : false) ? GEnum18.const_1 : GEnum18.const_0);
	}
}
