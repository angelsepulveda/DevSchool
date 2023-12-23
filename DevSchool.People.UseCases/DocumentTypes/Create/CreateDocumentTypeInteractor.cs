namespace DevSchool.People.UseCases.DocumentTypes.Create;

internal sealed class CreateDocumentTypeInteractor : ICreateDocumentTypeInputPort
{ 
    private readonly IDocumentTypeCommandRepository _commandRepository;
    private readonly ICreateDocumentTypeOutputPort _outputPort;
    private readonly IUnitOfWork _unitOfWork;
    
    public CreateDocumentTypeInteractor(
        IDocumentTypeCommandRepository commandRepository, 
        ICreateDocumentTypeOutputPort outputPort,
        IUnitOfWork unitOfWork)
    {
        _commandRepository = commandRepository;
        _outputPort = outputPort;
        _unitOfWork = unitOfWork;
    }
    
    public async ValueTask Handle(CreateDocumentTypeDTO dto)
    {
        var documentType = DocumentType.Create(dto.Name, dto.Description);
        
        _commandRepository.Add(documentType);

        var result = await _unitOfWork.SaveCnangesAsync();
        
        if(result <= 0)
        {
            throw new Exception("Error saving document type");
        }

        await _outputPort.Handle(documentType.Id.Value);
    }
}