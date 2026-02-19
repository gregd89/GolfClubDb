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
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        public int Handicap { get; set; }

    }
}
