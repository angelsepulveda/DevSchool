namespace DevSchool.Entities.People.DocumentTypes.Exceptions;

public class DocumentTypeDeletedException : DomainException
{
    public DocumentTypeDeletedException() : base("El Tipo de Documento ya se encuentra eliminado"){}
}