using System.Collections.Generic;
using Newtonsoft.Json.Linq;

internal sealed class Class121 : Class113
{
	public GEnum10 genum10_0;

	private static readonly string string_10 = "st";

	public override int Int32_0 => 7;

	public override ushort[] UInt16_1 => new ushort[1] { 110 };

	public override void OnFormClosing(Dictionary<string, object> dictionary_0)
	{
		dictionary_0.Add(string_10, (int)genum10_0);
	}

	protected override void DeserializeEngineSpeificFields(JObject _jo)
	{
		bool_2 = false;
		genum10_0 = (GEnum10)(int)_jo[string_10];
	}

	public string AdjustFormSize()
	{
		return Class194.Class194_0[genum10_0];
	}
}
