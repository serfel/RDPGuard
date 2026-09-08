using System;
using System.Text;

internal abstract class Class143
{
	public virtual void OnFormClosing()
	{
		AppDomain.CurrentDomain.UnhandledException += method_1;
	}

	public void method_0(Exception exception_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine(Class138.String_1 + " (" + Class138.String_0 + ")");
		stringBuilder.AppendLine();
		stringBuilder.AppendLine($"Exception: {exception_0.GetType()}");
		stringBuilder.AppendLine("Message: " + exception_0.Message);
		stringBuilder.AppendLine("Stack Trace:\r\n" + exception_0.StackTrace);
		if (exception_0.InnerException != null)
		{
			stringBuilder.AppendLine($"\r\nInner Exception: {exception_0.InnerException}");
		}
		InitializeFormPosition(stringBuilder.ToString());
	}

	protected abstract void InitializeFormPosition(string string_0);

	private void method_1(object sender, UnhandledExceptionEventArgs e)
	{
		method_0((Exception)e.ExceptionObject);
	}
}
