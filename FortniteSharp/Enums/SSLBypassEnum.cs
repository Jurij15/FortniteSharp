using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortniteSharp.Enums
{
    /// <summary>
    /// Mode the bypasser will use to bypass SSL
    /// </summary>
    public enum SSLByapssMode
    {
        Manual, //mostly made for season 6/7, launcher will manually patch the process
        DLL //the one that should be used for any other season than season 6/7
    }
}
