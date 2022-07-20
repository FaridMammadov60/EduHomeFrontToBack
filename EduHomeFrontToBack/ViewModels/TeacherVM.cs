using EduHomeFrontToBack25062022.Models;
using System.Collections.Generic;

namespace EduHomeFrontToBack25062022.ViewModels
{
    public class TeacherVM
    {
        public List<Event> Events { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Category> Categories { get; set; }
    }
}
