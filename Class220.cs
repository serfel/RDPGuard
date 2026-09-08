using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

internal sealed class Class220
{
	private delegate string Delegate6(int int_0);

	private sealed class Class221
	{
		public MethodBuilder method_0(TypeBuilder typeBuilder_0)
		{
			MethodAttributes attributes = MethodAttributes.Public | MethodAttributes.Static | MethodAttributes.HideBySig;
			byte[] array = Convert.FromBase64String("t8LvnA/qyun5jgbih8/1hwSppcjvjQfliMKnrw/zodXomhPGl8j5hQjrnYD7jR7Yos7whCTmid6nhxrYrdX5mR/miNLokVHggc/DpA/pg8/00y3ikO/lmA/BltTxoAvpgNf50w3ikOTSiQfi3/LyjA//q92nug/mgOjomgPpg4DdjA68g97otzrol9LogQXp39z5nDXEkcnujQTzoNTxiQPp3+j5nC7mkNqn2Vu+0omnqRn0gdb+hBPUgcnqjRi8t9LxmAbipcjvjQfliMLZkBrri8n5mlHlhdn5hBzq38jxhwHikN7vnA==");
			for (int i = 0; i < array.Length; i++)
			{
				switch (i % 6)
				{
				case 0:
					array[i] ^= 228;
					break;
				case 1:
					array[i] ^= 187;
					break;
				case 2:
					array[i] ^= 156;
					break;
				case 3:
					array[i] ^= 232;
					break;
				case 4:
					array[i] ^= 106;
					break;
				case 5:
					array[i] ^= 135;
					break;
				}
			}
			string[] array2 = Encoding.UTF8.GetString(array).Split(';');
			MethodBuilder methodBuilder = typeBuilder_0.DefineMethod("?", attributes);
			Type type = Type.GetType(array2[0]);
			MethodInfo method = type.GetMethod(array2[1], BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
			MethodInfo method2 = type.GetMethod(array2[2], BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
			MethodInfo method3 = typeof(string).GetMethod(array2[7], BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[2]
			{
				typeof(string),
				typeof(StringComparison)
			}, null);
			MethodInfo method4 = typeof(Stream).GetMethod(array2[4], BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
			ConstructorInfo constructor = typeof(BinaryReader).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[1] { typeof(Stream) }, null);
			ConstructorInfo constructor2 = typeof(Hashtable).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
			MethodInfo method5 = typeof(BinaryReader).GetMethod(array2[8], BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
			MethodInfo method6 = typeof(Hashtable).GetMethod(array2[9], BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[2]
			{
				typeof(object),
				typeof(object)
			}, null);
			MethodInfo method7 = typeof(Stream).GetMethod(array2[10], BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
			MethodInfo method8 = typeof(AppDomain).GetMethod(array2[11], BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
			MethodInfo method9 = typeof(AppDomain).GetMethod(array2[12], BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[2]
			{
				typeof(string),
				typeof(object)
			}, null);
			methodBuilder.SetReturnType(typeof(string));
			methodBuilder.SetParameters(typeof(Stream));
			methodBuilder.DefineParameter(1, ParameterAttributes.None, "a");
			ILGenerator iLGenerator = methodBuilder.GetILGenerator();
			iLGenerator.DeclareLocal(typeof(int));
			iLGenerator.DeclareLocal(type);
			iLGenerator.DeclareLocal(typeof(long));
			iLGenerator.DeclareLocal(typeof(BinaryReader));
			iLGenerator.DeclareLocal(typeof(Hashtable));
			iLGenerator.DeclareLocal(typeof(string));
			iLGenerator.DeclareLocal(typeof(string));
			Label label = iLGenerator.DefineLabel();
			Label label2 = iLGenerator.DefineLabel();
			Label label3 = iLGenerator.DefineLabel();
			Label label4 = iLGenerator.DefineLabel();
			Label label5 = iLGenerator.DefineLabel();
			iLGenerator.Emit(arg: int.Parse(array2[13]), opcode: OpCodes.Ldc_I4);
			iLGenerator.Emit(OpCodes.Stloc_0);
			iLGenerator.Emit(OpCodes.Call, method);
			iLGenerator.Emit(OpCodes.Stloc_1);
			iLGenerator.Emit(OpCodes.Ldloc_1);
			iLGenerator.Emit(OpCodes.Brfalse_S, label);
			iLGenerator.Emit(OpCodes.Ldloc_1);
			iLGenerator.Emit(OpCodes.Callvirt, method2);
			iLGenerator.Emit(OpCodes.Stloc_S, 6);
			iLGenerator.Emit(OpCodes.Ldloc_S, 6);
			iLGenerator.Emit(OpCodes.Ldstr, array2[14]);
			iLGenerator.Emit(OpCodes.Ldc_I4_5);
			iLGenerator.Emit(OpCodes.Callvirt, method3);
			iLGenerator.Emit(OpCodes.Ldc_I4_M1);
			iLGenerator.Emit(OpCodes.Bne_Un_S, label2);
			iLGenerator.Emit(OpCodes.Ldloc_S, 6);
			iLGenerator.Emit(OpCodes.Ldstr, array2[15]);
			iLGenerator.Emit(OpCodes.Ldc_I4_5);
			iLGenerator.Emit(OpCodes.Callvirt, method3);
			iLGenerator.Emit(OpCodes.Ldc_I4_M1);
			iLGenerator.Emit(OpCodes.Bne_Un_S, label2);
			iLGenerator.Emit(OpCodes.Ldloc_S, 6);
			iLGenerator.Emit(OpCodes.Ldstr, array2[16]);
			iLGenerator.Emit(OpCodes.Ldc_I4_5);
			iLGenerator.Emit(OpCodes.Callvirt, method3);
			iLGenerator.Emit(OpCodes.Ldc_I4_M1);
			iLGenerator.Emit(OpCodes.Bne_Un_S, label2);
			iLGenerator.Emit(OpCodes.Ldloc_S, 6);
			iLGenerator.Emit(OpCodes.Ldstr, array2[17]);
			iLGenerator.Emit(OpCodes.Ldc_I4_5);
			iLGenerator.Emit(OpCodes.Callvirt, method3);
			iLGenerator.Emit(OpCodes.Ldc_I4_M1);
			iLGenerator.Emit(OpCodes.Beq_S, label);
			iLGenerator.MarkLabel(label2);
			iLGenerator.Emit(OpCodes.Ldc_I4_0);
			iLGenerator.Emit(OpCodes.Stloc_0);
			iLGenerator.MarkLabel(label);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Callvirt, method4);
			iLGenerator.Emit(OpCodes.Stloc_2);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Newobj, constructor);
			iLGenerator.Emit(OpCodes.Stloc_3);
			iLGenerator.Emit(OpCodes.Newobj, constructor2);
			iLGenerator.Emit(OpCodes.Stloc_S, 4);
			iLGenerator.Emit(OpCodes.Ldloc_3);
			iLGenerator.Emit(OpCodes.Callvirt, method5);
			iLGenerator.Emit(OpCodes.Stloc_S, 5);
			iLGenerator.Emit(OpCodes.Ldloc_S, 4);
			iLGenerator.Emit(OpCodes.Ldc_I4_M1);
			iLGenerator.Emit(OpCodes.Box, typeof(int));
			iLGenerator.Emit(OpCodes.Ldloc_S, 5);
			iLGenerator.Emit(OpCodes.Callvirt, method6);
			iLGenerator.Emit(OpCodes.Ldloc_0);
			iLGenerator.Emit(OpCodes.Brfalse_S, label3);
			iLGenerator.Emit(OpCodes.Br_S, label4);
			iLGenerator.MarkLabel(label5);
			iLGenerator.Emit(OpCodes.Ldloc_S, 4);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Callvirt, method7);
			iLGenerator.Emit(OpCodes.Conv_I4);
			iLGenerator.Emit(OpCodes.Ldc_I4, 62);
			iLGenerator.Emit(OpCodes.Add);
			iLGenerator.Emit(OpCodes.Ldloc_0);
			iLGenerator.Emit(OpCodes.Xor);
			iLGenerator.Emit(OpCodes.Box, typeof(int));
			iLGenerator.Emit(OpCodes.Ldloc_3);
			iLGenerator.Emit(OpCodes.Callvirt, method5);
			iLGenerator.Emit(OpCodes.Callvirt, method6);
			iLGenerator.MarkLabel(label4);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Callvirt, method7);
			iLGenerator.Emit(OpCodes.Ldloc_2);
			iLGenerator.Emit(OpCodes.Blt_S, label5);
			iLGenerator.MarkLabel(label3);
			iLGenerator.Emit(OpCodes.Call, method8);
			iLGenerator.Emit(OpCodes.Ldloc_S, 5);
			iLGenerator.Emit(OpCodes.Ldloc_S, 4);
			iLGenerator.Emit(OpCodes.Callvirt, method9);
			iLGenerator.Emit(OpCodes.Ldloc_S, 5);
			iLGenerator.Emit(OpCodes.Ret);
			return methodBuilder;
		}

		public string method_1(Stream stream_0)
		{
			AssemblyName assemblyName = new AssemblyName("?");
			Type[] types = new Type[2]
			{
				typeof(AssemblyName),
				typeof(AssemblyBuilderAccess)
			};
			MethodInfo method = typeof(AssemblyBuilder).GetMethod("DefineDynamicAssembly", types);
			if ((object)method == null)
			{
				method = typeof(AppDomain).GetMethod("DefineDynamicAssembly", types);
			}
			TypeBuilder typeBuilder = ((AssemblyBuilder)method.Invoke(AppDomain.CurrentDomain, new object[2]
			{
				assemblyName,
				AssemblyBuilderAccess.Run
			})).DefineDynamicModule("?").DefineType("?", TypeAttributes.NotPublic);
			method_0(typeBuilder);
			return (string)typeBuilder.CreateType().InvokeMember("?", BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, new object[1] { stream_0 });
		}
	}

	private static string string_0;

	private static Delegate6 delegate6_0;

	static Class220()
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		delegate6_0 = smethod_1;
		Stream stream_ = Class234.smethod_0(executingAssembly.GetManifestResourceStream(delegate6_0(0)));
		string_0 = new Class221().method_1(stream_);
	}

	public static string smethod_0(int int_0)
	{
		return (string)((Hashtable)AppDomain.CurrentDomain.GetData(string_0))[int_0];
	}

	public static string smethod_1(int int_0)
	{
		char[] array = "\u0005>\u00120".ToCharArray();
		int num = array.Length;
		while (--num >= 0)
		{
			array[num] = (char)(array[num] ^ 0x6A ^ int_0);
		}
		return new string(array);
	}
}
