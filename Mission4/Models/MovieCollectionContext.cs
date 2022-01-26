using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class MovieCollectionContext : DbContext
    {
        //constructor
        public MovieCollectionContext(DbContextOptions<MovieCollectionContext> options) : base(options)
        {
            //leave blank for now
        }

        public DbSet<MovieResponse> Responses { get; set; }

        //fulfill req. of at least 3 seeded movies
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieResponse>().HasData(
                new MovieResponse
                {
                    MovieID = 1,
                    Category = "Adventure",
                    Title = "O Brother, Where Art Thou?",
                    Year = "2000",
                    Director = "Joel Coen",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "Best movie ever!"
                },
                new MovieResponse
                {
                    MovieID = 2,
                    Category = "Drama",
                    Title = "About Time",
                    Year = "2013",
                    Director = "Richard Curtis",
                    Rating = "R",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new MovieResponse
                {
                    MovieID = 3,
                    Category = "Biography",
                    Title = "Green Book",
                    Year = "2018",
                    Director = "Peter Farrelly",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                }
            );
        }
    }
}
