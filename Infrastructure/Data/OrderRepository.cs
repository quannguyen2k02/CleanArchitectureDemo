using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Data;

public class OrderRepository : GenericRepository<Order>, IOrderRepository
{
    public OrderRepository(ApplicationDbContext context) : base(context)
    {
    }

    public Task<Order> Delete(int id)
    {
        throw new NotImplementedException();
    }
}
