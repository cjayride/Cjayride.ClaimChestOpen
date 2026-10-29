# ClaimChestOpen — Valheim 1.0.21 release

## Goal
- Verify Release build against Valheim 1.0.21, update BepInExPack dependency, changelog, Thunderstore `/dist` zip, git tag `v1.0.1`.

## Status
- Completed

## Changes
- Version 1.0.1 in csproj, Plugin.cs, manifest.
- BepInEx: `denikson-BepInExPack_Valheim-5.4.2360`.
- CHANGELOG (root + Package).
- `dist/` Thunderstore artifacts and zip.

## Commands
- `dotnet build -c Release` — succeeded (0 warnings, 0 errors).

## Output
- DLL: `D:\AI-Agent-Projects\cjaycraft\Cjayride.ClaimChestOpen\bin\Release\net481\Cjayride.ClaimChestOpen.dll`
- Zip: `D:\AI-Agent-Projects\cjaycraft\Cjayride.ClaimChestOpen\dist\cjayride-ClaimChestOpen-1.0.1.zip`
