public class StatsOwner : IStatsOwner
{
    private Stats _stats;
    private Stats _mods;

    public StatsOwner(Stats stats)
    {
        _stats = stats;
        _mods = Stats.Zero;
    }

    public Stats GetStats()
    {
        return _stats.Add(_mods);
    }
    public void ApplyStatsModifier(Stats delta) => _mods = _mods.Add(delta);
    public void RemoveStatsModifier(Stats delta) => _mods = _mods.Sub(delta);

}
