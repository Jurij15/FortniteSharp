using FortniteSharp.Internal;
using FortniteSharp.Structs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortniteSharp.Patchers
{
    public class SSLPatcher
    {
        /// <summary>
        /// Patches SSL by injecting the DLL, provided in Params
        /// </summary>
        /// <param name="Params">Parameters</param>
        public static void PatchWithDLL(SSLBypassDLLParams Params)
        {
            Injector.InjectDll(Params.ProcessID, Params.SSLBypassDLLLocation);
            Logger.Log(Enums.LogMessageImportance.Success, Enums.LogMessageSource.SSLByapss, "Patched SSL!");
        }

        /// <summary>
        /// Patches the SSL Manually, mostly made for season 6/7
        /// 
        /// NOTE::
        /// Experiencing some issues with this right now, it might be put to private
        /// 
        /// It will stay on private until i figure out why is it crashing the game
        /// </summary>
        private void ManualPatch(SSLBypassManualParams Params)
        {
            Process FN = Params.FNProces;
            if (!FN.WaitForInputIdle())
            {
                Logger.Log(Enums.LogMessageImportance.Error, Enums.LogMessageSource.SSLByapss, "Unable to set process state Idle!");
                return;
            }

            Win32.SuspendProcess(FN);

            var SS = new SigScan(SigScan.OpenProcess(SigScan.PROCESS_ALL_ACCESS, false, FN.Id));
            SS.SelectModule(FN.MainModule);
            var Addr = SS.FindPattern("41 39 28 0F 95 C0 88 83 50 04 00 00", out long Time);
            if (Addr == 0)
            {
                Logger.Log(Enums.LogMessageImportance.Error, Enums.LogMessageSource.SSLByapss, "Unable to Find CUROPT_SSL_VERIFYPEER!");
                return;
            }
            SigScan.WriteProcessMemory(SigScan.OpenProcess(SigScan.PROCESS_ALL_ACCESS, false, FN.Id), (IntPtr)Addr, Patches._verifyPeerPatched69, Patches._verifyPeerPatched69.Length, out IntPtr bytesWritten);

            Logger.Log(Enums.LogMessageImportance.Success, Enums.LogMessageSource.SSLByapss, "Patched SSL, resuming process!");

            NewWin32.ResumeProcess(FN.Id);
        }
    }
}
