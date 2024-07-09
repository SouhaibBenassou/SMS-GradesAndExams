using Application.IRepository;
using Domain;
using Infrastructure.Data;

namespace Infrastracture.Repositories
{
    public class GradeRepository : AsyncRepository<Grade>, IGradeRepository
    {
        public GradeRepository(ApplicationDbContext db) : base(db) {
        }
    }
}
