using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace GolfClubDb.Pages.Bookings
{
    public class DeleteModel : PageModel
    {
        private readonly GolfClubDb.Data.ApplicationDbContext _context;

        public DeleteModel(GolfClubDb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public GolfClubDb.Models.Bookings Bookings { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookings = await _context.Bookings.FirstOrDefaultAsync(m => m.Id == id);

            if (bookings is not null)
            {
                Bookings = bookings;

                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookings = await _context.Bookings.FindAsync(id);
            if (bookings != null)
            {
                Bookings = bookings;
                _context.Bookings.Remove(Bookings);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
