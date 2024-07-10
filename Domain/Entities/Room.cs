namespace Domain.Entities
{
    public class Room : AuditableEntity
    {
        public string Capacity { get; set; }
        public RoomType RoomType { get; set; }
        public ICollection<SessionsExam> SessionsExams { get; set; }
    }
}

