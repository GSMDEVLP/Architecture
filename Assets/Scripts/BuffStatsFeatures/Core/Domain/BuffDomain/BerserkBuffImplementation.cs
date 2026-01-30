
using System.Data;

public class BerserkBuffImplementation : IBuff
{
    private readonly float _damageMultiplier;
    private readonly float _armorReduction;
    private readonly float _duration;

    public BerserkBuffImplementation( float damageMultiplier, float armorReduction, float duration)
    {
        _damageMultiplier = damageMultiplier;
        _armorReduction = armorReduction;
        _duration = duration;
    } 


    public void Apply(IEntity target)
    {
        throw new System.NotImplementedException();
    }

    public void Remove(IEntity target)
    {
        throw new System.NotImplementedException();
    }
}

