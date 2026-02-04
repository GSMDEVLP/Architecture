
public class RegenerationBuffImplementation : IBuff
{

    private readonly int _instantHeal;
    private readonly int _duration;
    
    public int Duration => _duration;

    public RegenerationBuffImplementation(int instantHeal, int duration)
    {
        _instantHeal = instantHeal;
        _duration = duration;
    }


    public void Apply(IEntity target)
    {
        target.ApplyResourcesModifier(new Resources(_instantHeal, 0, 0, 0));
    }

    public void Remove(IEntity target)
    {
    }
}
