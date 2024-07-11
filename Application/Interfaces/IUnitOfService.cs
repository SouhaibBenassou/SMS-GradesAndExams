using Application.IServices;

namespace Application.Interfaces
{
    public interface IUnitOfService
    {
        IGradeService GradeService { get; set; }
        IExamService ExamService { get; set; }
    }
}
