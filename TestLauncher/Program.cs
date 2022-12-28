using FortniteSharp;
using FortniteSharp.Launcher;
using FortniteSharp.Structs;
using FortniteSharp.Patchers;
using System.Diagnostics;

string Path = string.Empty;
string Args = string.Empty;
string SSLBypassDLLPath = string.Empty;
Process FN;

//get user variables
Console.WriteLine("Testing launcher for FortniteSharp");
Console.WriteLine("Enter the path to your Fortnite installation (the folder should contain the FortniteGame and Engine folders!)");
Path = Console.ReadLine();
Console.WriteLine("Enter the launch arguments to use (will be default if empty)");
Args= Console.ReadLine();
Console.WriteLine("Enter the path to the ssl bypass dll to use (will not be used if empty)");
SSLBypassDLLPath = Console.ReadLine();

//the actuall launch procedure
LaunchFortnite_Params Params= new LaunchFortnite_Params();
Params.ValidPath = Path;
Params.UseShellExecute = false;
Params.LaunchArguments= Args;

FN = Launcher.Start(FortniteSharp.Enums.FortniteExecutableType.Fortnite64ShippingExecutable, Params);

SSLBypassDLLParams SParams = new SSLBypassDLLParams();
SParams.ProcessID = FN.Id;
SParams.SSLBypassDLLLocation = SSLBypassDLLPath;

SSLPatcher.PatchWithDLL(SParams);

Basic.PrintFortniteSharpInfo();

///Console.ReadLine();

FN.WaitForExit();
