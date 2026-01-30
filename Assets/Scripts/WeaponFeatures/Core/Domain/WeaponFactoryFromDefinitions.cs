using System;
using System.Collections.Generic;

public sealed class WeaponFactoryFromDefinitions : IWeaponFactory
{
    private readonly Dictionary<WeaponType, WeaponDefinition> _defs = new();
    private readonly Dictionary<WeaponType, IWeapon> _cache = new();

    public WeaponFactoryFromDefinitions(IEnumerable<WeaponDefinition> defs)
    {
        foreach (var d in defs)
            _defs[d.Type] = d;
        CreateWeaponsCache();
    }

    private void CreateWeaponsCache()
    {
        foreach (var def in _defs.Values)
        {
            var effects = new List<IWeaponEffect>(def.Effects.Count);
            foreach (var e in def.Effects)
                effects.Add(e.CreateEffect());

            var weapon = new CompositeWeapon(def.BaseDamage, effects);
            _cache[def.Type] = weapon;
        }
    }

    public IWeapon GetWeapon(WeaponType type)
    {
        if (_cache.TryGetValue(type, out var weapon))
            return weapon;
        throw new ArgumentException($"Weapon of type {type} is not defined in factory");
    }
}
