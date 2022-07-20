using EduHomeFrontToBack25062022.Models;
using Microsoft.EntityFrameworkCore;

namespace EduHomeFrontToBack25062022.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderContent> SliderContents { get; set; }
        public DbSet<NoticeLeftSide> NoticeLeftSides { get; set; }
        public DbSet<NoticeRightSide> NoticeRightSides { get; set; }
        public DbSet<Choose> Chooses { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Writer> Writers { get; set; }

    }
}
