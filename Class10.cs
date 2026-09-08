using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Properties;
using rdpguard.lib;

internal static class Class10
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Action<Class90> _003C_003E9__27_0;

		public static Action<Class90> _003C_003E9__28_0;

		public static Action<Class90> _003C_003E9__28_1;

		public static Func<Class90, bool> _003C_003E9__37_0;

		internal void method_0(Class90 class90_0)
		{
			smethod_0(class90_0.gclass11_0.genum16_0).Add(class90_0);
		}

		internal void method_1(Class90 class90_0)
		{
			smethod_0(class90_0.gclass11_0.genum16_0).Remove(class90_0);
		}

		internal void method_2(Class90 class90_0)
		{
			list_4.Remove(class90_0);
		}

		internal bool method_3(Class90 class90_0)
		{
			if (!Form23_0.Class135_0.vmethod_0(class90_0.gclass11_0.gclass24_0))
			{
				return class90_0.gclass11_0.gclass24_0.method_1(Form23_0.Class135_0.gclass24_0);
			}
			return true;
		}

		internal string method_4()
		{
			return Class52.smethod_0(Resources.up_10);
		}

		internal string method_5()
		{
			return Class52.smethod_0(Resources.down_10);
		}
	}

	private static readonly Lazy<string> lazy_0 = new Lazy<string>(_003C_003Ec._003C_003E9.method_4);

	private static readonly Lazy<string> lazy_1 = new Lazy<string>(_003C_003Ec._003C_003E9.method_5);

	private static Class79 class79_0 = null;

	private static readonly Lazy<Form23> lazy_2 = new Lazy<Form23>();

	private static be<Class90> be_0 = null;

	private static GEnum16 genum16_0 = GEnum16.const_0;

	private static readonly List<Class90> list_0 = new List<Class90>();

	private static readonly List<Class90> list_1 = new List<Class90>();

	private static readonly List<Class90> list_2 = new List<Class90>();

	private static readonly List<Class90> list_3 = new List<Class90>();

	private static readonly List<Class90> list_4 = new List<Class90>();

	public static Class164 class164_0 = null;

	private static Dictionary<GEnum16, List<Class90>> dictionary_0 = new Dictionary<GEnum16, List<Class90>>
	{
		{
			GEnum16.const_0,
			list_0
		},
		{
			GEnum16.const_1,
			list_1
		},
		{
			GEnum16.const_2,
			list_2
		},
		{
			GEnum16.const_3,
			list_4
		},
		{
			GEnum16.const_4,
			list_3
		}
	};

	private static string String_0 => lazy_0.Value;

	private static string String_1 => lazy_1.Value;

	private static Form23 Form23_0 => lazy_2.Value;

	public static GEnum16 GEnum16_0
	{
		get
		{
			return genum16_0;
		}
		private set
		{
			genum16_0 = value;
		}
	}

	private static List<Class90> List_0 => smethod_0(GEnum16_0);

	private static List<Class90> smethod_0(GEnum16 genum16_1)
	{
		return dictionary_0[genum16_1];
	}

	public static void smethod_1(Class79 class79_1)
	{
		class79_0 = class79_1;
		be_0 = new be<Class90>(class79_1);
	}

	public static void smethod_2(Class90[] class90_0)
	{
		list_0.Clear();
		list_1.Clear();
		list_2.Clear();
		list_3.Clear();
		list_4.Clear();
		smethod_3(class90_0);
	}

	public static void smethod_3(Class90[] class90_0)
	{
		Action<Class90> action_ = _003C_003Ec._003C_003E9.method_0;
		class90_0.smethod_0(action_);
		list_4.AddRange(class90_0);
		smethod_12();
	}

	public static void smethod_4(Class90[] class90_0)
	{
		Action<Class90> action_ = _003C_003Ec._003C_003E9.method_1;
		class90_0.smethod_0(action_);
		Action<Class90> action_2 = _003C_003Ec._003C_003E9.method_2;
		class90_0.smethod_0(action_2);
		smethod_12();
	}

	public static void smethod_5()
	{
		smethod_12();
		smethod_16();
	}

	public static void smethod_6(GEnum16 genum16_1)
	{
		GEnum16_0 = genum16_1;
		smethod_12();
	}

	public static void smethod_7()
	{
		if (DialogResult.OK == Form23_0.ShowDialog())
		{
			if (!Form23_0.Boolean_0)
			{
				smethod_8();
			}
			else
			{
				smethod_12();
			}
		}
	}

	public static void smethod_8()
	{
		Form23_0.method_11();
		smethod_12();
	}

	public static void smethod_9()
	{
		be_0.method_0();
	}

	public static void smethod_10()
	{
		be_0.method_1();
	}

	public static void smethod_11(int int_0)
	{
		be_0.Int32_2 = int_0;
		smethod_14();
	}

	private static void smethod_12()
	{
		Class90[] array = smethod_13(List_0.ToArray());
		Array.Sort(array, new Class93(Class163.Class163_0.GEnum14_0));
		be_0.Prop_0 = array;
		smethod_14();
		class79_0.method_0("filter_lbl", Form23_0?.Class135_0?.String_0);
		class79_0.method_2("filtered_results", Form23_0.Boolean_0);
		class79_0.method_0("local_ips_switcher", (Form23_0.Boolean_0 && GEnum16_0 == GEnum16.const_0) ? $"Local ({array.Length}/{list_0.Count})" : ((list_0.Count > 0) ? $"Local ({list_0.Count})" : "Local"));
		class79_0.method_0("cloud_ips_switcher", (Form23_0.Boolean_0 && GEnum16.const_1 == GEnum16_0) ? $"Cloud ({array.Length}/{list_1.Count})" : ((list_1.Count > 0) ? $"Cloud ({list_1.Count})" : "Cloud"));
		class79_0.method_0("geoip_ips_switcher", (Form23_0.Boolean_0 && GEnum16.const_2 == GEnum16_0) ? $"GeoIP ({array.Length}/{list_2.Count})" : ((list_2.Count > 0) ? $"GeoIP ({list_2.Count})" : "GeoIP"));
		class79_0.method_0("all_ips_switcher", (Form23_0.Boolean_0 && GEnum16.const_3 == GEnum16_0) ? $"All ({array.Length}/{list_4.Count})" : ((list_4.Count > 0) ? $"All ({list_4.Count})" : "All"));
	}

	private static Class90[] smethod_13(Class90[] class90_0)
	{
		if (!Form23_0.Boolean_0)
		{
			return class90_0;
		}
		Func<Class90, bool> predicate = _003C_003Ec._003C_003E9.method_3;
		return class90_0.Where(predicate).ToArray();
	}

	public static void smethod_14()
	{
		class79_0.method_1("blocked_ips", smethod_15(be_0.IEnumerable_0.ToArray()));
		smethod_16();
		be_0.method_2();
	}

	private static string smethod_15(Class90[] class90_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("<table id=\"blocked_ips_table\" cellpadding=\"0\" cellspacing=\"0\">");
		stringBuilder.Append(Resources.DashboardDialog_IPTableHeader);
		foreach (Class90 @class in class90_0)
		{
			bool flag = class164_0 != null && GeoIPMode.Allow == class164_0.Class132_0.geoIPMode_0 && GEnum16.const_2 == @class.gclass11_0.genum16_0;
			stringBuilder.Append("<tr>");
			string text = @class.gclass11_0.gclass24_0.method_6();
			stringBuilder.Append("<td><a href=# id=ip_" + text.Replace('.', '_') + ((Class80.smethod_0(@class.gclass11_0.gclass24_0) ? true : false) ? " class=\"ip_lnk_visited\"" : string.Empty) + " title=\"Get details for " + text + "\" name=\"" + @class.method_1() + "\">" + text + "</a></td>");
			stringBuilder.Append("<td>" + ((flag ? true : false) ? "N/A" : @class.dateTime_0.ToString()) + "</td>");
			stringBuilder.Append("<td>" + ((@class.Boolean_0 ? true : false) ? @class.DateTime_0.ToString() : "N/A") + "</td>");
			stringBuilder.Append("<td style=\"" + ((flag ? true : false) ? "color:#009500;" : null) + "\">" + @class.gclass11_0.String_0 + "</td>");
			stringBuilder.Append("</tr>");
		}
		if (!class90_0.Any())
		{
			stringBuilder.Append("<tr><td>-</td><td>-</td><td>-</td><td>-</td></tr>");
		}
		stringBuilder.Append("</table>");
		return stringBuilder.ToString();
	}

	private static void smethod_16()
	{
		string string_ = "text-decoration:underline;";
		class79_0.method_2("ip_sorting_by_ip", bool_0: false);
		class79_0.method_3("lnk_ip_sorting_by_ip", null);
		class79_0.method_2("ip_sorting_by_block_date", bool_0: false);
		class79_0.method_3("lnk_ip_sorting_by_block_date", null);
		class79_0.method_2("ip_sorting_by_unblock_date", bool_0: false);
		class79_0.method_3("lnk_ip_sorting_by_unblock_date", null);
		class79_0.method_2("ip_sorting_by_protocol", bool_0: false);
		class79_0.method_3("lnk_ip_sorting_by_protocol", null);
		switch (Class163.Class163_0.GEnum14_0)
		{
		default:
			Class208.smethod_0("UpdateSortingImages::unknown_sorting_settings");
			break;
		case GEnum14.const_0:
			class79_0.method_5("ip_sorting_by_ip", String_0);
			class79_0.method_3("lnk_ip_sorting_by_ip", string_);
			break;
		case GEnum14.const_1:
			class79_0.method_5("ip_sorting_by_ip", String_1);
			class79_0.method_3("lnk_ip_sorting_by_ip", string_);
			break;
		case GEnum14.const_2:
			class79_0.method_5("ip_sorting_by_block_date", String_0);
			class79_0.method_3("lnk_ip_sorting_by_block_date", string_);
			break;
		case GEnum14.const_3:
			class79_0.method_5("ip_sorting_by_block_date", String_1);
			class79_0.method_3("lnk_ip_sorting_by_block_date", string_);
			break;
		case GEnum14.const_4:
			class79_0.method_5("ip_sorting_by_unblock_date", String_0);
			class79_0.method_3("lnk_ip_sorting_by_unblock_date", string_);
			break;
		case GEnum14.const_5:
			class79_0.method_5("ip_sorting_by_unblock_date", String_1);
			class79_0.method_3("lnk_ip_sorting_by_unblock_date", string_);
			break;
		case GEnum14.const_6:
			class79_0.method_5("ip_sorting_by_protocol", String_0);
			class79_0.method_3("lnk_ip_sorting_by_protocol", string_);
			break;
		case GEnum14.const_7:
			class79_0.method_5("ip_sorting_by_protocol", String_1);
			class79_0.method_3("lnk_ip_sorting_by_protocol", string_);
			break;
		}
	}
}
