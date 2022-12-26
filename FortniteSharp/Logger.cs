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
    internal class Logger
    {
        /// <summary>
        /// Logs the provided message
        /// </summary>
        /// <param name="Importance">How important is the message</param>
        /// <param name="Source">Where is the message coming from</param>
        /// <param name="Message">The actuall message</param>
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
                    Console.WriteLine(LogMessage + "[Launcher]" + Message);
                    break;
                case LogMessageSource.SSLByapss:
                    Console.WriteLine(LogMessage + "[SSL]" + Message);
                    break;
                case LogMessageSource.None:
                    Console.WriteLine(LogMessage + Message); 
                    break;
                default:
                    break;
            }
        }
    }
}
