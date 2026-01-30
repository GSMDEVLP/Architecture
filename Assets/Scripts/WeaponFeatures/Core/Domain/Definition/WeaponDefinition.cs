    using System.Collections.Generic;

public sealed class WeaponDefinition
{
    public WeaponType Type { get; }
    public int BaseDamage { get; }
    public IReadOnlyList<EffectDefinition> Effects { get; }

    public WeaponDefinition(WeaponType type, int baseDamage, IReadOnlyList<EffectDefinition> effects)
    {
        Type = type;
        BaseDamage = baseDamage;
        Effects = effects;
    }
}
