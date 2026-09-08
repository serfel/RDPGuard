using System;

internal sealed class Class177
{
	private readonly string string_0;

	private readonly bool bool_0;

	private readonly bool bool_1;

	private readonly bool bool_2;

	private readonly string string_1;

	private readonly string string_2;

	private readonly string string_3;

	public Class177(string string_4)
		: this(string_4, bool_3: false)
	{
	}

	public Class177(string string_4, bool bool_3)
	{
		bool_2 = bool_3;
		if (string_4 == null)
		{
			string_4 = string.Empty;
		}
		string_0 = ((bool_2 ? true : false) ? string_4.ToLowerInvariant() : string_4);
		bool_0 = string_0.IndexOf('*') >= 0 || string_0.IndexOf('?') >= 0;
		bool_1 = string_0.IndexOf('?') >= 0;
		if (bool_1 ? true : false)
		{
			return;
		}
		int num = string_0.IndexOf('*');
		if (num < 0)
		{
			string_1 = string_0;
			return;
		}
		int num2 = string_0.LastIndexOf('*');
		if (num == 0 && num2 == 0)
		{
			string_2 = string_0.Substring(1);
		}
		else if (num == string_0.Length - 1 && num2 == string_0.Length - 1)
		{
			string_1 = string_0.Substring(0, string_0.Length - 1);
		}
		else if (num == 0 && num2 == string_0.Length - 1)
		{
			if (string_0.Length >= 2)
			{
				string_3 = string_0.Substring(1, string_0.Length - 2);
			}
			else
			{
				string_3 = string.Empty;
			}
		}
	}

	public bool method_0(string string_4)
	{
		string text = string_4;
		if (text == null)
		{
			text = string.Empty;
		}
		string text2 = text;
		if (bool_2)
		{
			text2 = text2.ToLowerInvariant();
		}
		if (!bool_0)
		{
			return string.Equals(string_0, text2, StringComparison.Ordinal);
		}
		if (string_0 == "*")
		{
			return true;
		}
		if (!bool_1)
		{
			if (string_2 != null)
			{
				return text2.EndsWith(string_2, StringComparison.Ordinal);
			}
			if (string_1 != null && string_3 == null)
			{
				return text2.StartsWith(string_1, StringComparison.Ordinal);
			}
			if (string_3 != null)
			{
				return text2.IndexOf(string_3, StringComparison.Ordinal) >= 0;
			}
		}
		int i = 0;
		int num = 0;
		int num2 = -1;
		int num3 = 0;
		while (true)
		{
			if (num < text2.Length)
			{
				if (i < string_0.Length && (string_0[i] == '?' || string_0[i] == text2[num]))
				{
					i++;
					num++;
					continue;
				}
				if (i < string_0.Length && string_0[i] == '*')
				{
					num2 = ++i;
					num3 = num;
					continue;
				}
				if (num2 == -1)
				{
					break;
				}
				i = num2;
				num = ++num3;
				continue;
			}
			for (; i < string_0.Length && string_0[i] == '*'; i++)
			{
			}
			return i == string_0.Length;
		}
		return false;
	}
}
