using Application.Interfaces;
using Application.IServices;
using AutoMapper;

namespace Application.Services
{
    public class UnitOfService : IUnitOfService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public IGradeService GradeService { get; set; }
        public IExamService ExamService { get; set; }

        public UnitOfService(IMapper mapper, IUnitOfWork uow, IGradeService gradeService, IExamService examService) {
            _mapper = mapper;
            _uow = uow;
            GradeService = gradeService;
            ExamService = examService;
        }
    }
}
