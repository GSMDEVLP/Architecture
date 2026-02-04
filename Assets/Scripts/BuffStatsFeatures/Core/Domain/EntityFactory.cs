
public class EntityFactory : IEntityFactory
{
    public IResourcesOwner CreateResourcesOwner(Resources resources)
    {
        return new ResourcesOwner(resources);
    }

    public IStatsOwner CreateStatsOwner(Stats stats)
    {
        return new StatsOwner(stats);
    }
}
