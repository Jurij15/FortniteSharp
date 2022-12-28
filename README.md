# FortniteSharp
A simple tool to help making custom launchers for Fortnite easiser

## Usage
# Without SSL Bypass
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
