namespace Domain.Dtos.ExamDtos
{
    public class GetListExamDto
    {
        public Guid Id { get; set; }
        public int? Duration { get; set; }
        public DateOnly Date { get; set; }
        public Guid IdYear { get; set; }
        public ExamType ExamType { get; set; }
        public GetListSessionsDto SessionsExam { get; set; }
        public TimeOnly EndExam { get; set; }
        public StatusType Status { get; set; }
    }
}
