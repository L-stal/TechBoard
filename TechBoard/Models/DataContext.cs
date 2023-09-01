using Microsoft.EntityFrameworkCore;
using TechBoard.Models.ViewModels;

namespace TechBoard.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Subject> Subject { get; set; }
        public DbSet<Thread> Thread { get; set; }
        public DbSet<Post> Post { get; set; }

        //Use once to genreate data in DB
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subject>().HasData(new Subject[] {
                new Subject{Id=1, Title="Hardware"},
                new Subject{Id=2, Title="Software"},
                new Subject{Id=3, Title="Games"},
            });
            modelBuilder.Entity<Thread>().HasData(new Thread[] {
                new Thread{Id=1, Heading="GPU", SubjectRefId=1 },
                new Thread{Id=2, Heading="OS", SubjectRefId=2},
                new Thread{Id=3, Heading="WorldOfWarcraft", SubjectRefId=3},
            });
            modelBuilder.Entity<Post>().HasData(new Post[] {
                new Post{Id=1, Title="Nvidia", TextBody="Nvidia blabalbla", UserName="GPUuser", ThreadRefId=1 },
                new Post{Id=2, Title="Windows", TextBody="Windows blabalbla", UserName="OSuser", ThreadRefId=2 },
                new Post{Id=3, Title="Shaman", TextBody="Shaman blabalbla", UserName="WOWuser", ThreadRefId=3 },
            });
        }

        //Use once to genreate data in DB
        public DbSet<TechBoard.Models.ViewModels.ThreadViewModel>? ThreadViewModel { get; set; }
    }
}

