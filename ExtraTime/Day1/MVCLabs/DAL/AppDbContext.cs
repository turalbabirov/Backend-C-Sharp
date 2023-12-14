using Microsoft.EntityFrameworkCore;
using MVCLabs.Models;

namespace MVCLabs.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<Slider> Sliders { get; set; }
    }
}
