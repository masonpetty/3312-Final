using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EventManagementPlatform.Models;
using Microsoft.EntityFrameworkCore;

namespace EventManagementPlatform.Pages
{
    public class IndexModel : PageModel
    {
        private readonly EventManagementContext _context;

        public IndexModel(EventManagementContext context)
        {
            _context = context;
        }

        public IList<Event> Events { get; set; }

        public void OnGet()
        {
            Events = _context.Events.ToList();
        }
    }
}
