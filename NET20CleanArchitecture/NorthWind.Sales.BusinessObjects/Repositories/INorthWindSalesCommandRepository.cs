namespace NorthWind.Sales.BusinessObjects.Repositories
{
    public interface INorthWindSalesCommandRepository : IUnitOfWork
    {
        ValueTask CreateOrder(OrderAggregate order);
    }
}
