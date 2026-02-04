using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffInstaller : MonoBehaviour, IInstaller
{
    [SerializeField] private int _order; 
    [SerializeField] private BuffSystem _buffSystem;
    [SerializeField] private List<BuffConfig> _buffConfigs = new();

    private Dictionary<BuffsEnum, IBuff> _buffs = new();

    public int Order => _order;

    public void InstallBindings(GameServices gameServices)
    {
        foreach (var buffConfig in _buffConfigs)
        {
            var buff = buffConfig.CreateBuff();
            if (_buffs.TryAdd(buffConfig.BuffName, buff))
                Debug.Log($"[BuffInstaller] Registered buff: {buffConfig.BuffName}");
            else
                Debug.LogWarning($"[BuffInstaller] Duplicate buff key: {buffConfig.BuffName}");
        }
        var entity = gameServices.Entity;
        var buffService = new BuffService(entity, _buffs);
        _buffSystem.Init(buffService);
        Debug.Log($"[BuffInstaller] BuffSystem initialized. Buff count: {_buffs.Count}");
    }
}
