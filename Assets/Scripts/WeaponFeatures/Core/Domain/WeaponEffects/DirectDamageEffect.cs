public sealed class DirectDamageEffect : IWeaponEffect
{
    private readonly int _damage;

    public DirectDamageEffect(int damage)
    {
        _damage = damage;
    }

    public void Apply(ITarget target)
    {
        
        target.TakeDamage(_damage);
    }
}
