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
    public partial class Integer : global::java.lang.Number, global::java.lang.Comparable {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _compareTo0;
        
        internal static global::net.sf.jni4net.jni.MethodId _compareTo1;
        
        internal static global::net.sf.jni4net.jni.MethodId _toHexString2;
        
        internal static global::net.sf.jni4net.jni.MethodId _toString3;
        
        internal static global::net.sf.jni4net.jni.MethodId _toString4;
        
        internal static global::net.sf.jni4net.jni.MethodId _decode5;
        
        internal static global::net.sf.jni4net.jni.MethodId _valueOf6;
        
        internal static global::net.sf.jni4net.jni.MethodId _valueOf7;
        
        internal static global::net.sf.jni4net.jni.MethodId _valueOf8;
        
        internal static global::net.sf.jni4net.jni.MethodId _reverse9;
        
        internal static global::net.sf.jni4net.jni.MethodId _reverseBytes10;
        
        internal static global::net.sf.jni4net.jni.MethodId _parseInt11;
        
        internal static global::net.sf.jni4net.jni.MethodId _parseInt12;
        
        internal static global::net.sf.jni4net.jni.MethodId _bitCount13;
        
        internal static global::net.sf.jni4net.jni.MethodId _getInteger14;
        
        internal static global::net.sf.jni4net.jni.MethodId _getInteger15;
        
        internal static global::net.sf.jni4net.jni.MethodId _getInteger16;
        
        internal static global::net.sf.jni4net.jni.MethodId _highestOneBit17;
        
        internal static global::net.sf.jni4net.jni.MethodId _lowestOneBit18;
        
        internal static global::net.sf.jni4net.jni.MethodId _numberOfLeadingZeros19;
        
        internal static global::net.sf.jni4net.jni.MethodId _numberOfTrailingZeros20;
        
        internal static global::net.sf.jni4net.jni.MethodId _rotateLeft21;
        
        internal static global::net.sf.jni4net.jni.MethodId _rotateRight22;
        
        internal static global::net.sf.jni4net.jni.MethodId _signum23;
        
        internal static global::net.sf.jni4net.jni.MethodId _toBinaryString24;
        
        internal static global::net.sf.jni4net.jni.MethodId _toOctalString25;
        
        internal static global::net.sf.jni4net.jni.FieldId _MIN_VALUE26;
        
        internal static global::net.sf.jni4net.jni.FieldId _MAX_VALUE27;
        
        internal static global::net.sf.jni4net.jni.FieldId _TYPE28;
        
        internal static global::net.sf.jni4net.jni.FieldId _SIZE29;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorInteger30;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorInteger31;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public Integer(global::java.lang.String par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.lang.Integer.staticClass, global::java.lang.Integer.@__ctorInteger30, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)V")]
        public Integer(int par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.lang.Integer.staticClass, global::java.lang.Integer.@__ctorInteger31, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
        }
        
        protected Integer(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.Integer.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int MIN_VALUE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.lang.Integer.staticClass, global::java.lang.Integer._MIN_VALUE26)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int MAX_VALUE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.lang.Integer.staticClass, global::java.lang.Integer._MAX_VALUE27)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Ljava/lang/Class;")]
        public static global::java.lang.Class TYPE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return global::net.sf.jni4net.utils.Convertor.StrongJ2CpClass(@__env, @__env.GetStaticObjectFieldPtr(global::java.lang.Integer.staticClass, global::java.lang.Integer._TYPE28));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int SIZE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.lang.Integer.staticClass, global::java.lang.Integer._SIZE29)));
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.lang.Integer.staticClass = @__class;
            global::java.lang.Integer._compareTo0 = @__env.GetMethodID(global::java.lang.Integer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
            global::java.lang.Integer._compareTo1 = @__env.GetMethodID(global::java.lang.Integer.staticClass, "compareTo", "(Ljava/lang/Integer;)I");
            global::java.lang.Integer._toHexString2 = @__env.GetStaticMethodID(global::java.lang.Integer.staticClass, "toHexString", "(I)Ljava/lang/String;");
            global::java.lang.Integer._toString3 = @__env.GetStaticMethodID(global::java.lang.Integer.staticClass, "toString", "(II)Ljava/lang/String;");
            global::java.lang.Integer._toString4 = @__env.GetStaticMethodID(global::java.lang.Integer.staticClass, "toString", "(I)Ljava/lang/String;");
            global::java.lang.Integer._decode5 = @__env.GetStaticMethodID(global::java.lang.Integer.staticClass, "decode", "(Ljava/lang/String;)Ljava/lang/Integer;");
            global::java.lang.Integer._valueOf6 = @__env.GetStaticMethodID(global::java.lang.Integer.staticClass, "valueOf", "(Ljava/lang/String;I)Ljava/lang/Integer;");
            global::java.lang.Integer._valueOf7 = @__env.GetStaticMethodID(global::java.lang.Integer.staticClass, "valueOf", "(I)Ljava/lang/Integer;");
            global::java.lang.Integer._valueOf8 = @__env.GetStaticMethodID(global::java.lang.Integer.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Integer;");
            global::java.lang.Integer._reverse9 = @__env.GetStaticMethodID(global::java.lang.Integer.staticClass, "reverse", "(I)I");
            global::java.lang.Integer._reverseBytes10 = @__env.GetStaticMethodID(global::java.lang.Integer.staticClass, "reverseBytes", "(I)I");
            global::java.lang.Integer._parseInt11 = @__env.GetStaticMethodID(global::java.lang.Integer.staticClass, "parseInt", "(Ljava/lang/String;)I");
            global::java.lang.Integer._parseInt12 = @__env.GetStaticMethodID(global::java.lang.Integer.staticClass, "parseInt", "(Ljava/lang/String;I)I");
            global::java.lang.Integer._bitCount13 = @__env.GetStaticMethodID(global::java.lang.Integer.staticClass, "bitCount", "(I)I");
            global::java.lang.Integer._getInteger14 = @__env.GetStaticMethodID(global::java.lang.Integer.staticClass, "getInteger", "(Ljava/lang/String;)Ljava/lang/Integer;");
            global::java.lang.Integer._getInteger15 = @__env.GetStaticMethodID(global::java.lang.Integer.staticClass, "getInteger", "(Ljava/lang/String;I)Ljava/lang/Integer;");
            global::java.lang.Integer._getInteger16 = @__env.GetStaticMethodID(global::java.lang.Integer.staticClass, "getInteger", "(Ljava/lang/String;Ljava/lang/Integer;)Ljava/lang/Integer;");
            global::java.lang.Integer._highestOneBit17 = @__env.GetStaticMethodID(global::java.lang.Integer.staticClass, "highestOneBit", "(I)I");
            global::java.lang.Integer._lowestOneBit18 = @__env.GetStaticMethodID(global::java.lang.Integer.staticClass, "lowestOneBit", "(I)I");
            global::java.lang.Integer._numberOfLeadingZeros19 = @__env.GetStaticMethodID(global::java.lang.Integer.staticClass, "numberOfLeadingZeros", "(I)I");
            global::java.lang.Integer._numberOfTrailingZeros20 = @__env.GetStaticMethodID(global::java.lang.Integer.staticClass, "numberOfTrailingZeros", "(I)I");
            global::java.lang.Integer._rotateLeft21 = @__env.GetStaticMethodID(global::java.lang.Integer.staticClass, "rotateLeft", "(II)I");
            global::java.lang.Integer._rotateRight22 = @__env.GetStaticMethodID(global::java.lang.Integer.staticClass, "rotateRight", "(II)I");
            global::java.lang.Integer._signum23 = @__env.GetStaticMethodID(global::java.lang.Integer.staticClass, "signum", "(I)I");
            global::java.lang.Integer._toBinaryString24 = @__env.GetStaticMethodID(global::java.lang.Integer.staticClass, "toBinaryString", "(I)Ljava/lang/String;");
            global::java.lang.Integer._toOctalString25 = @__env.GetStaticMethodID(global::java.lang.Integer.staticClass, "toOctalString", "(I)Ljava/lang/String;");
            global::java.lang.Integer._MIN_VALUE26 = @__env.GetStaticFieldID(global::java.lang.Integer.staticClass, "MIN_VALUE", "I");
            global::java.lang.Integer._MAX_VALUE27 = @__env.GetStaticFieldID(global::java.lang.Integer.staticClass, "MAX_VALUE", "I");
            global::java.lang.Integer._TYPE28 = @__env.GetStaticFieldID(global::java.lang.Integer.staticClass, "TYPE", "Ljava/lang/Class;");
            global::java.lang.Integer._SIZE29 = @__env.GetStaticFieldID(global::java.lang.Integer.staticClass, "SIZE", "I");
            global::java.lang.Integer.@__ctorInteger30 = @__env.GetMethodID(global::java.lang.Integer.staticClass, "<init>", "(Ljava/lang/String;)V");
            global::java.lang.Integer.@__ctorInteger31 = @__env.GetMethodID(global::java.lang.Integer.staticClass, "<init>", "(I)V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)I")]
        public virtual int compareTo(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::java.lang.Integer._compareTo0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Integer;)I")]
        public virtual int compareTo(global::java.lang.Integer par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::java.lang.Integer._compareTo1, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Ljava/lang/String;")]
        public static global::java.lang.String toHexString(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Integer.staticClass, global::java.lang.Integer._toHexString2, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(II)Ljava/lang/String;")]
        public static global::java.lang.String toString(int par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Integer.staticClass, global::java.lang.Integer._toString3, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Ljava/lang/String;")]
        public static global::java.lang.String toString(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Integer.staticClass, global::java.lang.Integer._toString4, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/Integer;")]
        public static global::java.lang.Integer decode(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Integer>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Integer.staticClass, global::java.lang.Integer._decode5, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;I)Ljava/lang/Integer;")]
        public static global::java.lang.Integer valueOf(global::java.lang.String par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Integer>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Integer.staticClass, global::java.lang.Integer._valueOf6, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Ljava/lang/Integer;")]
        public static global::java.lang.Integer valueOf(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Integer>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Integer.staticClass, global::java.lang.Integer._valueOf7, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/Integer;")]
        public static global::java.lang.Integer valueOf(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Integer>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Integer.staticClass, global::java.lang.Integer._valueOf8, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)I")]
        public static int reverse(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((int)(@__env.CallStaticIntMethod(global::java.lang.Integer.staticClass, global::java.lang.Integer._reverse9, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)I")]
        public static int reverseBytes(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((int)(@__env.CallStaticIntMethod(global::java.lang.Integer.staticClass, global::java.lang.Integer._reverseBytes10, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)I")]
        public static int parseInt(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((int)(@__env.CallStaticIntMethod(global::java.lang.Integer.staticClass, global::java.lang.Integer._parseInt11, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;I)I")]
        public static int parseInt(global::java.lang.String par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((int)(@__env.CallStaticIntMethod(global::java.lang.Integer.staticClass, global::java.lang.Integer._parseInt12, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)I")]
        public static int bitCount(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((int)(@__env.CallStaticIntMethod(global::java.lang.Integer.staticClass, global::java.lang.Integer._bitCount13, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/Integer;")]
        public static global::java.lang.Integer getInteger(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Integer>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Integer.staticClass, global::java.lang.Integer._getInteger14, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;I)Ljava/lang/Integer;")]
        public static global::java.lang.Integer getInteger(global::java.lang.String par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Integer>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Integer.staticClass, global::java.lang.Integer._getInteger15, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/Integer;)Ljava/lang/Integer;")]
        public static global::java.lang.Integer getInteger(global::java.lang.String par0, global::java.lang.Integer par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Integer>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Integer.staticClass, global::java.lang.Integer._getInteger16, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)I")]
        public static int highestOneBit(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((int)(@__env.CallStaticIntMethod(global::java.lang.Integer.staticClass, global::java.lang.Integer._highestOneBit17, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)I")]
        public static int lowestOneBit(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((int)(@__env.CallStaticIntMethod(global::java.lang.Integer.staticClass, global::java.lang.Integer._lowestOneBit18, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)I")]
        public static int numberOfLeadingZeros(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((int)(@__env.CallStaticIntMethod(global::java.lang.Integer.staticClass, global::java.lang.Integer._numberOfLeadingZeros19, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)I")]
        public static int numberOfTrailingZeros(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((int)(@__env.CallStaticIntMethod(global::java.lang.Integer.staticClass, global::java.lang.Integer._numberOfTrailingZeros20, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(II)I")]
        public static int rotateLeft(int par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((int)(@__env.CallStaticIntMethod(global::java.lang.Integer.staticClass, global::java.lang.Integer._rotateLeft21, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(II)I")]
        public static int rotateRight(int par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((int)(@__env.CallStaticIntMethod(global::java.lang.Integer.staticClass, global::java.lang.Integer._rotateRight22, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)I")]
        public static int signum(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((int)(@__env.CallStaticIntMethod(global::java.lang.Integer.staticClass, global::java.lang.Integer._signum23, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Ljava/lang/String;")]
        public static global::java.lang.String toBinaryString(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Integer.staticClass, global::java.lang.Integer._toBinaryString24, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Ljava/lang/String;")]
        public static global::java.lang.String toOctalString(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Integer.staticClass, global::java.lang.Integer._toOctalString25, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.lang.Integer(@__env);
            }
        }
    }
    #endregion
}
