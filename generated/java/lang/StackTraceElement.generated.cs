//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class StackTraceElement : global::java.lang.Object, global::java.io.Serializable {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getClassName0;
        
        internal static global::net.sf.jni4net.jni.MethodId _getFileName1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getLineNumber2;
        
        internal static global::net.sf.jni4net.jni.MethodId _getMethodName3;
        
        internal static global::net.sf.jni4net.jni.MethodId _isNativeMethod4;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor5;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V")]
        public StackTraceElement(global::java.lang.String par0, global::java.lang.String par1, global::java.lang.String par2, int par3) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.lang.StackTraceElement.staticClass, global::java.lang.StackTraceElement.@__ctor5, this, global::net.sf.jni4net.utils.Convertor.ParamC2J<global::java.lang.String>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParamC2J<global::java.lang.String>(@__env, par1), global::net.sf.jni4net.utils.Convertor.ParamC2J<global::java.lang.String>(@__env, par2), global::net.sf.jni4net.utils.Convertor.ParamC2J(@__env, par3));
        }
        
        protected StackTraceElement(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.StackTraceElement.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.lang.StackTraceElement.staticClass = @__class;
            global::java.lang.StackTraceElement._getClassName0 = @__env.GetMethodID(global::java.lang.StackTraceElement.staticClass, "getClassName", "()Ljava/lang/String;");
            global::java.lang.StackTraceElement._getFileName1 = @__env.GetMethodID(global::java.lang.StackTraceElement.staticClass, "getFileName", "()Ljava/lang/String;");
            global::java.lang.StackTraceElement._getLineNumber2 = @__env.GetMethodID(global::java.lang.StackTraceElement.staticClass, "getLineNumber", "()I");
            global::java.lang.StackTraceElement._getMethodName3 = @__env.GetMethodID(global::java.lang.StackTraceElement.staticClass, "getMethodName", "()Ljava/lang/String;");
            global::java.lang.StackTraceElement._isNativeMethod4 = @__env.GetMethodID(global::java.lang.StackTraceElement.staticClass, "isNativeMethod", "()Z");
            global::java.lang.StackTraceElement.@__ctor5 = @__env.GetMethodID(global::java.lang.StackTraceElement.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getClassName() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<global::java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.StackTraceElement._getClassName0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getFileName() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<global::java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.StackTraceElement._getFileName1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int getLineNumber() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::java.lang.StackTraceElement._getLineNumber2)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getMethodName() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<global::java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.StackTraceElement._getMethodName3));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isNativeMethod() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.lang.StackTraceElement._isNativeMethod4)));
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.lang.StackTraceElement(@__env);
            }
        }
    }
    #endregion
}
