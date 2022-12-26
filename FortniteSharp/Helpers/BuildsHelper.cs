using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FortniteSharp.Internal;

namespace FortniteSharp.Helpers
{
    public class BuildsHelper
    {
        /// <summary>
        /// Determines if the provided path contains every required file for launching
        /// </summary>
        /// <param name="Path">A path to the Fortnite install (Should contain the FortniteGame and Engine folders)</param>
        /// <param name="AlsoCheckForFortniteEACEXE">Will also check for the EasyAntiCheat executable (might not work on builds older than 1.11)</param>
        /// <returns>True if path is valid, false if not valid</returns>
        public static bool IsPathValid(string Path, bool AlsoCheckForFortniteEACEXE = false)
        {
            if (File.Exists(Path + Strings.Fortnite64ShippingExecutablePath))
            {
                if (File.Exists(Path + Strings.Fortnite64ShippingBattleEyeExecutablePath))
                {
                    if (AlsoCheckForFortniteEACEXE)
                    {
                        if (File.Exists(Path+ Strings.Fortnite64ShippingEACExecutablePath))
                        {
                            return true;
                        }
                        else if (!File.Exists(Path + Strings.Fortnite64ShippingEACExecutablePath))
                        {
                            return false;
                        }
                    }

                    return true;
                }
                else if (!File.Exists(Path + Strings.Fortnite64ShippingBattleEyeExecutablePath))
                {
                    return false;
                }
            }
            else if (!File.Exists(Path + Strings.Fortnite64ShippingExecutablePath))
            {
                return false;
            }

            return false;
        }
        /// <summary>
        /// Determines if the EasyAntiCheat executable Exists
        /// </summary>
        /// <param name="ValidPath">A valid path</param>
        /// <returns>True if exists, false if it doesnt exist</returns>
        public static bool DoesEACExecutableExist(string ValidPath) //i have to do this because some older builds do not contain the eac executable
        {
            if (File.Exists(ValidPath + Strings.Fortnite64ShippingEACExecutablePath))
            {
                return true;
            }
            else if (!File.Exists(ValidPath + Strings.Fortnite64ShippingEACExecutablePath))
            {
                return false;
            }

            return false;
        }
    }
}
