# FiveM Default Build

Set the FiveM build to start by default when using the FiveM protocol handler (`fivem://connect/ip`).

![screenshot](https://user-images.githubusercontent.com/10238474/106896033-b2590380-66f9-11eb-9c2a-4259ca8a76d0.png)

## ⚠ DO THIS AT YOUR OWN RISK!

This utility is intended to mitigate the risk of editing Windows Registry.  
  
However, if you are not comfortable using this utility, you may use a safer method:  
Make a shortcut to FiveM, right click, Properties.  
In "Target", at the end of the text, add <kbd> -b2060</kbd> - that's: space dash b2060 (or <kbd> -b2189</kbd>) and save.
  
Use that shortcut to start FiveM before connecting to a server that requires build 2060 or 2189, respectively.

## [Download](https://github.com/sharkykh/FiveM_Default_Build/releases/latest)

## How to use?

Note: You only need to do this once (until you reinstall FiveM).  

- Download the EXE file and run it.
- Windows might show a blue SmartScreen warning, you will need to click "More info" and then "Run anyway" at the buttom of the window.
- Select the appropriate game build version or "Default" to revert.
- Click "Set".
- Done!

## Supported game builds

- Default (whatever FiveM launches by default)
- b2060
- b2189

## How does this work?

This small utility changes the Windows Registry key at:
```reg
HKEY_CURRENT_USER\SOFTWARE\Classes\FiveM.ProtocolHandler\shell\open\command
```
to force FiveM to launch a specific game build by default.
