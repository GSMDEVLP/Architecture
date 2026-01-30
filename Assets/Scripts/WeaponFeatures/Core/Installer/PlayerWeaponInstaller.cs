using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponInstaller : MonoBehaviour, IInstaller
{
    [SerializeField] private int _order = 0; 
    [SerializeField] private List<WeaponConfig> _weaponConfigs;
    [SerializeField] private PlayerWeaponSystem _playerWeaponController;

    public int Order => _order;

    public void InstallBindings(GameServices gameServices)
    {
        var defs = new List<WeaponDefinition>(_weaponConfigs.Count);
        foreach (var cfg in _weaponConfigs)
            defs.Add(cfg.ToDefinition());

        var factory = new WeaponFactoryFromDefinitions(defs);
        var weaponSystem = new WeaponSystem(factory);

        _playerWeaponController.Init(weaponSystem, gameServices.EventBus);
    }
}
