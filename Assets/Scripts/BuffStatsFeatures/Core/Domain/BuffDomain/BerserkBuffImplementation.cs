public class BerserkBuffImplementation : IBuff
{
    private readonly int _damageMultiplier;
    private readonly int _armorReduction;
    private readonly int _duration;

    public int Duration => _duration;
    public BerserkBuffImplementation(int damageMultiplier, int armorReduction, int duration)
    {
        _damageMultiplier = damageMultiplier;
        _armorReduction = armorReduction;
        _duration = duration;
    }


    public void Apply(IEntity target)
    {
        target.ApplyStatsModifier(new Stats(_damageMultiplier, 0, 0));
        target.ApplyResourcesModifier(new Resources(0, 0, 0, -_armorReduction));
    }

    public void Remove(IEntity target)
    {
        target.RemoveStatsModifier(new Stats(_damageMultiplier, 0, 0));
        target.RemoveResourcesModifier(new Resources(0, 0, 0, -_armorReduction));
    }
}

    