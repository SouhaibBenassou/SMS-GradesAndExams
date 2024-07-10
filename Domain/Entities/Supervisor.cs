using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Supervisor : AuditableEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public Guid ExamId { get; set; }
        [ForeignKey("ExamId")]
        public Exam Exam { get; set; }
        public Guid? RoomId { get; set; }
        [ForeignKey("RoomId")]
        public Room Room { get; set; }
    }
}
