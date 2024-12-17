using Domain.Entities;

namespace Domain.Interfaces;

public interface IOrderRepository:IGenericRepository<Order>
{
    public Task<Order> Delete(int id);
}
