using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

public class GClass12 : XmlDocument
{
	public XmlElement XmlElement_0 => base.DocumentElement;

	public IEnumerable<XmlNode> IEnumerable_0 => XmlElement_0.ChildNodes.Cast<XmlNode>();

	private GClass12()
	{
	}

	public static GClass12 smethod_0(string string_0)
	{
		GClass12 gClass = new GClass12();
		gClass.Load(string_0);
		return gClass;
	}

	public static GClass12 smethod_1(Stream stream_0)
	{
		GClass12 gClass = new GClass12();
		gClass.Load(stream_0);
		return gClass;
	}

	public static GClass12 smethod_2(string string_0)
	{
		GClass12 gClass = new GClass12();
		gClass.LoadXml(string_0);
		return gClass;
	}

	public override void Load(string filename)
	{
		XmlResolver = null;
		base.Load(filename);
	}

	public override void Load(Stream inStream)
	{
		XmlResolver = null;
		base.Load(inStream);
	}

	public override void Load(TextReader txtReader)
	{
		XmlResolver = null;
		base.Load(txtReader);
	}

	public override void Load(XmlReader reader)
	{
		XmlResolver = null;
		base.Load(reader);
	}

	public override void LoadXml(string xml)
	{
		XmlResolver = null;
		base.LoadXml(xml);
	}
}
