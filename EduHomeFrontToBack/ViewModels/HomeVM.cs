using EduHomeFrontToBack25062022.Models;
using System.Collections.Generic;

namespace EduHomeFrontToBack25062022.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public SliderContent SliderContent { get; set; }
        public List<NoticeLeftSide> NoticeLeftSides { get; set; }
        public List<NoticeRightSide> NoticeRightSides { get; set; }
        public Choose Choose { get; set; }
        public List<Course> Courses { get; set; }
        public List<Category> Categories { get; set; }
        public List<Event> Events { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
