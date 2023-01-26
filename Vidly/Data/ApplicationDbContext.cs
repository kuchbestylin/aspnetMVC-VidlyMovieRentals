using Microsoft.EntityFrameworkCore;
using Vidly.Models;

namespace Vidly.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MembershipType>().HasData(
                new MembershipType { Id = 1, Name = "Free", SignUpFee = 0, DurationInMonths = 0, DiscountRate = 0 },
                new MembershipType { Id = 2, Name = "Basic", SignUpFee = 30, DurationInMonths = 1, DiscountRate = 10 },
                new MembershipType { Id = 3, Name = "Compact", SignUpFee = 90, DurationInMonths = 3, DiscountRate = 15 },
                new MembershipType { Id = 4, Name = "Premium", SignUpFee = 300, DurationInMonths = 12, DiscountRate = 20 }
                );
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Name = "A Perfect Match", Genre = "Romance", Release = DateTime.Parse("1/10/2016"), Stock = 5, Added = DateTime.Now },
                new Movie { Id = 2, Name = "Jumanji", Genre = "Adventure", Release = DateTime.Parse("1/10/2018"), Stock = 4, Added = DateTime.Now },
                new Movie { Id = 3, Name = "A Resonable Doubt", Genre = "Mistery", Release = DateTime.Parse("1/10/2013"), Stock = 55, Added = DateTime.Now },
                new Movie { Id = 4, Name = "Brown Coffee", Genre = "Romance", Release = DateTime.Parse("1/10/2013"), Stock = 6, Added = DateTime.Now },
                new Movie { Id = 5, Name = "Most Wanted", Genre = "Thriller", Release = DateTime.Parse("1/10/2016"), Stock = 18, Added = DateTime.Now },
                new Movie { Id = 6, Name = "The Maze Runner", Genre = "Thriller", Release = DateTime.Parse("1/10/2018"), Stock = 34, Added = DateTime.Now },
                new Movie { Id = 7, Name = "Blade Runner", Genre = "Scify", Release = DateTime.Parse("1/10/2017"), Stock = 68, Added = DateTime.Now },
                new Movie { Id = 8, Name = "13 Hours the Secret Soldier", Genre = "Action", Release = DateTime.Parse("1/10/2012"), Stock = 6, Added = DateTime.Now },
                new Movie { Id = 9, Name = "The Matrix Ressurection", Genre = "Action", Release = DateTime.Parse("1/10/1994"), Stock = 3, Added = DateTime.Now }
                );
        }
    }
}
