using Microsoft.EntityFrameworkCore;

namespace MovieList.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        { }

        //Parameterless constuctor for design-time for EF Core Migrations
        public MovieContext() { }

        public DbSet<Movie> Movies { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        if (!optionsBuilder.IsConfigured)
        optionsBuilder.UseSqlite("Data Source=app.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                new Genre {
                    GenreId = 1, 
                    Name = "Action"
                },
                new Genre {
                    GenreId = 2,
                    Name = "Comedy"
                },
                new Genre {
                    GenreId = 3,
                    Name = "Drama"
                },
                new Genre {
                    GenreId = 4,
                    Name = "Horror"
                },
                new Genre {
                    GenreId = 5,
                    Name = "Musical"
                },
                new Genre {
                    GenreId = 6,
                    Name = "RomCom"
                },
                new Genre {
                    GenreId = 7,
                    Name = "SciFi"
                }


            );

            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    MovieId = 1,
                    Name = "Casablanca",
                    Year = 1942,
                    Rating = 5,
                    GenreId = 3
                },
                new Movie
                {
                    MovieId = 2,
                    Name = "Wonder Woman",
                    Year = 2017,
                    Rating = 3,
                    GenreId = 1
                },
                new Movie
                {
                    MovieId = 3,
                    Name = "Moonstruck",
                    Year = 1988,
                    Rating = 4,
                    GenreId = 6
                }
            );

        }
    }
}
