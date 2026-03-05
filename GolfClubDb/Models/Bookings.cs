using System.ComponentModel.DataAnnotations;

namespace GolfClubDb.Models
{
    public class Bookings
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Tee Date is required.")]
        public DateOnly? TeeDate { get; set; }
        [Required(ErrorMessage = "Tee Time is required.")]
        public TimeOnly TeeTime { get; set; }

        // Player 1
        [Required(ErrorMessage = "Player 1 is required.")]
        public int? Player1MemberId { get; set; }
        public Member? Player1Member { get; set; }


        // Player 2
        public int? Player2MemberId { get; set; }
        public Member? Player2Member { get; set; }


        // Player 3
        public int? Player3MemberId { get; set; }
        public Member? Player3Member { get; set; }


        // Player 4
        public int? Player4MemberId { get; set; }
        public Member? Player4Member { get; set; }



    }
}
