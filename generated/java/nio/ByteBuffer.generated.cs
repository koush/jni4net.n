//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.nio {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class ByteBuffer : global::java.nio.Buffer, global::java.lang.Comparable {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _compareTo0;
        
        internal static global::net.sf.jni4net.jni.MethodId _compareTo1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getShort2;
        
        internal static global::net.sf.jni4net.jni.MethodId _getShort3;
        
        internal static global::net.sf.jni4net.jni.MethodId _getChar4;
        
        internal static global::net.sf.jni4net.jni.MethodId _getChar5;
        
        internal static global::net.sf.jni4net.jni.MethodId _getInt6;
        
        internal static global::net.sf.jni4net.jni.MethodId _getInt7;
        
        internal static global::net.sf.jni4net.jni.MethodId _getLong8;
        
        internal static global::net.sf.jni4net.jni.MethodId _getLong9;
        
        internal static global::net.sf.jni4net.jni.MethodId _getFloat10;
        
        internal static global::net.sf.jni4net.jni.MethodId _getFloat11;
        
        internal static global::net.sf.jni4net.jni.MethodId _getDouble12;
        
        internal static global::net.sf.jni4net.jni.MethodId _getDouble13;
        
        internal static global::net.sf.jni4net.jni.MethodId _putShort14;
        
        internal static global::net.sf.jni4net.jni.MethodId _putShort15;
        
        internal static global::net.sf.jni4net.jni.MethodId _putChar16;
        
        internal static global::net.sf.jni4net.jni.MethodId _putChar17;
        
        internal static global::net.sf.jni4net.jni.MethodId _putInt18;
        
        internal static global::net.sf.jni4net.jni.MethodId _putInt19;
        
        internal static global::net.sf.jni4net.jni.MethodId _putLong20;
        
        internal static global::net.sf.jni4net.jni.MethodId _putLong21;
        
        internal static global::net.sf.jni4net.jni.MethodId _putFloat22;
        
        internal static global::net.sf.jni4net.jni.MethodId _putFloat23;
        
        internal static global::net.sf.jni4net.jni.MethodId _putDouble24;
        
        internal static global::net.sf.jni4net.jni.MethodId _putDouble25;
        
        internal static global::net.sf.jni4net.jni.MethodId _put26;
        
        internal static global::net.sf.jni4net.jni.MethodId _put27;
        
        internal static global::net.sf.jni4net.jni.MethodId _put28;
        
        internal static global::net.sf.jni4net.jni.MethodId _put29;
        
        internal static global::net.sf.jni4net.jni.MethodId _put30;
        
        internal static global::net.sf.jni4net.jni.MethodId _get31;
        
        internal static global::net.sf.jni4net.jni.MethodId _get32;
        
        internal static global::net.sf.jni4net.jni.MethodId _get33;
        
        internal static global::net.sf.jni4net.jni.MethodId _get34;
        
        internal static global::net.sf.jni4net.jni.MethodId _array35;
        
        internal static global::net.sf.jni4net.jni.MethodId _arrayOffset36;
        
        internal static global::net.sf.jni4net.jni.MethodId _hasArray37;
        
        internal static global::net.sf.jni4net.jni.MethodId _isDirect38;
        
        internal static global::net.sf.jni4net.jni.MethodId _wrap39;
        
        internal static global::net.sf.jni4net.jni.MethodId _wrap40;
        
        internal static global::net.sf.jni4net.jni.MethodId _allocate41;
        
        internal static global::net.sf.jni4net.jni.MethodId _allocateDirect42;
        
        internal static global::net.sf.jni4net.jni.MethodId _asCharBuffer43;
        
        internal static global::net.sf.jni4net.jni.MethodId _asDoubleBuffer44;
        
        internal static global::net.sf.jni4net.jni.MethodId _asFloatBuffer45;
        
        internal static global::net.sf.jni4net.jni.MethodId _asIntBuffer46;
        
        internal static global::net.sf.jni4net.jni.MethodId _asLongBuffer47;
        
        internal static global::net.sf.jni4net.jni.MethodId _asReadOnlyBuffer48;
        
        internal static global::net.sf.jni4net.jni.MethodId _asShortBuffer49;
        
        internal static global::net.sf.jni4net.jni.MethodId _compact50;
        
        internal static global::net.sf.jni4net.jni.MethodId _duplicate51;
        
        internal static global::net.sf.jni4net.jni.MethodId _order52;
        
        internal static global::net.sf.jni4net.jni.MethodId _order53;
        
        internal static global::net.sf.jni4net.jni.MethodId _slice54;
        
        protected ByteBuffer(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.nio.ByteBuffer.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.nio.ByteBuffer.staticClass = @__class;
            global::java.nio.ByteBuffer._compareTo0 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
            global::java.nio.ByteBuffer._compareTo1 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "compareTo", "(Ljava/nio/ByteBuffer;)I");
            global::java.nio.ByteBuffer._getShort2 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "getShort", "()S");
            global::java.nio.ByteBuffer._getShort3 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "getShort", "(I)S");
            global::java.nio.ByteBuffer._getChar4 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "getChar", "()C");
            global::java.nio.ByteBuffer._getChar5 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "getChar", "(I)C");
            global::java.nio.ByteBuffer._getInt6 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "getInt", "(I)I");
            global::java.nio.ByteBuffer._getInt7 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "getInt", "()I");
            global::java.nio.ByteBuffer._getLong8 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "getLong", "()J");
            global::java.nio.ByteBuffer._getLong9 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "getLong", "(I)J");
            global::java.nio.ByteBuffer._getFloat10 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "getFloat", "()F");
            global::java.nio.ByteBuffer._getFloat11 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "getFloat", "(I)F");
            global::java.nio.ByteBuffer._getDouble12 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "getDouble", "(I)D");
            global::java.nio.ByteBuffer._getDouble13 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "getDouble", "()D");
            global::java.nio.ByteBuffer._putShort14 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "putShort", "(S)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._putShort15 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "putShort", "(IS)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._putChar16 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "putChar", "(IC)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._putChar17 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "putChar", "(C)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._putInt18 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "putInt", "(II)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._putInt19 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "putInt", "(I)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._putLong20 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "putLong", "(J)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._putLong21 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "putLong", "(IJ)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._putFloat22 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "putFloat", "(F)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._putFloat23 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "putFloat", "(IF)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._putDouble24 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "putDouble", "(ID)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._putDouble25 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "putDouble", "(D)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._put26 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "put", "([B)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._put27 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "put", "(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._put28 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "put", "(IB)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._put29 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "put", "([BII)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._put30 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "put", "(B)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._get31 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "get", "(I)B");
            global::java.nio.ByteBuffer._get32 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "get", "([B)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._get33 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "get", "()B");
            global::java.nio.ByteBuffer._get34 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "get", "([BII)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._array35 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "array", "()[B");
            global::java.nio.ByteBuffer._arrayOffset36 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "arrayOffset", "()I");
            global::java.nio.ByteBuffer._hasArray37 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "hasArray", "()Z");
            global::java.nio.ByteBuffer._isDirect38 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "isDirect", "()Z");
            global::java.nio.ByteBuffer._wrap39 = @__env.GetStaticMethodID(global::java.nio.ByteBuffer.staticClass, "wrap", "([B)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._wrap40 = @__env.GetStaticMethodID(global::java.nio.ByteBuffer.staticClass, "wrap", "([BII)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._allocate41 = @__env.GetStaticMethodID(global::java.nio.ByteBuffer.staticClass, "allocate", "(I)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._allocateDirect42 = @__env.GetStaticMethodID(global::java.nio.ByteBuffer.staticClass, "allocateDirect", "(I)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._asCharBuffer43 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "asCharBuffer", "()Ljava/nio/CharBuffer;");
            global::java.nio.ByteBuffer._asDoubleBuffer44 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "asDoubleBuffer", "()Ljava/nio/DoubleBuffer;");
            global::java.nio.ByteBuffer._asFloatBuffer45 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "asFloatBuffer", "()Ljava/nio/FloatBuffer;");
            global::java.nio.ByteBuffer._asIntBuffer46 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "asIntBuffer", "()Ljava/nio/IntBuffer;");
            global::java.nio.ByteBuffer._asLongBuffer47 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "asLongBuffer", "()Ljava/nio/LongBuffer;");
            global::java.nio.ByteBuffer._asReadOnlyBuffer48 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._asShortBuffer49 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "asShortBuffer", "()Ljava/nio/ShortBuffer;");
            global::java.nio.ByteBuffer._compact50 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "compact", "()Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._duplicate51 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "duplicate", "()Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._order52 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "order", "(Ljava/nio/ByteOrder;)Ljava/nio/ByteBuffer;");
            global::java.nio.ByteBuffer._order53 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;");
            global::java.nio.ByteBuffer._slice54 = @__env.GetMethodID(global::java.nio.ByteBuffer.staticClass, "slice", "()Ljava/nio/ByteBuffer;");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)I")]
        public virtual int compareTo(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::java.nio.ByteBuffer._compareTo0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/nio/ByteBuffer;)I")]
        public virtual int compareTo(global::java.nio.ByteBuffer par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::java.nio.ByteBuffer._compareTo1, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()S")]
        public virtual short getShort() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((short)(@__env.CallShortMethod(this, global::java.nio.ByteBuffer._getShort2)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)S")]
        public virtual short getShort(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((short)(@__env.CallShortMethod(this, global::java.nio.ByteBuffer._getShort3, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()C")]
        public virtual char getChar() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((char)(@__env.CallCharMethod(this, global::java.nio.ByteBuffer._getChar4)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)C")]
        public virtual char getChar(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((char)(@__env.CallCharMethod(this, global::java.nio.ByteBuffer._getChar5, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)I")]
        public virtual int getInt(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::java.nio.ByteBuffer._getInt6, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int getInt() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::java.nio.ByteBuffer._getInt7)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()J")]
        public virtual long getLong() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((long)(@__env.CallLongMethod(this, global::java.nio.ByteBuffer._getLong8)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)J")]
        public virtual long getLong(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((long)(@__env.CallLongMethod(this, global::java.nio.ByteBuffer._getLong9, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()F")]
        public virtual float getFloat() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((float)(@__env.CallFloatMethod(this, global::java.nio.ByteBuffer._getFloat10)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)F")]
        public virtual float getFloat(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((float)(@__env.CallFloatMethod(this, global::java.nio.ByteBuffer._getFloat11, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)D")]
        public virtual double getDouble(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((double)(@__env.CallDoubleMethod(this, global::java.nio.ByteBuffer._getDouble12, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()D")]
        public virtual double getDouble() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((double)(@__env.CallDoubleMethod(this, global::java.nio.ByteBuffer._getDouble13)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(S)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer putShort(short par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.ByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ByteBuffer._putShort14, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(IS)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer putShort(int par0, short par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.ByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ByteBuffer._putShort15, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(IC)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer putChar(int par0, char par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.ByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ByteBuffer._putChar16, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(C)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer putChar(char par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.ByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ByteBuffer._putChar17, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(II)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer putInt(int par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.ByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ByteBuffer._putInt18, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer putInt(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.ByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ByteBuffer._putInt19, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer putLong(long par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.ByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ByteBuffer._putLong20, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(IJ)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer putLong(int par0, long par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.ByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ByteBuffer._putLong21, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(F)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer putFloat(float par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.ByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ByteBuffer._putFloat22, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(IF)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer putFloat(int par0, float par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.ByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ByteBuffer._putFloat23, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(ID)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer putDouble(int par0, double par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.ByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ByteBuffer._putDouble24, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(D)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer putDouble(double par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.ByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ByteBuffer._putDouble25, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([B)Ljava/nio/ByteBuffer;")]
        public global::java.nio.ByteBuffer put(byte[] par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.ByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ByteBuffer._put26, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer put(global::java.nio.ByteBuffer par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.ByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ByteBuffer._put27, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(IB)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer put(int par0, byte par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.ByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ByteBuffer._put28, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([BII)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer put(byte[] par0, int par1, int par2) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.ByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ByteBuffer._put29, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par2)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(B)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer put(byte par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.ByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ByteBuffer._put30, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)B")]
        public virtual byte get(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((byte)(@__env.CallByteMethod(this, global::java.nio.ByteBuffer._get31, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([B)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer get(byte[] par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.ByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ByteBuffer._get32, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()B")]
        public virtual byte get() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((byte)(@__env.CallByteMethod(this, global::java.nio.ByteBuffer._get33)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([BII)Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer get(byte[] par0, int par1, int par2) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.ByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ByteBuffer._get34, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par2)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[B")]
        public byte[] array() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.ArrayPrimJ2Cbyte(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ByteBuffer._array35));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public int arrayOffset() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::java.nio.ByteBuffer._arrayOffset36)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public bool hasArray() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.nio.ByteBuffer._hasArray37)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isDirect() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.nio.ByteBuffer._isDirect38)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([B)Ljava/nio/ByteBuffer;")]
        public static global::java.nio.ByteBuffer wrap(byte[] par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.ByteBuffer>(@__env, @__env.CallStaticObjectMethodPtr(global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._wrap39, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([BII)Ljava/nio/ByteBuffer;")]
        public static global::java.nio.ByteBuffer wrap(byte[] par0, int par1, int par2) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.ByteBuffer>(@__env, @__env.CallStaticObjectMethodPtr(global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._wrap40, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par2)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Ljava/nio/ByteBuffer;")]
        public static global::java.nio.ByteBuffer allocate(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.ByteBuffer>(@__env, @__env.CallStaticObjectMethodPtr(global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._allocate41, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Ljava/nio/ByteBuffer;")]
        public static global::java.nio.ByteBuffer allocateDirect(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.ByteBuffer>(@__env, @__env.CallStaticObjectMethodPtr(global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._allocateDirect42, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/nio/CharBuffer;")]
        public virtual global::java.nio.Buffer asCharBuffer() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.Buffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ByteBuffer._asCharBuffer43));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/nio/DoubleBuffer;")]
        public virtual global::java.nio.Buffer asDoubleBuffer() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.Buffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ByteBuffer._asDoubleBuffer44));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/nio/FloatBuffer;")]
        public virtual global::java.nio.Buffer asFloatBuffer() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.Buffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ByteBuffer._asFloatBuffer45));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/nio/IntBuffer;")]
        public virtual global::java.nio.Buffer asIntBuffer() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.Buffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ByteBuffer._asIntBuffer46));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/nio/LongBuffer;")]
        public virtual global::java.nio.Buffer asLongBuffer() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.Buffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ByteBuffer._asLongBuffer47));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer asReadOnlyBuffer() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.ByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ByteBuffer._asReadOnlyBuffer48));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/nio/ShortBuffer;")]
        public virtual global::java.nio.Buffer asShortBuffer() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.Buffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ByteBuffer._asShortBuffer49));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer compact() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.ByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ByteBuffer._compact50));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer duplicate() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.ByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ByteBuffer._duplicate51));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/nio/ByteOrder;)Ljava/nio/ByteBuffer;")]
        public global::java.nio.ByteBuffer order(global::java.nio.ByteOrder par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.ByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ByteBuffer._order52, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/nio/ByteOrder;")]
        public global::java.nio.ByteOrder order() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.ByteOrder>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ByteBuffer._order53));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/nio/ByteBuffer;")]
        public virtual global::java.nio.ByteBuffer slice() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.ByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.ByteBuffer._slice54));
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.nio.ByteBuffer(@__env);
            }
        }
    }
    #endregion
}
