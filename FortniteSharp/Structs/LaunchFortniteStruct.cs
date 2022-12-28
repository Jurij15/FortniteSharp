using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FortniteSharp.Structs
{
    /// <summary>
    /// Parameters for launching Fortnite
    /// </summary>
    public struct LaunchFortnite_Params
    {
        public string ValidPath; //a Valid path
        public string LaunchArguments; //arguments to use when launching (will be default if empty/null)
        public bool SuspendOnStart; //this is meant mostly for EAC and BE, will stop the process after it is started
    }
}
