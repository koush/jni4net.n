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
    public partial class System : global::java.lang.Object {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _arraycopy0;
        
        internal static global::net.sf.jni4net.jni.MethodId _currentTimeMillis1;
        
        internal static global::net.sf.jni4net.jni.MethodId _nanoTime2;
        
        internal static global::net.sf.jni4net.jni.MethodId _identityHashCode3;
        
        internal static global::net.sf.jni4net.jni.MethodId _exit4;
        
        internal static global::net.sf.jni4net.jni.MethodId _runFinalizersOnExit5;
        
        internal static global::net.sf.jni4net.jni.MethodId _setProperty6;
        
        internal static global::net.sf.jni4net.jni.MethodId _getProperty7;
        
        internal static global::net.sf.jni4net.jni.MethodId _getProperty8;
        
        internal static global::net.sf.jni4net.jni.MethodId _getSecurityManager9;
        
        internal static global::net.sf.jni4net.jni.MethodId _load10;
        
        internal static global::net.sf.jni4net.jni.MethodId _loadLibrary11;
        
        internal static global::net.sf.jni4net.jni.MethodId _mapLibraryName12;
        
        internal static global::net.sf.jni4net.jni.MethodId _clearProperty13;
        
        internal static global::net.sf.jni4net.jni.MethodId _gc14;
        
        internal static global::net.sf.jni4net.jni.MethodId _getProperties15;
        
        internal static global::net.sf.jni4net.jni.MethodId _getenv16;
        
        internal static global::net.sf.jni4net.jni.MethodId _getenv17;
        
        internal static global::net.sf.jni4net.jni.MethodId _inheritedChannel18;
        
        internal static global::net.sf.jni4net.jni.MethodId _runFinalization19;
        
        internal static global::net.sf.jni4net.jni.MethodId _setErr20;
        
        internal static global::net.sf.jni4net.jni.MethodId _setIn21;
        
        internal static global::net.sf.jni4net.jni.MethodId _setOut22;
        
        internal static global::net.sf.jni4net.jni.MethodId _setProperties23;
        
        internal static global::net.sf.jni4net.jni.MethodId _setSecurityManager24;
        
        internal static global::net.sf.jni4net.jni.FieldId _in25;
        
        internal static global::net.sf.jni4net.jni.FieldId _out26;
        
        internal static global::net.sf.jni4net.jni.FieldId _err27;
        
        protected System(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.System.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Ljava/io/InputStream;")]
        public static global::java.io.InputStream @in {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return global::net.sf.jni4net.Bridge.ToCLR<global::java.io.InputStream>(env.GetStaticObjectField(global::java.lang.System.staticClass, global::java.lang.System._in25));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Ljava/io/PrintStream;")]
        public static global::java.io.PrintStream @out {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return global::net.sf.jni4net.Bridge.ToCLR<global::java.io.PrintStream>(env.GetStaticObjectField(global::java.lang.System.staticClass, global::java.lang.System._out26));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Ljava/io/PrintStream;")]
        public static global::java.io.PrintStream err {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return global::net.sf.jni4net.Bridge.ToCLR<global::java.io.PrintStream>(env.GetStaticObjectField(global::java.lang.System.staticClass, global::java.lang.System._err27));
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::java.lang.System.staticClass = staticClass;
            global::java.lang.System._arraycopy0 = env.GetStaticMethodID(global::java.lang.System.staticClass, "arraycopy", "(Ljava/lang/Object;ILjava/lang/Object;II)V");
            global::java.lang.System._currentTimeMillis1 = env.GetStaticMethodID(global::java.lang.System.staticClass, "currentTimeMillis", "()J");
            global::java.lang.System._nanoTime2 = env.GetStaticMethodID(global::java.lang.System.staticClass, "nanoTime", "()J");
            global::java.lang.System._identityHashCode3 = env.GetStaticMethodID(global::java.lang.System.staticClass, "identityHashCode", "(Ljava/lang/Object;)I");
            global::java.lang.System._exit4 = env.GetStaticMethodID(global::java.lang.System.staticClass, "exit", "(I)V");
            global::java.lang.System._runFinalizersOnExit5 = env.GetStaticMethodID(global::java.lang.System.staticClass, "runFinalizersOnExit", "(Z)V");
            global::java.lang.System._setProperty6 = env.GetStaticMethodID(global::java.lang.System.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
            global::java.lang.System._getProperty7 = env.GetStaticMethodID(global::java.lang.System.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/String;");
            global::java.lang.System._getProperty8 = env.GetStaticMethodID(global::java.lang.System.staticClass, "getProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
            global::java.lang.System._getSecurityManager9 = env.GetStaticMethodID(global::java.lang.System.staticClass, "getSecurityManager", "()Ljava/lang/SecurityManager;");
            global::java.lang.System._load10 = env.GetStaticMethodID(global::java.lang.System.staticClass, "load", "(Ljava/lang/String;)V");
            global::java.lang.System._loadLibrary11 = env.GetStaticMethodID(global::java.lang.System.staticClass, "loadLibrary", "(Ljava/lang/String;)V");
            global::java.lang.System._mapLibraryName12 = env.GetStaticMethodID(global::java.lang.System.staticClass, "mapLibraryName", "(Ljava/lang/String;)Ljava/lang/String;");
            global::java.lang.System._clearProperty13 = env.GetStaticMethodID(global::java.lang.System.staticClass, "clearProperty", "(Ljava/lang/String;)Ljava/lang/String;");
            global::java.lang.System._gc14 = env.GetStaticMethodID(global::java.lang.System.staticClass, "gc", "()V");
            global::java.lang.System._getProperties15 = env.GetStaticMethodID(global::java.lang.System.staticClass, "getProperties", "()Ljava/util/Properties;");
            global::java.lang.System._getenv16 = env.GetStaticMethodID(global::java.lang.System.staticClass, "getenv", "(Ljava/lang/String;)Ljava/lang/String;");
            global::java.lang.System._getenv17 = env.GetStaticMethodID(global::java.lang.System.staticClass, "getenv", "()Ljava/util/Map;");
            global::java.lang.System._inheritedChannel18 = env.GetStaticMethodID(global::java.lang.System.staticClass, "inheritedChannel", "()Ljava/nio/channels/Channel;");
            global::java.lang.System._runFinalization19 = env.GetStaticMethodID(global::java.lang.System.staticClass, "runFinalization", "()V");
            global::java.lang.System._setErr20 = env.GetStaticMethodID(global::java.lang.System.staticClass, "setErr", "(Ljava/io/PrintStream;)V");
            global::java.lang.System._setIn21 = env.GetStaticMethodID(global::java.lang.System.staticClass, "setIn", "(Ljava/io/InputStream;)V");
            global::java.lang.System._setOut22 = env.GetStaticMethodID(global::java.lang.System.staticClass, "setOut", "(Ljava/io/PrintStream;)V");
            global::java.lang.System._setProperties23 = env.GetStaticMethodID(global::java.lang.System.staticClass, "setProperties", "(Ljava/util/Properties;)V");
            global::java.lang.System._setSecurityManager24 = env.GetStaticMethodID(global::java.lang.System.staticClass, "setSecurityManager", "(Ljava/lang/SecurityManager;)V");
            global::java.lang.System._in25 = env.GetStaticFieldID(global::java.lang.System.staticClass, "in", "Ljava/io/InputStream;");
            global::java.lang.System._out26 = env.GetStaticFieldID(global::java.lang.System.staticClass, "out", "Ljava/io/PrintStream;");
            global::java.lang.System._err27 = env.GetStaticFieldID(global::java.lang.System.staticClass, "err", "Ljava/io/PrintStream;");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;ILjava/lang/Object;II)V")]
        public static void arraycopy(global::java.lang.Object par0, int par1, global::java.lang.Object par2, int par3, int par4) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            env.CallStaticVoidMethod(global::java.lang.System.staticClass, global::java.lang.System._arraycopy0, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1), new global::net.sf.jni4net.jni.Value(par2), new global::net.sf.jni4net.jni.Value(par3), new global::net.sf.jni4net.jni.Value(par4));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()J")]
        public static long currentTimeMillis() {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return env.CallStaticLongMethod(global::java.lang.System.staticClass, global::java.lang.System._currentTimeMillis1);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()J")]
        public static long nanoTime() {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return env.CallStaticLongMethod(global::java.lang.System.staticClass, global::java.lang.System._nanoTime2);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)I")]
        public static int identityHashCode(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return env.CallStaticIntMethod(global::java.lang.System.staticClass, global::java.lang.System._identityHashCode3, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)V")]
        public static void exit(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            env.CallStaticVoidMethod(global::java.lang.System.staticClass, global::java.lang.System._exit4, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Z)V")]
        public static void runFinalizersOnExit(bool par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            env.CallStaticVoidMethod(global::java.lang.System.staticClass, global::java.lang.System._runFinalizersOnExit5, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;")]
        public static global::java.lang.String setProperty(global::java.lang.String par0, global::java.lang.String par1) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallStaticObjectMethod(global::java.lang.System.staticClass, global::java.lang.System._setProperty6, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/String;")]
        public static global::java.lang.String getProperty(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallStaticObjectMethod(global::java.lang.System.staticClass, global::java.lang.System._getProperty7, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;")]
        public static global::java.lang.String getProperty(global::java.lang.String par0, global::java.lang.String par1) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallStaticObjectMethod(global::java.lang.System.staticClass, global::java.lang.System._getProperty8, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()LSystem/Object;")]
        public static object getSecurityManager() {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.Bridge.ToCLR<object>(env.CallStaticObjectMethod(global::java.lang.System.staticClass, global::java.lang.System._getSecurityManager9));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public static void load(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            env.CallStaticVoidMethod(global::java.lang.System.staticClass, global::java.lang.System._load10, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public static void loadLibrary(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            env.CallStaticVoidMethod(global::java.lang.System.staticClass, global::java.lang.System._loadLibrary11, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/String;")]
        public static global::java.lang.String mapLibraryName(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallStaticObjectMethod(global::java.lang.System.staticClass, global::java.lang.System._mapLibraryName12, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/String;")]
        public static global::java.lang.String clearProperty(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallStaticObjectMethod(global::java.lang.System.staticClass, global::java.lang.System._clearProperty13, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public static void gc() {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            env.CallStaticVoidMethod(global::java.lang.System.staticClass, global::java.lang.System._gc14);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/Properties;")]
        public static global::java.util.Properties getProperties() {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.util.Properties>(env.CallStaticObjectMethod(global::java.lang.System.staticClass, global::java.lang.System._getProperties15));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/String;")]
        public static global::java.lang.String getenv(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallStaticObjectMethod(global::java.lang.System.staticClass, global::java.lang.System._getenv16, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/Map;")]
        public static global::java.util.Map getenv() {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.util.Map>(env.CallStaticObjectMethod(global::java.lang.System.staticClass, global::java.lang.System._getenv17));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/io/Closeable;")]
        public static global::java.io.Closeable inheritedChannel() {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.io.Closeable>(env.CallStaticObjectMethod(global::java.lang.System.staticClass, global::java.lang.System._inheritedChannel18));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public static void runFinalization() {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            env.CallStaticVoidMethod(global::java.lang.System.staticClass, global::java.lang.System._runFinalization19);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/PrintStream;)V")]
        public static void setErr(global::java.io.PrintStream par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            env.CallStaticVoidMethod(global::java.lang.System.staticClass, global::java.lang.System._setErr20, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/InputStream;)V")]
        public static void setIn(global::java.io.InputStream par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            env.CallStaticVoidMethod(global::java.lang.System.staticClass, global::java.lang.System._setIn21, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/PrintStream;)V")]
        public static void setOut(global::java.io.PrintStream par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            env.CallStaticVoidMethod(global::java.lang.System.staticClass, global::java.lang.System._setOut22, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/util/Properties;)V")]
        public static void setProperties(global::java.util.Properties par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            env.CallStaticVoidMethod(global::java.lang.System.staticClass, global::java.lang.System._setProperties23, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(LSystem/Object;)V")]
        public static void setSecurityManager(object par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            env.CallStaticVoidMethod(global::java.lang.System.staticClass, global::java.lang.System._setSecurityManager24, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::java.lang.System(env);
            }
        }
    }
    #endregion
}
