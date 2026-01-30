public class Resources 
{
    public int  Health { get; }
    public int Mana { get; }
    public int Stamina { get; }
    public int Armor { get; }

    public Resources(int health, int mana, int stamina, int armor)
    {
        Health = health;
        Mana = mana;
        Stamina = stamina;
        Armor = armor;
    }
    public Resources Add(Resources delta)
        => new Resources(Health + delta.Health, Mana + delta.Mana, Stamina + delta.Stamina, Armor + delta.Armor);

    public Resources Sub(Resources delta)
        => new Resources(Health - delta.Health, Mana - delta.Mana, Stamina - delta.Stamina, Armor - delta.Armor);
    public static Resources Zero => new Resources(0, 0, 0, 0);
}
