public interface IResourcesOwner 
{
    Resources GetResources();
    void ApplyResourcesModifier(Resources delta);
    void RemoveResourcesModifier(Resources delta);
}
