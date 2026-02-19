using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GolfClubDb.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {
        public DbSet<GolfClubDb.Models.Member> Member { get; set; } = default!;
        public DbSet<GolfClubDb.Models.Bookings> Bookings { get; set; } = default!;
    }
}
