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
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Security;
using System.Security.Permissions;
using java.lang;
using net.sf.jni4net.jni;
using net.sf.jni4net.utils;
using Exception=System.Exception;

namespace net.sf.jni4net
{
    public static partial class Bridge
    {
        private static readonly Dictionary<Assembly, object> knownAssemblies = new Dictionary<Assembly, object>();
        private static bool jvmLoaded;
        internal static bool clrLoaded;
        private static BridgeSetup setup;
        private static readonly string homeDir;
        private static readonly string homeDll;

        [FileIOPermission(SecurityAction.Assert, Unrestricted = true)]
        static Bridge()
        {
            homeDll = typeof(Bridge).Assembly.Location;
            homeDir = Path.GetDirectoryName(homeDll);
        }

        public static BridgeSetup Setup
        {
            get
            {
                return setup;
            }
        }

        public static IList<Assembly> KnownAssemblies
        {
            get
            {
                Assembly[] res=new Assembly[knownAssemblies.Count];
                knownAssemblies.Keys.CopyTo(res, 0);
                return res;
            }
        }
		
		public static void SetJVM(JavaVM jvm)
		{
			jvmLoaded = true;
			clrLoaded = true;
			setup = new BridgeSetup();
		}

        public static string GetVersion()
        {
            return typeof (Bridge).Assembly.GetName().Version.ToString();
        }

        [FileIOPermission(SecurityAction.Assert, Unrestricted = true)]
        public static void LoadAndRegisterAssemblyFrom(java.io.File assemblyFile)
        {
            string assemblyPath = new Uri(assemblyFile.getCanonicalFile().toURI().toString()).LocalPath;

            Assembly assembly;
            if (File.Exists(assemblyPath))
            {
                assembly = Assembly.LoadFrom(assemblyPath);
            }
            else
            {
                string current = Path.Combine(homeDir, assemblyPath);
                if (File.Exists(current))
                {
                    assembly = Assembly.LoadFrom(current);
                }
                else
                {
                    throw new FileNotFoundException(assemblyPath);
                }
            }
            RegisterAssembly(assembly);
        }

        [FileIOPermission(SecurityAction.Assert, Unrestricted = true)]
        public static void LoadAndRegisterAssemblyByName(string strongName)
        {
            Assembly assembly = Assembly.Load(strongName);
            RegisterAssembly(assembly);
        }

        [FileIOPermission(SecurityAction.Assert, Unrestricted = true)]
        public static void RegisterAssembly(Assembly assembly)
        {
            if (knownAssemblies.ContainsKey(assembly))
            {
                if (Setup.Verbose)
                {
                    Console.WriteLine("skipped " + assembly + " from " + assembly.Location);
                }
                return;
            }
            if (Setup.Verbose)
            {
                Console.WriteLine("loading " + assembly + " from " + assembly.Location);
            }
            knownAssemblies.Add(assembly, assembly);
            Registry.RegisterAssembly(assembly, true);

            if (Setup.Verbose)
            {
                Console.WriteLine("loaded " + assembly + " from " + assembly.Location);
            }
        }

        public static void SetSystemClassLoader(ClassLoader classLoader)
        {
            Registry.systemClassLoader = classLoader;
        }
    }
}