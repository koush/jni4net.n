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
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class Throwable {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _printStackTrace0;
        
        internal static global::net.sf.jni4net.jni.MethodId _printStackTrace1;
        
        internal static global::net.sf.jni4net.jni.MethodId _printStackTrace2;
        
        internal static global::net.sf.jni4net.jni.MethodId _fillInStackTrace3;
        
        internal static global::net.sf.jni4net.jni.MethodId _toString4;
        
        internal static global::net.sf.jni4net.jni.MethodId _getCause5;
        
        internal static global::net.sf.jni4net.jni.MethodId _getLocalizedMessage6;
        
        internal static global::net.sf.jni4net.jni.MethodId _getMessage7;
        
        internal static global::net.sf.jni4net.jni.MethodId _getStackTrace8;
        
        internal static global::net.sf.jni4net.jni.MethodId _initCause9;
        
        internal static global::net.sf.jni4net.jni.MethodId _setStackTrace10;
        
        internal static global::net.sf.jni4net.jni.MethodId _hashCode11;
        
        internal static global::net.sf.jni4net.jni.MethodId _getClass12;
        
        internal static global::net.sf.jni4net.jni.MethodId _wait13;
        
        internal static global::net.sf.jni4net.jni.MethodId _wait14;
        
        internal static global::net.sf.jni4net.jni.MethodId _wait15;
        
        internal static global::net.sf.jni4net.jni.MethodId _equals16;
        
        internal static global::net.sf.jni4net.jni.MethodId _notify17;
        
        internal static global::net.sf.jni4net.jni.MethodId _notifyAll18;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorThrowable19;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorThrowable20;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorThrowable21;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorThrowable22;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public Throwable(global::java.lang.String par0) : this (global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.lang.Throwable.staticClass, global::java.lang.Throwable.@__ctorThrowable19, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/Throwable;)V")]
        public Throwable(global::java.lang.String par0, global::java.lang.Throwable par1) : this (global::net.sf.jni4net.jni.JNIEnv.ThreadEnv)  {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.lang.Throwable.staticClass, global::java.lang.Throwable.@__ctorThrowable20, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Throwable>(@__env, par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Throwable;)V")]
        public Throwable(global::java.lang.Throwable par0) : this (global::net.sf.jni4net.jni.JNIEnv.ThreadEnv)  {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.lang.Throwable.staticClass, global::java.lang.Throwable.@__ctorThrowable21, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Throwable>(@__env, par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public Throwable() : this (global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.lang.Throwable.staticClass, global::java.lang.Throwable.@__ctorThrowable22, this);
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::java.lang.Throwable.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.lang.Throwable.staticClass = @__class;
            global::java.lang.Throwable._printStackTrace0 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "printStackTrace", "(Ljava/io/PrintWriter;)V");
            global::java.lang.Throwable._printStackTrace1 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "printStackTrace", "(Ljava/io/PrintStream;)V");
            global::java.lang.Throwable._printStackTrace2 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "printStackTrace", "()V");
            global::java.lang.Throwable._fillInStackTrace3 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "fillInStackTrace", "()Ljava/lang/Throwable;");
            global::java.lang.Throwable._toString4 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "toString", "()Ljava/lang/String;");
            global::java.lang.Throwable._getCause5 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "getCause", "()Ljava/lang/Throwable;");
            global::java.lang.Throwable._getLocalizedMessage6 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "getLocalizedMessage", "()Ljava/lang/String;");
            global::java.lang.Throwable._getMessage7 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "getMessage", "()Ljava/lang/String;");
            global::java.lang.Throwable._getStackTrace8 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "getStackTrace", "()[Ljava/lang/StackTraceElement;");
            global::java.lang.Throwable._initCause9 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "initCause", "(Ljava/lang/Throwable;)Ljava/lang/Throwable;");
            global::java.lang.Throwable._setStackTrace10 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "setStackTrace", "([Ljava/lang/StackTraceElement;)V");
            global::java.lang.Throwable._hashCode11 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "hashCode", "()I");
            global::java.lang.Throwable._getClass12 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "getClass", "()Ljava/lang/Class;");
            global::java.lang.Throwable._wait13 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "wait", "()V");
            global::java.lang.Throwable._wait14 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "wait", "(JI)V");
            global::java.lang.Throwable._wait15 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "wait", "(J)V");
            global::java.lang.Throwable._equals16 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "equals", "(Ljava/lang/Object;)Z");
            global::java.lang.Throwable._notify17 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "notify", "()V");
            global::java.lang.Throwable._notifyAll18 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "notifyAll", "()V");
            global::java.lang.Throwable.@__ctorThrowable19 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "<init>", "(Ljava/lang/String;)V");
            global::java.lang.Throwable.@__ctorThrowable20 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
            global::java.lang.Throwable.@__ctorThrowable21 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
            global::java.lang.Throwable.@__ctorThrowable22 = @__env.GetMethodID(global::java.lang.Throwable.staticClass, "<init>", "()V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/PrintWriter;)V")]
        public virtual void printStackTrace(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.lang.Throwable._printStackTrace0, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/PrintStream;)V")]
        public virtual void printStackTrace(global::java.io.PrintStream par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.lang.Throwable._printStackTrace1, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public virtual void printStackTrace() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.lang.Throwable._printStackTrace2);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Throwable;")]
        public virtual global::java.lang.Throwable fillInStackTrace() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Throwable>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Throwable._fillInStackTrace3));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String toString() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Throwable._toString4));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Throwable;")]
        public virtual global::java.lang.Throwable getCause() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Throwable>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Throwable._getCause5));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getLocalizedMessage() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Throwable._getLocalizedMessage6));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getMessage() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Throwable._getMessage7));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/StackTraceElement;")]
        public virtual java.lang.StackTraceElement[] getStackTrace() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.ArrayStrongJ2Cp<java.lang.StackTraceElement[], global::java.lang.StackTraceElement>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Throwable._getStackTrace8));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Throwable;)Ljava/lang/Throwable;")]
        public virtual global::java.lang.Throwable initCause(global::java.lang.Throwable par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Throwable>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Throwable._initCause9, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Throwable>(@__env, par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([Ljava/lang/StackTraceElement;)V")]
        public virtual void setStackTrace(java.lang.StackTraceElement[] par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.lang.Throwable._setStackTrace10, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int hashCode() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::java.lang.Throwable._hashCode11)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Class;")]
        public global::java.lang.Class getClass() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpClass(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Throwable._getClass12));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public void wait() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.lang.Throwable._wait13);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(JI)V")]
        public void wait(long par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.lang.Throwable._wait14, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)V")]
        public void wait(long par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.lang.Throwable._wait15, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Z")]
        public virtual bool equals(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.lang.Throwable._equals16, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public void notify() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.lang.Throwable._notify17);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public void notifyAll() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.lang.Throwable._notifyAll18);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.lang.Throwable(@__env);
            }
        }
    }
    #endregion
}
