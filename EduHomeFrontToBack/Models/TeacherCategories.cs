namespace EduHomeFrontToBack25062022.Models
{
    public class TeacherCategories
    {
        public int Id { get; set; }
        public int teacherId { get; set; }
        public Teacher Teacher { get; set; }
        public int categoryId { get; set; }
        public Category Category { get; set; }
    }
}
