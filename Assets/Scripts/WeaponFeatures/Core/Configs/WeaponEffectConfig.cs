using UnityEngine;

public abstract class WeaponEffectConfig : ScriptableObject
{
    public abstract EffectDefinition ToDefinition(int baseDamage);

}
