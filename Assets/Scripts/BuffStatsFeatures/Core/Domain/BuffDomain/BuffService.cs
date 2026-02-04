using System.Collections.Generic;
using System.Data;

public class BuffService
{
    private readonly IEntity _target;
    private readonly Dictionary<BuffsEnum, IBuff> _buffs = new();

    public BuffService(IEntity target, Dictionary<BuffsEnum, IBuff> buffs)
    {
        _target = target;
        _buffs = buffs;
    }

    public void Apply(BuffsEnum buffName)
    {
        if (_buffs.TryGetValue(buffName, out IBuff buff))
        {
            buff.Apply(_target);
        }
    }

    public void Remove(BuffsEnum buffName)
    {
        if (_buffs.TryGetValue(buffName, out IBuff buff))
        {
            buff.Remove(_target);
        }
    }

    public int GetBuffDuration(BuffsEnum buffName)
    {
        if (_buffs.TryGetValue(buffName, out IBuff buff))
        {
            return buff.Duration;
        }
        return 0;
    }
}
