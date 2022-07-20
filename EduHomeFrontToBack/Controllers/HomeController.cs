using EduHomeFrontToBack25062022.DAL;
using EduHomeFrontToBack25062022.Models;
using EduHomeFrontToBack25062022.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace EduHomeFrontToBack25062022.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.Sliders = _context.Sliders.ToList();
            homeVM.SliderContent = _context.SliderContents.FirstOrDefault();
            homeVM.NoticeLeftSides= _context.NoticeLeftSides.ToList();
            homeVM.NoticeRightSides= _context.NoticeRightSides.ToList();
            homeVM.Choose = _context.Chooses.FirstOrDefault();
            return View(homeVM);
        }
        public IActionResult Search(string search)
        {
           List<Course> courses =  new List<Course>();   
            if (search != null)
            {
                courses = _context.Courses
                .OrderBy(c => c.Id)
                .Where(c => c.Name.ToLower()
                .Contains(search.ToLower()))
                .Take(5)
                .ToList();
            }
            //return Content("Ok");
            return PartialView("_SearchCoursePartial", courses);
        }

    }
}
