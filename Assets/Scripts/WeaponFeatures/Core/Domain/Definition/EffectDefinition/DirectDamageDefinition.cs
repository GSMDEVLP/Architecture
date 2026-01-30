public sealed class DirectDamageDefinition : EffectDefinition
{
    private readonly int _damage;

    public DirectDamageDefinition(int damage)
    {
        _damage = damage;
    }

    public override IWeaponEffect CreateEffect() => new DirectDamageEffect(_damage);
}