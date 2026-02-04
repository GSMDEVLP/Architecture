using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParameterInstaller : MonoBehaviour, IInstaller
{
    [SerializeField] private int _order; 
    [SerializeField] private ParameterSystem _parameterSystem;

    [SerializeField] private EntityParameters _entityParameters;

    private IResourcesOwner _resourcesOwner;
    private IStatsOwner _statsOwner;
    private IEntityFactory _entityFactory;
    private EntityConfigAdapter _entityConfigAdapter;
    private IEntity _entity;

    public int Order => _order;

    public void InstallBindings(GameServices gameServices)
    {
        _entityConfigAdapter = new EntityConfigAdapter();
        var entityParametersDefenition = _entityConfigAdapter.ToDefenition(_entityParameters);
        _entityFactory = new EntityFactory();
        _resourcesOwner = _entityFactory.CreateResourcesOwner(entityParametersDefenition.Resources);
        _statsOwner = _entityFactory.CreateStatsOwner(entityParametersDefenition.Stats); 
        _entity = new Entity(_statsOwner, _resourcesOwner);

        gameServices.Entity = _entity;
        _parameterSystem.Init(_entity);
    }
}
