using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G02_EF01.Models.MappingByConvention.ITISchemaMapping
{
    [Table("Stud_Course")]
    [PrimaryKey("Stud_Id", "Course_Id")]
    internal class Stud_Course_DA
    {
        public int Stud_Id { get; set; }
        public int Course_Id { get; set; }
        public int? Grade { get; set; }
    }
}
