using C44_G02_EF01.DatabaseContext;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace C44_G02_EF01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITIDpContext dpContext = new ITIDpContext(); // Open Connection With Database
            ITIDpContext2 dpContext2 = new ITIDpContext2(); // Open Connection With Database
            AirlineDpContext airlineDpContext = new AirlineDpContext(); // Open Connection With Database
            AirlineDpContext2 airlineDpContext2 = new AirlineDpContext2(); // Open Connection With Database
            dpContext.Database.Migrate(); // Create Database If Not Exists
            dpContext2.Database.Migrate(); // Create Database If Not Exists
            airlineDpContext.Database.Migrate(); // Create Database If Not Exists
            airlineDpContext2.Database.Migrate(); // Create Database If Not Exists
        }
    }
}
