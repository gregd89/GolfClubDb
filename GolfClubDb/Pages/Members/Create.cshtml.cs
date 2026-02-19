using GolfClubDb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GolfClubDb.Pages.Members
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
            GenderSelectList = new SelectList(Enum.GetValues(typeof(Gender)));
            return Page();
        }

        [BindProperty]
        public Member Member { get; set; } = default!;

        public SelectList GenderSelectList { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                GenderSelectList = new SelectList(Enum.GetValues(typeof(Gender)));
                return Page();
            }

            _context.Member.Add(Member);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
