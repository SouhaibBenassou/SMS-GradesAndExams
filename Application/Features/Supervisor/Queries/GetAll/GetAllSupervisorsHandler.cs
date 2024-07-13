using Application.IRepository;
using MediatR;


namespace Application.Features.Supervisor.Queries
{
    public class GetAllSupervisorsHandler : IRequestHandler<GetAllSupervisorsQuery, List<Domain.Entities.Supervisor>>
    {
        private readonly ISupervisorRepository _supervisorRepository;

        public GetAllSupervisorsHandler(ISupervisorRepository supervisorRepository)
        {
            _supervisorRepository = supervisorRepository;
        }

        public async Task<List<Domain.Entities.Supervisor>> Handle(GetAllSupervisorsQuery request, CancellationToken cancellationToken)
        {
            return await _supervisorRepository.GetAllAsNoTracking();
        }
    }
}
