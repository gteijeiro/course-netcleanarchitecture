namespace NorthWind.Sales.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUsesCasesService(this IServiceCollection services)
        {
            services.AddScoped<ICreateOrderInputPort, CreateOrderInteractor>();

            return services;
        }
    }
}
