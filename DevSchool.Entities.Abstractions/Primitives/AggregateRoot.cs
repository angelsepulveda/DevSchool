namespace DevSchool.Entities.Abstractions.Primitives;

public abstract class AggregateRoot : IEventProvider
{
    private readonly List<IDomainEvent> _domainEvents;

    protected AggregateRoot()
    {
        _domainEvents = new List<IDomainEvent>();
    }
    
    public IEnumerable<IDomainEvent> GetUncommitedDomainEvents()
    {
        return _domainEvents;
    }

    public void MarkDomainEventsAsCommited()
    {
        _domainEvents.Clear();
    }
    
    protected void AddDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }
}