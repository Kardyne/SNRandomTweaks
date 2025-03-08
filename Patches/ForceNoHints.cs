namespace Kardyne.RandomTweaks.Patches;

using HarmonyLib;

[HarmonyPatch(typeof(GameModeUtils))]
public class ForceNoHints
{
    [HarmonyPostfix]
    [HarmonyPatch(nameof(GameModeUtils.IsOptionActive))]
    [HarmonyPatch(new [] { typeof(GameModeOption) })]
    public static void OverrideNoHints(GameModeOption option, ref bool __result)
    {
        if (GameModeUtils.IsOptionActive(option, GameModeOption.NoHints) && Plugin.Config.ForceNoHints) {
            __result = true;
        }
    }
}
