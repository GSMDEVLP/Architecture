using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class WeaponInstaller : MonoInstaller
{
    [SerializeField] private List<WeaponConfig> _weaponConfigs;

    public override void InstallBindings()
    {
        var defs = SetDTO();
        Container.BindInstance<IEnumerable<WeaponDefinition>>(defs);
        Container.Bind<IWeaponFactory>().To<WeaponFactoryFromDefinitions>().AsSingle();
        Container.Bind<WeaponSystem>().AsSingle();
        Container.Bind<IEventBus>().To<EventBus>().AsSingle();
    }

    private List<WeaponDefinition> SetDTO()
    {
        var defs = new List<WeaponDefinition>(_weaponConfigs.Count);
        foreach (var cfg in _weaponConfigs)
            defs.Add(cfg.ToDefinition());
        return defs;
    }
}
