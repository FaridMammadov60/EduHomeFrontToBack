using System.Collections.Generic;

namespace EduHomeFrontToBack25062022.Models
{
    public class Writer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
