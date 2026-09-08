using System.Collections.Generic;
using System.Net.Sockets;
using Newtonsoft.Json.Linq;

internal sealed class Class124 : Class113
{
	public override int Int32_0 => 10;

	public override ushort[] UInt16_1 => new ushort[1] { 5060 };

	public ProtocolType[] ProtocolType => new ProtocolType[2]
	{
		System.Net.Sockets.ProtocolType.Tcp,
		System.Net.Sockets.ProtocolType.Udp
	};

	public override void OnFormClosing(Dictionary<string, object> dictionary_0)
	{
	}

	protected override void DeserializeEngineSpeificFields(JObject _jo)
	{
	}
}
