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
    public class IndexModel : PageModel
    {
        private readonly GolfClubDb.Data.ApplicationDbContext _context;

        public IndexModel(GolfClubDb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Member> Member { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Member = await _context.Member.ToListAsync();
        }
    }
}
