namespace Domain;

public class Grade : AuditableEntity
{
    public Guid Id { get; set; }
    public int Total { get; set; }

}
