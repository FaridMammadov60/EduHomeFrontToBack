using System;
using System.Collections.Generic;

namespace EduHomeFrontToBack25062022.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string imageUrl { get; set; }
        public string Location { get; set; }
        public List<EventTeachers> EventTeachers { get; set; }
    }
}
