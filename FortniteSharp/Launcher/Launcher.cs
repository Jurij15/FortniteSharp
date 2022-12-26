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
        /// <summary>
        /// Launches Fortnite based on the parameters provided
        /// </summary>
        /// <param name="Executable">Type of the executable that will be launched</param>
        /// <param name="Params">Parameters about launching</param>
        /// <returns>Fortnite Process</returns>
        public static Process Start(FortniteExecutableType Executable, LaunchFortnite_Params Params)
        {
            Process p = new Process();
            string LaunchArgs = string.Empty;
            bool bProcessStarted = false;
            bool bSuspendAfterLaunch = false;

            if (BuildsHelper.IsPathValid(Params.ValidPath))
            {
                //determine which executable to start
                switch (Executable)
                {
                    case FortniteExecutableType.Fortnite64ShippingExecutable:
                        p.StartInfo.FileName= Params.ValidPath + Strings.Fortnite64ShippingExecutablePath;
                        break;
                    case FortniteExecutableType.Fortnite64ShippingBattleEye:
                        p.StartInfo.FileName = Params.ValidPath + Strings.Fortnite64ShippingBattleEyeExecutablePath;
                        bSuspendAfterLaunch= true;
                        break;
                    case FortniteExecutableType.Fortnite64ShippingEasyAntiCheat:
                        if (BuildsHelper.DoesEACExecutableExist(Params.ValidPath))
                        {
                            p.StartInfo.FileName = Params.ValidPath + Strings.Fortnite64ShippingEACExecutablePath;
                            bSuspendAfterLaunch= true;
                        }
                        else
                        {
                            Logger.Log(LogMessageImportance.Error, LogMessageSource.Launcher, "Unable to start and suspend EAC as it does not exist!");
                        }
                        break;
                    default:
                        break;
                }
            }
            else if (!BuildsHelper.IsPathValid(Params.ValidPath))
            {
                Logger.Log(LogMessageImportance.Error, LogMessageSource.Launcher, "Provided path is not valid!");
            }

            if (Params.UseShellExecute == true)
            {
                p.StartInfo.UseShellExecute = true;
            }

            if (Params.LaunchArguments != null || Params.LaunchArguments != string.Empty)
            {
                p.StartInfo.Arguments= Strings.DefaultLaunchArguments;
                LaunchArgs = p.StartInfo.Arguments;
            }
            else
            {
                p.StartInfo.Arguments = Strings.DefaultLaunchArguments;
                LaunchArgs = p.StartInfo.Arguments;
            }

            if (p.Start())
            {
                bProcessStarted= true;
            }
            else
            {
                bProcessStarted= false;
            }

            if(bSuspendAfterLaunch)
            {
                Win32.SuspendProcess(p);
            }

            if (bProcessStarted)
            {
                Logger.Log(LogMessageImportance.Success, LogMessageSource.Launcher, "Fortnite was launched!");
                Logger.Log(LogMessageImportance.Information, LogMessageSource.Launcher, "Details:");
                Logger.Log(LogMessageImportance.Information, LogMessageSource.Launcher, "Executable type: " + Executable.ToString());
                Logger.Log(LogMessageImportance.Information, LogMessageSource.Launcher, "Started on: " + DateTime.Now.ToString());
                Logger.Log(LogMessageImportance.Information, LogMessageSource.Launcher, "Process ID: " + p.Id.ToString());
                Logger.Log(LogMessageImportance.Information, LogMessageSource.Launcher, "Launch arguments: " + LaunchArgs);
                Logger.Log(LogMessageImportance.Information, LogMessageSource.Launcher, "Path: " + p.StartInfo.FileName);
                if (bSuspendAfterLaunch)
                {
                    Logger.Log(LogMessageImportance.Information, LogMessageSource.Launcher, "The Process was suspended after launch!");
                }
            }
            else if (!bProcessStarted) 
            {
                Logger.Log(LogMessageImportance.Error, LogMessageSource.Launcher, "Fortnite was not launched!");
            }

            return p;
        }
    }
}
