//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang.reflect {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class Modifier : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _toString0;
        
        internal static global::net.sf.jni4net.jni.MethodId _isAbstract1;
        
        internal static global::net.sf.jni4net.jni.MethodId _isInterface2;
        
        internal static global::net.sf.jni4net.jni.MethodId _isProtected3;
        
        internal static global::net.sf.jni4net.jni.MethodId _isPublic4;
        
        internal static global::net.sf.jni4net.jni.MethodId _isFinal5;
        
        internal static global::net.sf.jni4net.jni.MethodId _isNative6;
        
        internal static global::net.sf.jni4net.jni.MethodId _isPrivate7;
        
        internal static global::net.sf.jni4net.jni.MethodId _isStatic8;
        
        internal static global::net.sf.jni4net.jni.MethodId _isStrict9;
        
        internal static global::net.sf.jni4net.jni.MethodId _isSynchronized10;
        
        internal static global::net.sf.jni4net.jni.MethodId _isTransient11;
        
        internal static global::net.sf.jni4net.jni.MethodId _isVolatile12;
        
        internal static global::net.sf.jni4net.jni.FieldId _PUBLIC13;
        
        internal static global::net.sf.jni4net.jni.FieldId _PRIVATE14;
        
        internal static global::net.sf.jni4net.jni.FieldId _PROTECTED15;
        
        internal static global::net.sf.jni4net.jni.FieldId _STATIC16;
        
        internal static global::net.sf.jni4net.jni.FieldId _FINAL17;
        
        internal static global::net.sf.jni4net.jni.FieldId _SYNCHRONIZED18;
        
        internal static global::net.sf.jni4net.jni.FieldId _VOLATILE19;
        
        internal static global::net.sf.jni4net.jni.FieldId _TRANSIENT20;
        
        internal static global::net.sf.jni4net.jni.FieldId _NATIVE21;
        
        internal static global::net.sf.jni4net.jni.FieldId _INTERFACE22;
        
        internal static global::net.sf.jni4net.jni.FieldId _ABSTRACT23;
        
        internal static global::net.sf.jni4net.jni.FieldId _STRICT24;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorModifier25;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public Modifier() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier.@__ctorModifier25, this);
        }
        
        protected Modifier(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.reflect.Modifier.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int PUBLIC {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._PUBLIC13)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int PRIVATE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._PRIVATE14)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int PROTECTED {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._PROTECTED15)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int STATIC {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._STATIC16)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int FINAL {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._FINAL17)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int SYNCHRONIZED {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._SYNCHRONIZED18)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int VOLATILE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._VOLATILE19)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int TRANSIENT {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._TRANSIENT20)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int NATIVE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._NATIVE21)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int INTERFACE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._INTERFACE22)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int ABSTRACT {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._ABSTRACT23)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int STRICT {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._STRICT24)));
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.lang.reflect.Modifier.staticClass = @__class;
            global::java.lang.reflect.Modifier._toString0 = @__env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "toString", "(I)Ljava/lang/String;");
            global::java.lang.reflect.Modifier._isAbstract1 = @__env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "isAbstract", "(I)Z");
            global::java.lang.reflect.Modifier._isInterface2 = @__env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "isInterface", "(I)Z");
            global::java.lang.reflect.Modifier._isProtected3 = @__env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "isProtected", "(I)Z");
            global::java.lang.reflect.Modifier._isPublic4 = @__env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "isPublic", "(I)Z");
            global::java.lang.reflect.Modifier._isFinal5 = @__env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "isFinal", "(I)Z");
            global::java.lang.reflect.Modifier._isNative6 = @__env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "isNative", "(I)Z");
            global::java.lang.reflect.Modifier._isPrivate7 = @__env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "isPrivate", "(I)Z");
            global::java.lang.reflect.Modifier._isStatic8 = @__env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "isStatic", "(I)Z");
            global::java.lang.reflect.Modifier._isStrict9 = @__env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "isStrict", "(I)Z");
            global::java.lang.reflect.Modifier._isSynchronized10 = @__env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "isSynchronized", "(I)Z");
            global::java.lang.reflect.Modifier._isTransient11 = @__env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "isTransient", "(I)Z");
            global::java.lang.reflect.Modifier._isVolatile12 = @__env.GetStaticMethodID(global::java.lang.reflect.Modifier.staticClass, "isVolatile", "(I)Z");
            global::java.lang.reflect.Modifier._PUBLIC13 = @__env.GetStaticFieldID(global::java.lang.reflect.Modifier.staticClass, "PUBLIC", "I");
            global::java.lang.reflect.Modifier._PRIVATE14 = @__env.GetStaticFieldID(global::java.lang.reflect.Modifier.staticClass, "PRIVATE", "I");
            global::java.lang.reflect.Modifier._PROTECTED15 = @__env.GetStaticFieldID(global::java.lang.reflect.Modifier.staticClass, "PROTECTED", "I");
            global::java.lang.reflect.Modifier._STATIC16 = @__env.GetStaticFieldID(global::java.lang.reflect.Modifier.staticClass, "STATIC", "I");
            global::java.lang.reflect.Modifier._FINAL17 = @__env.GetStaticFieldID(global::java.lang.reflect.Modifier.staticClass, "FINAL", "I");
            global::java.lang.reflect.Modifier._SYNCHRONIZED18 = @__env.GetStaticFieldID(global::java.lang.reflect.Modifier.staticClass, "SYNCHRONIZED", "I");
            global::java.lang.reflect.Modifier._VOLATILE19 = @__env.GetStaticFieldID(global::java.lang.reflect.Modifier.staticClass, "VOLATILE", "I");
            global::java.lang.reflect.Modifier._TRANSIENT20 = @__env.GetStaticFieldID(global::java.lang.reflect.Modifier.staticClass, "TRANSIENT", "I");
            global::java.lang.reflect.Modifier._NATIVE21 = @__env.GetStaticFieldID(global::java.lang.reflect.Modifier.staticClass, "NATIVE", "I");
            global::java.lang.reflect.Modifier._INTERFACE22 = @__env.GetStaticFieldID(global::java.lang.reflect.Modifier.staticClass, "INTERFACE", "I");
            global::java.lang.reflect.Modifier._ABSTRACT23 = @__env.GetStaticFieldID(global::java.lang.reflect.Modifier.staticClass, "ABSTRACT", "I");
            global::java.lang.reflect.Modifier._STRICT24 = @__env.GetStaticFieldID(global::java.lang.reflect.Modifier.staticClass, "STRICT", "I");
            global::java.lang.reflect.Modifier.@__ctorModifier25 = @__env.GetMethodID(global::java.lang.reflect.Modifier.staticClass, "<init>", "()V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Ljava/lang/String;")]
        public static global::java.lang.String toString(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._toString0, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Z")]
        public static bool isAbstract(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((bool)(@__env.CallStaticBooleanMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isAbstract1, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Z")]
        public static bool isInterface(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((bool)(@__env.CallStaticBooleanMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isInterface2, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Z")]
        public static bool isProtected(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((bool)(@__env.CallStaticBooleanMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isProtected3, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Z")]
        public static bool isPublic(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((bool)(@__env.CallStaticBooleanMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isPublic4, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Z")]
        public static bool isFinal(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((bool)(@__env.CallStaticBooleanMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isFinal5, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Z")]
        public static bool isNative(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((bool)(@__env.CallStaticBooleanMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isNative6, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Z")]
        public static bool isPrivate(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((bool)(@__env.CallStaticBooleanMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isPrivate7, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Z")]
        public static bool isStatic(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((bool)(@__env.CallStaticBooleanMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isStatic8, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Z")]
        public static bool isStrict(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((bool)(@__env.CallStaticBooleanMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isStrict9, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Z")]
        public static bool isSynchronized(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((bool)(@__env.CallStaticBooleanMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isSynchronized10, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Z")]
        public static bool isTransient(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((bool)(@__env.CallStaticBooleanMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isTransient11, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Z")]
        public static bool isVolatile(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((bool)(@__env.CallStaticBooleanMethod(global::java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._isVolatile12, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.lang.reflect.Modifier(@__env);
            }
        }
    }
    #endregion
}
