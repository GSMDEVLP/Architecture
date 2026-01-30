public interface IStatsOwner
{
    Stats GetStats();
    void ApplyStatsModifier(Stats delta);
    void RemoveStatsModifier(Stats delta);
}
