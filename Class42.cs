using System;
using System.Windows.Forms;

internal sealed class Class42
{
	private readonly OpenFileDialog openFileDialog_0 = new OpenFileDialog
	{
		Multiselect = false,
		CheckFileExists = false
	};

	public string String_0
	{
		get
		{
			return openFileDialog_0.InitialDirectory;
		}
		set
		{
			openFileDialog_0.InitialDirectory = value;
		}
	}

	public string[] String_1 => openFileDialog_0.FileNames;

	public bool Boolean_0
	{
		set
		{
			openFileDialog_0.Multiselect = value;
		}
	}

	public bool method_0(IntPtr intptr_0)
	{
		if (Class178.Boolean_1)
		{
			Class73 @class = new Class73("System.Windows.Forms");
			Type type_ = @class.method_0("FileDialogNative.IFileDialog");
			object obj = @class.method_3(openFileDialog_0, "CreateVistaDialog");
			@class.method_3(openFileDialog_0, "OnBeforeVistaDialog", obj);
			uint num = (uint)@class.method_4(openFileDialog_0, typeof(FileDialog), "GetOptions");
			num |= (uint)@class.method_5("FileDialogNative.FOS", "FOS_PICKFOLDERS");
			@class.method_4(obj, type_, "SetOptions", num);
			uint num2 = 0u;
			object obj2 = @class.method_1("FileDialog.VistaDialogEvents", openFileDialog_0);
			object[] array = new object[2] { obj2, 0u };
			@class.method_4(obj, type_, "Advise", array);
			num2 = (uint)array[1];
			try
			{
				return (int)@class.method_4(obj, type_, "Show", intptr_0) == 0;
			}
			finally
			{
				@class.method_4(obj, type_, "Unadvise", num2);
				GC.KeepAlive(obj2);
			}
		}
		FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
		{
			SelectedPath = String_0
		};
		using (folderBrowserDialog)
		{
			try
			{
				return DialogResult.OK == folderBrowserDialog.ShowDialog();
			}
			finally
			{
				openFileDialog_0.FileName = folderBrowserDialog.SelectedPath;
			}
		}
	}
}
