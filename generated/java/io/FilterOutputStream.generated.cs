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
    public partial class FilterOutputStream : global::java.io.OutputStream {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorFilterOutputStream0;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/OutputStream;)V")]
        public FilterOutputStream(global::java.io.OutputStream par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.io.FilterOutputStream.staticClass, global::java.io.FilterOutputStream.@__ctorFilterOutputStream0, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
        }
        
        protected FilterOutputStream(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.io.FilterOutputStream.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.io.FilterOutputStream.staticClass = @__class;
            global::java.io.FilterOutputStream.@__ctorFilterOutputStream0 = @__env.GetMethodID(global::java.io.FilterOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.io.FilterOutputStream(@__env);
            }
        }
    }
    #endregion
}
