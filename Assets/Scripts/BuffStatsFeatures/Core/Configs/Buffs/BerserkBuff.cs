using UnityEngine;

[CreateAssetMenu(fileName = "BerserkBuff", menuName = "Configs/Buffs/BerserkBuff")]
public class BerserkBuff : BuffConfig
{
    [SerializeField] private int _damageMultiplier;
    [SerializeField] private int _armorReduction;
    [SerializeField] private int _duration;


    public override IBuff CreateBuff()
    {
        return new BerserkBuffImplementation(_damageMultiplier, _armorReduction, _duration);
    }
}
