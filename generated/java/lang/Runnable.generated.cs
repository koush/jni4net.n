//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface Runnable {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        void run();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class Runnable_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.@__Runnable.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::java.lang.Runnable))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::java.lang.Runnable))]
    internal sealed partial class @__Runnable : global::java.lang.Object, global::java.lang.Runnable {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _run0;
        
        protected @__Runnable(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.lang.@__Runnable.staticClass = @__class;
            global::java.lang.@__Runnable._run0 = @__env.GetMethodID(global::java.lang.@__Runnable.staticClass, "run", "()V");
        }
        
        public void run() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.lang.@__Runnable._run0);
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__Runnable);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "run", "run0", "()V"));
            return methods;
        }
        
        private static void run0(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.lang.Runnable @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Runnable>(@__env, @__obj);
            @__real.run();
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.lang.@__Runnable(@__env);
            }
        }
    }
    #endregion
}
