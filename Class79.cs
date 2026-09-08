using System.Collections.Generic;
using System.Windows.Forms;

internal sealed class Class79 : WebBrowser
{
	public Class79(string string_0)
	{
		base.AllowWebBrowserDrop = false;
		base.IsWebBrowserContextMenuEnabled = false;
		base.WebBrowserShortcutsEnabled = false;
		Dock = DockStyle.Fill;
		base.TabIndex = 0;
		base.DocumentText = string_0;
	}

	public void method_0(string string_0, string string_1)
	{
		HtmlElement htmlElement = method_10(string_0);
		if (null != htmlElement)
		{
			htmlElement.InnerText = string_1;
		}
	}

	public void method_1(string string_0, string string_1)
	{
		HtmlElement htmlElement = method_10(string_0);
		if (null != htmlElement)
		{
			htmlElement.InnerHtml = string_1;
		}
	}

	public void method_2(string string_0, bool bool_0)
	{
		method_3(string_0, (bool_0 ? true : false) ? "display: inline" : "display: none");
	}

	public void method_3(string string_0, string string_1)
	{
		HtmlElement htmlElement = method_10(string_0);
		if (null != htmlElement)
		{
			htmlElement.Style = string_1;
		}
	}

	public void method_4(string string_0, string string_1)
	{
		method_10(string_0)?.SetAttribute("className", string_1);
	}

	public void method_5(string string_0, string string_1)
	{
		method_10(string_0)?.SetAttribute("src", "data:image/png;base64," + string_1);
		method_2(string_0, bool_0: true);
	}

	public void method_6(Dictionary<string, HtmlElementEventHandler> dictionary_0)
	{
		dictionary_0.smethod_0(method_11);
	}

	public void InitializeComponent(string string_0, HtmlElementEventHandler htmlElementEventHandler_0)
	{
		HtmlElement htmlElement = method_10(string_0);
		if (null != htmlElement)
		{
			htmlElement.Click -= htmlElementEventHandler_0;
			htmlElement.Click += htmlElementEventHandler_0;
		}
	}

	public void method_8(Dictionary<string, HtmlElementEventHandler> dictionary_0)
	{
		dictionary_0.smethod_0(method_12);
	}

	public void method_9(string string_0, HtmlElementEventHandler htmlElementEventHandler_0)
	{
		HtmlElement htmlElement = method_10(string_0);
		if (null != htmlElement)
		{
			htmlElement.MouseUp -= htmlElementEventHandler_0;
			htmlElement.MouseUp += htmlElementEventHandler_0;
		}
	}

	public HtmlElement method_10(string string_0)
	{
		return base.Document.GetElementById(string_0);
	}

	private void method_11(KeyValuePair<string, HtmlElementEventHandler> keyValuePair_0)
	{
		InitializeComponent(keyValuePair_0.Key, keyValuePair_0.Value);
	}

	private void method_12(KeyValuePair<string, HtmlElementEventHandler> keyValuePair_0)
	{
		method_9(keyValuePair_0.Key, keyValuePair_0.Value);
	}
}
