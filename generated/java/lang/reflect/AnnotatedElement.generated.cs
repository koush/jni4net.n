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
    public partial interface AnnotatedElement {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;")]
        global::java.lang.annotation.Annotation getAnnotation(global::java.lang.Class par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/annotation/Annotation;")]
        java.lang.annotation.Annotation[] getAnnotations();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/annotation/Annotation;")]
        java.lang.annotation.Annotation[] getDeclaredAnnotations();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Class;)Z")]
        bool isAnnotationPresent(global::java.lang.Class par0);
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class AnnotatedElement_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.reflect.@__AnnotatedElement.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::java.lang.reflect.AnnotatedElement))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::java.lang.reflect.AnnotatedElement))]
    internal sealed partial class @__AnnotatedElement : global::java.lang.Object, global::java.lang.reflect.AnnotatedElement {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getAnnotation0;
        
        internal static global::net.sf.jni4net.jni.MethodId _getAnnotations1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getDeclaredAnnotations2;
        
        internal static global::net.sf.jni4net.jni.MethodId _isAnnotationPresent3;
        
        protected @__AnnotatedElement(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.lang.reflect.@__AnnotatedElement.staticClass = @__class;
            global::java.lang.reflect.@__AnnotatedElement._getAnnotation0 = @__env.GetMethodID(global::java.lang.reflect.@__AnnotatedElement.staticClass, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;");
            global::java.lang.reflect.@__AnnotatedElement._getAnnotations1 = @__env.GetMethodID(global::java.lang.reflect.@__AnnotatedElement.staticClass, "getAnnotations", "()[Ljava/lang/annotation/Annotation;");
            global::java.lang.reflect.@__AnnotatedElement._getDeclaredAnnotations2 = @__env.GetMethodID(global::java.lang.reflect.@__AnnotatedElement.staticClass, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;");
            global::java.lang.reflect.@__AnnotatedElement._isAnnotationPresent3 = @__env.GetMethodID(global::java.lang.reflect.@__AnnotatedElement.staticClass, "isAnnotationPresent", "(Ljava/lang/Class;)Z");
        }
        
        public global::java.lang.annotation.Annotation getAnnotation(global::java.lang.Class par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.annotation.Annotation>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.@__AnnotatedElement._getAnnotation0, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
        }
        
        public java.lang.annotation.Annotation[] getAnnotations() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<java.lang.annotation.Annotation[], global::java.lang.annotation.Annotation>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.@__AnnotatedElement._getAnnotations1));
        }
        
        public java.lang.annotation.Annotation[] getDeclaredAnnotations() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<java.lang.annotation.Annotation[], global::java.lang.annotation.Annotation>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.@__AnnotatedElement._getDeclaredAnnotations2));
        }
        
        public bool isAnnotationPresent(global::java.lang.Class par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.lang.reflect.@__AnnotatedElement._isAnnotationPresent3, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0))));
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__AnnotatedElement);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getAnnotation", "getAnnotation0", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getAnnotations", "getAnnotations1", "()[Ljava/lang/annotation/Annotation;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getDeclaredAnnotations", "getDeclaredAnnotations2", "()[Ljava/lang/annotation/Annotation;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isAnnotationPresent", "isAnnotationPresent3", "(Ljava/lang/Class;)Z"));
            return methods;
        }
        
        private static global::System.IntPtr getAnnotation0(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr par0) {
            // (Ljava/lang/Class;)Ljava/lang/annotation/Annotation;
            // (Ljava/lang/Class;)Ljava/lang/annotation/Annotation;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.lang.reflect.AnnotatedElement @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.reflect.AnnotatedElement>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.lang.annotation.Annotation>(@__env, @__real.getAnnotation(global::net.sf.jni4net.utils.Convertor.StrongJ2CpClass(@__env, par0)));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr getAnnotations1(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()[Ljava/lang/annotation/Annotation;
            // ()[Ljava/lang/annotation/Annotation;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.lang.reflect.AnnotatedElement @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.reflect.AnnotatedElement>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.ArrayFullC2J<java.lang.annotation.Annotation[], global::java.lang.annotation.Annotation>(@__env, @__real.getAnnotations());
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr getDeclaredAnnotations2(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()[Ljava/lang/annotation/Annotation;
            // ()[Ljava/lang/annotation/Annotation;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.lang.reflect.AnnotatedElement @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.reflect.AnnotatedElement>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.ArrayFullC2J<java.lang.annotation.Annotation[], global::java.lang.annotation.Annotation>(@__env, @__real.getDeclaredAnnotations());
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static bool isAnnotationPresent3(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr par0) {
            // (Ljava/lang/Class;)Z
            // (Ljava/lang/Class;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.lang.reflect.AnnotatedElement @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.reflect.AnnotatedElement>(@__env, @__obj);
            return ((bool)(@__real.isAnnotationPresent(global::net.sf.jni4net.utils.Convertor.StrongJ2CpClass(@__env, par0))));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.lang.reflect.@__AnnotatedElement(@__env);
            }
        }
    }
    #endregion
}
