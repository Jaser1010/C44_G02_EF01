using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G02_EF01.Models.MappingByConvention.ITISchemaMapping
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public decimal? Bouns { get; set; }
        public decimal? Salary { get; set; }
        public decimal? Hour_Rate { get; set; }
        public int? Dep_Id { get; set; }
    }
}
