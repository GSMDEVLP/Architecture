using UnityEngine;

public class InputSystem : MonoBehaviour
{   
    private IEventBus _bus;
   
    public void Init(IEventBus bus)
    {
        _bus = bus;
    }

    void Update()
    {
        SetWeaponType();
        SetAttack();
    }

    private void SetAttack()
    {
        if (Input.GetMouseButtonDown(0)) 
            _bus.Invoke(new SetAttack());
    }

    private void SetWeaponType()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)) 
            _bus.Invoke(new SetWeaponType(WeaponType.Sword));
        if(Input.GetKeyDown(KeyCode.Alpha2))
            _bus.Invoke(new SetWeaponType(WeaponType.Bow));
        if(Input.GetKeyDown(KeyCode.Alpha3))
            _bus.Invoke(new SetWeaponType(WeaponType.Axe));
        if(Input.GetKeyDown(KeyCode.Alpha4)) 
            _bus.Invoke(new SetWeaponType(WeaponType.Blade));
    }
}
