namespace EventManagementPlatform.Models
{
    public class Attendee
    {
        public int AttendeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
       
        // Navigation properties
        public ICollection<EventAttendee> EventAttendees { get; set; }
    }
}

