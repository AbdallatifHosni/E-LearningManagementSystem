using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace E_Learning_Management_System.DTO
{
    public class CertificateDTO
    {
        [Key]
        public int CertificateId { get; set; }
        [Required]
        public DateTime CertificateDate { get; set; }
    }
}
