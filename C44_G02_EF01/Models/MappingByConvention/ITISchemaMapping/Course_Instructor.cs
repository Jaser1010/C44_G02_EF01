using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G02_EF01.Models.MappingByConvention.ITISchemaMapping
{
    internal class Course_Instructor
    {
        public int Course_Id { get; set; }
        public int Inst_Id { get; set; }
        public string? Evaluation { get; set; }
    }
}
