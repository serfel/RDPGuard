using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

internal sealed class Class115 : Class113
{
	public static readonly string string_10 = "# This is comment, it starts with the # symbol\r\n\r\n# Treat each 15 requests with HTTP status 404 as scan attempt\r\nStatus=404,Threshold=15\r\n\r\n# secrets, environment variables, repository metadata scan\r\nUri=*/.aws*\r\nUri=*/.env*\r\nUri=*/.git*\r\nUri=*/.hg/*\r\nUri=*/.svn*\r\nUri=*/.vscode*\r\n\r\n# scan for backups, uncomment if you do not host these archive types\r\n#Uri=/*.bz2\r\n#Uri=/*.tar.gz\r\n#Uri=/*.tgz\r\n#Uri=/*.7z\r\n#Uri=/*.zip, Uri!=/download/*\r\n#Uri=/*.rar\r\n\r\n# scan for wordpress files, uncomment if necessary\r\n#Uri=*/wp-content/*\r\n#Uri=*/wp-admin/*\r\n#Uri=*/wp-includes/*\r\n#Uri=*/wp-json/*\r\n#Uri=*/wp-config*\r\n#Uri=*/wp-login.php*";

	public bool bool_3;

	public string string_11 = string.Empty;

	public bool bool_4;

	public bool bool_5;

	public override int Int32_0 => 4;

	public string String_2
	{
		get
		{
			if (bool_3 && !string.IsNullOrEmpty(string_11))
			{
				return string_11;
			}
			return string_10;
		}
	}

	public override void vmethod_0(Dictionary<string, object> dictionary_0)
	{
		dictionary_0.Add("ucr", bool_3);
		if (!string.IsNullOrEmpty(string_11))
		{
			dictionary_0.Add("cr", string_11);
		}
		dictionary_0.Add("uxff", bool_4);
		dictionary_0.Add("xff_fallback", bool_5);
	}

	protected override void DeserializeEngineSpeificFields(JObject _jo)
	{
		base.GEnum4_0 = GEnum4.const_1;
		bool_2 = false;
		bool_3 = (bool)_jo["ucr"];
		JToken val = default(JToken);
		if (_jo.TryGetValue("cr", out val))
		{
			string_11 = (string)val;
		}
		JToken val2 = default(JToken);
		if (_jo.TryGetValue("uxff", out val2))
		{
			bool_4 = (bool)val2;
		}
		JToken val3 = default(JToken);
		if (_jo.TryGetValue("xff_fallback", out val3))
		{
			bool_5 = (bool)val3;
		}
	}

	public string vmethod_2()
	{
		return "IIS";
	}

	public void vmethod_3(StringBuilder stringBuilder_0)
	{
		stringBuilder_0.Append($"UseCustomRules: {bool_3}; ");
		if (bool_3)
		{
			stringBuilder_0.Append("CustomRules: " + string_11.Replace("\r\n", " OR ") + "; ");
		}
		stringBuilder_0.Append($"UseXForwardedFor: {bool_4}; ");
		stringBuilder_0.Append($"XffFallbackToRemoteAddr: {bool_5}; ");
	}
}
