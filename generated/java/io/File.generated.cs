//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.io {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class File : global::java.lang.Object, global::java.io.Serializable, global::java.lang.Comparable {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _compareTo0;
        
        internal static global::net.sf.jni4net.jni.MethodId _compareTo1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getName2;
        
        internal static global::net.sf.jni4net.jni.MethodId _length3;
        
        internal static global::net.sf.jni4net.jni.MethodId _getCanonicalPath4;
        
        internal static global::net.sf.jni4net.jni.MethodId _getParent5;
        
        internal static global::net.sf.jni4net.jni.MethodId _isAbsolute6;
        
        internal static global::net.sf.jni4net.jni.MethodId _setReadOnly7;
        
        internal static global::net.sf.jni4net.jni.MethodId _list8;
        
        internal static global::net.sf.jni4net.jni.MethodId _list9;
        
        internal static global::net.sf.jni4net.jni.MethodId _delete10;
        
        internal static global::net.sf.jni4net.jni.MethodId _getPath11;
        
        internal static global::net.sf.jni4net.jni.MethodId _canRead12;
        
        internal static global::net.sf.jni4net.jni.MethodId _canWrite13;
        
        internal static global::net.sf.jni4net.jni.MethodId _createNewFile14;
        
        internal static global::net.sf.jni4net.jni.MethodId _createTempFile15;
        
        internal static global::net.sf.jni4net.jni.MethodId _createTempFile16;
        
        internal static global::net.sf.jni4net.jni.MethodId _deleteOnExit17;
        
        internal static global::net.sf.jni4net.jni.MethodId _exists18;
        
        internal static global::net.sf.jni4net.jni.MethodId _getAbsoluteFile19;
        
        internal static global::net.sf.jni4net.jni.MethodId _getAbsolutePath20;
        
        internal static global::net.sf.jni4net.jni.MethodId _getCanonicalFile21;
        
        internal static global::net.sf.jni4net.jni.MethodId _getParentFile22;
        
        internal static global::net.sf.jni4net.jni.MethodId _isDirectory23;
        
        internal static global::net.sf.jni4net.jni.MethodId _isFile24;
        
        internal static global::net.sf.jni4net.jni.MethodId _isHidden25;
        
        internal static global::net.sf.jni4net.jni.MethodId _lastModified26;
        
        internal static global::net.sf.jni4net.jni.MethodId _listFiles27;
        
        internal static global::net.sf.jni4net.jni.MethodId _listFiles28;
        
        internal static global::net.sf.jni4net.jni.MethodId _listRoots29;
        
        internal static global::net.sf.jni4net.jni.MethodId _mkdir30;
        
        internal static global::net.sf.jni4net.jni.MethodId _mkdirs31;
        
        internal static global::net.sf.jni4net.jni.MethodId _renameTo32;
        
        internal static global::net.sf.jni4net.jni.MethodId _setLastModified33;
        
        internal static global::net.sf.jni4net.jni.MethodId _toURI34;
        
        internal static global::net.sf.jni4net.jni.MethodId _toURL35;
        
        internal static global::net.sf.jni4net.jni.FieldId _separatorChar36;
        
        internal static global::net.sf.jni4net.jni.FieldId _separator37;
        
        internal static global::net.sf.jni4net.jni.FieldId _pathSeparatorChar38;
        
        internal static global::net.sf.jni4net.jni.FieldId _pathSeparator39;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorFile40;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorFile41;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorFile42;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorFile43;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/File;Ljava/lang/String;)V")]
        public File(global::java.io.File par0, global::java.lang.String par1) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.io.File.staticClass, global::java.io.File.@__ctorFile40, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/net/URI;)V")]
        public File(global::java.lang.Object par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.io.File.staticClass, global::java.io.File.@__ctorFile41, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/String;)V")]
        public File(global::java.lang.String par0, global::java.lang.String par1) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.io.File.staticClass, global::java.io.File.@__ctorFile42, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public File(global::java.lang.String par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.io.File.staticClass, global::java.io.File.@__ctorFile43, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
        }
        
        protected File(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.io.File.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("C")]
        public static char separatorChar {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((char)(@__env.GetStaticCharField(global::java.io.File.staticClass, global::java.io.File._separatorChar36)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Ljava/lang/String;")]
        public static global::java.lang.String separator {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.GetStaticObjectFieldPtr(global::java.io.File.staticClass, global::java.io.File._separator37));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("C")]
        public static char pathSeparatorChar {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((char)(@__env.GetStaticCharField(global::java.io.File.staticClass, global::java.io.File._pathSeparatorChar38)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Ljava/lang/String;")]
        public static global::java.lang.String pathSeparator {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.GetStaticObjectFieldPtr(global::java.io.File.staticClass, global::java.io.File._pathSeparator39));
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.io.File.staticClass = @__class;
            global::java.io.File._compareTo0 = @__env.GetMethodID(global::java.io.File.staticClass, "compareTo", "(Ljava/lang/Object;)I");
            global::java.io.File._compareTo1 = @__env.GetMethodID(global::java.io.File.staticClass, "compareTo", "(Ljava/io/File;)I");
            global::java.io.File._getName2 = @__env.GetMethodID(global::java.io.File.staticClass, "getName", "()Ljava/lang/String;");
            global::java.io.File._length3 = @__env.GetMethodID(global::java.io.File.staticClass, "length", "()J");
            global::java.io.File._getCanonicalPath4 = @__env.GetMethodID(global::java.io.File.staticClass, "getCanonicalPath", "()Ljava/lang/String;");
            global::java.io.File._getParent5 = @__env.GetMethodID(global::java.io.File.staticClass, "getParent", "()Ljava/lang/String;");
            global::java.io.File._isAbsolute6 = @__env.GetMethodID(global::java.io.File.staticClass, "isAbsolute", "()Z");
            global::java.io.File._setReadOnly7 = @__env.GetMethodID(global::java.io.File.staticClass, "setReadOnly", "()Z");
            global::java.io.File._list8 = @__env.GetMethodID(global::java.io.File.staticClass, "list", "(Ljava/io/FilenameFilter;)[Ljava/lang/String;");
            global::java.io.File._list9 = @__env.GetMethodID(global::java.io.File.staticClass, "list", "()[Ljava/lang/String;");
            global::java.io.File._delete10 = @__env.GetMethodID(global::java.io.File.staticClass, "delete", "()Z");
            global::java.io.File._getPath11 = @__env.GetMethodID(global::java.io.File.staticClass, "getPath", "()Ljava/lang/String;");
            global::java.io.File._canRead12 = @__env.GetMethodID(global::java.io.File.staticClass, "canRead", "()Z");
            global::java.io.File._canWrite13 = @__env.GetMethodID(global::java.io.File.staticClass, "canWrite", "()Z");
            global::java.io.File._createNewFile14 = @__env.GetMethodID(global::java.io.File.staticClass, "createNewFile", "()Z");
            global::java.io.File._createTempFile15 = @__env.GetStaticMethodID(global::java.io.File.staticClass, "createTempFile", "(Ljava/lang/String;Ljava/lang/String;Ljava/io/File;)Ljava/io/File;");
            global::java.io.File._createTempFile16 = @__env.GetStaticMethodID(global::java.io.File.staticClass, "createTempFile", "(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;");
            global::java.io.File._deleteOnExit17 = @__env.GetMethodID(global::java.io.File.staticClass, "deleteOnExit", "()V");
            global::java.io.File._exists18 = @__env.GetMethodID(global::java.io.File.staticClass, "exists", "()Z");
            global::java.io.File._getAbsoluteFile19 = @__env.GetMethodID(global::java.io.File.staticClass, "getAbsoluteFile", "()Ljava/io/File;");
            global::java.io.File._getAbsolutePath20 = @__env.GetMethodID(global::java.io.File.staticClass, "getAbsolutePath", "()Ljava/lang/String;");
            global::java.io.File._getCanonicalFile21 = @__env.GetMethodID(global::java.io.File.staticClass, "getCanonicalFile", "()Ljava/io/File;");
            global::java.io.File._getParentFile22 = @__env.GetMethodID(global::java.io.File.staticClass, "getParentFile", "()Ljava/io/File;");
            global::java.io.File._isDirectory23 = @__env.GetMethodID(global::java.io.File.staticClass, "isDirectory", "()Z");
            global::java.io.File._isFile24 = @__env.GetMethodID(global::java.io.File.staticClass, "isFile", "()Z");
            global::java.io.File._isHidden25 = @__env.GetMethodID(global::java.io.File.staticClass, "isHidden", "()Z");
            global::java.io.File._lastModified26 = @__env.GetMethodID(global::java.io.File.staticClass, "lastModified", "()J");
            global::java.io.File._listFiles27 = @__env.GetMethodID(global::java.io.File.staticClass, "listFiles", "()[Ljava/io/File;");
            global::java.io.File._listFiles28 = @__env.GetMethodID(global::java.io.File.staticClass, "listFiles", "(Ljava/io/FilenameFilter;)[Ljava/io/File;");
            global::java.io.File._listRoots29 = @__env.GetStaticMethodID(global::java.io.File.staticClass, "listRoots", "()[Ljava/io/File;");
            global::java.io.File._mkdir30 = @__env.GetMethodID(global::java.io.File.staticClass, "mkdir", "()Z");
            global::java.io.File._mkdirs31 = @__env.GetMethodID(global::java.io.File.staticClass, "mkdirs", "()Z");
            global::java.io.File._renameTo32 = @__env.GetMethodID(global::java.io.File.staticClass, "renameTo", "(Ljava/io/File;)Z");
            global::java.io.File._setLastModified33 = @__env.GetMethodID(global::java.io.File.staticClass, "setLastModified", "(J)Z");
            global::java.io.File._toURI34 = @__env.GetMethodID(global::java.io.File.staticClass, "toURI", "()Ljava/net/URI;");
            global::java.io.File._toURL35 = @__env.GetMethodID(global::java.io.File.staticClass, "toURL", "()Ljava/net/URL;");
            global::java.io.File._separatorChar36 = @__env.GetStaticFieldID(global::java.io.File.staticClass, "separatorChar", "C");
            global::java.io.File._separator37 = @__env.GetStaticFieldID(global::java.io.File.staticClass, "separator", "Ljava/lang/String;");
            global::java.io.File._pathSeparatorChar38 = @__env.GetStaticFieldID(global::java.io.File.staticClass, "pathSeparatorChar", "C");
            global::java.io.File._pathSeparator39 = @__env.GetStaticFieldID(global::java.io.File.staticClass, "pathSeparator", "Ljava/lang/String;");
            global::java.io.File.@__ctorFile40 = @__env.GetMethodID(global::java.io.File.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
            global::java.io.File.@__ctorFile41 = @__env.GetMethodID(global::java.io.File.staticClass, "<init>", "(Ljava/net/URI;)V");
            global::java.io.File.@__ctorFile42 = @__env.GetMethodID(global::java.io.File.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
            global::java.io.File.@__ctorFile43 = @__env.GetMethodID(global::java.io.File.staticClass, "<init>", "(Ljava/lang/String;)V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)I")]
        public virtual int compareTo(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::java.io.File._compareTo0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/File;)I")]
        public virtual int compareTo(global::java.io.File par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::java.io.File._compareTo1, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getName() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.io.File._getName2));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()J")]
        public virtual long length() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((long)(@__env.CallLongMethod(this, global::java.io.File._length3)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getCanonicalPath() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.io.File._getCanonicalPath4));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getParent() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.io.File._getParent5));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isAbsolute() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.io.File._isAbsolute6)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool setReadOnly() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.io.File._setReadOnly7)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/FilenameFilter;)[Ljava/lang/String;")]
        public virtual java.lang.String[] list(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.ArrayStrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.io.File._list8, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/String;")]
        public virtual java.lang.String[] list() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.ArrayStrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.io.File._list9));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool delete() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.io.File._delete10)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getPath() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.io.File._getPath11));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool canRead() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.io.File._canRead12)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool canWrite() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.io.File._canWrite13)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool createNewFile() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.io.File._createNewFile14)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/io/File;)Ljava/io/File;")]
        public static global::java.io.File createTempFile(global::java.lang.String par0, global::java.lang.String par1, global::java.io.File par2) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.io.File>(@__env, @__env.CallStaticObjectMethodPtr(global::java.io.File.staticClass, global::java.io.File._createTempFile15, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par2)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;")]
        public static global::java.io.File createTempFile(global::java.lang.String par0, global::java.lang.String par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.io.File>(@__env, @__env.CallStaticObjectMethodPtr(global::java.io.File.staticClass, global::java.io.File._createTempFile16, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public virtual void deleteOnExit() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.io.File._deleteOnExit17);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool exists() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.io.File._exists18)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/io/File;")]
        public virtual global::java.io.File getAbsoluteFile() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.io.File>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.File._getAbsoluteFile19));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getAbsolutePath() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.io.File._getAbsolutePath20));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/io/File;")]
        public virtual global::java.io.File getCanonicalFile() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.io.File>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.File._getCanonicalFile21));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/io/File;")]
        public virtual global::java.io.File getParentFile() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.io.File>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.File._getParentFile22));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isDirectory() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.io.File._isDirectory23)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isFile() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.io.File._isFile24)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isHidden() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.io.File._isHidden25)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()J")]
        public virtual long lastModified() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((long)(@__env.CallLongMethod(this, global::java.io.File._lastModified26)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/io/File;")]
        public virtual java.io.File[] listFiles() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.ArrayStrongJ2Cp<java.io.File[], global::java.io.File>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.File._listFiles27));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/FilenameFilter;)[Ljava/io/File;")]
        public virtual java.io.File[] listFiles(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.ArrayStrongJ2Cp<java.io.File[], global::java.io.File>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.File._listFiles28, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/io/File;")]
        public static java.io.File[] listRoots() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.ArrayStrongJ2Cp<java.io.File[], global::java.io.File>(@__env, @__env.CallStaticObjectMethodPtr(global::java.io.File.staticClass, global::java.io.File._listRoots29));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool mkdir() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.io.File._mkdir30)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool mkdirs() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.io.File._mkdirs31)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/File;)Z")]
        public virtual bool renameTo(global::java.io.File par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.io.File._renameTo32, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)Z")]
        public virtual bool setLastModified(long par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.io.File._setLastModified33, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/net/URI;")]
        public virtual global::java.lang.Object toURI() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.File._toURI34));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/net/URL;")]
        public virtual global::java.net.URL toURL() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.net.URL>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.File._toURL35));
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.io.File(@__env);
            }
        }
    }
    #endregion
}
