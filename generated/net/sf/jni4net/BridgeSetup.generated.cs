//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace net.sf.jni4net {
    
    
    #region Component Designer generated code 
    public partial class BridgeSetup_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::net.sf.jni4net.@__BridgeSetup.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::net.sf.jni4net.BridgeSetup))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::net.sf.jni4net.BridgeSetup))]
    internal sealed partial class @__BridgeSetup : global::java.lang.Object {
        
        internal static global::java.lang.Class staticClass;
        
        protected @__BridgeSetup(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::net.sf.jni4net.@__BridgeSetup.staticClass = @__class;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__BridgeSetup);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getBindCLRTypes", "BindCLRTypes0", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "setBindCLRTypes", "BindCLRTypes1", "(Z)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getVerbose", "Verbose2", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "setVerbose", "Verbose3", "(Z)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getVeryVerbose", "VeryVerbose4", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "setVeryVerbose", "VeryVerbose5", "(Z)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getDebug", "Debug6", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "setDebug", "Debug7", "(Z)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getBindNative", "BindNative8", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "setBindNative", "BindNative9", "(Z)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getBindCoreOnly", "BindCoreOnly10", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "setBindCoreOnly", "BindCoreOnly11", "(Z)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getBindStatic", "BindStatic12", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "setBindStatic", "BindStatic13", "(Z)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getJVMOptions", "JVMOptions14", "()[Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getJVMCLassPath", "JVMCLassPath15", "()[Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "AddBridgeClassPath", "AddBridgeClassPath16", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "AddClassPath", "AddClassPath17", "(Ljava/lang/String;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "AddJVMOption", "AddJVMOption18", "(Ljava/lang/String;Ljava/lang/String;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "AddAllJarsClassPath", "AddAllJarsClassPath19", "(Ljava/lang/String;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorBridgeSetup0", "__ctorBridgeSetup0", "(Lnet/sf/jni4net/inj/IClrProxy;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorBridgeSetup1", "__ctorBridgeSetup1", "(Lnet/sf/jni4net/inj/IClrProxy;Z)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorBridgeSetup2", "__ctorBridgeSetup2", "(Lnet/sf/jni4net/inj/IClrProxy;[Ljava/lang/String;)V"));
            return methods;
        }
        
        private static bool BindCLRTypes0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.BridgeSetup @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.BridgeSetup>(@__env, @__obj);
            return ((bool)(@__real.BindCLRTypes));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(bool);
        }
        
        private static void BindCLRTypes1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, bool value) {
            // (Z)V
            // (Z)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.BridgeSetup @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.BridgeSetup>(@__env, @__obj);
            @__real.BindCLRTypes = value;
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static bool Verbose2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.BridgeSetup @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.BridgeSetup>(@__env, @__obj);
            return ((bool)(@__real.Verbose));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(bool);
        }
        
        private static void Verbose3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, bool value) {
            // (Z)V
            // (Z)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.BridgeSetup @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.BridgeSetup>(@__env, @__obj);
            @__real.Verbose = value;
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static bool VeryVerbose4(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.BridgeSetup @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.BridgeSetup>(@__env, @__obj);
            return ((bool)(@__real.VeryVerbose));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(bool);
        }
        
        private static void VeryVerbose5(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, bool value) {
            // (Z)V
            // (Z)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.BridgeSetup @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.BridgeSetup>(@__env, @__obj);
            @__real.VeryVerbose = value;
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static bool Debug6(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.BridgeSetup @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.BridgeSetup>(@__env, @__obj);
            return ((bool)(@__real.Debug));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(bool);
        }
        
        private static void Debug7(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, bool value) {
            // (Z)V
            // (Z)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.BridgeSetup @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.BridgeSetup>(@__env, @__obj);
            @__real.Debug = value;
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static bool BindNative8(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.BridgeSetup @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.BridgeSetup>(@__env, @__obj);
            return ((bool)(@__real.BindNative));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(bool);
        }
        
        private static void BindNative9(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, bool value) {
            // (Z)V
            // (Z)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.BridgeSetup @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.BridgeSetup>(@__env, @__obj);
            @__real.BindNative = value;
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static bool BindCoreOnly10(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.BridgeSetup @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.BridgeSetup>(@__env, @__obj);
            return ((bool)(@__real.BindCoreOnly));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(bool);
        }
        
        private static void BindCoreOnly11(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, bool value) {
            // (Z)V
            // (Z)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.BridgeSetup @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.BridgeSetup>(@__env, @__obj);
            @__real.BindCoreOnly = value;
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static bool BindStatic12(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.BridgeSetup @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.BridgeSetup>(@__env, @__obj);
            return ((bool)(@__real.BindStatic));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(bool);
        }
        
        private static void BindStatic13(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, bool value) {
            // (Z)V
            // (Z)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.BridgeSetup @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.BridgeSetup>(@__env, @__obj);
            @__real.BindStatic = value;
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::net.sf.jni4net.utils.JniHandle JVMOptions14(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()[Ljava/lang/String;
            // ()[LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.BridgeSetup @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.BridgeSetup>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.ArrayStrongC2JString(@__env, @__real.JVMOptions);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(global::net.sf.jni4net.utils.JniHandle);
        }
        
        private static global::net.sf.jni4net.utils.JniHandle JVMCLassPath15(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()[Ljava/lang/String;
            // ()[LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.BridgeSetup @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.BridgeSetup>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.ArrayStrongC2JString(@__env, @__real.JVMCLassPath);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(global::net.sf.jni4net.utils.JniHandle);
        }
        
        private static void AddBridgeClassPath16(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.BridgeSetup @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.BridgeSetup>(@__env, @__obj);
            @__real.AddBridgeClassPath();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void AddClassPath17(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle jarOrClassRoot) {
            // (Ljava/lang/String;)V
            // (LSystem/String;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.BridgeSetup @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.BridgeSetup>(@__env, @__obj);
            @__real.AddClassPath(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, jarOrClassRoot));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void AddJVMOption18(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle name, global::net.sf.jni4net.utils.JniLocalHandle value) {
            // (Ljava/lang/String;Ljava/lang/String;)V
            // (LSystem/String;LSystem/String;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.BridgeSetup @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.BridgeSetup>(@__env, @__obj);
            @__real.AddJVMOption(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, name), global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, value));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void AddAllJarsClassPath19(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle directory) {
            // (Ljava/lang/String;)V
            // (LSystem/String;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.BridgeSetup @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.BridgeSetup>(@__env, @__obj);
            @__real.AddAllJarsClassPath(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, directory));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void @__ctorBridgeSetup0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.BridgeSetup @__real = new global::net.sf.jni4net.BridgeSetup();
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void @__ctorBridgeSetup1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj, bool autoAddBridgeClassPath) {
            // (Z)V
            // (Z)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.BridgeSetup @__real = new global::net.sf.jni4net.BridgeSetup(autoAddBridgeClassPath);
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void @__ctorBridgeSetup2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle jvmOptions) {
            // ([Ljava/lang/String;)V
            // ([LSystem/String;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.BridgeSetup @__real = new global::net.sf.jni4net.BridgeSetup(global::net.sf.jni4net.utils.Convertor.ArrayStrongJ2CString(@__env, jvmOptions));
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::net.sf.jni4net.@__BridgeSetup(@__env);
            }
        }
    }
    #endregion
}
