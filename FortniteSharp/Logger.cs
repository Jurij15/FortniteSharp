using FortniteSharp.Enums;
using FortniteSharp.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortniteSharp
{
    public static class Logger
    {
        public static void Log(LogMessageImportance Importance, LogMessageSource Source, string Message)
        {
            string LogMessage = string.Empty;
            switch (Importance)
            {
                case LogMessageImportance.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    LogMessage = "[ERROR]";
                    break;
                case LogMessageImportance.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    LogMessage = "[WARNING]";
                    break;
                case LogMessageImportance.Success:
                    Console.ForegroundColor = ConsoleColor.Green;
                    LogMessage = "[SUCCESS]";
                    break;
                case LogMessageImportance.Information:
                    Console.ResetColor();
                    LogMessage = "[INFORMATION]";
                    break;
                default:
                    break;
            }

            switch (Source)
            {
                case LogMessageSource.Launcher:
                    Console.Write(LogMessage + "[Launcher]" + Message);
                    break;
                case LogMessageSource.SSLByapss:
                    Console.Write(LogMessage + "[SSL]" + Message);
                    break;
                default:
                    break;
            }
        }
    }
}
