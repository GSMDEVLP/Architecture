using UnityEngine;

public abstract class BuffConfig : ScriptableObject
{
    [SerializeField] private BuffsEnum _buffName;
    public BuffsEnum BuffName => _buffName;

    public abstract IBuff CreateBuff();
}
