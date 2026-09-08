using System.Collections.Generic;
using System.Text;

internal sealed class Class131
{
	public bool bool_0 = true;

	public bool bool_1 = true;

	public bool bool_2 = true;

	public bool bool_3 = true;

	public bool bool_4 = true;

	public bool bool_5 = true;

	public bool bool_6 = true;

	public static Dictionary<string, string> dictionary_0 = new Dictionary<string, string>
	{
		["failed-web-admin"] = "Block failed web admin logins",
		["failed-web-mail"] = "Block failed web mail logins",
		["username-enum"] = "Block username enumeration attempts",
		["relay-attempts"] = "Block relay attempts",
		["spam-attacks"] = "Block spam attacks",
		["dns-blacklisted"] = "Block DNS blacklisted addresses",
		["no-reverse-dns"] = "Block no reverse DNS addresses"
	};

	public string method_0()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append($"BlockFailedWebAdminLogins: {bool_0}; ");
		stringBuilder.Append($"BlockFailedWebMailLogins: {bool_1}; ");
		stringBuilder.Append($"BlockUsernameEnumerationAttempts: {bool_2}; ");
		stringBuilder.Append($"BlockRelayAttempts: {bool_3}; ");
		stringBuilder.Append($"BlockSpamAttacks: {bool_4}; ");
		stringBuilder.Append($"BlockDnsBlacklistedAddresses: {bool_5}; ");
		stringBuilder.Append($"BlockNoReverseDnsAddresses: {bool_6}; ");
		return stringBuilder.ToString();
	}
}
