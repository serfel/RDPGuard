using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

internal sealed class Class126 : Class113
{
	public static readonly string string_10 = "EventData1=3003,EventData18=HttpRequestValidationException\r\nEventData1=3005,EventData18=HttpException,EventData19=*ValidateInputIfRequiredByConfig*\r\n";

	public bool bool_3;

	public string string_11 = string.Empty;

	public override int Int32_0 => 9;

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

	public override void OnFormClosing(Dictionary<string, object> dictionary_0)
	{
		dictionary_0.Add("ucr", bool_3);
		dictionary_0.Add("cr", string_11);
	}

	protected override void DeserializeEngineSpeificFields(JObject _jo)
	{
		base.GEnum4_0 = GEnum4.const_1;
		bool_3 = (bool)_jo["ucr"];
		string_11 = (string)_jo["cr"];
	}

	public void AdjustFormSize(StringBuilder stringBuilder_0)
	{
		stringBuilder_0.Append($"UseCustomRules: {bool_3}; ");
		if (bool_3)
		{
			stringBuilder_0.Append("CustomRules: " + string_11.Replace("\r\n", " OR ") + "; ");
		}
	}
}
