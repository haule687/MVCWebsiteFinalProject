using FinalProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace FinalProject.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FinalProjectContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<FinalProjectContext>>()))
            {
                // Look for any movies or book
                if (!context.Movie.Any())
                {
                    context.Movie.AddRange(
                   new Movie
                   {
                       Title = "When Harry Met Sally",
                       ReleaseDate = DateTime.Parse("1989-2-12"),
                       Genre = "Romantic Comedy",
                       Rating = "R",
                       Price = 7.99M
                   },

                   new Movie
                   {
                       Title = "Ghostbusters ",
                       ReleaseDate = DateTime.Parse("1984-3-13"),
                       Genre = "Comedy",
                       Rating = "R",
                       Price = 8.99M
                   },

                   new Movie
                   {
                       Title = "Ghostbusters 2",
                       ReleaseDate = DateTime.Parse("1986-2-23"),
                       Genre = "Comedy",
                       Rating = "R",
                       Price = 9.99M
                   },

                   new Movie
                   {
                       Title = "Rio Bravo",
                       ReleaseDate = DateTime.Parse("1959-4-15"),
                       Genre = "Western",
                       Rating = "R",
                       Price = 3.99M
                   }
               );
                }

               
                if (!context.Book.Any())
                {
                    context.Book.AddRange(
                    new Book
                    {
                        Title = "Long Shadows",
                        Publisher = "Grand Central Publishing",
                        PublicationDate = DateTime.Parse("2022-10-11"),
                        Genre = "Thrillers",
                        Price = 19.99M,
                        Author = "David Baldacci"
                    }
                    );
                }
                context.SaveChanges();
            }
        }
    }
}
