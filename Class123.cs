using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

internal sealed class Class123 : Class113
{
	public bool bool_3;

	public bool bool_4;

	public override int Int32_0 => 1;

	public override void vmethod_0(Dictionary<string, object> dictionary_0)
	{
		dictionary_0.Add("xff", bool_3);
		dictionary_0.Add("xff_fallback", bool_4);
	}

	protected override void DeserializeEngineSpeificFields(JObject _jo)
	{
		JToken val = default(JToken);
		if (_jo.TryGetValue("xff", out val))
		{
			bool_3 = (bool)val;
		}
		JToken val2 = default(JToken);
		if (_jo.TryGetValue("xff_fallback", out val2))
		{
			bool_4 = (bool)val2;
		}
	}

	public string vmethod_2()
	{
		return "IIS";
	}

	public void vmethod_3(StringBuilder stringBuilder_0)
	{
		stringBuilder_0.Append($"UseXForwardedFor: {bool_3}; ");
		stringBuilder_0.Append($"XffFallbackToRemoteAddr: {bool_4}; ");
	}
}
