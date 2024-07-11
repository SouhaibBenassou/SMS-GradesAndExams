using Application.Interfaces;
using AutoMapper;
using Domain.Dtos.ExamDtos;
using MediatR;

namespace Application.Features.Exam.Queries.GetListExamQuery
{
    public class GetListExamQueryHandler(IUnitOfWork uow, IMapper mapper) : IRequestHandler<GetListExamQuery, List<GetListExamDto>>
    {
        private readonly IUnitOfWork _uow = uow;
        private readonly IMapper _mapper = mapper;
        public async Task<List<GetListExamDto>> Handle(GetListExamQuery request, CancellationToken cancellationToken) {
            List<Domain.Exam> exam = (await _uow.ExamRepository.GetAllAsNoTracking()).ToList();
            return _mapper.Map<List<Domain.Dtos.ExamDtos.GetListExamDto>>(exam);
        }
    }
}
