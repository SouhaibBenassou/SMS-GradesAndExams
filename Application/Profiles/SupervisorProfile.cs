using AutoMapper;
using Domain.Dtos.SupervisorDto;
using Domain.Dtos.SupervisorDtos;
using Domain.Entities;

namespace Application.Mapping
{
    public class MappeingProfile : Profile

    {
        public MappeingProfile()
        {
            CreateMap<CreateSupervisorDto, Supervisor>();
            CreateMap<UpdateSupervisorDTO, Supervisor>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}
