using System;
using System.Collections.Generic;

namespace EventManagementPlatform.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
       
        // Navigation properties
        public ICollection<EventAttendee> EventAttendees { get; set; }
    }
}
