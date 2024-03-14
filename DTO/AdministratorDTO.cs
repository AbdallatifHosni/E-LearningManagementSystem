using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Learning_Management_System.DTO
{
    public class AdministratorDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AdminID { get; set; }
        [Required]
        public string AdminName { get; set; }
       


    }
}
