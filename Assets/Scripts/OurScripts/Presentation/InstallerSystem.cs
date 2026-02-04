using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstallerSystem : MonoBehaviour
{
    [SerializeField] private MonoBehaviour[] _installersMonoBehaviours;
    private GameServices _gameServices;

    void Awake()
    {
        _gameServices = new GameServices();
        InstallBindings(_gameServices);
    }
    public void InstallBindings(GameServices gameServices)
    {
        var installers = new List<IInstaller>();
        foreach (var m in _installersMonoBehaviours)
            if (m is IInstaller i) installers.Add(i);

        installers.Sort((a,b) => a.Order.CompareTo(b.Order));

        foreach (var installer in installers)
        {
            installer.InstallBindings(gameServices);
            Debug.LogWarning($"MonoBehaviour {installer.GetType().Name} does not implement IInstaller.");
        }
    }
}
