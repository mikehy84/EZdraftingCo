using AutoMapper;
using System.Linq.Expressions;

namespace Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(

            Expression<Func<T, bool>>? filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            bool asNoTracking = true,
            params Expression<Func<T, object>>[] includes);

        Task<T?> GetAsync(
            Expression<Func<T, bool>> filter,
            bool tracked = true,
            params Expression<Func<T, object>>[] includes
        );

        Task CreateAsync(T entity);
        Task RemoveAsync(T entity);
        Task SaveAsync();


        Task<List<TResult>> GetAllProjectedAsync<TResult>(
            IConfigurationProvider mapperConfig, 
            Expression<Func<T, bool>>? filter = null);


        Task<TResult?> GetProjectedByIdAsync<TResult>(
            IConfigurationProvider mapperConfig,
            Expression<Func<T, bool>> filter
        );
    }
}
