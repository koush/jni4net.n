//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Collections {
    
    
    #region Component Designer generated code 
    public partial class IDictionary_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.Collections.@__IDictionary.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.Collections.IDictionary))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.Collections.IDictionary))]
    internal sealed partial class @__IDictionary : global::java.lang.Object, global::System.Collections.IDictionary {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _CopyTo0;
        
        internal static global::net.sf.jni4net.jni.MethodId _Count1;
        
        internal static global::net.sf.jni4net.jni.MethodId _SyncRoot2;
        
        internal static global::net.sf.jni4net.jni.MethodId _IsSynchronized3;
        
        internal static global::net.sf.jni4net.jni.MethodId _Item4;
        
        internal static global::net.sf.jni4net.jni.MethodId _Item5;
        
        internal static global::net.sf.jni4net.jni.MethodId _Keys6;
        
        internal static global::net.sf.jni4net.jni.MethodId _Values7;
        
        internal static global::net.sf.jni4net.jni.MethodId _Contains8;
        
        internal static global::net.sf.jni4net.jni.MethodId _Add9;
        
        internal static global::net.sf.jni4net.jni.MethodId _Clear10;
        
        internal static global::net.sf.jni4net.jni.MethodId _IsReadOnly11;
        
        internal static global::net.sf.jni4net.jni.MethodId _IsFixedSize12;
        
        internal static global::net.sf.jni4net.jni.MethodId _Remove13;
        
        internal static global::net.sf.jni4net.jni.MethodId _GetEnumerator14;
        
        internal static global::net.sf.jni4net.jni.MethodId _GetEnumerator15;
        
        protected @__IDictionary(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        public int Count {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = this.Env;
                return env.CallIntMethod(this, global::System.Collections.@__IDictionary._Count1);
            }
        }
        
        public object SyncRoot {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = this.Env;
                return global::net.sf.jni4net.utils.Convertor.J2C<object>(env, env.CallObjectMethodPtr(this, global::System.Collections.@__IDictionary._SyncRoot2));
            }
        }
        
        public bool IsSynchronized {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = this.Env;
                return env.CallBooleanMethod(this, global::System.Collections.@__IDictionary._IsSynchronized3);
            }
        }
        
        public object this[object key] {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = this.Env;
                return global::net.sf.jni4net.utils.Convertor.J2C<object>(env, env.CallObjectMethodPtr(this, global::System.Collections.@__IDictionary._Item4, global::net.sf.jni4net.utils.Convertor.ParamC2J(env, key)));
            }
            set {
                global::net.sf.jni4net.jni.JNIEnv env = this.Env;
                env.CallVoidMethod(this, global::System.Collections.@__IDictionary._Item5, global::net.sf.jni4net.utils.Convertor.ParamC2J(env, key), global::net.sf.jni4net.utils.Convertor.ParamC2J(env, value));
            }
        }
        
        public global::System.Collections.ICollection Keys {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = this.Env;
                return global::net.sf.jni4net.utils.Convertor.J2C<global::System.Collections.ICollection>(env, env.CallObjectMethodPtr(this, global::System.Collections.@__IDictionary._Keys6));
            }
        }
        
        public global::System.Collections.ICollection Values {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = this.Env;
                return global::net.sf.jni4net.utils.Convertor.J2C<global::System.Collections.ICollection>(env, env.CallObjectMethodPtr(this, global::System.Collections.@__IDictionary._Values7));
            }
        }
        
        public bool IsReadOnly {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = this.Env;
                return env.CallBooleanMethod(this, global::System.Collections.@__IDictionary._IsReadOnly11);
            }
        }
        
        public bool IsFixedSize {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = this.Env;
                return env.CallBooleanMethod(this, global::System.Collections.@__IDictionary._IsFixedSize12);
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::System.Collections.@__IDictionary.staticClass = staticClass;
            global::System.Collections.@__IDictionary._CopyTo0 = env.GetMethodID(global::System.Collections.@__IDictionary.staticClass, "CopyTo", "(Lsystem/Array;I)V");
            global::System.Collections.@__IDictionary._Count1 = env.GetMethodID(global::System.Collections.@__IDictionary.staticClass, "getCount", "()I");
            global::System.Collections.@__IDictionary._SyncRoot2 = env.GetMethodID(global::System.Collections.@__IDictionary.staticClass, "getSyncRoot", "()Lsystem/Object;");
            global::System.Collections.@__IDictionary._IsSynchronized3 = env.GetMethodID(global::System.Collections.@__IDictionary.staticClass, "isSynchronized", "()Z");
            global::System.Collections.@__IDictionary._Item4 = env.GetMethodID(global::System.Collections.@__IDictionary.staticClass, "getItem", "(Lsystem/Object;)Lsystem/Object;");
            global::System.Collections.@__IDictionary._Item5 = env.GetMethodID(global::System.Collections.@__IDictionary.staticClass, "setItem", "(Lsystem/Object;Lsystem/Object;)V");
            global::System.Collections.@__IDictionary._Keys6 = env.GetMethodID(global::System.Collections.@__IDictionary.staticClass, "getKeys", "()Lsystem/collections/ICollection;");
            global::System.Collections.@__IDictionary._Values7 = env.GetMethodID(global::System.Collections.@__IDictionary.staticClass, "getValues", "()Lsystem/collections/ICollection;");
            global::System.Collections.@__IDictionary._Contains8 = env.GetMethodID(global::System.Collections.@__IDictionary.staticClass, "Contains", "(Lsystem/Object;)Z");
            global::System.Collections.@__IDictionary._Add9 = env.GetMethodID(global::System.Collections.@__IDictionary.staticClass, "Add", "(Lsystem/Object;Lsystem/Object;)V");
            global::System.Collections.@__IDictionary._Clear10 = env.GetMethodID(global::System.Collections.@__IDictionary.staticClass, "Clear", "()V");
            global::System.Collections.@__IDictionary._IsReadOnly11 = env.GetMethodID(global::System.Collections.@__IDictionary.staticClass, "isReadOnly", "()Z");
            global::System.Collections.@__IDictionary._IsFixedSize12 = env.GetMethodID(global::System.Collections.@__IDictionary.staticClass, "isFixedSize", "()Z");
            global::System.Collections.@__IDictionary._Remove13 = env.GetMethodID(global::System.Collections.@__IDictionary.staticClass, "Remove", "(Lsystem/Object;)V");
            global::System.Collections.@__IDictionary._GetEnumerator14 = env.GetMethodID(global::System.Collections.@__IDictionary.staticClass, "GetEnumerator", "()Lsystem/collections/IDictionaryEnumerator;");
            global::System.Collections.@__IDictionary._GetEnumerator15 = env.GetMethodID(global::System.Collections.@__IDictionary.staticClass, "IEnumerable_GetEnumerator", "()Lsystem/collections/IEnumerator;");
        }
        
        public void CopyTo(global::System.Array array, int index) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::System.Collections.@__IDictionary._CopyTo0, global::net.sf.jni4net.utils.Convertor.ParamC2J(env, array), global::net.sf.jni4net.utils.Convertor.ParamC2J(env, index));
        }
        
        public bool Contains(object key) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::System.Collections.@__IDictionary._Contains8, global::net.sf.jni4net.utils.Convertor.ParamC2J(env, key));
        }
        
        public void Add(object key, object value) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::System.Collections.@__IDictionary._Add9, global::net.sf.jni4net.utils.Convertor.ParamC2J(env, key), global::net.sf.jni4net.utils.Convertor.ParamC2J(env, value));
        }
        
        public void Clear() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::System.Collections.@__IDictionary._Clear10);
        }
        
        public void Remove(object key) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::System.Collections.@__IDictionary._Remove13, global::net.sf.jni4net.utils.Convertor.ParamC2J(env, key));
        }
        
        public global::System.Collections.IDictionaryEnumerator GetEnumerator() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<global::System.Collections.IDictionaryEnumerator>(env, env.CallObjectMethodPtr(this, global::System.Collections.@__IDictionary._GetEnumerator14));
        }
        
        global::System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<global::System.Collections.IEnumerator>(env, env.CallObjectMethodPtr(this, global::System.Collections.@__IDictionary._GetEnumerator15));
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__IDictionary);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "CopyTo", "CopyTo0", "(Lsystem/Array;I)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getCount", "Count1", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getSyncRoot", "SyncRoot2", "()Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "isSynchronized", "IsSynchronized3", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getItem", "Item4", "(Lsystem/Object;)Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "setItem", "Item5", "(Lsystem/Object;Lsystem/Object;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getKeys", "Keys6", "()Lsystem/collections/ICollection;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getValues", "Values7", "()Lsystem/collections/ICollection;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "Contains", "Contains8", "(Lsystem/Object;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "Add", "Add9", "(Lsystem/Object;Lsystem/Object;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "Clear", "Clear10", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "isReadOnly", "IsReadOnly11", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "isFixedSize", "IsFixedSize12", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "Remove", "Remove13", "(Lsystem/Object;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "GetEnumerator", "GetEnumerator14", "()Lsystem/collections/IDictionaryEnumerator;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "IEnumerable_GetEnumerator", "GetEnumerator15", "()Lsystem/collections/IEnumerator;"));
            return methods;
        }
        
        private static void CopyTo0(global::System.IntPtr @__envi, global::System.IntPtr @__obj, global::System.IntPtr array, int index) {
            // (Lsystem/Array;I)V
            // (LSystem/Array;I)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Collections.IDictionary real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Collections.IDictionary>(__env, @__obj);
            ((global::System.Collections.ICollection)(real)).CopyTo(global::net.sf.jni4net.utils.Convertor.J2C<global::System.Array>(__env, array), index);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static int Count1(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Collections.IDictionary real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Collections.IDictionary>(__env, @__obj);
            return ((global::System.Collections.ICollection)(real)).Count;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static global::System.IntPtr SyncRoot2(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Lsystem/Object;
            // ()LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Collections.IDictionary real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Collections.IDictionary>(__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J(@__env, ((global::System.Collections.ICollection)(real)).SyncRoot);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static bool IsSynchronized3(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Collections.IDictionary real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Collections.IDictionary>(__env, @__obj);
            return ((global::System.Collections.ICollection)(real)).IsSynchronized;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static global::System.IntPtr Item4(global::System.IntPtr @__envi, global::System.IntPtr @__obj, global::System.IntPtr key) {
            // (Lsystem/Object;)Lsystem/Object;
            // (LSystem/Object;)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Collections.IDictionary real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Collections.IDictionary>(__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J(@__env, real[global::net.sf.jni4net.utils.Convertor.J2C<global::System.Object>(__env, key)]);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static void Item5(global::System.IntPtr @__envi, global::System.IntPtr @__obj, global::System.IntPtr key, global::System.IntPtr value) {
            // (Lsystem/Object;Lsystem/Object;)V
            // (LSystem/Object;LSystem/Object;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Collections.IDictionary real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Collections.IDictionary>(__env, @__obj);
            real[global::net.sf.jni4net.utils.Convertor.J2C<global::System.Object>(__env, key)] = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Object>(__env, value);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static global::System.IntPtr Keys6(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Lsystem/collections/ICollection;
            // ()LSystem/Collections/ICollection;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Collections.IDictionary real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Collections.IDictionary>(__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J(@__env, real.Keys);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr Values7(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Lsystem/collections/ICollection;
            // ()LSystem/Collections/ICollection;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Collections.IDictionary real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Collections.IDictionary>(__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J(@__env, real.Values);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static bool Contains8(global::System.IntPtr @__envi, global::System.IntPtr @__obj, global::System.IntPtr key) {
            // (Lsystem/Object;)Z
            // (LSystem/Object;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Collections.IDictionary real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Collections.IDictionary>(__env, @__obj);
            return real.Contains(global::net.sf.jni4net.utils.Convertor.J2C<global::System.Object>(__env, key));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static void Add9(global::System.IntPtr @__envi, global::System.IntPtr @__obj, global::System.IntPtr key, global::System.IntPtr value) {
            // (Lsystem/Object;Lsystem/Object;)V
            // (LSystem/Object;LSystem/Object;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Collections.IDictionary real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Collections.IDictionary>(__env, @__obj);
            real.Add(global::net.sf.jni4net.utils.Convertor.J2C<global::System.Object>(__env, key), global::net.sf.jni4net.utils.Convertor.J2C<global::System.Object>(__env, value));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static void Clear10(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Collections.IDictionary real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Collections.IDictionary>(__env, @__obj);
            real.Clear();
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static bool IsReadOnly11(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Collections.IDictionary real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Collections.IDictionary>(__env, @__obj);
            return real.IsReadOnly;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool IsFixedSize12(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Collections.IDictionary real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Collections.IDictionary>(__env, @__obj);
            return real.IsFixedSize;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static void Remove13(global::System.IntPtr @__envi, global::System.IntPtr @__obj, global::System.IntPtr key) {
            // (Lsystem/Object;)V
            // (LSystem/Object;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Collections.IDictionary real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Collections.IDictionary>(__env, @__obj);
            real.Remove(global::net.sf.jni4net.utils.Convertor.J2C<global::System.Object>(__env, key));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static global::System.IntPtr GetEnumerator14(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Lsystem/collections/IDictionaryEnumerator;
            // ()LSystem/Collections/IDictionaryEnumerator;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Collections.IDictionary real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Collections.IDictionary>(__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J(@__env, real.GetEnumerator());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr GetEnumerator15(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Lsystem/collections/IEnumerator;
            // ()LSystem/Collections/IEnumerator;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Collections.IDictionary real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Collections.IDictionary>(__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J(@__env, ((global::System.Collections.IEnumerable)(real)).GetEnumerator());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::System.Collections.@__IDictionary(env);
            }
        }
    }
    #endregion
}
