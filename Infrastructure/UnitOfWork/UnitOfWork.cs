using Domain.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.UnitOfWork;

public class UnitOfWork:IUnitOfWork
{
    private readonly ApplicationDbContext _context;
    public IProductRepository Products { get; private set; }
    public IOrderRepository Orders { get; private set; }

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
        Products = new ProductRepository(_context);
        Orders = new OrderRepository(_context);
    }

    public async Task<int> Complete()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
