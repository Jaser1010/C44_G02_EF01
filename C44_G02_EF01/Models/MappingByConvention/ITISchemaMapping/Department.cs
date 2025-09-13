using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G02_EF01.Models.MappingByConvention.ITISchemaMapping
{
    internal class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime? Hiring_Date { get; set; }
        public int? Ins_Id { get; set; }
    }
}
