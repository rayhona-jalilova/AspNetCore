using Microsoft.EntityFrameworkCore;

namespace MyAspNetCoreApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        

    }
}
