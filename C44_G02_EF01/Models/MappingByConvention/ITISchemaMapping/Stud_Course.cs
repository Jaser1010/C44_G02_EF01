using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G02_EF01.Models.MappingByConvention.ITISchemaMapping
{
    internal class Stud_Course
    {
        public int Stud_Id { get; set; }
        public int Course_Id { get; set; }
        public int? Grade { get; set; }
    }
}
