namespace NorthWind.Sales.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddNorthWindSalesControllers(this IServiceCollection services)
        {
            services.AddScoped<ICreateOrderController, CreateOrderController>();

            return services;
        }
    }
}
