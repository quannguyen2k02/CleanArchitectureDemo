using System.Linq.Expressions;

namespace Domain.Interfaces;

public interface IGenericRepository<T> where T : class
{
    public Task<T> GetByIdAsync(int id);
    public Task<List<T>> GetAll();
    public Task<List<T>> Find(Expression<Func<T, bool>> predicate);
    public Task<T> Add(T entity);
    public T Update(T entity);
}
