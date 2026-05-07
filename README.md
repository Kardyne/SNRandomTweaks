# Subnautica Random Tweaks

Requires Nautilus.

Some tweaks to better fit my play style.

All of these are disabled by default, and can be enabled with the in-game mod
config menu.

* Force disable hints: Force disable all in-game hints on all difficulties. This
  makes it possible to run on non-hardcore difficulties and not have the
  low-oxygen alerts.
* Disable Escape Pod Hatch Animations: Disable first use hatch animations. This
  must be set before loading/creating a new save.
* Always open PDA on Inventory tab: Instead of letting the game determine which
  tab to open (such as opening the encyclopedia), force the PDA to always open
  on the inventory tab. This avoids problems when trying to quickly open the
  inventory to switch gear.
* Force disable Radiation FX: The radiation effects make me a bit dizzy and
  nauseous, so this force disables them.
* Disable first tool use animations: Disable the animations that happen on the
  first time the player picks up a tool.

## Build

On Linux:

```bash
dotnet build
```

Running `dotnet run` should also install to the Subnautica mod directory
automatically on Linux.
