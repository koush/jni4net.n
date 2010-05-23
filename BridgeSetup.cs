using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Permissions;
using System.Text;

namespace net.sf.jni4net
{
    [Serializable]
    public class BridgeSetup
    {
        public bool Verbose { get; set; }
        public bool VeryVerbose { get; set; }
        public bool Debug { get; set; }

        public BridgeSetup()
        {
        }
    }
}
