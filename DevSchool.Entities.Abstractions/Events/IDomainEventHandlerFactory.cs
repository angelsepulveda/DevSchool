namespace DevSchool.Entities.Abstractions.Events;

public interface IDomainEventHandlerFactory
{
    IEnumerable<IDomainEventHandler<T>> GetHandler<T>() where T : IDomainEvent;
}