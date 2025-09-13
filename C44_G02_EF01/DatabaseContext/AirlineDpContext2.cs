using C44_G02_EF01.Models.MappingByConvention.AirlineSchemaMapping;
using Microsoft.EntityFrameworkCore;


namespace C44_G02_EF01.DatabaseContext
{
    internal class AirlineDpContext2 : DbContext
    {
        public AirlineDpContext2() : base()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = Airline2; Trusted_Connection = True; TrustServerCertificate = True");
        }


        public DbSet<Aircraft_DA> Aircrafts_DA { get; set; }
        public DbSet<Aircraft_Route_DA> Aircraft_Routes_DA { get; set; }
        public DbSet<Airline_DA> Airlines_DA { get; set; }
        public DbSet<Airline_Phone_DA> Airline_Phones_DA { get; set; }
        public DbSet<Emp_Qualification_DA> Emp_Qualifications_DA { get; set; }
        public DbSet<Employee_DA> Employees_DA { get; set; }
        public DbSet<Route_DA> Routes_DA { get; set; }
        public DbSet<Transaction_DA> Transactions_DA { get; set; }
    }
}
