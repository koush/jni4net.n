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
    public partial class IDisposable_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.@__IDisposable.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.IDisposable))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.IDisposable))]
    internal sealed partial class @__IDisposable : global::java.lang.Object, global::System.IDisposable {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _Dispose0;
        
        protected @__IDisposable(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::System.@__IDisposable.staticClass = staticClass;
            global::System.@__IDisposable._Dispose0 = env.GetMethodID(global::System.@__IDisposable.staticClass, "Dispose", "()V");
        }
        
        public void Dispose() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::System.@__IDisposable._Dispose0);
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__IDisposable);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "Dispose", "Dispose0", "()V"));
            return methods;
        }
        
        private static void Dispose0(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IDisposable real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.IDisposable>(__env, @__obj);
            real.Dispose();
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::System.@__IDisposable(env);
            }
        }
    }
    #endregion
}
