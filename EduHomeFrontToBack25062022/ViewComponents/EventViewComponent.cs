using EduHomeFrontToBack25062022.DAL;
using EduHomeFrontToBack25062022.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFrontToBack25062022.ViewComponents
{
    public class EventViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public EventViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int skip)
        {
            List<Event> events = _context.Events.Skip(skip).Take(4).ToList();
            return View(await Task.FromResult(events));
        }
    }
}
