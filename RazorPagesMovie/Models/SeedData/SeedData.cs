using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;

namespace RazorPagesMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                if (context == null || context.Movie == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Devs de Elite, O BUG Agora é Outro ",
                        ReleaseDate = DateTime.Parse("2018-2-12"),
                        Genre = "Ação",
                        Price = 7.99M,
                        Rating = "14",
                        duration = DateTime.Parse("02:00:00"),
                    },

                    new Movie
                    {
                        Title = "Delete sem Where",
                        ReleaseDate = DateTime.Parse("2012-3-13"),
                        Genre = "Terror",
                        Price = 8.99M,
                        Rating = "18",
                        duration = DateTime.Parse("02:00:00"),
                    },

                    new Movie
                    {
                        Title = "Um Lindo Código",
                        ReleaseDate = DateTime.Parse("1990-7-27"),
                        Genre = "Romance",
                        Price = 9.99M,
                        Rating = "12",
                        duration = DateTime.Parse("02:00:00")
                    },

                    new Movie
                    {
                        Title = "O Mundial do Palmeiras",
                        ReleaseDate = DateTime.Parse("1951-4-15"),
                        Genre = "Fântasia",
                        Price = 3.99M,
                        Rating = "l",
                        duration = DateTime.Parse("02:00:00"),


                    }
                ); ; ;
                context.SaveChanges();
            }
        }
    }
}