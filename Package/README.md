# Claim Chest Open

OpenSesame for chests. When you press E on a container, your client takes ZDO ownership first, then the chest opens locally. The dedicated server records it; other players see it when their packet arrives. You no longer wait on whoever happened to load that zone first.

Ship and cart inventories are not claimed.

**Client only.** Dedicated servers do not need this.

## Requires

- [BepInExPack for Valheim](https://thunderstore.io/c/valheim/p/denikson/BepInExPack_Valheim/)

## Install

**Thunderstore, Gale, or r2modman:** install the package.

**Nexus or a manual zip:** copy `plugins/cjayride-ClaimChestOpen` into `Valheim/BepInEx/plugins`. You should end up with:

```
Valheim/BepInEx/plugins/cjayride-ClaimChestOpen/Cjayride.ClaimChestOpen.dll
```

Do not copy `manifest.json`, `README.md`, or `icon.png` into the game.

Replace `icon.png` (exactly 256×256) before uploading to Thunderstore, Hexium, or Nexus if you are packaging this yourself.

## Contact
-  X: x.com/cjayride

-  Discord: discord.gg/cjayride (find me at the top of the user list) "cjayride"

-  Twitch: twitch.tv/cjayride
