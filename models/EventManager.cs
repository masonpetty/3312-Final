namespace EventManagementPlatform.Models
{
    public class EventManager
    {
        public int EventManagerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        // Navigation properties
        public ICollection<Event> Events { get; set; }
    }
}
