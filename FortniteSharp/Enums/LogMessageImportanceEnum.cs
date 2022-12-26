using FortniteSharp.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortniteSharp.Enums
{ 
    /// <summary>
    /// Determine the importance of the log message
    /// </summary>
    public enum LogMessageImportance : int
    {
        Error,
        Warning,
        Success,
        Information
    };
}
