using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Data;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<Product> Delete(int id)
    {
        var product = await _context.Products.FindAsync(id);
        if (product == null) throw new KeyNotFoundException($"Product with Id {id} not found.");
        return product;
    }
}
