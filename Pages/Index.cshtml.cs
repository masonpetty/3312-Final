using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EventManagementPlatform.Models;
using Microsoft.EntityFrameworkCore;

namespace _3312_Final.Pages
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
