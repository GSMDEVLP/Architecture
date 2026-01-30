using System;

public class AdrenalineBuffImplementation : IBuff
{
    private readonly int _agilityBonus;
    private readonly float _duration;
    private Stats _stats;
    private Resources _resources;

    public AdrenalineBuffImplementation(int agilityBonus, float duration)
    {
        _agilityBonus = agilityBonus;
        _duration = duration;
    }

    public void Apply(IEntity target)
            => target.ApplyStatsModifier(new Stats(0, _agilityBonus, 0));

    public void Remove(IEntity target)
            => target.RemoveStatsModifier(new Stats(0, _agilityBonus, 0));

}
