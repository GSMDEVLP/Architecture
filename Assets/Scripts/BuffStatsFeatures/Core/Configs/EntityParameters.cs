using UnityEngine;

[CreateAssetMenu(fileName = "EntityParameters", menuName = "Entity/EntityParameters", order = 0)]
public class EntityParameters : ScriptableObject
{
    [SerializeField] private StatsConfig  _stats;
    [SerializeField] private ResourcesConfig  _resources;

    public StatsConfig Stats => _stats;
    public ResourcesConfig Resources => _resources;
    
}
