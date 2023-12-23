using DevScnool.People.BusinessObjects.DocumentTypes.Contracts.Controllers;
using DevScnool.People.BusinessObjects.DocumentTypes.Contracts.Ports.Create;
using DevScnool.People.BusinessObjects.DocumentTypes.Contracts.Presenters;
using DevScnool.People.BusinessObjects.DocumentTypes.DTOs;

namespace DevSchool.People.Controllers.DocumentTypes;

public class CreateDocumentTypeController : ICreateDocumentTypeController
{
    private readonly ICreateDocumentTypeInputPort _inputPort;
    private readonly ICreateDocumentTypePresenter _presenter;
    
    public CreateDocumentTypeController(
        ICreateDocumentTypeInputPort inputPort, 
        ICreateDocumentTypePresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<Guid> Handle(CreateDocumentTypeDTO dto)
    {
        await _inputPort.Handle(dto);

        return _presenter.DocumentTypeId;
    }
}