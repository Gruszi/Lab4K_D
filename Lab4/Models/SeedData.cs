using K_DLab4.Data;
using K_DLab4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new K_DLab4Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<K_DLab4Context>>()))
            {
                // Look for any movies.
                if (context.Song.Any())
                {
                    return;   // DB has been seeded
                }

                context.Song.AddRange(
                    new Song
                    {
                        addDate = DateTime.Parse("1984-3-13"),
                        Author = "Franek Kimono",
                        Kind = "Dance",
                        Title = "King Bruce Lee - Karate mistrz"
                    },

                    new Song
                    {
                        addDate = DateTime.Parse("2008-3-13"),
                        Author = "Green Day",
                        Kind = "Rock",
                        Title = "American Idiot"
                    },

                    new Song
                    {
                        addDate = DateTime.Parse("1999-12-17"),
                        Author = "Metallica",
                        Kind = "Dance",
                        Title = "Nothing else mathers"
                    },

                    new Song
                    {
                        addDate = DateTime.Parse("2006-7-22"),
                        Author = "Dzem",
                        Kind = "Ballada",
                        Title = "Wisky moja zono"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}