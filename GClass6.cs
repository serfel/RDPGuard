public static class GClass6
{
	public static string smethod_0(this GEnum6 genum6_0)
	{
		string text = string.Empty;
		if (genum6_0.HasFlag(GEnum6.flag_0))
		{
			text += "loopback, ";
		}
		if (genum6_0.HasFlag(GEnum6.flag_1))
		{
			text += "up, ";
		}
		if (genum6_0.HasFlag(GEnum6.flag_2))
		{
			text += "running, ";
		}
		if (genum6_0.HasFlag(GEnum6.flag_3))
		{
			text += "wireless, ";
		}
		if (genum6_0.HasFlag(GEnum6.flag_6))
		{
			text += "connected, ";
		}
		if (genum6_0.HasFlag(GEnum6.flag_7))
		{
			text += "disconnected, ";
		}
		if (genum6_0.HasFlag(GEnum6.flag_4))
		{
			text += "not applicable, ";
		}
		return text.TrimEnd(',', ' ');
	}
}
