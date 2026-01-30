using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AdrenalineBuff", menuName = "Configs/Buffs/AdrenalineBuff")]
public class AdrenalineBuff : BuffConfig
{
    [SerializeField] private int _speedIncrease;
    [SerializeField] private float _duration;


    public override IBuff CreateBuff()
    {
        return new AdrenalineBuffImplementation(_speedIncrease, _duration);
    }
}
