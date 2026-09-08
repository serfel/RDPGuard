using System;

internal sealed class EventArgs10 : EventArgs
{
	public bool bool_0;

	public EventArgs10(string string_0)
	{
		bool_0 = bool.Parse(string_0);
	}
}
