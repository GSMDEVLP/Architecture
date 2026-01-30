using UnityEngine;

[CreateAssetMenu(fileName = "DirectDamageEffectConfig", menuName = "Combat/Effects/DirectDamage")]
public class DirectDamageEffectConfig : WeaponEffectConfig
{
    [SerializeField] private float damageMultiplier = 1f;

    public override EffectDefinition ToDefinition(int baseDamage)
    {
        int damage = Mathf.RoundToInt(baseDamage * damageMultiplier);
        return new DirectDamageDefinition(damage);
    }
}
