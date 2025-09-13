using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G02_EF01.Models.MappingByConvention.AirlineSchemaMapping
{
    internal class Aircraft_Route
    {
        // Convention cannot determine a composite key here without Fluent API.
        public int AC_Id { get; set; }
        public int Route_Id { get; set; }
        public DateTime? Departure { get; set; }
        public int? Num_Of_Pass { get; set; }
        public decimal? Price { get; set; }
        public DateTime? Arrival { get; set; }
    }
}
