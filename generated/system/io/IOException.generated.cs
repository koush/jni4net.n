//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.IO {
    
    
    #region Component Designer generated code 
    public partial class IOException_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.IO.@__IOException.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.IO.IOException))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.IO.IOException))]
    internal sealed partial class @__IOException : global::java.lang.Object {
        
        internal static global::java.lang.Class staticClass;
        
        protected @__IOException(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::System.IO.@__IOException.staticClass = @__class;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__IOException);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorIOException0", "__ctorIOException0", "(Lnet/sf/jni4net/inj/IClrProxy;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorIOException1", "__ctorIOException1", "(Lnet/sf/jni4net/inj/IClrProxy;Ljava/lang/String;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorIOException2", "__ctorIOException2", "(Lnet/sf/jni4net/inj/IClrProxy;Ljava/lang/String;I)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorIOException3", "__ctorIOException3", "(Lnet/sf/jni4net/inj/IClrProxy;Ljava/lang/String;Lsystem/Exception;)V"));
            return methods;
        }
        
        private static void @__ctorIOException0(global::System.IntPtr @__envp, global::System.IntPtr @__class, global::System.IntPtr @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.IOException @__real = new global::System.IO.IOException();
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
        }
        
        private static void @__ctorIOException1(global::System.IntPtr @__envp, global::System.IntPtr @__class, global::System.IntPtr @__obj, global::System.IntPtr message) {
            // (Ljava/lang/String;)V
            // (LSystem/String;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.IOException @__real = new global::System.IO.IOException(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, message));
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
        }
        
        private static void @__ctorIOException2(global::System.IntPtr @__envp, global::System.IntPtr @__class, global::System.IntPtr @__obj, global::System.IntPtr message, int hresult) {
            // (Ljava/lang/String;I)V
            // (LSystem/String;I)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.IOException @__real = new global::System.IO.IOException(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, message), hresult);
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
        }
        
        private static void @__ctorIOException3(global::System.IntPtr @__envp, global::System.IntPtr @__class, global::System.IntPtr @__obj, global::System.IntPtr message, global::System.IntPtr innerException) {
            // (Ljava/lang/String;Lsystem/Exception;)V
            // (LSystem/String;LSystem/Exception;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.IO.IOException @__real = new global::System.IO.IOException(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, message), global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.Exception>(@__env, innerException));
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::System.IO.@__IOException(@__env);
            }
        }
    }
    #endregion
}
