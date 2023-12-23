namespace DevSchool.Entities.People.DocumentTypes.Exceptions;

public class DocumentTypeRecoveryException : DomainException
{
    public DocumentTypeRecoveryException() : base("El tipo de documento ya se encuentra activo"){}
}