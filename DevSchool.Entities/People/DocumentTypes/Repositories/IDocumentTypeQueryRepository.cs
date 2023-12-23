namespace DevSchool.Entities.People.DocumentTypes.Repositories;

public interface IDocumentTypeQueryRepository
{
   public Task<IReadOnlyList<DocumentType>> GetAll();
   public Task<DocumentType?> GetById(Id id);
}