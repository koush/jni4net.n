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
    public partial interface ParameterizedType : global::java.lang.reflect.Type {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/reflect/Type;")]
        java.lang.reflect.Type[] getActualTypeArguments();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/reflect/Type;")]
        global::java.lang.reflect.Type getOwnerType();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/reflect/Type;")]
        global::java.lang.reflect.Type getRawType();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class ParameterizedType_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.reflect.@__ParameterizedType.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::java.lang.reflect.ParameterizedType))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::java.lang.reflect.ParameterizedType))]
    internal sealed partial class @__ParameterizedType : global::java.lang.Object, global::java.lang.reflect.ParameterizedType {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getActualTypeArguments0;
        
        internal static global::net.sf.jni4net.jni.MethodId _getOwnerType1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getRawType2;
        
        protected @__ParameterizedType(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.lang.reflect.@__ParameterizedType.staticClass = @__class;
            global::java.lang.reflect.@__ParameterizedType._getActualTypeArguments0 = @__env.GetMethodID(global::java.lang.reflect.@__ParameterizedType.staticClass, "getActualTypeArguments", "()[Ljava/lang/reflect/Type;");
            global::java.lang.reflect.@__ParameterizedType._getOwnerType1 = @__env.GetMethodID(global::java.lang.reflect.@__ParameterizedType.staticClass, "getOwnerType", "()Ljava/lang/reflect/Type;");
            global::java.lang.reflect.@__ParameterizedType._getRawType2 = @__env.GetMethodID(global::java.lang.reflect.@__ParameterizedType.staticClass, "getRawType", "()Ljava/lang/reflect/Type;");
        }
        
        public java.lang.reflect.Type[] getActualTypeArguments() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<java.lang.reflect.Type[]>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.@__ParameterizedType._getActualTypeArguments0));
        }
        
        public global::java.lang.reflect.Type getOwnerType() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<global::java.lang.reflect.Type>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.@__ParameterizedType._getOwnerType1));
        }
        
        public global::java.lang.reflect.Type getRawType() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<global::java.lang.reflect.Type>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.@__ParameterizedType._getRawType2));
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__ParameterizedType);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getActualTypeArguments", "getActualTypeArguments0", "()[Ljava/lang/reflect/Type;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getOwnerType", "getOwnerType1", "()Ljava/lang/reflect/Type;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getRawType", "getRawType2", "()Ljava/lang/reflect/Type;"));
            return methods;
        }
        
        private static global::System.IntPtr getActualTypeArguments0(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()[Ljava/lang/reflect/Type;
            // ()[Ljava/lang/reflect/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.lang.reflect.ParameterizedType @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::java.lang.reflect.ParameterizedType>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J<java.lang.reflect.Type[]>(@__env, @__real.getActualTypeArguments());
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr getOwnerType1(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Ljava/lang/reflect/Type;
            // ()Ljava/lang/reflect/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.lang.reflect.ParameterizedType @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::java.lang.reflect.ParameterizedType>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J<global::java.lang.reflect.Type>(@__env, @__real.getOwnerType());
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr getRawType2(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Ljava/lang/reflect/Type;
            // ()Ljava/lang/reflect/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.lang.reflect.ParameterizedType @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::java.lang.reflect.ParameterizedType>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J<global::java.lang.reflect.Type>(@__env, @__real.getRawType());
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.lang.reflect.@__ParameterizedType(@__env);
            }
        }
    }
    #endregion
}
