
public class Target : ITarget
{
    public int Health { get; private set; }

    public int Armor { get; private set; }

    public Target(int health, int armor)
    {
        Health = health;
        Armor = armor;
    }

    public void TakeDamage(int amount)
    {
        Health -= amount;
        if (Health <= 0)
            Health = 0; 
    }
}
