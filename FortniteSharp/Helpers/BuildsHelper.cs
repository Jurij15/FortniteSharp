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
        public static bool IsPathValid(string Path, bool AlsoCheckForFortniteLauncherEXE = false)
        {
            if (File.Exists(Path + Strings.Fortnite64ShippingExecutablePath))
            {
                if (File.Exists(Path + Strings.Fortnite64ShippingBattleEyeExecutablePath))
                {
                    if (File.Exists(Path + Strings.Fortnite64ShippingEACExecutablePath))
                    {
                        if (AlsoCheckForFortniteLauncherEXE)
                        {
                            if (File.Exists(Path + Strings.FortniteLauncherExecutablePath))
                            {
                                return true;
                            }
                            else if (!File.Exists(Path + Strings.FortniteLauncherExecutablePath))
                            {
                                return false;
                            }
                        }
                        else if (!AlsoCheckForFortniteLauncherEXE)
                        {
                            return true;
                        }
                    }
                    else if (!File.Exists(Path + Strings.Fortnite64ShippingEACExecutablePath))
                    {
                        return false;
                    }
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
    }
}
