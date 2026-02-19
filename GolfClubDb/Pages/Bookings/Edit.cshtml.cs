using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace GolfClubDb.Pages.Bookings
{
    public class EditModel : PageModel
    {
        private readonly GolfClubDb.Data.ApplicationDbContext _context;

        public EditModel(GolfClubDb.Data.ApplicationDbContext context)
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
            if (bookings == null)
            {
                return NotFound();
            }
            Bookings = bookings;
            ViewData["MemberId"] = new SelectList(_context.Member, "Id", "Id");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Bookings).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookingsExists(Bookings.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool BookingsExists(int id)
        {
            return _context.Bookings.Any(e => e.Id == id);
        }
    }
}
