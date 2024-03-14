using E_Learning_Management_System.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace E_Learning_Management_System.DTO
{
    public class InstructorDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InstructorID { get; set; }
        [Required]
        public string  Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(80)]
        public string Email { get; set; }

        [ForeignKey(nameof(Account))]
        public string AccountId { get; set; }
        public virtual Account Account { get; set; }

        public virtual ICollection<CourseDTO> Courses { get; set; }//=new HashSet<Course>();
    }
}
