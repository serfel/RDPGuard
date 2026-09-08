using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

internal sealed class Class117 : Class113
{
	public static readonly int[] int_0 = new int[3] { 18456, 17832, 17836 };

	public int[] int_1 = int_0;

	public string[] string_10 = new string[0];

	private static readonly string string_11 = "ei";

	private static readonly string string_12 = "e";

	public override int Int32_0 => 2;

	public override void vmethod_0(Dictionary<string, object> dictionary_0)
	{
		dictionary_0.Add(string_11, int_1);
		if (string_10.Any())
		{
			dictionary_0.Add(string_12, string_10);
		}
	}

	protected override void DeserializeEngineSpeificFields(JObject _jo)
	{
		base.GEnum4_0 = GEnum4.const_1;
		int_1 = _jo[string_11].ToObject<int[]>();
		JToken val = default(JToken);
		if (_jo.TryGetValue(string_12, out val))
		{
			string_10 = val.ToObject<string[]>();
		}
	}

	public void vmethod_2(StringBuilder stringBuilder_0)
	{
		stringBuilder_0.Append("Events: " + string.Join(", ", int_1) + "; ");
		if (string_10.Any())
		{
			stringBuilder_0.Append("EventId18456ExclusionPatterns: " + string.Join(", ", string_10) + "; ");
		}
	}
}
