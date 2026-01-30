public sealed class BleedEffect : IWeaponEffect
{
    private readonly int _tickDamage;
    private readonly int _ticks;

    public BleedEffect(int tickDamage, int ticks)
    {
        _tickDamage = tickDamage;
        _ticks = ticks;
    }

    public void Apply(ITarget target)
    {
        int total = _tickDamage * _ticks;
        target.TakeDamage(total);
    }
}
