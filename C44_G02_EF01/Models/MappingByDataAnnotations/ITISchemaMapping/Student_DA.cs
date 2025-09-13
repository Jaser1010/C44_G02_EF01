using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G02_EF01.Models.MappingByConvention.ITISchemaMapping
{
    [Table("Students")]
    internal class Student_DA
    {
        [Key]
        public int Id { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }
        public int? Age { get; set; }
        public string? Address { get; set; }
        public int? Dep_Id { get; set; }
    }
}
