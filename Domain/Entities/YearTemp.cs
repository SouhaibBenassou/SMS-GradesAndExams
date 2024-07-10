namespace Domain;

public class YearTemp : AuditableEntity
{
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public Semester Semester { get; set; }
    public bool Current { get; set; }

}
