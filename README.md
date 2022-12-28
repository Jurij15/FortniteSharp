# FortniteSharp
A simple tool to help making custom launchers for Fortnite easiser

# Usage
-You can check out the TestLauncher for an example on how to use this tool
## Without SSL Bypass
```
using FortniteSharp;
using FortniteSharp.Launcher;
using FortniteSharp.Structs;

LaunchFortnite_Params Params= new LaunchFortnite_Params();
Params.ValidPath = /*Path to the folder that contains the FortniteGame and Engine folders*/;
Params.UseShellExecute = false;
Params.LaunchArguments= /*if you need, custom launch arguments*/;

Launcher.Start(FortniteSharp.Enums.FortniteExecutableType.Fortnite64ShippingExecutable, Params);
```

## With SSL Bypass

```
using FortniteSharp;
using FortniteSharp.Launcher;
using FortniteSharp.Structs;
using FortniteSharp.Patchers;

LaunchFortnite_Params Params= new LaunchFortnite_Params();
Params.ValidPath = /*Path to the folder that contains the FortniteGame and Engine folders*/;
Params.UseShellExecute = false;
Params.LaunchArguments= /*if you need, custom launch arguments*/;

Launcher.Start(FortniteSharp.Enums.FortniteExecutableType.Fortnite64ShippingExecutable, Params);

SSLBypassDLLParams SParams = new SSLBypassDLLParams();
SParams.ProcessID = FN.Id;
SParams.SSLBypassDLLLocation = SSLBypassDLLPath;

SSLPatcher.PatchWithDLL(SParams);
```
