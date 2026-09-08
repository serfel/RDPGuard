using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

internal static class Class217
{
	private static readonly byte[] byte_0 = Encoding.ASCII.GetBytes("3A309E578D49");

	public static string smethod_0(string string_0, string string_1)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			throw new ArgumentNullException("plainText");
		}
		if (string.IsNullOrEmpty(string_1))
		{
			throw new ArgumentNullException("sharedSecret");
		}
		using Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(string_1, byte_0);
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		using ICryptoTransform transform = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV);
		using MemoryStream memoryStream = new MemoryStream();
		memoryStream.Write(BitConverter.GetBytes(rijndaelManaged.IV.Length), 0, 4);
		memoryStream.Write(rijndaelManaged.IV, 0, rijndaelManaged.IV.Length);
		CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
		byte[] bytes = Encoding.Default.GetBytes(string_0);
		cryptoStream.Write(bytes, 0, bytes.Length);
		cryptoStream.FlushFinalBlock();
		return Convert.ToBase64String(memoryStream.ToArray());
	}

	public static string smethod_1(string string_0, string string_1)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			throw new ArgumentNullException("cipherText");
		}
		if (string.IsNullOrEmpty(string_1))
		{
			throw new ArgumentNullException("sharedSecret");
		}
		string result = null;
		using Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(string_1, byte_0);
		using (MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(string_0)))
		{
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = smethod_2(memoryStream);
			using ICryptoTransform transform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
			result = new StreamReader(new CryptoStream(memoryStream, transform, CryptoStreamMode.Read)).ReadToEnd();
		}
		return result;
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
