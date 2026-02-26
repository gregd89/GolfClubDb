using GolfClubDb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace GolfClubDb.Pages.Members
{
    public class IndexModel : PageModel
    {
        private readonly GolfClubDb.Data.ApplicationDbContext _context;

        public IndexModel(GolfClubDb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Member> Member { get; set; } = new List<Member>();

        // Filter
        [BindProperty(SupportsGet = true)]
        public Gender? GenderFilter { get; set; }

        //Sort
        [BindProperty(SupportsGet = true)]
        public string? SortOrder { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<Member> member = _context.Member;

            // Filtering by Gender
            if (GenderFilter.HasValue)
            {
                member = member.Where(m => m.Gender == GenderFilter.Value);
            }

            // Sorting
            member = SortOrder switch
            {
                "name_desc" => member.OrderByDescending(m => m.Name),
                "name_asc" => member.OrderBy(m => m.Name),
                "handicap_desc" => member.OrderByDescending(m => m.Handicap),
                "handicap_asc" => member.OrderBy(m => m.Handicap),
                _ => member.OrderBy(m => m.Id)

            };

            Member = await member.AsNoTracking().ToListAsync();
            List<Models.Bookings> Bookings = await _context.Bookings
                .Include(b => b.Player1Member)
                .Include(b => b.Player2Member)
                .Include(b => b.Player3Member)
                .Include(b => b.Player4Member)
                .ToListAsync();
        }





    }
}
