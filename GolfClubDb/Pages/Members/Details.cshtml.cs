using GolfClubDb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace GolfClubDb.Pages.Members
{
    public class DetailsModel : PageModel
    {
        private readonly GolfClubDb.Data.ApplicationDbContext _context;

        public DetailsModel(GolfClubDb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Member Member { get; set; } = default!;

        public IList<GolfClubDb.Models.Bookings> RelatedBookings { get; set; } = new List<GolfClubDb.Models.Bookings>();

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var member = await _context.Member.FirstOrDefaultAsync(m => m.Id == id);

            RelatedBookings = await _context.Bookings
                .Include(b => b.Player1Member)
                .Include(b => b.Player2Member)
                .Include(b => b.Player3Member)
                .Include(b => b.Player4Member)
                .Where(b =>
                    b.Player1MemberId == id ||
                    b.Player2MemberId == id ||
                    b.Player3MemberId == id ||
                    b.Player4MemberId == id)
                .AsNoTracking()
                .ToListAsync();

            if (member is not null)
            {
                Member = member;

                return Page();
            }



            return NotFound();
        }

    }
}
