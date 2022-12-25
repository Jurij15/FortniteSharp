using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortniteSharp.Helpers
{
    public class ProcessHelper
    {
        public static Process[] GetAllRunningProcesses()
        {
            return Process.GetProcesses();
        }

        public static bool IsProcessRunning(int PID)
        {
            if (PID == 0) return false;
            foreach (var Process in Process.GetProcesses())
            {
                if (Process.Id == PID)
                {
                    return true;
                }
                else if (Process.Id != PID)
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }

        public static bool IsProcessRunning(string Name)
        {
            if (Name == null) return false;
            if (Name == "") return false;
            foreach (var Process in Process.GetProcesses())
            {
                if (Process.ProcessName == Name)
                {
                    return true;
                }
                else if (Process.ProcessName == Name)
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }

        public static void KillProcess(int PID)
        {
            if (PID == 0) return;
            foreach (var Process in GetAllRunningProcesses())
            {
                if (Process.Id == PID)
                {
                    Process.Kill();
                }
                else if (Process.Id != PID)
                {
                    continue;
                }
            }
        }

        public static void KillProcess(string Name)
        {
            if (Name == null) return;
            if(Name== "") return;
            foreach (var Process in GetAllRunningProcesses())
            {
                if (Process.ProcessName == Name)
                {
                    Process.Kill();
                }
                else if (Process.ProcessName != Name)
                {
                    continue;
                }
            }
        }
    }
}
