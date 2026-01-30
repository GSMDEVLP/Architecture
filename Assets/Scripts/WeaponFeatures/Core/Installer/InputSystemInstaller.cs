using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystemInstaller : MonoBehaviour, IInstaller
{
    
    [SerializeField] private int _order = 0; 
    [SerializeField] private InputSystem _inputSystem;

    public int Order => _order;

    public void InstallBindings(GameServices gameServices)
    {
        _inputSystem.Init(gameServices.EventBus);
    }
}
