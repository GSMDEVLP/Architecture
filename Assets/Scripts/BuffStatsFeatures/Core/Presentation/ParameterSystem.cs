using UnityEngine;
using Zenject;

public class ParameterSystem : MonoBehaviour
{
    private IEntity _entity;

    public IEntity Entity => _entity;

    [Inject]
    public void Construct(IEntity entity)
    {
        _entity = entity;
    }

    private void Start()
    {
        Debug.Log("PlayerParameterSystem: Accessing Entity Resources and Stats");
        Debug.Log("Resources: " + _entity.GetResources());
        Debug.Log("Stats: " + _entity.GetStats());
    }

    private void Update()
    {
        if (_entity == null) return;

        if (Input.GetMouseButtonDown(0))
        {
            var stats = _entity.GetStats();
            var resources = _entity.GetResources();

            Debug.Log(
                $"[ParameterSystem] Stats => STR:{stats.Strength} AGI:{stats.Agility} INT:{stats.Intelligence}\n" +
                $"[ParameterSystem] Resources => HP:{resources.Health} MP:{resources.Mana} STA:{resources.Stamina} ARM:{resources.Armor}"
            );
        }
    }
}
