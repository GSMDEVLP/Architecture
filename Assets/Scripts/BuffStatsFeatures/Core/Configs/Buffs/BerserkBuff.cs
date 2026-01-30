using UnityEngine;

[CreateAssetMenu(fileName = "BerserkBuff", menuName = "Configs/Buffs/BerserkBuff")]
public class BerserkBuff : BuffConfig
{
    [SerializeField] private float _damageMultiplier;
    [SerializeField] private float _armorReduction;
    [SerializeField] private float _duration;



    public override IBuff CreateBuff()
    {
        return new BerserkBuffImplementation(_damageMultiplier, _armorReduction, _duration);
    }
}
