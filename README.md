# Starbound - RCON Sample

A small sample project I had laying around that contains an RCON app and server mod.

## Enabling RCON

In the `starbound_server.config`, a few values must be set to enable RCON on the server.

| Key | Value |
| --- | --- |
| runRconServer | `true` |
| rconServerBind | `*` |
| rconServerPassword | `YourSecureRCONPassword` |
| rconServerPort | Port for the RCON listener. Make sure this value differs from the actual server port. |
| rconServerTimeout | Amount of time before inactive connections are dropped (probably milliseconds). If you're not getting any response frequently, consider increasing this value. |

---

# Server Mod

The server mod includes a command processor script, which allows you to define your own RCON functions. The main server commands also work through RCON (such as `ban`).

Please note that the mod is specifically made for RCON commands, and will have to be modified or integrated into another mod to allow for custom in-game commands as well.

## Installation

1. Copy or move the `StarboundRCON-Mod` folder into the Starbound `mods` folder.
2. Set `allowAssetsMismatch` to `true` in the `starbound_server.config`.

---

# Client Application

The client application is a Windows Forms application used to send RCON commands to the server. It is just a simple application used to test if RCON is configured and working correctly, so don't be surprised if there's any issues with the application.

![](https://raw.githubusercontent.com/Silverfeelin/Starbound-RCONSample/master/StarboundRCON-App/overview.png)

## Installation

1. Copy the `StarboundRCON-App` folder anywhere you want.
  * Make sure you copy the folder from a downloaded [release](https://github.com/Silverfeelin/Starbound-RCONSample/releases), **not** the source code!
  * The application depends on all included `.dll` files. Make sure they're in the same location.
2. Open the application.
3. Define your settings in the `settings` tab.

## Settings

All settings, including the RCON Server Password, are saved in a configuration file.  
Location: `%AppData%/StarboundRCON/settings.config`

Changed settings are saved automatically when changing back to the `RCON` tab or when closing the application.

| Setting | Description |
| --- | --- |
| Server Address | The server IP.<br/>In case of local testing, use `127.0.0.1`. |
| RCON Server Port | The RCON listener port. |
| RCON Server Password | The RCON server password. |
| Message Format | The format of sent RCON messages.<br/>The identifier `{message}` will be replaced with the entered command. |

![](https://raw.githubusercontent.com/Silverfeelin/Starbound-RCONSample/master/StarboundRCON-App/overview-settings.png)

---

# Licenses

This project is licensed under the [MIT License](https://github.com/Silverfeelin/Starbound-RCONSample/blob/master/LICENSE).  
The client application uses some libraries, which have their own license found below.

| Library | License |
| ---     | ---     |
| [MaterialSkin](https://github.com/IgnaceMaes/MaterialSkin) | [MIT License](https://github.com/IgnaceMaes/MaterialSkin/blob/master/LICENSE) |
| [RconSharp](https://github.com/stefanodriussi/rconsharp) | [MIT License](https://github.com/stefanodriussi/rconsharp/blob/master/LICENSE) |
| [Microsoft Async](https://www.nuget.org/packages/Microsoft.Bcl.Async/) | [DotNET Library License](https://www.microsoft.com/net/dotnet_library_license.htm) |