
using Application.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;

        public Repository(ApplicationDbContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync(
            Expression<Func<T, bool>>? filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            bool asNoTracking = true,
            params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = dbSet;

            if (asNoTracking)
                query = query.AsNoTracking();

            if (filter != null)
                query = query.Where(filter);

            foreach (var include in includes)
                query = query.Include(include);

            if (orderBy != null)
                query = orderBy(query);

            return await query.ToListAsync();
        }

        public async Task<T?> GetAsync(
            Expression<Func<T, bool>> filter,
            bool tracked = true,
            params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = dbSet;

            if (!tracked) query = query.AsNoTracking();

            query = query.Where(filter);

            foreach (var inc in includes)
                query = query.Include(inc);

            return await query.FirstOrDefaultAsync();
        }


        public async Task CreateAsync(T entity)
        {
            await dbSet.AddAsync(entity);
            await SaveAsync();
        }


        public async Task RemoveAsync(T entity)
        {
            dbSet.Remove(entity);
            await SaveAsync();
        }


        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }


        public async Task<List<TResult>> GetAllProjectedAsync<TResult>(
            IConfigurationProvider mapperConfig,
            Expression<Func<T, bool>>? filter = null)
        {
            IQueryable<T> query = dbSet.AsNoTracking();

            if (filter != null)
                query = query.Where(filter);

            return await query
                .ProjectTo<TResult>(mapperConfig)
                .ToListAsync();
        }





        public Task<TResult?> GetProjectedByIdAsync<TResult>(
            IConfigurationProvider mapperConfig,
            Expression<Func<T, bool>>? filter = null)
        {
            IQueryable<T> query = dbSet.AsNoTracking();

            if (filter != null)
                query = query.Where(filter);

            return query
                .ProjectTo<TResult>(mapperConfig)
                .FirstOrDefaultAsync();
        }


    }
}
