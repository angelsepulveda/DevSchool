using System.ComponentModel.Design;
using DevSchool.Entities.Abstractions.Contracts;
using DevSchool.Entities.Abstractions.Events;
using DevSchool.Entities.Abstractions.Primitives;

namespace DevSchool.Entities.EFCore.Contexts;

public class ApplicationDbContext: DbContext, IApplicationDbContext, IUnitOfWork
{
    private readonly IDomainEventBus _domainEventBus;

    public ApplicationDbContext(DbContextOptions options, IDomainEventBus domainEventBus) : base(options)
    {
        _domainEventBus = domainEventBus;
    }
    
    public DbSet<DocumentType> DocumentTypes { get; set; }
    
    public Task<int> SaveCnangesAsync(CancellationToken cancellationToken = default)
    {
        var domainEvents = ChangeTracker.Entries<AggregateRoot>()
            .Select(e => e.Entity)
            .Where(e => e.GetUncommitedDomainEvents().Any())
            .SelectMany(e => e.GetUncommitedDomainEvents());
        
        var result = base.SaveChangesAsync(cancellationToken);
        
        foreach (var domainEvent in domainEvents)
        {
            var _domainEvent = (dynamic)Convert.ChangeType(domainEvent, domainEvent.GetType());
            
            _domainEventBus.Execute(_domainEvent);
        }

        return result;
    }
}