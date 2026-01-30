
public class Entity : IEntity
{
    protected readonly IStatsOwner _statsOwner;
    protected readonly IResourcesOwner _resourcesOwner;

    public Entity(IStatsOwner statsOwner, IResourcesOwner resourcesOwner)
    {
        _statsOwner = statsOwner;
        _resourcesOwner = resourcesOwner;
    }

    public Resources GetResources() => _resourcesOwner.GetResources();
    public Stats GetStats() => _statsOwner.GetStats();
    
    public void ApplyResourcesModifier(Resources delta)
    {
        _resourcesOwner.ApplyResourcesModifier(delta);
    }

    public void ApplyStatsModifier(Stats delta)
    {
        _statsOwner.ApplyStatsModifier(delta);
    }

    public void RemoveResourcesModifier(Resources delta)
    {
        _resourcesOwner.RemoveResourcesModifier(delta);
    }

    public void RemoveStatsModifier(Stats delta)
    {
        _statsOwner.RemoveStatsModifier(delta);
    }
}
