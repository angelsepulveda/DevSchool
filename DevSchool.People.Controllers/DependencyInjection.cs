namespace DevSchool.People.Controllers;

public static class DependencyInjection
{
    public static IServiceCollection AddPeopleControllers(this IServiceCollection services)
    {
        services.AddDocumentTypesControllers();
        
        return services;
    }
    
    private static IServiceCollection AddDocumentTypesControllers(this IServiceCollection services)
    {
        services.AddScoped<ICreateDocumentTypeController,CreateDocumentTypeController>();
        
        return services;
    }
}