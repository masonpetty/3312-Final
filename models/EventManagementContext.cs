using Microsoft.EntityFrameworkCore;

namespace EventManagementPlatform.Models
{
    public class EventManagementContext : DbContext
    {
        public EventManagementContext(DbContextOptions<EventManagementContext> options) : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<EventManager> Eventmanagers { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<EventAttendee> EventAttendees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventAttendee>()
                .HasKey(ea => new { ea.EventId, ea.AttendeeId });

            modelBuilder.Entity<EventAttendee>()
                .HasOne(ea => ea.Event)
                .WithMany(e => e.EventAttendees)
                .HasForeignKey(ea => ea.EventId);

            modelBuilder.Entity<EventAttendee>()
                .HasOne(ea => ea.Attendee)
                .WithMany(a => a.EventAttendees)
                .HasForeignKey(ea => ea.AttendeeId);
        }
    }
}
