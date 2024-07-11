using Application.IRepository;
using Domain;
using Infrastructure.Data;

namespace Infrastracture.Repositories
{
    public class ExamRepository : AsyncRepository<Exam>, IExamRepository
    {
        public ExamRepository(ApplicationDbContext context) : base(context) { }
    }
}
