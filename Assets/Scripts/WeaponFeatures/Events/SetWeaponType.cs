public class SetWeaponType : IEvent
{
    public WeaponType WeaponType { get; }

    public SetWeaponType(WeaponType weaponType)
    {
        WeaponType = weaponType;
    }
}
