using System.Collections.Generic;

public class WeaponSystem 
{    
    private IWeapon _weapon;
    private IWeaponFactory _weaponFactory;
    public IWeapon Weapon => _weapon;
    
    public WeaponSystem(IWeaponFactory weaponFactory)
    {
        _weaponFactory = weaponFactory;    
    }

    public void Attack(ITarget target)
    {
        if(_weapon == null)
        {
            return;
        }
        _weapon.ExecuteAttack(target);
    }

    public void SetWeapon(WeaponType type)
    {
        _weapon = _weaponFactory.GetWeapon(type);
    }
}
