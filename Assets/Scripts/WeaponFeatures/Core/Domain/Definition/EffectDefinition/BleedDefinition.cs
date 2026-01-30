public sealed class BleedDefinition : EffectDefinition
{
    private readonly int _tickDamage;
    private readonly int _ticks;

    public BleedDefinition(int tickDamage, int ticks)
    {
        _tickDamage = tickDamage;
        _ticks = ticks;
    }

    public override IWeaponEffect CreateEffect() => new BleedEffect(_tickDamage, _ticks);
}
