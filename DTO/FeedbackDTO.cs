using System.ComponentModel.DataAnnotations;

namespace E_Learning_Management_System.DTO
{
    public class FeedbackDTO
    {
        [Key]
        public int FeedbackId { get; set; }
        [Required]
        public int QuizID { get; set; }

    }
}
