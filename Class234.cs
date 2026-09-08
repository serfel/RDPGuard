using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

internal sealed class Class234
{
	static Class234()
	{
	}

	public static Stream smethod_0(Stream stream_0)
	{
		BinaryReader binaryReader = new BinaryReader(stream_0);
		int num = binaryReader.ReadUInt16();
		byte[] array = new byte[num];
		binaryReader.Read(array, 0, num);
		int num2 = binaryReader.ReadByte();
		byte[] array2 = new byte[num2];
		binaryReader.Read(array2, 0, array2.Length);
		for (int i = 0; i < num; i++)
		{
			array[i] ^= array2[i % num2];
		}
		byte b = 0;
		SymmetricAlgorithm symmetricAlgorithm = null;
		using (BinaryReader binaryReader2 = new BinaryReader(new MemoryStream(array, writable: false)))
		{
			binaryReader2.ReadString();
			b = binaryReader2.ReadByte();
			byte byte_ = binaryReader2.ReadByte();
			byte b2 = binaryReader2.ReadByte();
			int num3 = binaryReader2.ReadByte();
			byte[] array3 = new byte[num3];
			binaryReader2.Read(array3, 0, num3);
			if (b2 < 64)
			{
				binaryReader2.Read(array3, 0, num3);
			}
			else
			{
				byte[] publicKey = Assembly.GetExecutingAssembly().GetName().GetPublicKey();
				if (publicKey == null)
				{
					throw new InvalidOperationException();
				}
				Buffer.BlockCopy(publicKey, b2 + 12, array3, 0, num3);
			}
			symmetricAlgorithm = smethod_1(byte_);
			symmetricAlgorithm.IV = array2;
			symmetricAlgorithm.Key = array3;
		}
		MemoryStream memoryStream = new MemoryStream();
		if ((b & 2) != 0)
		{
			using (CryptoStream stream_1 = new CryptoStream(binaryReader.BaseStream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Read))
			{
				smethod_3(stream_1, memoryStream);
			}
			if ((b & 1) != 0)
			{
				memoryStream.Position = 0L;
				MemoryStream memoryStream2 = new MemoryStream();
				Class229.smethod_0(memoryStream, memoryStream2);
				memoryStream = memoryStream2;
			}
		}
		else if (b == 1)
		{
			Class229.smethod_0(binaryReader.BaseStream, memoryStream);
		}
		else
		{
			smethod_3(binaryReader.BaseStream, memoryStream);
		}
		memoryStream.Position = 0L;
		return memoryStream;
	}

	public static SymmetricAlgorithm smethod_1(byte byte_0)
	{
		return smethod_2(byte_0);
	}

	private static SymmetricAlgorithm smethod_2(byte byte_0)
	{
		if (1 == 0)
		{
		}
		SymmetricAlgorithm result = byte_0 switch
		{
			1 => DES.Create(), 
			2 => Aes.Create(), 
			3 => TripleDES.Create(), 
			4 => Rijndael.Create(), 
			5 => RC2.Create(), 
			6 => new Class233(), 
			_ => null, 
		};
		if (1 == 0)
		{
		}
		return result;
	}

	public static void smethod_3(Stream stream_0, Stream stream_1)
	{
		byte[] array = new byte[4096];
		while (true)
		{
			int num = stream_0.Read(array, 0, array.Length);
			if (num > 0)
			{
				stream_1.Write(array, 0, num);
				continue;
			}
			break;
		}
	}
}
