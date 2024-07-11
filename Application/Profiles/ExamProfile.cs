using AutoMapper;
using Domain;
using Domain.Dtos.ExamDtos;

namespace Application.Profiles
{
    public class ExamProfile : Profile

    {
        public ExamProfile() {
            CreateMap<Exam, GetListExamDto>().ReverseMap();
            CreateMap<GetListExamDto, GetListSessionsDto>().ReverseMap();
            CreateMap<GetListSessionsDto, GetListSupervisorDto>().ReverseMap();
            CreateMap<GetListSessionsDto, GetListRoomDto>().ReverseMap();

        }
    }
}
