using System.Collections.Generic;
using Newtonsoft.Json.Linq;

internal sealed class Class116 : Class113
{
	public GEnum8 genum8_0;

	private static readonly string string_10 = "st";

	public override int Int32_0 => 6;

	public override ushort[] UInt16_1 => new ushort[1] { 143 };

	public override void vmethod_0(Dictionary<string, object> dictionary_0)
	{
		dictionary_0.Add(string_10, (int)genum8_0);
	}

	protected override void DeserializeEngineSpeificFields(JObject _jo)
	{
		bool_2 = false;
		genum8_0 = (GEnum8)(int)_jo[string_10];
	}

	public string vmethod_2()
	{
		return Class192.Class192_0[genum8_0];
	}
}
