//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System {
    
    
    #region Component Designer generated code 
    public partial class IConvertible_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.@__IConvertible.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.IConvertible))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.IConvertible))]
    internal sealed partial class @__IConvertible : global::java.lang.Object, global::System.IConvertible {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _GetTypeCode0;
        
        internal static global::net.sf.jni4net.jni.MethodId _ToBoolean1;
        
        internal static global::net.sf.jni4net.jni.MethodId _ToChar2;
        
        internal static global::net.sf.jni4net.jni.MethodId _ToSByte3;
        
        internal static global::net.sf.jni4net.jni.MethodId _ToByte4;
        
        internal static global::net.sf.jni4net.jni.MethodId _ToInt165;
        
        internal static global::net.sf.jni4net.jni.MethodId _ToUInt166;
        
        internal static global::net.sf.jni4net.jni.MethodId _ToInt327;
        
        internal static global::net.sf.jni4net.jni.MethodId _ToUInt328;
        
        internal static global::net.sf.jni4net.jni.MethodId _ToInt649;
        
        internal static global::net.sf.jni4net.jni.MethodId _ToUInt6410;
        
        internal static global::net.sf.jni4net.jni.MethodId _ToSingle11;
        
        internal static global::net.sf.jni4net.jni.MethodId _ToDouble12;
        
        internal static global::net.sf.jni4net.jni.MethodId _ToDecimal13;
        
        internal static global::net.sf.jni4net.jni.MethodId _ToDateTime14;
        
        internal static global::net.sf.jni4net.jni.MethodId _ToString15;
        
        internal static global::net.sf.jni4net.jni.MethodId _ToType16;
        
        protected @__IConvertible(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::System.@__IConvertible.staticClass = @__class;
            global::System.@__IConvertible._GetTypeCode0 = @__env.GetMethodID(global::System.@__IConvertible.staticClass, "GetTypeCode", "()Lsystem/Enum;");
            global::System.@__IConvertible._ToBoolean1 = @__env.GetMethodID(global::System.@__IConvertible.staticClass, "ToBoolean", "(Lsystem/IFormatProvider;)Z");
            global::System.@__IConvertible._ToChar2 = @__env.GetMethodID(global::System.@__IConvertible.staticClass, "ToChar", "(Lsystem/IFormatProvider;)C");
            global::System.@__IConvertible._ToSByte3 = @__env.GetMethodID(global::System.@__IConvertible.staticClass, "ToSByte", "(Lsystem/IFormatProvider;)B");
            global::System.@__IConvertible._ToByte4 = @__env.GetMethodID(global::System.@__IConvertible.staticClass, "ToByte", "(Lsystem/IFormatProvider;)B");
            global::System.@__IConvertible._ToInt165 = @__env.GetMethodID(global::System.@__IConvertible.staticClass, "ToInt16", "(Lsystem/IFormatProvider;)S");
            global::System.@__IConvertible._ToUInt166 = @__env.GetMethodID(global::System.@__IConvertible.staticClass, "ToUInt16", "(Lsystem/IFormatProvider;)S");
            global::System.@__IConvertible._ToInt327 = @__env.GetMethodID(global::System.@__IConvertible.staticClass, "ToInt32", "(Lsystem/IFormatProvider;)I");
            global::System.@__IConvertible._ToUInt328 = @__env.GetMethodID(global::System.@__IConvertible.staticClass, "ToUInt32", "(Lsystem/IFormatProvider;)I");
            global::System.@__IConvertible._ToInt649 = @__env.GetMethodID(global::System.@__IConvertible.staticClass, "ToInt64", "(Lsystem/IFormatProvider;)J");
            global::System.@__IConvertible._ToUInt6410 = @__env.GetMethodID(global::System.@__IConvertible.staticClass, "ToUInt64", "(Lsystem/IFormatProvider;)J");
            global::System.@__IConvertible._ToSingle11 = @__env.GetMethodID(global::System.@__IConvertible.staticClass, "ToSingle", "(Lsystem/IFormatProvider;)F");
            global::System.@__IConvertible._ToDouble12 = @__env.GetMethodID(global::System.@__IConvertible.staticClass, "ToDouble", "(Lsystem/IFormatProvider;)D");
            global::System.@__IConvertible._ToDecimal13 = @__env.GetMethodID(global::System.@__IConvertible.staticClass, "ToDecimal", "(Lsystem/IFormatProvider;)Lsystem/Decimal;");
            global::System.@__IConvertible._ToDateTime14 = @__env.GetMethodID(global::System.@__IConvertible.staticClass, "ToDateTime", "(Lsystem/IFormatProvider;)Lsystem/DateTime;");
            global::System.@__IConvertible._ToString15 = @__env.GetMethodID(global::System.@__IConvertible.staticClass, "ToString", "(Lsystem/IFormatProvider;)Ljava/lang/String;");
            global::System.@__IConvertible._ToType16 = @__env.GetMethodID(global::System.@__IConvertible.staticClass, "ToType", "(Lsystem/Type;Lsystem/IFormatProvider;)Lsystem/Object;");
        }
        
        public global::System.TypeCode GetTypeCode() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<global::System.Enum, global::System.TypeCode>(@__env, @__env.CallObjectMethodPtr(this, global::System.@__IConvertible._GetTypeCode0));
        }
        
        public bool ToBoolean(global::System.IFormatProvider provider) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::System.@__IConvertible._ToBoolean1, global::net.sf.jni4net.utils.Convertor.ParamC2J<global::System.IFormatProvider>(@__env, provider))));
        }
        
        public char ToChar(global::System.IFormatProvider provider) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((char)(@__env.CallCharMethod(this, global::System.@__IConvertible._ToChar2, global::net.sf.jni4net.utils.Convertor.ParamC2J<global::System.IFormatProvider>(@__env, provider))));
        }
        
        public sbyte ToSByte(global::System.IFormatProvider provider) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((sbyte)(@__env.CallByteMethod(this, global::System.@__IConvertible._ToSByte3, global::net.sf.jni4net.utils.Convertor.ParamC2J<global::System.IFormatProvider>(@__env, provider))));
        }
        
        public byte ToByte(global::System.IFormatProvider provider) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((byte)(@__env.CallByteMethod(this, global::System.@__IConvertible._ToByte4, global::net.sf.jni4net.utils.Convertor.ParamC2J<global::System.IFormatProvider>(@__env, provider))));
        }
        
        public short ToInt16(global::System.IFormatProvider provider) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((short)(@__env.CallShortMethod(this, global::System.@__IConvertible._ToInt165, global::net.sf.jni4net.utils.Convertor.ParamC2J<global::System.IFormatProvider>(@__env, provider))));
        }
        
        public ushort ToUInt16(global::System.IFormatProvider provider) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((ushort)(@__env.CallShortMethod(this, global::System.@__IConvertible._ToUInt166, global::net.sf.jni4net.utils.Convertor.ParamC2J<global::System.IFormatProvider>(@__env, provider))));
        }
        
        public int ToInt32(global::System.IFormatProvider provider) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::System.@__IConvertible._ToInt327, global::net.sf.jni4net.utils.Convertor.ParamC2J<global::System.IFormatProvider>(@__env, provider))));
        }
        
        public uint ToUInt32(global::System.IFormatProvider provider) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((uint)(@__env.CallIntMethod(this, global::System.@__IConvertible._ToUInt328, global::net.sf.jni4net.utils.Convertor.ParamC2J<global::System.IFormatProvider>(@__env, provider))));
        }
        
        public long ToInt64(global::System.IFormatProvider provider) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((long)(@__env.CallLongMethod(this, global::System.@__IConvertible._ToInt649, global::net.sf.jni4net.utils.Convertor.ParamC2J<global::System.IFormatProvider>(@__env, provider))));
        }
        
        public ulong ToUInt64(global::System.IFormatProvider provider) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((ulong)(@__env.CallLongMethod(this, global::System.@__IConvertible._ToUInt6410, global::net.sf.jni4net.utils.Convertor.ParamC2J<global::System.IFormatProvider>(@__env, provider))));
        }
        
        public float ToSingle(global::System.IFormatProvider provider) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((float)(@__env.CallFloatMethod(this, global::System.@__IConvertible._ToSingle11, global::net.sf.jni4net.utils.Convertor.ParamC2J<global::System.IFormatProvider>(@__env, provider))));
        }
        
        public double ToDouble(global::System.IFormatProvider provider) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((double)(@__env.CallDoubleMethod(this, global::System.@__IConvertible._ToDouble12, global::net.sf.jni4net.utils.Convertor.ParamC2J<global::System.IFormatProvider>(@__env, provider))));
        }
        
        public decimal ToDecimal(global::System.IFormatProvider provider) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<decimal>(@__env, @__env.CallObjectMethodPtr(this, global::System.@__IConvertible._ToDecimal13, global::net.sf.jni4net.utils.Convertor.ParamC2J<global::System.IFormatProvider>(@__env, provider)));
        }
        
        public global::System.DateTime ToDateTime(global::System.IFormatProvider provider) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<global::System.DateTime>(@__env, @__env.CallObjectMethodPtr(this, global::System.@__IConvertible._ToDateTime14, global::net.sf.jni4net.utils.Convertor.ParamC2J<global::System.IFormatProvider>(@__env, provider)));
        }
        
        public string ToString(global::System.IFormatProvider provider) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2CString(@__env, @__env.CallObjectMethodPtr(this, global::System.@__IConvertible._ToString15, global::net.sf.jni4net.utils.Convertor.ParamC2J<global::System.IFormatProvider>(@__env, provider)));
        }
        
        public object ToType(global::System.Type conversionType, global::System.IFormatProvider provider) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<object>(@__env, @__env.CallObjectMethodPtr(this, global::System.@__IConvertible._ToType16, global::net.sf.jni4net.utils.Convertor.ParamC2J<global::System.Type>(@__env, conversionType), global::net.sf.jni4net.utils.Convertor.ParamC2J<global::System.IFormatProvider>(@__env, provider)));
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__IConvertible);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetTypeCode", "GetTypeCode0", "()Lsystem/Enum;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToBoolean", "ToBoolean1", "(Lsystem/IFormatProvider;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToChar", "ToChar2", "(Lsystem/IFormatProvider;)C"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToSByte", "ToSByte3", "(Lsystem/IFormatProvider;)B"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToByte", "ToByte4", "(Lsystem/IFormatProvider;)B"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToInt16", "ToInt165", "(Lsystem/IFormatProvider;)S"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToUInt16", "ToUInt166", "(Lsystem/IFormatProvider;)S"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToInt32", "ToInt327", "(Lsystem/IFormatProvider;)I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToUInt32", "ToUInt328", "(Lsystem/IFormatProvider;)I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToInt64", "ToInt649", "(Lsystem/IFormatProvider;)J"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToUInt64", "ToUInt6410", "(Lsystem/IFormatProvider;)J"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToSingle", "ToSingle11", "(Lsystem/IFormatProvider;)F"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToDouble", "ToDouble12", "(Lsystem/IFormatProvider;)D"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToDecimal", "ToDecimal13", "(Lsystem/IFormatProvider;)Lsystem/Decimal;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToDateTime", "ToDateTime14", "(Lsystem/IFormatProvider;)Lsystem/DateTime;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToString", "ToString15", "(Lsystem/IFormatProvider;)Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToType", "ToType16", "(Lsystem/Type;Lsystem/IFormatProvider;)Lsystem/Object;"));
            return methods;
        }
        
        private static global::System.IntPtr GetTypeCode0(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Lsystem/Enum;
            // ()LSystem/TypeCode;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IConvertible @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.IConvertible>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J<global::System.Enum, global::System.TypeCode>(@__env, @__real.GetTypeCode());
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static bool ToBoolean1(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr provider) {
            // (Lsystem/IFormatProvider;)Z
            // (LSystem/IFormatProvider;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IConvertible @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.IConvertible>(@__env, @__obj);
            return ((bool)(@__real.ToBoolean(global::net.sf.jni4net.utils.Convertor.J2C<global::System.IFormatProvider>(@__env, provider))));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static char ToChar2(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr provider) {
            // (Lsystem/IFormatProvider;)C
            // (LSystem/IFormatProvider;)C
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IConvertible @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.IConvertible>(@__env, @__obj);
            return ((char)(@__real.ToChar(global::net.sf.jni4net.utils.Convertor.J2C<global::System.IFormatProvider>(@__env, provider))));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(char);
        }
        
        private static sbyte ToSByte3(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr provider) {
            // (Lsystem/IFormatProvider;)B
            // (LSystem/IFormatProvider;)LSystem/SByte;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IConvertible @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.IConvertible>(@__env, @__obj);
            return ((sbyte)(@__real.ToSByte(global::net.sf.jni4net.utils.Convertor.J2C<global::System.IFormatProvider>(@__env, provider))));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(sbyte);
        }
        
        private static byte ToByte4(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr provider) {
            // (Lsystem/IFormatProvider;)B
            // (LSystem/IFormatProvider;)B
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IConvertible @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.IConvertible>(@__env, @__obj);
            return ((byte)(@__real.ToByte(global::net.sf.jni4net.utils.Convertor.J2C<global::System.IFormatProvider>(@__env, provider))));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(byte);
        }
        
        private static short ToInt165(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr provider) {
            // (Lsystem/IFormatProvider;)S
            // (LSystem/IFormatProvider;)S
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IConvertible @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.IConvertible>(@__env, @__obj);
            return ((short)(@__real.ToInt16(global::net.sf.jni4net.utils.Convertor.J2C<global::System.IFormatProvider>(@__env, provider))));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(short);
        }
        
        private static ushort ToUInt166(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr provider) {
            // (Lsystem/IFormatProvider;)S
            // (LSystem/IFormatProvider;)LSystem/UInt16;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IConvertible @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.IConvertible>(@__env, @__obj);
            return ((ushort)(@__real.ToUInt16(global::net.sf.jni4net.utils.Convertor.J2C<global::System.IFormatProvider>(@__env, provider))));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(ushort);
        }
        
        private static int ToInt327(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr provider) {
            // (Lsystem/IFormatProvider;)I
            // (LSystem/IFormatProvider;)I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IConvertible @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.IConvertible>(@__env, @__obj);
            return ((int)(@__real.ToInt32(global::net.sf.jni4net.utils.Convertor.J2C<global::System.IFormatProvider>(@__env, provider))));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static uint ToUInt328(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr provider) {
            // (Lsystem/IFormatProvider;)I
            // (LSystem/IFormatProvider;)LSystem/UInt32;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IConvertible @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.IConvertible>(@__env, @__obj);
            return ((uint)(@__real.ToUInt32(global::net.sf.jni4net.utils.Convertor.J2C<global::System.IFormatProvider>(@__env, provider))));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(uint);
        }
        
        private static long ToInt649(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr provider) {
            // (Lsystem/IFormatProvider;)J
            // (LSystem/IFormatProvider;)J
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IConvertible @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.IConvertible>(@__env, @__obj);
            return ((long)(@__real.ToInt64(global::net.sf.jni4net.utils.Convertor.J2C<global::System.IFormatProvider>(@__env, provider))));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(long);
        }
        
        private static ulong ToUInt6410(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr provider) {
            // (Lsystem/IFormatProvider;)J
            // (LSystem/IFormatProvider;)LSystem/UInt64;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IConvertible @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.IConvertible>(@__env, @__obj);
            return ((ulong)(@__real.ToUInt64(global::net.sf.jni4net.utils.Convertor.J2C<global::System.IFormatProvider>(@__env, provider))));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(ulong);
        }
        
        private static float ToSingle11(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr provider) {
            // (Lsystem/IFormatProvider;)F
            // (LSystem/IFormatProvider;)F
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IConvertible @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.IConvertible>(@__env, @__obj);
            return ((float)(@__real.ToSingle(global::net.sf.jni4net.utils.Convertor.J2C<global::System.IFormatProvider>(@__env, provider))));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(float);
        }
        
        private static double ToDouble12(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr provider) {
            // (Lsystem/IFormatProvider;)D
            // (LSystem/IFormatProvider;)D
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IConvertible @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.IConvertible>(@__env, @__obj);
            return ((double)(@__real.ToDouble(global::net.sf.jni4net.utils.Convertor.J2C<global::System.IFormatProvider>(@__env, provider))));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(double);
        }
        
        private static global::System.IntPtr ToDecimal13(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr provider) {
            // (Lsystem/IFormatProvider;)Lsystem/Decimal;
            // (LSystem/IFormatProvider;)LSystem/Decimal;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IConvertible @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.IConvertible>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J<decimal>(@__env, @__real.ToDecimal(global::net.sf.jni4net.utils.Convertor.J2C<global::System.IFormatProvider>(@__env, provider)));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr ToDateTime14(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr provider) {
            // (Lsystem/IFormatProvider;)Lsystem/DateTime;
            // (LSystem/IFormatProvider;)LSystem/DateTime;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IConvertible @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.IConvertible>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J<global::System.DateTime>(@__env, @__real.ToDateTime(global::net.sf.jni4net.utils.Convertor.J2C<global::System.IFormatProvider>(@__env, provider)));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr ToString15(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr provider) {
            // (Lsystem/IFormatProvider;)Ljava/lang/String;
            // (LSystem/IFormatProvider;)LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IConvertible @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.IConvertible>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2JString(@__env, @__real.ToString(global::net.sf.jni4net.utils.Convertor.J2C<global::System.IFormatProvider>(@__env, provider)));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr ToType16(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr conversionType, global::System.IntPtr provider) {
            // (Lsystem/Type;Lsystem/IFormatProvider;)Lsystem/Object;
            // (LSystem/Type;LSystem/IFormatProvider;)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IConvertible @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.IConvertible>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J<object>(@__env, @__real.ToType(global::net.sf.jni4net.utils.Convertor.J2C<global::System.Type>(@__env, conversionType), global::net.sf.jni4net.utils.Convertor.J2C<global::System.IFormatProvider>(@__env, provider)));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::System.@__IConvertible(@__env);
            }
        }
    }
    #endregion
}
