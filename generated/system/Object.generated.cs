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
    public partial class Object_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.@__Object.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(object))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(object))]
    internal sealed partial class @__Object : global::java.lang.Object {
        
        internal static global::java.lang.Class staticClass;
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::System.@__Object.staticClass = @__class;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__Object);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ToString", "ToString0", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Equals", "Equals1", "(Lsystem/Object;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Equals", "Equals2", "(Lsystem/Object;Lsystem/Object;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ReferenceEquals", "ReferenceEquals3", "(Lsystem/Object;Lsystem/Object;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetHashCode", "GetHashCode4", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetType", "GetType5", "()Lsystem/Type;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorObject0", "__ctorObject0", "(Lnet/sf/jni4net/inj/IClrProxy;)V"));
            return methods;
        }
        
        private static global::System.IntPtr ToString0(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Ljava/lang/String;
            // ()LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            object @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Object>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2JString(@__env, @__real.ToString());
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static bool Equals1(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr obj) {
            // (Lsystem/Object;)Z
            // (LSystem/Object;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            object @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Object>(@__env, @__obj);
            return ((bool)(@__real.Equals(global::net.sf.jni4net.utils.Convertor.J2C<object>(@__env, obj))));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool Equals2(global::System.IntPtr @__envp, global::System.IntPtr @__class, global::System.IntPtr objA, global::System.IntPtr objB) {
            // (Lsystem/Object;Lsystem/Object;)Z
            // (LSystem/Object;LSystem/Object;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            return ((bool)(object.Equals(global::net.sf.jni4net.utils.Convertor.J2C<object>(@__env, objA), global::net.sf.jni4net.utils.Convertor.J2C<object>(@__env, objB))));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool ReferenceEquals3(global::System.IntPtr @__envp, global::System.IntPtr @__class, global::System.IntPtr objA, global::System.IntPtr objB) {
            // (Lsystem/Object;Lsystem/Object;)Z
            // (LSystem/Object;LSystem/Object;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            return ((bool)(object.ReferenceEquals(global::net.sf.jni4net.utils.Convertor.J2C<object>(@__env, objA), global::net.sf.jni4net.utils.Convertor.J2C<object>(@__env, objB))));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static int GetHashCode4(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            object @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Object>(@__env, @__obj);
            return ((int)(@__real.GetHashCode()));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static global::System.IntPtr GetType5(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Lsystem/Type;
            // ()LSystem/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            object @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Object>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J<global::System.Type>(@__env, @__real.GetType());
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static void @__ctorObject0(global::System.IntPtr @__envp, global::System.IntPtr @__class, global::System.IntPtr @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            object @__real = new object();
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::System.@__Object(@__env);
            }
        }
    }
    #endregion
}
