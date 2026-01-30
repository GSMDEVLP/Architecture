using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RegenerationBuff", menuName = "Configs/Buffs/RegenerationBuff")]
public class RegenerationBuff : BuffConfig
{
    [SerializeField] private float _healingPerSecond;
    [SerializeField] private float _duration;

    public override IBuff CreateBuff()
    {
        return new RegenerationBuffImplementation(_healingPerSecond, _duration);
    }
}
