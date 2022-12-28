using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortniteSharp.Internal
{
    internal class Strings
    {
        public static readonly string Fortnite64ShippingExecutablePath = @"\FortniteGame\Binaries\Win64\FortniteClient-Win64-Shipping.exe";

        public static readonly string Fortnite64ShippingBattleEyeExecutablePath = @"\FortniteGame\Binaries\Win64\FortniteClient-Win64-Shipping_BE.exe";

        public static readonly string Fortnite64ShippingEACExecutablePath = @"\FortniteGame\Binaries\Win64\FortniteClient-Win64-Shipping_EAC.exe";

        public static readonly string FortniteLauncherExecutablePath = @"\FortniteGame\Binaries\Win64\FortniteLauncher.exe";

        public static readonly string FortniteSplashImage = @"\FortniteGame\Content\Splash\Splash.bmp";

        public static readonly string DefaultLaunchArguments = "-log -epicapp=Fortnite -epicenv=Prod -epiclocale=en-us -epicportal -skippatchcheck -nobe -fromfl=eac -fltoken=3db3ba5dcbd2e16703f3978d -caldera={} -AUTH_LOGIN=player@fortnite.dev -AUTH_PASSWORD=Password -AUTH_TYPE=epic";
    }

    internal sealed class Patches
    {
        public static readonly byte[] _verifyPeerPatched69 = new byte[] //s6 - 9.10
{
            65,
            57,
            40,
            176,
            0,
            144,
            136,
            131,
            80,
            4,
            0,
            0
};
    }
}
