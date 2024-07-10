namespace Domain;

public class RoomTemp : AuditableEntity
{
    public RoomType RoomType { get; set; }
    public int Capacity { get; set; }

}
