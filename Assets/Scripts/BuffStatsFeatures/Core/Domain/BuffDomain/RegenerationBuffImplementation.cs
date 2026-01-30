
public class RegenerationBuffImplementation : IBuff
{
    private readonly float _healingPerSecond;
    private readonly float _duration;

    public RegenerationBuffImplementation(float healingPerSecond, float duration)
    {
        _healingPerSecond = healingPerSecond;
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
