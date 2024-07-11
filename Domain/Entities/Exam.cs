using System.ComponentModel.DataAnnotations.Schema;

namespace Domain;

public class Exam : AuditableEntity
{
    public int Duration { get; set; }
    public TimeOnly StartExam { get; set; }
    public DateOnly Date { get; set; }
    public Guid IdYear { get; set; }
    public ExamType ExamType { get; set; }
    public Guid SessionsExamId { get; set; }
    [ForeignKey("SessionsExamId")]
    public SessionsExam SessionsExam { get; set; }
    public TimeOnly EndExam { get; set; }
    public StatusType Status { get; set; }
}