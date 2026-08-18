using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class BuffInstaller : MonoInstaller
{
    [SerializeField] private List<BuffConfig> _buffConfigs;

    private Dictionary<BuffsEnum, IBuff> _buffs = new();
    
    public override void InstallBindings()
    {
        CreateBuff();
        Container.Bind<BuffService>().AsSingle();
        // Container.Bind<BuffSystem>().AsSingle();
        // Container.Bind<ParameterSystem>().AsSingle();
        // Container.BindInterfacesAndSelfTo<BuffInstaller>().AsSingle();
        // Container.BindInterfacesAndSelfTo<ParameterInstaller>().AsSingle();
    }

    private void CreateBuff()
    {
        foreach (var buffConfig in _buffConfigs)
        {
            var buff = buffConfig.CreateBuff();
            if (_buffs.TryAdd(buffConfig.BuffName, buff))
                Debug.Log($"[BuffInstaller] Registered buff: {buffConfig.BuffName}");
            else
                Debug.LogWarning($"[BuffInstaller] Duplicate buff key: {buffConfig.BuffName}");
        }
        Container.BindInstance(_buffs);
    }
}
