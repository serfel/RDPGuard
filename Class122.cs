using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

internal sealed class Class122 : Class113
{
	private bool? nullable_0;

	public string string_10 = string.Empty;

	private static readonly string string_11 = "etm";

	private static readonly string string_12 = "e";

	public override int Int32_0 => 0;

	public override ushort[] UInt16_1 => new ushort[1] { Class130.UInt16_0 };

	public bool Boolean_0
	{
		get
		{
			return nullable_0.GetValueOrDefault(!Class178.Boolean_2);
		}
		set
		{
			nullable_0 = value;
		}
	}

	public override void OnFormClosing(Dictionary<string, object> dictionary_0)
	{
		dictionary_0.Add(string_11, Boolean_0);
		dictionary_0.Add(string_12, string_10);
	}

	protected override void DeserializeEngineSpeificFields(JObject _jo)
	{
		Boolean_0 = (bool)_jo[string_11];
		string_10 = (string)_jo[string_12];
	}

	public string AdjustFormSize()
	{
		if (!bool_0)
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder($"Enabled: {bool_0}; ");
		if (string_10.Length > 0)
		{
			stringBuilder.Append("Exclusions: " + string_10.Replace("\r\n", " OR ") + "; ");
		}
		stringBuilder.Append($"EnableTrafficMonitoring: {Boolean_0}; ");
		if (!Boolean_0)
		{
			return stringBuilder.ToString();
		}
		InitializeFormPosition(stringBuilder);
		return stringBuilder.ToString();
	}
}
