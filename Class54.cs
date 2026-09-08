using System.IO;
using System.Windows.Forms;
using Properties;

internal sealed class Class54 : Class53
{
	public bool bool_0;

	private string string_0;

	private string string_1;

	public string String_1
	{
		get
		{
			if (string.IsNullOrEmpty(Text))
			{
				return string_0;
			}
			if (File.Exists(Text))
			{
				return Path.GetDirectoryName(Text);
			}
			if (Directory.Exists(Text))
			{
				return Text;
			}
			return null;
		}
		set
		{
			string_0 = value;
		}
	}

	public string String_2
	{
		private get
		{
			return string_1;
		}
		set
		{
			string_1 = value;
		}
	}

	public Class54()
	{
		image_0 = Resources.folder16;
		image_1 = Resources.folder_16_gray;
	}

	protected override void OnFormClosing()
	{
		if (bool_0)
		{
			method_2();
		}
		else
		{
			method_1();
		}
	}

	private void method_1()
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		if (!string.IsNullOrEmpty(String_2))
		{
			openFileDialog.Filter = String_2;
		}
		if (!string.IsNullOrEmpty(String_1))
		{
			openFileDialog.InitialDirectory = String_1;
		}
		if (DialogResult.OK == openFileDialog.ShowDialog())
		{
			Text = openFileDialog.FileName;
		}
	}

	private void method_2()
	{
		Class42 @class = new Class42
		{
			String_0 = String_1
		};
		if (@class.method_0(base.Handle))
		{
			Text = @class.String_1[0];
		}
	}
}
