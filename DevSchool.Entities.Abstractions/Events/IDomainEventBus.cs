namespace DevSchool.Entities.Abstractions.Events;

public interface IDomainEventBus
{
    Task Execute<T>(T domainEvent) where T : IDomainEvent;
}