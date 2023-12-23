namespace DevSchool.People.Presenters;

public static class DependencyInjection
{
    public static IServiceCollection AddPeoplePresenters(this IServiceCollection services)
    {
        services.AddDocumentTypesPresenters();
        
        return services;
    }
    
    private static IServiceCollection AddDocumentTypesPresenters(this IServiceCollection services)
    {
        services.AddScoped<CreateDocumentTypePresenter>();
        services.AddScoped<ICreateDocumentTypePresenter>(provider => provider.GetRequiredService<CreateDocumentTypePresenter>());
        services.AddScoped<ICreateDocumentTypeOutputPort>(provider => provider.GetRequiredService<CreateDocumentTypePresenter>());
        
        return services;
    }
}