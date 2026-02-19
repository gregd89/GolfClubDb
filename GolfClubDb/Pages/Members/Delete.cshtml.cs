using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GolfClubDb.Data;
using GolfClubDb.Models;

namespace GolfClubDb.Pages.Members
{
    public class DeleteModel : PageModel
    {
        private readonly GolfClubDb.Data.ApplicationDbContext _context;

        public DeleteModel(GolfClubDb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Member Member { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var member = await _context.Member.FirstOrDefaultAsync(m => m.Id == id);

            if (member is not null)
            {
                Member = member;

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

            var member = await _context.Member.FindAsync(id);
            if (member != null)
            {
                Member = member;
                _context.Member.Remove(Member);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
