using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

internal sealed class Class125 : Class113
{
	public GEnum11 genum11_0;

	public Class131 class131_0 = new Class131();

	private static readonly string string_10 = "st";

	private static readonly string string_11 = "as";

	public override int Int32_0 => 5;

	public override ushort[] UInt16_1 => new ushort[1] { 25 };

	public override void vmethod_0(Dictionary<string, object> dictionary_0)
	{
		dictionary_0.Add(string_10, (int)genum11_0);
		dictionary_0.Add(string_11, class131_0);
	}

	protected override void DeserializeEngineSpeificFields(JObject _jo)
	{
		bool_2 = false;
		genum11_0 = (GEnum11)(int)_jo[string_10];
		class131_0 = _jo[string_11].ToObject<Class131>();
	}

	public string vmethod_2()
	{
		return Class195.Class195_0[genum11_0];
	}

	public void vmethod_3(StringBuilder stringBuilder_0)
	{
		stringBuilder_0.Append(class131_0.method_0());
	}
}
