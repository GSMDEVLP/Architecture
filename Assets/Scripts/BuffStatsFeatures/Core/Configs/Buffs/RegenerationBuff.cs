using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RegenerationBuff", menuName = "Configs/Buffs/RegenerationBuff")]
public class RegenerationBuff : BuffConfig
{
    [SerializeField] private int _instantHeal;
    [SerializeField] private int _duration;

    public override IBuff CreateBuff()
    {
        return new RegenerationBuffImplementation(_instantHeal, _duration);
    }
}
