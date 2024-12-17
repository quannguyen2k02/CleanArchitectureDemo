using Domain.Entities;

namespace Domain.Interfaces;

public interface IProductRepository:IGenericRepository<Product>
{
    public Task<Product> Delete(int id);
}
