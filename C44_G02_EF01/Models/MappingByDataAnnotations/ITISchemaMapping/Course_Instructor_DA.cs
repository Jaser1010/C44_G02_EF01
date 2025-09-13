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
    [Table("Course_Instructor")]
    [PrimaryKey("Course_Id", "Inst_Id")]
    internal class Course_Instructor_DA
    {
        public int Course_Id { get; set; }
        public int Inst_Id { get; set; }
        public string? Evaluation { get; set; }
    }
}
