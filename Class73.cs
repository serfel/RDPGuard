using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

internal sealed class Class73
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<AssemblyName, Assembly> _003C_003E9__4_1;

		public static Func<object, bool> _003C_003E9__6_2;

		internal Assembly method_0(AssemblyName assemblyName_0)
		{
			return Assembly.Load(assemblyName_0);
		}

		internal bool method_1(object object_0)
		{
			return object_0 != null;
		}
	}

	private sealed class Class74
	{
		public string string_0;

		internal bool method_0(AssemblyName assemblyName_0)
		{
			return assemblyName_0.FullName.StartsWith(string_0);
		}
	}

	private sealed class Class75
	{
		public object[] object_0;

		public Class73 class73_0;

		internal bool method_0(ConstructorInfo constructorInfo_0)
		{
			return constructorInfo_0.GetParameters().Length == object_0.Length;
		}

		internal object method_1(ConstructorInfo constructorInfo_0)
		{
			return class73_0.method_2(constructorInfo_0, object_0);
		}
	}

	private readonly string string_0;

	private readonly Assembly assembly_0;

	private static readonly BindingFlags bindingFlags_0 = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

	public Class73(string string_1)
		: this(string_1, string_1)
	{
	}

	public Class73(string string_1, string string_2)
	{
		Class74 @class = new Class74
		{
			string_0 = string_1
		};
		string_0 = string_2;
		IEnumerable<AssemblyName> source = Assembly.GetExecutingAssembly().GetReferencedAssemblies().Where(@class.method_0);
		Func<AssemblyName, Assembly> selector = _003C_003Ec._003C_003E9.method_0;
		assembly_0 = source.Select(selector).First();
	}

	public Type method_0(string string_1)
	{
		Type type = null;
		string[] array = string_1.smethod_11();
		if (array.Length != 0)
		{
			type = assembly_0.GetType(string_0 + "." + array.First());
		}
		for (int i = 1; i < array.Length; i++)
		{
			type = type.GetNestedType(array[i], BindingFlags.NonPublic);
		}
		return type;
	}

	public object method_1(string string_1, params object[] object_0)
	{
		Class75 @class = new Class75();
		@class.object_0 = object_0;
		@class.class73_0 = this;
		IEnumerable<object> source = method_0(string_1).GetConstructors().Where(@class.method_0).Select(@class.method_1);
		Func<object, bool> predicate = _003C_003Ec._003C_003E9.method_1;
		return source.First(predicate);
	}

	private object method_2(ConstructorInfo constructorInfo_0, params object[] object_0)
	{
		try
		{
			return constructorInfo_0.Invoke(object_0);
		}
		catch
		{
		}
		return null;
	}

	public object method_3(object object_0, string string_1, params object[] object_1)
	{
		return method_4(object_0, object_0.GetType(), string_1, object_1);
	}

	public object method_4(object object_0, Type type_0, string string_1, params object[] object_1)
	{
		return type_0.GetMethod(string_1, bindingFlags_0).Invoke(object_0, object_1);
	}

	public object method_5(string string_1, string string_2)
	{
		return method_0(string_1).GetField(string_2).GetValue(null);
	}
}
