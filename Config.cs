namespace Kardyne.RandomTweaks;

using Nautilus.Json;
using Nautilus.Options.Attributes;

[Menu("Kardyne's Random Tweaks", LoadOn = MenuAttribute.LoadEvents.MenuRegistered | MenuAttribute.LoadEvents.MenuOpened)]
public class Config: ConfigFile
{
    [Toggle("Force disable hints", Tooltip = "Force disable hints in all game mods (such as low oxygen alerts)")]
    public bool ForceNoHints = false;

    [Toggle("Disable Escape Pod Hatch Animations", Tooltip = "Disable Escape Pod first use hatch animations. Must be set before loading/creating a new save.")]
    public bool DisableEscapePodHatchAnims = false;

    [Toggle("Always open PDA on Inventory tab", Tooltip = "When the PDA is opened, always select the inventory tab.")]
    public bool ForcePDAInventory = false;

    [Toggle("Force disable Radiation FX", Tooltip = "Ensure that Radiation Fx will never show.")]
    public bool ForceDisableRadiationFx = false;

    [Toggle("Disable first use animations", Tooltip = "Disable first use animations for tools.")]
    public bool DisableToolFirstUseAnims = false;
}
