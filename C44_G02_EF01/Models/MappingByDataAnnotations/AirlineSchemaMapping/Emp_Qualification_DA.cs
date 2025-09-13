using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G02_EF01.Models.MappingByConvention.AirlineSchemaMapping
{
    [Table("Emp_Qualifications")]
    internal class Emp_Qualification_DA
    {
        [Key]
        public int Emp_Id { get; set; }
        public string? Qualifications { get; set; }
    }
}
