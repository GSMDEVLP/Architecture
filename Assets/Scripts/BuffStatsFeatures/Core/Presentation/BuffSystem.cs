using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class BuffSystem : MonoBehaviour
{
    private BuffService _buffService;

    [Inject]
    public void Construct(BuffService buffService)
    {
        _buffService = buffService;
    }
    
    private void Start()
    {
        ApplyTimed(BuffsEnum.Berserk);
    }

    public void ApplyTimed(BuffsEnum buffName)
    {
        if (_buffService == null)
        {
            Debug.LogError("BuffSystem: not initialized.");
            return;
        }
        Debug.Log($"[BuffSystem] ApplyTimed requested: {buffName}");
        StartCoroutine(Run(buffName));
    }

    private IEnumerator Run(BuffsEnum buffName)
    {
        _buffService.Apply(buffName);
        int duration = _buffService.GetBuffDuration(buffName);
        Debug.Log($"[BuffSystem] Buff {buffName} applied. Duration: {duration}s");

        yield return new WaitForSeconds(duration);
        _buffService.Remove(buffName);
    }
}
