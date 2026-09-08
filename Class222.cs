using System;
using System.IO;
using System.Reflection;
using System.Threading;

internal sealed class Class222
{
	private delegate string Delegate7(int int_0);

	private static Assembly assembly_0;

	private static object object_0;

	private static int int_0;

	private static string[] string_0;

	private static Delegate7 delegate7_0;

	static Class222()
	{
		object_0 = new object();
		delegate7_0 = smethod_1;
	}

	public static void smethod_0()
	{
		if ((int_0 != 0) ? true : false)
		{
			return;
		}
		try
		{
			Monitor.Enter(object_0);
			if (int_0 == 0)
			{
				AppDomain.CurrentDomain.ResourceResolve += smethod_2;
				int_0 = 1;
			}
		}
		finally
		{
			Monitor.Exit(object_0);
		}
	}

	public static string smethod_1(int int_1)
	{
		char[] array = "\u007f|D{`".ToCharArray();
		int num = array.Length;
		while (--num >= 0)
		{
			array[num] = (char)(array[num] ^ 0x9F ^ int_1);
		}
		return new string(array);
	}

	public static Assembly smethod_2(object object_1, ResolveEventArgs resolveEventArgs_0)
	{
		return smethod_3(resolveEventArgs_0.Name);
	}

	private static Assembly smethod_3(string string_1)
	{
		if (string_0 == null)
		{
			Monitor.Enter(object_0);
			try
			{
				if (string_0 == null)
				{
					Stream manifestResourceStream = typeof(Class222).Assembly.GetManifestResourceStream(delegate7_0(136));
					if (manifestResourceStream != null)
					{
						assembly_0 = smethod_4(manifestResourceStream);
					}
				}
			}
			finally
			{
				Monitor.Exit(object_0);
			}
		}
		if (string_0 != null)
		{
			string[] array = string_0;
			string[] array2 = array;
			foreach (string b in array2)
			{
				if (string.Equals(string_1, b, StringComparison.OrdinalIgnoreCase))
				{
					return assembly_0;
				}
			}
		}
		return null;
	}

	private static Assembly smethod_4(Stream stream_0)
	{
		BinaryReader binaryReader = new BinaryReader(Class234.smethod_0(stream_0));
		int num = binaryReader.ReadInt32() ^ 0x234BD6F6;
		string[] array = new string[num];
		for (int i = 0; i < num; i++)
		{
			string text = binaryReader.ReadString();
			char[] array2 = new char[text.Length];
			for (int j = 0; j < array2.Length; j++)
			{
				array2[j] = (char)(text[j] ^ 0xED6);
			}
			array[i] = new string(array2);
		}
		string_0 = array;
		num = binaryReader.ReadInt32() ^ 0x57DDBC9F;
		byte[] array3 = new byte[num];
		binaryReader.Read(array3, 0, num);
		return Assembly.Load(array3);
	}
}
