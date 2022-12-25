using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FortniteSharp.Structs
{
    public struct LaunchFortnite_Params
    {
        public string ValidPath;
        public string LaunchArguments;
        public bool UseShellExecute; //kinda useless but why not
    }
}
