namespace DevSchool.Entities.Events;

public static class DepencencyInjection
{
    public static IServiceCollection AddDomainEvents(this IServiceCollection services)
    {
        services.AddSingleton<IDomainEventBus, DomainEventBus>();
        services.AddSingleton<IDomainEventHandlerFactory, DomainEventHandlerFactory>();
        
        return services;
    }
}