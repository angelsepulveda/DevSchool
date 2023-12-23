namespace DevSchool.People.UseCases;

public static class DepedencyInjection
{
    public static IServiceCollection AddPeopleUseCases(this IServiceCollection services)
    {
        services.AddDocumentTypesUseCases();
        
        return services;
    }
    
    private static IServiceCollection AddDocumentTypesUseCases(this IServiceCollection services)
    {
        services.AddScoped<ICreateDocumentTypeInputPort, CreateDocumentTypeInteractor>();
        
        return services;
    }
}