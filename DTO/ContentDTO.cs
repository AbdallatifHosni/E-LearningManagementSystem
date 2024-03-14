using System.ComponentModel.DataAnnotations;

namespace E_Learning_Management_System.DTO
{
    public class ContentDTO
    {
        [Key]
        public int ContentId { get; set; }
        [Required]
        public string Contenttype { get; set; }

    }
}
