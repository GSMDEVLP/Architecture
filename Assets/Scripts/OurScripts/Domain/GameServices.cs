public class GameServices
{
    public IEventBus EventBus { get; private set; }
    public IEntity Entity { get; set; }
    
    public GameServices()
    {
        EventBus = new EventBus();
    }
}
