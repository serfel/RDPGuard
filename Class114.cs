using System.Collections.Generic;
using Newtonsoft.Json.Linq;

internal sealed class Class114 : Class113
{
	public static readonly string[] string_10 = new string[2] { "530", "534" };

	public GEnum7 genum7_0;

	private static readonly string string_11 = "st";

	public override int Int32_0 => 3;

	public override ushort[] UInt16_1 => new ushort[1] { 21 };

	public override void OnFormClosing(Dictionary<string, object> dictionary_0)
	{
		dictionary_0.Add(string_11, (int)genum7_0);
	}

	protected override void DeserializeEngineSpeificFields(JObject _jo)
	{
		bool_2 = false;
		genum7_0 = (GEnum7)(int)_jo[string_11];
	}

	public string AdjustFormSize()
	{
		return Class191.Class191_0[genum7_0];
	}
}
