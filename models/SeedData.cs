using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace EventManagementPlatform.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new EventManagementContext(
                serviceProvider.GetRequiredService<DbContextOptions<EventManagementContext>>()))
            {
                // Ensure the database is created
                context.Database.EnsureCreated();

                // Look for any events
                if (context.Events.Any())
                {
                    return;   // DB has been seeded
                }

                context.Events.AddRange(
                    new Event
                    {
                        Name = "Conference",
                        Description = "Annual Conference",
                        StartTime = DateTime.Parse("2024-06-01"),
                        EndTime = DateTime.Parse("2024-06-03"),
                    },
                    new Event
                    {
                        Name = "Workshop",
                        Description = "Hands-on Workshop",
                        StartTime = DateTime.Parse("2024-06-05"),
                        EndTime = DateTime.Parse("2024-06-07"),
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
