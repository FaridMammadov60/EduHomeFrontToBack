using System.Collections.Generic;

namespace EduHomeFrontToBack25062022.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public string ImageUrl { get; set; }
        public List<EventTeachers> EventTeachers { get; set; }
        public List<TeacherCategories> TeacherCategories { get; set; }

    }
}
