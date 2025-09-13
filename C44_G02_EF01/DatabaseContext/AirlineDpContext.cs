using C44_G02_EF01.Models.MappingByConvention.AirlineSchemaMapping;
using Microsoft.EntityFrameworkCore;


namespace C44_G02_EF01.DatabaseContext
{
    internal class AirlineDpContext : DbContext
    {
        public AirlineDpContext() : base()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = Airline; Trusted_Connection = True; TrustServerCertificate = True");
        }
        public DbSet<Aircraft> Aircrafts { get; set; }
        public DbSet<Aircraft_Route> Aircraft_Routes { get; set; }
        public DbSet<Airline> Airlines { get; set; }
        public DbSet<Airline_Phone> Airline_Phones { get; set; }
        public DbSet<Emp_Qualification> Emp_Qualifications { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Transaction> Transactions { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aircraft_Route>().HasKey(ar => new { ar.AC_Id, ar.Route_Id });
            modelBuilder.Entity<Airline_Phone>().HasKey(ap => new { ap.AL_Id, ap.Phones });
            modelBuilder.Entity<Emp_Qualification>().HasKey(eq => new { eq.Emp_Id, eq.Qualifications });
        }

        }
}
