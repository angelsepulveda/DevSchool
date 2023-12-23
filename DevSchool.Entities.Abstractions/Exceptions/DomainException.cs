namespace DevSchool.Entities.Abstractions.Exceptions;

public class DomainException : Exception
{
    protected DomainException() { }

    protected DomainException(string message) : base(message) { }

    protected DomainException(string message, Exception innerException)
        : base(message, innerException) { }
}