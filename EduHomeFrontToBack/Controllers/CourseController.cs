using EduHomeFrontToBack25062022.DAL;
using EduHomeFrontToBack25062022.Models;
using EduHomeFrontToBack25062022.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EduHomeFrontToBack25062022.Controllers
{
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;

        public CourseController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Name = "Courses";
            CourseVM courseVM = new CourseVM(); 
            courseVM.Courses=_context.Courses.Include(cat=>cat.Category).ToList();
            courseVM.Categories=_context.Categories.ToList(); 
            return View(courseVM);
        }
    }
}
