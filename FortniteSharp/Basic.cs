using FortniteSharp.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Version = FortniteSharp.Internal.Version;

namespace FortniteSharp
{
    public class Basic
    {
        public static void PrintFortniteSharpInfo()
        { 
            Logger.Log(Enums.LogMessageImportance.Information, Enums.LogMessageSource.None, "FortniteSharp");
            Logger.Log(Enums.LogMessageImportance.Information, Enums.LogMessageSource.None, "A tool to help you make a custom launcher for fortnite easier");
            Logger.Log(Enums.LogMessageImportance.Information, Enums.LogMessageSource.None, "Version: " + Version.VersionString);
            Logger.Log(Enums.LogMessageImportance.Information, Enums.LogMessageSource.None, "Made by Jurij15");
            Logger.Log(Enums.LogMessageImportance.Information, Enums.LogMessageSource.None, "GitHub: https://github.com/Jurij15/FortniteSharp");
        }
    }
}
