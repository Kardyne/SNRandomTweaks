namespace Kardyne.RandomTweaks.Patches;

using HarmonyLib;

[HarmonyPatch(typeof(PlayerTool), nameof(PlayerTool.ShouldPlayFirstUseAnimation))]
public class DisableToolFirstUseAnims
{
    static void Postfix(ref bool __result)
    {
        if (Plugin.Config.DisableToolFirstUseAnims) {
            __result = false;
	}
    }
}
