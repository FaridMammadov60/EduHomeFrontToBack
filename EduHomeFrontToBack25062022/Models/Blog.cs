using System;

namespace EduHomeFrontToBack25062022.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateTime { get; set; }
        public int CommentCount { get; set; }
        public string ImageUrl { get; set; }
        public Writer Writer { get; set; }
        public int writerId { get; set; }
        
    }
}
