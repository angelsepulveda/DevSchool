namespace DevSchool.Entities.Abstractions.Events;

public interface IEventProvider
{
    IEnumerable<IDomainEvent> GetUncommitedDomainEvents();
    void MarkDomainEventsAsCommited();
}