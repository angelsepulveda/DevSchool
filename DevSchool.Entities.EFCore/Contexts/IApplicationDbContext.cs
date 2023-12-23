namespace DevSchool.Entities.EFCore.Contexts;

public interface IApplicationDbContext
{
    DbSet<DocumentType> DocumentTypes { get; set; }
    
}