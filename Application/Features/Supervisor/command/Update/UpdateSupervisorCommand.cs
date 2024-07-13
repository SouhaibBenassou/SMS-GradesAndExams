using Domain.Dtos.SupervisorDtos;
using MediatR;
using System;


namespace Application.Features.Supervisor.Commands.Update
{
    public class UpdateSupervisorCommand : IRequest<Unit>
    {
        public UpdateSupervisorDTO Supervisor { get; set; }

        public UpdateSupervisorCommand(UpdateSupervisorDTO supervisor)
        {
            Supervisor = supervisor;
        }
    }
}
