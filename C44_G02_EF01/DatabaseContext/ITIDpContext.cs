using C44_G02_EF01.Models.MappingByConvention.ITISchemaMapping;
using Microsoft.EntityFrameworkCore;


namespace C44_G02_EF01.DatabaseContext
{
    internal class ITIDpContext : DbContext
    {
        public ITIDpContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = ITI; Trusted_Connection = True; TrustServerCertificate = True");
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Course_Instructor> Course_Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Topic> Topics { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Course_Instructor>()
                .HasKey(ci => new { ci.Course_Id, ci.Inst_Id });

            modelBuilder.Entity<Stud_Course>()
                .HasKey(sc => new { sc.Stud_Id, sc.Course_Id });

        }


    }
}
