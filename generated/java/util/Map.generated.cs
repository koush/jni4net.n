//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.3074
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.util {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface Map {
        
        global::java.lang.Object get(global::java.lang.Object par0);
        
        global::java.lang.Object put(global::java.lang.Object par0, global::java.lang.Object par1);
        
        int hashCode();
        
        void clear();
        
        bool equals(global::java.lang.Object par0);
        
        bool isEmpty();
        
        global::java.util.Set entrySet();
        
        void putAll(global::java.util.Map par0);
        
        int size();
        
        global::java.util.Collection values();
        
        global::java.lang.Object remove(global::java.lang.Object par0);
        
        global::java.util.Set keySet();
        
        bool containsKey(global::java.lang.Object par0);
        
        bool containsValue(global::java.lang.Object par0);
    }
    #endregion
    
    #region Component Designer generated code 
    public unsafe partial class Map_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.util.@__Map.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute()]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::java.util.Map))]
    internal unsafe partial class @__Map : global::java.lang.Object, global::java.util.Map {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _get0;
        
        internal static global::net.sf.jni4net.jni.MethodId _put1;
        
        internal static global::net.sf.jni4net.jni.MethodId _hashCode2;
        
        internal static global::net.sf.jni4net.jni.MethodId _clear3;
        
        internal static global::net.sf.jni4net.jni.MethodId _equals4;
        
        internal static global::net.sf.jni4net.jni.MethodId _isEmpty5;
        
        internal static global::net.sf.jni4net.jni.MethodId _entrySet6;
        
        internal static global::net.sf.jni4net.jni.MethodId _putAll7;
        
        internal static global::net.sf.jni4net.jni.MethodId _size8;
        
        internal static global::net.sf.jni4net.jni.MethodId _values9;
        
        internal static global::net.sf.jni4net.jni.MethodId _remove10;
        
        internal static global::net.sf.jni4net.jni.MethodId _keySet11;
        
        internal static global::net.sf.jni4net.jni.MethodId _containsKey12;
        
        internal static global::net.sf.jni4net.jni.MethodId _containsValue13;
        
        protected @__Map(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::java.util.@__Map.staticClass = staticClass;
            global::java.util.@__Map._get0 = env.GetMethodID(global::java.util.@__Map.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
            global::java.util.@__Map._put1 = env.GetMethodID(global::java.util.@__Map.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
            global::java.util.@__Map._hashCode2 = env.GetMethodID(global::java.util.@__Map.staticClass, "hashCode", "()I");
            global::java.util.@__Map._clear3 = env.GetMethodID(global::java.util.@__Map.staticClass, "clear", "()V");
            global::java.util.@__Map._equals4 = env.GetMethodID(global::java.util.@__Map.staticClass, "equals", "(Ljava/lang/Object;)Z");
            global::java.util.@__Map._isEmpty5 = env.GetMethodID(global::java.util.@__Map.staticClass, "isEmpty", "()Z");
            global::java.util.@__Map._entrySet6 = env.GetMethodID(global::java.util.@__Map.staticClass, "entrySet", "()Ljava/util/Set;");
            global::java.util.@__Map._putAll7 = env.GetMethodID(global::java.util.@__Map.staticClass, "putAll", "(Ljava/util/Map;)V");
            global::java.util.@__Map._size8 = env.GetMethodID(global::java.util.@__Map.staticClass, "size", "()I");
            global::java.util.@__Map._values9 = env.GetMethodID(global::java.util.@__Map.staticClass, "values", "()Ljava/util/Collection;");
            global::java.util.@__Map._remove10 = env.GetMethodID(global::java.util.@__Map.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
            global::java.util.@__Map._keySet11 = env.GetMethodID(global::java.util.@__Map.staticClass, "keySet", "()Ljava/util/Set;");
            global::java.util.@__Map._containsKey12 = env.GetMethodID(global::java.util.@__Map.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
            global::java.util.@__Map._containsValue13 = env.GetMethodID(global::java.util.@__Map.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
        }
        
        public virtual global::java.lang.Object get(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Object>(env.CallObjectMethod(this, global::java.util.@__Map._get0, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        public virtual global::java.lang.Object put(global::java.lang.Object par0, global::java.lang.Object par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Object>(env.CallObjectMethod(this, global::java.util.@__Map._put1, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1)));
        }
        
        public virtual int hashCode() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::java.util.@__Map._hashCode2);
        }
        
        public virtual void clear() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::java.util.@__Map._clear3);
        }
        
        public virtual bool equals(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.util.@__Map._equals4, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        public virtual bool isEmpty() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.util.@__Map._isEmpty5);
        }
        
        public virtual global::java.util.Set entrySet() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.util.Set>(env.CallObjectMethod(this, global::java.util.@__Map._entrySet6));
        }
        
        public virtual void putAll(global::java.util.Map par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::java.util.@__Map._putAll7, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        public virtual int size() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::java.util.@__Map._size8);
        }
        
        public virtual global::java.util.Collection values() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.util.Collection>(env.CallObjectMethod(this, global::java.util.@__Map._values9));
        }
        
        public virtual global::java.lang.Object remove(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Object>(env.CallObjectMethod(this, global::java.util.@__Map._remove10, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        public virtual global::java.util.Set keySet() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.util.Set>(env.CallObjectMethod(this, global::java.util.@__Map._keySet11));
        }
        
        public virtual bool containsKey(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.util.@__Map._containsKey12, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        public virtual bool containsValue(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.util.@__Map._containsValue13, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__Map);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "get", "get0", "(Ljava/lang/Object;)Ljava/lang/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "put", "put1", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "hashCode", "hashCode2", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "clear", "clear3", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "equals", "equals4", "(Ljava/lang/Object;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "isEmpty", "isEmpty5", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "entrySet", "entrySet6", "()Ljava/util/Set;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "putAll", "putAll7", "(Ljava/util/Map;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "size", "size8", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "values", "values9", "()Ljava/util/Collection;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "remove", "remove10", "(Ljava/lang/Object;)Ljava/lang/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "keySet", "keySet11", "()Ljava/util/Set;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "containsKey", "containsKey12", "(Ljava/lang/Object;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "containsValue", "containsValue13", "(Ljava/lang/Object;)Z"));
            return methods;
        }
        
        private static global::java.lang.Object.JavaPtr* get0(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* par0) {
            // (Ljava/lang/Object;)Ljava/lang/Object;
            // (Ljava/lang/Object;)Ljava/lang/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.Map real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.Map>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.get(global::net.sf.jni4net.utils.JavaProxiesMap.Wrap<java.lang.Object>(__env, par0)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* put1(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* par0, global::java.lang.Object.JavaPtr* par1) {
            // (Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;
            // (Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.Map real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.Map>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.put(global::net.sf.jni4net.utils.JavaProxiesMap.Wrap<java.lang.Object>(__env, par0), global::net.sf.jni4net.utils.JavaProxiesMap.Wrap<java.lang.Object>(__env, par1)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static int hashCode2(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.Map real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.Map>(__env, @__obj);
            return real.hashCode();
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static void clear3(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.Map real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.Map>(__env, @__obj);
            real.clear();
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static bool equals4(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* par0) {
            // (Ljava/lang/Object;)Z
            // (Ljava/lang/Object;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.Map real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.Map>(__env, @__obj);
            return real.equals(global::net.sf.jni4net.utils.JavaProxiesMap.Wrap<java.lang.Object>(__env, par0));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool isEmpty5(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.Map real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.Map>(__env, @__obj);
            return real.isEmpty();
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static global::java.lang.Object.JavaPtr* entrySet6(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Ljava/util/Set;
            // ()Ljava/util/Set;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.Map real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.Map>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.entrySet());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static void putAll7(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* par0) {
            // (Ljava/util/Map;)V
            // (Ljava/util/Map;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.Map real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.Map>(__env, @__obj);
            real.putAll(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.Map>(__env, par0));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static int size8(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.Map real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.Map>(__env, @__obj);
            return real.size();
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static global::java.lang.Object.JavaPtr* values9(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Ljava/util/Collection;
            // ()Ljava/util/Collection;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.Map real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.Map>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.values());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* remove10(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* par0) {
            // (Ljava/lang/Object;)Ljava/lang/Object;
            // (Ljava/lang/Object;)Ljava/lang/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.Map real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.Map>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.remove(global::net.sf.jni4net.utils.JavaProxiesMap.Wrap<java.lang.Object>(__env, par0)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* keySet11(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Ljava/util/Set;
            // ()Ljava/util/Set;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.Map real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.Map>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.keySet());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static bool containsKey12(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* par0) {
            // (Ljava/lang/Object;)Z
            // (Ljava/lang/Object;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.Map real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.Map>(__env, @__obj);
            return real.containsKey(global::net.sf.jni4net.utils.JavaProxiesMap.Wrap<java.lang.Object>(__env, par0));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool containsValue13(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* par0) {
            // (Ljava/lang/Object;)Z
            // (Ljava/lang/Object;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.Map real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.Map>(__env, @__obj);
            return real.containsValue(global::net.sf.jni4net.utils.JavaProxiesMap.Wrap<java.lang.Object>(__env, par0));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::java.util.@__Map(env);
            }
        }
    }
    #endregion
}
