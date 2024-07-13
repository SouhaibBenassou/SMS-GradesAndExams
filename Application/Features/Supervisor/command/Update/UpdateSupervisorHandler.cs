using Application.Interfaces;
using Application.IRepository;
using AutoMapper;
using MediatR;


namespace Application.Features.Supervisor.Commands.Update
{
    public class UpdateSupervisorHandler : IRequestHandler<UpdateSupervisorCommand, Unit>
    {
        private readonly ISupervisorRepository _supervisorRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public UpdateSupervisorHandler(ISupervisorRepository supervisorRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _supervisorRepository = supervisorRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateSupervisorCommand request, CancellationToken cancellationToken)
        {
            var supervisor = await _supervisorRepository.GetAsTracking(x => x.Id == request.Supervisor.Id);
            if (supervisor == null)
            {
                throw new KeyNotFoundException("Supervisor not found");
            }

            // Map the changes from the DTO to the entity
            _mapper.Map(request.Supervisor, supervisor);

            await _supervisorRepository.UpdateAsync(supervisor);
            await _unitOfWork.CommitAsync();

            return Unit.Value;
        }

    }
}
