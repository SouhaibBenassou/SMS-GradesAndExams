using Application.Interfaces;
using Infrastructure.Data;
namespace Infrastracture;


public class UnitOfWork(ApplicationDbContext db) : IUnitOfWork
{
    private readonly ApplicationDbContext _db = db;


    #region Methods
    public void Commit() {
        _db.SaveChanges();
    }

    public async Task CommitAsync() {
        await _db.SaveChangesAsync();
    }

    public void Rollback() {
        _db.SaveChanges();
    }

    public async Task RollbackAsync() {
        await _db.SaveChangesAsync();
    }
    #endregion

}
