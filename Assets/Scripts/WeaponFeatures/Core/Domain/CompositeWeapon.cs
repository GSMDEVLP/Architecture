using System.Collections.Generic;

public sealed class CompositeWeapon : IWeapon
{
    private readonly IReadOnlyList<IWeaponEffect> _effects;

    public int BaseDamage { get; }

    public CompositeWeapon(int baseDamage, IReadOnlyList<IWeaponEffect> effects)
    {
        BaseDamage = baseDamage;
        _effects = effects;
    }

    public void ExecuteAttack(ITarget target)
    {
        foreach (var effect in _effects)
        {
            effect.Apply(target); 
        }
    }
}
    