//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.3074
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace net.sf.jni4net.inj {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface IClrProxy {
    }
    #endregion
    
    #region Component Designer generated code 
    public unsafe partial class IClrProxy_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::net.sf.jni4net.inj.@__IClrProxy.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::net.sf.jni4net.inj.IClrProxy))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::net.sf.jni4net.inj.IClrProxy))]
    internal unsafe partial class @__IClrProxy : global::java.lang.Object, global::net.sf.jni4net.inj.IClrProxy {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getClrHandle0;
        
        internal static global::net.sf.jni4net.jni.MethodId _initProxy1;
        
        protected @__IClrProxy(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::net.sf.jni4net.inj.@__IClrProxy.staticClass = staticClass;
            global::net.sf.jni4net.inj.@__IClrProxy._getClrHandle0 = env.GetMethodID(global::net.sf.jni4net.inj.@__IClrProxy.staticClass, "getClrHandle", "()I");
            global::net.sf.jni4net.inj.@__IClrProxy._initProxy1 = env.GetMethodID(global::net.sf.jni4net.inj.@__IClrProxy.staticClass, "initProxy", "(I)V");
        }
        
        public virtual int getClrHandle() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::net.sf.jni4net.inj.@__IClrProxy._getClrHandle0);
        }
        
        public virtual void initProxy(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::net.sf.jni4net.inj.@__IClrProxy._initProxy1, global::net.sf.jni4net.utils.Convertor.ParamC2J(env, par0));
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__IClrProxy);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getClrHandle", "getClrHandle0", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "initProxy", "initProxy1", "(I)V"));
            return methods;
        }
        
        private static int getClrHandle0(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::net.sf.jni4net.inj.IClrProxy real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::net.sf.jni4net.inj.IClrProxy>(__env, @__obj);
            return real.getClrHandle();
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static void initProxy1(global::System.IntPtr @__envi, global::System.IntPtr @__obj, int par0) {
            // (I)V
            // (I)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::net.sf.jni4net.inj.IClrProxy real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::net.sf.jni4net.inj.IClrProxy>(__env, @__obj);
            real.initProxy(par0);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::net.sf.jni4net.inj.@__IClrProxy(env);
            }
        }
    }
    #endregion
}
