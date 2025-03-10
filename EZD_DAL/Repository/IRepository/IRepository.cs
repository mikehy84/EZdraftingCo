using System.Linq.Expressions;

namespace EZD_DAL.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, string? includedProps = null);
        Task<T> GetAsync(Expression<Func<T, bool>>? filter, bool tracked = true, string? includedProps = null);
        Task CreateAsync(T entity);
        Task RemoveAsync(T entity);
        Task SaveAsync();
    }
}
