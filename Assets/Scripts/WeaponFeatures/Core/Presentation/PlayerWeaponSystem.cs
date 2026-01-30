using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponSystem : MonoBehaviour
{
    private ITarget _target;
    private IEventBus _bus;
    private WeaponSystem _weaponSystem;

    private void Awake()
    {
        _target = new Target(100, 100);
    }

    public void Init(WeaponSystem weaponSystem, IEventBus bus)
    {
        _weaponSystem = weaponSystem;
        _bus = bus;
        _bus.Subscribe<SetWeaponType>(SetWeapon);
        _bus.Subscribe<SetAttack>(SetAttack);
    }

    private void SetAttack(SetAttack e)
    {
        if(_weaponSystem.Weapon == null)
        {
            Debug.LogWarning("No weapon selected!");
            return;
        }
        _weaponSystem.Attack(_target);
        Debug.Log($"Target health after attack: {_target.Health}");
    }

    private void SetWeapon(SetWeaponType type)
    {
        _weaponSystem.SetWeapon(type.WeaponType);
        Debug.Log($"Weapon set to {type.WeaponType} with base damage {_weaponSystem.Weapon.BaseDamage}");
    }

    private void OnDestroy()
    {
        _bus.Unsubscribe<SetWeaponType>(SetWeapon);
        _bus.Unsubscribe<SetAttack>(SetAttack);
    }

}
