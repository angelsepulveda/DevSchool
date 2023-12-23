namespace DevSchool.Entities.Abstractions.Events;

public interface IDomainEvent
{
    void Commit(AggregateRoot aggregateRoot);
    void BeginTransaction();
    void CommitTransaction();
    void RollbackTransaction();
    void Dispose();
}