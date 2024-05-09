using Microsoft.EntityFrameworkCore;

namespace EventManagementPlatform.Models
{
    public class EventManagementContext : DbContext
    {
        public EventManagementContext(DbContextOptions<EventManagementContext> options) : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<EventManager> Eventmanagers  { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
    }
}
