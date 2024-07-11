namespace Domain.Dtos.ExamDtos
{
    public class GetListSessionsDto
    {
        public Guid Id { get; set; }
        public GetListRoomDto Room { get; set; }
        public TimeOnly Starts { get; set; }
        public TimeOnly Ends { get; set; }
        public GetListSupervisorDto Supervisor { get; set; }
    }
}
