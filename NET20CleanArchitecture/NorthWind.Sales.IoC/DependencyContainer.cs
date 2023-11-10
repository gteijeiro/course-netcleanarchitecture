namespace NorthWind.Sales.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddNorthWindSalesServices(this IServiceCollection services,
                                            IConfiguration configuration,
                                            string connectionStringName)
        {
            services.AddRepositories(configuration, connectionStringName)
            .AddUsesCasesService()
            .AddPresenters()
            .AddNorthWindSalesControllers();

            return services;
        }
    }
}
