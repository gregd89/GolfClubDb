using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace GolfClubDb.Pages.Bookings
{
    public class IndexModel : PageModel
    {
        private readonly GolfClubDb.Data.ApplicationDbContext _context;

        public IndexModel(GolfClubDb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<GolfClubDb.Models.Bookings> Bookings { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Bookings = await _context.Bookings
                .Include(b => b.Member).ToListAsync();
        }
    }
}
