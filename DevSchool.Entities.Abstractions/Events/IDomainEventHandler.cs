namespace DevSchool.Entities.Abstractions.Events;

public interface IDomainEventHandler<T> where T : IDomainEvent
{
    void Handle(T domainEvent);
}