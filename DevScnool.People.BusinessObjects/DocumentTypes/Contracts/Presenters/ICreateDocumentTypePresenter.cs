namespace DevScnool.People.BusinessObjects.DocumentTypes.Contracts.Presenters;

public interface ICreateDocumentTypePresenter : ICreateDocumentTypeOutputPort
{
    Guid DocumentTypeId { get; }
}