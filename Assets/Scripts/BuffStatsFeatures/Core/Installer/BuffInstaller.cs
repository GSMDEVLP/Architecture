using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffInstaller : MonoBehaviour, IInstaller
{
    [SerializeField] private int _order = 0; 
    [SerializeField] private BuffSystem _buffSystem;
[SerializeField] private List<BuffConfig> _buffConfigs = new();

    private Dictionary<string, IBuff> _buffs;

    public int Order => _order;

    public void InstallBindings(GameServices gameServices)
    {
        foreach (var buffConfig in _buffConfigs)
        {
            var buff = buffConfig.CreateBuff();
            _buffs.Add(buffConfig.BuffName.ToString(), buff);
        }
        var entity = gameServices.Entity;
        _buffSystem.Init(entity, _buffs);
    }
}
