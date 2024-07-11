namespace Domain.Dtos.ExamDtos
{
    public class GetListSupervisorDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
    }
}
