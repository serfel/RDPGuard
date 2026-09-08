using System;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace rdpguard.lib;

[JsonConverter(typeof(Class136))]
internal class IPListEntry
{
	private class Class136 : JsonConverter
	{
		public override void WriteJson(JsonWriter jsonWriter_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			IPListEntry iPListEntry = (IPListEntry)object_0;
			jsonWriter_0.WriteStartObject();
			jsonWriter_0.WritePropertyName("_");
			jsonSerializer_0.Serialize(jsonWriter_0, (object)new object[2] { iPListEntry.gclass24_0, iPListEntry.Comment });
			jsonWriter_0.WriteEndObject();
		}

		public override object ReadJson(JsonReader jsonReader_0, Type type_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			JToken value = JObject.Load(jsonReader_0).Properties().First()
				.Value;
			return new IPListEntry
			{
				gclass24_0 = value[(object)0].ToObject<GClass24>(),
				Comment = (string)value[(object)1]
			};
		}

		public override bool CanConvert(Type type_0)
		{
			return typeof(IPListEntry).IsAssignableFrom(type_0);
		}
	}

	public GClass24 gclass24_0 = GClass24.GClass24_0;

	public string Comment;

	public IPListEntry()
	{
	}

	public IPListEntry(string string_0, string string_1)
	{
		gclass24_0 = GClass24.smethod_1(string_0);
		Comment = string_1?.Trim();
	}

	public virtual bool vmethod_0(GClass24 gclass24_1)
	{
		if (!(gclass24_1 == gclass24_0))
		{
			return gclass24_0.method_1(gclass24_1);
		}
		return true;
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (this == obj)
		{
			return true;
		}
		if (obj.GetType() != GetType())
		{
			return false;
		}
		return method_1((IPListEntry)obj);
	}

	public bool method_0(IPListEntry iplistEntry_0)
	{
		if ((object)iplistEntry_0 == null)
		{
			return false;
		}
		if ((object)this == iplistEntry_0)
		{
			return true;
		}
		return method_1(iplistEntry_0);
	}

	private bool method_1(IPListEntry iplistEntry_0)
	{
		if (gclass24_0 == iplistEntry_0.gclass24_0)
		{
			return string.Equals(Comment, iplistEntry_0.Comment);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return ((0x50C5D1F ^ (((object)gclass24_0 != null) ? gclass24_0.GetHashCode() : 0)) * 16777619) ^ ((Comment != null) ? Comment.GetHashCode() : 0);
	}

	public static bool operator ==(IPListEntry _set1, IPListEntry _set2)
	{
		return _set1?.method_0(_set2) ?? ((object)_set2 == null);
	}

	public static bool operator !=(IPListEntry _set1, IPListEntry _set2)
	{
		return !(_set1 == _set2);
	}

	public static IPListEntry DeserializeXml(string _xml)
	{
		try
		{
			XmlElement xmlElement_ = GClass12.smethod_2(_xml).XmlElement_0;
			IPListEntry iPListEntry = new IPListEntry();
			if (xmlElement_["comment"] != null)
			{
				iPListEntry.Comment = Encoding.UTF8.GetString(Convert.FromBase64String(xmlElement_["comment"].InnerText));
			}
			XmlElement xmlElement = xmlElement_["from"];
			object obj;
			if (xmlElement == null)
			{
				obj = null;
			}
			else
			{
				obj = xmlElement.InnerText;
				if (obj != null)
				{
					goto IL_00a0;
				}
			}
			bool flag = true;
			obj = xmlElement_["ip"]?.InnerText;
			goto IL_00a0;
			IL_00a0:
			string text = (string)obj;
			if (text.Contains("*"))
			{
				if (IPAddress.TryParse(text.Replace("*", "0"), out var address) && (IPAddress.TryParse(text.Replace("*", "255"), out var address2) ? true : false))
				{
					iPListEntry.gclass24_0 = new GClass24(address, address2);
					return iPListEntry;
				}
				Class208.smethod_0("IPListEntry::DeserializeXml: unable to parse " + text);
				return null;
			}
			if (!IPAddress.TryParse(text, out var address3))
			{
				Class208.smethod_0("IPListEntry::DeserializeXml: unable to parse " + text);
				return null;
			}
			if (IPAddress.TryParse(xmlElement_["to"]?.InnerText, out var address4))
			{
				GStruct1 gStruct = GClass25.smethod_0(address3);
				GStruct1 gStruct2 = GClass25.smethod_0(address4);
				if (gStruct > gStruct2)
				{
					Class208.smethod_0($"IPListEntry::DeserializeXml: invalid range {address3}-{address4} - start IP must be less than end IP");
					return null;
				}
				iPListEntry.gclass24_0 = new GClass24(gStruct, gStruct2);
			}
			else
			{
				iPListEntry.gclass24_0 = new GClass24(address3);
			}
			return iPListEntry;
		}
		catch (Exception arg)
		{
			Class208.smethod_0($"IPListEntry::DeserializeXml: unable to parse {_xml}: {arg}");
			return null;
		}
	}
}
