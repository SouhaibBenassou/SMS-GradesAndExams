using Application.IRepository;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastracture.Repositories
{
    public class AsyncRepository<T> : IAsyncRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> DbSet;
        public AsyncRepository(ApplicationDbContext db) {
            _db = db;
            this.DbSet = db.Set<T>();
        }
        Task<T> IAsyncRepository<T>.AddAsync(T entity) {
            throw new NotImplementedException();
        }

        Task IAsyncRepository<T>.DeleteAsync(T entity) {
            throw new NotImplementedException();
        }

        Task<T> IAsyncRepository<T>.GetByIdAsync(Guid id) {
            throw new NotImplementedException();
        }

        Task<IReadOnlyList<T>> IAsyncRepository<T>.ListAllAsync() {
            throw new NotImplementedException();
        }

        Task IAsyncRepository<T>.UpdateAsync(T entity) {
            throw new NotImplementedException();
        }
    }
}
