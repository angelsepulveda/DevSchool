namespace DevScnool.People.BusinessObjects.DocumentTypes.Contracts.Ports.Create;

public interface ICreateDocumentTypeOutputPort
{
    ValueTask Handle(Guid id);
}