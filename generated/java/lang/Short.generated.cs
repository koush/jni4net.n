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
    public partial class Short : global::java.lang.Number, global::java.lang.Comparable {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _compareTo0;
        
        internal static global::net.sf.jni4net.jni.MethodId _compareTo1;
        
        internal static global::net.sf.jni4net.jni.MethodId _toString2;
        
        internal static global::net.sf.jni4net.jni.MethodId _decode3;
        
        internal static global::net.sf.jni4net.jni.MethodId _valueOf4;
        
        internal static global::net.sf.jni4net.jni.MethodId _valueOf5;
        
        internal static global::net.sf.jni4net.jni.MethodId _valueOf6;
        
        internal static global::net.sf.jni4net.jni.MethodId _reverseBytes7;
        
        internal static global::net.sf.jni4net.jni.MethodId _parseShort8;
        
        internal static global::net.sf.jni4net.jni.MethodId _parseShort9;
        
        internal static global::net.sf.jni4net.jni.FieldId _MIN_VALUE10;
        
        internal static global::net.sf.jni4net.jni.FieldId _MAX_VALUE11;
        
        internal static global::net.sf.jni4net.jni.FieldId _TYPE12;
        
        internal static global::net.sf.jni4net.jni.FieldId _SIZE13;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor14;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor15;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public Short(global::java.lang.String par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.lang.Short.staticClass, global::java.lang.Short.@__ctor14, this, global::net.sf.jni4net.utils.Convertor.ParamC2J(@__env, par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(S)V")]
        public Short(short par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.lang.Short.staticClass, global::java.lang.Short.@__ctor15, this, global::net.sf.jni4net.utils.Convertor.ParamC2J(@__env, par0));
        }
        
        protected Short(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.Short.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("S")]
        public static short MIN_VALUE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return @__env.GetStaticShortField(global::java.lang.Short.staticClass, global::java.lang.Short._MIN_VALUE10);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("S")]
        public static short MAX_VALUE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return @__env.GetStaticShortField(global::java.lang.Short.staticClass, global::java.lang.Short._MAX_VALUE11);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Ljava/lang/Class;")]
        public static global::java.lang.Class TYPE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return global::net.sf.jni4net.utils.Convertor.J2C<global::java.lang.Class>(@__env, @__env.GetStaticObjectFieldPtr(global::java.lang.Short.staticClass, global::java.lang.Short._TYPE12));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int SIZE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return @__env.GetStaticIntField(global::java.lang.Short.staticClass, global::java.lang.Short._SIZE13);
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.lang.Short.staticClass = @__class;
            global::java.lang.Short._compareTo0 = @__env.GetMethodID(global::java.lang.Short.staticClass, "compareTo", "(Ljava/lang/Object;)I");
            global::java.lang.Short._compareTo1 = @__env.GetMethodID(global::java.lang.Short.staticClass, "compareTo", "(Ljava/lang/Short;)I");
            global::java.lang.Short._toString2 = @__env.GetStaticMethodID(global::java.lang.Short.staticClass, "toString", "(S)Ljava/lang/String;");
            global::java.lang.Short._decode3 = @__env.GetStaticMethodID(global::java.lang.Short.staticClass, "decode", "(Ljava/lang/String;)Ljava/lang/Short;");
            global::java.lang.Short._valueOf4 = @__env.GetStaticMethodID(global::java.lang.Short.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Short;");
            global::java.lang.Short._valueOf5 = @__env.GetStaticMethodID(global::java.lang.Short.staticClass, "valueOf", "(Ljava/lang/String;I)Ljava/lang/Short;");
            global::java.lang.Short._valueOf6 = @__env.GetStaticMethodID(global::java.lang.Short.staticClass, "valueOf", "(S)Ljava/lang/Short;");
            global::java.lang.Short._reverseBytes7 = @__env.GetStaticMethodID(global::java.lang.Short.staticClass, "reverseBytes", "(S)S");
            global::java.lang.Short._parseShort8 = @__env.GetStaticMethodID(global::java.lang.Short.staticClass, "parseShort", "(Ljava/lang/String;I)S");
            global::java.lang.Short._parseShort9 = @__env.GetStaticMethodID(global::java.lang.Short.staticClass, "parseShort", "(Ljava/lang/String;)S");
            global::java.lang.Short._MIN_VALUE10 = @__env.GetStaticFieldID(global::java.lang.Short.staticClass, "MIN_VALUE", "S");
            global::java.lang.Short._MAX_VALUE11 = @__env.GetStaticFieldID(global::java.lang.Short.staticClass, "MAX_VALUE", "S");
            global::java.lang.Short._TYPE12 = @__env.GetStaticFieldID(global::java.lang.Short.staticClass, "TYPE", "Ljava/lang/Class;");
            global::java.lang.Short._SIZE13 = @__env.GetStaticFieldID(global::java.lang.Short.staticClass, "SIZE", "I");
            global::java.lang.Short.@__ctor14 = @__env.GetMethodID(global::java.lang.Short.staticClass, "<init>", "(Ljava/lang/String;)V");
            global::java.lang.Short.@__ctor15 = @__env.GetMethodID(global::java.lang.Short.staticClass, "<init>", "(S)V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)I")]
        public virtual int compareTo(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return @__env.CallIntMethod(this, global::java.lang.Short._compareTo0, global::net.sf.jni4net.utils.Convertor.ParamC2J(@__env, par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Short;)I")]
        public virtual int compareTo(global::java.lang.Short par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return @__env.CallIntMethod(this, global::java.lang.Short._compareTo1, global::net.sf.jni4net.utils.Convertor.ParamC2J(@__env, par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(S)Ljava/lang/String;")]
        public static global::java.lang.String toString(short par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.J2C<global::java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Short.staticClass, global::java.lang.Short._toString2, global::net.sf.jni4net.utils.Convertor.ParamC2J(@__env, par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/Short;")]
        public static global::java.lang.Short decode(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.J2C<global::java.lang.Short>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Short.staticClass, global::java.lang.Short._decode3, global::net.sf.jni4net.utils.Convertor.ParamC2J(@__env, par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/Short;")]
        public static global::java.lang.Short valueOf(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.J2C<global::java.lang.Short>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Short.staticClass, global::java.lang.Short._valueOf4, global::net.sf.jni4net.utils.Convertor.ParamC2J(@__env, par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;I)Ljava/lang/Short;")]
        public static global::java.lang.Short valueOf(global::java.lang.String par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.J2C<global::java.lang.Short>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Short.staticClass, global::java.lang.Short._valueOf5, global::net.sf.jni4net.utils.Convertor.ParamC2J(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParamC2J(@__env, par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(S)Ljava/lang/Short;")]
        public static global::java.lang.Short valueOf(short par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.J2C<global::java.lang.Short>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Short.staticClass, global::java.lang.Short._valueOf6, global::net.sf.jni4net.utils.Convertor.ParamC2J(@__env, par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(S)S")]
        public static short reverseBytes(short par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return @__env.CallStaticShortMethod(global::java.lang.Short.staticClass, global::java.lang.Short._reverseBytes7, global::net.sf.jni4net.utils.Convertor.ParamC2J(@__env, par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;I)S")]
        public static short parseShort(global::java.lang.String par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return @__env.CallStaticShortMethod(global::java.lang.Short.staticClass, global::java.lang.Short._parseShort8, global::net.sf.jni4net.utils.Convertor.ParamC2J(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParamC2J(@__env, par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)S")]
        public static short parseShort(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return @__env.CallStaticShortMethod(global::java.lang.Short.staticClass, global::java.lang.Short._parseShort9, global::net.sf.jni4net.utils.Convertor.ParamC2J(@__env, par0));
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.lang.Short(@__env);
            }
        }
    }
    #endregion
}
