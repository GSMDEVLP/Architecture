using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffSystem : MonoBehaviour
{
    private IEntity _entity;

    private Dictionary<string, IBuff> _buffs = new();

    public void Init(IEntity entity, Dictionary<string, IBuff> buffs)
    {
        _entity = entity;
        _buffs = buffs;
    }

    public void ApplyTimedBuff(IBuff buff, float duration)
    {
        buff.Apply(_entity);
        StartCoroutine(RemoveAfter(buff, duration));
    }

    private IEnumerator RemoveAfter(IBuff buff, float duration)
    {
        yield return new WaitForSeconds(duration);
        buff.Remove(_entity);
    }
}
