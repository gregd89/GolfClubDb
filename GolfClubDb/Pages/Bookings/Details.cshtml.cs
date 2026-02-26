using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace GolfClubDb.Pages.Bookings
{
    public class DetailsModel : PageModel
    {
        private readonly GolfClubDb.Data.ApplicationDbContext _context;

        public DetailsModel(GolfClubDb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public GolfClubDb.Models.Bookings Bookings { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookings = await _context.Bookings
                .Include(b => b.Player1Member)
                .Include(b => b.Player2Member)
                .Include(b => b.Player3Member)
                .Include(b => b.Player4Member)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (bookings is not null)
            {
                Bookings = bookings;

                return Page();
            }

            return NotFound();
        }
    }
}
