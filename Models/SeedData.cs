using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCMovie.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Aquaman",
                        ReleaseDate = DateTime.Parse("2018-12-21"),
                        Genre = "Action",
                        Actors = "Jason Momoa, Amber Heard",
                        ImdbNote = "6.9/10",
                        MovieDuration = "2h 23min",
                        Price = 10.99M,
                        Rating = "R"
                    },

                    new Movie
                    {
                        Title = "Deadpool 2",
                        ReleaseDate = DateTime.Parse("2018-5-18"),
                        Genre = "Adventure, Comedy",
                        Actors = "Ryan Reynolds, Josh Brolin",
                        ImdbNote = "7.7/10",
                        MovieDuration = "1h 59min",
                        Price = 8.99M,
                        Rating = "R"
                    },

                    new Movie
                    {
                        Title = "Home Alone",
                        ReleaseDate = DateTime.Parse("1990-11-16"),
                        Genre = "Comedy",
                        Actors = "Macaulay Culkin, Joe Pesci",
                        ImdbNote = "7.6/10",
                        MovieDuration = "1h 43min",
                        Price = 6.99M,
                        Rating = "R"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
