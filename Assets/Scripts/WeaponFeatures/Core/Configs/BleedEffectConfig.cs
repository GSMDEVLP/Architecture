using UnityEngine;

[CreateAssetMenu(fileName = "BleedEffectConfig",menuName = "Combat/Effects/Bleed")]
public class BleedEffectConfig : WeaponEffectConfig
{
    [SerializeField] private int tickDamage = 2;
    [SerializeField] private int ticks = 3;

    public override EffectDefinition ToDefinition(int baseDamage)
    {
        return new BleedDefinition(tickDamage, ticks);
    }
}
