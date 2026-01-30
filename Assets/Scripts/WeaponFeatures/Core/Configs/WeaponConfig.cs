using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WeaponConfig",menuName = "Combat/Weapon")]
public class WeaponConfig : ScriptableObject
{
    [SerializeField] private WeaponType _weaponName;
    [SerializeField] private int _baseDamage;
    [SerializeField] private WeaponEffectConfig[] _effects;

    public WeaponType WeaponName => _weaponName;
    public int BaseDamage => _baseDamage;
    public WeaponEffectConfig[] Effects => _effects;

    public WeaponDefinition ToDefinition()
    {
        var defs = new List<EffectDefinition>(_effects.Length);
        foreach (var cfg in _effects)
            defs.Add(cfg.ToDefinition(_baseDamage));

        return new WeaponDefinition(_weaponName, _baseDamage, defs);
    }

}
