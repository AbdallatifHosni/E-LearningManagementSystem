//using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace E_Learning_Management_System.Model
{
    public class Account
    { 
        [Key]
        [EmailAddress]
        public string  AccountAddress  { get; set; }
        [Required]
        public string Accounttype { get; set; }
       // [JsonIgnore]
       
       // public  virtual Learner Learner { get; internal set; }
        // [ForeignKey(nameof(Instructor))]
        // public int InstructorId { get; set; }
        // public  Instructor Instructor { get; set; }
    }
}
