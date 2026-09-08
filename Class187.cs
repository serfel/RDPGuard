using System;
using System.Collections.Generic;

internal sealed class Class187 : id<GEnum3>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		internal Class187 method_0()
		{
			return new Class187();
		}
	}

	private static readonly Lazy<Class187> lazy_0 = new Lazy<Class187>(_003C_003Ec._003C_003E9.method_0);

	internal static Class187 Class187_0 => lazy_0.Value;

	private Class187()
		: base(new Dictionary<GEnum3, string>
		{
			{
				GEnum3.const_0,
				"SendMailTask"
			},
			{
				GEnum3.const_1,
				"HttpPostTask"
			},
			{
				GEnum3.const_2,
				"ProgramExecuteTask"
			},
			{
				GEnum3.const_3,
				"AbuseIPDBReportTask"
			},
			{
				GEnum3.const_4,
				"SendTelegramTask"
			}
		}, GEnum3.const_5, (string)null)
	{
	}
}
