namespace DevSchool.Entities.People.DocumentTypes.Repositories;

public interface IDocumentTypeCommandRepository
{
    public void Add(DocumentType documentType);
    public void Update(DocumentType documentType);
}