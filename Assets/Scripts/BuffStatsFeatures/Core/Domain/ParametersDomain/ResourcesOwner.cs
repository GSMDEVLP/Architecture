public class ResourcesOwner : IResourcesOwner
{
    private readonly Resources _baseResources;
    private Resources _mods;

    public ResourcesOwner(Resources baseResources)
    {
        _baseResources = baseResources;
        _mods = Resources.Zero;
    }

    public Resources GetResources() => _baseResources.Add(_mods);

    public void ApplyResourcesModifier(Resources delta) => _mods = _mods.Add(delta);
    public void RemoveResourcesModifier(Resources delta) => _mods = _mods.Sub(delta);
}
