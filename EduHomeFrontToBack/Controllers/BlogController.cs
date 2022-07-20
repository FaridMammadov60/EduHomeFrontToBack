using EduHomeFrontToBack25062022.DAL;
using EduHomeFrontToBack25062022.Models;
using EduHomeFrontToBack25062022.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EduHomeFrontToBack25062022.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }
      
        public IActionResult Index()
        {
            ViewBag.Name = "Blog";
            BlogVM blogVM = new BlogVM();
            blogVM.Blogs = _context.Blogs.ToList();
            blogVM.Writers = _context.Writers.ToList();
            return View(blogVM);
        }
        public IActionResult Search(string search)
        {
            List<Blog> blogs = new List<Blog>();
            if (search != null)
            {
                blogs = _context.Blogs.Include(w=>w.Writer)
                .OrderBy(b => b.Id)
                .Where(b => b.Name.ToLower()
                .Contains(search.ToLower())
                || b.Writer.FullName.ToLower().Contains(search.ToLower()))
                .Take(5)
                .ToList();
            }
            return PartialView("_SearchBlogPartial", blogs);
        }
    }
}
