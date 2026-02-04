public interface IEntityFactory {
    IStatsOwner CreateStatsOwner(Stats stats);
    IResourcesOwner CreateResourcesOwner(Resources resources);
}
