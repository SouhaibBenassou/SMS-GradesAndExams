using Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain;

public class SessionsExam : AuditableEntity
{
    public Guid IdRoom { get; set; }
    [ForeignKey("IdRoom")]
    public Room Room { get; set; }
    public TimeOnly Starts { get; set; }
    public TimeOnly Ends { get; set; }
    public Exam Exam { get; set; }
    [ForeignKey("IdSupervisor")]
    public Guid IdSupervisor { get; set; }
    public Supervisor Supervisor { get; set; }

}