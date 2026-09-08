using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

internal static class Class80
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<Class82, bool> _003C_003E9__8_0;

		internal bool method_0(Class82 class82_0)
		{
			return (DateTime.Now - class82_0.dateTime_0).TotalDays < 31.0;
		}
	}

	private sealed class Class81
	{
		public GClass24 gclass24_0;

		internal bool method_0(Class82 class82_0)
		{
			return class82_0.gclass24_0 == gclass24_0;
		}
	}

	private static List<Class82> list_0;

	private static string String_0 => Path.Combine(Class163.Class163_0.String_0, "b9c7bc0d79c5");

	private static string String_1 => Path.Combine(Class163.Class163_0.String_0, "a320e6d23df0");

	private static List<Class82> List_0
	{
		get
		{
			lock (String_0)
			{
				object obj;
				if (list_0 == null)
				{
					if (!File.Exists(String_0))
					{
						obj = new List<Class82>();
					}
					else
					{
						Class82[] array = JsonConvert.DeserializeObject<Class82[]>(File.ReadAllText(String_0));
						if (array == null)
						{
							obj = null;
						}
						else
						{
							obj = array.ToList();
							if (obj != null)
							{
								goto IL_0087;
							}
						}
						bool flag = true;
						obj = new List<Class82>();
					}
					goto IL_0087;
				}
				goto end_IL_0009;
				IL_0087:
				list_0 = (List<Class82>)obj;
				end_IL_0009:;
			}
			return list_0;
		}
	}

	public static bool smethod_0(GClass24 gclass24_0)
	{
		Class81 @class = new Class81();
		@class.gclass24_0 = gclass24_0;
		lock (List_0)
		{
			return List_0.Any(@class.method_0);
		}
	}

	public static void smethod_1(GClass24 gclass24_0)
	{
		lock (List_0)
		{
			List_0.Add(new Class82
			{
				gclass24_0 = gclass24_0
			});
		}
		lock (String_0)
		{
			List<Class82> source = list_0;
			Func<Class82, bool> predicate = _003C_003Ec._003C_003E9.method_0;
			Class82[] array = source.Where(predicate).ToArray();
			File.WriteAllText(String_1, JsonConvert.SerializeObject((object)array));
			File.Copy(String_1, String_0, overwrite: true);
			File.Delete(String_1);
		}
	}
}
