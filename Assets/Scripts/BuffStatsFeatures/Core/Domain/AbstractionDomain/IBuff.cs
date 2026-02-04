public interface IBuff 
{
    int Duration { get; }
    public void Apply(IEntity target);
    public void Remove(IEntity target);
}
