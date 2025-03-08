namespace Kardyne.RandomTweaks.Patches;

using HarmonyLib;

[HarmonyPatch(typeof(uGUI_PDA))]
public class ForcePDAInventory
{
    [HarmonyPrefix]
    [HarmonyPatch(nameof(uGUI_PDA.OnOpenPDA))]
    public static void OverrideNoHints(ref PDATab tabId)
    {
        if (Plugin.Config.ForcePDAInventory) {
            tabId = PDATab.Inventory;
        }
    }
}
