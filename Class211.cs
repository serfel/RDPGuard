using System;
using System.IO;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

internal static class Class211
{
	private static readonly SecureRandom secureRandom_0 = new SecureRandom();

	public static byte[] smethod_0(byte[] byte_0, byte[] byte_1, byte[] byte_2 = null)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		if (byte_1 != null && byte_1.Length == 32)
		{
			if (byte_0 != null && byte_0.Length != 0)
			{
				byte[] array = byte_2;
				if (array == null)
				{
					array = new byte[0];
				}
				byte_2 = array;
				byte[] array2 = new byte[16];
				secureRandom_0.NextBytes(array2, 0, array2.Length);
				GcmBlockCipher val = new GcmBlockCipher((IBlockCipher)new AesEngine());
				AeadParameters val2 = new AeadParameters(new KeyParameter(byte_1), 128, array2, byte_2);
				val.Init(true, (ICipherParameters)(object)val2);
				byte[] array3 = new byte[val.GetOutputSize(byte_0.Length)];
				int num = val.ProcessBytes(byte_0, 0, byte_0.Length, array3, 0);
				val.DoFinal(array3, num);
				using MemoryStream memoryStream = new MemoryStream();
				using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream))
				{
					binaryWriter.Write(byte_2);
					binaryWriter.Write(array2);
					binaryWriter.Write(array3);
				}
				return memoryStream.ToArray();
			}
			throw new ArgumentException("Secret Message Required!", "secretMessage");
		}
		throw new ArgumentException($"Key needs to be {256} bit!", "key");
	}

	public static byte[] smethod_1(byte[] byte_0, byte[] byte_1, int int_0 = 0)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		if (byte_1 != null && byte_1.Length == 32)
		{
			if (byte_0 != null && byte_0.Length != 0)
			{
				using (MemoryStream input = new MemoryStream(byte_0))
				{
					using BinaryReader binaryReader = new BinaryReader(input);
					byte[] array = binaryReader.ReadBytes(int_0);
					byte[] array2 = binaryReader.ReadBytes(16);
					GcmBlockCipher val = new GcmBlockCipher((IBlockCipher)new AesEngine());
					AeadParameters val2 = new AeadParameters(new KeyParameter(byte_1), 128, array2, array);
					val.Init(false, (ICipherParameters)(object)val2);
					byte[] array3 = binaryReader.ReadBytes(byte_0.Length - int_0 - array2.Length);
					byte[] array4 = new byte[val.GetOutputSize(array3.Length)];
					try
					{
						int num = val.ProcessBytes(array3, 0, array3.Length, array4, 0);
						val.DoFinal(array4, num);
					}
					catch (InvalidCipherTextException)
					{
						return null;
					}
					return array4;
				}
			}
			throw new ArgumentException("Encrypted Message Required!", "encryptedMessage");
		}
		throw new ArgumentException($"Key needs to be {256} bit!", "key");
	}

	public static byte[] smethod_2(byte[] byte_0, string string_0, byte[] byte_1 = null)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		byte[] array = byte_1;
		if (array == null)
		{
			array = new byte[0];
		}
		byte_1 = array;
		if (!string.IsNullOrWhiteSpace(string_0) && string_0.Length >= 1)
		{
			if (byte_0 == null || byte_0.Length == 0)
			{
				throw new ArgumentException("Secret Message Required!", "secretMessage");
			}
			Pkcs5S2ParametersGenerator val = new Pkcs5S2ParametersGenerator();
			byte[] array2 = new byte[16];
			((Random)(object)secureRandom_0).NextBytes(array2);
			((PbeParametersGenerator)val).Init(PbeParametersGenerator.Pkcs5PasswordToBytes(string_0.ToCharArray()), array2, 10000);
			KeyParameter val2 = (KeyParameter)((PbeParametersGenerator)val).GenerateDerivedMacParameters(256);
			byte[] array3 = new byte[array2.Length + byte_1.Length];
			Array.Copy(byte_1, array3, byte_1.Length);
			Array.Copy(array2, 0, array3, byte_1.Length, array2.Length);
			return smethod_0(byte_0, val2.GetKey(), array3);
		}
		throw new ArgumentException($"Must have a password of at least {1} characters!", "password");
	}

	public static byte[] smethod_3(byte[] byte_0, string string_0, int int_0 = 0)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		if (!string.IsNullOrWhiteSpace(string_0) && string_0.Length >= 1)
		{
			if (byte_0 == null || byte_0.Length == 0)
			{
				throw new ArgumentException("Encrypted Message Required!", "encryptedMessage");
			}
			Pkcs5S2ParametersGenerator val = new Pkcs5S2ParametersGenerator();
			byte[] array = new byte[16];
			Array.Copy(byte_0, int_0, array, 0, array.Length);
			((PbeParametersGenerator)val).Init(PbeParametersGenerator.Pkcs5PasswordToBytes(string_0.ToCharArray()), array, 10000);
			KeyParameter val2 = (KeyParameter)((PbeParametersGenerator)val).GenerateDerivedMacParameters(256);
			return smethod_1(byte_0, val2.GetKey(), array.Length + int_0);
		}
		throw new ArgumentException($"Must have a password of at least {1} characters!", "password");
	}
}
