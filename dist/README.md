# 📦 Claim Chest Open

### Open Containers Without Waiting for ZDO Ownership

**OpenSesame for Valheim containers.**

Claim Chest Open lets your client take ownership of a container's ZDO (Zone Data Object) before opening it. When you press **E** to open a container, ownership is claimed first so the container can open locally without waiting for whichever player originally loaded the area.

The dedicated server records the change, and other players see the updated state when their network packets arrive.

### ✨ Features

- **Faster container access:** Claim ownership before opening a container.
- **Reduced waiting:** No longer need to wait on the player who first loaded the zone.
- **Multiplayer compatible:** The dedicated server records the change for other players to receive.
- **Ship and cart inventories excluded:** These inventories are not claimed by the mod.

## 📦 Requirements

- [BepInExPack for Valheim](https://thunderstore.io/c/valheim/p/denikson/BepInExPack_Valheim/)

> **Client-side only:** Dedicated servers do not need this mod installed.

## 📥 Installation

### Thunderstore, Gale, or r2modman

Install the package through your preferred mod manager.

### Nexus Mods or Manual Installation

1. Download and extract the mod archive.
2. Copy the `plugins/cjayride-ClaimChestOpen` folder into your Valheim `BepInEx/plugins` directory.
3. Confirm the DLL is located at:

```text id="7ab3d9"
Valheim/BepInEx/plugins/
└── cjayride-ClaimChestOpen/
    └── Cjayride.ClaimChestOpen.dll
```

**Do not copy** `manifest.json`, `README.md`, or `icon.png` into the game's plugin directory.

If you are packaging this mod yourself for Thunderstore, Hexium, or Nexus, replace `icon.png` with your own **256 × 256** icon before uploading.

## 💬 Contact

- **X:** [@cjayride](https://x.com/cjayride)
- **Discord:** [discord.gg/cjayride](https://discord.gg/cjayride) — Find `cjayride` near the top of the user list.
- **Twitch:** [twitch.tv/cjayride](https://twitch.tv/cjayride)

