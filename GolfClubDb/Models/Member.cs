using System.ComponentModel.DataAnnotations;

namespace GolfClubDb.Models
{

    public enum Gender
    {
        Male,
        Female,
        Other
    }

    public class Member
    {
        public int Id { get; set; }

        public String MembershipNumber { get; set; } = string.Empty;
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; } = string.Empty;
        [EmailAddress]
        [Required]
        public string Email { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        [Range(0, 54)]
        [Required]
        public int Handicap { get; set; }

    }
}
