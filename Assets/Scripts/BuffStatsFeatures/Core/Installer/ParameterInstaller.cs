using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParameterInstaller : MonoBehaviour, IInstaller
{
    [SerializeField] private int _order = 0; 
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
        _entityFactory = new EntityFactory(entityParametersDefenition);
        _resourcesOwner = _entityFactory.CreateResourcesOwner();
        _statsOwner = _entityFactory.CreateStatsOwner(); 
        _entity = new Entity(_statsOwner, _resourcesOwner);

        _parameterSystem.Init(_entity);
    }
}
