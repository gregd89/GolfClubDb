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
                .Include(b => b.Player1Member)
                .Include(b => b.Player2Member)
                .Include(b => b.Player3Member)
                .Include(b => b.Player4Member)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
