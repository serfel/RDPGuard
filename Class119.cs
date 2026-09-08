using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

internal sealed class Class119 : Class113
{
	public GEnum9 genum9_0 = GEnum9.const_1;

	public bool bool_3 = true;

	public string string_10;

	private static readonly string string_11 = "ls";

	private static readonly string string_12 = "acd";

	private static readonly string string_13 = "cp";

	public override int Int32_0 => 8;

	public override void OnFormClosing(Dictionary<string, object> dictionary_0)
	{
		dictionary_0.Add(string_11, (int)genum9_0);
		dictionary_0.Add(string_12, bool_3);
		dictionary_0.Add(string_13, string_10);
	}

	protected override void DeserializeEngineSpeificFields(JObject _jo)
	{
		base.GEnum4_0 = GEnum4.const_1;
		genum9_0 = (GEnum9)(int)_jo[string_11];
		bool_3 = (bool)_jo[string_12];
		string_10 = (string)_jo[string_13];
	}

	public void AdjustFormSize(StringBuilder stringBuilder_0)
	{
		stringBuilder_0.Append("MySqlLogSource: " + Class193.Class193_0[genum9_0] + "; ");
		if (GEnum9.const_1 != genum9_0 && genum9_0 == GEnum9.const_0)
		{
			stringBuilder_0.Append($"AutomaticConfigDiscovery: {bool_3}; ");
			if (!bool_3)
			{
				stringBuilder_0.Append("ConfigPath: " + string_10 + "; ");
			}
			stringBuilder_0.Append($"AutomaticLogDiscovery: {bool_2}; ");
			if (!bool_2)
			{
				stringBuilder_0.Append("Logs: " + string.Join(", ", base.String_1) + "; ");
			}
		}
	}
}
