using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

internal static class Class218
{
	public static string smethod_0(string string_0, string string_1)
	{
		if (!string.IsNullOrEmpty(string_0) && !string.IsNullOrEmpty(string_1))
		{
			using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
			{
				byte[] bytes = Encoding.Unicode.GetBytes(string_0);
				byte[] bytes2 = Encoding.ASCII.GetBytes(string_1.Length.ToString());
				using PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(string_1, bytes2);
				using ICryptoTransform transform = rijndaelManaged.CreateEncryptor(passwordDeriveBytes.GetBytes(32), passwordDeriveBytes.GetBytes(16));
				using MemoryStream memoryStream = new MemoryStream();
				CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
				cryptoStream.Write(bytes, 0, bytes.Length);
				cryptoStream.FlushFinalBlock();
				return Convert.ToBase64String(memoryStream.ToArray());
			}
		}
		return null;
	}

	public static string smethod_1(string string_0, string string_1)
	{
		string result = null;
		try
		{
			if (string.IsNullOrEmpty(string_0) || false || string.IsNullOrEmpty(string_1))
			{
				return result;
			}
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			byte[] array = Convert.FromBase64String(string_0);
			byte[] bytes = Encoding.ASCII.GetBytes(string_1.Length.ToString());
			using PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(string_1, bytes);
			using ICryptoTransform transform = rijndaelManaged.CreateDecryptor(passwordDeriveBytes.GetBytes(32), passwordDeriveBytes.GetBytes(16));
			using MemoryStream stream = new MemoryStream(array);
			CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Read);
			byte[] array2 = new byte[array.Length];
			int num = cryptoStream.Read(array2, 0, array2.Length);
			if (num > 0)
			{
				result = Encoding.Unicode.GetString(array2, 0, num);
			}
		}
		catch (CryptographicException)
		{
		}
		return result;
	}
}
