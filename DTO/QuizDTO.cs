using System.ComponentModel.DataAnnotations;

namespace E_Learning_Management_System.DTO
{
    public class QuizDTO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public double Mark { get; set; }
    }
}
