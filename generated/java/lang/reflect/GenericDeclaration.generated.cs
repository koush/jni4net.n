//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang.reflect {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface GenericDeclaration {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/reflect/TypeVariable;")]
        java.lang.reflect.TypeVariable[] getTypeParameters();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class GenericDeclaration_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.reflect.@__GenericDeclaration.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::java.lang.reflect.GenericDeclaration))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::java.lang.reflect.GenericDeclaration))]
    internal sealed partial class @__GenericDeclaration : global::java.lang.Object, global::java.lang.reflect.GenericDeclaration {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getTypeParameters0;
        
        protected @__GenericDeclaration(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::java.lang.reflect.@__GenericDeclaration.staticClass = staticClass;
            global::java.lang.reflect.@__GenericDeclaration._getTypeParameters0 = env.GetMethodID(global::java.lang.reflect.@__GenericDeclaration.staticClass, "getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;");
        }
        
        public java.lang.reflect.TypeVariable[] getTypeParameters() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<java.lang.reflect.TypeVariable[]>(env, env.CallObjectMethodPtr(this, global::java.lang.reflect.@__GenericDeclaration._getTypeParameters0));
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__GenericDeclaration);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getTypeParameters", "getTypeParameters0", "()[Ljava/lang/reflect/TypeVariable;"));
            return methods;
        }
        
        private static global::System.IntPtr getTypeParameters0(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()[Ljava/lang/reflect/TypeVariable;
            // ()[Ljava/lang/reflect/TypeVariable;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::java.lang.reflect.GenericDeclaration real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.lang.reflect.GenericDeclaration>(__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J(@__env, real.getTypeParameters());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::java.lang.reflect.@__GenericDeclaration(env);
            }
        }
    }
    #endregion
}
