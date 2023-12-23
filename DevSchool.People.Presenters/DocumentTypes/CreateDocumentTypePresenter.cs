namespace DevSchool.People.Presenters.DocumentTypes; 

internal sealed class CreateDocumentTypePresenter : ICreateDocumentTypePresenter
{
    public ValueTask Handle(Guid id)
    {
        DocumentTypeId = id;

        return ValueTask.CompletedTask;
    }

    public Guid DocumentTypeId { get; private set;  }
}