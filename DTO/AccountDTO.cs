﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Learning_Management_System.DTO
{
    public class AccountDTO
    {
        [Key]
        [EmailAddress]
        public string  AccountAddress  { get; set; }
        [Required]
        public string Accounttype { get; set; }
         //public Learner Learner { get; internal set; }
        // [ForeignKey(nameof(Instructor))]
        // public int InstructorId { get; set; }
        // public  Instructor Instructor { get; set; }
    }
}
