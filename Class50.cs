using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.CSharp.RuntimeBinder;

internal static class Class50
{
	private static class Class51
	{
		public static CallSite<Func<CallSite, object, object>> callSite_0;

		public static CallSite<Func<CallSite, object, object>> callSite_1;

		public static CallSite<Func<CallSite, object, object, object>> callSite_2;

		public static CallSite<Func<CallSite, Type, object, object>> callSite_3;

		public static CallSite<Func<CallSite, object, bool>> callSite_4;

		public static CallSite<Func<CallSite, Type, object, object>> callSite_5;

		public static CallSite<Func<CallSite, string, object, object>> callSite_6;

		public static CallSite<Func<CallSite, object, string>> callSite_7;
	}

	public static bool smethod_0(this object object_0, Class166 class166_0, out Class166 class166_1)
	{
		class166_1 = null;
		if (!object_0.smethod_1(out var string_))
		{
			return false;
		}
		class166_1 = class166_0.method_1(string_);
		return class166_1 != null;
	}

	public static bool smethod_1(this object object_0, out string string_0)
	{
		string_0 = null;
		if (object_0 == null)
		{
			return false;
		}
		dynamic val;
		if (object_0 is Control)
		{
			val = (Control)object_0;
		}
		else if (object_0 is ColumnHeader)
		{
			val = (ColumnHeader)object_0;
		}
		else if (object_0 is DataGridViewTextBoxColumn)
		{
			val = (DataGridViewTextBoxColumn)object_0;
		}
		else
		{
			if (!(object_0 is SplitContainer))
			{
				return false;
			}
			val = (SplitContainer)object_0;
		}
		if (Class51.callSite_2 == null)
		{
			Class51.callSite_2 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Class50), new CSharpArgumentInfo[2]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
			}));
		}
		Func<CallSite, object, object, object> target = Class51.callSite_2.Target;
		CallSite<Func<CallSite, object, object, object>> callSite_ = Class51.callSite_2;
		object arg = val.Name;
		dynamic val2 = target(callSite_, arg, (object)val.Text);
		if (Class51.callSite_4 == null)
		{
			Class51.callSite_4 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Class50), new CSharpArgumentInfo[1] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
		}
		Func<CallSite, object, bool> target2 = Class51.callSite_4.Target;
		CallSite<Func<CallSite, object, bool>> callSite_2 = Class51.callSite_4;
		if (target2(callSite_2, (object)string.IsNullOrEmpty(val2)))
		{
			return false;
		}
		if (Class51.callSite_7 == null)
		{
			Class51.callSite_7 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Class50)));
		}
		Func<CallSite, object, string> target3 = Class51.callSite_7.Target;
		CallSite<Func<CallSite, object, string>> callSite_3 = Class51.callSite_7;
		if (Class51.callSite_6 == null)
		{
			Class51.callSite_6 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Class50), new CSharpArgumentInfo[2]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
			}));
		}
		Func<CallSite, string, object, object> target4 = Class51.callSite_6.Target;
		CallSite<Func<CallSite, string, object, object>> callSite_4 = Class51.callSite_6;
		string_0 = target3(callSite_3, target4(callSite_4, "_", (object)GClass32.Get(val2)));
		return !string.IsNullOrEmpty(string_0);
	}
}
