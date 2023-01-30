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
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MembershipType>().HasData(
                new MembershipType { Id = 1, Name = "Free", SignUpFee = 0, DurationInMonths = 0, DiscountRate = 0 },
                new MembershipType { Id = 2, Name = "Basic", SignUpFee = 30, DurationInMonths = 1, DiscountRate = 10 },
                new MembershipType { Id = 3, Name = "Compact", SignUpFee = 90, DurationInMonths = 3, DiscountRate = 15 },
                new MembershipType { Id = 4, Name = "Premium", SignUpFee = 300, DurationInMonths = 12, DiscountRate = 20 }
                );
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Name = "A Perfect Match", Release = DateTime.Parse("1/10/2016"), Stock = 5, GenreId = 6 },
                new Movie { Id = 2, Name = "Jumanji", Release = DateTime.Parse("1/10/2018"), Stock = 4, GenreId = 2 },
                new Movie { Id = 3, Name = "A Resonable Doubt", Release = DateTime.Parse("1/10/2013"), Stock = 55, GenreId = 6 },
                new Movie { Id = 4, Name = "Brown Coffee", Release = DateTime.Parse("1/10/2013"), Stock = 6, GenreId = 6 },
                new Movie { Id = 5, Name = "Most Wanted", Release = DateTime.Parse("1/10/2016"), Stock = 18, GenreId = 1 },
                new Movie { Id = 6, Name = "The Maze Runner", Release = DateTime.Parse("1/10/2018"), Stock = 34, GenreId = 5 },
                new Movie { Id = 7, Name = "Blade Runner", Release = DateTime.Parse("1/10/2017"), Stock = 68, GenreId = 7 },
                new Movie { Id = 8, Name = "13 Hours the Secret Soldier", Release = DateTime.Parse("1/10/2012"), Stock = 6, GenreId = 1 },
                new Movie { Id = 9, Name = "The Matrix Ressurection", Release = DateTime.Parse("1/10/1994"), Stock = 3, GenreId = 1 }
                );
            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 1, Name = "Action" },
                new Genre { Id = 2, Name = "Adventure" },
                new Genre { Id = 3, Name = "Comedy" },
                new Genre { Id = 4, Name = "Drama" },
                new Genre { Id = 5, Name = "Mystery" },
                new Genre { Id = 6, Name = "Romance" },
                new Genre { Id = 7, Name = "Scify" },
                new Genre { Id = 8, Name = "Thriller" }
                );
        }
    }
}
