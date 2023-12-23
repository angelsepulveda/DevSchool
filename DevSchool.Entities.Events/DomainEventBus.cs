namespace DevSchool.Entities.Events;

public class DomainEventBus : IDomainEventBus
{
    private readonly IDomainEventHandlerFactory _domainEventHandlerFactory;
    
    public DomainEventBus(IDomainEventHandlerFactory domainEventHandlerFactory)
    {
        _domainEventHandlerFactory = domainEventHandlerFactory;
    }
    
    
    public async Task Execute<T>(T domainEvent) where T : IDomainEvent
    {
        var handlers = _domainEventHandlerFactory.GetHandler<T>();

        await Task.Run(() =>
        {
            foreach (var handler in handlers)
            {
                handler.Handle(domainEvent);
            }
        });

    }
}