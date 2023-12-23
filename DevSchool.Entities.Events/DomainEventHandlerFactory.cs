namespace DevSchool.Entities.Events;

public class  DomainEventHandlerFactory : IDomainEventHandlerFactory
{
    private readonly IServiceProvider _serviceProvider;
    
    public DomainEventHandlerFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }
    
    public IEnumerable<IDomainEventHandler<T>> GetHandler<T>() where T : IDomainEvent
    {
        return _serviceProvider.GetService<IEnumerable<IDomainEventHandler<T>>>();
    }
}