namespace Kardyne.RandomTweaks.Patches;

using HarmonyLib;

[HarmonyPatch(typeof(RadiationsScreenFXController))]
public class ForceDisableRadiationFx
{
    [HarmonyPostfix]
    [HarmonyPatch(nameof(RadiationsScreenFXController.Update))]
    public static void OverrideScreenFxUpdate(RadiationsScreenFXController __instance)
    {
        if (Plugin.Config.ForceDisableRadiationFx) {
            __instance.fx.enabled = false;
        }
    }
}
