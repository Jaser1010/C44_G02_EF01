using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G02_EF01.Models.MappingByConvention.AirlineSchemaMapping
{
    [Table("Employee")]
    internal class Employee_DA
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Gender { get; set; }
        public string? Position { get; set; }
        public int? BD_Year { get; set; }
        public int? BD_Month { get; set; }
        public int? BD_Day { get; set; }
        public int? AL_id { get; set; }
    }
}
