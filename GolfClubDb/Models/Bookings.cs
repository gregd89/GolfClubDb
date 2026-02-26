namespace GolfClubDb.Models
{
    public class Bookings
    {
        public int Id { get; set; }
        public DateOnly? TeeDate { get; set; }
        public TimeOnly TeeTime { get; set; }

        // Player 1
        public int? Player1MemberId { get; set; }
        public Member? Player1Member { get; set; }
        //public int? Player1Handicap { get; set; }

        // Player 2
        public int? Player2MemberId { get; set; }
        public Member? Player2Member { get; set; }
        //public int? Player2Handicap { get; set; }

        // Player 3
        public int? Player3MemberId { get; set; }
        public Member? Player3Member { get; set; }
        //public int? Player3Handicap { get; set; }

        // Player 4
        public int? Player4MemberId { get; set; }
        public Member? Player4Member { get; set; }
        //public int? Player4Handicap { get; set; }


    }
}
