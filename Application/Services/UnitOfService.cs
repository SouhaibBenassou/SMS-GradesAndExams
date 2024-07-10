using Application.Interfaces;
using Application.IServices;
using AutoMapper;

namespace Application.Services
{
    public class UnitOfService : IUnitOfService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;
        public IGradeService gradeService { get; private set; }

        public IGradeService GradeService => throw new NotImplementedException();

        public UnitOfService(IMapper mapper, IUnitOfWork uow, IGradeService gradeService) {
            _mapper = mapper;
            _uow = uow;
            this.gradeService = gradeService;
        }
    }
}
