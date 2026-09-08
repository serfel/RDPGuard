using System;
using System.ComponentModel;
using System.Windows.Forms;

public static class GClass1
{
	private static int int_0 = -1;

	public static void smethod_0(this ListView listView_0, int int_1, SortOrder sortOrder_0)
	{
		IntPtr intptr_ = Class181.SendMessage(listView_0.Handle, 4127u, IntPtr.Zero, IntPtr.Zero);
		int num = 0;
		while (true)
		{
			if (num > listView_0.Columns.Count - 1)
			{
				return;
			}
			IntPtr intptr_2 = new IntPtr(num);
			Class181.Struct1 struct1_ = new Class181.Struct1
			{
				int_0 = 4
			};
			if (!(Class181.SendMessage_1(intptr_, 4619u, intptr_2, ref struct1_) == IntPtr.Zero))
			{
				if (sortOrder_0 != SortOrder.None && num == int_1)
				{
					switch (sortOrder_0)
					{
					case SortOrder.Descending:
						struct1_.int_3 &= -1025;
						struct1_.int_3 |= 512;
						break;
					case SortOrder.Ascending:
						struct1_.int_3 &= -513;
						struct1_.int_3 |= 1024;
						break;
					}
				}
				else
				{
					struct1_.int_3 &= -1537;
				}
				if (Class181.SendMessage_1(intptr_, 4620u, intptr_2, ref struct1_) == IntPtr.Zero)
				{
					break;
				}
				num++;
				continue;
			}
			throw new Win32Exception();
		}
		throw new Win32Exception();
	}

	public static SortOrder smethod_1(this ListView listView_0, out int int_1)
	{
		IntPtr intptr_ = Class181.SendMessage(listView_0.Handle, 4127u, IntPtr.Zero, IntPtr.Zero);
		int_1 = 0;
		while (true)
		{
			if (int_1 <= listView_0.Columns.Count - 1)
			{
				IntPtr intptr_2 = new IntPtr(int_1);
				Class181.Struct1 struct1_ = new Class181.Struct1
				{
					int_0 = 4
				};
				if (!(Class181.SendMessage_1(intptr_, 4619u, intptr_2, ref struct1_) == IntPtr.Zero))
				{
					if ((struct1_.int_3 & 0x200) == 0)
					{
						if ((struct1_.int_3 & 0x400) != 0)
						{
							break;
						}
						int_1++;
						continue;
					}
					return SortOrder.Descending;
				}
				throw new Win32Exception();
			}
			return SortOrder.None;
		}
		return SortOrder.Ascending;
	}

	public static int smethod_2(this ListView listView_0)
	{
		int result = listView_0.Font.Height + 4;
		if (int_0 > 0)
		{
			return int_0;
		}
		IntPtr intPtr = Class181.SendMessage(listView_0.Handle, 4127u, IntPtr.Zero, IntPtr.Zero);
		if (IntPtr.Zero == intPtr)
		{
			return result;
		}
		if (Class181.GetWindowRect(intPtr, out var struct2_))
		{
			int_0 = struct2_.int_3 - struct2_.int_1;
			return int_0;
		}
		return result;
	}
}
