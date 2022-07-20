using System.Collections.Generic;

namespace EduHomeFrontToBack25062022.Models
{
    public class Category
    {
        public int Id { get; set; }
        public int courseId { get; set; }
        public Course Course { get; set; }
        public string Name { get; set; }
        public List<TeacherCategories> TeacherCategories { get; set; }
    }
}
