//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.util {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class Dictionary : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _put0;
        
        internal static global::net.sf.jni4net.jni.MethodId _get1;
        
        internal static global::net.sf.jni4net.jni.MethodId _size2;
        
        internal static global::net.sf.jni4net.jni.MethodId _remove3;
        
        internal static global::net.sf.jni4net.jni.MethodId _elements4;
        
        internal static global::net.sf.jni4net.jni.MethodId _keys5;
        
        internal static global::net.sf.jni4net.jni.MethodId _isEmpty6;
        
        protected Dictionary(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.util.Dictionary.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.util.Dictionary.staticClass = @__class;
            global::java.util.Dictionary._put0 = @__env.GetMethodID(global::java.util.Dictionary.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
            global::java.util.Dictionary._get1 = @__env.GetMethodID(global::java.util.Dictionary.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
            global::java.util.Dictionary._size2 = @__env.GetMethodID(global::java.util.Dictionary.staticClass, "size", "()I");
            global::java.util.Dictionary._remove3 = @__env.GetMethodID(global::java.util.Dictionary.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
            global::java.util.Dictionary._elements4 = @__env.GetMethodID(global::java.util.Dictionary.staticClass, "elements", "()Ljava/util/Enumeration;");
            global::java.util.Dictionary._keys5 = @__env.GetMethodID(global::java.util.Dictionary.staticClass, "keys", "()Ljava/util/Enumeration;");
            global::java.util.Dictionary._isEmpty6 = @__env.GetMethodID(global::java.util.Dictionary.staticClass, "isEmpty", "()Z");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;")]
        public virtual global::java.lang.Object put(global::java.lang.Object par0, global::java.lang.Object par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Dictionary._put0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Ljava/lang/Object;")]
        public virtual global::java.lang.Object get(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Dictionary._get1, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int size() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::java.util.Dictionary._size2)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Ljava/lang/Object;")]
        public virtual global::java.lang.Object remove(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Dictionary._remove3, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/Enumeration;")]
        public virtual global::java.util.Enumeration elements() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Enumeration>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Dictionary._elements4));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/Enumeration;")]
        public virtual global::java.util.Enumeration keys() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Enumeration>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Dictionary._keys5));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isEmpty() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.util.Dictionary._isEmpty6)));
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.util.Dictionary(@__env);
            }
        }
    }
    #endregion
}
