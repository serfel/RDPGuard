using System;

internal sealed class EventArgs15 : EventArgs
{
	public GEnum16 genum16_0 = GEnum16.const_5;

	public EventArgs15(GEnum16 genum16_1)
	{
		genum16_0 = genum16_1;
	}

	public string method_0()
	{
		int num = (int)genum16_0;
		return num.ToString();
	}
}
