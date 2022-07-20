using System.Collections.Generic;

namespace EduHomeFrontToBack25062022.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public List<Category> Category { get; set; }
        public string Desc { get; set; }
    }
}
