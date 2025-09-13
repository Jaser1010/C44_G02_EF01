using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G02_EF01.Models.MappingByConvention.AirlineSchemaMapping
{
    internal class Emp_Qualification
    {
        // Convention cannot determine a key here without Fluent API.
        public int Emp_Id { get; set; }
        public string? Qualifications { get; set; }
    }
}
