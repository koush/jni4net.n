//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Reflection {
    
    
    #region Component Designer generated code 
    public partial class ConstructorInfo_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.Reflection.@__ConstructorInfo.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.Reflection.ConstructorInfo))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.Reflection.ConstructorInfo))]
    internal sealed partial class @__ConstructorInfo : global::java.lang.Object {
        
        internal static global::java.lang.Class staticClass;
        
        protected @__ConstructorInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::System.Reflection.@__ConstructorInfo.staticClass = @__class;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__ConstructorInfo);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Invoke", "Invoke0", "(Lsystem/reflection/BindingFlags;Ljava/lang/Object;[Lsystem/Object;Lsystem/IClone" +
                        "able;)Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Invoke", "Invoke1", "([Lsystem/Object;)Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Invoke_2", "Invoke_22", "(Lsystem/Object;Lsystem/reflection/BindingFlags;Ljava/lang/Object;[Lsystem/Object" +
                        ";Lsystem/ICloneable;)Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Invoke_3", "Invoke_33", "(Lsystem/Object;[Lsystem/Object;)Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Invoke_4", "Invoke_44", "(Lsystem/reflection/BindingFlags;Ljava/lang/Object;[Lsystem/Object;Lsystem/IClone" +
                        "able;)Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Invoke_5", "Invoke_55", "([Lsystem/Object;)Lsystem/Object;"));
            return methods;
        }
        
        private static global::System.IntPtr Invoke0(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr invokeAttr, global::System.IntPtr binder, global::System.IntPtr parameters, global::System.IntPtr culture) {
            // (Lsystem/reflection/BindingFlags;Ljava/lang/Object;[Lsystem/Object;Lsystem/ICloneable;)Lsystem/Object;
            // (LSystem/Reflection/BindingFlags;LSystem/Reflection/Binder;[LSystem/Object;LSystem/Globalization/CultureInfo;)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ConstructorInfo @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Reflection.ConstructorInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J<object>(@__env, @__real.Invoke(global::net.sf.jni4net.utils.Convertor.J2C<global::System.Reflection.BindingFlags>(@__env, invokeAttr), global::net.sf.jni4net.utils.Convertor.J2C<global::System.Reflection.Binder>(@__env, binder), global::net.sf.jni4net.utils.Convertor.J2C<object[]>(@__env, parameters), global::net.sf.jni4net.utils.Convertor.J2C<global::System.Globalization.CultureInfo>(@__env, culture)));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr Invoke1(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr parameters) {
            // ([Lsystem/Object;)Lsystem/Object;
            // ([LSystem/Object;)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ConstructorInfo @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Reflection.ConstructorInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J<object>(@__env, @__real.Invoke(global::net.sf.jni4net.utils.Convertor.J2C<object[]>(@__env, parameters)));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr Invoke_22(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr obj, global::System.IntPtr invokeAttr, global::System.IntPtr binder, global::System.IntPtr parameters, global::System.IntPtr culture) {
            // (Lsystem/Object;Lsystem/reflection/BindingFlags;Ljava/lang/Object;[Lsystem/Object;Lsystem/ICloneable;)Lsystem/Object;
            // (LSystem/Object;LSystem/Reflection/BindingFlags;LSystem/Reflection/Binder;[LSystem/Object;LSystem/Globalization/CultureInfo;)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ConstructorInfo @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Reflection.ConstructorInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J<object>(@__env, ((global::System.Runtime.InteropServices._ConstructorInfo)(@__real)).Invoke_2(global::net.sf.jni4net.utils.Convertor.J2C<object>(@__env, obj), global::net.sf.jni4net.utils.Convertor.J2C<global::System.Reflection.BindingFlags>(@__env, invokeAttr), global::net.sf.jni4net.utils.Convertor.J2C<global::System.Reflection.Binder>(@__env, binder), global::net.sf.jni4net.utils.Convertor.J2C<object[]>(@__env, parameters), global::net.sf.jni4net.utils.Convertor.J2C<global::System.Globalization.CultureInfo>(@__env, culture)));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr Invoke_33(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr obj, global::System.IntPtr parameters) {
            // (Lsystem/Object;[Lsystem/Object;)Lsystem/Object;
            // (LSystem/Object;[LSystem/Object;)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ConstructorInfo @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Reflection.ConstructorInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J<object>(@__env, ((global::System.Runtime.InteropServices._ConstructorInfo)(@__real)).Invoke_3(global::net.sf.jni4net.utils.Convertor.J2C<object>(@__env, obj), global::net.sf.jni4net.utils.Convertor.J2C<object[]>(@__env, parameters)));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr Invoke_44(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr invokeAttr, global::System.IntPtr binder, global::System.IntPtr parameters, global::System.IntPtr culture) {
            // (Lsystem/reflection/BindingFlags;Ljava/lang/Object;[Lsystem/Object;Lsystem/ICloneable;)Lsystem/Object;
            // (LSystem/Reflection/BindingFlags;LSystem/Reflection/Binder;[LSystem/Object;LSystem/Globalization/CultureInfo;)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ConstructorInfo @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Reflection.ConstructorInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J<object>(@__env, ((global::System.Runtime.InteropServices._ConstructorInfo)(@__real)).Invoke_4(global::net.sf.jni4net.utils.Convertor.J2C<global::System.Reflection.BindingFlags>(@__env, invokeAttr), global::net.sf.jni4net.utils.Convertor.J2C<global::System.Reflection.Binder>(@__env, binder), global::net.sf.jni4net.utils.Convertor.J2C<object[]>(@__env, parameters), global::net.sf.jni4net.utils.Convertor.J2C<global::System.Globalization.CultureInfo>(@__env, culture)));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr Invoke_55(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr parameters) {
            // ([Lsystem/Object;)Lsystem/Object;
            // ([LSystem/Object;)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.ConstructorInfo @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Reflection.ConstructorInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J<object>(@__env, ((global::System.Runtime.InteropServices._ConstructorInfo)(@__real)).Invoke_5(global::net.sf.jni4net.utils.Convertor.J2C<object[]>(@__env, parameters)));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::System.Reflection.@__ConstructorInfo(@__env);
            }
        }
    }
    #endregion
}
