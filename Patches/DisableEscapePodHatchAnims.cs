namespace Kardyne.RandomTweaks.Patches;

using HarmonyLib;

[HarmonyPatch(typeof(EscapePodFirstUseCinematicsController))]
public class DisableEscapePodHatchAnims
{
    [HarmonyPrefix]
    [HarmonyPatch(nameof(EscapePodFirstUseCinematicsController.Initialize))]
    public static void OverrideHatchUsed(EscapePodFirstUseCinematicsController __instance)
    {
        if (Plugin.Config.DisableEscapePodHatchAnims) {
            __instance.escapePod.bottomHatchUsed = true;
            __instance.escapePod.topHatchUsed = true;
        }
    }
}
