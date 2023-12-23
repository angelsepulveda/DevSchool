using DevSchool.Entities.People.DocumentTypes.Exceptions;

namespace DevSchool.Entities.People.DocumentTypes;

public class DocumentType : Entity
{
    public Id Id { get; private set; } = null!;
    public string Name { get; private set; } = null!;
    public string? Description { get; private set; }
    public Status Status { get; private set; } = null!;

    private DocumentType(Id id, string name, string? description, Status status)
    {
        Id = id;
        Name = name;
        Description = description;
        Status = status;
    }

    public DocumentType()
    {
        
    }

    public static DocumentType Create(string name, string? description)
    {
        return new DocumentType(new Id(Guid.NewGuid()), name, description, new Status(true));
    }

    public void Update(string name, string? description)
    {
        if (!Name.Equals(name)) Name = name;

        if (Description == null || !Description.Equals(description)) Description = description;
    }

    public void Delete()
    {
        if (Status.Value == false)
        {
            throw new DocumentTypeDeletedException();
        }
        
        Status = new Status(false);
    }

    public void Recover()
    {
        if (Status.Value == true)
        {
            throw new DocumentTypeDeletedException();
        }
        
        Status = new Status(true);
    }
}