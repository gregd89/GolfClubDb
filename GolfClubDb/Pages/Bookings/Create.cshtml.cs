using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GolfClubDb.Pages.Bookings
{
    public class CreateModel : PageModel
    {
        private readonly GolfClubDb.Data.ApplicationDbContext _context;

        // Constructor to inject the ApplicationDbContext
        public CreateModel(GolfClubDb.Data.ApplicationDbContext context)
        {
            _context = context;
        }


        // GET handler to display the create page
        public IActionResult OnGet()
        {
            ViewData["MemberId"] = new SelectList(_context.Member, "Id", "Id");
            TimeOptions = GenerateTimeOptions();
            return Page();
        }



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

        // BindProperty to bind the form data for the booking date
        [BindProperty]
        public DateOnly? BookingDate { get; set; }

        // BindProperty to bind the form data to the Bookings model
        [BindProperty]
        public GolfClubDb.Models.Bookings Bookings { get; set; } = default!;


        // List of time options for the booking
        public List<SelectListItem> TimeOptions { get; set; } = new();

        // Method to generate time options in 15-minute intervals from 9:00 to 18:00
        private List<SelectListItem> GenerateTimeOptions()
        {
            var items = new List<SelectListItem>();
            var start = new TimeOnly(9, 0);
            var end = new TimeOnly(18, 0);

            for (var s = start; s <= end; s = s.AddMinutes(15))
            {
                var label = s.ToString("HH:mm");
                items.Add(new SelectListItem { Value = label, Text = label });

            }

            return items;
        }


    }
}
