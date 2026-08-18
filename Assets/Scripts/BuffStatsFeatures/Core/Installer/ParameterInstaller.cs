using System;
using UnityEngine;
using Zenject;

public class ParameterInstaller : MonoInstaller
{
    [SerializeField] private EntityParameters _entityParameters;

    
    public override void InstallBindings()
    {
        EntityParametersDefenition defs = SetDTO();
        Container.BindInstance(defs.Stats);
        Container.BindInstance(defs.Resources);
        Container.Bind<IStatsOwner>().To<StatsOwner>().AsSingle();
        Container.Bind<IResourcesOwner>().To<ResourcesOwner>().AsSingle();
        Container.Bind<IEntity>().To<Entity>().AsSingle();
    }

    private EntityParametersDefenition SetDTO()
    {
        EntityConfigAdapter _entityConfigAdapter = new EntityConfigAdapter();
        var entityParametersDefenition = _entityConfigAdapter.ToDefenition(_entityParameters);
        return entityParametersDefenition;
    }
}
