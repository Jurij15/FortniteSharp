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
LaunchFortnite_Params Params= new LaunchFortnite_Params(); //create the params variable
Params.ValidPath = Path; //path that we got from the user
Params.SuspendOnStart = false; //the process will not get suspended on startup
Params.LaunchArguments= Args; //arguments to launch it

FN = Launcher.Start(FortniteSharp.Enums.FortniteExecutableType.Fortnite64ShippingExecutable, Params); //start the process and assign it to the FN variable

/*
 * What is FortniteExecutableType?
 * It tells the launcher if the launched process is EAC or BE or just normal Fornite
 * if it is EAC or BE, SuspendOnStart will be automatically true
 * */

SSLBypassDLLParams SParams = new SSLBypassDLLParams(); //create the SParams variable
SParams.ProcessID = FN.Id; //fortnite process id
SParams.SSLBypassDLLLocation = SSLBypassDLLPath; //path to the dll that will be used to bypass ssl

SSLPatcher.PatchWithDLL(SParams); //patch SSL

Basic.PrintFortniteSharpInfo();

///Console.ReadLine();

FN.WaitForExit();
