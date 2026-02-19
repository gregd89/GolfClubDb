using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GolfClubDb.Pages.Bookings
{
    public class CreateModel : PageModel
    {
        private readonly GolfClubDb.Data.ApplicationDbContext _context;

        public CreateModel(GolfClubDb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["MemberId"] = new SelectList(_context.Member, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public GolfClubDb.Models.Bookings Bookings { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Bookings.Add(Bookings);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
