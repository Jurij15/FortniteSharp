using FortniteSharp.Enums;
using FortniteSharp.Helpers;
using FortniteSharp.Internal;
using FortniteSharp.Structs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortniteSharp.Launcher
{
    public class Launcher
    {
        public static Process Start(FortniteExecutableType Executable, LaunchFortnite_Params Params)
        {
            Process p = new Process();
            if (BuildsHelper.IsPathValid(Params.ValidPath))
            {
                p.StartInfo.FileName = Params.ValidPath;
            }
            else if (!BuildsHelper.IsPathValid(Params.ValidPath))
            {
                Logger.Log(LogMessageImportance.Error, LogMessageSource.Launcher, "Provided path is not valid!");
                return null;
            }

            if (Params.LaunchArguments == null || Params.LaunchArguments == "")
            {
                p.StartInfo.Arguments = Strings.DefaultLaunchArguments;
            }
            else if (Params.LaunchArguments != null || Params.LaunchArguments != "")
            {
                p.StartInfo.Arguments = Params.LaunchArguments;
            }

            if (Params.UseShellExecute == true) p.StartInfo.UseShellExecute = true;
            if (Params.UseShellExecute == false) p.StartInfo.UseShellExecute= false;

            p.Start();

            Logger.Log(LogMessageImportance.Success, LogMessageSource.Launcher, "Fortnite was launched!");
            Logger.Log(LogMessageImportance.Information, LogMessageSource.Launcher, "Details:");
            Logger.Log(LogMessageImportance.Information, LogMessageSource.Launcher, "Started on" + DateTime.Now.ToString());
            Logger.Log(LogMessageImportance.Information, LogMessageSource.Launcher, "Process ID" + p.Id.ToString());

            return p;
        }
    }
}
