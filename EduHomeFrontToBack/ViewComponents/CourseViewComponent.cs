using EduHomeFrontToBack25062022.DAL;
using EduHomeFrontToBack25062022.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFrontToBack25062022.ViewComponents
{
    public class CourseViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;

        public CourseViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int take)
        {
           
           List<Course> course= _context.Courses.Include(cat => cat.Category).Take(take).ToList();
            return View(await Task.FromResult(course));
        }
    }
}
