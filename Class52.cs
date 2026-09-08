using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

internal static class Class52
{
	public static string smethod_0(Bitmap bitmap_0)
	{
		using MemoryStream memoryStream = new MemoryStream();
		bitmap_0.Save(memoryStream, ImageFormat.Png);
		return Convert.ToBase64String(memoryStream.ToArray());
	}
}
