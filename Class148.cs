internal static class Class148
{
	internal static class Class149
	{
		public static string String_0 => Get("versioncheck.aspx");
	}

	internal static class Class150
	{
		public static string String_0 => Get("second-license");

		public static string String_1 => Get("upgrade-license");

		public static string smethod_0(string string_0)
		{
			return Get("purchase.aspx", "&f=" + string_0);
		}

		public static string smethod_1(string string_0)
		{
			return Get("license-tools.aspx", "&a=gli&glik=" + string_0);
		}
	}

	internal static class Class151
	{
		public static string String_0 => Get("rdp-protection-settings.aspx");

		public static string String_1 => Get("rdp-exclusions-for-security-log-event-id-4625.aspx", "#exclusion-rules-syntax");

		public static string String_2 => Get("ftp-detection-engine-settings.aspx");

		public static string String_3 => Get("http-detection-engine-settings.aspx");

		public static string String_4 => String_3 + "#advanced-settings";

		public static string String_5 => Get("imap-protection-settings.aspx");

		public static string String_6 => Get("pop3-protection-settings.aspx");

		public static string String_7 => Get("smtp-engine-settings.aspx");

		public static string String_8 => Get("mysql-detection-engine-settings.aspx");

		public static string String_9 => Get("mssql-protection-settings.aspx");

		public static string String_10 => Get("mssql-protection-settings.aspx", "#exclusions");

		public static string String_11 => Get("voip-sip-brute-force-protection-settings.aspx");

		public static string String_12 => Get("rdweb-access-protection-settings.aspx");

		public static string String_13 => String_12 + "#advanced-settings";

		public static string String_14 => Get("asp-net-web-forms-protection.aspx", "#configure");
	}

	internal static class Class152
	{
		public static string String_0 => Get("whitelist.aspx");

		public static string String_1 => String_0 + "#add-ip-address-to-whitelist";

		public static string String_2 => String_0 + "#edit-ip-address";
	}

	internal static class Class153
	{
		public static string String_0 => Get("custom-actions.aspx");

		public static string String_1 => String_0 + "#add_custom_action";

		public static string String_2 => String_0 + "#edit_custom_action";

		public static string String_3 => String_0 + "#event-settings";
	}

	internal static class Class154
	{
		public static string String_0 => Get("smtp-servers.aspx");

		public static string String_1 => String_0 + "#add_smtp_server";

		public static string String_2 => String_0 + "#edit_smtp_server";
	}

	internal static class Class155
	{
		public static string String_0 => Get("monitoring-via-raw-sockets.aspx");

		public static string String_1 => Get("monitoring-via-winpcap.aspx");
	}

	internal static class Class156
	{
		public static string string_0 = String_0 + "#add-allowed-address-or-range";

		public static string string_1 = String_0 + "#advanced-settings";

		public static string string_2 = "scripts/geoip/";

		public static string String_0 => Get("geoip-blocking.aspx");

		public static string String_1 => String_0 + "#restrictions";
	}

	public static string String_0 => Get("help.aspx");

	public static string String_1 => Get("contactus.aspx");

	public static string String_2 => Get("");

	public static string String_3 => Get("scripts/error_report.aspx");

	public static string String_4 => Get("ip-list-filtering.aspx");

	public static string String_5 => Get("advanced-blocking-settings.aspx");

	public static string String_6 => Get("winpcap-npcap-compatibility.aspx", (Class178.Boolean_1 ? true : false) ? "#win2k8plus" : "#win2k3");

	public static string String_7 => Get("iis-x-forwarded-for-configuration.aspx");

	private static string Get(string _path)
	{
		return Get(_path, null);
	}

	private static string Get(string _path, string _extra)
	{
		return string.Format("https://{0}/{1}?v={2}&fam={3}{4}", "rdpguard.com", _path, Class138.version_0, Class138.String_0, _extra);
	}

	public static string smethod_0(string string_0)
	{
		return "https://rdpguard.com/free-whois.aspx?ip=" + string_0;
	}
}
