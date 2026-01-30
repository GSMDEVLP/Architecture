public class Stats
{
    public int Strength {get;}
    public int Agility {get;}
    public int Intelligence {get;}

    public Stats(int strength, int agility, int intelligence)
    {
        Strength = strength;
        Agility = agility;
        Intelligence = intelligence;
    }

    public Stats Add(Stats delta)
        => new Stats(Strength + delta.Strength, Agility + delta.Agility, Intelligence + delta.Intelligence);

    public Stats Sub(Stats delta)
        => new Stats(Strength - delta.Strength, Agility - delta.Agility, Intelligence - delta.Intelligence);

    public static Stats Zero => new Stats(0, 0, 0);
}
