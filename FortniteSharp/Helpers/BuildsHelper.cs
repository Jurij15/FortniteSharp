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
