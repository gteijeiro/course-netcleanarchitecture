namespace NorthWind.EFCore.Repositories.Repositories
{
    public class NorthWindSalesCommandRepository : INorthWindSalesCommandRepository
    {
        readonly NorthWindSalesContext Context;

        public NorthWindSalesCommandRepository(NorthWindSalesContext context)
        {
            Context = context;
        }

        public async ValueTask CreateOrder(OrderAggregate order)
        {
            await Context.AddAsync(order);
            foreach (var item in order.OrderDetails)
            {
                await Context.AddAsync(new OrderDetail
                {
                    Order = order,
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice
                });
            }
        }

        public async ValueTask SaveChanges()
        {
            await Context.SaveChangesAsync();
        }
    }
}
