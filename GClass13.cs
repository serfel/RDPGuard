using System;

public class GClass13
{
	public static class GClass14
	{
		public static string Get()
		{
			return Guid.NewGuid().ToString().Substring(0, 8);
		}

		public static bool smethod_0(string string_0)
		{
			return Class212.smethod_1(string_0, 8);
		}
	}

	public static class GClass15
	{
		public const string string_0 = "http://";

		public const string string_1 = "https://";

		public const string string_2 = "s3://";

		public const string string_3 = "s3b://";

		public static bool smethod_0(string string_4)
		{
			if (!string_4.StartsWith("http://", StringComparison.InvariantCultureIgnoreCase))
			{
				return string_4.StartsWith("https://", StringComparison.InvariantCultureIgnoreCase);
			}
			return true;
		}

		public static string smethod_1(string string_4)
		{
			if (string.IsNullOrEmpty(string_4))
			{
				return string_4;
			}
			if (string_4.StartsWith("http://", StringComparison.InvariantCultureIgnoreCase))
			{
				return string_4.Substring("http://".Length);
			}
			if (string_4.StartsWith("https://", StringComparison.InvariantCultureIgnoreCase))
			{
				return string_4.Substring("https://".Length);
			}
			if (string_4.StartsWith("s3://", StringComparison.InvariantCultureIgnoreCase))
			{
				return string_4.Substring("s3://".Length);
			}
			if (string_4.StartsWith("s3b://", StringComparison.InvariantCultureIgnoreCase))
			{
				return string_4.Substring("s3b://".Length);
			}
			return string_4;
		}

		public static string smethod_2(string string_4)
		{
			if (!string_4.StartsWith("http://"))
			{
				return string_4;
			}
			return string_4.Replace("http://", "https://");
		}
	}
}
