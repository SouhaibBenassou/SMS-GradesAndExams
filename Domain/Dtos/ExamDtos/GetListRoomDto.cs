namespace Domain.Dtos.ExamDtos
{
    public class GetListRoomDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Capacity { get; set; }
        public RoomType RoomType { get; set; }
    }
}
