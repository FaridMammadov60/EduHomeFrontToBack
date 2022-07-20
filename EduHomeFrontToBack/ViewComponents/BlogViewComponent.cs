using EduHomeFrontToBack25062022.DAL;
using EduHomeFrontToBack25062022.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFrontToBack25062022.ViewComponents
{
    public class BlogViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public BlogViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int take)
        {

            List<Blog> blog = _context.Blogs.Include(w=>w.Writer).Take(take).ToList();
            return View(await Task.FromResult(blog));
        }
    }
}
