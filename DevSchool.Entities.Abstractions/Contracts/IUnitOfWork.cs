namespace DevSchool.Entities.Abstractions.Contracts;

public interface IUnitOfWork
{
    Task<int> SaveCnangesAsync(CancellationToken cancellationToken = default);
}