using UnityEngine;
using UnityEngine.PlayerLoop;

public class ParameterSystem : MonoBehaviour
{
    private IEntity _entity;

    public IEntity Entity => _entity;
    public void Init(IEntity entity)
    {
        _entity = entity;
    }

    private void Start()
    {
        Debug.Log("PlayerParameterSystem: Accessing Entity Resources and Stats");
        Debug.Log("Resources: " + _entity.GetResources());
        Debug.Log("Stats: " + _entity.GetStats());
    }
}
