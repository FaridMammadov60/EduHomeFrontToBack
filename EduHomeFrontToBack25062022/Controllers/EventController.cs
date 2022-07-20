using EduHomeFrontToBack25062022.DAL;
using EduHomeFrontToBack25062022.Models;
using EduHomeFrontToBack25062022.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EduHomeFrontToBack25062022.Controllers
{
    public class EventController : Controller
    {
        private readonly AppDbContext _context;

        public EventController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Name = "EVENT";
            EventVM eventVM = new EventVM();
            eventVM.Events = _context.Events.ToList();
            return View(eventVM);
        }

        public IActionResult Detail(int id)
        {
            ViewBag.Name = "EVENT";

            

            if (id==null)
            {
                return NotFound();
            }
            Event dbEvent = _context.Events
                .Include(et => et.EventTeachers)
                .ThenInclude(t => t.Teacher)
                .FirstOrDefault(n=>n.Id==id);
            return View(dbEvent);
        }
    }
}
