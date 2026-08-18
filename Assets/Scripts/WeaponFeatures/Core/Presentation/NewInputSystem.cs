using System;
using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

[RequireComponent(typeof(PlayerInput))]
public sealed class NewInputSystem : MonoBehaviour
{
    private IEventBus _bus;
    private PlayerInput _playerInput;
    private InputAction _attackAction;
    private InputAction _swordAction;
    private InputAction _bowAction;
    private InputAction _axeAction;
    private InputAction _bladeAction;

    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();

        _attackAction = _playerInput.actions.FindAction(
            "Player/Attack",
            throwIfNotFound: true);

        _swordAction = _playerInput.actions.FindAction(
            "Player/Sword",
            throwIfNotFound: true);

        _bowAction = _playerInput.actions.FindAction(
            "Player/Bow",
            throwIfNotFound: true);

        _axeAction = _playerInput.actions.FindAction(
            "Player/Axe",
            throwIfNotFound: true);

        _bladeAction = _playerInput.actions.FindAction(
            "Player/Blade",
            throwIfNotFound: true);
    }

    [Inject]
    public void Construct(IEventBus bus)
    {
        _bus = bus;
    }
    private void OnEnable()
    {
        _attackAction.performed += OnAttack;
        _swordAction.performed += OnSelectSword;
        _bowAction.performed += OnSelectBow;
        _axeAction.performed += OnSelectAxe;
        _bladeAction.performed += OnSelectBlade;
    }
    private void OnDisable()
    {
        _attackAction.performed -= OnAttack;
        _swordAction.performed -= OnSelectSword;
        _bowAction.performed -= OnSelectBow;
        _axeAction.performed -= OnSelectAxe;
        _bladeAction.performed -= OnSelectBlade;
    }

    private void OnSelectAxe(InputAction.CallbackContext context)
    {
        SelectWeapon(WeaponType.Axe);
    }


    private void OnSelectBow(InputAction.CallbackContext context)
    {
        SelectWeapon(WeaponType.Bow);
    }


    private void OnSelectSword(InputAction.CallbackContext context)
    {
        SelectWeapon(WeaponType.Sword);
    }

    private void OnSelectBlade(InputAction.CallbackContext context)
    {
        SelectWeapon(WeaponType.Blade);
    }

    private void SelectWeapon(WeaponType weaponType)
    {
        _bus.Invoke(new SetWeaponType(weaponType));
    }

    private void OnAttack(InputAction.CallbackContext context)
    {
        _bus.Invoke(new SetAttack());
    }
}
