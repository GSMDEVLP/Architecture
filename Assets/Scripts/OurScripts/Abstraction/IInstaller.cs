public interface IInstaller
{
    int Order { get; }
    void InstallBindings(GameServices gameServices);
}  

