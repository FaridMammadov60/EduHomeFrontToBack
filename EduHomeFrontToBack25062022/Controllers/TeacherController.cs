using EduHomeFrontToBack25062022.DAL;
using EduHomeFrontToBack25062022.Models;
using EduHomeFrontToBack25062022.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EduHomeFrontToBack25062022.Controllers
{
    public class TeacherController : Controller
    {
        private readonly AppDbContext _context;

        public TeacherController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            @ViewBag.Name = "Our Teachers";
            TeacherVM teacherVM = new TeacherVM();
           teacherVM.Teachers  = _context.Teachers.ToList();
            return View(teacherVM);
        }

        public IActionResult Search(string search)
        {
            List<Teacher> teachers = _context.Teachers
                .OrderBy(t => t.Id)
                .Where(t => t.FullName.ToLower()
                .Contains(search.ToLower())
                || t.Position.ToLower().Contains(search.ToLower()))
                .Take(12)
                .ToList();

            return PartialView("_SearchTeacherPartial", teachers);
        }
    }
}
