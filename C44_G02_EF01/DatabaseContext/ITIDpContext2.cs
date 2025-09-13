using C44_G02_EF01.Models.MappingByConvention.ITISchemaMapping;
using Microsoft.EntityFrameworkCore;


namespace C44_G02_EF01.DatabaseContext 
{
    internal class ITIDpContext2 : DbContext
    {
        public ITIDpContext2() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = ITI2; Trusted_Connection = True; TrustServerCertificate = True");
        }

        public DbSet<Course_DA> Courses_DA { get; set; }
        public DbSet<Course_Instructor_DA> Course_Instructors_DA { get; set; }
        public DbSet<Department_DA> Departments_DA { get; set; }
        public DbSet<Instructor_DA> Instructors_DA { get; set; }
        public DbSet<Stud_Course_DA> Stud_Courses_DA { get; set; }
        public DbSet<Student_DA> Students_DA { get; set; }
        public DbSet<Topic_DA> Topics_DA { get; set; }
    }
}
