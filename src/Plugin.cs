using BepInEx;
using HarmonyLib;
using UnityEngine;

namespace Cjayride.ClaimChestOpen
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    public class Plugin : BaseUnityPlugin
    {
        public const string PluginGuid = "cjayride.ClaimChestOpen";
        public const string PluginName = "Claim Chest Open";
        public const string PluginVersion = "1.0.1";

        private void Awake()
        {
            new Harmony(PluginGuid).PatchAll();
            Logger.LogInfo("Chests claim ownership on your client before they open, so a distant player in the same zone is not in the round trip.");
        }
    }

    /// <summary>
    /// Same idea as OpenSesame on doors: take the ZDO before Interact runs so the game
    /// does not RPC_RequestOpen to whoever currently owns the container.
    /// Ships and carts stay vanilla; stealing those ZDOs breaks vehicle physics.
    /// </summary>
    [HarmonyPatch(typeof(Container), nameof(Container.Interact))]
    internal static class ClaimOnInteract
    {
        private static void Prefix(Container __instance, Humanoid character)
        {
            if (__instance == null || character == null)
                return;
            if (Player.m_localPlayer == null || character != Player.m_localPlayer)
                return;
            if (__instance.m_nview == null || !__instance.m_nview.IsValid())
                return;
            if (__instance.m_nview.IsOwner())
                return;
            if (__instance.GetComponentInParent<Ship>() != null)
                return;
            if (__instance.GetComponentInParent<Vagon>() != null)
                return;

            __instance.m_nview.ClaimOwnership();
        }
    }
}
