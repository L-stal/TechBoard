using Microsoft.EntityFrameworkCore;
using TechBoard.Models;

namespace TechBoard.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Subject> Subject { get; set; }
        public DbSet<Models.Thread> Thread { get; set; }
        public DbSet<Post> Post { get; set; }
    }
}
