using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

internal static class Class216
{
	private static readonly byte[] byte_0 = Encoding.ASCII.GetBytes("3A309E578D49");

	public static string smethod_0(string string_0, string string_1)
	{
		if (!string.IsNullOrEmpty(string_0) && !string.IsNullOrEmpty(string_1))
		{
			using (Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(string_1, byte_0))
			{
				using DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
				dESCryptoServiceProvider.Key = rfc2898DeriveBytes.GetBytes(dESCryptoServiceProvider.KeySize / 8);
				using ICryptoTransform transform = dESCryptoServiceProvider.CreateEncryptor(dESCryptoServiceProvider.Key, dESCryptoServiceProvider.IV);
				using MemoryStream memoryStream = new MemoryStream();
				memoryStream.Write(BitConverter.GetBytes(dESCryptoServiceProvider.IV.Length), 0, 4);
				memoryStream.Write(dESCryptoServiceProvider.IV, 0, dESCryptoServiceProvider.IV.Length);
				CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
				byte[] bytes = Encoding.Default.GetBytes(string_0);
				cryptoStream.Write(bytes, 0, bytes.Length);
				cryptoStream.FlushFinalBlock();
				return Convert.ToBase64String(memoryStream.ToArray());
			}
		}
		return string.Empty;
	}

	public static string smethod_1(string string_0, string string_1)
	{
		if (!string.IsNullOrEmpty(string_0) && !string.IsNullOrEmpty(string_1))
		{
			string result = null;
			using Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(string_1, byte_0);
			using (MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(string_0)))
			{
				using DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
				dESCryptoServiceProvider.Key = rfc2898DeriveBytes.GetBytes(dESCryptoServiceProvider.KeySize / 8);
				dESCryptoServiceProvider.IV = smethod_2(memoryStream);
				using ICryptoTransform transform = dESCryptoServiceProvider.CreateDecryptor(dESCryptoServiceProvider.Key, dESCryptoServiceProvider.IV);
				result = new StreamReader(new CryptoStream(memoryStream, transform, CryptoStreamMode.Read)).ReadToEnd();
			}
			return result;
		}
		return string.Empty;
	}

	private static byte[] smethod_2(Stream stream_0)
	{
		byte[] array = new byte[4];
		if (stream_0.Read(array, 0, array.Length) != array.Length)
		{
			throw new SystemException("Stream did not contain properly formatted byte array");
		}
		byte[] array2 = new byte[BitConverter.ToInt32(array, 0)];
		if (stream_0.Read(array2, 0, array2.Length) != array2.Length)
		{
			throw new SystemException("Did not read byte array properly");
		}
		return array2;
	}
}
