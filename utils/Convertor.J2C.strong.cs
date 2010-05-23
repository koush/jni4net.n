#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU Lesser General Public License as 
published by the Free Software Foundation, either version 3 
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

#endregion

using System;
using java.lang;
using net.sf.jni4net.jni;
using Object=java.lang.Object;
using String=java.lang.String;

namespace net.sf.jni4net.utils
{
    partial class Convertor
    {
        public static TRes StrongJ2Cp<TRes>(JNIEnv env, JniLocalHandle obj)
            where TRes : IJvmProxy
        {
            if (JniHandle.IsNull(obj))
            {
                return default(TRes);
            }
            Class clazz = env.GetObjectClass(obj);
            RegistryRecord record = Registry.GetJVMRecord(clazz);
            return (TRes) record.CreateCLRProxy(env, obj);
        }

        public static object StrongJ2CpUntyped(IntPtr ptr)
        {
            JNIEnv env = JNIEnv.ThreadEnv;
            JniLocalHandle obj = ptr;
            if (JniHandle.IsNull(obj))
            {
                return null;
            }
            Class clazz = env.GetObjectClass(obj);
            RegistryRecord record = Registry.GetJVMRecord(clazz);
            return record.CreateCLRProxy(env, obj);
        }
        
        private class ConstructerHelper<T>
        {
            static System.Reflection.ConstructorInfo constructor;
            static ConstructerHelper()
            {
                constructor = typeof(T).GetConstructor(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.CreateInstance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic, null, new Type[] { typeof(JNIEnv) }, null);
            }
            
            public static T Create(JNIEnv env)
            {
                return (T)constructor.Invoke(new object[] { env });
            }
        }

        public static TRes StrongJ2CpTyped<TRes>(IntPtr ptr)
        {
            var env = JNIEnv.ThreadEnv;
            var ret = ConstructerHelper<TRes>.Create(env);
            (ret as IJvmProxy).Init(env, ptr);
            return ret;
        }

        #region Well known

        public static string StrongJ2CString(JNIEnv env, JniLocalHandle obj)
        {
            if (JniHandle.IsNull(obj))
            {
                return null;
            }
            string res = env.ConvertToString(obj);
            return res;
        }

        public static String StrongJ2CpString(JNIEnv env, JniLocalHandle obj)
        {
            if (JniHandle.IsNull(obj))
            {
                return null;
            }
            return String.CreateProxy(env, obj);
        }

        public static Class StrongJ2CpClass(JNIEnv env, JniLocalHandle obj)
        {
            if (JniHandle.IsNull(obj))
            {
                return null;
            }
            return Class.CreateProxy(env, obj);
        }

        public static Object StrongJ2CpObject(JNIEnv env, JniLocalHandle obj)
        {
            var res = new Object(env);
            ((IJvmProxy) res).Init(env, obj);
            return res;
        }

        #endregion
    }
}