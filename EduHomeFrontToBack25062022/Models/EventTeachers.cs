namespace EduHomeFrontToBack25062022.Models
{
    public class EventTeachers
    {
        public int Id { get; set; }
        public int eventId { get; set; }
        public Event Event { get; set; }
        public int teacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
