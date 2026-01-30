
public class EntityFactory : IEntityFactory
{
    private Resources resources;
    private Stats stats;
    public EntityFactory(EntityParametersDefenition entityParametersDefenition)
    {
        resources = entityParametersDefenition.Resources;
        stats = entityParametersDefenition.Stats;
    }
    public IResourcesOwner CreateResourcesOwner()
    {
        return new ResourcesOwner(resources);
    }

    public IStatsOwner CreateStatsOwner()
    {
        return new StatsOwner(stats);
    }
}
