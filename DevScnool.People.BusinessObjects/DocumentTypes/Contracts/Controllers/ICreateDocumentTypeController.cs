namespace DevScnool.People.BusinessObjects.DocumentTypes.Contracts.Controllers;

public interface ICreateDocumentTypeController
{
    ValueTask<Guid> Handle(CreateDocumentTypeDTO dto);
}