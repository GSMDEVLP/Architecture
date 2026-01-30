public class EntityParametersDefenition 
{
    public Stats Stats { get; }
    public Resources Resources { get; }

    public EntityParametersDefenition(Stats stats, Resources resources)
    {
        Stats = stats;
        Resources = resources;
    }
}