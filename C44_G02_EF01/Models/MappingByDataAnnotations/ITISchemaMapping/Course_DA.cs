using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G02_EF01.Models.MappingByConvention.ITISchemaMapping
{
    [Table("Courses")]
    internal class Course_DA
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Duration { get; set; }
        public string? Description { get; set; }
        public int? top_Id { get; set; }
    }
}
