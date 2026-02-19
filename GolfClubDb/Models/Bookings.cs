namespace GolfClubDb.Models
{
    public class Bookings
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; }
        public DateOnly TeeDate { get; set; }
        public TimeOnly TeeTime { get; set; }

        // Player 1
        public String Player1Name { get; set; } = string.Empty;
        public int Player1Handicap { get; set; }

        // Player 2
        public String Player2Name { get; set; } = string.Empty;
        public int Player2Handicap { get; set; }

        // Player 3
        public String Player3Name { get; set; } = string.Empty;
        public int Player3Handicap { get; set; }

        // Player 4
        public String Player4Name { get; set; } = string.Empty;
        public int Player4Handicap { get; set; }

    }
}
