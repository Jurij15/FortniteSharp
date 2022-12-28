# FortniteSharp
A simple tool to help making custom launchers for Fortnite easiser

# Usage
- You can check out the TestLauncher for an example on how to use this tool
## Without SSL Bypass
```
using FortniteSharp;
using FortniteSharp.Launcher;
using FortniteSharp.Structs;

//the actuall launch procedure
LaunchFortnite_Params Params= new LaunchFortnite_Params(); //create the params variable
Params.ValidPath = /*Path to the folder that contains the FortniteGame and Engine folders*/;
Params.SuspendOnStart = false; //the process will not get suspended on startup
Params.LaunchArguments= /*if you need, custom launch arguments*/;

/*
 * What is FortniteExecutableType?
 * It tells the launcher if the launched process is EAC or BE or just normal Fornite
 * if it is EAC or BE, SuspendOnStart will be automatically true

SSLBypassDLLParams SParams = new SSLBypassDLLParams(); //create the SParams variable
SParams.ProcessID = FN.Id; //fortnite process id
SParams.SSLBypassDLLLocation = SSLBypassDLLPath; //path to the dll that will be used to bypass ssl
*/

Launcher.Start(FortniteSharp.Enums.FortniteExecutableType.Fortnite64ShippingExecutable, Params); //start the process
```

## With SSL Bypass

```
using FortniteSharp;
using FortniteSharp.Launcher;
using FortniteSharp.Structs;
using FortniteSharp.Patchers;

//the actuall launch procedure
LaunchFortnite_Params Params= new LaunchFortnite_Params(); //create the params variable
Params.ValidPath = /*Path to the folder that contains the FortniteGame and Engine folders*/;
Params.SuspendOnStart = false; //the process will not get suspended on startup
Params.LaunchArguments= /*if you need, custom launch arguments*/;

Launcher.Start(FortniteSharp.Enums.FortniteExecutableType.Fortnite64ShippingExecutable, Params); //start the process and assign it to the FN variable

SSLBypassDLLParams SParams = new SSLBypassDLLParams(); //create the SParams variable
SParams.ProcessID = //fortnite process id;
SParams.SSLBypassDLLLocation = //path to the dll that will be used to bypass ssl;

SSLPatcher.PatchWithDLL(SParams); //patch SSL
```
