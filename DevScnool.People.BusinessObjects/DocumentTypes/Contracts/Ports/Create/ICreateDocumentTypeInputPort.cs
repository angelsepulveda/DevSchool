namespace DevScnool.People.BusinessObjects.DocumentTypes.Contracts.Ports.Create;

public interface ICreateDocumentTypeInputPort
{
    ValueTask Handle(CreateDocumentTypeDTO dto);
}