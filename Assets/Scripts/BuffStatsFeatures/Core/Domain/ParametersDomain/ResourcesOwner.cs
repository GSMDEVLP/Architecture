using System;

public class ResourcesOwner : IResourcesOwner
{
    private readonly Resources _baseResources;
    private Resources _mods;
    private Resources _current;

    public ResourcesOwner(Resources baseResources)
    {
        _baseResources = baseResources;
        _mods = Resources.Zero;
        _current = baseResources;
    }

    public Resources GetResources()
    {
        int health = Math.Clamp(_current.Health, 0, _baseResources.Health);
        int mana = Math.Clamp(_current.Mana, 0, _baseResources.Mana);
        int stamina = Math.Clamp(_current.Stamina, 0, _baseResources.Stamina);
        int armor = _baseResources.Armor + _mods.Armor;

        return new Resources(health, mana, stamina, armor);
    }

    public void ApplyResourcesModifier(Resources delta)
    {
        _current = new Resources(
            Math.Clamp(_current.Health + delta.Health, 0, _baseResources.Health),
            Math.Clamp(_current.Mana + delta.Mana, 0, _baseResources.Mana),
            Math.Clamp(_current.Stamina + delta.Stamina, 0, _baseResources.Stamina),
            _current.Armor
        );

        _mods = new Resources(0, 0, 0, _mods.Armor + delta.Armor);
    }

    public void RemoveResourcesModifier(Resources delta)
    {
        _mods = new Resources(0, 0, 0, _mods.Armor - delta.Armor);
    }
}
