# FiveM Default Build

Set the default build for FiveM protocol handler (`fivem://connect/ip`)

![screenshot](https://user-images.githubusercontent.com/10238474/106896033-b2590380-66f9-11eb-9c2a-4259ca8a76d0.png)

## How?

This small utility changes the Windows Registry key at:
```reg
HKEY_CURRENT_USER\SOFTWARE\Classes\FiveM.ProtocolHandler\shell\open\command
```
to force FiveM to launch a specific game build by default.

## Supported versions

- Default (whatever FiveM launches by default)
- b2060
- b2189
