using E_Learning_Management_System.Model;
using Microsoft.EntityFrameworkCore;

namespace E_Learning_Management_System.Data
{
    public class ApplicatioDbContext:DbContext
    {
        public ApplicatioDbContext(DbContextOptions options )
            :base(options)
        {
                
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder )
        {
            //modelBuilder.Entity<Account>()
            //    .HasOne(E => E.Learner)
            //    .WithOne(e => e.account)
            //    .HasForeignKey<Account>(e => e.);




        }
        /// <summary>
        /// ////////////////////////////////////////////////////////////////////
        /// </summary>
        public virtual DbSet<Account>  Accounts{ get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public  virtual DbSet<Administrator> Administrators { get; set; }
        public virtual DbSet<Certificate> Certificates { get; set; }
        public virtual DbSet<Fees> Fees { get; set; }
        public virtual DbSet<Quiz> Quizzes  { get; set; }
        public DbSet<Course> Course { get; set; } 
        public DbSet<Duration> Duration { get; set; } 
        public DbSet<Content> Content { get; set; } 
        public DbSet<Learner> Learner { get; set; } 
        public DbSet<Feedback> Feedbacks { get; set; }


    }
}
