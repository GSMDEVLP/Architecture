public interface ITarget
{
    int Health { get; }

    int Armor { get; }
    void TakeDamage(int amount);
}