using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.Win32.SafeHandles;

internal sealed class Class180
{
	public delegate void Delegate4(byte[] byte_0);

	public delegate void Delegate5();

	private Delegate4 delegate4_0;

	private Delegate5 delegate5_0;

	private FileStream fileStream_0;

	private SafeFileHandle safeFileHandle_0;

	private bool bool_0;

	private string string_0;

	public bool Boolean_0
	{
		get
		{
			return bool_0;
		}
		private set
		{
			bool_0 = value;
		}
	}

	public event Delegate4 Event_0
	{
		add
		{
			Delegate4 @delegate = delegate4_0;
			Delegate4 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate4 value2 = (Delegate4)Delegate.Combine(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate4_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		remove
		{
			Delegate4 @delegate = delegate4_0;
			Delegate4 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate4 value2 = (Delegate4)Delegate.Remove(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate4_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern SafeFileHandle CreateFile(string string_1, uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, uint uint_3, IntPtr intptr_1);

	public void method_0(string string_1)
	{
		string_0 = string_1;
		safeFileHandle_0 = CreateFile(string_0, 3221225472u, 0u, IntPtr.Zero, 3u, 1073741824u, IntPtr.Zero);
		if (!safeFileHandle_0.IsInvalid)
		{
			Boolean_0 = true;
			fileStream_0 = new FileStream(safeFileHandle_0, FileAccess.ReadWrite, 16777216, isAsync: true);
			Thread thread = new Thread(method_1);
			thread.IsBackground = true;
			thread.Start();
		}
	}

	private void method_1()
	{
		byte[] array = new byte[16777216];
		while (true)
		{
			int num = 0;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				try
				{
					if (fileStream_0.Read(array, 0, 4) == 0)
					{
						break;
					}
					int num2 = BitConverter.ToInt32(array, 0);
					do
					{
						int num3 = fileStream_0.Read(array, 0, Math.Min(num2 - num, 16777216));
						memoryStream.Write(array, 0, num3);
						num += num3;
					}
					while (num < num2);
					goto IL_0082;
				}
				catch
				{
				}
				goto end_IL_001a;
				IL_0082:
				if (num == 0)
				{
					break;
				}
				delegate4_0?.Invoke(memoryStream.ToArray());
				continue;
				end_IL_001a:;
			}
			break;
		}
		if (Boolean_0)
		{
			method_3();
			delegate5_0?.Invoke();
		}
	}

	public void method_2(byte[] byte_0)
	{
		fileStream_0.Write(BitConverter.GetBytes(byte_0.Length), 0, 4);
		fileStream_0.Write(byte_0, 0, byte_0.Length);
		fileStream_0.Flush();
	}

	private void method_3()
	{
		Boolean_0 = false;
		string_0 = null;
		if (fileStream_0 != null)
		{
			fileStream_0.Close();
			fileStream_0 = null;
		}
		if (safeFileHandle_0 != null)
		{
			safeFileHandle_0.Close();
			safeFileHandle_0 = null;
		}
	}
}
