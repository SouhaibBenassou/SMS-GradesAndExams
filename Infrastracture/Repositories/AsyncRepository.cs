using Application.IRepository;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastracture.Repositories
{
    public class AsyncRepository<T> : IAsyncRepository<T> where T : class
    {
        #region Props
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;
        #endregion
        #region Constructor
        public AsyncRepository(ApplicationDbContext db) {
            _db = db;
            dbSet = db.Set<T>();
        }
        #endregion
        #region Methods
        public IQueryable<T> GetAsNoTracking() {
            return dbSet.AsNoTracking();
        }
        public IQueryable<T> GetAsTracking() {
            return dbSet.AsTracking();
        }
        public async Task CreateRangeAsync(ICollection<T> entities) {
            await dbSet.AddRangeAsync(entities);
        }
        public async Task CreateAsync(T entity) {
            await dbSet.AddAsync(entity);
        }
        public async Task<T> GetAsync(Expression<Func<T, bool>> filter = null) {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            return await query.FirstOrDefaultAsync();
        }
        public async Task UpdateAsync(T entity) {
            dbSet.Update(entity);
        }
        public async Task RemoveAsync(T entity) {
            dbSet.Remove(entity);
        }
        #endregion
    }
}


